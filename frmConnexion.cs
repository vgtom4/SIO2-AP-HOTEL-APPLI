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
    public partial class frmConnexion : Form
    {
        public frmConnexion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshConnexion();
        }

        public void RefreshConnexion()
        {
            lblInfo.Text = "";
            if (varglobale.hotel != null)
            {
                PanelFormLogout();
                lblCompte.Text = varglobale.hotel.nom;
            }
            else
            {
                PanelFormLogin();
            }
        }

        public void PanelFormLogin()
        {
            panelLogin.Visible = true;
            panelLogout.Visible = false;
        }

        public void PanelFormLogout()
        {
            panelLogin.Visible = false;
            panelLogout.Visible = true;
        }

        

        private void btnConnect_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            if (passerelle.initConnexion(txtId.Text, txtPw.Text))
            {
                Application.OpenForms.OfType<formMain>().FirstOrDefault().RefreshForm();
                RefreshConnexion();
                this.Hide();
            }
            else
            {
                lblInfo.Text = "Identifiant ou mot de passe incorrect";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            varglobale.hotel = null;
            Application.OpenForms.OfType<formMain>().FirstOrDefault().RefreshForm();
            RefreshConnexion();
        }

        private void btnConnexionDemo_Click(object sender, EventArgs e)
        {
            varglobale.hotel = varglobale.connexion.hotel.FirstOrDefault();
            Application.OpenForms.OfType<formMain>().FirstOrDefault().RefreshForm();
            RefreshConnexion();
            this.Hide();
        }

        public void HideForm()
        {
            this.Hide();
            //Application.OpenForms.OfType<formMain>().FirstOrDefault().
        }

        private void frmConnexion_Deactivate(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
