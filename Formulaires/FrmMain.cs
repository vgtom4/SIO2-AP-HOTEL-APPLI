using AP_HOTEL_APPLI.Controlers;
using AP_HOTEL_APPLI.Formulaires;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP_HOTEL_APPLI
{
    public partial class FrmMain : Form
    {
        private CustomButton currentBtn;
        private Form currentChildForm;

        private Color originalBackColor;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void formBase_Load(object sender, EventArgs e)
        {
            RefreshConnexion();
            originalBackColor = btnReservation.BackColor;
            ActivateButton(null);
            OpenChildForm(new FrmAccueil());
        }

        #region Main

        // actualisation des autres forms
        public void RefreshForm()
        {
            RefreshConnexion();
            Application.OpenForms.OfType<FrmInfo>().FirstOrDefault()?.RefreshInfo();
            Application.OpenForms.OfType<FrmChambre>().FirstOrDefault()?.RefreshChambre();
            Application.OpenForms.OfType<FrmReservation>().FirstOrDefault()?.RefreshForms();
        }

        /// <summary> Permet d'afficher un formulaire enfant dans la zone de travail "panelDesktop". </summary>
        /// <param name="childForm">Nouveau formulaire à afficher</param>
        private void OpenChildForm(Form childForm, object senderBtn = null)
        {
            // Vérifie si le formulaire actuel est différent du formulaire à ouvrir
            if (currentChildForm == null || currentChildForm.GetType() != childForm.GetType())
            {
                // Ferme le formulaire actuel s'il existe
                currentChildForm?.Close();

                if (varglobale.hotel != null)
                {
                    // Crée une nouvelle instance du formulaire à ouvrir
                    currentChildForm = (Form)Activator.CreateInstance(childForm.GetType());
                    ActivateButton(senderBtn);
                }
                else
                {
                    currentChildForm = new FrmAccueil();
                }

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

        private void btnReservation_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmReservation(), sender);
        }

        private void btnChambre_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmChambre(), sender);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmInfo(), sender);
        }
        #endregion

        #region Connexion
        public void RefreshConnexion()
        {
            if (varglobale.hotel != null)
            {
                lblInfo.Text = $"Hotel \n{varglobale.hotel.nom}";
                lblInfo.Visible = true;
                lblInfo.BringToFront();
                tablePanelConnexion.Visible = false;
                btnLogIn.Visible = false;
                btnLogOut.Visible = true;
            }
            else
            {
                lblInfo.Text = "Vous n'êtes pas connecté";
                lblInfo.Visible = false;
                tablePanelConnexion.Visible = true;
                btnLogIn.Visible = true;
                btnLogOut.Visible = false;
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
            if (passerelleConnexion.initConnexion(txtId.Text, txtPwd.Text))
            {
                RefreshForm();
            }
            else
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect");
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtPwd.Text = "";
            varglobale.hotel = null;
            ActivateButton(null);
            OpenChildForm(new FrmAccueil());
            RefreshForm();
        }
        
        private void customButton1_Click(object sender, EventArgs e)
        {
            varglobale.hotel = varglobale.connexion.hotel.FirstOrDefault();
            RefreshForm();
        }
        #endregion


        #region Gestion fenêtre (minimiser, fermer, déplacer, couleurs boutons) 
        /// <summary> Permet de changer la couleur du bouton cliqué. </summary>
        /// <param name="senderBtn">Bouton cliqué</param>
        private void ActivateButton(object senderBtn)
        {
            DisableButton();
            if (senderBtn != null)
            {
                currentBtn = (CustomButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(246, 160, 56);
            }
        }

        /// <summary> Permet de restaurer la couleur initial de tous les boutons. </summary>
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = originalBackColor;
            }
        }

        // Déplacement de la fenêtre
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Permet de déplacer la fenêtre avec la souris
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Permet de fermer l'application
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Permet d'agrandir l'application sur toute l'écran
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
                WindowState = FormWindowState.Normal;
        }

        // Permet de minimiser l'application dans la barre de tâche
        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion
    }
}