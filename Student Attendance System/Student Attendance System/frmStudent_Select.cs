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
    public partial class frmStudent_Select : Form
    {
        Maintain_Helper maintainhelper = new Maintain_Helper();

        SqlConnection conn = null;
        SqlDataAdapter adap;
        SqlCommand comm;
        DataSet ds;

        string studentid, sql;

        public string StudentID
        {
            get { return studentid; }
            set { studentid = value; }
        }

        public frmStudent_Select()
        {
            InitializeComponent();
        }

        private void Connect()
        {
            if (conn == null)
                conn = new SqlConnection(maintainhelper.ConnectionString);
        }

        public void StudentSearch(string caller, string criteria)
        {
            sql = "SELECT Student_ID, Last_Name, Name, Email FROM STUDENTS WHERE " + caller + " LIKE  '%" + criteria + "%'";

            SQLSubmit();
        }

        private void DisplayAll()
        {
            sql = "SELECT Student_ID, Last_Name, Name, Email FROM STUDENTS";

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
            catch (SqlException se)
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


        private void frmStudent_Select_Load(object sender, EventArgs e)
        {
            DisplayAll();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            StudentID = dgvStudents.CurrentRow.Cells[0].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
