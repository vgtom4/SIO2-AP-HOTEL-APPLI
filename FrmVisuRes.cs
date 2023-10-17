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

        public void RefreshForm()
        {
            RefreshLesReservations();
            rtbInfoRes.Visible = lesReservations.Any();
            if (!lesReservations.Any()) listChambre.Items.Clear();
        }

        public void RefreshLesReservations()
        {
            lesReservations.Clear();
            lesReservations = ReservationDAO.GetLesReservationsDate(DateDebut.Value);
            ShowRes(lesReservations);
        }

        /// <summary>
        /// Permet d'afficher les réservations de la liste de réservations passée en paramètre dans la combobox des réservations
        /// </summary>
        /// <param name="lesRes">Listes des réservations à afficher dans la ComboBox</param>
        private void ShowRes(List<reservation> lesRes)
        {
            cboRes.Items.Clear();
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
                lblChambreDispo.Visible = true;
                listChambre.Visible = true;
            }
            else
            {
                panelEditBtn.Visible = false;
                cboRes.Visible = false;
                lblLesRes.Visible = false;
                lblChambreDispo.Visible = false;
                listChambre.Visible = false;
            }
        }

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

        private void cboRes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lareservation = varglobale.hotel.reservation.Where(reservation => reservation == lesReservations[cboRes.SelectedIndex]).FirstOrDefault();
            frmBase.RefreshChambre(listChambre, DateDebut.Value, DateDebut.Value, lareservation);
            rtbInfoRes.Text =
                        "Informations réservation\n\n" +
                        $"N°{lareservation.nores}\n" +
                        $"Nom : {lareservation.nom}\n" +
                        $"Email : {lareservation.email}\n" +
                        $"Début : {lareservation.datedeb.Value:dddd d MMMM HH'h'mm}\n" +
                        $"Fin : {lareservation.datefin.Value:dddd d MMMM HH'h'mm}\n" +
                        $"Code d'accès : {lareservation.codeacces}";
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
                    // lesChambres = listChambre.CheckedItems.Cast<string>().Select(itemList => varglobale.hotel.chambre.Where(chambre => chambre.nochambre == int.Parse(itemList.ToString().Substring(2))).FirstOrDefault()).ToList();

                    ReservationDAO.UpdateReservation(lareservation, lesChambres);
                    frmBase.RefreshForms();
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
            frmBase.RefreshChambre(listChambre, DateDebut.Value, DateDebut.Value, lareservation);
        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            if (lareservation != null && varglobale.hotel != null && MessageBox.Show($"Voulez-vous vraiment supprimer cette réservation {lareservation.nores}  ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                varglobale.connexion.reservation.Remove(lareservation);
                varglobale.connexion.SaveChanges();

                Application.OpenForms.OfType<FrmMain>().FirstOrDefault().RefreshForm();
            }
        }
    }
}
