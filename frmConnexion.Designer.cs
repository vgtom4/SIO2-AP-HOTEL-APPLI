namespace AP_HOTEL_APPLI
{
    partial class frmConnexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.lblErreurId = new System.Windows.Forms.Label();
            this.lblErreurPw = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifiant :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe :";
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(247, 228);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(166, 44);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Connexion";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(247, 124);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(165, 22);
            this.txtId.TabIndex = 3;
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(247, 180);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(166, 22);
            this.txtPw.TabIndex = 4;
            // 
            // lblErreurId
            // 
            this.lblErreurId.ForeColor = System.Drawing.Color.Red;
            this.lblErreurId.Location = new System.Drawing.Point(248, 147);
            this.lblErreurId.Name = "lblErreurId";
            this.lblErreurId.Size = new System.Drawing.Size(164, 15);
            this.lblErreurId.TabIndex = 5;
            // 
            // lblErreurPw
            // 
            this.lblErreurPw.ForeColor = System.Drawing.Color.Red;
            this.lblErreurPw.Location = new System.Drawing.Point(249, 205);
            this.lblErreurPw.Name = "lblErreurPw";
            this.lblErreurPw.Size = new System.Drawing.Size(164, 15);
            this.lblErreurPw.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F);
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(232, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Se connecter";
            // 
            // frmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblErreurPw);
            this.Controls.Add(this.lblErreurId);
            this.Controls.Add(this.txtPw);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmConnexion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Label lblErreurId;
        private System.Windows.Forms.Label lblErreurPw;
        private System.Windows.Forms.Label label3;
    }
}

