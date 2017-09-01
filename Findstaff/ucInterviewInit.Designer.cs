namespace Findstaff
{
    partial class ucInterviewInit
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
            this.btnViewIntList = new System.Windows.Forms.Button();
            this.dgvInitInt = new System.Windows.Forms.DataGridView();
            this.lblInitInt = new System.Windows.Forms.Label();
            this.ucIntListInit = new Findstaff.ucIntListInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInitInt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewIntList
            // 
            this.btnViewIntList.BackColor = System.Drawing.Color.Gainsboro;
            this.btnViewIntList.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewIntList.FlatAppearance.BorderSize = 0;
            this.btnViewIntList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewIntList.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewIntList.ForeColor = System.Drawing.Color.Black;
            this.btnViewIntList.Location = new System.Drawing.Point(459, 345);
            this.btnViewIntList.Name = "btnViewIntList";
            this.btnViewIntList.Size = new System.Drawing.Size(200, 50);
            this.btnViewIntList.TabIndex = 43;
            this.btnViewIntList.Text = "VIEW INTERVIEWEE LIST";
            this.btnViewIntList.UseVisualStyleBackColor = false;
            this.btnViewIntList.Click += new System.EventHandler(this.btnViewIntList_Click);
            // 
            // dgvInitInt
            // 
            this.dgvInitInt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInitInt.Location = new System.Drawing.Point(100, 100);
            this.dgvInitInt.Name = "dgvInitInt";
            this.dgvInitInt.Size = new System.Drawing.Size(918, 200);
            this.dgvInitInt.TabIndex = 42;
            // 
            // lblInitInt
            // 
            this.lblInitInt.AutoSize = true;
            this.lblInitInt.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitInt.ForeColor = System.Drawing.Color.Black;
            this.lblInitInt.Location = new System.Drawing.Point(25, 25);
            this.lblInitInt.Name = "lblInitInt";
            this.lblInitInt.Size = new System.Drawing.Size(270, 39);
            this.lblInitInt.TabIndex = 41;
            this.lblInitInt.Text = "Initial Interview";
            // 
            // ucIntListInit
            // 
            this.ucIntListInit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucIntListInit.Location = new System.Drawing.Point(0, 0);
            this.ucIntListInit.Name = "ucIntListInit";
            this.ucIntListInit.Size = new System.Drawing.Size(10, 10);
            this.ucIntListInit.TabIndex = 44;
            this.ucIntListInit.Visible = false;
            // 
            // ucInterviewInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.ucIntListInit);
            this.Controls.Add(this.btnViewIntList);
            this.Controls.Add(this.dgvInitInt);
            this.Controls.Add(this.lblInitInt);
            this.Name = "ucInterviewInit";
            this.Size = new System.Drawing.Size(1118, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInitInt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewIntList;
        private System.Windows.Forms.DataGridView dgvInitInt;
        private System.Windows.Forms.Label lblInitInt;
        private ucIntListInit ucIntListInit;
    }
}
