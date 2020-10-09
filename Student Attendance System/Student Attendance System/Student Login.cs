using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_System
{
    public partial class Student_Login : Form
    {
        public Student_Login()
        {
            InitializeComponent();
        }

        private void btnReturnToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtStudentID.Text = "";
            txtPassword.Text = "";
        }

        private void btnStudentLogIn_Click(object sender, EventArgs e)
        {
            //if login credentials are valid & exist within STUDENT table --> open student attendance form
            Student_Attendance studentAttendance = new Student_Attendance();
            studentAttendance.Show();
        }
    }
}
