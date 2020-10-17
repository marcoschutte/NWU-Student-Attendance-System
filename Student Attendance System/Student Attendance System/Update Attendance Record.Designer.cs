namespace Student_Attendance_System
{
    partial class Update_Attendance_Record
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
            this.lblAttendanceID = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnUpdateRecord = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtModuleID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLecturerID = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAttendanceID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturnToAttendanceMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.Location = new System.Drawing.Point(503, 321);
            this.lblErrorMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(371, 87);
            this.lblErrorMessage.TabIndex = 147;
            this.lblErrorMessage.Text = "[Error message]";
            // 
            // lblAttendanceID
            // 
            this.lblAttendanceID.AutoSize = true;
            this.lblAttendanceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttendanceID.Location = new System.Drawing.Point(159, 425);
            this.lblAttendanceID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAttendanceID.Name = "lblAttendanceID";
            this.lblAttendanceID.Size = new System.Drawing.Size(0, 20);
            this.lblAttendanceID.TabIndex = 146;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(17, 425);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(134, 20);
            this.lbl1.TabIndex = 145;
            this.lbl1.Text = "Attendance ID:";
            // 
            // btnUpdateRecord
            // 
            this.btnUpdateRecord.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdateRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdateRecord.ForeColor = System.Drawing.Color.Purple;
            this.btnUpdateRecord.Location = new System.Drawing.Point(160, 607);
            this.btnUpdateRecord.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateRecord.Name = "btnUpdateRecord";
            this.btnUpdateRecord.Size = new System.Drawing.Size(232, 57);
            this.btnUpdateRecord.TabIndex = 136;
            this.btnUpdateRecord.Text = "Update Record";
            this.btnUpdateRecord.UseVisualStyleBackColor = false;
            this.btnUpdateRecord.Click += new System.EventHandler(this.btnUpdateRecord_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(156, 574);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(95, 20);
            this.lblTime.TabIndex = 144;
            this.lblTime.Text = "[hh:mm tt]";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(96, 574);
            this.lbl6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(56, 20);
            this.lbl6.TabIndex = 143;
            this.lbl6.Text = "Time:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(156, 543);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(119, 20);
            this.lblDate.TabIndex = 142;
            this.lblDate.Text = "[mm/dd/yyyy]";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(97, 543);
            this.lbl5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(55, 20);
            this.lbl5.TabIndex = 141;
            this.lbl5.Text = "Date:";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(160, 454);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentID.MaxLength = 8;
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(232, 22);
            this.txtStudentID.TabIndex = 133;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(48, 454);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(104, 20);
            this.lbl2.TabIndex = 140;
            this.lbl2.Text = "Student ID:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(51, 515);
            this.lbl4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(100, 20);
            this.lbl4.TabIndex = 139;
            this.lbl4.Text = "Module ID:";
            // 
            // txtModuleID
            // 
            this.txtModuleID.Location = new System.Drawing.Point(160, 513);
            this.txtModuleID.Margin = new System.Windows.Forms.Padding(4);
            this.txtModuleID.MaxLength = 7;
            this.txtModuleID.Name = "txtModuleID";
            this.txtModuleID.Size = new System.Drawing.Size(232, 22);
            this.txtModuleID.TabIndex = 135;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 454);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 138;
            // 
            // txtLecturerID
            // 
            this.txtLecturerID.Location = new System.Drawing.Point(160, 484);
            this.txtLecturerID.Margin = new System.Windows.Forms.Padding(4);
            this.txtLecturerID.MaxLength = 8;
            this.txtLecturerID.Name = "txtLecturerID";
            this.txtLecturerID.Size = new System.Drawing.Size(232, 22);
            this.txtLecturerID.TabIndex = 134;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(41, 484);
            this.lbl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(111, 20);
            this.lbl3.TabIndex = 137;
            this.lbl3.Text = "Lecturer ID:";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(17, 394);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(340, 20);
            this.lblMessage.TabIndex = 132;
            this.lblMessage.Text = "Enter the updated record details below:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Purple;
            this.btnClear.Location = new System.Drawing.Point(399, 288);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 87);
            this.btnClear.TabIndex = 131;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.Purple;
            this.btnSearch.Location = new System.Drawing.Point(159, 318);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(232, 57);
            this.btnSearch.TabIndex = 128;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 253);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(556, 20);
            this.label11.TabIndex = 130;
            this.label11.Text = "Please enter the Attendance ID of the record you want to update:";
            // 
            // txtAttendanceID
            // 
            this.txtAttendanceID.Location = new System.Drawing.Point(159, 288);
            this.txtAttendanceID.Margin = new System.Windows.Forms.Padding(4);
            this.txtAttendanceID.Name = "txtAttendanceID";
            this.txtAttendanceID.Size = new System.Drawing.Size(232, 22);
            this.txtAttendanceID.TabIndex = 127;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 288);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 20);
            this.label9.TabIndex = 129;
            this.label9.Text = "Attendance ID:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(21, 60);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(850, 190);
            this.dataGridView3.TabIndex = 126;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 48);
            this.label1.TabIndex = 125;
            this.label1.Text = "Update an attendance record";
            // 
            // btnReturnToAttendanceMenu
            // 
            this.btnReturnToAttendanceMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReturnToAttendanceMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnReturnToAttendanceMenu.ForeColor = System.Drawing.Color.Purple;
            this.btnReturnToAttendanceMenu.Location = new System.Drawing.Point(585, 607);
            this.btnReturnToAttendanceMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturnToAttendanceMenu.Name = "btnReturnToAttendanceMenu";
            this.btnReturnToAttendanceMenu.Size = new System.Drawing.Size(286, 57);
            this.btnReturnToAttendanceMenu.TabIndex = 148;
            this.btnReturnToAttendanceMenu.Text = "Return to Attendance Menu";
            this.btnReturnToAttendanceMenu.UseVisualStyleBackColor = false;
            this.btnReturnToAttendanceMenu.Click += new System.EventHandler(this.btnReturnToAttendanceMenu_Click);
            // 
            // Update_Attendance_Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 672);
            this.Controls.Add(this.btnReturnToAttendanceMenu);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.lblAttendanceID);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnUpdateRecord);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.txtModuleID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLecturerID);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtAttendanceID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label1);
            this.Name = "Update_Attendance_Record";
            this.Text = "Update_Attendance_Record";
            this.Load += new System.EventHandler(this.Update_Attendance_Record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label lblAttendanceID;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnUpdateRecord;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lbl5;
        public System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txtModuleID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLecturerID;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtAttendanceID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturnToAttendanceMenu;
    }
}