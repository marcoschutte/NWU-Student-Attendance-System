namespace Student_Attendance_System
{
    partial class Existing_IDs
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
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.dgvStudentID = new System.Windows.Forms.DataGridView();
            this.dgvLecturerID = new System.Windows.Forms.DataGridView();
            this.dgvModuleID = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModuleID)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClassDetails
            // 
            this.lblClassDetails.AutoSize = true;
            this.lblClassDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassDetails.ForeColor = System.Drawing.Color.Purple;
            this.lblClassDetails.Location = new System.Drawing.Point(191, 9);
            this.lblClassDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClassDetails.Name = "lblClassDetails";
            this.lblClassDetails.Size = new System.Drawing.Size(254, 48);
            this.lblClassDetails.TabIndex = 42;
            this.lblClassDetails.Text = "Existing IDs";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.Location = new System.Drawing.Point(13, 66);
            this.lblErrorMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(608, 56);
            this.lblErrorMessage.TabIndex = 43;
            this.lblErrorMessage.Text = "All Student, Lecturer and Module IDs that can be used for submitting an attendanc" +
    "e record are listed below:";
            // 
            // dgvStudentID
            // 
            this.dgvStudentID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentID.Location = new System.Drawing.Point(17, 156);
            this.dgvStudentID.Name = "dgvStudentID";
            this.dgvStudentID.RowTemplate.Height = 24;
            this.dgvStudentID.Size = new System.Drawing.Size(189, 458);
            this.dgvStudentID.TabIndex = 44;
            // 
            // dgvLecturerID
            // 
            this.dgvLecturerID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLecturerID.Location = new System.Drawing.Point(222, 156);
            this.dgvLecturerID.Name = "dgvLecturerID";
            this.dgvLecturerID.RowTemplate.Height = 24;
            this.dgvLecturerID.Size = new System.Drawing.Size(189, 458);
            this.dgvLecturerID.TabIndex = 45;
            // 
            // dgvModuleID
            // 
            this.dgvModuleID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModuleID.Location = new System.Drawing.Point(427, 156);
            this.dgvModuleID.Name = "dgvModuleID";
            this.dgvModuleID.RowTemplate.Height = 24;
            this.dgvModuleID.Size = new System.Drawing.Size(189, 458);
            this.dgvModuleID.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Student IDs:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Lecturer IDs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(423, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "Module IDs:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.Purple;
            this.btnClose.Location = new System.Drawing.Point(427, 621);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(189, 59);
            this.btnClose.TabIndex = 50;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 621);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(394, 56);
            this.label4.TabIndex = 51;
            this.label4.Text = "Please contact an Admin Lecturer to add more IDs to the list!";
            // 
            // Existing_IDs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 690);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvModuleID);
            this.Controls.Add(this.dgvLecturerID);
            this.Controls.Add(this.dgvStudentID);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.lblClassDetails);
            this.Name = "Existing_IDs";
            this.Text = "Existing_IDs";
            this.Load += new System.EventHandler(this.Existing_IDs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModuleID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClassDetails;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.DataGridView dgvStudentID;
        private System.Windows.Forms.DataGridView dgvLecturerID;
        private System.Windows.Forms.DataGridView dgvModuleID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label4;
    }
}