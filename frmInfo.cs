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
    public partial class FrmInfo : Form
    {
        bool editMode;
        public FrmInfo()
        {
            InitializeComponent();
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {
            editMode = false;
            IsEditMode();
            RefreshInfo();
        }

        public void IsEditMode()
        {
            // Parcoure tous les contrôles dans le TableLayoutPanel
            foreach (Control control in tablePanelInfo.Controls)
            {
                // Vérifie si le contrôle est de type TextBox
                if (control is RichTextBox RTB)
                {
                    // Bascule l'état du TextBox en fonction de l'état du mode d'édition
                    RTB.ReadOnly = !editMode || control == txtNo;

                    // ReadOnly si l'hotel est connecté
                    RTB.Enabled = varglobale.hotel != null;
                }
            }
            if (varglobale.hotel != null)
            {
                btnEdit.Visible = !editMode;
                btnSave.Visible = editMode;
                btnCancel.Visible = editMode;
            }
            else
            {
                btnEdit.Visible = false;
                btnSave.Visible = false;
                btnCancel.Visible = false;
                editMode = false;
            }
            
            
        }

        public void RefreshInfo()
        {
            IsEditMode();
            if (varglobale.hotel != null)
            {
                txtNo.Text = varglobale.hotel.nohotel.ToString();
                txtNom.Text = varglobale.hotel.nom;
                txtPassword.Text = varglobale.hotel.password;
                txtAdr1.Text = varglobale.hotel.adr1;
                txtAdr2.Text = varglobale.hotel.adr2;
                txtVille.Text = varglobale.hotel.ville;
                txtCP.Text = varglobale.hotel.cp.ToString();
                txtTel.Text = varglobale.hotel.tel.ToString();

                txtDescL.Text = varglobale.hotel.deslong;
                txtDescC.Text = varglobale.hotel.descourt;
                txtPrix.Text = varglobale.hotel.prix.ToString();
            }
            else
            {
                foreach (Control RTB in tablePanelInfo.Controls.OfType<RichTextBox>())
                {
                    RTB.Text = "donnée inaccessible";
                    // Vérifiez si le contrôle est de type TextBox
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (varglobale.hotel != null)
            {
                editMode = true;
                RefreshInfo();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DataIsCorrect())
            {
                editMode = false;
                EditHotel();
                Application.OpenForms.OfType<FrmMain>().FirstOrDefault().RefreshForm();
                RefreshInfo();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            RemoveErrorsProvider();
            editMode = false;
            RefreshInfo();
        }

        List<ErrorProvider> listErrorProviders = new List<ErrorProvider>();
        public void RemoveErrorsProvider()
        {
            foreach (var errorProvider in listErrorProviders)
            {
                errorProvider.Clear();
            }
        }

        public bool DataIsCorrect()
        {
            RemoveErrorsProvider();

            bool dataIsCorrect = true;
            // Liste des contrôles à ignorer car peuvent être vides
            List<RichTextBox> controlsToIgnoreBecauseCanBeEmpty = new List<RichTextBox> { txtAdr2 };

            // Liste des contrôles invalide
            List<RichTextBox> invalidControls = new List<RichTextBox>();

            foreach (Control RTB in tablePanelInfo.Controls.OfType<RichTextBox>())
            {
                // Si le contrôle est vide et n'est pas dans la liste des contrôles à ignorer
                if (RTB.Text == "" && !controlsToIgnoreBecauseCanBeEmpty.Contains(RTB))
                {
                    // Ajoutez le contrôle à la liste des contrôles invalides
                    invalidControls.Add((RichTextBox)RTB);
                    dataIsCorrect = false;
                }
            }

            // instance d'error provider pour tout les contrôles invalides
            
            foreach (var RTB in invalidControls)
            {
                ErrorProvider errorProvider = new ErrorProvider();
                errorProvider.SetError(RTB, "Veuillez remplir ce champ");
                listErrorProviders.Add(errorProvider);
            }

            return dataIsCorrect;
        }

        private void EditHotel()
        {
            try
            {
                if (varglobale.hotel != null)
                {
                    varglobale.hotel.nom = txtNom.Text;
                    varglobale.hotel.password = txtPassword.Text;
                    varglobale.hotel.adr1 = txtAdr1.Text;
                    varglobale.hotel.adr2 = txtAdr2.Text;
                    varglobale.hotel.ville = txtVille.Text;
                    varglobale.hotel.cp = txtCP.Text;
                    varglobale.hotel.tel = txtTel.Text;
                    varglobale.hotel.deslong = txtDescL.Text;
                    varglobale.hotel.descourt = txtDescC.Text;
                    varglobale.hotel.prix = int.Parse(txtPrix.Text);
                    varglobale.connexion.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Aucun hotel n'est connecté");
                }
            } catch (Exception)
            {
                
            }
        }
    }
}
