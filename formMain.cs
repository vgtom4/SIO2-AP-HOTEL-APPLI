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
    public partial class formMain : Form
    {
        frmConnexion frmConnexion;
        private Form currentChildForm;

        public formMain()
        {
            InitializeComponent();
        }

        private void formBase_Load(object sender, EventArgs e)
        {
            RefreshConnexion();
            frmConnexion = new frmConnexion();
            frmConnexion.TopLevel = false;
            panelConnexion.Controls.Add(frmConnexion);
            frmConnexion.Show();
            panelConnexion.Visible = false;
        }

        public void RefreshConnexion()
        {
            lblInfo.Text = string.Empty;
            if (varglobale.hotel != null)
            {
                lblInfo.Text = "Bienvenue " + varglobale.hotel.nom;
            }
            else
            {
                lblInfo.Text = "Vous n'êtes pas connecté";
            }
        }

        public void SwitchVisibilityFormConnexion()
        {
            if (panelConnexion.Visible) panelConnexion.Visible = false;
            else panelConnexion.Visible = true;
        }

        private void btnCompte_Click(object sender, EventArgs e)
        {
            SwitchVisibilityFormConnexion();
        }

        private void btnInfoHotel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormInfo());
        }

        // actualisation des autres forms
        public void RefreshForm()
        {
            Application.OpenForms.OfType<formMain>().FirstOrDefault().RefreshConnexion();
            Application.OpenForms.OfType<FormInfo>().FirstOrDefault()?.RefreshInfo();
            frmConnexion?.RefreshConnexion();
            Application.OpenForms.OfType<frmChambre>().FirstOrDefault()?.RefreshChambre();

        }

        /// <summary> Permet d'afficher un formulaire enfant dans la zone de travail "panelDesktop". </summary>
        /// <param name="childForm">Nouveau formulaire à afficher</param>
        private void OpenChildForm(Form childForm)
        {
            // Vérifie si le formulaire actuel est différent du formulaire à ouvrir
            if (currentChildForm == null || currentChildForm.GetType() != childForm.GetType())
            {
                // Ferme le formulaire actuel s'il existe
                currentChildForm?.Close();

                // Crée une nouvelle instance du formulaire à ouvrir
                currentChildForm = (Form)Activator.CreateInstance(childForm.GetType());

                // Configure les propriétés du formulaire
                currentChildForm.TopLevel = false;
                currentChildForm.FormBorderStyle = FormBorderStyle.None;
                currentChildForm.Dock = DockStyle.Fill;

                // Ajoute le formulaire à la zone de travail "panelDesktop"
                panelDesktop.Controls.Clear();
                panelDesktop.Controls.Add(currentChildForm);
                currentChildForm.BringToFront();
                currentChildForm.Show();
            }
        }

        private void panelConnexion_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("test");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmChambre());
        }
    }
}
