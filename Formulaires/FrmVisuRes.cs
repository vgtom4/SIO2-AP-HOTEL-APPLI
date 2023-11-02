using AP_HOTEL_APPLI.ClasseTechniques;
using AP_HOTEL_APPLI.EntityModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AP_HOTEL_APPLI
{
    public partial class FrmVisuRes : Form
    {
        private FrmReservation frmBase = Application.OpenForms.OfType<FrmReservation>().FirstOrDefault();
        List<reservation> lesReservations = new List<reservation>();
        reservation lareservation;

        public FrmVisuRes()
        {
            InitializeComponent();
        }

        private void FrmVisuRes_Load(object sender, EventArgs e)
        {
            SwitchEditMode(false);

            // date du jour pour le calendrier
            DateDebut.Value = DateTime.Now;
        }

        /// <summary>
        /// Permet d'actualiser les informations du formulaire
        /// </summary>
        public void RefreshForm()
        {
            try {
                RefreshLesReservations();
                rtbInfoRes.Visible = lesReservations.Any();
                if (!lesReservations.Any()) listChambre.Items.Clear();
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
            }
        }

        /// <summary>
        /// Permet d'actualiser la liste des réservations
        /// </summary>
        public void RefreshLesReservations()
        {
            try {
                lesReservations.Clear();
                lesReservations = ReservationDAO.GetLesReservationsDate(DateDebut.Value);
                ShowRes(lesReservations);
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
            }
        }

        /// <summary>
        /// Permet d'afficher les réservations de la liste de réservations du paramètre dans la combobox des réservations
        /// </summary>
        /// <param name="lesRes">Listes des réservations à afficher dans la ComboBox</param>
        private void ShowRes(List<reservation> lesRes)
        {
            try {
                cboRes.Items.Clear();
                foreach (reservation reservation in lesRes)
                {
                    cboRes.Items.Add($"n°{reservation.nores}");
                }

                // si il y a des réservations, on sélectionne la première et on affiche les informations
                if (cboRes.Items.Count > 0)
                {
                    cboRes.SelectedIndex = 0;
                    SwitchEditMode(false);
                    panelEditBtn.Visible = true;
                    cboRes.Visible = true;
                    lblLesRes.Visible = true;
                    lblChambreDispo.Visible = true;
                    listChambre.Visible = true;
                }

                // sinon on cache les informations
                else
                {
                    panelEditBtn.Visible = false;
                    cboRes.Visible = false;
                    lblLesRes.Visible = false;
                    lblChambreDispo.Visible = false;
                    listChambre.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
            }
        }

        /// <summary>
        /// Permet de changer le mode d'édition
        /// </summary>
        /// <param name="editMode"></param>
        public void SwitchEditMode(bool editMode)
        {
            listChambre.Enabled = editMode;
            btnEdit.Visible = !editMode;
            btnSave.Visible = editMode;
            btnCancel.Visible = editMode;
        }

        private void DateDebut_ValueChanged(object sender, EventArgs e)
        {
            RefreshForm();
        }

        // Permet d'affichger les informations de la réservation sélectionnée
        private void cboRes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                errorProvider.Clear();
                // on récupére les informations de la réservation sélectionnée
                lareservation = varglobale.hotel.reservation.Where(reservation => reservation == lesReservations[cboRes.SelectedIndex]).FirstOrDefault();
                frmBase.RefreshChambre(listChambre, DateDebut.Value, DateDebut.Value, lareservation);
                rtbInfoRes.Text =
                            "Résumé de la réservation\n\n" +
                            $"N°{lareservation.nores}\n" +
                            $"Nom : {lareservation.nom}\n" +
                            $"Email : {lareservation.email}\n" +
                            $"Début : {lareservation.datedeb.Value:dddd d MMMM HH'h'mm}\n" +
                            $"Fin : {lareservation.datefin.Value:dddd d MMMM HH'h'mm}\n" +
                            $"Code d'accès : {lareservation.codeacces}";
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Utils.HotelIsConnected())
            {
                SwitchEditMode(true);
            }
        }

        // Permet de sauvegarder les modifications de la réservation sélectionnée dans la base de données
        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                errorProvider.Clear();
                if (Utils.HotelIsConnected())
                {
                    if (listChambre.CheckedItems.Count > 0)
                    {
                        List<chambre> lesChambres = new List<chambre>();
                        // Pour chaque chambre cochée, on l'ajoute à la liste des chambres de la réservation sélectionnée dans la base de données
                        foreach (var item in listChambre.CheckedItems)
                        {
                            lesChambres.Add(varglobale.hotel.chambre.Where(chambre => chambre.nochambre == int.Parse(item.ToString().Substring(2))).FirstOrDefault());
                        }
                        ReservationDAO.UpdateReservation(lareservation, lesChambres);
                    
                        SwitchEditMode(false);
                    }
                    else
                    {
                        errorProvider.SetError(listChambre, "Au moins 1 chambre doit être sélectionnée.");
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
            }
        }

        // Permet d'annuler les modifications de la réservation sélectionnée
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider.Clear();
                SwitchEditMode(false);
                frmBase.RefreshChambre(listChambre, DateDebut.Value, DateDebut.Value, lareservation);
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
            }
        }

        // Permet de supprimer la réservation sélectionnée
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try {
                errorProvider.Clear();
                if (lareservation != null && Utils.HotelIsConnected() && MessageBox.Show($"Voulez-vous vraiment supprimer cette réservation {lareservation.nores}  ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    varglobale.connexion.reservation.Remove(lareservation);
                    varglobale.connexion.SaveChanges();

                    Application.OpenForms.OfType<FrmMain>().FirstOrDefault().RefreshAllForms();
                }
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
            }
        }
    }
}
