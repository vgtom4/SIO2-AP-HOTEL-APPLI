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
            //lblCompte.Visible = false;
            //label1.Visible = true;
            //label2.Visible = true;
            //txtId.Visible = true;
            //txtPw.Visible = true;
            //btnConnect.Visible = true;
            //btnLogout.Visible = false;
        }

        public void PanelFormLogout()
        {
            panelLogin.Visible = false;
            panelLogout.Visible = true;
            //lblCompte.Visible = true;
            //label1.Visible = false;
            //label2.Visible = false;
            //txtId.Visible = false;
            //txtPw.Visible = false;
            //btnConnect.Visible = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            if (passerelle.initConnexion(txtId.Text, txtPw.Text))
            {
                // utilisation de refreshConnexion() pour mettre à jour le label de formBase
                Application.OpenForms.OfType<formMain>().FirstOrDefault().RefreshConnexion();
                Form1_Load(sender, e);
                this.Close();
            }
            else
            {
                lblInfo.Text = "Identifiant ou mot de passe incorrect";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            varglobale.hotel = null;
            Application.OpenForms.OfType<formMain>().FirstOrDefault().RefreshConnexion();
            Form1_Load(sender, e);
        }
    }
}
