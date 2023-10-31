using AP_HOTEL_APPLI.ClasseTechniques;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
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
            SwitchEditMode();
            RefreshInfo();
        }

        public void SwitchEditMode()
        {
            txtPassword.UseSystemPasswordChar = !editMode;  

            // Parcoure tous les contrôles dans le TableLayoutPanel
            foreach (Control control in tablePanelInfo.Controls)
            {
                // Vérifie si le contrôle est de type TextBox
                if (control is TextBoxBase zoneDeSaisie)
                {
                    // Bascule l'état du TextBox en fonction de l'état du mode d'édition
                    zoneDeSaisie.ReadOnly = !editMode || control == txtNo;

                    // ReadOnly si l'hotel est connecté
                    zoneDeSaisie.Enabled = varglobale.hotel != null;
                }
            }
            grdEquip.ReadOnly = !editMode;
            grdEquip.Columns[1].ReadOnly = true;

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
            SwitchEditMode();
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

                // Equipement de l'hotel
                grdEquip.Rows.Clear();
                foreach (var equipement in varglobale.connexion.equipement)
                {
                    // Ajouter dans la deuxième colonne de la ligne actuelle le nom de l'équipement
                    grdEquip.Rows[grdEquip.Rows.Add()].Cells[1].Value = equipement.lib;
                    // Check si l'équipement est présent dans l'hotel
                    if (varglobale.hotel.equipement.Contains(equipement))
                    {
                        // Ajouter dans la première colonne de la ligne actuelle un checkbox coché
                        grdEquip.Rows[grdEquip.Rows.Count - 1].Cells[0].Value = true;
                    }
                }
            }
            else
            {
                grdEquip.Rows.Clear();
                txtPassword.UseSystemPasswordChar = false;
                foreach (Control RTB in tablePanelInfo.Controls.OfType<TextBoxBase>())
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
            if (varglobale.hotel != null)
            { 
                if (DataIsCorrect())
                {
                    editMode = false;
                    HotelDAO.UpdateHotel(txtNom.Text, txtPassword.Text, txtAdr1.Text, txtAdr2.Text, txtVille.Text, txtCP.Text, txtTel.Text, txtDescL.Text, txtDescC.Text, Single.Parse(txtPrix.Text), EquipementDAO.GetLesEquipementsDGV(grdEquip));
                    Application.OpenForms.OfType<FrmMain>().FirstOrDefault().RefreshForm();
                    RefreshInfo();
                }
            }
            else
            {
                MessageBox.Show("Aucun hotel n'est connecté");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Utils.RemoveErrorsProvider(listErrorProviders);
            editMode = false;
            RefreshInfo();
        }

        List<ErrorProvider> listErrorProviders = new List<ErrorProvider>();
        public bool DataIsCorrect()
        {
            Utils.RemoveErrorsProvider(listErrorProviders);

            // Liste des contrôles à ignorer car peuvent être vides
            List<TextBoxBase> controlsToIgnoreBecauseCanBeEmpty = new List<TextBoxBase> { txtAdr2 };

            // Liste des contrôles invalide
            Dictionary<Control, string> invalidControls = new Dictionary<Control, string>();

            foreach (Control RTB in tablePanelInfo.Controls.OfType<TextBoxBase>())
            {
                // Si le contrôle est vide et n'est pas dans la liste des contrôles à ignorer
                if (RTB.Text == "" && !controlsToIgnoreBecauseCanBeEmpty.Contains(RTB))
                {
                    // Ajoutez le contrôle à la liste des contrôles invalides
                    invalidControls.Add(RTB, "Veuillez remplir ce champ");
                }
            }

            Utils.SetErrorProviders(listErrorProviders, invalidControls);

            return !invalidControls.Any();
        }

        private void grdEquip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cocher ou décocher la checkbox présente dans la première colonne de la ligne cliqué dans le DataGridView des équipements
            if (e.RowIndex >= 0 && editMode)
            {
                if (grdEquip.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    grdEquip.Rows[e.RowIndex].Cells[0].Value = !(bool)grdEquip.Rows[e.RowIndex].Cells[0].Value;
                }
                else
                {
                    grdEquip.Rows[e.RowIndex].Cells[0].Value = true;
                }
            }
        }
    }
}
