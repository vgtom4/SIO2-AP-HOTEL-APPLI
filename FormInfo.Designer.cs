namespace AP_HOTEL_APPLI
{
    partial class FormInfo
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
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.tablePanelInfo = new System.Windows.Forms.TableLayoutPanel();
            this.txtDescC = new System.Windows.Forms.RichTextBox();
            this.txtDescL = new System.Windows.Forms.RichTextBox();
            this.txtTel = new System.Windows.Forms.RichTextBox();
            this.txtVille = new System.Windows.Forms.RichTextBox();
            this.txtCP = new System.Windows.Forms.RichTextBox();
            this.txtPassword = new System.Windows.Forms.RichTextBox();
            this.txtAdr2 = new System.Windows.Forms.RichTextBox();
            this.txtNom = new System.Windows.Forms.RichTextBox();
            this.txtAdr1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.RichTextBox();
            this.tablePanelInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1058, 43);
            this.label1.TabIndex = 12;
            this.label1.Text = "Informations";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnEdit.IconColor = System.Drawing.Color.IndianRed;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.Location = new System.Drawing.Point(1020, 479);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(50, 50);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSave.IconColor = System.Drawing.Color.BlueViolet;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSave.IconSize = 45;
            this.btnSave.Location = new System.Drawing.Point(1020, 535);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 50);
            this.btnSave.TabIndex = 13;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btnCancel.IconColor = System.Drawing.Color.Brown;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 45;
            this.btnCancel.Location = new System.Drawing.Point(1020, 591);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 50);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tablePanelInfo
            // 
            this.tablePanelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanelInfo.ColumnCount = 5;
            this.tablePanelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tablePanelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tablePanelInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelInfo.Controls.Add(this.txtDescC, 1, 7);
            this.tablePanelInfo.Controls.Add(this.txtDescL, 1, 6);
            this.tablePanelInfo.Controls.Add(this.txtTel, 4, 5);
            this.tablePanelInfo.Controls.Add(this.txtVille, 4, 3);
            this.tablePanelInfo.Controls.Add(this.txtCP, 4, 2);
            this.tablePanelInfo.Controls.Add(this.txtPassword, 1, 2);
            this.tablePanelInfo.Controls.Add(this.txtAdr2, 4, 1);
            this.tablePanelInfo.Controls.Add(this.txtNom, 1, 1);
            this.tablePanelInfo.Controls.Add(this.txtAdr1, 4, 0);
            this.tablePanelInfo.Controls.Add(this.label2, 0, 0);
            this.tablePanelInfo.Controls.Add(this.label5, 3, 0);
            this.tablePanelInfo.Controls.Add(this.label8, 0, 6);
            this.tablePanelInfo.Controls.Add(this.label3, 0, 1);
            this.tablePanelInfo.Controls.Add(this.label4, 3, 1);
            this.tablePanelInfo.Controls.Add(this.label6, 3, 2);
            this.tablePanelInfo.Controls.Add(this.label10, 3, 3);
            this.tablePanelInfo.Controls.Add(this.label9, 0, 7);
            this.tablePanelInfo.Controls.Add(this.label7, 3, 5);
            this.tablePanelInfo.Controls.Add(this.label12, 0, 2);
            this.tablePanelInfo.Controls.Add(this.txtNo, 1, 0);
            this.tablePanelInfo.Controls.Add(this.label11, 3, 7);
            this.tablePanelInfo.Controls.Add(this.txtPrix, 4, 7);
            this.tablePanelInfo.Location = new System.Drawing.Point(12, 55);
            this.tablePanelInfo.Name = "tablePanelInfo";
            this.tablePanelInfo.RowCount = 9;
            this.tablePanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tablePanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tablePanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tablePanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tablePanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tablePanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tablePanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tablePanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tablePanelInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tablePanelInfo.Size = new System.Drawing.Size(1002, 586);
            this.tablePanelInfo.TabIndex = 16;
            // 
            // txtDescC
            // 
            this.txtDescC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescC.EnableAutoDragDrop = true;
            this.txtDescC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescC.Location = new System.Drawing.Point(210, 458);
            this.txtDescC.Name = "txtDescC";
            this.txtDescC.Size = new System.Drawing.Size(305, 59);
            this.txtDescC.TabIndex = 12;
            this.txtDescC.Text = "";
            // 
            // txtDescL
            // 
            this.txtDescL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescL.EnableAutoDragDrop = true;
            this.txtDescL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescL.Location = new System.Drawing.Point(210, 393);
            this.txtDescL.Name = "txtDescL";
            this.txtDescL.Size = new System.Drawing.Size(305, 59);
            this.txtDescL.TabIndex = 11;
            this.txtDescL.Text = "";
            // 
            // txtTel
            // 
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTel.EnableAutoDragDrop = true;
            this.txtTel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(694, 328);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(305, 59);
            this.txtTel.TabIndex = 9;
            this.txtTel.Text = "";
            // 
            // txtVille
            // 
            this.txtVille.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVille.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVille.EnableAutoDragDrop = true;
            this.txtVille.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVille.Location = new System.Drawing.Point(694, 198);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(305, 59);
            this.txtVille.TabIndex = 8;
            this.txtVille.Text = "";
            // 
            // txtCP
            // 
            this.txtCP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCP.EnableAutoDragDrop = true;
            this.txtCP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCP.Location = new System.Drawing.Point(694, 133);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(305, 59);
            this.txtCP.TabIndex = 7;
            this.txtCP.Text = "";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.EnableAutoDragDrop = true;
            this.txtPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(210, 133);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(305, 59);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "";
            // 
            // txtAdr2
            // 
            this.txtAdr2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdr2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAdr2.EnableAutoDragDrop = true;
            this.txtAdr2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdr2.Location = new System.Drawing.Point(694, 68);
            this.txtAdr2.Name = "txtAdr2";
            this.txtAdr2.Size = new System.Drawing.Size(305, 59);
            this.txtAdr2.TabIndex = 6;
            this.txtAdr2.Text = "";
            // 
            // txtNom
            // 
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNom.EnableAutoDragDrop = true;
            this.txtNom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(210, 68);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(305, 59);
            this.txtNom.TabIndex = 3;
            this.txtNom.Text = "";
            // 
            // txtAdr1
            // 
            this.txtAdr1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdr1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAdr1.EnableAutoDragDrop = true;
            this.txtAdr1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdr1.Location = new System.Drawing.Point(694, 3);
            this.txtAdr1.Name = "txtAdr1";
            this.txtAdr1.Size = new System.Drawing.Size(305, 59);
            this.txtAdr1.TabIndex = 5;
            this.txtAdr1.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "N°";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(579, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Adresse 1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 411);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 23);
            this.label8.TabIndex = 23;
            this.label8.Text = "Description Longue";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nom";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(579, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Adresse 2";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(561, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Code postal";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(637, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 23);
            this.label10.TabIndex = 25;
            this.label10.Text = "Ville";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 476);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 23);
            this.label9.TabIndex = 24;
            this.label9.Text = "Description Courte";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(575, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Téléphone";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(64, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 23);
            this.label12.TabIndex = 27;
            this.label12.Text = "Mot de passe";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNo
            // 
            this.txtNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNo.EnableAutoDragDrop = true;
            this.txtNo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNo.Location = new System.Drawing.Point(210, 3);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(305, 59);
            this.txtNo.TabIndex = 2;
            this.txtNo.Text = "";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(641, 476);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 23);
            this.label11.TabIndex = 26;
            this.label11.Text = "Prix";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrix
            // 
            this.txtPrix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrix.EnableAutoDragDrop = true;
            this.txtPrix.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrix.Location = new System.Drawing.Point(694, 458);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(305, 59);
            this.txtPrix.TabIndex = 10;
            this.txtPrix.Text = "";
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.tablePanelInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "FormInfo";
            this.Text = "FormInfo";
            this.Load += new System.EventHandler(this.FormInfo_Load);
            this.tablePanelInfo.ResumeLayout(false);
            this.tablePanelInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnCancel;
        private System.Windows.Forms.TableLayoutPanel tablePanelInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox txtNo;
        private System.Windows.Forms.RichTextBox txtPrix;
        private System.Windows.Forms.RichTextBox txtDescC;
        private System.Windows.Forms.RichTextBox txtDescL;
        private System.Windows.Forms.RichTextBox txtTel;
        private System.Windows.Forms.RichTextBox txtVille;
        private System.Windows.Forms.RichTextBox txtCP;
        private System.Windows.Forms.RichTextBox txtPassword;
        private System.Windows.Forms.RichTextBox txtAdr2;
        private System.Windows.Forms.RichTextBox txtNom;
        private System.Windows.Forms.RichTextBox txtAdr1;
    }
}