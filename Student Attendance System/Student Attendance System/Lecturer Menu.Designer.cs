namespace Student_Attendance_System
{
    partial class Lecturer_Menu
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
            this.lblClassDetails = new System.Windows.Forms.Label();
            this.loverslanePictureBox = new System.Windows.Forms.PictureBox();
            this.btnMaintainStudents = new System.Windows.Forms.Button();
            this.btnMaintainLecturers = new System.Windows.Forms.Button();
            this.btnMaintainModules = new System.Windows.Forms.Button();
            this.btnMaintainStudentAttendance = new System.Windows.Forms.Button();
            this.btnRequestReports = new System.Windows.Forms.Button();
            this.btnExitApplication = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loverslanePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClassDetails
            // 
            this.lblClassDetails.AutoSize = true;
            this.lblClassDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassDetails.ForeColor = System.Drawing.Color.Purple;
            this.lblClassDetails.Location = new System.Drawing.Point(315, 22);
            this.lblClassDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClassDetails.Name = "lblClassDetails";
            this.lblClassDetails.Size = new System.Drawing.Size(235, 48);
            this.lblClassDetails.TabIndex = 42;
            this.lblClassDetails.Text = "Main Menu";
            // 
            // loverslanePictureBox
            // 
            this.loverslanePictureBox.Image = global::Student_Attendance_System.Properties.Resources.LoversLane;
            this.loverslanePictureBox.Location = new System.Drawing.Point(13, 13);
            this.loverslanePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.loverslanePictureBox.Name = "loverslanePictureBox";
            this.loverslanePictureBox.Size = new System.Drawing.Size(302, 452);
            this.loverslanePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loverslanePictureBox.TabIndex = 43;
            this.loverslanePictureBox.TabStop = false;
            // 
            // btnMaintainStudents
            // 
            this.btnMaintainStudents.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMaintainStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnMaintainStudents.ForeColor = System.Drawing.Color.Purple;
            this.btnMaintainStudents.Location = new System.Drawing.Point(323, 92);
            this.btnMaintainStudents.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaintainStudents.Name = "btnMaintainStudents";
            this.btnMaintainStudents.Size = new System.Drawing.Size(220, 50);
            this.btnMaintainStudents.TabIndex = 44;
            this.btnMaintainStudents.Text = "Maintain Students";
            this.btnMaintainStudents.UseVisualStyleBackColor = false;
            this.btnMaintainStudents.Click += new System.EventHandler(this.btnMaintainStudents_Click);
            // 
            // btnMaintainLecturers
            // 
            this.btnMaintainLecturers.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMaintainLecturers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnMaintainLecturers.ForeColor = System.Drawing.Color.Purple;
            this.btnMaintainLecturers.Location = new System.Drawing.Point(323, 150);
            this.btnMaintainLecturers.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaintainLecturers.Name = "btnMaintainLecturers";
            this.btnMaintainLecturers.Size = new System.Drawing.Size(220, 50);
            this.btnMaintainLecturers.TabIndex = 45;
            this.btnMaintainLecturers.Text = "Maintain Lecturers";
            this.btnMaintainLecturers.UseVisualStyleBackColor = false;
            this.btnMaintainLecturers.Click += new System.EventHandler(this.btnMaintainLecturers_Click);
            // 
            // btnMaintainModules
            // 
            this.btnMaintainModules.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMaintainModules.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnMaintainModules.ForeColor = System.Drawing.Color.Purple;
            this.btnMaintainModules.Location = new System.Drawing.Point(323, 208);
            this.btnMaintainModules.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaintainModules.Name = "btnMaintainModules";
            this.btnMaintainModules.Size = new System.Drawing.Size(220, 50);
            this.btnMaintainModules.TabIndex = 46;
            this.btnMaintainModules.Text = "Maintain Modules";
            this.btnMaintainModules.UseVisualStyleBackColor = false;
            this.btnMaintainModules.Click += new System.EventHandler(this.btnMaintainModules_Click);
            // 
            // btnMaintainStudentAttendance
            // 
            this.btnMaintainStudentAttendance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMaintainStudentAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnMaintainStudentAttendance.ForeColor = System.Drawing.Color.Purple;
            this.btnMaintainStudentAttendance.Location = new System.Drawing.Point(323, 266);
            this.btnMaintainStudentAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaintainStudentAttendance.Name = "btnMaintainStudentAttendance";
            this.btnMaintainStudentAttendance.Size = new System.Drawing.Size(220, 57);
            this.btnMaintainStudentAttendance.TabIndex = 47;
            this.btnMaintainStudentAttendance.Text = "Maintain Student Attendance";
            this.btnMaintainStudentAttendance.UseVisualStyleBackColor = false;
            this.btnMaintainStudentAttendance.Click += new System.EventHandler(this.btnMaintainStudentAttendance_Click);
            // 
            // btnRequestReports
            // 
            this.btnRequestReports.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRequestReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnRequestReports.ForeColor = System.Drawing.Color.Purple;
            this.btnRequestReports.Location = new System.Drawing.Point(323, 331);
            this.btnRequestReports.Margin = new System.Windows.Forms.Padding(4);
            this.btnRequestReports.Name = "btnRequestReports";
            this.btnRequestReports.Size = new System.Drawing.Size(220, 50);
            this.btnRequestReports.TabIndex = 48;
            this.btnRequestReports.Text = "Request Reports";
            this.btnRequestReports.UseVisualStyleBackColor = false;
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExitApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExitApplication.ForeColor = System.Drawing.Color.Purple;
            this.btnExitApplication.Location = new System.Drawing.Point(323, 402);
            this.btnExitApplication.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(222, 50);
            this.btnExitApplication.TabIndex = 49;
            this.btnExitApplication.Text = "Exit Application";
            this.btnExitApplication.UseVisualStyleBackColor = false;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitApplication_Click);
            // 
            // Lecturer_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 477);
            this.Controls.Add(this.btnExitApplication);
            this.Controls.Add(this.btnRequestReports);
            this.Controls.Add(this.btnMaintainStudentAttendance);
            this.Controls.Add(this.btnMaintainModules);
            this.Controls.Add(this.btnMaintainLecturers);
            this.Controls.Add(this.btnMaintainStudents);
            this.Controls.Add(this.loverslanePictureBox);
            this.Controls.Add(this.lblClassDetails);
            this.Name = "Lecturer_Menu";
            this.Text = "Lecturer_Menu";
            ((System.ComponentModel.ISupportInitialize)(this.loverslanePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClassDetails;
        private System.Windows.Forms.PictureBox loverslanePictureBox;
        private System.Windows.Forms.Button btnMaintainStudents;
        private System.Windows.Forms.Button btnMaintainLecturers;
        private System.Windows.Forms.Button btnMaintainModules;
        private System.Windows.Forms.Button btnMaintainStudentAttendance;
        private System.Windows.Forms.Button btnRequestReports;
        private System.Windows.Forms.Button btnExitApplication;
    }
}