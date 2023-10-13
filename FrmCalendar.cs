using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AP_HOTEL_APPLI
{
    public partial class FrmCalendar : Form
    {
        FrmVisuRes frmVisuRes;
        FrmAddRes frmAddRes;

        public FrmCalendar()
        {
            InitializeComponent();
        }

        private void FrmCalendar_Load(object sender, EventArgs e)
        {
            frmVisuRes = new FrmVisuRes {TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill};
            panelGestion.Controls.Add(frmVisuRes);

            frmAddRes = new FrmAddRes {TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill};
            panelGestion.Controls.Add(frmAddRes);

            rdoVisuRes.Checked = true;
            RefreshForms();
        }

        public void RefreshForms()
        {
            //SwitchEditMode(false);
            if (varglobale.hotel != null)
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

        public void RefreshChambre(CheckedListBox checkedListBox, DateTime dateTimeDebut, DateTime dateTimeFin, reservation lareservation = null)
        {
            List<chambre> lesChambresDisponibles = ChambreDAO.GetLesChambresDisponibles(varglobale.hotel.chambre.ToList(), dateTimeDebut, dateTimeFin, lareservation);

            checkedListBox.Items.Clear();
            foreach (chambre chambre in lesChambresDisponibles)
            {
                checkedListBox.Items.Add($"n°{chambre.nochambre}");
                if (chambre.reservation.Contains(lareservation))
                {
                    // selectionner le checkbox de la chambre dans la liste
                    checkedListBox.SetItemChecked(checkedListBox.Items.Count - 1, true);
                }
            }
        }

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
            RefreshForms();
        }

        private void rdoVisuRes_CheckedChanged(object sender, EventArgs e)
        {
            RefreshForms();
        }
    }
}
