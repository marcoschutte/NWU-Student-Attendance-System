using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_System
{
    public partial class Maintain_Lecturers : Form
    {
        Maintain_Helper maintainhelper = new Maintain_Helper();

        public Maintain_Lecturers()
        {
            InitializeComponent();
        }

        private void btnReturnToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddLecturer_Click(object sender, EventArgs e)
        {
            string id = txtLecturerID.Text;
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (maintainhelper.CheckEmail(email))
            {
                if (maintainhelper.CheckID(id))
                {
                    if (maintainhelper.Insert('L', id, fname, lname, email, password))
                        MessageBox.Show("Record has been succesfully inserted.");
                    else
                        MessageBox.Show("There was a problem inserting the record.");
                }
                else
                    MessageBox.Show("Incorrect id");
            }
            else
                MessageBox.Show("Incorrect email.");
        }
    }
}
