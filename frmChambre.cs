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
using Microsoft.VisualBasic;

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
                List<chambre> chambres = varglobale.hotel.chambre.OrderBy(chambre => chambre.nochambre).ToList();

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

        private int noHotel()
        {
            return varglobale.hotel.nohotel;
        }

        private void btnAddChambre_Click(object sender, EventArgs e)
        {
            if (varglobale.hotel != null)
            {
                List<chambre> lesChambres = varglobale.hotel.chambre.OrderBy(chambre=>chambre.nochambre).ToList();
                
                bool valid = false;
                int numNewChambre = 1;

                if (cboxcustom.Checked)
                {
                    string numNewChambreStr = Interaction.InputBox("Numéro de la chambre à ajouter");
                    // vérifie si numNewChambreStr est un nombre
                    if (int.TryParse(numNewChambreStr, out int numNewChambreInt) && numNewChambreInt > 0)
                    {
                        if (!varglobale.hotel.chambre.Where(chambre => chambre.nochambre == numNewChambreInt).Any())
                        {
                            numNewChambre = numNewChambreInt;
                            valid = true;
                        }
                        else
                        {
                            MessageBox.Show("Numéro de chambre déjà existant");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Numéro de chambre invalide");
                    }
                }
                else
                {
                    while (numNewChambre <= lesChambres.Count && !valid)
                    {
                        if (lesChambres[numNewChambre - 1].nochambre != numNewChambre)
                        {
                            valid = true;
                        }
                        else
                        {
                            numNewChambre++;
                        }
                    }
                    if (!valid)
                    {
                        numNewChambre = varglobale.hotel.chambre.ToList().Count() + 1;
                        valid = true;
                    }
                }

                if (valid)
                {
                    chambre nvChambre = new chambre();
                    nvChambre.nohotel = varglobale.hotel.nohotel;
                    nvChambre.nochambre = numNewChambre;
                    varglobale.hotel.chambre.Add(nvChambre);
                    varglobale.connexion.SaveChanges();
                    RefreshChambre();
                }
                
            }
                
        }
    }
}
