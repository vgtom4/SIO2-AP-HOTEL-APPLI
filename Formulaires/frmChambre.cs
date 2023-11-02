using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AP_HOTEL_APPLI.ClasseTechniques;
using AP_HOTEL_APPLI.EntityModel;
using Microsoft.VisualBasic;

namespace AP_HOTEL_APPLI
{
    public partial class FrmChambre : Form
    {
        List<chambre> lesChambresASupprimmer = new List<chambre>();

        public FrmChambre()
        {
            InitializeComponent();
        }

        private void frmChambre_Load(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            numericUpDownNewNumChambre.Visible = false;
            RefreshChambre();
        }

        /// <summary>
        /// Permet de rafraichir la liste des chambres de l'hotel
        /// </summary>
        public void RefreshChambre()
        {
            try {
                flowLayoutPanelChambres.Controls.Clear();
                if (Utils.HotelIsConnected())
                {
                    // récupère les chambres de l'hotel
                    List<chambre> chambres = varglobale.hotel.chambre.OrderBy(chambre => chambre.nochambre).ToList();

                    // pour chaque chambre, créer un bouton et l'ajouter à la flowLayoutPanelChambres
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
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
            }
        }

        /// <summary>
        /// Permet d'ajouter la chambre associée à la liste de chambre à supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnChambre_Click(object sender, EventArgs e)
        {
            try {
                int idChambre = (int)((System.Windows.Forms.Button)sender).Tag;
                int idHotel = (int)varglobale.hotel.nohotel;

                chambre chambreASupprimer = varglobale.hotel.chambre.Where(chambre => chambre.nochambre == idChambre).FirstOrDefault();

                // Si la chambre est déjà dans la liste, on la retire de celle-ci, sinon on l'ajoute
                if (lesChambresASupprimmer.Contains(chambreASupprimer))
                {
                    lesChambresASupprimmer.Remove(chambreASupprimer);
                }
                else
                {
                    lesChambresASupprimmer.Add(chambreASupprimer);
                }

                // Si la liste n'est pas vide, on active le bouton de suppression, sinon on le désactive
                btnDelete.Visible = lesChambresASupprimmer.Any();
            
                BtnSelected();
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
            }
        }

        /// <summary>
        /// Permet de colorer le bouton pour lui donner un effet de sélection
        /// </summary>
        private void BtnSelected()
        {
            try
            {
                // pour tous les boutons de la flowLayoutPanelChambres aillant le tag (nochambre) de la chambre dans la liste lesChambresASupprimmer
                foreach (System.Windows.Forms.Button btn in flowLayoutPanelChambres.Controls.OfType<System.Windows.Forms.Button>())
                {
                    btn.BackColor = lesChambresASupprimmer.Where(chambre=> chambre.nochambre == Convert.ToInt16(btn.Tag)).Any() ? Color.RoyalBlue : Color.White;
                }
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
            }
        }

        // Permet d'ajouter une chambre à l'hotel
        private void btnAddChambre_Click(object sender, EventArgs e)
        {
            try {
                errorProvider1.Clear();
                if (Utils.HotelIsConnected())
                {
                    // récupère les chambres de l'hotel
                    List<chambre> lesChambres = varglobale.hotel.chambre.OrderBy(chambre=>chambre.nochambre).ToList();
                
                    bool valid = false;
                    int numNewChambre = 1;

                    if (cbNumChambreCustom.Checked)
                    {
                        numNewChambre = (int)numericUpDownNewNumChambre.Value;
                        // vérifie que le numéro de chambre n'existe pas déjà
                        if (!varglobale.hotel.chambre.Where(chambre => chambre.nochambre == numNewChambre).Any())
                        {
                            valid = true;
                        }
                        else
                        {
                            errorProvider1.SetError(numericUpDownNewNumChambre, "Ce numéro de chambre existe déjà");
                        }
                    }
                    else
                    {
                        // boucle pour trouver un numéro de chambre valide
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

                        // si aucun numéro de chambre n'est valide, on prend le numéro de chambre suivant
                        if (!valid)
                        {
                            numNewChambre = varglobale.hotel.chambre.Max(chambre => chambre.nochambre) + 1;
                            valid = true;
                        }
                    }

                    // si le numéro de chambre est valide, on l'ajoute à la base de données
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
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try {
                if (Utils.HotelIsConnected() && lesChambresASupprimmer.Count > 0)
                {
                    // ordonner lesChambresASupprimmer par numero de chambre
                    lesChambresASupprimmer = lesChambresASupprimmer.OrderBy(chambre => chambre.nochambre).ToList();

                    string lesChambresASupprimmerStr = "";
                    // Préparation du message de confirmation de suppression
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
                            // si la chambre a des réservation
                            if (chambreASupprimer.reservation.Any())
                            {
                                //message de confirmation de suppression
                                canDeleteChambre = MessageBox.Show($"La chambre {chambreASupprimer.nochambre} a des réservations, voulez-vous vraiment la supprimer ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
                                // retirer la chambre de la reservation
                                if (canDeleteChambre)
                                {
                                    // pour chaque réservation de la chambre, on retire la chambre de la réservation
                                    foreach (var reservation in chambreASupprimer.reservation)
                                    {
                                        reservation.chambre.Remove(chambreASupprimer);
                                    }
                                    varglobale.connexion.SaveChanges();
                                }
                            }
                            // si la chambre n'a pas de réservation ou que l'utilisateur a confirmé la suppression
                            if (canDeleteChambre)
                            {
                                varglobale.hotel.chambre.Remove(chambreASupprimer);
                                varglobale.connexion.SaveChanges();

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
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
            }
        }

        private void cbNumChambreCustom_CheckedChanged(object sender, EventArgs e)
        {
            try {
                numericUpDownNewNumChambre.Value = varglobale.hotel.chambre.Max(chambre => chambre.nochambre) + 1;
                numericUpDownNewNumChambre.Visible = cbNumChambreCustom.Checked;
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
            }
        }
    }
}
