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
            this.lblClassDetails.Location = new System.Drawing.Point(236, 18);
            this.lblClassDetails.Name = "lblClassDetails";
            this.lblClassDetails.Size = new System.Drawing.Size(186, 38);
            this.lblClassDetails.TabIndex = 42;
            this.lblClassDetails.Text = "Main Menu";
            // 
            // loverslanePictureBox
            // 
            this.loverslanePictureBox.Image = global::Student_Attendance_System.Properties.Resources.LoversLane;
            this.loverslanePictureBox.Location = new System.Drawing.Point(10, 11);
            this.loverslanePictureBox.Name = "loverslanePictureBox";
            this.loverslanePictureBox.Size = new System.Drawing.Size(226, 367);
            this.loverslanePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loverslanePictureBox.TabIndex = 43;
            this.loverslanePictureBox.TabStop = false;
            // 
            // btnMaintainStudents
            // 
            this.btnMaintainStudents.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMaintainStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnMaintainStudents.ForeColor = System.Drawing.Color.Purple;
            this.btnMaintainStudents.Location = new System.Drawing.Point(242, 75);
            this.btnMaintainStudents.Name = "btnMaintainStudents";
            this.btnMaintainStudents.Size = new System.Drawing.Size(165, 41);
            this.btnMaintainStudents.TabIndex = 0;
            this.btnMaintainStudents.Text = "Maintain Students";
            this.btnMaintainStudents.UseVisualStyleBackColor = false;
            this.btnMaintainStudents.Click += new System.EventHandler(this.btnMaintainStudents_Click);
            // 
            // btnMaintainLecturers
            // 
            this.btnMaintainLecturers.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMaintainLecturers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnMaintainLecturers.ForeColor = System.Drawing.Color.Purple;
            this.btnMaintainLecturers.Location = new System.Drawing.Point(242, 122);
            this.btnMaintainLecturers.Name = "btnMaintainLecturers";
            this.btnMaintainLecturers.Size = new System.Drawing.Size(165, 41);
            this.btnMaintainLecturers.TabIndex = 1;
            this.btnMaintainLecturers.Text = "Maintain Lecturers";
            this.btnMaintainLecturers.UseVisualStyleBackColor = false;
            this.btnMaintainLecturers.Click += new System.EventHandler(this.btnMaintainLecturers_Click);
            // 
            // btnMaintainModules
            // 
            this.btnMaintainModules.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMaintainModules.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnMaintainModules.ForeColor = System.Drawing.Color.Purple;
            this.btnMaintainModules.Location = new System.Drawing.Point(242, 169);
            this.btnMaintainModules.Name = "btnMaintainModules";
            this.btnMaintainModules.Size = new System.Drawing.Size(165, 41);
            this.btnMaintainModules.TabIndex = 2;
            this.btnMaintainModules.Text = "Maintain Modules";
            this.btnMaintainModules.UseVisualStyleBackColor = false;
            this.btnMaintainModules.Click += new System.EventHandler(this.btnMaintainModules_Click);
            // 
            // btnMaintainStudentAttendance
            // 
            this.btnMaintainStudentAttendance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMaintainStudentAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnMaintainStudentAttendance.ForeColor = System.Drawing.Color.Purple;
            this.btnMaintainStudentAttendance.Location = new System.Drawing.Point(242, 216);
            this.btnMaintainStudentAttendance.Name = "btnMaintainStudentAttendance";
            this.btnMaintainStudentAttendance.Size = new System.Drawing.Size(165, 46);
            this.btnMaintainStudentAttendance.TabIndex = 3;
            this.btnMaintainStudentAttendance.Text = "Maintain Student Attendance";
            this.btnMaintainStudentAttendance.UseVisualStyleBackColor = false;
            this.btnMaintainStudentAttendance.Click += new System.EventHandler(this.btnMaintainStudentAttendance_Click);
            // 
            // btnRequestReports
            // 
            this.btnRequestReports.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRequestReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnRequestReports.ForeColor = System.Drawing.Color.Purple;
            this.btnRequestReports.Location = new System.Drawing.Point(242, 269);
            this.btnRequestReports.Name = "btnRequestReports";
            this.btnRequestReports.Size = new System.Drawing.Size(165, 41);
            this.btnRequestReports.TabIndex = 4;
            this.btnRequestReports.Text = "Request Reports";
            this.btnRequestReports.UseVisualStyleBackColor = false;
            this.btnRequestReports.Click += new System.EventHandler(this.btnRequestReports_Click);
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExitApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExitApplication.ForeColor = System.Drawing.Color.Purple;
            this.btnExitApplication.Location = new System.Drawing.Point(242, 327);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(166, 41);
            this.btnExitApplication.TabIndex = 5;
            this.btnExitApplication.Text = "Exit Application";
            this.btnExitApplication.UseVisualStyleBackColor = false;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitApplication_Click);
            // 
            // Lecturer_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 388);
            this.Controls.Add(this.btnExitApplication);
            this.Controls.Add(this.btnRequestReports);
            this.Controls.Add(this.btnMaintainStudentAttendance);
            this.Controls.Add(this.btnMaintainModules);
            this.Controls.Add(this.btnMaintainLecturers);
            this.Controls.Add(this.btnMaintainStudents);
            this.Controls.Add(this.loverslanePictureBox);
            this.Controls.Add(this.lblClassDetails);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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