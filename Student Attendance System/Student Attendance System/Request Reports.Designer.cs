namespace Student_Attendance_System
{
    partial class Request_Reports
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblRR = new System.Windows.Forms.Label();
            this.lbl_ESN = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnShowAttendance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(723, 314);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblRR
            // 
            this.lblRR.AutoSize = true;
            this.lblRR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRR.Location = new System.Drawing.Point(13, 333);
            this.lblRR.Name = "lblRR";
            this.lblRR.Size = new System.Drawing.Size(332, 24);
            this.lblRR.TabIndex = 1;
            this.lblRR.Text = "Request report of the selected student:";
            // 
            // lbl_ESN
            // 
            this.lbl_ESN.AutoSize = true;
            this.lbl_ESN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ESN.Location = new System.Drawing.Point(12, 374);
            this.lbl_ESN.Name = "lbl_ESN";
            this.lbl_ESN.Size = new System.Drawing.Size(139, 16);
            this.lbl_ESN.TabIndex = 2;
            this.lbl_ESN.Text = "Enter student number: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 374);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btnShowAttendance
            // 
            this.btnShowAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAttendance.Location = new System.Drawing.Point(12, 415);
            this.btnShowAttendance.Name = "btnShowAttendance";
            this.btnShowAttendance.Size = new System.Drawing.Size(139, 23);
            this.btnShowAttendance.TabIndex = 4;
            this.btnShowAttendance.Text = "Show Attendance";
            this.btnShowAttendance.UseVisualStyleBackColor = true;
            this.btnShowAttendance.Click += new System.EventHandler(this.btnShowAttendance_Click);
            // 
            // Request_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 499);
            this.Controls.Add(this.btnShowAttendance);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_ESN);
            this.Controls.Add(this.lblRR);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Request_Reports";
            this.Text = "Request_Reports";
            this.Load += new System.EventHandler(this.Request_Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblRR;
        private System.Windows.Forms.Label lbl_ESN;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnShowAttendance;
    }
}