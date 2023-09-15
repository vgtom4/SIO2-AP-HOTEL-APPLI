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

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            if (passerelle.initConnexion(txtId.Text, txtPw.Text))
            {
                MessageBox.Show("Connexion établie");
                // utilisation de refreshConnexion() pour mettre à jour le label de formBase
                Application.OpenForms.OfType<formMain>().FirstOrDefault().refreshConnexion();
                this.Close();
            }
            else
            {
                lblInfo.Text = "Identifiant ou mot de passe incorrect";
            }
        }
    }
}
