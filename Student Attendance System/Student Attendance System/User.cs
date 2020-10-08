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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLecturer_Click(object sender, EventArgs e)
        {
            Lecturer_Login lecturerLogin = new Lecturer_Login();
            lecturerLogin.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Student_Login studentLogin = new Student_Login();
            studentLogin.Show();
        }
    }
}
