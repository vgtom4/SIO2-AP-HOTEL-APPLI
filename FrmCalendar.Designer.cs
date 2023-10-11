namespace AP_HOTEL_APPLI
{
    partial class FrmCalendar
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
            this.DateDebut = new System.Windows.Forms.DateTimePicker();
            this.cboRes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblChambreDispo = new System.Windows.Forms.Label();
            this.btnAddRes = new FontAwesome.Sharp.IconButton();
            this.lblLesRes = new System.Windows.Forms.Label();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.listChambre = new System.Windows.Forms.CheckedListBox();
            this.rdoCreateRes = new System.Windows.Forms.RadioButton();
            this.rdoVisuRes = new System.Windows.Forms.RadioButton();
            this.panelEditBtn = new System.Windows.Forms.Panel();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DateFin = new System.Windows.Forms.DateTimePicker();
            this.TimeFin = new System.Windows.Forms.DateTimePicker();
            this.TimeDebut = new System.Windows.Forms.DateTimePicker();
            this.panelInfoClient = new System.Windows.Forms.Panel();
            this.panelEditBtn.SuspendLayout();
            this.panelInfoClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // DateDebut
            // 
            this.DateDebut.CustomFormat = "";
            this.DateDebut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateDebut.Location = new System.Drawing.Point(322, 146);
            this.DateDebut.Name = "DateDebut";
            this.DateDebut.Size = new System.Drawing.Size(387, 34);
            this.DateDebut.TabIndex = 2;
            this.DateDebut.ValueChanged += new System.EventHandler(this.DateDebut_ValueChanged);
            // 
            // cboRes
            // 
            this.cboRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRes.FormattingEnabled = true;
            this.cboRes.Location = new System.Drawing.Point(12, 233);
            this.cboRes.Name = "cboRes";
            this.cboRes.Size = new System.Drawing.Size(215, 35);
            this.cboRes.TabIndex = 3;
            this.cboRes.Visible = false;
            this.cboRes.SelectedIndexChanged += new System.EventHandler(this.cboRes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1058, 40);
            this.label2.TabIndex = 14;
            this.label2.Text = "Gestion des réservations";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChambreDispo
            // 
            this.lblChambreDispo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblChambreDispo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChambreDispo.Location = new System.Drawing.Point(12, 271);
            this.lblChambreDispo.Name = "lblChambreDispo";
            this.lblChambreDispo.Size = new System.Drawing.Size(529, 30);
            this.lblChambreDispo.TabIndex = 17;
            this.lblChambreDispo.Text = "Chambres disponibles :";
            this.lblChambreDispo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddRes
            // 
            this.btnAddRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRes.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAddRes.IconColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddRes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddRes.IconSize = 45;
            this.btnAddRes.Location = new System.Drawing.Point(633, 487);
            this.btnAddRes.Name = "btnAddRes";
            this.btnAddRes.Size = new System.Drawing.Size(160, 50);
            this.btnAddRes.TabIndex = 18;
            this.btnAddRes.Text = "Ajouter";
            this.btnAddRes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddRes.UseVisualStyleBackColor = true;
            this.btnAddRes.Click += new System.EventHandler(this.btnAddRes_Click);
            // 
            // lblLesRes
            // 
            this.lblLesRes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLesRes.Location = new System.Drawing.Point(12, 200);
            this.lblLesRes.Name = "lblLesRes";
            this.lblLesRes.Size = new System.Drawing.Size(215, 30);
            this.lblLesRes.TabIndex = 19;
            this.lblLesRes.Text = "Les réservations :";
            this.lblLesRes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.btnCancel.IconColor = System.Drawing.Color.Brown;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 45;
            this.btnCancel.Location = new System.Drawing.Point(0, 112);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 50);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSave.IconColor = System.Drawing.Color.BlueViolet;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSave.IconSize = 45;
            this.btnSave.Location = new System.Drawing.Point(0, 56);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 50);
            this.btnSave.TabIndex = 21;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnEdit.IconColor = System.Drawing.Color.IndianRed;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.Location = new System.Drawing.Point(0, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 50);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // listChambre
            // 
            this.listChambre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listChambre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listChambre.CheckOnClick = true;
            this.listChambre.ColumnWidth = 80;
            this.listChambre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listChambre.FormattingEnabled = true;
            this.listChambre.HorizontalScrollbar = true;
            this.listChambre.Location = new System.Drawing.Point(12, 305);
            this.listChambre.MultiColumn = true;
            this.listChambre.Name = "listChambre";
            this.listChambre.Size = new System.Drawing.Size(529, 236);
            this.listChambre.TabIndex = 23;
            // 
            // rdoCreateRes
            // 
            this.rdoCreateRes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdoCreateRes.AutoSize = true;
            this.rdoCreateRes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCreateRes.Location = new System.Drawing.Point(189, 67);
            this.rdoCreateRes.Name = "rdoCreateRes";
            this.rdoCreateRes.Size = new System.Drawing.Size(298, 31);
            this.rdoCreateRes.TabIndex = 24;
            this.rdoCreateRes.TabStop = true;
            this.rdoCreateRes.Text = "Création de réservation";
            this.rdoCreateRes.UseVisualStyleBackColor = true;
            this.rdoCreateRes.CheckedChanged += new System.EventHandler(this.rdoCreateRes_CheckedChanged);
            // 
            // rdoVisuRes
            // 
            this.rdoVisuRes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdoVisuRes.AutoSize = true;
            this.rdoVisuRes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoVisuRes.Location = new System.Drawing.Point(570, 67);
            this.rdoVisuRes.Name = "rdoVisuRes";
            this.rdoVisuRes.Size = new System.Drawing.Size(367, 31);
            this.rdoVisuRes.TabIndex = 25;
            this.rdoVisuRes.TabStop = true;
            this.rdoVisuRes.Text = "Visualisation des réservations";
            this.rdoVisuRes.UseVisualStyleBackColor = true;
            this.rdoVisuRes.CheckedChanged += new System.EventHandler(this.rdoVisuRes_CheckedChanged);
            // 
            // panelEditBtn
            // 
            this.panelEditBtn.Controls.Add(this.btnCancel);
            this.panelEditBtn.Controls.Add(this.btnEdit);
            this.panelEditBtn.Controls.Add(this.btnSave);
            this.panelEditBtn.Location = new System.Drawing.Point(1020, 379);
            this.panelEditBtn.Name = "panelEditBtn";
            this.panelEditBtn.Size = new System.Drawing.Size(50, 162);
            this.panelEditBtn.TabIndex = 26;
            // 
            // txtNom
            // 
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(34, 42);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(220, 27);
            this.txtNom.TabIndex = 27;
            // 
            // txtMail
            // 
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(34, 105);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(220, 27);
            this.txtMail.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 30);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nom :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 30);
            this.label5.TabIndex = 30;
            this.label5.Text = "Mail :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateFin
            // 
            this.DateFin.CustomFormat = "";
            this.DateFin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFin.Location = new System.Drawing.Point(322, 200);
            this.DateFin.Name = "DateFin";
            this.DateFin.Size = new System.Drawing.Size(387, 34);
            this.DateFin.TabIndex = 31;
            this.DateFin.ValueChanged += new System.EventHandler(this.DateFin_ValueChanged);
            // 
            // TimeFin
            // 
            this.TimeFin.CustomFormat = "HH\'h\'mm";
            this.TimeFin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeFin.Location = new System.Drawing.Point(730, 200);
            this.TimeFin.Name = "TimeFin";
            this.TimeFin.ShowUpDown = true;
            this.TimeFin.Size = new System.Drawing.Size(97, 34);
            this.TimeFin.TabIndex = 33;
            this.TimeFin.ValueChanged += new System.EventHandler(this.TimeFin_ValueChanged);
            // 
            // TimeDebut
            // 
            this.TimeDebut.CustomFormat = "HH\'h\'mm";
            this.TimeDebut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeDebut.Location = new System.Drawing.Point(730, 146);
            this.TimeDebut.Name = "TimeDebut";
            this.TimeDebut.ShowUpDown = true;
            this.TimeDebut.Size = new System.Drawing.Size(97, 34);
            this.TimeDebut.TabIndex = 32;
            this.TimeDebut.ValueChanged += new System.EventHandler(this.TimeDebut_ValueChanged);
            // 
            // panelInfoClient
            // 
            this.panelInfoClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfoClient.Controls.Add(this.label1);
            this.panelInfoClient.Controls.Add(this.txtNom);
            this.panelInfoClient.Controls.Add(this.txtMail);
            this.panelInfoClient.Controls.Add(this.label5);
            this.panelInfoClient.Location = new System.Drawing.Point(573, 305);
            this.panelInfoClient.Name = "panelInfoClient";
            this.panelInfoClient.Size = new System.Drawing.Size(289, 150);
            this.panelInfoClient.TabIndex = 34;
            // 
            // FrmCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.panelInfoClient);
            this.Controls.Add(this.TimeFin);
            this.Controls.Add(this.TimeDebut);
            this.Controls.Add(this.DateFin);
            this.Controls.Add(this.panelEditBtn);
            this.Controls.Add(this.rdoVisuRes);
            this.Controls.Add(this.rdoCreateRes);
            this.Controls.Add(this.listChambre);
            this.Controls.Add(this.lblLesRes);
            this.Controls.Add(this.btnAddRes);
            this.Controls.Add(this.lblChambreDispo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboRes);
            this.Controls.Add(this.DateDebut);
            this.Name = "FrmCalendar";
            this.Text = "FrmCalendar";
            this.Load += new System.EventHandler(this.FrmCalendar_Load);
            this.panelEditBtn.ResumeLayout(false);
            this.panelInfoClient.ResumeLayout(false);
            this.panelInfoClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DateDebut;
        private System.Windows.Forms.ComboBox cboRes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblChambreDispo;
        private FontAwesome.Sharp.IconButton btnAddRes;
        private System.Windows.Forms.Label lblLesRes;
        private FontAwesome.Sharp.IconButton btnCancel;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnEdit;
        private System.Windows.Forms.CheckedListBox listChambre;
        private System.Windows.Forms.RadioButton rdoCreateRes;
        private System.Windows.Forms.RadioButton rdoVisuRes;
        private System.Windows.Forms.Panel panelEditBtn;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DateFin;
        private System.Windows.Forms.DateTimePicker TimeFin;
        private System.Windows.Forms.DateTimePicker TimeDebut;
        private System.Windows.Forms.Panel panelInfoClient;
    }
}