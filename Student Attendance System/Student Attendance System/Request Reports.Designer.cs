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
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.rbtnAll = new System.Windows.Forms.RadioButton();
            this.rbtnSpesific = new System.Windows.Forms.RadioButton();
            this.btnSelectStudent = new System.Windows.Forms.Button();
            this.gbxStudents = new System.Windows.Forms.GroupBox();
            this.cbxModules = new System.Windows.Forms.ComboBox();
            this.calStart = new System.Windows.Forms.MonthCalendar();
            this.calEnd = new System.Windows.Forms.MonthCalendar();
            this.btnSelectDate = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.gbxStudents.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(269, 41);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(734, 489);
            this.dgvReport.TabIndex = 0;
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Checked = true;
            this.rbtnAll.Location = new System.Drawing.Point(17, 28);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(36, 17);
            this.rbtnAll.TabIndex = 5;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "All";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.CheckedChanged += new System.EventHandler(this.rbtnAll_CheckedChanged);
            // 
            // rbtnSpesific
            // 
            this.rbtnSpesific.AutoSize = true;
            this.rbtnSpesific.Location = new System.Drawing.Point(72, 28);
            this.rbtnSpesific.Name = "rbtnSpesific";
            this.rbtnSpesific.Size = new System.Drawing.Size(62, 17);
            this.rbtnSpesific.TabIndex = 6;
            this.rbtnSpesific.TabStop = true;
            this.rbtnSpesific.Text = "Spesific";
            this.rbtnSpesific.UseVisualStyleBackColor = true;
            this.rbtnSpesific.CheckedChanged += new System.EventHandler(this.rbtnAll_CheckedChanged);
            // 
            // btnSelectStudent
            // 
            this.btnSelectStudent.Enabled = false;
            this.btnSelectStudent.Location = new System.Drawing.Point(17, 71);
            this.btnSelectStudent.Name = "btnSelectStudent";
            this.btnSelectStudent.Size = new System.Drawing.Size(227, 28);
            this.btnSelectStudent.TabIndex = 7;
            this.btnSelectStudent.Text = "Select Student";
            this.btnSelectStudent.UseVisualStyleBackColor = true;
            this.btnSelectStudent.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // gbxStudents
            // 
            this.gbxStudents.Controls.Add(this.rbtnSpesific);
            this.gbxStudents.Controls.Add(this.rbtnAll);
            this.gbxStudents.Location = new System.Drawing.Point(17, 13);
            this.gbxStudents.Name = "gbxStudents";
            this.gbxStudents.Size = new System.Drawing.Size(227, 52);
            this.gbxStudents.TabIndex = 8;
            this.gbxStudents.TabStop = false;
            this.gbxStudents.Text = "Students";
            // 
            // cbxModules
            // 
            this.cbxModules.FormattingEnabled = true;
            this.cbxModules.Location = new System.Drawing.Point(17, 115);
            this.cbxModules.Name = "cbxModules";
            this.cbxModules.Size = new System.Drawing.Size(227, 21);
            this.cbxModules.TabIndex = 9;
            this.cbxModules.SelectedIndexChanged += new System.EventHandler(this.cbxModules_SelectedIndexChanged);
            // 
            // calStart
            // 
            this.calStart.Location = new System.Drawing.Point(17, 148);
            this.calStart.MaxSelectionCount = 1;
            this.calStart.Name = "calStart";
            this.calStart.TabIndex = 11;
            this.calStart.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calStart_DateChanged);
            // 
            // calEnd
            // 
            this.calEnd.Location = new System.Drawing.Point(17, 328);
            this.calEnd.MaxSelectionCount = 1;
            this.calEnd.Name = "calEnd";
            this.calEnd.TabIndex = 12;
            // 
            // btnSelectDate
            // 
            this.btnSelectDate.Enabled = false;
            this.btnSelectDate.Location = new System.Drawing.Point(17, 502);
            this.btnSelectDate.Name = "btnSelectDate";
            this.btnSelectDate.Size = new System.Drawing.Size(227, 28);
            this.btnSelectDate.TabIndex = 13;
            this.btnSelectDate.Text = "Select Date";
            this.btnSelectDate.UseVisualStyleBackColor = true;
            this.btnSelectDate.Click += new System.EventHandler(this.btnSelectDate_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Enabled = false;
            this.btnReturn.Location = new System.Drawing.Point(776, 538);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(227, 28);
            this.btnReturn.TabIndex = 15;
            this.btnReturn.Text = "Return to Menu ";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // Request_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 578);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSelectDate);
            this.Controls.Add(this.calEnd);
            this.Controls.Add(this.calStart);
            this.Controls.Add(this.cbxModules);
            this.Controls.Add(this.gbxStudents);
            this.Controls.Add(this.btnSelectStudent);
            this.Controls.Add(this.dgvReport);
            this.Name = "Request_Reports";
            this.Text = "Request_Reports";
            this.Load += new System.EventHandler(this.Request_Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.gbxStudents.ResumeLayout(false);
            this.gbxStudents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.RadioButton rbtnAll;
        private System.Windows.Forms.RadioButton rbtnSpesific;
        private System.Windows.Forms.Button btnSelectStudent;
        private System.Windows.Forms.GroupBox gbxStudents;
        private System.Windows.Forms.ComboBox cbxModules;
        private System.Windows.Forms.MonthCalendar calStart;
        private System.Windows.Forms.MonthCalendar calEnd;
        private System.Windows.Forms.Button btnSelectDate;
        private System.Windows.Forms.Button btnReturn;
    }
}