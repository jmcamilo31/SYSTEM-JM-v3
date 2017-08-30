namespace Findstaff
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
            this.rbJobFees = new System.Windows.Forms.RadioButton();
            this.rbJobList = new System.Windows.Forms.RadioButton();
            this.rbJobOrder = new System.Windows.Forms.RadioButton();
            this.rbEmployer = new System.Windows.Forms.RadioButton();
            this.rbCountry = new System.Windows.Forms.RadioButton();
            this.rbApplicant = new System.Windows.Forms.RadioButton();
            this.rbEmployee = new System.Windows.Forms.RadioButton();
            this.ucJobFees = new Findstaff.ucJobFees();
            this.ucApplicant = new Findstaff.ucApplicant();
            this.ucEmployer = new Findstaff.ucEmployer();
            this.ucEmployee = new Findstaff.ucEmployee();
            this.ucJobOrder = new Findstaff.ucJobOrder();
            this.ucCountry = new Findstaff.ucCountry();
            this.ucGenReqs = new Findstaff.ucGenReqs();
            this.ucJobList = new Findstaff.ucJobList();
            this.pnlTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTabs
            // 
            this.pnlTabs.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlTabs.Controls.Add(this.rbGeneralRequirements);
            this.pnlTabs.Controls.Add(this.rbJobFees);
            this.pnlTabs.Controls.Add(this.rbJobList);
            this.pnlTabs.Controls.Add(this.rbJobOrder);
            this.pnlTabs.Controls.Add(this.rbEmployer);
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
            this.rbGeneralRequirements.Location = new System.Drawing.Point(751, 10);
            this.rbGeneralRequirements.Name = "rbGeneralRequirements";
            this.rbGeneralRequirements.Size = new System.Drawing.Size(200, 40);
            this.rbGeneralRequirements.TabIndex = 8;
            this.rbGeneralRequirements.Text = "General Requirements";
            this.rbGeneralRequirements.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbGeneralRequirements.UseVisualStyleBackColor = false;
            this.rbGeneralRequirements.CheckedChanged += new System.EventHandler(this.rbGeneralRequirements_CheckedChanged);
            // 
            // rbJobFees
            // 
            this.rbJobFees.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbJobFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbJobFees.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbJobFees.FlatAppearance.BorderSize = 0;
            this.rbJobFees.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbJobFees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbJobFees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbJobFees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbJobFees.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJobFees.ForeColor = System.Drawing.Color.White;
            this.rbJobFees.Location = new System.Drawing.Point(645, 10);
            this.rbJobFees.Name = "rbJobFees";
            this.rbJobFees.Size = new System.Drawing.Size(100, 40);
            this.rbJobFees.TabIndex = 7;
            this.rbJobFees.Text = "Job Fees";
            this.rbJobFees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbJobFees.UseVisualStyleBackColor = false;
            this.rbJobFees.CheckedChanged += new System.EventHandler(this.rbFees_CheckedChanged);
            // 
            // rbJobList
            // 
            this.rbJobList.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbJobList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbJobList.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbJobList.FlatAppearance.BorderSize = 0;
            this.rbJobList.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbJobList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbJobList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbJobList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbJobList.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJobList.ForeColor = System.Drawing.Color.White;
            this.rbJobList.Location = new System.Drawing.Point(539, 10);
            this.rbJobList.Name = "rbJobList";
            this.rbJobList.Size = new System.Drawing.Size(100, 40);
            this.rbJobList.TabIndex = 6;
            this.rbJobList.Text = "Job List";
            this.rbJobList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbJobList.UseVisualStyleBackColor = false;
            this.rbJobList.CheckedChanged += new System.EventHandler(this.rbJob_CheckedChanged);
            // 
            // rbJobOrder
            // 
            this.rbJobOrder.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbJobOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbJobOrder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbJobOrder.FlatAppearance.BorderSize = 0;
            this.rbJobOrder.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbJobOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbJobOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbJobOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbJobOrder.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJobOrder.ForeColor = System.Drawing.Color.White;
            this.rbJobOrder.Location = new System.Drawing.Point(433, 10);
            this.rbJobOrder.Name = "rbJobOrder";
            this.rbJobOrder.Size = new System.Drawing.Size(100, 40);
            this.rbJobOrder.TabIndex = 5;
            this.rbJobOrder.Text = "Job Order";
            this.rbJobOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbJobOrder.UseVisualStyleBackColor = false;
            this.rbJobOrder.CheckedChanged += new System.EventHandler(this.rbJobOrder_CheckedChanged);
            // 
            // rbEmployer
            // 
            this.rbEmployer.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbEmployer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbEmployer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbEmployer.FlatAppearance.BorderSize = 0;
            this.rbEmployer.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbEmployer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbEmployer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbEmployer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbEmployer.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmployer.ForeColor = System.Drawing.Color.White;
            this.rbEmployer.Location = new System.Drawing.Point(327, 10);
            this.rbEmployer.Name = "rbEmployer";
            this.rbEmployer.Size = new System.Drawing.Size(100, 40);
            this.rbEmployer.TabIndex = 4;
            this.rbEmployer.Text = "Employer";
            this.rbEmployer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbEmployer.UseVisualStyleBackColor = false;
            this.rbEmployer.CheckedChanged += new System.EventHandler(this.rbEmployer_CheckedChanged);
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
            // ucJobFees
            // 
            this.ucJobFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucJobFees.ForeColor = System.Drawing.Color.Black;
            this.ucJobFees.Location = new System.Drawing.Point(645, 56);
            this.ucJobFees.Name = "ucJobFees";
            this.ucJobFees.Size = new System.Drawing.Size(100, 100);
            this.ucJobFees.TabIndex = 40;
            this.ucJobFees.Visible = false;
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
            // ucEmployer
            // 
            this.ucEmployer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucEmployer.ForeColor = System.Drawing.Color.Black;
            this.ucEmployer.Location = new System.Drawing.Point(327, 56);
            this.ucEmployer.Name = "ucEmployer";
            this.ucEmployer.Size = new System.Drawing.Size(100, 100);
            this.ucEmployer.TabIndex = 36;
            this.ucEmployer.Visible = false;
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
            // ucJobOrder
            // 
            this.ucJobOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucJobOrder.ForeColor = System.Drawing.Color.Black;
            this.ucJobOrder.Location = new System.Drawing.Point(433, 56);
            this.ucJobOrder.Name = "ucJobOrder";
            this.ucJobOrder.Size = new System.Drawing.Size(100, 100);
            this.ucJobOrder.TabIndex = 33;
            this.ucJobOrder.Visible = false;
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
            this.ucGenReqs.Location = new System.Drawing.Point(751, 56);
            this.ucGenReqs.Name = "ucGenReqs";
            this.ucGenReqs.Size = new System.Drawing.Size(200, 100);
            this.ucGenReqs.TabIndex = 41;
            this.ucGenReqs.Visible = false;
            // 
            // ucJobList
            // 
            this.ucJobList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucJobList.ForeColor = System.Drawing.Color.Black;
            this.ucJobList.Location = new System.Drawing.Point(539, 56);
            this.ucJobList.Name = "ucJobList";
            this.ucJobList.Size = new System.Drawing.Size(100, 100);
            this.ucJobList.TabIndex = 42;
            this.ucJobList.Visible = false;
            // 
            // ucMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.ucJobList);
            this.Controls.Add(this.ucGenReqs);
            this.Controls.Add(this.ucJobFees);
            this.Controls.Add(this.ucApplicant);
            this.Controls.Add(this.ucEmployer);
            this.Controls.Add(this.ucEmployee);
            this.Controls.Add(this.ucJobOrder);
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
        private System.Windows.Forms.RadioButton rbJobFees;
        private System.Windows.Forms.RadioButton rbJobList;
        private System.Windows.Forms.RadioButton rbJobOrder;
        private System.Windows.Forms.RadioButton rbEmployer;
        private System.Windows.Forms.RadioButton rbCountry;
        private System.Windows.Forms.RadioButton rbGeneralRequirements;
        public ucCountry ucCountry;
        public ucJobOrder ucJobOrder;
        public ucEmployee ucEmployee;
        public ucEmployer ucEmployer;
        public ucApplicant ucApplicant;
        public ucJobFees ucJobFees;
        public ucGenReqs ucGenReqs;
        public ucJobList ucJobList;
    }
}
