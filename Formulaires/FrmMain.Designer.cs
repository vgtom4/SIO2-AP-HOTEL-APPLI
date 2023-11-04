namespace AP_HOTEL_APPLI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lblInfo = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new AP_HOTEL_APPLI.Controlers.CustomButton();
            this.btnMin = new AP_HOTEL_APPLI.Controlers.CustomButton();
            this.btnMax = new AP_HOTEL_APPLI.Controlers.CustomButton();
            this.tablePanelConnexion = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReservation = new AP_HOTEL_APPLI.Controlers.CustomButton();
            this.btnInfo = new AP_HOTEL_APPLI.Controlers.CustomButton();
            this.btnChambre = new AP_HOTEL_APPLI.Controlers.CustomButton();
            this.btnTest = new AP_HOTEL_APPLI.Controlers.CustomButton();
            this.btnSignIn = new AP_HOTEL_APPLI.Controlers.CustomButton();
            this.btnSignOut = new AP_HOTEL_APPLI.Controlers.CustomButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.tablePanelConnexion.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(789, 44);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(331, 72);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "label1";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.panelDesktop.Location = new System.Drawing.Point(12, 123);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1176, 665);
            this.panelDesktop.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::AP_HOTEL_APPLI.Properties.Resources.logo_balladins;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.btnMin);
            this.panelTitleBar.Controls.Add(this.btnMax);
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1200, 41);
            this.panelTitleBar.TabIndex = 12;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Location = new System.Drawing.Point(12, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(427, 30);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Outil de gestion Hotel Balladins";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.btnClose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.btnClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClose.BorderRadius = 5;
            this.btnClose.BorderSize = 0;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnClose.IconSize = 28;
            this.btnClose.Location = new System.Drawing.Point(1162, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 11;
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.btnMin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.btnMin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMin.BorderRadius = 5;
            this.btnMin.BorderSize = 0;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMin.IconColor = System.Drawing.Color.White;
            this.btnMin.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMin.IconSize = 28;
            this.btnMin.Location = new System.Drawing.Point(1090, 6);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 30);
            this.btnMin.TabIndex = 9;
            this.btnMin.TextColor = System.Drawing.Color.White;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.btnMax.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.btnMax.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMax.BorderRadius = 5;
            this.btnMax.BorderSize = 0;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.ForeColor = System.Drawing.Color.White;
            this.btnMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMax.IconColor = System.Drawing.Color.White;
            this.btnMax.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnMax.IconSize = 28;
            this.btnMax.Location = new System.Drawing.Point(1126, 6);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(30, 30);
            this.btnMax.TabIndex = 10;
            this.btnMax.TextColor = System.Drawing.Color.White;
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // tablePanelConnexion
            // 
            this.tablePanelConnexion.ColumnCount = 4;
            this.tablePanelConnexion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelConnexion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablePanelConnexion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablePanelConnexion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tablePanelConnexion.Controls.Add(this.label1, 0, 0);
            this.tablePanelConnexion.Controls.Add(this.txtId, 0, 1);
            this.tablePanelConnexion.Controls.Add(this.label2, 2, 0);
            this.tablePanelConnexion.Controls.Add(this.txtPwd, 2, 1);
            this.tablePanelConnexion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanelConnexion.Location = new System.Drawing.Point(502, 0);
            this.tablePanelConnexion.Margin = new System.Windows.Forms.Padding(0);
            this.tablePanelConnexion.Name = "tablePanelConnexion";
            this.tablePanelConnexion.RowCount = 2;
            this.tablePanelConnexion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tablePanelConnexion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tablePanelConnexion.Size = new System.Drawing.Size(331, 75);
            this.tablePanelConnexion.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Identifiant :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.txtId.Location = new System.Drawing.Point(3, 33);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(139, 28);
            this.txtId.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(168, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mot de passe :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPwd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.txtPwd.Location = new System.Drawing.Point(168, 33);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(139, 28);
            this.txtPwd.TabIndex = 5;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.99999F));
            this.tableLayoutPanel2.Controls.Add(this.btnReservation, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnInfo, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnChambre, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tablePanelConnexion, 4, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(287, 41);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(833, 75);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // btnReservation
            // 
            this.btnReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.btnReservation.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.btnReservation.BorderColor = System.Drawing.Color.Transparent;
            this.btnReservation.BorderRadius = 0;
            this.btnReservation.BorderSize = 0;
            this.btnReservation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReservation.FlatAppearance.BorderSize = 0;
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.btnReservation.IconChar = FontAwesome.Sharp.IconChar.CalendarDay;
            this.btnReservation.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.btnReservation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReservation.IconSize = 40;
            this.btnReservation.Location = new System.Drawing.Point(0, 0);
            this.btnReservation.Margin = new System.Windows.Forms.Padding(0);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(164, 75);
            this.btnReservation.TabIndex = 1;
            this.btnReservation.Text = "Réservations";
            this.btnReservation.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.btnReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolTip1.SetToolTip(this.btnReservation, "Accéder au gestionnaire des réservations de l\'hotel");
            this.btnReservation.UseVisualStyleBackColor = false;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.btnInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.btnInfo.BorderColor = System.Drawing.Color.Transparent;
            this.btnInfo.BorderRadius = 0;
            this.btnInfo.BorderSize = 0;
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.btnInfo.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.btnInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.btnInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfo.IconSize = 40;
            this.btnInfo.Location = new System.Drawing.Point(328, 0);
            this.btnInfo.Margin = new System.Windows.Forms.Padding(0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(164, 75);
            this.btnInfo.TabIndex = 3;
            this.btnInfo.Text = "Informations";
            this.btnInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolTip1.SetToolTip(this.btnInfo, "Accéder au gestionnaire des informations de l\'hotel");
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnChambre
            // 
            this.btnChambre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.btnChambre.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.btnChambre.BorderColor = System.Drawing.Color.Transparent;
            this.btnChambre.BorderRadius = 0;
            this.btnChambre.BorderSize = 0;
            this.btnChambre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChambre.FlatAppearance.BorderSize = 0;
            this.btnChambre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChambre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChambre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.btnChambre.IconChar = FontAwesome.Sharp.IconChar.Bed;
            this.btnChambre.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(25)))), ((int)(((byte)(32)))));
            this.btnChambre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChambre.IconSize = 40;
            this.btnChambre.Location = new System.Drawing.Point(164, 0);
            this.btnChambre.Margin = new System.Windows.Forms.Padding(0);
            this.btnChambre.Name = "btnChambre";
            this.btnChambre.Size = new System.Drawing.Size(164, 75);
            this.btnChambre.TabIndex = 2;
            this.btnChambre.Text = "Chambres";
            this.btnChambre.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.btnChambre.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.toolTip1.SetToolTip(this.btnChambre, "Accéder au gestionnaire des chambres de l\'hotel");
            this.btnChambre.UseVisualStyleBackColor = false;
            this.btnChambre.Click += new System.EventHandler(this.btnChambre_Click);
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTest.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnTest.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTest.BorderRadius = 0;
            this.btnTest.BorderSize = 0;
            this.btnTest.FlatAppearance.BorderSize = 0;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Font = new System.Drawing.Font("Microsoft Uighur", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnTest.IconColor = System.Drawing.Color.Black;
            this.btnTest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTest.Location = new System.Drawing.Point(1145, 99);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(40, 21);
            this.btnTest.TabIndex = 16;
            this.btnTest.Text = "test";
            this.btnTest.TextColor = System.Drawing.Color.White;
            this.btnTest.UseVisualStyleBackColor = false;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.btnSignIn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.btnSignIn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSignIn.BorderRadius = 10;
            this.btnSignIn.BorderSize = 0;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.IconChar = FontAwesome.Sharp.IconChar.SignIn;
            this.btnSignIn.IconColor = System.Drawing.Color.Black;
            this.btnSignIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSignIn.Location = new System.Drawing.Point(1138, 52);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(50, 50);
            this.btnSignIn.TabIndex = 6;
            this.btnSignIn.TextColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.btnSignIn, "Se connecter");
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.btnSignOut.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(195)))), ((int)(((byte)(67)))));
            this.btnSignOut.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSignOut.BorderRadius = 10;
            this.btnSignOut.BorderSize = 0;
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnSignOut.IconColor = System.Drawing.Color.Black;
            this.btnSignOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSignOut.Location = new System.Drawing.Point(1138, 52);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(50, 50);
            this.btnSignOut.TabIndex = 6;
            this.btnSignOut.TextColor = System.Drawing.Color.White;
            this.toolTip1.SetToolTip(this.btnSignOut, "Se déconnecter");
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(73)))), ((int)(((byte)(131)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "FrmMain";
            this.Text = "Outil de gestion Hotel Balladins";
            this.Load += new System.EventHandler(this.formMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.tablePanelConnexion.ResumeLayout(false);
            this.tablePanelConnexion.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Controlers.CustomButton btnMin;
        private Controlers.CustomButton btnMax;
        private Controlers.CustomButton btnClose;
        private System.Windows.Forms.Panel panelTitleBar;
        private Controlers.CustomButton btnChambre;
        private Controlers.CustomButton btnInfo;
        private System.Windows.Forms.TableLayoutPanel tablePanelConnexion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private Controlers.CustomButton btnSignIn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Controlers.CustomButton btnReservation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPwd;
        private Controlers.CustomButton btnSignOut;
        private Controlers.CustomButton btnTest;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}