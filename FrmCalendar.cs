using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_HOTEL_APPLI
{
    public partial class FrmCalendar : Form
    {
        reservation lareservation;
        public FrmCalendar()
        {
            InitializeComponent();
        }

        private void FrmCalendar_Load(object sender, EventArgs e)
        {
            RefreshData();
            // date du jour pour le calendrier
            dateTimePicker1.Value = DateTime.Now;
        }

        public void RefreshData()
        {
            if (varglobale.hotel != null)
            {
                RefreshChambre();
            }
        }

        public void RefreshChambre()
        {
            listChambre.Items.Clear();
            foreach (chambre chambre in varglobale.hotel.chambre)
            {
                listChambre.Items.Add($"n°{chambre.nochambre}");

                if (chambre.reservation.Count > 0)
                {
                    if (chambre.reservation.Contains(lareservation))
                    {
                        listChambre.SetSelected(chambre.nochambre, true);
                    }
                    else
                    {
                        // l'élément de peut être sélectionné
                        listChambre.SetSelected(chambre.nochambre, false);
                    }
                }
            }
        }

        List<reservation> lesReservations = new List<reservation>();
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (varglobale.hotel != null)
            {

                cboRes.Visible = true;
                btnAddRes.Visible = true;

                List<reservation> reservationsDate = varglobale.hotel.reservation.Where(reservation => reservation.datedeb.Value.ToString("d") == dateTimePicker1.Value.ToString("d")).ToList();
                
                foreach (reservation reservation in reservationsDate)
                {
                    cboRes.Items.Add($"n°{reservation.nores}");
                    lesReservations.Add(reservation);
                }
                if (cboRes.Items.Count > 0) cboRes.SelectedIndex = 0;

            }
        }

        private void btnAddRes_Click(object sender, EventArgs e)
        {
            List<chambre> selectedChambres = new List<chambre>();
            foreach (chambre chambre in cboRes.Items)
            {
                if (cboRes.SelectedIndex == chambre.nochambre)
                {
                    selectedChambres.Add(chambre);
                }
            }
            
            foreach (chambre chambre in selectedChambres)
            {
                reservation unereservation = new reservation();
                unereservation.chambre.Add(chambre);
                varglobale.hotel.reservation.Add(unereservation);
                varglobale.connexion.SaveChanges();
            }
        }

        private void cboRes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lareservation = varglobale.hotel.reservation.Where(reservation => reservation == lesReservations[cboRes.SelectedIndex]).FirstOrDefault();
            RefreshChambre();
        }
    }
}
