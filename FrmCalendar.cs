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
        public FrmCalendar()
        {
            InitializeComponent();
        }

        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (varglobale.hotel != null)
            {

                cboRes.Visible = true;
                btnAddRes.Visible = true;

                List<reservation> reservationsDate = new List<reservation>();
                reservationsDate = varglobale.hotel.reservation.ToList().FindAll(reservation => reservation.datedeb == dateTimePicker1.Value);
                foreach (reservation reservation in reservationsDate)
                {
                    cboRes.Items.Add(reservation);
                }

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
    }
}
