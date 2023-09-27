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
    public partial class FrmConnexion : Form
    {
        private FrmMain formMain = Application.OpenForms.OfType<FrmMain>().FirstOrDefault();
        public FrmConnexion()
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
            }
            else
            {
                PanelFormLogin();
            }
        }

        public void PanelFormLogin()
        {
            panelLogin.Visible = true;
            btnLogout.Visible = false;
            this.BackColor = Color.RoyalBlue;
        }

        public void PanelFormLogout()
        {
            panelLogin.Visible = false;
            btnLogout.Visible = true;
            // faire disparaitre la couleur de fond
            this.BackColor = DefaultBackColor;
        }

        

        private void btnConnect_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            if (passerelleConnexion.initConnexion(txtId.Text, txtPw.Text))
            {
                Application.OpenForms.OfType<FrmMain>().FirstOrDefault().RefreshForm();
                RefreshConnexion();
                formMain.SwitchVisibilityFormConnexion();
            }
            else
            {
                lblInfo.Text = "Identifiant ou mot de passe incorrect";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtPw.Text = "";
            varglobale.hotel = null;
            formMain.RefreshForm();
            RefreshConnexion();
        }

        private void btnConnexionDemo_Click(object sender, EventArgs e)
        {
            varglobale.hotel = varglobale.connexion.hotel.FirstOrDefault();
            Application.OpenForms.OfType<FrmMain>().FirstOrDefault().RefreshForm();
            RefreshConnexion();
            formMain.SwitchVisibilityFormConnexion();
        }
    }
}
