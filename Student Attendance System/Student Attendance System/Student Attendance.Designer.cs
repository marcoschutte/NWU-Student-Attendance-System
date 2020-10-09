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
            this.lblPleaseSelect = new System.Windows.Forms.Label();
            this.lblClassDetails = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblSelectLecturer = new System.Windows.Forms.Label();
            this.lblSelectModule = new System.Windows.Forms.Label();
            this.lecturerComboBox = new System.Windows.Forms.ComboBox();
            this.txtModuleID = new System.Windows.Forms.TextBox();
            this.loverslanePictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnExitApplication = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.loverslanePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPleaseSelect
            // 
            this.lblPleaseSelect.AutoSize = true;
            this.lblPleaseSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleaseSelect.Location = new System.Drawing.Point(308, 89);
            this.lblPleaseSelect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPleaseSelect.Name = "lblPleaseSelect";
            this.lblPleaseSelect.Size = new System.Drawing.Size(330, 20);
            this.lblPleaseSelect.TabIndex = 42;
            this.lblPleaseSelect.Text = "Please enter your class details below:";
            // 
            // lblClassDetails
            // 
            this.lblClassDetails.AutoSize = true;
            this.lblClassDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassDetails.ForeColor = System.Drawing.Color.Purple;
            this.lblClassDetails.Location = new System.Drawing.Point(301, 13);
            this.lblClassDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClassDetails.Name = "lblClassDetails";
            this.lblClassDetails.Size = new System.Drawing.Size(375, 48);
            this.lblClassDetails.TabIndex = 41;
            this.lblClassDetails.Text = "Class Attendance ";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.Purple;
            this.btnSubmit.Location = new System.Drawing.Point(311, 376);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(220, 57);
            this.btnSubmit.TabIndex = 36;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // lblSelectLecturer
            // 
            this.lblSelectLecturer.AutoSize = true;
            this.lblSelectLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectLecturer.Location = new System.Drawing.Point(331, 193);
            this.lblSelectLecturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectLecturer.Name = "lblSelectLecturer";
            this.lblSelectLecturer.Size = new System.Drawing.Size(181, 20);
            this.lblSelectLecturer.TabIndex = 39;
            this.lblSelectLecturer.Text = "Select your lecturer:";
            // 
            // lblSelectModule
            // 
            this.lblSelectModule.AutoSize = true;
            this.lblSelectModule.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectModule.Location = new System.Drawing.Point(308, 149);
            this.lblSelectModule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectModule.Name = "lblSelectModule";
            this.lblSelectModule.Size = new System.Drawing.Size(204, 20);
            this.lblSelectModule.TabIndex = 38;
            this.lblSelectModule.Text = "Enter the module code:";
            // 
            // lecturerComboBox
            // 
            this.lecturerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lecturerComboBox.FormattingEnabled = true;
            this.lecturerComboBox.Items.AddRange(new object[] {
            "Roelien Goede",
            "Janet Liebenberg",
            "Linda Redelinghuys"});
            this.lecturerComboBox.Location = new System.Drawing.Point(529, 193);
            this.lecturerComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.lecturerComboBox.Name = "lecturerComboBox";
            this.lecturerComboBox.Size = new System.Drawing.Size(232, 24);
            this.lecturerComboBox.TabIndex = 35;
            // 
            // txtModuleID
            // 
            this.txtModuleID.Location = new System.Drawing.Point(529, 149);
            this.txtModuleID.Margin = new System.Windows.Forms.Padding(4);
            this.txtModuleID.Name = "txtModuleID";
            this.txtModuleID.Size = new System.Drawing.Size(232, 22);
            this.txtModuleID.TabIndex = 43;
            // 
            // loverslanePictureBox
            // 
            this.loverslanePictureBox.Image = global::Student_Attendance_System.Properties.Resources.LoversLane;
            this.loverslanePictureBox.Location = new System.Drawing.Point(13, 13);
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
            this.label1.Location = new System.Drawing.Point(457, 242);
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
            this.label2.Location = new System.Drawing.Point(456, 283);
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
            this.lblDate.Location = new System.Drawing.Point(525, 242);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(135, 20);
            this.lblDate.TabIndex = 46;
            this.lblDate.Text = "[MM/DD/YYYY]";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(527, 283);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(111, 20);
            this.lblTime.TabIndex = 47;
            this.lblTime.Text = "[h:mm:ss tt]";
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExitApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExitApplication.ForeColor = System.Drawing.Color.Purple;
            this.btnExitApplication.Location = new System.Drawing.Point(539, 377);
            this.btnExitApplication.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(222, 57);
            this.btnExitApplication.TabIndex = 48;
            this.btnExitApplication.Text = "Exit Application";
            this.btnExitApplication.UseVisualStyleBackColor = false;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitApplication_Click);
            // 
            // Student_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 447);
            this.Controls.Add(this.btnExitApplication);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtModuleID);
            this.Controls.Add(this.lblPleaseSelect);
            this.Controls.Add(this.lblClassDetails);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblSelectLecturer);
            this.Controls.Add(this.lblSelectModule);
            this.Controls.Add(this.lecturerComboBox);
            this.Controls.Add(this.loverslanePictureBox);
            this.Name = "Student_Attendance";
            this.Text = "Student_Attendance";
            this.Load += new System.EventHandler(this.Student_Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loverslanePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPleaseSelect;
        private System.Windows.Forms.Label lblClassDetails;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblSelectLecturer;
        private System.Windows.Forms.Label lblSelectModule;
        private System.Windows.Forms.ComboBox lecturerComboBox;
        private System.Windows.Forms.PictureBox loverslanePictureBox;
        private System.Windows.Forms.TextBox txtModuleID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnExitApplication;
    }
}