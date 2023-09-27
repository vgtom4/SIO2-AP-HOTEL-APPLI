namespace AP_HOTEL_APPLI
{
    partial class FrmConnexion
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtPw = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConnexionDemo = new AP_HOTEL_APPLI.Controlers.CustomButton();
            this.btnConnect = new AP_HOTEL_APPLI.Controlers.CustomButton();
            this.btnLogout = new AP_HOTEL_APPLI.Controlers.CustomButton();
            this.panelLogin.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifiant :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            this.txtId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtId.Location = new System.Drawing.Point(23, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(234, 22);
            this.txtId.TabIndex = 3;
            // 
            // txtPw
            // 
            this.txtPw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPw.Location = new System.Drawing.Point(23, 78);
            this.txtPw.Name = "txtPw";
            this.txtPw.Size = new System.Drawing.Size(234, 22);
            this.txtPw.TabIndex = 4;
            // 
            // lblInfo
            // 
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(23, 100);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(234, 25);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLogin
            // 
            this.panelLogin.ColumnCount = 3;
            this.panelLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelLogin.Controls.Add(this.flowLayoutPanel1, 1, 5);
            this.panelLogin.Controls.Add(this.label1, 1, 0);
            this.panelLogin.Controls.Add(this.txtId, 1, 1);
            this.panelLogin.Controls.Add(this.label2, 1, 2);
            this.panelLogin.Controls.Add(this.txtPw, 1, 3);
            this.panelLogin.Controls.Add(this.lblInfo, 1, 4);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.RowCount = 6;
            this.panelLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.panelLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.panelLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.panelLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.panelLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.panelLogin.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelLogin.Size = new System.Drawing.Size(280, 200);
            this.panelLogin.TabIndex = 14;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnConnexionDemo);
            this.flowLayoutPanel1.Controls.Add(this.btnConnect);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 128);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(234, 69);
            this.flowLayoutPanel1.TabIndex = 15;
            // 
            // btnConnexionDemo
            // 
            this.btnConnexionDemo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConnexionDemo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(66)))), ((int)(((byte)(212)))));
            this.btnConnexionDemo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(66)))), ((int)(((byte)(212)))));
            this.btnConnexionDemo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConnexionDemo.BorderRadius = 0;
            this.btnConnexionDemo.BorderSize = 0;
            this.btnConnexionDemo.FlatAppearance.BorderSize = 0;
            this.btnConnexionDemo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnexionDemo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexionDemo.ForeColor = System.Drawing.Color.White;
            this.btnConnexionDemo.Location = new System.Drawing.Point(3, 3);
            this.btnConnexionDemo.Name = "btnConnexionDemo";
            this.btnConnexionDemo.Size = new System.Drawing.Size(69, 44);
            this.btnConnexionDemo.TabIndex = 10;
            this.btnConnexionDemo.Text = "Demo";
            this.btnConnexionDemo.TextColor = System.Drawing.Color.White;
            this.btnConnexionDemo.UseVisualStyleBackColor = false;
            this.btnConnexionDemo.Click += new System.EventHandler(this.btnConnexionDemo_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(66)))), ((int)(((byte)(212)))));
            this.btnConnect.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(66)))), ((int)(((byte)(212)))));
            this.btnConnect.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnConnect.BorderRadius = 0;
            this.btnConnect.BorderSize = 0;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(78, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(147, 44);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Connexion";
            this.btnConnect.TextColor = System.Drawing.Color.White;
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(66)))), ((int)(((byte)(212)))));
            this.btnLogout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(66)))), ((int)(((byte)(212)))));
            this.btnLogout.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLogout.BorderRadius = 5;
            this.btnLogout.BorderSize = 0;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(280, 200);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Se déconnecter";
            this.btnLogout.TextColor = System.Drawing.Color.White;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(169)))), ((int)(((byte)(159)))));
            this.ClientSize = new System.Drawing.Size(280, 200);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtPw;
        private System.Windows.Forms.Label lblInfo;
        private Controlers.CustomButton btnLogout;
        private System.Windows.Forms.TableLayoutPanel panelLogin;
        private Controlers.CustomButton btnConnect;
        private Controlers.CustomButton btnConnexionDemo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

