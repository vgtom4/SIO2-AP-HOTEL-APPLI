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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelChambres = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddChambre = new FontAwesome.Sharp.IconButton();
            this.cboxcustom = new System.Windows.Forms.CheckBox();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1058, 40);
            this.label1.TabIndex = 13;
            this.label1.Text = "Gestion des chambres";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelChambres
            // 
            this.flowLayoutPanelChambres.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelChambres.Location = new System.Drawing.Point(12, 51);
            this.flowLayoutPanelChambres.Name = "flowLayoutPanelChambres";
            this.flowLayoutPanelChambres.Size = new System.Drawing.Size(1002, 490);
            this.flowLayoutPanelChambres.TabIndex = 14;
            // 
            // btnAddChambre
            // 
            this.btnAddChambre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddChambre.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAddChambre.IconColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddChambre.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAddChambre.IconSize = 45;
            this.btnAddChambre.Location = new System.Drawing.Point(1020, 435);
            this.btnAddChambre.Name = "btnAddChambre";
            this.btnAddChambre.Size = new System.Drawing.Size(50, 50);
            this.btnAddChambre.TabIndex = 0;
            this.btnAddChambre.UseVisualStyleBackColor = true;
            this.btnAddChambre.Click += new System.EventHandler(this.btnAddChambre_Click);
            // 
            // cboxcustom
            // 
            this.cboxcustom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxcustom.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cboxcustom.Location = new System.Drawing.Point(1009, 365);
            this.cboxcustom.Name = "cboxcustom";
            this.cboxcustom.Size = new System.Drawing.Size(73, 64);
            this.cboxcustom.TabIndex = 15;
            this.cboxcustom.Text = "N° custom";
            this.cboxcustom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cboxcustom.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Crimson;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnDelete.IconSize = 45;
            this.btnDelete.Location = new System.Drawing.Point(1020, 491);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 50);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cboxcustom);
            this.Controls.Add(this.btnAddChambre);
            this.Controls.Add(this.flowLayoutPanelChambres);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "FrmChambre";
            this.Text = "frmChambre";
            this.Load += new System.EventHandler(this.frmChambre_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChambres;
        private FontAwesome.Sharp.IconButton btnAddChambre;
        private System.Windows.Forms.CheckBox cboxcustom;
        private FontAwesome.Sharp.IconButton btnDelete;
    }
}