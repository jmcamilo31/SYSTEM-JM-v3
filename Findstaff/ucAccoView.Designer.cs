namespace Findstaff
{
    partial class ucAccoView
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
            this.lblViewAcco = new System.Windows.Forms.Label();
            this.lblApp = new System.Windows.Forms.Label();
            this.lblJobName = new System.Windows.Forms.Label();
            this.lblJobOrder = new System.Windows.Forms.Label();
            this.lblEmp = new System.Windows.Forms.Label();
            this.dgvViewAcco = new System.Windows.Forms.DataGridView();
            this.btnPayBal = new System.Windows.Forms.Button();
            this.pnlTabs = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAcco)).BeginInit();
            this.SuspendLayout();
            // 
            // lblViewAcco
            // 
            this.lblViewAcco.AutoSize = true;
            this.lblViewAcco.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewAcco.ForeColor = System.Drawing.Color.Black;
            this.lblViewAcco.Location = new System.Drawing.Point(25, 75);
            this.lblViewAcco.Name = "lblViewAcco";
            this.lblViewAcco.Size = new System.Drawing.Size(229, 39);
            this.lblViewAcco.TabIndex = 0;
            this.lblViewAcco.Text = "View Account";
            // 
            // lblApp
            // 
            this.lblApp.AutoSize = true;
            this.lblApp.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApp.ForeColor = System.Drawing.Color.Black;
            this.lblApp.Location = new System.Drawing.Point(100, 150);
            this.lblApp.Name = "lblApp";
            this.lblApp.Size = new System.Drawing.Size(88, 19);
            this.lblApp.TabIndex = 1;
            this.lblApp.Text = "Applicant :";
            // 
            // lblJobName
            // 
            this.lblJobName.AutoSize = true;
            this.lblJobName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobName.ForeColor = System.Drawing.Color.Black;
            this.lblJobName.Location = new System.Drawing.Point(100, 180);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(90, 19);
            this.lblJobName.TabIndex = 2;
            this.lblJobName.Text = "Job Name :";
            // 
            // lblJobOrder
            // 
            this.lblJobOrder.AutoSize = true;
            this.lblJobOrder.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobOrder.ForeColor = System.Drawing.Color.Black;
            this.lblJobOrder.Location = new System.Drawing.Point(600, 150);
            this.lblJobOrder.Name = "lblJobOrder";
            this.lblJobOrder.Size = new System.Drawing.Size(92, 19);
            this.lblJobOrder.TabIndex = 3;
            this.lblJobOrder.Text = "Job Order :";
            // 
            // lblEmp
            // 
            this.lblEmp.AutoSize = true;
            this.lblEmp.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmp.ForeColor = System.Drawing.Color.Black;
            this.lblEmp.Location = new System.Drawing.Point(600, 180);
            this.lblEmp.Name = "lblEmp";
            this.lblEmp.Size = new System.Drawing.Size(90, 19);
            this.lblEmp.TabIndex = 4;
            this.lblEmp.Text = "Employer :";
            // 
            // dgvViewAcco
            // 
            this.dgvViewAcco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewAcco.Location = new System.Drawing.Point(100, 220);
            this.dgvViewAcco.Name = "dgvViewAcco";
            this.dgvViewAcco.Size = new System.Drawing.Size(918, 200);
            this.dgvViewAcco.TabIndex = 5;
            // 
            // btnPayBal
            // 
            this.btnPayBal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPayBal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPayBal.FlatAppearance.BorderSize = 0;
            this.btnPayBal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPayBal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPayBal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayBal.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayBal.ForeColor = System.Drawing.Color.Black;
            this.btnPayBal.Location = new System.Drawing.Point(459, 435);
            this.btnPayBal.Name = "btnPayBal";
            this.btnPayBal.Size = new System.Drawing.Size(200, 50);
            this.btnPayBal.TabIndex = 6;
            this.btnPayBal.Text = "PAY BALANCE";
            this.btnPayBal.UseVisualStyleBackColor = false;
            this.btnPayBal.Click += new System.EventHandler(this.btnPayBal_Click);
            // 
            // pnlTabs
            // 
            this.pnlTabs.BackColor = System.Drawing.Color.White;
            this.pnlTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTabs.Location = new System.Drawing.Point(0, 0);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(1118, 50);
            this.pnlTabs.TabIndex = 60;
            // 
            // ucAccoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.pnlTabs);
            this.Controls.Add(this.btnPayBal);
            this.Controls.Add(this.dgvViewAcco);
            this.Controls.Add(this.lblEmp);
            this.Controls.Add(this.lblJobOrder);
            this.Controls.Add(this.lblJobName);
            this.Controls.Add(this.lblApp);
            this.Controls.Add(this.lblViewAcco);
            this.Name = "ucAccoView";
            this.Size = new System.Drawing.Size(1118, 500);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewAcco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblViewAcco;
        private System.Windows.Forms.Label lblApp;
        private System.Windows.Forms.Label lblJobName;
        private System.Windows.Forms.Label lblJobOrder;
        private System.Windows.Forms.Label lblEmp;
        private System.Windows.Forms.DataGridView dgvViewAcco;
        private System.Windows.Forms.Button btnPayBal;
        private System.Windows.Forms.Panel pnlTabs;
    }
}
