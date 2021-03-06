﻿namespace Findstaff
{
    partial class ucMaintenance
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
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.rbGeneralRequirements = new System.Windows.Forms.RadioButton();
            this.rbCountry = new System.Windows.Forms.RadioButton();
            this.rbApplicant = new System.Windows.Forms.RadioButton();
            this.rbEmployee = new System.Windows.Forms.RadioButton();
            this.ucApplicant = new Findstaff.ucApplicant();
            this.ucEmployee = new Findstaff.ucEmployee();
            this.ucCountry = new Findstaff.ucCountry();
            this.ucGenReqs = new Findstaff.ucGenReqs();
            this.pnlTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTabs
            // 
            this.pnlTabs.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlTabs.Controls.Add(this.rbGeneralRequirements);
            this.pnlTabs.Controls.Add(this.rbCountry);
            this.pnlTabs.Controls.Add(this.rbApplicant);
            this.pnlTabs.Controls.Add(this.rbEmployee);
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabs.Location = new System.Drawing.Point(0, 0);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(1118, 50);
            this.pnlTabs.TabIndex = 31;
            // 
            // rbGeneralRequirements
            // 
            this.rbGeneralRequirements.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbGeneralRequirements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbGeneralRequirements.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbGeneralRequirements.FlatAppearance.BorderSize = 0;
            this.rbGeneralRequirements.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbGeneralRequirements.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbGeneralRequirements.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbGeneralRequirements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbGeneralRequirements.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGeneralRequirements.ForeColor = System.Drawing.Color.White;
            this.rbGeneralRequirements.Location = new System.Drawing.Point(327, 10);
            this.rbGeneralRequirements.Name = "rbGeneralRequirements";
            this.rbGeneralRequirements.Size = new System.Drawing.Size(200, 40);
            this.rbGeneralRequirements.TabIndex = 8;
            this.rbGeneralRequirements.Text = "General Requirements";
            this.rbGeneralRequirements.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbGeneralRequirements.UseVisualStyleBackColor = false;
            this.rbGeneralRequirements.CheckedChanged += new System.EventHandler(this.rbGeneralRequirements_CheckedChanged);
            // 
            // rbCountry
            // 
            this.rbCountry.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbCountry.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbCountry.FlatAppearance.BorderSize = 0;
            this.rbCountry.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbCountry.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbCountry.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbCountry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbCountry.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCountry.ForeColor = System.Drawing.Color.White;
            this.rbCountry.Location = new System.Drawing.Point(221, 10);
            this.rbCountry.Name = "rbCountry";
            this.rbCountry.Size = new System.Drawing.Size(100, 40);
            this.rbCountry.TabIndex = 3;
            this.rbCountry.Text = "Country";
            this.rbCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbCountry.UseVisualStyleBackColor = false;
            this.rbCountry.CheckedChanged += new System.EventHandler(this.rbCountry_CheckedChanged);
            // 
            // rbApplicant
            // 
            this.rbApplicant.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbApplicant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbApplicant.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbApplicant.FlatAppearance.BorderSize = 0;
            this.rbApplicant.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbApplicant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbApplicant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbApplicant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbApplicant.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbApplicant.ForeColor = System.Drawing.Color.White;
            this.rbApplicant.Location = new System.Drawing.Point(115, 10);
            this.rbApplicant.Name = "rbApplicant";
            this.rbApplicant.Size = new System.Drawing.Size(100, 40);
            this.rbApplicant.TabIndex = 2;
            this.rbApplicant.Text = "Applicant";
            this.rbApplicant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbApplicant.UseVisualStyleBackColor = false;
            this.rbApplicant.CheckedChanged += new System.EventHandler(this.rbApplicant_CheckedChanged);
            // 
            // rbEmployee
            // 
            this.rbEmployee.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbEmployee.FlatAppearance.BorderSize = 0;
            this.rbEmployee.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbEmployee.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmployee.ForeColor = System.Drawing.Color.White;
            this.rbEmployee.Location = new System.Drawing.Point(9, 10);
            this.rbEmployee.Name = "rbEmployee";
            this.rbEmployee.Size = new System.Drawing.Size(100, 40);
            this.rbEmployee.TabIndex = 1;
            this.rbEmployee.Text = "Employee";
            this.rbEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbEmployee.UseVisualStyleBackColor = false;
            this.rbEmployee.CheckedChanged += new System.EventHandler(this.rbEmployee_CheckedChanged);
            // 
            // ucApplicant
            // 
            this.ucApplicant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucApplicant.ForeColor = System.Drawing.Color.Black;
            this.ucApplicant.Location = new System.Drawing.Point(115, 56);
            this.ucApplicant.Name = "ucApplicant";
            this.ucApplicant.Size = new System.Drawing.Size(100, 100);
            this.ucApplicant.TabIndex = 39;
            this.ucApplicant.Visible = false;
            // 
            // ucEmployee
            // 
            this.ucEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucEmployee.ForeColor = System.Drawing.Color.Black;
            this.ucEmployee.Location = new System.Drawing.Point(9, 56);
            this.ucEmployee.Name = "ucEmployee";
            this.ucEmployee.Size = new System.Drawing.Size(100, 100);
            this.ucEmployee.TabIndex = 34;
            this.ucEmployee.Visible = false;
            // 
            // ucCountry
            // 
            this.ucCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucCountry.ForeColor = System.Drawing.Color.Black;
            this.ucCountry.Location = new System.Drawing.Point(221, 56);
            this.ucCountry.Name = "ucCountry";
            this.ucCountry.Size = new System.Drawing.Size(100, 100);
            this.ucCountry.TabIndex = 32;
            this.ucCountry.Visible = false;
            // 
            // ucGenReqs
            // 
            this.ucGenReqs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucGenReqs.Location = new System.Drawing.Point(327, 56);
            this.ucGenReqs.Name = "ucGenReqs";
            this.ucGenReqs.Size = new System.Drawing.Size(200, 200);
            this.ucGenReqs.TabIndex = 41;
            this.ucGenReqs.Visible = false;
            // 
            // ucMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.ucGenReqs);
            this.Controls.Add(this.ucApplicant);
            this.Controls.Add(this.ucEmployee);
            this.Controls.Add(this.ucCountry);
            this.Controls.Add(this.pnlTabs);
            this.Name = "ucMaintenance";
            this.Size = new System.Drawing.Size(1118, 500);
            this.VisibleChanged += new System.EventHandler(this.ucMaintenance_VisibleChanged);
            this.pnlTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTabs;
        private System.Windows.Forms.RadioButton rbApplicant;
        private System.Windows.Forms.RadioButton rbEmployee;
        private System.Windows.Forms.RadioButton rbCountry;
        private System.Windows.Forms.RadioButton rbGeneralRequirements;
        public ucCountry ucCountry;
        public ucEmployee ucEmployee;
        public ucApplicant ucApplicant;
        public ucGenReqs ucGenReqs;
    }
}
