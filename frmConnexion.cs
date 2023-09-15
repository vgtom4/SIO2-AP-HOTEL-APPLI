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
        connexiondb maconnexion;

        public frmConnexion()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            maconnexion = new connexiondb();           
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            hotel unhotel;
            lblErreurId.Text = "";
            lblErreurPw.Text = "";
             if (maconnexion.hotel.Where(hotel => hotel.nom == txtId.Text).FirstOrDefault()!=null)
            {
                unhotel = maconnexion.hotel.Where(hotel => hotel.nom == txtId.Text).FirstOrDefault();
                if (unhotel.password == txtPw.Text)
                {
                    MessageBox.Show("Connexion réussie");
                    // Charger formulaire gestion
                    varglobale.hotel = unhotel;
                }
                else
                {
                    lblErreurPw.Text = "mot de passe erroné";
                }
            }   
             else
            {
                lblErreurId.Text = "identifiant erroné";
            }
        }
    }
}
