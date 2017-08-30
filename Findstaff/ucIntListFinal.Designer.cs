namespace Findstaff
{
    partial class ucIntListFinal
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFailInt = new System.Windows.Forms.Button();
            this.btnPassInt = new System.Windows.Forms.Button();
            this.dgvIntervieweeList = new System.Windows.Forms.DataGridView();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblEmp = new System.Windows.Forms.Label();
            this.lblJobOrder = new System.Windows.Forms.Label();
            this.lblIntervieweeList = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervieweeList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(509, 402);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 54;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFailInt
            // 
            this.btnFailInt.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFailInt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFailInt.FlatAppearance.BorderSize = 0;
            this.btnFailInt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFailInt.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFailInt.ForeColor = System.Drawing.Color.Black;
            this.btnFailInt.Location = new System.Drawing.Point(563, 366);
            this.btnFailInt.Name = "btnFailInt";
            this.btnFailInt.Size = new System.Drawing.Size(200, 30);
            this.btnFailInt.TabIndex = 53;
            this.btnFailInt.Text = "FAIL INTERVIEWEE";
            this.btnFailInt.UseVisualStyleBackColor = false;
            this.btnFailInt.Click += new System.EventHandler(this.btnFailInt_Click);
            // 
            // btnPassInt
            // 
            this.btnPassInt.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPassInt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPassInt.FlatAppearance.BorderSize = 0;
            this.btnPassInt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassInt.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassInt.ForeColor = System.Drawing.Color.Black;
            this.btnPassInt.Location = new System.Drawing.Point(357, 366);
            this.btnPassInt.Name = "btnPassInt";
            this.btnPassInt.Size = new System.Drawing.Size(200, 30);
            this.btnPassInt.TabIndex = 52;
            this.btnPassInt.Text = "PASS INTERVIEWEE";
            this.btnPassInt.UseVisualStyleBackColor = false;
            this.btnPassInt.Click += new System.EventHandler(this.btnPassInt_Click);
            // 
            // dgvIntervieweeList
            // 
            this.dgvIntervieweeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIntervieweeList.Location = new System.Drawing.Point(100, 140);
            this.dgvIntervieweeList.Name = "dgvIntervieweeList";
            this.dgvIntervieweeList.Size = new System.Drawing.Size(918, 200);
            this.dgvIntervieweeList.TabIndex = 51;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJob.ForeColor = System.Drawing.Color.Black;
            this.lblJob.Location = new System.Drawing.Point(448, 100);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(42, 19);
            this.lblJob.TabIndex = 50;
            this.lblJob.Text = "Job :";
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmp.ForeColor = System.Drawing.Color.Black;
            this.lblEmp.Location = new System.Drawing.Point(761, 100);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(90, 19);
            this.lblEmp.TabIndex = 49;
            this.lblEmp.Text = "Employer :";
            // 
            // lblJobOrder
            // 
            this.lblJobOrder.AutoSize = true;
            this.lblJobOrder.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobOrder.ForeColor = System.Drawing.Color.Black;
            this.lblJobOrder.Location = new System.Drawing.Point(100, 100);
            this.lblJobOrder.Name = "lblJobOrder";
            this.lblJobOrder.Size = new System.Drawing.Size(92, 19);
            this.lblJobOrder.TabIndex = 48;
            this.lblJobOrder.Text = "Job Order :";
            // 
            // lblIntervieweeList
            // 
            this.lblIntervieweeList.AutoSize = true;
            this.lblIntervieweeList.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntervieweeList.ForeColor = System.Drawing.Color.Black;
            this.lblIntervieweeList.Location = new System.Drawing.Point(25, 25);
            this.lblIntervieweeList.Name = "lblIntervieweeList";
            this.lblIntervieweeList.Size = new System.Drawing.Size(269, 39);
            this.lblIntervieweeList.TabIndex = 47;
            this.lblIntervieweeList.Text = "Interviewee List";
            // 
            // ucIntListFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFailInt);
            this.Controls.Add(this.btnPassInt);
            this.Controls.Add(this.dgvIntervieweeList);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.lblEmp);
            this.Controls.Add(this.lblJobOrder);
            this.Controls.Add(this.lblIntervieweeList);
            this.Name = "ucIntListFinal";
            this.Size = new System.Drawing.Size(1118, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntervieweeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFailInt;
        private System.Windows.Forms.Button btnPassInt;
        private System.Windows.Forms.DataGridView dgvIntervieweeList;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.Label lblJobOrder;
        private System.Windows.Forms.Label lblIntervieweeList;
    }
}
