﻿namespace Findstaff
{
    partial class ucDocumentation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.dgvRecruitment = new System.Windows.Forms.DataGridView();
            this.btnAdvSe = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnCheckDetails = new System.Windows.Forms.Button();
            this.lblDocu = new System.Windows.Forms.Label();
            this.ucDocAppDetails = new Findstaff.ucDocAppDetails();
            this.pnlTabs = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecruitment)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // txtMName
            // 
            this.txtMName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMName.ForeColor = System.Drawing.Color.Black;
            this.txtMName.Location = new System.Drawing.Point(475, 147);
            this.txtMName.MaxLength = 30;
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(120, 26);
            this.txtMName.TabIndex = 53;
            // 
            // txtFName
            // 
            this.txtFName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtFName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.ForeColor = System.Drawing.Color.Black;
            this.txtFName.Location = new System.Drawing.Point(349, 147);
            this.txtFName.MaxLength = 30;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(120, 26);
            this.txtFName.TabIndex = 52;
            // 
            // dgvRecruitment
            // 
            this.dgvRecruitment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecruitment.Location = new System.Drawing.Point(100, 200);
            this.dgvRecruitment.Name = "dgvRecruitment";
            this.dgvRecruitment.Size = new System.Drawing.Size(918, 200);
            this.dgvRecruitment.TabIndex = 51;
            // 
            // btnAdvSe
            // 
            this.btnAdvSe.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdvSe.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdvSe.FlatAppearance.BorderSize = 0;
            this.btnAdvSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvSe.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvSe.ForeColor = System.Drawing.Color.Black;
            this.btnAdvSe.Location = new System.Drawing.Point(707, 144);
            this.btnAdvSe.Name = "btnAdvSe";
            this.btnAdvSe.Size = new System.Drawing.Size(250, 30);
            this.btnAdvSe.TabIndex = 50;
            this.btnAdvSe.Text = "ADVANCED SEARCH";
            this.btnAdvSe.UseVisualStyleBackColor = false;
            this.btnAdvSe.Click += new System.EventHandler(this.btnAdvSe_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(601, 144);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 49;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtLName
            // 
            this.txtLName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtLName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.ForeColor = System.Drawing.Color.Black;
            this.txtLName.Location = new System.Drawing.Point(223, 147);
            this.txtLName.MaxLength = 30;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(120, 26);
            this.txtLName.TabIndex = 48;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Black;
            this.lblSearch.Location = new System.Drawing.Point(100, 150);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(117, 19);
            this.lblSearch.TabIndex = 47;
            this.lblSearch.Text = "Search Name :";
            // 
            // btnCheckDetails
            // 
            this.btnCheckDetails.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCheckDetails.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCheckDetails.FlatAppearance.BorderSize = 0;
            this.btnCheckDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckDetails.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckDetails.ForeColor = System.Drawing.Color.Black;
            this.btnCheckDetails.Location = new System.Drawing.Point(460, 425);
            this.btnCheckDetails.Name = "btnCheckDetails";
            this.btnCheckDetails.Size = new System.Drawing.Size(200, 50);
            this.btnCheckDetails.TabIndex = 46;
            this.btnCheckDetails.Text = "CHECK DETAILS";
            this.btnCheckDetails.UseVisualStyleBackColor = false;
            this.btnCheckDetails.Click += new System.EventHandler(this.btnCheckDetails_Click);
            // 
            // lblDocu
            // 
            this.lblDocu.AutoSize = true;
            this.lblDocu.BackColor = System.Drawing.Color.Transparent;
            this.lblDocu.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocu.ForeColor = System.Drawing.Color.Black;
            this.lblDocu.Location = new System.Drawing.Point(25, 75);
            this.lblDocu.Name = "lblDocu";
            this.lblDocu.Size = new System.Drawing.Size(259, 39);
            this.lblDocu.TabIndex = 45;
            this.lblDocu.Text = "Documentation";
            // 
            // ucDocAppDetails
            // 
            this.ucDocAppDetails.AutoScroll = true;
            this.ucDocAppDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucDocAppDetails.Location = new System.Drawing.Point(0, 0);
            this.ucDocAppDetails.Name = "ucDocAppDetails";
            this.ucDocAppDetails.Size = new System.Drawing.Size(15, 15);
            this.ucDocAppDetails.TabIndex = 54;
            this.ucDocAppDetails.Visible = false;
            // 
            // pnlTabs
            // 
            this.pnlTabs.BackColor = System.Drawing.Color.White;
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabs.Location = new System.Drawing.Point(0, 0);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(1118, 50);
            this.pnlTabs.TabIndex = 59;
            // 
            // ucDocumentation
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.pnlTabs);
            this.Controls.Add(this.ucDocAppDetails);
            this.Controls.Add(this.txtMName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.dgvRecruitment);
            this.Controls.Add(this.btnAdvSe);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnCheckDetails);
            this.Controls.Add(this.lblDocu);
            this.Name = "ucDocumentation";
            this.Size = new System.Drawing.Size(1118, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecruitment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.DataGridView dgvRecruitment;
        private System.Windows.Forms.Button btnAdvSe;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnCheckDetails;
        private System.Windows.Forms.Label lblDocu;
        private ucDocAppDetails ucDocAppDetails;
        private System.Windows.Forms.Panel pnlTabs;
    }
}