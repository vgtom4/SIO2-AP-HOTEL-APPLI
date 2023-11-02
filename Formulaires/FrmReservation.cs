using AP_HOTEL_APPLI.ClasseTechniques;
using AP_HOTEL_APPLI.EntityModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Forms;

namespace AP_HOTEL_APPLI
{
    public partial class FrmReservation : Form
    {
        FrmVisuRes frmVisuRes;
        FrmAddRes frmAddRes;

        public FrmReservation()
        {
            InitializeComponent();
        }

        private void FrmCalendar_Load(object sender, EventArgs e)
        {
            try {
                // Instanciation des formulaires de gestion des réservations (ajout et visualisation) et ajout dans le panel
                frmVisuRes = new FrmVisuRes {TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill};
                panelGestion.Controls.Add(frmVisuRes);

                frmAddRes = new FrmAddRes {TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill};
                panelGestion.Controls.Add(frmAddRes);

                rdoVisuRes.Checked = true;
                RefreshReservationForms();
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
            }
        }

        /// <summary>
        /// Permet de rafraichir les formulaires de gestion des réservations (ajout et visualisation)
        /// </summary>
        public void RefreshReservationForms()
        {
            try {
                if (Utils.HotelIsConnected())
                {
                    SwitchGestionReservation();
                    frmVisuRes.RefreshForm();
                    frmAddRes.RefreshForm();
                }
                else
                {
                    frmAddRes.Hide();
                    frmVisuRes.Hide();
                }
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
            }
        }

        /// <summary>
        /// Permet de rafraichir la liste des chambres disponibles dans la checkedListBox en paramètre en fonction des dates de début et de fin de réservation et de la réservation en cours.
        /// </summary>
        /// <param name="checkedListBox">checkedListBox des chambres disponibles</param>
        /// <param name="dateTimeDebut">période de début</param>
        /// <param name="dateTimeFin">période de fin</param>
        /// <param name="lareservation">(Optionnel) réservation sélectionnée</param>
        public void RefreshChambre(CheckedListBox checkedListBox, DateTime dateTimeDebut, DateTime dateTimeFin, reservation lareservation = null)
        {
            try {
                List<chambre> lesChambresDisponibles = ChambreDAO.GetLesChambresDisponibles(varglobale.hotel.chambre.ToList(), dateTimeDebut, dateTimeFin, lareservation);

                checkedListBox.Items.Clear();
                foreach (chambre chambre in lesChambresDisponibles)
                {
                    checkedListBox.Items.Add($"n°{chambre.nochambre}");

                    // Cocher la chambre si elle est réservée
                    checkedListBox.SetItemChecked(checkedListBox.Items.Count - 1, chambre.reservation.Contains(lareservation));
                }
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
            }
        }

        /// <summary>
        /// Permet de switcher entre les formulaires de gestion des réservations (ajout et visualisation)
        /// </summary>
        private void SwitchGestionReservation()
        {
            if (rdoCreateRes.Checked)
            {
                frmVisuRes.Hide();
                frmAddRes.Show();
            }
            else
            {
                frmAddRes.Hide();
                frmVisuRes.Show();
            }
        }

        private void rdoCreateRes_CheckedChanged(object sender, EventArgs e)
        {
            RefreshReservationForms();
        }

        private void rdoVisuRes_CheckedChanged(object sender, EventArgs e)
        {
            RefreshReservationForms();
        }
    }
}
