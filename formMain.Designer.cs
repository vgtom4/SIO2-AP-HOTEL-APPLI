﻿namespace AP_HOTEL_APPLI
{
    partial class formMain
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnCompte = new FontAwesome.Sharp.IconButton();
            this.btnInfoHotel = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelConnexion = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(946, 32);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(194, 50);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "label1";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCompte
            // 
            this.btnCompte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompte.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnCompte.IconColor = System.Drawing.Color.LightCoral;
            this.btnCompte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompte.IconSize = 45;
            this.btnCompte.Location = new System.Drawing.Point(890, 32);
            this.btnCompte.Name = "btnCompte";
            this.btnCompte.Size = new System.Drawing.Size(50, 50);
            this.btnCompte.TabIndex = 2;
            this.btnCompte.UseVisualStyleBackColor = true;
            this.btnCompte.Click += new System.EventHandler(this.btnCompte_Click);
            // 
            // btnInfoHotel
            // 
            this.btnInfoHotel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInfoHotel.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.btnInfoHotel.IconColor = System.Drawing.Color.RoyalBlue;
            this.btnInfoHotel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfoHotel.IconSize = 45;
            this.btnInfoHotel.Location = new System.Drawing.Point(834, 32);
            this.btnInfoHotel.Name = "btnInfoHotel";
            this.btnInfoHotel.Size = new System.Drawing.Size(50, 50);
            this.btnInfoHotel.TabIndex = 3;
            this.btnInfoHotel.UseVisualStyleBackColor = true;
            this.btnInfoHotel.Click += new System.EventHandler(this.btnInfoHotel_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktop.Location = new System.Drawing.Point(40, 119);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1100, 600);
            this.panelDesktop.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AP_HOTEL_APPLI.Properties.Resources.logo_balladins;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panelConnexion
            // 
            this.panelConnexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelConnexion.Location = new System.Drawing.Point(890, 88);
            this.panelConnexion.Name = "panelConnexion";
            this.panelConnexion.Size = new System.Drawing.Size(280, 200);
            this.panelConnexion.TabIndex = 5;
            this.panelConnexion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelConnexion_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(770, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelConnexion);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.btnInfoHotel);
            this.Controls.Add(this.btnCompte);
            this.Controls.Add(this.lblInfo);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "formMain";
            this.Text = "Base";
            this.Load += new System.EventHandler(this.formBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private FontAwesome.Sharp.IconButton btnCompte;
        private FontAwesome.Sharp.IconButton btnInfoHotel;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelConnexion;
        private System.Windows.Forms.Button button1;
    }
}