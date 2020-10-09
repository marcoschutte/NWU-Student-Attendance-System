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
    public partial class Lecturer_Login : Form
    {
        public Lecturer_Login()
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
            txtFirstName.Text = "";
            txtLecturerID.Text = "";
            txtPassword.Text = "";
        }

        private void btnLecturerLogIn_Click(object sender, EventArgs e)
        {
            Lecturer_Menu lecturerMenu = new Lecturer_Menu();
            lecturerMenu.Show();
        }
    }
}
