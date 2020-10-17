using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Attendance_System
{
    public partial class Request_Reports : Form
    {
        public Request_Reports()
        {
            InitializeComponent();
        }

        //declare and initialize the connection string
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bernh\Source\Repos\CMPG223-Project\Student Attendance System\Student Attendance System\Database1.mdf;Integrated Security=True";

        //using System.Data.SqlClient namespace
        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataSet dataset;

        private void DisplayTable()
        {
            //query statement
            string selectAll = "SELECT * FROM ATTENDANCE";

            connection = new SqlConnection(connectionString);

            //open the connection
            connection.Open();

            command = new SqlCommand(selectAll, connection);

            dataset = new DataSet();
            adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(dataset, "ATTENDANCE");

            dataGridView1.DataSource = dataset;
            dataGridView1.DataMember = "ATTENDANCE";

            //close the connection
            connection.Close();

            txtStudentNumber.Focus();
        }


        private void Request_Reports_Load(object sender, EventArgs e)
        {
            DisplayTable();
        }

        private void btnShowAttendance_Click(object sender, EventArgs e)
        {
            //query statement
            string searchQuery = "SELECT * FROM ATTENDANCE WHERE Student_ID LIKE '" + txtStudentNumber.Text + "%'";

            connection = new SqlConnection(connectionString);

            //open the connection
            connection.Open();

            adapter = new SqlDataAdapter();
            dataset = new DataSet();

            command = new SqlCommand(searchQuery, connection);

            adapter.SelectCommand = command;
            adapter.Fill(dataset, "ATTENDANCE");

            dataGridView1.DataSource = dataset;
            dataGridView1.DataMember = "ATTENDANCE";

            //close the connection
            connection.Close();

            txtStudentNumber.Focus();

            //clear the text box
            txtStudentNumber.Text = "";
        }
    }
}
