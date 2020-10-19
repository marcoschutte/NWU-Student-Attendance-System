namespace Student_Attendance_System
{
    partial class frmStudent_Select
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
            this.txtSLName = new System.Windows.Forms.TextBox();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSelect.ForeColor = System.Drawing.Color.Purple;
            this.btnSelect.Location = new System.Drawing.Point(12, 234);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(171, 36);
            this.btnSelect.TabIndex = 53;
            this.btnSelect.Text = "Select Student";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtSEmail
            // 
            this.txtSEmail.Location = new System.Drawing.Point(512, 6);
            this.txtSEmail.MaxLength = 25;
            this.txtSEmail.Name = "txtSEmail";
            this.txtSEmail.Size = new System.Drawing.Size(152, 20);
            this.txtSEmail.TabIndex = 59;
            this.txtSEmail.TextChanged += new System.EventHandler(this.txtSEmail_TextChanged);
            // 
            // txtSLName
            // 
            this.txtSLName.Location = new System.Drawing.Point(206, 6);
            this.txtSLName.MaxLength = 25;
            this.txtSLName.Name = "txtSLName";
            this.txtSLName.Size = new System.Drawing.Size(152, 20);
            this.txtSLName.TabIndex = 58;
            this.txtSLName.TextChanged += new System.EventHandler(this.txtSLName_TextChanged);
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(359, 6);
            this.txtSName.MaxLength = 25;
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(152, 20);
            this.txtSName.TabIndex = 57;
            this.txtSName.TextChanged += new System.EventHandler(this.txtSName_TextChanged);
            // 
            // txtSID
            // 
            this.txtSID.Location = new System.Drawing.Point(53, 6);
            this.txtSID.MaxLength = 25;
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(152, 20);
            this.txtSID.TabIndex = 56;
            this.txtSID.TextChanged += new System.EventHandler(this.txtSID_TextChanged);
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(12, 32);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(652, 195);
            this.dgvStudents.TabIndex = 55;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnReturn.ForeColor = System.Drawing.Color.Purple;
            this.btnReturn.Location = new System.Drawing.Point(501, 234);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(161, 36);
            this.btnReturn.TabIndex = 54;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmStudent_Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 281);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtSEmail);
            this.Controls.Add(this.txtSLName);
            this.Controls.Add(this.txtSName);
            this.Controls.Add(this.txtSID);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.btnReturn);
            this.Name = "frmStudent_Select";
            this.Text = "frmStudent_Select";
            this.Load += new System.EventHandler(this.frmStudent_Select_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtSEmail;
        private System.Windows.Forms.TextBox txtSLName;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnReturn;
    }
}