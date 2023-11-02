namespace AP_HOTEL_APPLI
{
    partial class FrmChambre
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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelChambres = new System.Windows.Forms.FlowLayoutPanel();
            this.cbNumChambreCustom = new System.Windows.Forms.CheckBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.numericUpDownNewNumChambre = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnDelete = new AP_HOTEL_APPLI.Controlers.CustomButton();
            this.btnAddChambre = new AP_HOTEL_APPLI.Controlers.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewNumChambre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1076, 40);
            this.label1.TabIndex = 13;
            this.label1.Text = "Gestion des chambres";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelChambres
            // 
            this.flowLayoutPanelChambres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelChambres.AutoScroll = true;
            this.flowLayoutPanelChambres.Location = new System.Drawing.Point(12, 51);
            this.flowLayoutPanelChambres.Name = "flowLayoutPanelChambres";
            this.flowLayoutPanelChambres.Size = new System.Drawing.Size(1020, 537);
            this.flowLayoutPanelChambres.TabIndex = 14;
            // 
            // cbNumChambreCustom
            // 
            this.cbNumChambreCustom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbNumChambreCustom.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbNumChambreCustom.ForeColor = System.Drawing.Color.White;
            this.cbNumChambreCustom.Location = new System.Drawing.Point(1033, 427);
            this.cbNumChambreCustom.Name = "cbNumChambreCustom";
            this.cbNumChambreCustom.Size = new System.Drawing.Size(50, 22);
            this.cbNumChambreCustom.TabIndex = 15;
            this.cbNumChambreCustom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.cbNumChambreCustom, "Activer/Désactiver le numéro de chambre personnalisé");
            this.cbNumChambreCustom.UseVisualStyleBackColor = true;
            this.cbNumChambreCustom.CheckedChanged += new System.EventHandler(this.cbNumChambreCustom_CheckedChanged);
            // 
            // numericUpDownNewNumChambre
            // 
            this.numericUpDownNewNumChambre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownNewNumChambre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.numericUpDownNewNumChambre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownNewNumChambre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownNewNumChambre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.numericUpDownNewNumChambre.Location = new System.Drawing.Point(1033, 455);
            this.numericUpDownNewNumChambre.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownNewNumChambre.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNewNumChambre.Name = "numericUpDownNewNumChambre";
            this.numericUpDownNewNumChambre.Size = new System.Drawing.Size(50, 21);
            this.numericUpDownNewNumChambre.TabIndex = 17;
            this.toolTip.SetToolTip(this.numericUpDownNewNumChambre, "Numéro de la chambre à ajouter");
            this.numericUpDownNewNumChambre.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.btnDelete.IconSize = 46;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(1033, 538);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 50);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.toolTip.SetToolTip(this.btnDelete, "Supprimer les chambres sélectionnées");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddChambre
            // 
            this.btnAddChambre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddChambre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.btnAddChambre.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.btnAddChambre.BorderColor = System.Drawing.Color.LightPink;
            this.btnAddChambre.BorderRadius = 5;
            this.btnAddChambre.BorderSize = 0;
            this.btnAddChambre.FlatAppearance.BorderSize = 0;
            this.btnAddChambre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddChambre.ForeColor = System.Drawing.Color.White;
            this.btnAddChambre.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAddChambre.IconColor = System.Drawing.Color.Teal;
            this.btnAddChambre.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAddChambre.IconSize = 46;
            this.btnAddChambre.Location = new System.Drawing.Point(1033, 482);
            this.btnAddChambre.Name = "btnAddChambre";
            this.btnAddChambre.Size = new System.Drawing.Size(50, 50);
            this.btnAddChambre.TabIndex = 21;
            this.btnAddChambre.TextColor = System.Drawing.Color.White;
            this.toolTip.SetToolTip(this.btnAddChambre, "Ajouter une chambre");
            this.btnAddChambre.UseVisualStyleBackColor = false;
            this.btnAddChambre.Click += new System.EventHandler(this.btnAddChambre_Click);
            // 
            // FrmChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddChambre);
            this.Controls.Add(this.numericUpDownNewNumChambre);
            this.Controls.Add(this.cbNumChambreCustom);
            this.Controls.Add(this.flowLayoutPanelChambres);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "FrmChambre";
            this.Text = "frmChambre";
            this.Load += new System.EventHandler(this.frmChambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNewNumChambre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChambres;
        private System.Windows.Forms.CheckBox cbNumChambreCustom;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.NumericUpDown numericUpDownNewNumChambre;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Controlers.CustomButton btnDelete;
        private Controlers.CustomButton btnAddChambre;
    }
}