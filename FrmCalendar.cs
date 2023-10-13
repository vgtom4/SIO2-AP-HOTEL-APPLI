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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace AP_HOTEL_APPLI
{
    public partial class FrmCalendar : Form
    {
        List<chambre> lesChambresDisponibles = new List<chambre>();
        List<reservation> lesReservations = new List<reservation>();
        reservation lareservation;
        public FrmCalendar()
        {
            InitializeComponent();
        }

        private void FrmCalendar_Load(object sender, EventArgs e)
        {
            SwitchEditMode(false);
            // date du jour pour le calendrier
            DateDebut.Value = DateTime.Now;
            TimeDebut.Value = DateTime.Now;

            // timeDebut et timeFin à 00:00:00
            TimeDebut.Value = new DateTime(TimeDebut.Value.Year, TimeDebut.Value.Month, TimeDebut.Value.Day, 0, 0, 0);
            TimeFin.Value = new DateTime(TimeFin.Value.Year, TimeFin.Value.Month, TimeFin.Value.Day, 0, 0, 0);
            rdoCreateRes.Checked = true;
            RefreshForm();
        }

        public void RefreshForm()
        {
            SwitchEditMode(false);
            if (varglobale.hotel != null)
            {
                SwitchGestionReservation();
                if (rdoVisuRes.Checked)
                {
                    DateTime dateTimeDebut = new DateTime(DateDebut.Value.Year, DateDebut.Value.Month, DateDebut.Value.Day, TimeDebut.Value.Hour, TimeDebut.Value.Minute, TimeDebut.Value.Second);
                    lesReservations = ReservationDAO.GetLesReservationsDate(dateTimeDebut);
                    ShowRes(lesReservations);
                }
                RefreshChambre();
            }
        }

        public void RefreshChambre()
        {
            listChambre.Items.Clear();

            DateTime dateTimeDebut = new DateTime(DateDebut.Value.Year, DateDebut.Value.Month, DateDebut.Value.Day, TimeDebut.Value.Hour, TimeDebut.Value.Minute, TimeDebut.Value.Second);
            DateTime dateTimeFin = new DateTime(DateFin.Value.Year, DateFin.Value.Month, DateFin.Value.Day, TimeFin.Value.Hour, TimeFin.Value.Minute, TimeFin.Value.Second);

            lesChambresDisponibles = null;
            lesChambresDisponibles = rdoCreateRes.Checked ? ChambreDAO.GetLesChambresDisponibles(dateTimeDebut, dateTimeFin) : ChambreDAO.GetLesChambresDisponibles(dateTimeDebut, dateTimeFin, lareservation);
            foreach (chambre chambre in lesChambresDisponibles)
            {
                listChambre.Items.Add($"n°{chambre.nochambre}");
                if (chambre.reservation.Contains(lareservation) && rdoVisuRes.Checked)
                {
                    // selectionner le checkbox de la chambre dans la liste
                    listChambre.SetItemChecked(listChambre.Items.Count - 1, true);
                }
            }
            listChambre.Visible = lesChambresDisponibles.Count > 0;

            // text de lblChambreDispo comme dans le formulaire
            lblChambreDispo.Text = lesChambresDisponibles.Count > 0 ? "Chambres disponibles :" : "Aucune chambre disponible";
            lblChambreDispo.ForeColor = lesChambresDisponibles.Count > 0 ? DefaultForeColor : System.Drawing.Color.DarkRed;

            if (lesChambresDisponibles.Count > 0)
            {
                
            }
        }

        /// <summary>
        /// Permet d'afficher les réservations de la liste de réservations passée en paramètre dans la combobox des réservations
        /// </summary>
        /// <param name="lesRes">Listes des réservations à afficher dans la ComboBox</param>
        private void ShowRes(List<reservation> lesRes)
        {
            cboRes.Items.Clear();
            lareservation = null;
            foreach (reservation reservation in lesRes)
            {
                cboRes.Items.Add($"n°{reservation.nores}");
            }
            if (cboRes.Items.Count > 0)
            {
                cboRes.SelectedIndex = 0;
                SwitchEditMode(false);
                panelEditBtn.Visible = true;
                cboRes.Visible = true;
                lblLesRes.Visible = true;
            }
            else
            {
                panelEditBtn.Visible = false;
                cboRes.Visible = false;
                lblLesRes.Visible = false;
            }
        }

        private void btnAddRes_Click(object sender, EventArgs e)
        {
            if (varglobale.hotel != null)
            {
                if (listChambre.CheckedItems.Count > 0 && txtNom.Text != "" && txtMail.Text != "")
                {
                    reservation nouvelleReservation = new reservation();
                    nouvelleReservation.nores = varglobale.hotel.reservation.Count > 0 ? varglobale.hotel.reservation.Max(res => res.nores) + 1 : 1;
                    nouvelleReservation.datedeb = new DateTime(DateDebut.Value.Year, DateDebut.Value.Month, DateDebut.Value.Day, TimeDebut.Value.Hour, TimeDebut.Value.Minute, TimeDebut.Value.Second);
                    nouvelleReservation.datefin = new DateTime(DateFin.Value.Year, DateFin.Value.Month, DateFin.Value.Day, TimeFin.Value.Hour, TimeFin.Value.Minute, TimeFin.Value.Second);
                    nouvelleReservation.nom = txtNom.Text;
                    nouvelleReservation.email = txtMail.Text;

                    nouvelleReservation.chambre = listChambre.CheckedItems.Cast<string>().Select(itemList => varglobale.hotel.chambre.Where(chambre => chambre.nochambre == int.Parse(itemList.ToString().Substring(2))).FirstOrDefault()).ToList();
                    // ajout des chambres sélectionnées à la réservation
                    //foreach (var chambre in listChambre.CheckedItems)
                    //{
                    //    nouvelleReservation.chambre.Add(lesChambresDisponibles.Where(c => c.nochambre == int.Parse(chambre.ToString().Substring(2))).First());
                    //}
                    

                    nouvelleReservation.codeacces = new Random().Next(10000, 99999);
                    varglobale.hotel.reservation.Add(nouvelleReservation);
                    varglobale.connexion.SaveChanges();
                    RefreshForm();
                }
            }
            // -------------------------------------------------------------------------------------------------A Léon

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
            listChambre.Enabled = rdoCreateRes.Checked ? true : editMode;

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
            }


        }

        private void SwitchGestionReservation()
        {
            bool modeCreateRes = rdoCreateRes.Checked;
            btnAddRes.Visible = modeCreateRes;
            TimeDebut.Visible = modeCreateRes;
            DateFin.Visible = modeCreateRes;
            TimeFin.Visible = modeCreateRes;
            panelInfoClient.Visible = modeCreateRes;

            lblLesRes.Visible = !modeCreateRes;
            panelEditBtn.Visible = !modeCreateRes;
            cboRes.Visible = !modeCreateRes;
        }

        private void rdoCreateRes_CheckedChanged(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void rdoVisuRes_CheckedChanged(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void DateDebut_ValueChanged(object sender, EventArgs e)
        {
            if (DateDebut.Value > DateFin.Value)
            {
                DateFin.Value = DateDebut.Value;
            }
            RefreshForm();
        }

        private void TimeDebut_ValueChanged(object sender, EventArgs e)
        {
            if (DateDebut.Value == DateFin.Value && TimeDebut.Value > TimeFin.Value)
            {
                TimeFin.Value = TimeDebut.Value;
            }
            RefreshForm();
        }

        private void DateFin_ValueChanged(object sender, EventArgs e)
        {
            if (DateDebut.Value > DateFin.Value)
            {
                DateDebut.Value = DateFin.Value;
            }
            RefreshForm();
        }

        private void TimeFin_ValueChanged(object sender, EventArgs e)
        {
            if (DateDebut.Value == DateFin.Value && TimeDebut.Value > TimeFin.Value)
            {
                TimeDebut.Value = TimeFin.Value;
            }
            RefreshForm();
        }
    }
}
