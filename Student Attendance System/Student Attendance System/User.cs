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
        bool _redButtonClicked = true;

        public User()
        {
            InitializeComponent();
        }

        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            DialogResult close = MessageBox.Show("Are you sure you want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            _redButtonClicked = false; 

            if (DialogResult.Yes == close)
                Application.Exit();
        }

        private void btnLecturer_Click(object sender, EventArgs e)
        {
            Lecturer_Login lecturerLogin = new Lecturer_Login();
            lecturerLogin.Show();
            this.Hide();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Student_Login studentLogin = new Student_Login();
            studentLogin.Show();
            this.Hide();
        }

        private void User_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_redButtonClicked == true)
            {
                DialogResult _closingForm = MessageBox.Show("Are you sure you want to close the Program", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (DialogResult.Yes == _closingForm)
                    Environment.Exit(0);
                else
                    e.Cancel = true;
            }
        }
    }
}
