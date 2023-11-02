using AP_HOTEL_APPLI.ClasseTechniques;
using AP_HOTEL_APPLI.EntityModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AP_HOTEL_APPLI
{
    public partial class FrmAddRes : Form
    {
        private List<chambre> lesChambresDisponibles = new List<chambre>();
        private readonly FrmReservation frmBase = Application.OpenForms.OfType<FrmReservation>().FirstOrDefault();

        public FrmAddRes()
        {
            InitializeComponent();
        }

        private void FrmAddRes_Load(object sender, EventArgs e)
        {
            // date du jour pour le calendrier
            DateDebut.Value = DateTime.Now;
            DateFin.Value = DateTime.Now;
        }

        /// <summary>
        /// Permet de rafraichir la liste des chambres disponibles
        /// </summary>
        public void RefreshForm()
        {
            try {
                frmBase.RefreshChambre(listChambre, DateDebut.Value, DateFin.Value);

                lblChambreDispo.Text = listChambre.Items.Count > 0 ? "Chambres disponibles :" : "Aucune chambre disponible";
                lblChambreDispo.ForeColor = listChambre.Items.Count > 0 ? System.Drawing.Color.White : System.Drawing.Color.FromArgb(179, 25, 32);
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
            }
        }

        // Permet d'ajouter une réservation à l'hôtel connecté
        private void btnAddRes_Click(object sender, EventArgs e)
        {
            try {
                lblInfo.Text = "";
                if (Utils.HotelIsConnected() && DataIsCorrect())
                {
                    // On crée une nouvelle réservation
                    reservation nouvelleReservation = new reservation() { 
                        nores = varglobale.hotel.reservation.Count > 0 ? varglobale.hotel.reservation.Max(res => res.nores) + 1 : 1,
                        datedeb = DateDebut.Value,
                        datefin = DateFin.Value,
                        nom = txtNom.Text,
                        email = txtMail.Text,
                        // On récupère les chambres cochées dans la liste des chambres
                        chambre = listChambre.CheckedItems.Cast<string>().Select(itemList => varglobale.hotel.chambre.Where(chambre => chambre.nochambre == int.Parse(itemList.ToString().Substring(2))).FirstOrDefault()).ToList(),
                        codeacces = new Random().Next(10000, 99999)
                    };

                    // On ajoute la réservation à l'hôtel connecté et on sauvegarde les changements
                    varglobale.hotel.reservation.Add(nouvelleReservation);
                    varglobale.connexion.SaveChanges();
                    lblInfo.Text = "Réservation enregistrée";
                    txtMail.Text = "";
                    txtNom.Text = "";
                    frmBase.RefreshReservationForms();
                }
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
            }
        }

        // Permet d'actualiser la liste des chambres disponibles en fonction des dates sélectionnées
        private void DateDebut_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                // Permet de ne pas sélectionner une date antérieure à la date du jour
                if (DateDebut.Value < DateTime.Now)
                {
                    DateDebut.Value = DateTime.Now;
                }
                // Permet d'ajuster la date de fin si elle est antérieure à la date de début
                if (DateDebut.Value > DateFin.Value)
                {
                    DateFin.Value = DateDebut.Value;
                }
                frmBase.RefreshReservationForms();
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
            }
        }

        // Permet d'actualiser la liste des chambres disponibles en fonction des dates sélectionnées
        private void DateFin_ValueChanged(object sender, EventArgs e)
        {
            try {
                // Permet d'ajuster la date de début si elle est postérieure à la date de fin
                if (DateDebut.Value > DateFin.Value)
                {
                    DateDebut.Value = DateFin.Value;
                }
                frmBase.RefreshReservationForms();
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
            }
        }

        readonly List<ErrorProvider> listErrorProviders = new List<ErrorProvider>();
        /// <summary>
        /// Vérifie que les données saisies sont correctes
        /// </summary>
        /// <returns>true, si les données saisies sont correctes. Sinon, false</returns>
        public bool DataIsCorrect()
        {
            try {
                Utils.RemoveErrorProviders(listErrorProviders);

                // Liste des contrôles invalide
                Dictionary<Control, string> invalidControls = new Dictionary<Control, string>();

                foreach (Control RTB in Controls.OfType<TextBoxBase>())
                {
                    // Si le contrôle est vide et n'est pas dans la liste des contrôles à ignorer
                    if (RTB.Text == "")
                    {
                        // Ajoutez le contrôle à la liste des contrôles invalides
                        invalidControls.Add(RTB, "Veuillez remplir ce champ.");
                    }
                }
                // Si aucune chambre n'est sélectionnée
                if (listChambre.CheckedItems.Count == 0) 
                { 
                    invalidControls.Add(listChambre, "Au moins 1 chambre doit être sélectionnée.");
                }

                Utils.SetErrorProviders(listErrorProviders, invalidControls);

                return !invalidControls.Any();
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
                return false;
            }
        }
    }
}