using AP_HOTEL_APPLI.ClasseTechniques;
using AP_HOTEL_APPLI.Controlers;
using AP_HOTEL_APPLI.Formulaires;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        private void formMain_Load(object sender, EventArgs e)
        {
            RefreshAffichageConnexion();

            // Instanciation du formulaire d'accueil
            originalBackColor = btnReservation.BackColor;
            ActivateButton(null);
            OpenChildForm(new FrmAccueil());
        }

        #region Main
        /// <summary>
        /// Permet d'actualiser les informations de tous les formulaires
        /// </summary>
        public void RefreshAllForms()
        {
            try {
                RefreshAffichageConnexion();
                Application.OpenForms.OfType<FrmInfo>().FirstOrDefault()?.RefreshInfo();
                Application.OpenForms.OfType<FrmChambre>().FirstOrDefault()?.RefreshChambre();
                Application.OpenForms.OfType<FrmReservation>().FirstOrDefault()?.RefreshReservationForms();
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
            }
        }

        /// <summary> 
        /// Permet d'afficher un formulaire enfant dans la zone de travail "panelDesktop". 
        /// </summary>
        /// <param name="childForm">Nouveau formulaire à afficher</param>
        private void OpenChildForm(Form childForm, object senderBtn = null)
        {
            try {
                // Vérifie si le formulaire actuel est différent du formulaire à ouvrir
                if (currentChildForm == null || currentChildForm.GetType() != childForm.GetType())
                {
                    // Ferme le formulaire actuel s'il existe
                    currentChildForm?.Close();

                    if (Utils.HotelIsConnected())
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
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
            }
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            // Ouvre le formulaire de gestion des réservations de l'hotel connecté
            OpenChildForm(new FrmReservation(), sender);
        }

        private void btnChambre_Click(object sender, EventArgs e)
        {
            // Ouvre le formulaire de gestion des chambres de l'hotel connecté
            OpenChildForm(new FrmChambre(), sender);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            // Ouvre le formulaire de gestion des informations de l'hotel connecté
            OpenChildForm(new FrmInfo(), sender);
        }
        #endregion

        #region Connexion
        /// <summary>
        /// Permet de gérer l'affichage des éléments de connexion en fonction du compte connecté
        /// </summary>
        public void RefreshAffichageConnexion()
        {
            try {
                // Si un compte est connecté, affiche le nom de l'hôtel et cache les inputs de connexion
                if (Utils.HotelIsConnected())
                {
                    lblInfo.Text = $"Hotel \n{varglobale.hotel.nom}";
                    lblInfo.Visible = true;
                    lblInfo.BringToFront();
                    tablePanelConnexion.Visible = false;
                    btnSignIn.Visible = false;
                    btnSignOut.Visible = true;
                }
                // Sinon, on affiche les inputs de connexion et cache le nom de l'hôtel
                else
                {
                    lblInfo.Text = "Vous n'êtes pas connecté";
                    lblInfo.Visible = false;
                    tablePanelConnexion.Visible = true;
                    btnSignIn.Visible = true;
                    btnSignOut.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
            }
        }

        List<ErrorProvider> listErrorProviders = new List<ErrorProvider>();
        /// <summary>
        /// Permet de vérifier si les données saisies sont correctes et d'afficher les erreurs si besoin
        /// </summary>
        /// <param name="connected"></param>
        /// <returns></returns>
        private bool DataIsCorrect()
        {
            try {
                // Supprime les erreurs précédentes
                Utils.RemoveErrorProviders(listErrorProviders);

                // Liste des contrôles invalide
                Dictionary<Control, string> invalidControls = new Dictionary<Control, string>();

                // Vérifie si les champs sont vides
                // Si oui, on ajoute le contrôle à la liste des contrôles invalides
                if (txtId.Text == "") invalidControls.Add(txtId, "Veuillez remplir ce champ");
                if (txtPwd.Text == "") invalidControls.Add(txtPwd, "Veuillez remplir ce champ");

                // Vérifie si les données saisies sont correctes
                if (invalidControls.Count == 0 && varglobale.hotel == null)
                {
                    invalidControls.Add(txtId, "Identifiant ou mot de passe incorrect");
                    invalidControls.Add(txtPwd, "Identifiant ou mot de passe incorrect");
                }

                // Affiche les erreurs
                Utils.SetErrorProviders(listErrorProviders, invalidControls);

                // Retourne si les données sont correctes ou non
                return !invalidControls.Any();
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
                return false;
            }
        }

        // Permet de se connecter à un compte
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try {
                lblInfo.Text = "";
                // Initialise la connexion
                bool isConnected = PasserelleConnexion.InitConnexion(txtId.Text, txtPwd.Text);
                // Si les données saisies sont correctes et que la connexion est réussie, on actualiase les formulaires
                if (DataIsCorrect() && isConnected)
                {
                    RefreshAllForms();
                }
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
            }
        }

        // Permet de se déconnecter d'un compte
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            try {
                txtId.Text = "";
                txtPwd.Text = "";
                varglobale.hotel = null;
                ActivateButton(null);
                OpenChildForm(new FrmAccueil());
                RefreshAllForms();
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
            }
        }
        
        // Bouton de test pour se connecter au premier hotel de la base de données (demo)
        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                varglobale.hotel = varglobale.connexion.hotel.FirstOrDefault();
                RefreshAllForms();
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
            }

        }
        #endregion


        #region Gestion fenêtre (minimiser, fermer, déplacer, couleurs boutons) 
        /// <summary> Permet de changer la couleur du bouton cliqué. </summary>
        /// <param name="senderBtn">Bouton cliqué</param>
        private void ActivateButton(object senderBtn)
        {
            try {
                DisableButton();
                if (senderBtn != null)
                {
                    currentBtn = (CustomButton)senderBtn;
                    currentBtn.BackColor = Color.FromArgb(246, 160, 56);
                }
            }
            catch (Exception ex)
            {
                Utils.GenerateFileError(ex);
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