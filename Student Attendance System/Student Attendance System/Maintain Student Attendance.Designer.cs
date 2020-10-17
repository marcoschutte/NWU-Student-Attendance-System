namespace Student_Attendance_System
{
    partial class Maintain_Student_Attendance
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
            this.btnAddAttendance = new System.Windows.Forms.Button();
            this.loverslanePictureBox = new System.Windows.Forms.PictureBox();
            this.btnDeleteAttendance = new System.Windows.Forms.Button();
            this.btnUpdateAttendance = new System.Windows.Forms.Button();
            this.lblClassDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loverslanePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddAttendance
            // 
            this.btnAddAttendance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddAttendance.ForeColor = System.Drawing.Color.Purple;
            this.btnAddAttendance.Location = new System.Drawing.Point(13, 70);
            this.btnAddAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAttendance.Name = "btnAddAttendance";
            this.btnAddAttendance.Size = new System.Drawing.Size(241, 57);
            this.btnAddAttendance.TabIndex = 4;
            this.btnAddAttendance.Text = "Add Attendance";
            this.btnAddAttendance.UseVisualStyleBackColor = false;
            this.btnAddAttendance.Click += new System.EventHandler(this.btnAddAttendance_Click);
            // 
            // loverslanePictureBox
            // 
            this.loverslanePictureBox.Image = global::Student_Attendance_System.Properties.Resources.Building3;
            this.loverslanePictureBox.Location = new System.Drawing.Point(13, 265);
            this.loverslanePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.loverslanePictureBox.Name = "loverslanePictureBox";
            this.loverslanePictureBox.Size = new System.Drawing.Size(241, 158);
            this.loverslanePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loverslanePictureBox.TabIndex = 44;
            this.loverslanePictureBox.TabStop = false;
            // 
            // btnDeleteAttendance
            // 
            this.btnDeleteAttendance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteAttendance.ForeColor = System.Drawing.Color.Purple;
            this.btnDeleteAttendance.Location = new System.Drawing.Point(13, 135);
            this.btnDeleteAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAttendance.Name = "btnDeleteAttendance";
            this.btnDeleteAttendance.Size = new System.Drawing.Size(241, 57);
            this.btnDeleteAttendance.TabIndex = 45;
            this.btnDeleteAttendance.Text = "Delete Attendance";
            this.btnDeleteAttendance.UseVisualStyleBackColor = false;
            // 
            // btnUpdateAttendance
            // 
            this.btnUpdateAttendance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdateAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdateAttendance.ForeColor = System.Drawing.Color.Purple;
            this.btnUpdateAttendance.Location = new System.Drawing.Point(13, 200);
            this.btnUpdateAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateAttendance.Name = "btnUpdateAttendance";
            this.btnUpdateAttendance.Size = new System.Drawing.Size(241, 57);
            this.btnUpdateAttendance.TabIndex = 46;
            this.btnUpdateAttendance.Text = "Update Attendance";
            this.btnUpdateAttendance.UseVisualStyleBackColor = false;
            // 
            // lblClassDetails
            // 
            this.lblClassDetails.AutoSize = true;
            this.lblClassDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassDetails.ForeColor = System.Drawing.Color.Purple;
            this.lblClassDetails.Location = new System.Drawing.Point(13, 9);
            this.lblClassDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClassDetails.Name = "lblClassDetails";
            this.lblClassDetails.Size = new System.Drawing.Size(241, 48);
            this.lblClassDetails.TabIndex = 47;
            this.lblClassDetails.Text = "Attendance";
            // 
            // Maintain_Student_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 434);
            this.Controls.Add(this.lblClassDetails);
            this.Controls.Add(this.btnUpdateAttendance);
            this.Controls.Add(this.btnDeleteAttendance);
            this.Controls.Add(this.loverslanePictureBox);
            this.Controls.Add(this.btnAddAttendance);
            this.Name = "Maintain_Student_Attendance";
            this.Text = "Maintain_Student_Attendance";
            ((System.ComponentModel.ISupportInitialize)(this.loverslanePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddAttendance;
        private System.Windows.Forms.PictureBox loverslanePictureBox;
        private System.Windows.Forms.Button btnDeleteAttendance;
        private System.Windows.Forms.Button btnUpdateAttendance;
        private System.Windows.Forms.Label lblClassDetails;
    }
}