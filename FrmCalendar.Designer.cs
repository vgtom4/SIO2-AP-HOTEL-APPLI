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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cboRes = new System.Windows.Forms.ComboBox();
            this.btnAddRes = new System.Windows.Forms.Button();
            this.lblInfoNbChambre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sélectionnez une date pour en voir les réservations";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 91);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(297, 22);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cboRes
            // 
            this.cboRes.FormattingEnabled = true;
            this.cboRes.Location = new System.Drawing.Point(57, 161);
            this.cboRes.Name = "cboRes";
            this.cboRes.Size = new System.Drawing.Size(215, 24);
            this.cboRes.TabIndex = 3;
            this.cboRes.Visible = false;
            // 
            // btnAddRes
            // 
            this.btnAddRes.Location = new System.Drawing.Point(429, 140);
            this.btnAddRes.Name = "btnAddRes";
            this.btnAddRes.Size = new System.Drawing.Size(122, 45);
            this.btnAddRes.TabIndex = 5;
            this.btnAddRes.Text = "Ajouter ";
            this.btnAddRes.UseVisualStyleBackColor = true;
            this.btnAddRes.Visible = false;
            this.btnAddRes.Click += new System.EventHandler(this.btnAddRes_Click);
            // 
            // lblInfoNbChambre
            // 
            this.lblInfoNbChambre.AutoSize = true;
            this.lblInfoNbChambre.Location = new System.Drawing.Point(413, 97);
            this.lblInfoNbChambre.Name = "lblInfoNbChambre";
            this.lblInfoNbChambre.Size = new System.Drawing.Size(0, 16);
            this.lblInfoNbChambre.TabIndex = 6;
            // 
            // FrmCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 206);
            this.Controls.Add(this.lblInfoNbChambre);
            this.Controls.Add(this.btnAddRes);
            this.Controls.Add(this.cboRes);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "FrmCalendar";
            this.Text = "FrmCalendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cboRes;
        private System.Windows.Forms.Button btnAddRes;
        private System.Windows.Forms.Label lblInfoNbChambre;
    }
}