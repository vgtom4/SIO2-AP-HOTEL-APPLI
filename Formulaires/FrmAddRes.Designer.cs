namespace AP_HOTEL_APPLI
{
    partial class FrmAddRes
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
            this.DateFin = new System.Windows.Forms.DateTimePicker();
            this.DateDebut = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listChambre = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblChambreDispo = new System.Windows.Forms.Label();
            this.btnAddRes = new AP_HOTEL_APPLI.Controlers.CustomButton();
            this.SuspendLayout();
            // 
            // DateFin
            // 
            this.DateFin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DateFin.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.DateFin.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.DateFin.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.DateFin.CustomFormat = "dddd dd MMMM yyyy   \'à\'   HH\'h\'mm";
            this.DateFin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateFin.Location = new System.Drawing.Point(12, 113);
            this.DateFin.Name = "DateFin";
            this.DateFin.Size = new System.Drawing.Size(518, 34);
            this.DateFin.TabIndex = 42;
            this.DateFin.ValueChanged += new System.EventHandler(this.DateFin_ValueChanged);
            // 
            // DateDebut
            // 
            this.DateDebut.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DateDebut.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.DateDebut.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.DateDebut.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.DateDebut.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.DateDebut.CustomFormat = "dddd dd MMMM yyyy   \'à\'   HH\'h\'mm";
            this.DateDebut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateDebut.Location = new System.Drawing.Point(12, 32);
            this.DateDebut.Name = "DateDebut";
            this.DateDebut.Size = new System.Drawing.Size(518, 34);
            this.DateDebut.TabIndex = 34;
            this.DateDebut.ValueChanged += new System.EventHandler(this.DateDebut_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 30);
            this.label1.TabIndex = 40;
            this.label1.Text = "Nom :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNom
            // 
            this.txtNom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(166, 207);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(220, 27);
            this.txtNom.TabIndex = 38;
            // 
            // txtMail
            // 
            this.txtMail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(166, 270);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(220, 27);
            this.txtMail.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(166, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 30);
            this.label5.TabIndex = 41;
            this.label5.Text = "Mail :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.listChambre.Location = new System.Drawing.Point(586, 85);
            this.listChambre.MultiColumn = true;
            this.listChambre.Name = "listChambre";
            this.listChambre.Size = new System.Drawing.Size(440, 340);
            this.listChambre.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(494, 23);
            this.label2.TabIndex = 45;
            this.label2.Text = "Début réservation";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(490, 23);
            this.label3.TabIndex = 46;
            this.label3.Text = "Fin réservation :";
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblInfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(166, 312);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(220, 23);
            this.lblInfo.TabIndex = 47;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChambreDispo
            // 
            this.lblChambreDispo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChambreDispo.Location = new System.Drawing.Point(581, 52);
            this.lblChambreDispo.Name = "lblChambreDispo";
            this.lblChambreDispo.Size = new System.Drawing.Size(292, 30);
            this.lblChambreDispo.TabIndex = 48;
            this.lblChambreDispo.Text = "Chambres disponibles :";
            this.lblChambreDispo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddRes
            // 
            this.btnAddRes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.btnAddRes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.btnAddRes.BorderColor = System.Drawing.Color.LightPink;
            this.btnAddRes.BorderRadius = 5;
            this.btnAddRes.BorderSize = 0;
            this.btnAddRes.FlatAppearance.BorderSize = 0;
            this.btnAddRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.btnAddRes.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAddRes.IconColor = System.Drawing.Color.Teal;
            this.btnAddRes.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAddRes.IconSize = 46;
            this.btnAddRes.Location = new System.Drawing.Point(109, 338);
            this.btnAddRes.Name = "btnAddRes";
            this.btnAddRes.Size = new System.Drawing.Size(329, 50);
            this.btnAddRes.TabIndex = 49;
            this.btnAddRes.Text = "Ajouter la réservation";
            this.btnAddRes.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.btnAddRes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddRes.UseVisualStyleBackColor = false;
            this.btnAddRes.Click += new System.EventHandler(this.btnAddRes_Click);
            // 
            // FrmAddRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(1058, 437);
            this.Controls.Add(this.btnAddRes);
            this.Controls.Add(this.lblChambreDispo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateFin);
            this.Controls.Add(this.DateDebut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listChambre);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddRes";
            this.Text = "FrmAddRes";
            this.Load += new System.EventHandler(this.FrmAddRes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker DateFin;
        private System.Windows.Forms.DateTimePicker DateDebut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox listChambre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblChambreDispo;
        private Controlers.CustomButton btnAddRes;
    }
}