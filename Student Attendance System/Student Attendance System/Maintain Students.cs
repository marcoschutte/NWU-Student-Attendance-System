using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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
            Owner.Show();
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
                if (maintainhelper.CheckID(id))
                {
                    if (maintainhelper.Insert(id, fname, lname, email, password))
                    { 
                        MessageBox.Show("Record has been succesfully inserted.");
                        Reset();
                    }   
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
            if (maintainhelper.Update(txtStudentID.Text, txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPassword.Text))
                MessageBox.Show("Record has been succesfully updated.");
            else
                MessageBox.Show("There was a problem updating the record.");
            
            Reset();
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (maintainhelper.Delete('S', txtStudentID.Text))
                MessageBox.Show("Record has been succesfully deleted.");
            else
                MessageBox.Show("There was a problem deleting the record.");

            Reset();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string id = dgvStudents.CurrentRow.Cells[0].Value.ToString();

            sql = "SELECT Student_ID, Last_Name, Name, Email FROM STUDENTS WHERE Student_ID = @id";

            Connect();
            conn.Open();

            comm = new SqlCommand(sql, conn);
            comm.Parameters.AddWithValue("@id", id);

            dreader = comm.ExecuteReader();

            while(dreader.Read())
            {
                txtStudentID.Text = dreader.GetString(0);
                txtLastName.Text = dreader.GetString(1);
                txtFirstName.Text = dreader.GetString(2);
                txtEmail.Text = dreader.GetString(3);
            }

            conn.Close();

            btnUpdate.Enabled = true;
            btnDeleteStudent.Enabled = true;
        }

        private void Connect()
        {
            if (conn == null)
                conn = new SqlConnection(maintainhelper.ConnectionString);
        }

        public void StudentSearch(string caller, string criteria)
        {
            sql = "SELECT Student_ID, Last_Name, Name, Email FROM STUDENTS WHERE " + caller + " LIKE  '%" + criteria + "%'" ;// FIELDS TO DISPLAY

            SQLSubmit();
        }

        private void DisplayAll()
        {
            sql = "SELECT Student_ID, Last_Name, Name, Email FROM STUDENTS";//DISPLAY ALL FIELDS

            SQLSubmit();
        }

        private void SQLSubmit()
        {
            Connect();
            conn.Open();

            try
            {
                comm = new SqlCommand(sql, conn);
                adap = new SqlDataAdapter();
                ds = new DataSet();

                adap.SelectCommand = comm;
                adap.Fill(ds, "STUDENTS");

                dgvStudents.DataSource = ds;
                dgvStudents.DataMember = "STUDENTS";
            }
            catch(SqlException se)
            {
                MessageBox.Show(se.Message);
            }

            dgvStudents.Columns[0].Width = 150;
            dgvStudents.Columns[1].Width = 150;
            dgvStudents.Columns[2].Width = 150;
            dgvStudents.Columns[3].Width = 150;

            conn.Close();
        }

        private void ClearSTextBox(char caller)
        {
            if (caller != 'I')
                txtSID.Clear();

            if (caller != 'L')
                txtSLName.Clear();

            if (caller != 'N')
                txtSName.Clear();

            if (caller != 'E')
                txtSEmail.Clear();
        }

        private void Reset()
        {
            ClearSTextBox(' ');
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPassword.Clear();
            txtStudentID.Clear();
            txtEmail.Clear();

            btnUpdate.Enabled = false;
            btnDeleteStudent.Enabled = false;

            DisplayAll();  
        }

        private void txtSID_TextChanged(object sender, EventArgs e)
        {
            ClearSTextBox('I');
            StudentSearch("Student_ID", txtSID.Text);
        }

        private void txtSName_TextChanged(object sender, EventArgs e)
        {
            ClearSTextBox('N');
            StudentSearch("Name", txtSName.Text);
        }

        private void txtSLName_TextChanged(object sender, EventArgs e)
        {
            ClearSTextBox('L');
            StudentSearch("Last_Name", txtSLName.Text);
        }

        private void txtSEmail_TextChanged(object sender, EventArgs e)
        {
            ClearSTextBox('E');
            StudentSearch("Email", txtSEmail.Text);
        }

        private void Maintain_Students_Load(object sender, EventArgs e)
        {
            DisplayAll();
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
