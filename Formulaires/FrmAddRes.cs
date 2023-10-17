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
            TimeDebut.Value = DateTime.Now;

            // timeDebut et timeFin à 00:00:00
            TimeDebut.Value = new DateTime(TimeDebut.Value.Year, TimeDebut.Value.Month, TimeDebut.Value.Day, 0, 0, 0);
            TimeFin.Value = new DateTime(TimeFin.Value.Year, TimeFin.Value.Month, TimeFin.Value.Day, 0, 0, 0);
        }

        /// <summary>
        /// Permet de rafraichir la liste des chambres disponibles
        /// </summary>
        public void RefreshForm()
        {
            DateTime dateTimeDebut = new DateTime(DateDebut.Value.Year, DateDebut.Value.Month, DateDebut.Value.Day, TimeDebut.Value.Hour, TimeDebut.Value.Minute, TimeDebut.Value.Second);
            DateTime dateTimeFin = new DateTime(DateFin.Value.Year, DateFin.Value.Month, DateFin.Value.Day, TimeFin.Value.Hour, TimeFin.Value.Minute, TimeFin.Value.Second);

            frmBase.RefreshChambre(listChambre, dateTimeDebut, dateTimeFin);

            lblChambreDispo.Text = listChambre.Items.Count > 0 ? "Chambres disponibles :" : "Aucune chambre disponible";
            lblChambreDispo.ForeColor = listChambre.Items.Count > 0 ? DefaultForeColor : System.Drawing.Color.DarkRed;
        }

        // Permet d'ajouter une réservation à l'hôtel connecté
        private void btnAddRes_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
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
            if (DateDebut.Value > DateFin.Value)
            {
                DateFin.Value = DateDebut.Value;
            }
            frmBase.RefreshForms();
        }

        private void TimeDebut_ValueChanged(object sender, EventArgs e)
        {
            if (DateDebut.Value == DateFin.Value && TimeDebut.Value > TimeFin.Value)
            {
                TimeFin.Value = TimeDebut.Value;
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

        private void TimeFin_ValueChanged(object sender, EventArgs e)
        {
            if (DateDebut.Value == DateFin.Value && TimeDebut.Value > TimeFin.Value)
            {
                TimeDebut.Value = TimeFin.Value;
            }
            frmBase.RefreshForms();
        }
    }
}
