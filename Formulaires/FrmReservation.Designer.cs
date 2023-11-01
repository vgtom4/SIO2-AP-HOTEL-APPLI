namespace AP_HOTEL_APPLI
{
    partial class FrmReservation
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
            this.label2 = new System.Windows.Forms.Label();
            this.rdoCreateRes = new System.Windows.Forms.RadioButton();
            this.rdoVisuRes = new System.Windows.Forms.RadioButton();
            this.panelGestion = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1058, 40);
            this.label2.TabIndex = 14;
            this.label2.Text = "Gestion des réservations";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdoCreateRes
            // 
            this.rdoCreateRes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rdoCreateRes.AutoSize = true;
            this.rdoCreateRes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCreateRes.ForeColor = System.Drawing.Color.White;
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
            this.rdoVisuRes.ForeColor = System.Drawing.Color.White;
            this.rdoVisuRes.Location = new System.Drawing.Point(570, 67);
            this.rdoVisuRes.Name = "rdoVisuRes";
            this.rdoVisuRes.Size = new System.Drawing.Size(367, 31);
            this.rdoVisuRes.TabIndex = 25;
            this.rdoVisuRes.TabStop = true;
            this.rdoVisuRes.Text = "Visualisation des réservations";
            this.rdoVisuRes.UseVisualStyleBackColor = true;
            this.rdoVisuRes.CheckedChanged += new System.EventHandler(this.rdoVisuRes_CheckedChanged);
            // 
            // panelGestion
            // 
            this.panelGestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGestion.Location = new System.Drawing.Point(12, 104);
            this.panelGestion.Name = "panelGestion";
            this.panelGestion.Size = new System.Drawing.Size(1058, 437);
            this.panelGestion.TabIndex = 35;
            // 
            // FrmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.rdoVisuRes);
            this.Controls.Add(this.rdoCreateRes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelGestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReservation";
            this.Text = "FrmCalendar";
            this.Load += new System.EventHandler(this.FrmCalendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoCreateRes;
        private System.Windows.Forms.RadioButton rdoVisuRes;
        private System.Windows.Forms.Panel panelGestion;
    }
}