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
using System.Data.Sql;

namespace Student_Attendance_System
{
    public partial class Existing_IDs : Form
    {
        public Existing_IDs()
        {
            InitializeComponent();
        }
        SqlCommand command;
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataSet dataset;

        public string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SAS_DB.mdf;Integrated Security = True";

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Existing_IDs_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();

            command = new SqlCommand("SELECT Student_ID FROM STUDENTS", connection);
            dataset = new DataSet();
            adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(dataset, "STUDENTS");
            dgvStudentID.DataSource = dataset;
            dgvStudentID.DataMember = "STUDENTS";

            command = new SqlCommand("SELECT Lecturer_ID FROM LECTURERS", connection);
            dataset = new DataSet();
            adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(dataset, "LECTURERS");
            dgvLecturerID.DataSource = dataset;
            dgvLecturerID.DataMember = "LECTURERS";

            command = new SqlCommand("SELECT Module_ID FROM MODULES", connection);
            dataset = new DataSet();
            adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(dataset, "STUDENTS");
            dgvModuleID.DataSource = dataset;
            dgvModuleID.DataMember = "STUDENTS";


        }
    }
}
