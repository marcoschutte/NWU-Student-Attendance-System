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

        SqlConnection conn = null;
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader dreader;
        string sql;

        public Maintain_Lecturers()
        {
            InitializeComponent();
        }

        private void btnReturnToMenu_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void btnAddLecturer_Click(object sender, EventArgs e)
        {
            string id = txtLecturerID.Text;
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            int admin = Convert.ToInt32(cbxAdmin.Checked);

            if (maintainhelper.CheckEmail(email))
            {
                if (maintainhelper.CheckID(id))
                {
                    int result = maintainhelper.Insert(id, fname, lname, email, password, admin);

                    if (result > 0)
                    {
                        MessageBox.Show("Record has been succesfully inserted.");
                        Reset();
                    }
                    else if (result == 0)
                    {
                        MessageBox.Show("No record could be inserted");
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
            int result = maintainhelper.Update(txtLecturerID.Text, txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPassword.Text, Convert.ToInt32(cbxAdmin.Checked));

            if (result > 0)
            {
                MessageBox.Show("Record has been succesfully updated.");
                Reset();
            }
            else if (result == 0)
            {
                MessageBox.Show("No record could be updated");
            }
            else
                MessageBox.Show("There was a problem updating the record.");

            Reset();
        }

        private void btnDeleteLecturer_Click(object sender, EventArgs e)
        {
            int result = maintainhelper.Delete('L', txtLecturerID.Text);

            if (result > 0)
            {
                MessageBox.Show("Record has been succesfully deleted.");
                Reset();
            }
            else if (result == 0)
            {
                MessageBox.Show("No record could be deleted");
            }
            else
                MessageBox.Show("There was a problem deleting the record.");

            Reset();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string id = dgvLecturers.CurrentRow.Cells[0].Value.ToString();

            sql = "SELECT Lecturer_ID, Last_Name, Name, Email, Admin FROM LECTURERS WHERE Lecturer_ID = @id";

            try
            {
                Connect();
                conn.Open();

                comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@id", id);

                dreader = comm.ExecuteReader();

                while (dreader.Read())
                {
                    txtLecturerID.Text = dreader.GetString(0);
                    txtLastName.Text = dreader.GetString(1);
                    txtFirstName.Text = dreader.GetString(2);
                    txtEmail.Text = dreader.GetString(3);
                    cbxAdmin.Checked = Convert.ToBoolean(dreader.GetInt32(4));
                }

                conn.Close();
            }
            catch(SqlException se)
            {
                MessageBox.Show(se.Message);
            }

            btnUpdate.Enabled = true;
            btnDeleteLecturer.Enabled = true;
        }

        private void Connect()
        {
            if (conn == null)
                conn = new SqlConnection(maintainhelper.ConnectionString);
        }

        public void StudentSearch(string caller, string criteria)
        {
            sql = "SELECT Lecturer_ID, Last_Name, Name, Email FROM LECTURERS WHERE " + caller + " LIKE  '%" + criteria + "%'";// FIELDS TO DISPLAY

            SQLSubmit();
        }

        private void DisplayAll()
        {
            sql = "SELECT Lecturer_ID, Last_Name, Name, Email FROM LECTURERS";//DISPLAY ALL FIELDS

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
                adap.Fill(ds, "LECTURERS");

                dgvLecturers.DataSource = ds;
                dgvLecturers.DataMember = "LECTURERS";
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }

            dgvLecturers.Columns[0].Width = 150;
            dgvLecturers.Columns[1].Width = 150;
            dgvLecturers.Columns[2].Width = 150;
            dgvLecturers.Columns[3].Width = 150;

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
            txtLecturerID.Clear();
            txtEmail.Clear();

            btnUpdate.Enabled = false;
            btnDeleteLecturer.Enabled = false;

            DisplayAll();
        }

        private void txtSID_TextChanged(object sender, EventArgs e)
        {
            ClearSTextBox('I');
            StudentSearch("Lecturer_ID", txtSID.Text);
        }

        private void txtSLName_TextChanged(object sender, EventArgs e)
        {
            ClearSTextBox('L');
            StudentSearch("Last_Name", txtSLName.Text);
        }

        private void txtSName_TextChanged(object sender, EventArgs e)
        {
            ClearSTextBox('N');
            StudentSearch("Name", txtSName.Text);
        }

        private void txtSEmail_TextChanged(object sender, EventArgs e)
        {
            ClearSTextBox('E');
            StudentSearch("Email", txtSEmail.Text);
        }

        private void Maintain_Lecturers_Load(object sender, EventArgs e)
        {
            DisplayAll();
        }
    }
}
