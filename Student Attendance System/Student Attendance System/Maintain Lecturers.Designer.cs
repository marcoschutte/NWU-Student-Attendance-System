namespace Student_Attendance_System
{
    partial class Maintain_Lecturers
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtSEmail = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSLName = new System.Windows.Forms.TextBox();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.dgvLecturers = new System.Windows.Forms.DataGridView();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReturnToMenu = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteLecturer = new System.Windows.Forms.Button();
            this.btnAddLecturer = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLecturerID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxAdmin = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSelect.ForeColor = System.Drawing.Color.Purple;
            this.btnSelect.Location = new System.Drawing.Point(443, 411);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(228, 44);
            this.btnSelect.TabIndex = 75;
            this.btnSelect.Text = "Select Lecturer";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtSEmail
            // 
            this.txtSEmail.Location = new System.Drawing.Point(1109, 82);
            this.txtSEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSEmail.MaxLength = 25;
            this.txtSEmail.Name = "txtSEmail";
            this.txtSEmail.Size = new System.Drawing.Size(201, 22);
            this.txtSEmail.TabIndex = 74;
            this.txtSEmail.TextChanged += new System.EventHandler(this.txtSEmail_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.Purple;
            this.btnUpdate.Location = new System.Drawing.Point(125, 359);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(228, 44);
            this.btnUpdate.TabIndex = 73;
            this.btnUpdate.Text = "Update Details";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSLName
            // 
            this.txtSLName.Location = new System.Drawing.Point(701, 82);
            this.txtSLName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSLName.MaxLength = 25;
            this.txtSLName.Name = "txtSLName";
            this.txtSLName.Size = new System.Drawing.Size(201, 22);
            this.txtSLName.TabIndex = 72;
            this.txtSLName.TextChanged += new System.EventHandler(this.txtSLName_TextChanged);
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(905, 82);
            this.txtSName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSName.MaxLength = 25;
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(201, 22);
            this.txtSName.TabIndex = 71;
            this.txtSName.TextChanged += new System.EventHandler(this.txtSName_TextChanged);
            // 
            // txtSID
            // 
            this.txtSID.Location = new System.Drawing.Point(497, 82);
            this.txtSID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSID.MaxLength = 25;
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(201, 22);
            this.txtSID.TabIndex = 70;
            this.txtSID.TextChanged += new System.EventHandler(this.txtSID_TextChanged);
            // 
            // dgvLecturers
            // 
            this.dgvLecturers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLecturers.Location = new System.Drawing.Point(443, 114);
            this.dgvLecturers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLecturers.Name = "dgvLecturers";
            this.dgvLecturers.Size = new System.Drawing.Size(869, 289);
            this.dgvLecturers.TabIndex = 69;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(129, 241);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.MaxLength = 25;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(223, 22);
            this.txtPassword.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 241);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 68;
            this.label9.Text = "Password: ";
            // 
            // btnReturnToMenu
            // 
            this.btnReturnToMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReturnToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnReturnToMenu.ForeColor = System.Drawing.Color.Purple;
            this.btnReturnToMenu.Location = new System.Drawing.Point(1097, 411);
            this.btnReturnToMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReturnToMenu.Name = "btnReturnToMenu";
            this.btnReturnToMenu.Size = new System.Drawing.Size(215, 44);
            this.btnReturnToMenu.TabIndex = 67;
            this.btnReturnToMenu.Text = "Return To Menu";
            this.btnReturnToMenu.UseVisualStyleBackColor = false;
            this.btnReturnToMenu.Click += new System.EventHandler(this.btnReturnToMenu_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Purple;
            this.label8.Location = new System.Drawing.Point(433, 11);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(329, 48);
            this.label8.TabIndex = 66;
            this.label8.Text = "Lecturer Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 65;
            this.label5.Text = "Lecturer ID:";
            // 
            // btnDeleteLecturer
            // 
            this.btnDeleteLecturer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteLecturer.Enabled = false;
            this.btnDeleteLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteLecturer.ForeColor = System.Drawing.Color.Purple;
            this.btnDeleteLecturer.Location = new System.Drawing.Point(125, 411);
            this.btnDeleteLecturer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteLecturer.Name = "btnDeleteLecturer";
            this.btnDeleteLecturer.Size = new System.Drawing.Size(228, 44);
            this.btnDeleteLecturer.TabIndex = 60;
            this.btnDeleteLecturer.Text = "Delete Lecturer";
            this.btnDeleteLecturer.UseVisualStyleBackColor = false;
            this.btnDeleteLecturer.Click += new System.EventHandler(this.btnDeleteLecturer_Click);
            // 
            // btnAddLecturer
            // 
            this.btnAddLecturer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddLecturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddLecturer.ForeColor = System.Drawing.Color.Purple;
            this.btnAddLecturer.Location = new System.Drawing.Point(129, 308);
            this.btnAddLecturer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddLecturer.Name = "btnAddLecturer";
            this.btnAddLecturer.Size = new System.Drawing.Size(224, 44);
            this.btnAddLecturer.TabIndex = 59;
            this.btnAddLecturer.Text = "Add Lecturer";
            this.btnAddLecturer.UseVisualStyleBackColor = false;
            this.btnAddLecturer.Click += new System.EventHandler(this.btnAddLecturer_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(129, 209);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.MaxLength = 35;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 22);
            this.txtEmail.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 209);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "Email:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(129, 145);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.MaxLength = 25;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(223, 22);
            this.txtLastName.TabIndex = 55;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(129, 114);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstName.MaxLength = 25;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(223, 22);
            this.txtFirstName.TabIndex = 54;
            // 
            // txtLecturerID
            // 
            this.txtLecturerID.Location = new System.Drawing.Point(129, 177);
            this.txtLecturerID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLecturerID.MaxLength = 8;
            this.txtLecturerID.Name = "txtLecturerID";
            this.txtLecturerID.Size = new System.Drawing.Size(223, 22);
            this.txtLecturerID.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 63;
            this.label6.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 145);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 62;
            this.label4.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(36, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 48);
            this.label2.TabIndex = 61;
            this.label2.Text = "Add Lecturer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 278);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "Admin:";
            // 
            // cbxAdmin
            // 
            this.cbxAdmin.AutoSize = true;
            this.cbxAdmin.Location = new System.Drawing.Point(129, 281);
            this.cbxAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxAdmin.Name = "cbxAdmin";
            this.cbxAdmin.Size = new System.Drawing.Size(18, 17);
            this.cbxAdmin.TabIndex = 77;
            this.cbxAdmin.UseVisualStyleBackColor = true;
            // 
            // Maintain_Lecturers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 471);
            this.Controls.Add(this.cbxAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtSEmail);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtSLName);
            this.Controls.Add(this.txtSName);
            this.Controls.Add(this.txtSID);
            this.Controls.Add(this.dgvLecturers);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnReturnToMenu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDeleteLecturer);
            this.Controls.Add(this.btnAddLecturer);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLecturerID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Maintain_Lecturers";
            this.Text = "Maintain_Lecturers";
            this.Load += new System.EventHandler(this.Maintain_Lecturers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLecturers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtSEmail;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSLName;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.DataGridView dgvLecturers;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnReturnToMenu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteLecturer;
        private System.Windows.Forms.Button btnAddLecturer;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLecturerID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbxAdmin;
    }
}