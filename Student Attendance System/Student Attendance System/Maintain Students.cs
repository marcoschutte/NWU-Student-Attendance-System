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
    public partial class Maintain_Students : Form
    {
        Maintain_Helper maintainhelper = new Maintain_Helper();

        SqlConnection conn = null;
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader dreader;
        string sql;

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
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if(maintainhelper.CheckEmail(email))
            {   
                if(maintainhelper.CheckID(id))
                {
                    if (maintainhelper.Insert('S', id, fname, lname, email, password))
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {

        }

        private void Connect()
        {
            if (conn == null)
                conn = new SqlConnection(maintainhelper.ConnectionString);
        }

        public void StudentSearch(string caller)
        {
            sql = "SELECT ";// FIELDS TO DISPLAY

            SQLSubmit("");
        }

        private void DisplayAll()
        {
            sql = "SELECT ";//DISPLAY ALL FIELDS
        }

        private void SQLSubmit(string caller)
        {
            Connect();
            conn.Open();

            comm = new SqlCommand(sql, conn);
            adap = new SqlDataAdapter();
            ds = new DataSet();

            adap.SelectCommand = comm;
            adap.Fill(ds, "STUDENTS");

            dgvStudents.DataSource = ds;
            dgvStudents.DataMember = "STUDENTS";
        }

        private void txtSID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSLName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSEmail_TextChanged(object sender, EventArgs e)
        {

        }  
    }
}
