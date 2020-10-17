namespace Student_Attendance_System
{
    partial class User
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
            this.components = new System.ComponentModel.Container();
            this.btnExitApplication = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnLecturer = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExitApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnExitApplication.ForeColor = System.Drawing.Color.Purple;
            this.btnExitApplication.Location = new System.Drawing.Point(619, 658);
            this.btnExitApplication.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(163, 57);
            this.btnExitApplication.TabIndex = 2;
            this.btnExitApplication.Text = "Exit Application";
            this.toolTip1.SetToolTip(this.btnExitApplication, "Click to close the application");
            this.btnExitApplication.UseVisualStyleBackColor = false;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitApplication_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(109, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(562, 48);
            this.label2.TabIndex = 11;
            this.label2.Text = "Student Attendance System";
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnStudent.BackgroundImage = global::Student_Attendance_System.Properties.Resources.Student;
            this.btnStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.btnStudent.ForeColor = System.Drawing.Color.Purple;
            this.btnStudent.Location = new System.Drawing.Point(415, 258);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(340, 379);
            this.btnStudent.TabIndex = 1;
            this.btnStudent.Text = "Student";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnStudent, "Click to go to the student login page");
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnLecturer
            // 
            this.btnLecturer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLecturer.BackgroundImage = global::Student_Attendance_System.Properties.Resources.Lecturer;
            this.btnLecturer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.btnLecturer.ForeColor = System.Drawing.Color.Purple;
            this.btnLecturer.Location = new System.Drawing.Point(38, 258);
            this.btnLecturer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLecturer.Name = "btnLecturer";
            this.btnLecturer.Size = new System.Drawing.Size(340, 379);
            this.btnLecturer.TabIndex = 0;
            this.btnLecturer.Text = "Lecturer";
            this.btnLecturer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.btnLecturer, "Click to go to the lecturer login page");
            this.btnLecturer.UseVisualStyleBackColor = false;
            this.btnLecturer.Click += new System.EventHandler(this.btnLecturer_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::Student_Attendance_System.Properties.Resources.NWU;
            this.logoPictureBox.Location = new System.Drawing.Point(13, 14);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(768, 165);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 729);
            this.Controls.Add(this.btnExitApplication);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnLecturer);
            this.Controls.Add(this.logoPictureBox);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "User";
            this.Text = "User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.User_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExitApplication;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnLecturer;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label label2;
    }
}

