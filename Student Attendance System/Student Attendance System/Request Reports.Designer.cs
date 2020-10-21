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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.gbxStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReport
            // 
            this.dgvReport.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(345, 244);
            this.dgvReport.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.Size = new System.Drawing.Size(507, 421);
            this.dgvReport.TabIndex = 0;
            // 
            // rbtnAll
            // 
            this.rbtnAll.AutoSize = true;
            this.rbtnAll.Checked = true;
            this.rbtnAll.Location = new System.Drawing.Point(23, 34);
            this.rbtnAll.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnAll.Name = "rbtnAll";
            this.rbtnAll.Size = new System.Drawing.Size(52, 24);
            this.rbtnAll.TabIndex = 5;
            this.rbtnAll.TabStop = true;
            this.rbtnAll.Text = "All";
            this.rbtnAll.UseVisualStyleBackColor = true;
            this.rbtnAll.CheckedChanged += new System.EventHandler(this.rbtnAll_CheckedChanged);
            // 
            // rbtnSpesific
            // 
            this.rbtnSpesific.AutoSize = true;
            this.rbtnSpesific.Location = new System.Drawing.Point(96, 34);
            this.rbtnSpesific.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnSpesific.Name = "rbtnSpesific";
            this.rbtnSpesific.Size = new System.Drawing.Size(98, 24);
            this.rbtnSpesific.TabIndex = 6;
            this.rbtnSpesific.TabStop = true;
            this.rbtnSpesific.Text = "Specific";
            this.rbtnSpesific.UseVisualStyleBackColor = true;
            this.rbtnSpesific.CheckedChanged += new System.EventHandler(this.rbtnAll_CheckedChanged);
            // 
            // btnSelectStudent
            // 
            this.btnSelectStudent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelectStudent.Enabled = false;
            this.btnSelectStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSelectStudent.Location = new System.Drawing.Point(23, 88);
            this.btnSelectStudent.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectStudent.Name = "btnSelectStudent";
            this.btnSelectStudent.Size = new System.Drawing.Size(304, 32);
            this.btnSelectStudent.TabIndex = 7;
            this.btnSelectStudent.Text = "Select Student";
            this.btnSelectStudent.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSelectStudent.UseVisualStyleBackColor = false;
            this.btnSelectStudent.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // gbxStudents
            // 
            this.gbxStudents.Controls.Add(this.rbtnSpesific);
            this.gbxStudents.Controls.Add(this.rbtnAll);
            this.gbxStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.gbxStudents.Location = new System.Drawing.Point(23, 16);
            this.gbxStudents.Margin = new System.Windows.Forms.Padding(4);
            this.gbxStudents.Name = "gbxStudents";
            this.gbxStudents.Padding = new System.Windows.Forms.Padding(4);
            this.gbxStudents.Size = new System.Drawing.Size(304, 64);
            this.gbxStudents.TabIndex = 8;
            this.gbxStudents.TabStop = false;
            this.gbxStudents.Text = "Students";
            // 
            // cbxModules
            // 
            this.cbxModules.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cbxModules.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbxModules.FormattingEnabled = true;
            this.cbxModules.Location = new System.Drawing.Point(23, 136);
            this.cbxModules.Margin = new System.Windows.Forms.Padding(4);
            this.cbxModules.Name = "cbxModules";
            this.cbxModules.Size = new System.Drawing.Size(304, 28);
            this.cbxModules.TabIndex = 9;
            this.cbxModules.Text = "Select Module";
            this.cbxModules.SelectedIndexChanged += new System.EventHandler(this.cbxModules_SelectedIndexChanged);
            // 
            // calStart
            // 
            this.calStart.Location = new System.Drawing.Point(23, 220);
            this.calStart.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.calStart.MaxSelectionCount = 1;
            this.calStart.Name = "calStart";
            this.calStart.TabIndex = 11;
            this.calStart.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calStart_DateChanged);
            // 
            // calEnd
            // 
            this.calEnd.Location = new System.Drawing.Point(23, 467);
            this.calEnd.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.calEnd.MaxSelectionCount = 1;
            this.calEnd.Name = "calEnd";
            this.calEnd.TabIndex = 12;
            // 
            // btnSelectDate
            // 
            this.btnSelectDate.Enabled = false;
            this.btnSelectDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSelectDate.ForeColor = System.Drawing.Color.Purple;
            this.btnSelectDate.Location = new System.Drawing.Point(23, 677);
            this.btnSelectDate.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectDate.Name = "btnSelectDate";
            this.btnSelectDate.Size = new System.Drawing.Size(304, 58);
            this.btnSelectDate.TabIndex = 13;
            this.btnSelectDate.Text = "Select Date";
            this.btnSelectDate.UseVisualStyleBackColor = true;
            this.btnSelectDate.Click += new System.EventHandler(this.btnSelectDate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 20);
            this.label3.TabIndex = 112;
            this.label3.Text = "Select Starting Date:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 438);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 113;
            this.label1.Text = "Select End Date:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Student_Attendance_System.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(345, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 114;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 216);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 115;
            this.label2.Text = "Generated Report:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Purple;
            this.button1.Location = new System.Drawing.Point(609, 672);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 63);
            this.button1.TabIndex = 117;
            this.button1.Text = "Return To Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Request_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 747);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSelectDate);
            this.Controls.Add(this.calEnd);
            this.Controls.Add(this.calStart);
            this.Controls.Add(this.cbxModules);
            this.Controls.Add(this.gbxStudents);
            this.Controls.Add(this.btnSelectStudent);
            this.Controls.Add(this.dgvReport);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Request_Reports";
            this.Text = "Request_Reports";
            this.Load += new System.EventHandler(this.Request_Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.gbxStudents.ResumeLayout(false);
            this.gbxStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}