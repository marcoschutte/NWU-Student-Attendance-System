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
    public partial class Maintain_Students : Form
    {
        Maintain_Helper maintainhelper = new Maintain_Helper();

        public Maintain_Students()
        {
            InitializeComponent();
        }

        private void btnReturnToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            string id = txtStudentID.Text;
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string password = txtPassword.Text;

            //Checks

            //maintainhelper.Insert('S', );
        }
    }
}
