namespace Findstaff
{
    partial class ucRecruitment
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
            this.rbJobApplicant = new System.Windows.Forms.RadioButton();
            this.rbApplicantList = new System.Windows.Forms.RadioButton();
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.rbInterview = new System.Windows.Forms.RadioButton();
            this.ucAppList = new Findstaff.ucAppList();
            this.ucJobApp = new Findstaff.ucJobApp();
            this.ucInterviewInitFin = new Findstaff.ucInterviewInitFin();
            this.pnlTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbJobApplicant
            // 
            this.rbJobApplicant.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbJobApplicant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbJobApplicant.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbJobApplicant.FlatAppearance.BorderSize = 0;
            this.rbJobApplicant.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbJobApplicant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbJobApplicant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbJobApplicant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbJobApplicant.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJobApplicant.ForeColor = System.Drawing.Color.White;
            this.rbJobApplicant.Location = new System.Drawing.Point(216, 10);
            this.rbJobApplicant.Name = "rbJobApplicant";
            this.rbJobApplicant.Size = new System.Drawing.Size(320, 40);
            this.rbJobApplicant.TabIndex = 2;
            this.rbJobApplicant.Text = "Applicant Matching / Job Suggestion";
            this.rbJobApplicant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbJobApplicant.UseVisualStyleBackColor = false;
            this.rbJobApplicant.CheckedChanged += new System.EventHandler(this.rbJobApplicant_CheckedChanged);
            // 
            // rbApplicantList
            // 
            this.rbApplicantList.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbApplicantList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbApplicantList.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbApplicantList.FlatAppearance.BorderSize = 0;
            this.rbApplicantList.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbApplicantList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbApplicantList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbApplicantList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbApplicantList.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbApplicantList.ForeColor = System.Drawing.Color.White;
            this.rbApplicantList.Location = new System.Drawing.Point(10, 10);
            this.rbApplicantList.Name = "rbApplicantList";
            this.rbApplicantList.Size = new System.Drawing.Size(200, 40);
            this.rbApplicantList.TabIndex = 1;
            this.rbApplicantList.Text = "Applicant List";
            this.rbApplicantList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbApplicantList.UseVisualStyleBackColor = false;
            this.rbApplicantList.CheckedChanged += new System.EventHandler(this.rbApplicantList_CheckedChanged);
            // 
            // pnlTabs
            // 
            this.pnlTabs.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlTabs.Controls.Add(this.rbInterview);
            this.pnlTabs.Controls.Add(this.rbJobApplicant);
            this.pnlTabs.Controls.Add(this.rbApplicantList);
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabs.Location = new System.Drawing.Point(0, 0);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(1118, 50);
            this.pnlTabs.TabIndex = 30;
            // 
            // rbInterview
            // 
            this.rbInterview.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbInterview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(146)))), ((int)(((byte)(63)))));
            this.rbInterview.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.rbInterview.FlatAppearance.BorderSize = 0;
            this.rbInterview.FlatAppearance.CheckedBackColor = System.Drawing.Color.DimGray;
            this.rbInterview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbInterview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rbInterview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbInterview.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInterview.ForeColor = System.Drawing.Color.White;
            this.rbInterview.Location = new System.Drawing.Point(542, 10);
            this.rbInterview.Name = "rbInterview";
            this.rbInterview.Size = new System.Drawing.Size(150, 40);
            this.rbInterview.TabIndex = 3;
            this.rbInterview.Text = "Interview";
            this.rbInterview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbInterview.UseVisualStyleBackColor = false;
            this.rbInterview.CheckedChanged += new System.EventHandler(this.rbInterview_CheckedChanged);
            // 
            // ucAppList
            // 
            this.ucAppList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucAppList.Location = new System.Drawing.Point(10, 56);
            this.ucAppList.Name = "ucAppList";
            this.ucAppList.Size = new System.Drawing.Size(200, 200);
            this.ucAppList.TabIndex = 31;
            this.ucAppList.Visible = false;
            // 
            // ucJobApp
            // 
            this.ucJobApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucJobApp.Location = new System.Drawing.Point(216, 56);
            this.ucJobApp.Name = "ucJobApp";
            this.ucJobApp.Size = new System.Drawing.Size(320, 320);
            this.ucJobApp.TabIndex = 32;
            this.ucJobApp.Visible = false;
            // 
            // ucInterviewInitFin
            // 
            this.ucInterviewInitFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucInterviewInitFin.Location = new System.Drawing.Point(542, 56);
            this.ucInterviewInitFin.Name = "ucInterviewInitFin";
            this.ucInterviewInitFin.Size = new System.Drawing.Size(150, 150);
            this.ucInterviewInitFin.TabIndex = 33;
            this.ucInterviewInitFin.Visible = false;
            // 
            // ucRecruitment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.ucInterviewInitFin);
            this.Controls.Add(this.ucJobApp);
            this.Controls.Add(this.ucAppList);
            this.Controls.Add(this.pnlTabs);
            this.Name = "ucRecruitment";
            this.Size = new System.Drawing.Size(1118, 500);
            this.pnlTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rbJobApplicant;
        private System.Windows.Forms.RadioButton rbApplicantList;
        private System.Windows.Forms.Panel pnlTabs;
        private System.Windows.Forms.RadioButton rbInterview;
        private ucAppList ucAppList;
        private ucJobApp ucJobApp;
        private ucInterviewInitFin ucInterviewInitFin;
    }
}
