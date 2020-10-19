namespace Student_Attendance_System
{
    partial class Student_Attendance
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
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.lblClassDetails = new System.Windows.Forms.Label();
            this.btnSubmitAttendance = new System.Windows.Forms.Button();
            this.lblSelectLecturer = new System.Windows.Forms.Label();
            this.lblModuleID = new System.Windows.Forms.Label();
            this.txtModuleID = new System.Windows.Forms.TextBox();
            this.loverslanePictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnExitApplication = new System.Windows.Forms.Button();
            this.lblEnterStudentNumber = new System.Windows.Forms.Label();
            this.txtLecturer_ID = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblStudentID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loverslanePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.Location = new System.Drawing.Point(308, 76);
            this.lblErrorMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(330, 20);
            this.lblErrorMessage.TabIndex = 42;
            this.lblErrorMessage.Text = "Please enter your class details below:";
            // 
            // lblClassDetails
            // 
            this.lblClassDetails.AutoSize = true;
            this.lblClassDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassDetails.ForeColor = System.Drawing.Color.Purple;
            this.lblClassDetails.Location = new System.Drawing.Point(301, 14);
            this.lblClassDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClassDetails.Name = "lblClassDetails";
            this.lblClassDetails.Size = new System.Drawing.Size(375, 48);
            this.lblClassDetails.TabIndex = 41;
            this.lblClassDetails.Text = "Class Attendance ";
            // 
            // btnSubmitAttendance
            // 
            this.btnSubmitAttendance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubmitAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmitAttendance.ForeColor = System.Drawing.Color.Purple;
            this.btnSubmitAttendance.Location = new System.Drawing.Point(427, 281);
            this.btnSubmitAttendance.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmitAttendance.Name = "btnSubmitAttendance";
            this.btnSubmitAttendance.Size = new System.Drawing.Size(220, 57);
            this.btnSubmitAttendance.TabIndex = 2;
            this.btnSubmitAttendance.Text = "Submit Attendance";
            this.btnSubmitAttendance.UseVisualStyleBackColor = false;
            this.btnSubmitAttendance.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblSelectLecturer
            // 
            this.lblSelectLecturer.AutoSize = true;
            this.lblSelectLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectLecturer.Location = new System.Drawing.Point(301, 144);
            this.lblSelectLecturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectLecturer.Name = "lblSelectLecturer";
            this.lblSelectLecturer.Size = new System.Drawing.Size(111, 20);
            this.lblSelectLecturer.TabIndex = 39;
            this.lblSelectLecturer.Text = "Lecturer ID:";
            // 
            // lblModuleID
            // 
            this.lblModuleID.AutoSize = true;
            this.lblModuleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModuleID.Location = new System.Drawing.Point(312, 174);
            this.lblModuleID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModuleID.Name = "lblModuleID";
            this.lblModuleID.Size = new System.Drawing.Size(100, 20);
            this.lblModuleID.TabIndex = 38;
            this.lblModuleID.Text = "Module ID:";
            // 
            // txtModuleID
            // 
            this.txtModuleID.Location = new System.Drawing.Point(432, 174);
            this.txtModuleID.Margin = new System.Windows.Forms.Padding(4);
            this.txtModuleID.MaxLength = 7;
            this.txtModuleID.Name = "txtModuleID";
            this.txtModuleID.Size = new System.Drawing.Size(215, 22);
            this.txtModuleID.TabIndex = 1;
            // 
            // loverslanePictureBox
            // 
            this.loverslanePictureBox.Image = global::Student_Attendance_System.Properties.Resources.LoversLane;
            this.loverslanePictureBox.Location = new System.Drawing.Point(13, 14);
            this.loverslanePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.loverslanePictureBox.Name = "loverslanePictureBox";
            this.loverslanePictureBox.Size = new System.Drawing.Size(287, 420);
            this.loverslanePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loverslanePictureBox.TabIndex = 37;
            this.loverslanePictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 243);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Time:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDate.Location = new System.Drawing.Point(428, 208);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(119, 20);
            this.lblDate.TabIndex = 46;
            this.lblDate.Text = "[mm/dd/yyyy]";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(429, 243);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(95, 20);
            this.lblTime.TabIndex = 47;
            this.lblTime.Text = "[hh:mm tt]";
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExitApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExitApplication.ForeColor = System.Drawing.Color.Purple;
            this.btnExitApplication.Location = new System.Drawing.Point(523, 374);
            this.btnExitApplication.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(153, 57);
            this.btnExitApplication.TabIndex = 4;
            this.btnExitApplication.Text = "Exit Application";
            this.btnExitApplication.UseVisualStyleBackColor = false;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitApplication_Click);
            // 
            // lblEnterStudentNumber
            // 
            this.lblEnterStudentNumber.AutoSize = true;
            this.lblEnterStudentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterStudentNumber.Location = new System.Drawing.Point(308, 114);
            this.lblEnterStudentNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnterStudentNumber.Name = "lblEnterStudentNumber";
            this.lblEnterStudentNumber.Size = new System.Drawing.Size(104, 20);
            this.lblEnterStudentNumber.TabIndex = 49;
            this.lblEnterStudentNumber.Text = "Student ID:";
            // 
            // txtLecturer_ID
            // 
            this.txtLecturer_ID.Location = new System.Drawing.Point(432, 144);
            this.txtLecturer_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txtLecturer_ID.MaxLength = 8;
            this.txtLecturer_ID.Name = "txtLecturer_ID";
            this.txtLecturer_ID.Size = new System.Drawing.Size(215, 22);
            this.txtLecturer_ID.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Purple;
            this.btnClear.Location = new System.Drawing.Point(554, 204);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 69);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.Location = new System.Drawing.Point(429, 114);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(110, 20);
            this.lblStudentID.TabIndex = 53;
            this.lblStudentID.Text = "[Student ID]";
            // 
            // Student_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 444);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtLecturer_ID);
            this.Controls.Add(this.lblEnterStudentNumber);
            this.Controls.Add(this.btnExitApplication);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtModuleID);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.lblClassDetails);
            this.Controls.Add(this.btnSubmitAttendance);
            this.Controls.Add(this.lblSelectLecturer);
            this.Controls.Add(this.lblModuleID);
            this.Controls.Add(this.loverslanePictureBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Student_Attendance";
            this.Text = "Student_Attendance";
            this.Load += new System.EventHandler(this.Student_Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loverslanePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label lblClassDetails;
        private System.Windows.Forms.Button btnSubmitAttendance;
        private System.Windows.Forms.Label lblSelectLecturer;
        private System.Windows.Forms.Label lblModuleID;
        private System.Windows.Forms.PictureBox loverslanePictureBox;
        private System.Windows.Forms.TextBox txtModuleID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnExitApplication;
        private System.Windows.Forms.Label lblEnterStudentNumber;
        private System.Windows.Forms.TextBox txtLecturer_ID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblStudentID;
    }
}