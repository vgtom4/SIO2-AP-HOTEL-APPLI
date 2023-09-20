namespace AP_HOTEL_APPLI
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
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(976, 12);
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
            this.btnCompte.Location = new System.Drawing.Point(920, 12);
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
            this.btnInfoHotel.Location = new System.Drawing.Point(864, 12);
            this.btnInfoHotel.Name = "btnInfoHotel";
            this.btnInfoHotel.Size = new System.Drawing.Size(50, 50);
            this.btnInfoHotel.TabIndex = 3;
            this.btnInfoHotel.UseVisualStyleBackColor = true;
            this.btnInfoHotel.Click += new System.EventHandler(this.btnInfoHotel_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.btnInfoHotel);
            this.Controls.Add(this.btnCompte);
            this.Controls.Add(this.lblInfo);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "formMain";
            this.Text = "Base";
            this.Load += new System.EventHandler(this.formBase_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private FontAwesome.Sharp.IconButton btnCompte;
        private FontAwesome.Sharp.IconButton btnInfoHotel;
    }
}