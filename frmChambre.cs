using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace AP_HOTEL_APPLI
{
    public partial class FrmChambre : Form
    {
        //connexiondb connexion = varglobale.connexion;
        hotel hotel = varglobale.hotel;

        public FrmChambre()
        {
            InitializeComponent();
        }

        private void frmChambre_Load(object sender, EventArgs e)
        {
            RefreshChambre();
        }

        public void RefreshChambre()
        {
            flowLayoutPanelChambres.Controls.Clear();
            if (varglobale.hotel != null)
            {
                List<chambre> chambres = varglobale.hotel.chambre.ToList();

                foreach (var chambre in chambres)
                {
                    var btnChambre = new System.Windows.Forms.Button();
                    btnChambre.Text = $"N°{chambre.nochambre}";
                    btnChambre.Tag = chambre.nochambre;
                    btnChambre.Size = new Size(60, 60);
                    btnChambre.Click += BtnChambre_Click;

                    flowLayoutPanelChambres.Controls.Add(btnChambre);
                }
            }
            else
            {
                // Données inaccessibles
            }
        }

        private void BtnChambre_Click(object sender, EventArgs e)
        {
            int idChambre = (int)((System.Windows.Forms.Button)sender).Tag;
            int idHotel = (int)varglobale.hotel.nohotel;

            if ((MessageBox.Show($"Confirmez la suppression de la chambre {idChambre} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
            {
                // Supprimez la chambre de la base de données
                chambre chambreASupprimer = varglobale.hotel.chambre.Where(chambre => chambre.nochambre == idChambre).FirstOrDefault();
                if (chambreASupprimer != null)
                {
                    bool canDeleteChambre = true;
                    // si la chambre a une reservation
                    if (chambreASupprimer.reservation.Count() > 0)
                    {
                        //message de confirmation de suppression
                        canDeleteChambre = MessageBox.Show($"La chambre {idChambre} a des réservations, voulez-vous vraiment la supprimer ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
                        // retirer la chambre de la reservation
                        if (canDeleteChambre)
                        {
                            foreach (var reservation in chambreASupprimer.reservation)
                            {
                                reservation.chambre.Remove(chambreASupprimer);
                            }
                            varglobale.connexion.SaveChanges();
                        }
                    }
                    if (canDeleteChambre)
                    {
                        varglobale.hotel.chambre.Remove(chambreASupprimer);
                        varglobale.connexion.SaveChanges();

                        //// Supprimez également le bouton associé du conteneur
                        //System.Windows.Forms.Button bouton = (System.Windows.Forms.Button)sender;
                        //((FlowLayoutPanel)Button.Parent).Controls.Remove(bouton);

                        // Supprimez également le bouton associé du conteneur
                        System.Windows.Forms.Button bouton = (System.Windows.Forms.Button)sender;
                        ((FlowLayoutPanel)bouton.Parent).Controls.Remove(bouton);
                    }

                    
                }
            }
        }

        private int numNouvChambre() { return varglobale.hotel.chambre.ToList().Count() + 1;}
        

        private int noHotel()
        {
            int no = varglobale.hotel.nohotel;
            return no;
        }
        private void btnAddChambre_Click(object sender, EventArgs e)
        {
            
            if (varglobale.hotel != null)
            {
                chambre nvChambre = new chambre();
                nvChambre.nochambre = numNouvChambre();
                nvChambre.nohotel = noHotel();
                varglobale.hotel.chambre.Add(nvChambre);
                varglobale.connexion.SaveChanges();
                RefreshChambre();
            }
                
        }
    }
}
