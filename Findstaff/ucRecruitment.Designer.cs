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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAppMatch = new System.Windows.Forms.TabPage();
            this.dgvAppMatch = new System.Windows.Forms.DataGridView();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbEmployer = new System.Windows.Forms.ComboBox();
            this.lblEmployer = new System.Windows.Forms.Label();
            this.cbJob = new System.Windows.Forms.ComboBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.tabJobSuggest = new System.Windows.Forms.TabPage();
            this.dgvJobSuggest = new System.Windows.Forms.DataGridView();
            this.btnResults = new System.Windows.Forms.Button();
            this.txtMiddle = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.lbljaSearch = new System.Windows.Forms.Label();
            this.lblJobApp = new System.Windows.Forms.Label();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.dgvRecruitment = new System.Windows.Forms.DataGridView();
            this.btnAdvSe = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblalSearch = new System.Windows.Forms.Label();
            this.lblApplicantList = new System.Windows.Forms.Label();
            this.pnlAppList = new System.Windows.Forms.Panel();
            this.ucAppView = new Findstaff.ucAppView();
            this.rbJobApplicant = new System.Windows.Forms.RadioButton();
            this.rbApplicantList = new System.Windows.Forms.RadioButton();
            this.pnlJobApp = new System.Windows.Forms.Panel();
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabAppMatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppMatch)).BeginInit();
            this.tabJobSuggest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobSuggest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecruitment)).BeginInit();
            this.pnlAppList.SuspendLayout();
            this.pnlJobApp.SuspendLayout();
            this.pnlTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAppMatch);
            this.tabControl1.Controls.Add(this.tabJobSuggest);
            this.tabControl1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(100, 100);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(918, 320);
            this.tabControl1.TabIndex = 4;
            // 
            // tabAppMatch
            // 
            this.tabAppMatch.BackColor = System.Drawing.Color.White;
            this.tabAppMatch.Controls.Add(this.dgvAppMatch);
            this.tabAppMatch.Controls.Add(this.btnFilter);
            this.tabAppMatch.Controls.Add(this.cbEmployer);
            this.tabAppMatch.Controls.Add(this.lblEmployer);
            this.tabAppMatch.Controls.Add(this.cbJob);
            this.tabAppMatch.Controls.Add(this.lblJob);
            this.tabAppMatch.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAppMatch.Location = new System.Drawing.Point(4, 28);
            this.tabAppMatch.Name = "tabAppMatch";
            this.tabAppMatch.Padding = new System.Windows.Forms.Padding(3);
            this.tabAppMatch.Size = new System.Drawing.Size(910, 288);
            this.tabAppMatch.TabIndex = 0;
            this.tabAppMatch.Text = "Applicant Matching";
            // 
            // dgvAppMatch
            // 
            this.dgvAppMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppMatch.Location = new System.Drawing.Point(75, 75);
            this.dgvAppMatch.Name = "dgvAppMatch";
            this.dgvAppMatch.Size = new System.Drawing.Size(748, 180);
            this.dgvAppMatch.TabIndex = 18;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.Black;
            this.btnFilter.Location = new System.Drawing.Point(581, 19);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 30);
            this.btnFilter.TabIndex = 17;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // cbEmployer
            // 
            this.cbEmployer.BackColor = System.Drawing.Color.Gainsboro;
            this.cbEmployer.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmployer.ForeColor = System.Drawing.Color.Black;
            this.cbEmployer.FormattingEnabled = true;
            this.cbEmployer.Location = new System.Drawing.Point(375, 22);
            this.cbEmployer.Name = "cbEmployer";
            this.cbEmployer.Size = new System.Drawing.Size(200, 27);
            this.cbEmployer.TabIndex = 16;
            // 
            // lblEmployer
            // 
            this.lblEmployer.AutoSize = true;
            this.lblEmployer.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployer.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployer.ForeColor = System.Drawing.Color.Black;
            this.lblEmployer.Location = new System.Drawing.Point(279, 25);
            this.lblEmployer.Name = "lblEmployer";
            this.lblEmployer.Size = new System.Drawing.Size(90, 19);
            this.lblEmployer.TabIndex = 15;
            this.lblEmployer.Text = "Employer :";
            // 
            // cbJob
            // 
            this.cbJob.BackColor = System.Drawing.Color.Gainsboro;
            this.cbJob.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbJob.ForeColor = System.Drawing.Color.Black;
            this.cbJob.FormattingEnabled = true;
            this.cbJob.Location = new System.Drawing.Point(73, 22);
            this.cbJob.Name = "cbJob";
            this.cbJob.Size = new System.Drawing.Size(200, 27);
            this.cbJob.TabIndex = 14;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.BackColor = System.Drawing.Color.Transparent;
            this.lblJob.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.ForeColor = System.Drawing.Color.Black;
            this.lblJob.Location = new System.Drawing.Point(25, 25);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(42, 19);
            this.lblJob.TabIndex = 13;
            this.lblJob.Text = "Job :";
            // 
            // tabJobSuggest
            // 
            this.tabJobSuggest.BackColor = System.Drawing.Color.White;
            this.tabJobSuggest.Controls.Add(this.dgvJobSuggest);
            this.tabJobSuggest.Controls.Add(this.btnResults);
            this.tabJobSuggest.Controls.Add(this.txtMiddle);
            this.tabJobSuggest.Controls.Add(this.txtFirst);
            this.tabJobSuggest.Controls.Add(this.txtLast);
            this.tabJobSuggest.Controls.Add(this.lbljaSearch);
            this.tabJobSuggest.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabJobSuggest.Location = new System.Drawing.Point(4, 28);
            this.tabJobSuggest.Name = "tabJobSuggest";
            this.tabJobSuggest.Padding = new System.Windows.Forms.Padding(3);
            this.tabJobSuggest.Size = new System.Drawing.Size(910, 288);
            this.tabJobSuggest.TabIndex = 1;
            this.tabJobSuggest.Text = "Job Suggestion";
            // 
            // dgvJobSuggest
            // 
            this.dgvJobSuggest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJobSuggest.Location = new System.Drawing.Point(75, 75);
            this.dgvJobSuggest.Name = "dgvJobSuggest";
            this.dgvJobSuggest.Size = new System.Drawing.Size(748, 180);
            this.dgvJobSuggest.TabIndex = 19;
            // 
            // btnResults
            // 
            this.btnResults.BackColor = System.Drawing.Color.Gainsboro;
            this.btnResults.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnResults.FlatAppearance.BorderSize = 0;
            this.btnResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResults.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResults.ForeColor = System.Drawing.Color.Black;
            this.btnResults.Location = new System.Drawing.Point(478, 19);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(100, 30);
            this.btnResults.TabIndex = 18;
            this.btnResults.Text = "RESULTS";
            this.btnResults.UseVisualStyleBackColor = false;
            // 
            // txtMiddle
            // 
            this.txtMiddle.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMiddle.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddle.ForeColor = System.Drawing.Color.Black;
            this.txtMiddle.Location = new System.Drawing.Point(352, 22);
            this.txtMiddle.MaxLength = 30;
            this.txtMiddle.Name = "txtMiddle";
            this.txtMiddle.Size = new System.Drawing.Size(120, 26);
            this.txtMiddle.TabIndex = 15;
            // 
            // txtFirst
            // 
            this.txtFirst.BackColor = System.Drawing.Color.Gainsboro;
            this.txtFirst.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirst.ForeColor = System.Drawing.Color.Black;
            this.txtFirst.Location = new System.Drawing.Point(226, 22);
            this.txtFirst.MaxLength = 30;
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(120, 26);
            this.txtFirst.TabIndex = 13;
            // 
            // txtLast
            // 
            this.txtLast.BackColor = System.Drawing.Color.Gainsboro;
            this.txtLast.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLast.ForeColor = System.Drawing.Color.Black;
            this.txtLast.Location = new System.Drawing.Point(100, 22);
            this.txtLast.MaxLength = 30;
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(120, 26);
            this.txtLast.TabIndex = 11;
            // 
            // lbljaSearch
            // 
            this.lbljaSearch.AutoSize = true;
            this.lbljaSearch.BackColor = System.Drawing.Color.Transparent;
            this.lbljaSearch.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljaSearch.ForeColor = System.Drawing.Color.Black;
            this.lbljaSearch.Location = new System.Drawing.Point(25, 25);
            this.lbljaSearch.Name = "lbljaSearch";
            this.lbljaSearch.Size = new System.Drawing.Size(69, 19);
            this.lbljaSearch.TabIndex = 10;
            this.lbljaSearch.Text = "Search :";
            // 
            // lblJobApp
            // 
            this.lblJobApp.AutoSize = true;
            this.lblJobApp.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobApp.ForeColor = System.Drawing.Color.Black;
            this.lblJobApp.Location = new System.Drawing.Point(25, 25);
            this.lblJobApp.Name = "lblJobApp";
            this.lblJobApp.Size = new System.Drawing.Size(231, 39);
            this.lblJobApp.TabIndex = 3;
            this.lblJobApp.Text = "Job-Applicant";
            // 
            // txtMName
            // 
            this.txtMName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMName.ForeColor = System.Drawing.Color.Black;
            this.txtMName.Location = new System.Drawing.Point(475, 97);
            this.txtMName.MaxLength = 30;
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(120, 26);
            this.txtMName.TabIndex = 37;
            // 
            // txtFName
            // 
            this.txtFName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtFName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.ForeColor = System.Drawing.Color.Black;
            this.txtFName.Location = new System.Drawing.Point(349, 97);
            this.txtFName.MaxLength = 30;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(120, 26);
            this.txtFName.TabIndex = 36;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Gainsboro;
            this.btnView.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnView.FlatAppearance.BorderSize = 0;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.Black;
            this.btnView.Location = new System.Drawing.Point(509, 371);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(100, 50);
            this.btnView.TabIndex = 35;
            this.btnView.Text = "VIEW";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dgvRecruitment
            // 
            this.dgvRecruitment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecruitment.Location = new System.Drawing.Point(100, 140);
            this.dgvRecruitment.Name = "dgvRecruitment";
            this.dgvRecruitment.Size = new System.Drawing.Size(918, 200);
            this.dgvRecruitment.TabIndex = 31;
            // 
            // btnAdvSe
            // 
            this.btnAdvSe.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdvSe.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdvSe.FlatAppearance.BorderSize = 0;
            this.btnAdvSe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvSe.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdvSe.ForeColor = System.Drawing.Color.Black;
            this.btnAdvSe.Location = new System.Drawing.Point(707, 94);
            this.btnAdvSe.Name = "btnAdvSe";
            this.btnAdvSe.Size = new System.Drawing.Size(250, 30);
            this.btnAdvSe.TabIndex = 29;
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
            this.btnSearch.Location = new System.Drawing.Point(601, 94);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtLName
            // 
            this.txtLName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtLName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.ForeColor = System.Drawing.Color.Black;
            this.txtLName.Location = new System.Drawing.Point(223, 97);
            this.txtLName.MaxLength = 30;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(120, 26);
            this.txtLName.TabIndex = 27;
            // 
            // lblalSearch
            // 
            this.lblalSearch.AutoSize = true;
            this.lblalSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblalSearch.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalSearch.ForeColor = System.Drawing.Color.Black;
            this.lblalSearch.Location = new System.Drawing.Point(100, 100);
            this.lblalSearch.Name = "lblalSearch";
            this.lblalSearch.Size = new System.Drawing.Size(117, 19);
            this.lblalSearch.TabIndex = 26;
            this.lblalSearch.Text = "Search Name :";
            // 
            // lblApplicantList
            // 
            this.lblApplicantList.AutoSize = true;
            this.lblApplicantList.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicantList.ForeColor = System.Drawing.Color.Black;
            this.lblApplicantList.Location = new System.Drawing.Point(25, 25);
            this.lblApplicantList.Name = "lblApplicantList";
            this.lblApplicantList.Size = new System.Drawing.Size(236, 39);
            this.lblApplicantList.TabIndex = 25;
            this.lblApplicantList.Text = "Applicant List";
            // 
            // pnlAppList
            // 
            this.pnlAppList.Controls.Add(this.txtMName);
            this.pnlAppList.Controls.Add(this.txtFName);
            this.pnlAppList.Controls.Add(this.btnView);
            this.pnlAppList.Controls.Add(this.dgvRecruitment);
            this.pnlAppList.Controls.Add(this.btnAdvSe);
            this.pnlAppList.Controls.Add(this.btnSearch);
            this.pnlAppList.Controls.Add(this.txtLName);
            this.pnlAppList.Controls.Add(this.lblalSearch);
            this.pnlAppList.Controls.Add(this.lblApplicantList);
            this.pnlAppList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAppList.Location = new System.Drawing.Point(0, 50);
            this.pnlAppList.Name = "pnlAppList";
            this.pnlAppList.Size = new System.Drawing.Size(10, 450);
            this.pnlAppList.TabIndex = 31;
            // 
            // ucRecView
            // 
            this.ucAppView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucAppView.Location = new System.Drawing.Point(0, 0);
            this.ucAppView.Name = "ucRecView";
            this.ucAppView.Size = new System.Drawing.Size(5, 5);
            this.ucAppView.TabIndex = 39;
            this.ucAppView.Visible = false;
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
            this.rbJobApplicant.Size = new System.Drawing.Size(200, 40);
            this.rbJobApplicant.TabIndex = 2;
            this.rbJobApplicant.Text = "Job-Applicant";
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
            // pnlJobApp
            // 
            this.pnlJobApp.AutoScroll = true;
            this.pnlJobApp.Controls.Add(this.tabControl1);
            this.pnlJobApp.Controls.Add(this.lblJobApp);
            this.pnlJobApp.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlJobApp.Location = new System.Drawing.Point(1108, 50);
            this.pnlJobApp.Name = "pnlJobApp";
            this.pnlJobApp.Size = new System.Drawing.Size(10, 450);
            this.pnlJobApp.TabIndex = 32;
            // 
            // pnlTabs
            // 
            this.pnlTabs.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlTabs.Controls.Add(this.rbJobApplicant);
            this.pnlTabs.Controls.Add(this.rbApplicantList);
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabs.Location = new System.Drawing.Point(0, 0);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(1118, 50);
            this.pnlTabs.TabIndex = 30;
            // 
            // ucRecruitment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.pnlJobApp);
            this.Controls.Add(this.pnlAppList);
            this.Controls.Add(this.pnlTabs);
            this.Name = "ucRecruitment";
            this.Size = new System.Drawing.Size(1118, 500);
            this.tabControl1.ResumeLayout(false);
            this.tabAppMatch.ResumeLayout(false);
            this.tabAppMatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppMatch)).EndInit();
            this.tabJobSuggest.ResumeLayout(false);
            this.tabJobSuggest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJobSuggest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecruitment)).EndInit();
            this.pnlAppList.ResumeLayout(false);
            this.pnlAppList.PerformLayout();
            this.pnlJobApp.ResumeLayout(false);
            this.pnlJobApp.PerformLayout();
            this.pnlTabs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAppMatch;
        private System.Windows.Forms.DataGridView dgvAppMatch;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cbEmployer;
        private System.Windows.Forms.Label lblEmployer;
        private System.Windows.Forms.ComboBox cbJob;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.TabPage tabJobSuggest;
        private System.Windows.Forms.DataGridView dgvJobSuggest;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.TextBox txtMiddle;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.Label lbljaSearch;
        private System.Windows.Forms.Label lblJobApp;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DataGridView dgvRecruitment;
        private System.Windows.Forms.Button btnAdvSe;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblalSearch;
        private System.Windows.Forms.Label lblApplicantList;
        private System.Windows.Forms.Panel pnlAppList;
        private System.Windows.Forms.RadioButton rbJobApplicant;
        private System.Windows.Forms.RadioButton rbApplicantList;
        private System.Windows.Forms.Panel pnlJobApp;
        private System.Windows.Forms.Panel pnlTabs;
        private ucAppView ucAppView;
    }
}
