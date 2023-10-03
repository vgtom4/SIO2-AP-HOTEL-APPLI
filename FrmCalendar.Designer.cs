﻿namespace AP_HOTEL_APPLI
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
            this.lblInfoNbChambre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listChambre = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddRes = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(628, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sélectionnez une date pour en voir les réservations";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(52, 131);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(368, 34);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cboRes
            // 
            this.cboRes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRes.FormattingEnabled = true;
            this.cboRes.Location = new System.Drawing.Point(52, 213);
            this.cboRes.Name = "cboRes";
            this.cboRes.Size = new System.Drawing.Size(215, 35);
            this.cboRes.TabIndex = 3;
            this.cboRes.Visible = false;
            this.cboRes.SelectedIndexChanged += new System.EventHandler(this.cboRes_SelectedIndexChanged);
            // 
            // lblInfoNbChambre
            // 
            this.lblInfoNbChambre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInfoNbChambre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoNbChambre.Location = new System.Drawing.Point(648, 232);
            this.lblInfoNbChambre.Name = "lblInfoNbChambre";
            this.lblInfoNbChambre.Size = new System.Drawing.Size(240, 16);
            this.lblInfoNbChambre.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1058, 40);
            this.label2.TabIndex = 14;
            this.label2.Text = "Gestion des réservations";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listChambre
            // 
            this.listChambre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listChambre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listChambre.ColumnWidth = 60;
            this.listChambre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listChambre.FormattingEnabled = true;
            this.listChambre.ItemHeight = 27;
            this.listChambre.Location = new System.Drawing.Point(52, 309);
            this.listChambre.MultiColumn = true;
            this.listChambre.Name = "listChambre";
            this.listChambre.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listChambre.Size = new System.Drawing.Size(454, 218);
            this.listChambre.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "Chambres disponibles :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddRes
            // 
            this.btnAddRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRes.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAddRes.IconColor = System.Drawing.Color.LightSeaGreen;
            this.btnAddRes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddRes.IconSize = 45;
            this.btnAddRes.Location = new System.Drawing.Point(728, 261);
            this.btnAddRes.Name = "btnAddRes";
            this.btnAddRes.Size = new System.Drawing.Size(160, 50);
            this.btnAddRes.TabIndex = 18;
            this.btnAddRes.Text = "Ajouter";
            this.btnAddRes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddRes.UseVisualStyleBackColor = true;
            this.btnAddRes.Click += new System.EventHandler(this.btnAddRes_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(628, 30);
            this.label4.TabIndex = 19;
            this.label4.Text = "Les réservations :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddRes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listChambre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblInfoNbChambre);
            this.Controls.Add(this.cboRes);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "FrmCalendar";
            this.Text = "FrmCalendar";
            this.Load += new System.EventHandler(this.FrmCalendar_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cboRes;
        private System.Windows.Forms.Label lblInfoNbChambre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listChambre;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnAddRes;
        private System.Windows.Forms.Label label4;
    }
}