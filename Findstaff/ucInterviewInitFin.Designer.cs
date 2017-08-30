namespace Findstaff
{
    partial class ucInterviewInitFin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewIntList1 = new System.Windows.Forms.Button();
            this.dgvInitInt = new System.Windows.Forms.DataGridView();
            this.lblInitInt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnViewIntList2 = new System.Windows.Forms.Button();
            this.dgvFinInt = new System.Windows.Forms.DataGridView();
            this.lblFinInt = new System.Windows.Forms.Label();
            this.ucIntListInit = new Findstaff.ucIntListInit();
            this.ucIntListFinal = new Findstaff.ucIntListFinal();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInitInt)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinInt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucIntListInit);
            this.panel1.Controls.Add(this.btnViewIntList1);
            this.panel1.Controls.Add(this.dgvInitInt);
            this.panel1.Controls.Add(this.lblInitInt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnViewIntList1
            // 
            this.btnViewIntList1.BackColor = System.Drawing.Color.Gainsboro;
            this.btnViewIntList1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewIntList1.FlatAppearance.BorderSize = 0;
            this.btnViewIntList1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewIntList1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewIntList1.ForeColor = System.Drawing.Color.Black;
            this.btnViewIntList1.Location = new System.Drawing.Point(459, 345);
            this.btnViewIntList1.Name = "btnViewIntList1";
            this.btnViewIntList1.Size = new System.Drawing.Size(200, 50);
            this.btnViewIntList1.TabIndex = 40;
            this.btnViewIntList1.Text = "VIEW INTERVIEWEE LIST";
            this.btnViewIntList1.UseVisualStyleBackColor = false;
            this.btnViewIntList1.Click += new System.EventHandler(this.btnViewIntList1_Click);
            // 
            // dgvInitInt
            // 
            this.dgvInitInt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInitInt.Location = new System.Drawing.Point(100, 100);
            this.dgvInitInt.Name = "dgvInitInt";
            this.dgvInitInt.Size = new System.Drawing.Size(918, 200);
            this.dgvInitInt.TabIndex = 39;
            // 
            // lblInitInt
            // 
            this.lblInitInt.AutoSize = true;
            this.lblInitInt.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitInt.ForeColor = System.Drawing.Color.Black;
            this.lblInitInt.Location = new System.Drawing.Point(25, 25);
            this.lblInitInt.Name = "lblInitInt";
            this.lblInitInt.Size = new System.Drawing.Size(270, 39);
            this.lblInitInt.TabIndex = 38;
            this.lblInitInt.Text = "Initial Interview";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ucIntListFinal);
            this.panel2.Controls.Add(this.btnViewIntList2);
            this.panel2.Controls.Add(this.dgvFinInt);
            this.panel2.Controls.Add(this.lblFinInt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1108, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 450);
            this.panel2.TabIndex = 1;
            // 
            // btnViewIntList2
            // 
            this.btnViewIntList2.BackColor = System.Drawing.Color.Gainsboro;
            this.btnViewIntList2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewIntList2.FlatAppearance.BorderSize = 0;
            this.btnViewIntList2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewIntList2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewIntList2.ForeColor = System.Drawing.Color.Black;
            this.btnViewIntList2.Location = new System.Drawing.Point(459, 345);
            this.btnViewIntList2.Name = "btnViewIntList2";
            this.btnViewIntList2.Size = new System.Drawing.Size(200, 50);
            this.btnViewIntList2.TabIndex = 43;
            this.btnViewIntList2.Text = "VIEW INTERVIEWEE LIST";
            this.btnViewIntList2.UseVisualStyleBackColor = false;
            this.btnViewIntList2.Click += new System.EventHandler(this.btnViewIntList2_Click);
            // 
            // dgvFinInt
            // 
            this.dgvFinInt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFinInt.Location = new System.Drawing.Point(100, 100);
            this.dgvFinInt.Name = "dgvFinInt";
            this.dgvFinInt.Size = new System.Drawing.Size(918, 200);
            this.dgvFinInt.TabIndex = 42;
            // 
            // lblFinInt
            // 
            this.lblFinInt.AutoSize = true;
            this.lblFinInt.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinInt.ForeColor = System.Drawing.Color.Black;
            this.lblFinInt.Location = new System.Drawing.Point(25, 25);
            this.lblFinInt.Name = "lblFinInt";
            this.lblFinInt.Size = new System.Drawing.Size(256, 39);
            this.lblFinInt.TabIndex = 41;
            this.lblFinInt.Text = "Final Interview";
            // 
            // ucIntListInit
            // 
            this.ucIntListInit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucIntListInit.Location = new System.Drawing.Point(0, 0);
            this.ucIntListInit.Name = "ucIntListInit";
            this.ucIntListInit.Size = new System.Drawing.Size(10, 10);
            this.ucIntListInit.TabIndex = 41;
            this.ucIntListInit.Visible = false;
            // 
            // ucIntListFinal
            // 
            this.ucIntListFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucIntListFinal.Location = new System.Drawing.Point(0, 0);
            this.ucIntListFinal.Name = "ucIntListFinal";
            this.ucIntListFinal.Size = new System.Drawing.Size(10, 10);
            this.ucIntListFinal.TabIndex = 44;
            this.ucIntListFinal.Visible = false;
            // 
            // ucInterviewInitFin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucInterviewInitFin";
            this.Size = new System.Drawing.Size(1118, 450);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInitInt)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFinInt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnViewIntList1;
        private System.Windows.Forms.DataGridView dgvInitInt;
        private System.Windows.Forms.Label lblInitInt;
        private System.Windows.Forms.Button btnViewIntList2;
        private System.Windows.Forms.DataGridView dgvFinInt;
        private System.Windows.Forms.Label lblFinInt;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        private ucIntListInit ucIntListInit;
        private ucIntListFinal ucIntListFinal;
    }
}
