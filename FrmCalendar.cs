using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

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
            SwitchEditMode(false);
            RefreshForm();
            // date du jour pour le calendrier
            dateTimePicker1.Value = DateTime.Now;
        }

        public void RefreshForm()
        {
            SwitchEditMode(false);
            if (varglobale.hotel != null)
            {
                RefreshChambre();
                GetLesReservations();
            }
        }

        public void RefreshChambre()
        {
            listChambre.Items.Clear();
            if (lareservation != null)
            {
                List<chambre> lesChambres = varglobale.hotel.chambre.Where(chambre => chambre.reservation.Count == 0 || chambre.reservation.Contains(lareservation)).ToList();
                foreach (chambre chambre in lesChambres)
                {
                    listChambre.Items.Add($"n°{chambre.nochambre}");

                    if (chambre.reservation.Contains(lareservation))
                    {
                        // selectionner le checkbox de la chambre dans la liste
                        listChambre.SetItemChecked(listChambre.Items.Count - 1, true);
                    }
                }
            }
        }

        public void GetLesReservations()
        {
            cboRes.Items.Clear();
            lareservation = null;
            if (varglobale.hotel != null)
            {
                cboRes.Visible = true;
                btnAddRes.Visible = true;

                List<reservation> lesReservationsDate = varglobale.hotel.reservation.Where(reservation => reservation.datedeb.Value.ToString("d") == dateTimePicker1.Value.ToString("d")).ToList();
                
                foreach (reservation reservation in lesReservationsDate)
                {
                    cboRes.Items.Add($"n°{reservation.nores}");
                    lesReservations.Add(reservation);
                }
                if (cboRes.Items.Count > 0) cboRes.SelectedIndex = 0;
            }
        }

        List<reservation> lesReservations = new List<reservation>();
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            GetLesReservations();
            RefreshForm();
        }

        private void btnAddRes_Click(object sender, EventArgs e)
        {
            // -------------------------------------------------------------------------------------------------A faire

            //List<chambre> selectedChambres = new List<chambre>();
            //foreach (chambre chambre in cboRes.Items)
            //{
            //    if (cboRes.SelectedIndex == chambre.nochambre)
            //    {
            //        selectedChambres.Add(chambre);
            //    }
            //}
            
            //foreach (chambre chambre in selectedChambres)
            //{
            //    reservation unereservation = new reservation();
            //    unereservation.chambre.Add(chambre);
            //    varglobale.hotel.reservation.Add(unereservation);
            //    varglobale.connexion.SaveChanges();
            //}
        }

        private void cboRes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lareservation = varglobale.hotel.reservation.Where(reservation => reservation == lesReservations[cboRes.SelectedIndex]).FirstOrDefault();
            RefreshChambre();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (varglobale.hotel != null)
            {
                SwitchEditMode(true);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (varglobale.hotel != null)
            {
                if (listChambre.CheckedItems.Count > 0)
                {
                    List<chambre> lesChambres = new List<chambre>();

                    //deux possibilités
                    foreach (var item in listChambre.CheckedItems)
                    {
                        lesChambres.Add(varglobale.hotel.chambre.Where(chambre => chambre.nochambre == int.Parse(item.ToString().Substring(2))).FirstOrDefault());
                    }
                    // ou
                    lesChambres = listChambre.CheckedItems.Cast<string>().Select(itemList => varglobale.hotel.chambre.Where(chambre => chambre.nochambre == int.Parse(itemList.ToString().Substring(2))).FirstOrDefault()).ToList();

                    ReservationDAO.UpdateReservation(lareservation, lesChambres);
                    RefreshChambre();
                    SwitchEditMode(false);
                }
            }
            else
            {
                MessageBox.Show("Aucun hotel n'est connecté");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SwitchEditMode(false);
            RefreshChambre();
        }

        public void SwitchEditMode(bool editMode)
        {
            listChambre.Enabled = editMode;

            if (varglobale.hotel != null && lareservation != null)
            {
                btnEdit.Visible = !editMode;
                btnSave.Visible = editMode;
                btnCancel.Visible = editMode;
            }
            else
            {
                btnEdit.Visible = false;
                btnSave.Visible = false;
                btnCancel.Visible = false;
                editMode = false;
            }


        }
    }
}
