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
        public formMain()
        {
            InitializeComponent();
        }

        private void formBase_Load(object sender, EventArgs e)
        {
            RefreshConnexion();
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
                //frmConnexion frm = new frmConnexion();
                //frm.Show();
            }
        }

        private void btnCompte_Click(object sender, EventArgs e)
        {
            frmConnexion frmConnexion = new frmConnexion();
            frmConnexion.Show();
        }
    }
}
