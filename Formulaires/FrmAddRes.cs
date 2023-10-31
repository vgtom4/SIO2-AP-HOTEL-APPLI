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
        List<chambre> lesChambresDisponibles = new List<chambre>();
        private FrmReservation frmBase = Application.OpenForms.OfType<FrmReservation>().FirstOrDefault();

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
            frmBase.RefreshChambre(listChambre, DateDebut.Value, DateFin.Value);

            lblChambreDispo.Text = listChambre.Items.Count > 0 ? "Chambres disponibles :" : "Aucune chambre disponible";
            lblChambreDispo.ForeColor = listChambre.Items.Count > 0 ? DefaultForeColor : System.Drawing.Color.DarkRed;
        }

        // Permet d'ajouter une réservation à l'hôtel connecté
        private void btnAddRes_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            if (varglobale.hotel != null)
            {
                if (DataIsCorrect())
                {
                    reservation nouvelleReservation = new reservation();
                    nouvelleReservation.nores = varglobale.hotel.reservation.Count > 0 ? varglobale.hotel.reservation.Max(res => res.nores) + 1 : 1;
                    nouvelleReservation.datedeb = DateDebut.Value;
                    nouvelleReservation.datefin = DateFin.Value;
                    //nouvelleReservation.datedeb = new DateTime(DateDebut.Value.Year, DateDebut.Value.Month, DateDebut.Value.Day, TimeDebut.Value.Hour, TimeDebut.Value.Minute, TimeDebut.Value.Second);
                    //nouvelleReservation.datefin = new DateTime(DateFin.Value.Year, DateFin.Value.Month, DateFin.Value.Day, TimeFin.Value.Hour, TimeFin.Value.Minute, TimeFin.Value.Second);
                    nouvelleReservation.nom = txtNom.Text;
                    nouvelleReservation.email = txtMail.Text;

                    nouvelleReservation.chambre = listChambre.CheckedItems.Cast<string>().Select(itemList => varglobale.hotel.chambre.Where(chambre => chambre.nochambre == int.Parse(itemList.ToString().Substring(2))).FirstOrDefault()).ToList();
                    // ajout des chambres sélectionnées à la réservation
                    //foreach (var chambre in listChambre.CheckedItems)
                    //{
                    //    nouvelleReservation.chambre.Add(lesChambresDisponibles.Where(c => c.nochambre == int.Parse(chambre.ToString().Substring(2))).FirstOrDefault());
                    //}

                    nouvelleReservation.codeacces = new Random().Next(10000, 99999);
                    varglobale.hotel.reservation.Add(nouvelleReservation);
                    varglobale.connexion.SaveChanges();
                    lblInfo.Text = "Réservation enregistrée";
                    txtMail.Text = "";
                    txtNom.Text = "";
                    frmBase.RefreshForms();
                }
            }
        }

        private void DateDebut_ValueChanged(object sender, EventArgs e)
        {
            if (DateDebut.Value < DateTime.Now)
            {
                DateDebut.Value = DateTime.Now;
            }
            if (DateDebut.Value > DateFin.Value)
            {
                DateFin.Value = DateDebut.Value;
            }
            frmBase.RefreshForms();
        }

        private void DateFin_ValueChanged(object sender, EventArgs e)
        {
            if (DateDebut.Value > DateFin.Value)
            {
                DateDebut.Value = DateFin.Value;
            }
            frmBase.RefreshForms();
        }

        List<ErrorProvider> listErrorProviders = new List<ErrorProvider>();
        public bool DataIsCorrect()
        {
            Utils.RemoveErrorsProvider(listErrorProviders);

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

            if (listChambre.CheckedItems.Count == 0) 
            { 
                invalidControls.Add(listChambre, "Au moins 1 chambre doit être sélectionnée.");
            }

            Utils.SetErrorProviders(listErrorProviders, invalidControls);

            return !invalidControls.Any();
        }
    }
}