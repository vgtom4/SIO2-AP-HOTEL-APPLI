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
using AP_HOTEL_APPLI.EntityModel;
using Microsoft.VisualBasic;

namespace AP_HOTEL_APPLI
{
    public partial class FrmChambre : Form
    {
        //connexiondb connexion = varglobale.connexion;
        hotel hotel = varglobale.hotel;
        List<chambre> lesChambresASupprimmer = new List<chambre>();

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
                    btnChambre.Cursor = Cursors.Hand;
                    btnChambre.Click += BtnChambre_Click;

                    flowLayoutPanelChambres.Controls.Add(btnChambre);

                    var lblChambre = new ListViewItem();
                    lblChambre.Text = $"N°{chambre.nochambre}";
                    lblChambre.Tag = chambre.nochambre;
                }
                BtnSelected();
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

            chambre chambreASupprimer = varglobale.hotel.chambre.Where(chambre => chambre.nochambre == idChambre).FirstOrDefault();
            if (lesChambresASupprimmer.Contains(chambreASupprimer))
            {
                lesChambresASupprimmer.Remove(chambreASupprimer);
            }
            else
            {
                lesChambresASupprimmer.Add(chambreASupprimer);
            }
            
            BtnSelected();

            //if ((MessageBox.Show($"Confirmez la suppression de la chambre {idChambre} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
            //{
            //    // Supprimez la chambre de la base de données
            //    chambre chambreASupprimer = varglobale.hotel.chambre.Where(chambre => chambre.nochambre == idChambre).FirstOrDefault();
            //    if (chambreASupprimer != null)
            //    {
            //        bool canDeleteChambre = true;
            //        // si la chambre a une reservation
            //        if (chambreASupprimer.reservation.Count() > 0)
            //        {
            //            //message de confirmation de suppression
            //            canDeleteChambre = MessageBox.Show($"La chambre {idChambre} a des réservations, voulez-vous vraiment la supprimer ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
            //            // retirer la chambre de la reservation
            //            if (canDeleteChambre)
            //            {
            //                foreach (var reservation in chambreASupprimer.reservation)
            //                {
            //                    reservation.chambre.Remove(chambreASupprimer);
            //                }
            //                varglobale.connexion.SaveChanges();
            //            }
            //        }
            //        if (canDeleteChambre)
            //        {
            //            varglobale.hotel.chambre.Remove(chambreASupprimer);
            //            varglobale.connexion.SaveChanges();

            //            //// Supprimez également le bouton associé du conteneur
            //            //System.Windows.Forms.Button bouton = (System.Windows.Forms.Button)sender;
            //            //((FlowLayoutPanel)Button.Parent).Controls.Remove(bouton);

            //            // Supprimez également le bouton associé du conteneur
            //            System.Windows.Forms.Button bouton = (System.Windows.Forms.Button)sender;
            //            ((FlowLayoutPanel)bouton.Parent).Controls.Remove(bouton);
            //        }


            //    }
            //}
        }

        private void BtnSelected()
        {
            // pour tous les boutons de la flowLayoutPanelChambres aillant le tag (nochambre) de la chambre dans la liste lesChambresASupprimmer
            foreach (System.Windows.Forms.Button btn in flowLayoutPanelChambres.Controls.OfType<System.Windows.Forms.Button>())
            {
                btn.BackColor = lesChambresASupprimmer.Where(chambre=> chambre.nochambre == Convert.ToInt16(btn.Tag)).Any() ? Color.RoyalBlue : Color.White;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (varglobale.hotel != null && lesChambresASupprimmer.Count > 0)
            {
                // ordonner lesChambresASupprimmer par numero de chambre
                lesChambresASupprimmer = lesChambresASupprimmer.OrderBy(chambre => chambre.nochambre).ToList();

                string lesChambresASupprimmerStr = "";
                foreach (var unechambre in lesChambresASupprimmer)
                {
                    lesChambresASupprimmerStr += unechambre.nochambre + ", ";
                }
                lesChambresASupprimmerStr = lesChambresASupprimmerStr.Substring(0, lesChambresASupprimmerStr.Length - 2);

                if (MessageBox.Show($"Confirmez la suppression des chambres suivantes :\n {lesChambresASupprimmerStr} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    foreach (var chambreASupprimer in lesChambresASupprimmer)
                    {
                        bool canDeleteChambre = true;
                        // si la chambre a une reservation
                        if (chambreASupprimer.reservation.Count() > 0)
                        {
                            //message de confirmation de suppression
                            canDeleteChambre = MessageBox.Show($"La chambre {chambreASupprimer.nochambre} a des réservations, voulez-vous vraiment la supprimer ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
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

                            // Supprimez également le bouton aillant comme tag le numéro de la chambre
                            foreach (System.Windows.Forms.Button btn in flowLayoutPanelChambres.Controls.OfType<System.Windows.Forms.Button>())
                            {
                                if (btn.Tag.ToString() == chambreASupprimer.nochambre.ToString())
                                {
                                    ((FlowLayoutPanel)btn.Parent).Controls.Remove(btn);
                                }
                            }
                        }
                    }
                }
                lesChambresASupprimmer.Clear();
                RefreshChambre();
            }
        }
    }
}
