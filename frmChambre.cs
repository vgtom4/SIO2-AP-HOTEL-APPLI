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
    public partial class frmChambre : Form
    {
        connexiondb connexion = varglobale.connexion;
        hotel hotel = varglobale.hotel;

        private FlowLayoutPanel flowLayoutPanelChambres;

        public frmChambre()
        {
            InitializeComponent();

            flowLayoutPanelChambres = new FlowLayoutPanel();
            flowLayoutPanelChambres.Dock = DockStyle.Fill;
            Controls.Add(flowLayoutPanelChambres);

        }

        private void frmChambre_Load(object sender, EventArgs e)
        {
            RefreshChambre();
        }

        public void RefreshChambre()
        {
            if (varglobale.hotel != null)
            {

                List<chambre> chambres = connexion.chambre.Where(chambre => chambre.nohotel == varglobale.hotel.nohotel).ToList();
                flowLayoutPanelChambres.Controls.Clear();

                foreach (var chambre in chambres)
                {
                    var btnChambre = new System.Windows.Forms.Button();
                    btnChambre.Text = $"Chambre {chambre.nochambre}";
                    btnChambre.Tag = chambre.nochambre;
                    btnChambre.Click += BtnChambre_Click;

                    flowLayoutPanelChambres.Controls.Add(btnChambre);
                }
            }
            else
            {
                //foreach (Control control in tablePanelInfo.Controls)
                //{
                //    // Vérifiez si le contrôle est de type TextBox
                //    if (control is RichTextBox RTB)
                //    {
                //        // Inversez l'état Enabled (désactiver si activé, activer si désactivé)
                //        RTB.Text = "donnée inaccessible";
                //    }
                //}
            }
        }
        private void AfficherBoutonsPourChambres()
        {
            RefreshChambre();
        }

        private void BtnChambre_Click(object sender, EventArgs e)
        {
            int idChambre = (int)((System.Windows.Forms.Button)sender).Tag;
            int idHotel = (int)varglobale.hotel.nohotel;

            if ((MessageBox.Show($"Confirmez la suppression de la chambre {idChambre} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
            {
                // Supprimez la chambre de la base de données
                chambre chambreASupprimer = connexion.chambre.Find(idHotel, idChambre);
                if (chambreASupprimer != null)
                {
                    connexion.chambre.Remove(chambreASupprimer);
                    connexion.SaveChanges();

                    // Supprimez également le bouton associé du conteneur
                    System.Windows.Forms.Button bouton = (System.Windows.Forms.Button)sender;
                    ((FlowLayoutPanel)bouton.Parent).Controls.Remove(bouton);
                }
            }
        }
    }
}
