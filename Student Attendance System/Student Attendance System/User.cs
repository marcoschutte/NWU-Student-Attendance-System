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
        bool _cameBack = false;
        public User()
        {
            InitializeComponent();
        }

        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            _redButtonClicked = false;
            DialogResult close = MessageBox.Show("Are you sure you want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

             

            if (DialogResult.Yes == close)
                Application.Exit();
        }

        private void btnLecturer_Click(object sender, EventArgs e)
        {
            Lecturer_Login lecturerLogin = new Lecturer_Login();
            lecturerLogin.Show();
            _cameBack = true;
            this.Hide();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Student_Login studentLogin = new Student_Login();
            studentLogin.Show();
            _cameBack = true;
            this.Hide();
        }

        private void User_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_redButtonClicked == true && _cameBack == false)
            {
                DialogResult _closingForm = MessageBox.Show("Are you sure you want to close the Program", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (DialogResult.No == _closingForm)
                    e.Cancel = true;
               // else
                  //  e.Cancel = true;
            }
        }
    }
}
