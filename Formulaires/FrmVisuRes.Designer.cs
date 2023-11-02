namespace AP_HOTEL_APPLI
{
    partial class FrmVisuRes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelEditBtn = new System.Windows.Forms.Panel();
            this.btnEdit = new AP_HOTEL_APPLI.Controlers.CustomButton();
            this.btnSave = new AP_HOTEL_APPLI.Controlers.CustomButton();
            this.btnCancel = new AP_HOTEL_APPLI.Controlers.CustomButton();
            this.btnDelete = new AP_HOTEL_APPLI.Controlers.CustomButton();
            this.listChambre = new System.Windows.Forms.CheckedListBox();
            this.lblLesRes = new System.Windows.Forms.Label();
            this.lblChambreDispo = new System.Windows.Forms.Label();
            this.cboRes = new System.Windows.Forms.ComboBox();
            this.DateDebut = new System.Windows.Forms.DateTimePicker();
            this.rtbInfoRes = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelEditBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEditBtn
            // 
            this.panelEditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEditBtn.Controls.Add(this.btnEdit);
            this.panelEditBtn.Controls.Add(this.btnSave);
            this.panelEditBtn.Controls.Add(this.btnCancel);
            this.panelEditBtn.Controls.Add(this.btnDelete);
            this.panelEditBtn.Location = new System.Drawing.Point(996, 198);
            this.panelEditBtn.Name = "panelEditBtn";
            this.panelEditBtn.Size = new System.Drawing.Size(50, 218);
            this.panelEditBtn.TabIndex = 38;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.btnEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.btnEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEdit.BorderRadius = 5;
            this.btnEdit.BorderSize = 0;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnEdit.IconColor = System.Drawing.Color.Navy;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.Location = new System.Drawing.Point(0, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 50);
            this.btnEdit.TabIndex = 41;
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.btnEdit, "Modifier les chambres de la réservation");
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 5;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSave.IconColor = System.Drawing.Color.Purple;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSave.Location = new System.Drawing.Point(0, 56);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 50);
            this.btnSave.TabIndex = 42;
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.btnSave, "Enregistrer les changements");
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.btnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.btnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancel.BorderRadius = 5;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.btnCancel.IconColor = System.Drawing.Color.DarkRed;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.Location = new System.Drawing.Point(0, 112);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 50);
            this.btnCancel.TabIndex = 43;
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.btnCancel, "Annuler les changements");
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.btnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 5;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.DarkRed;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnDelete.Location = new System.Drawing.Point(0, 168);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 50);
            this.btnDelete.TabIndex = 44;
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.btnDelete, "Supprimer la réservation actuelle");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listChambre
            // 
            this.listChambre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listChambre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.listChambre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listChambre.CheckOnClick = true;
            this.listChambre.ColumnWidth = 80;
            this.listChambre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listChambre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.listChambre.FormattingEnabled = true;
            this.listChambre.HorizontalScrollbar = true;
            this.listChambre.Location = new System.Drawing.Point(461, 189);
            this.listChambre.MultiColumn = true;
            this.listChambre.Name = "listChambre";
            this.listChambre.Size = new System.Drawing.Size(529, 236);
            this.listChambre.TabIndex = 37;
            // 
            // lblLesRes
            // 
            this.lblLesRes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLesRes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F);
            this.lblLesRes.Location = new System.Drawing.Point(111, 79);
            this.lblLesRes.Name = "lblLesRes";
            this.lblLesRes.Size = new System.Drawing.Size(215, 30);
            this.lblLesRes.TabIndex = 36;
            this.lblLesRes.Text = "Les réservations :";
            this.lblLesRes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblChambreDispo
            // 
            this.lblChambreDispo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChambreDispo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChambreDispo.Location = new System.Drawing.Point(461, 155);
            this.lblChambreDispo.Name = "lblChambreDispo";
            this.lblChambreDispo.Size = new System.Drawing.Size(529, 30);
            this.lblChambreDispo.TabIndex = 35;
            this.lblChambreDispo.Text = "Chambres disponibles :";
            this.lblChambreDispo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboRes
            // 
            this.cboRes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cboRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.cboRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.cboRes.FormattingEnabled = true;
            this.cboRes.Location = new System.Drawing.Point(111, 112);
            this.cboRes.Name = "cboRes";
            this.cboRes.Size = new System.Drawing.Size(215, 35);
            this.cboRes.TabIndex = 34;
            this.toolTip1.SetToolTip(this.cboRes, "Sélectionner une réservation");
            this.cboRes.Visible = false;
            this.cboRes.SelectedIndexChanged += new System.EventHandler(this.cboRes_SelectedIndexChanged);
            // 
            // DateDebut
            // 
            this.DateDebut.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.DateDebut.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.DateDebut.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.DateDebut.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.DateDebut.CustomFormat = "";
            this.DateDebut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateDebut.Location = new System.Drawing.Point(287, 23);
            this.DateDebut.Name = "DateDebut";
            this.DateDebut.Size = new System.Drawing.Size(387, 34);
            this.DateDebut.TabIndex = 33;
            this.DateDebut.ValueChanged += new System.EventHandler(this.DateDebut_ValueChanged);
            // 
            // rtbInfoRes
            // 
            this.rtbInfoRes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rtbInfoRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.rtbInfoRes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbInfoRes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInfoRes.ForeColor = System.Drawing.Color.White;
            this.rtbInfoRes.Location = new System.Drawing.Point(55, 189);
            this.rtbInfoRes.Name = "rtbInfoRes";
            this.rtbInfoRes.ReadOnly = true;
            this.rtbInfoRes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbInfoRes.Size = new System.Drawing.Size(339, 236);
            this.rtbInfoRes.TabIndex = 39;
            this.rtbInfoRes.Text = "";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F);
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 34);
            this.label1.TabIndex = 40;
            this.label1.Text = "Voir les réservation du";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FrmVisuRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(1058, 437);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbInfoRes);
            this.Controls.Add(this.panelEditBtn);
            this.Controls.Add(this.listChambre);
            this.Controls.Add(this.lblLesRes);
            this.Controls.Add(this.lblChambreDispo);
            this.Controls.Add(this.cboRes);
            this.Controls.Add(this.DateDebut);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVisuRes";
            this.Text = "FrmVisuRes";
            this.Load += new System.EventHandler(this.FrmVisuRes_Load);
            this.panelEditBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelEditBtn;
        private System.Windows.Forms.CheckedListBox listChambre;
        private System.Windows.Forms.Label lblLesRes;
        private System.Windows.Forms.Label lblChambreDispo;
        private System.Windows.Forms.ComboBox cboRes;
        private System.Windows.Forms.DateTimePicker DateDebut;
        private System.Windows.Forms.RichTextBox rtbInfoRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private Controlers.CustomButton btnDelete;
        private Controlers.CustomButton btnCancel;
        private Controlers.CustomButton btnSave;
        private Controlers.CustomButton btnEdit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}