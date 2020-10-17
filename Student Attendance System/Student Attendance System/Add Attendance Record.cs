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
    public partial class Add_Attendance_Record : Form
    {
        public Add_Attendance_Record()
        {
            InitializeComponent();
        }

        SqlCommand command;
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataSet dataset;

        DateTime currentDate = DateTime.Now;
        DateTime currentTime = DateTime.Now;

        public string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\marco\Desktop\Test\Test\Database1.mdf; Integrated Security = True";
        public string studentID;
        public string lecturerID;
        public string moduleID;
        public string date;
        public string time;

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            studentID = txtStudentID.Text;
            lecturerID = txtLecturerID.Text;
            moduleID = txtModuleID.Text;
            date = currentDate.ToString();
            time = currentDate.ToString();

            if (studentID == "" || lecturerID == "" || moduleID == "" || date == "" || time == "")
            {
                lblErrorMessage.ForeColor = System.Drawing.Color.Red;
                lblErrorMessage.Text = "Please fill in all the fields!";
            }
            else
            {
                try
                {
                    AddRecord();
                    DisplayTable();
                    ClearFields();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayTable();
        }

        public void DisplayTable()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();

            string selectAllQuery = "SELECT * FROM ATTENDANCE";

            command = new SqlCommand(selectAllQuery, connection);
            dataset = new DataSet();
            adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(dataset, "ATTENDANCE");
            dataGridView2.DataSource = dataset;
            dataGridView2.DataMember = "ATTENDANCE";

            connection.Close();
        }

        public void ClearFields()
        {
            txtStudentID.Text = "";
            txtLecturerID.Text = "";
            txtModuleID.Text = "";
        }

        public void AddRecord()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();

            string insertQuery = "INSERT INTO ATTENDANCE (Student_ID,Lecturer_ID,Module_ID,Attendance_Date,Attendance_Time) VALUES (@Student_ID,@Lecturer_ID,@Module_ID,@Attendance_Date,@Attendance_Time)";

            command = new SqlCommand(insertQuery, connection);
            command.Parameters.AddWithValue("@Student_ID", studentID);
            command.Parameters.AddWithValue("@Lecturer_ID", lecturerID);
            command.Parameters.AddWithValue("@Module_ID", moduleID);
            command.Parameters.AddWithValue("@Attendance_Date", date);
            command.Parameters.AddWithValue("@Attendance_Time", time);
            command.ExecuteNonQuery();

            connection.Close();

            lblErrorMessage.ForeColor = System.Drawing.Color.Green;
            lblErrorMessage.Text = "You have successfully added a new attendance record!";
        }

        private void Add_Attendance_Record_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Text = "";
            lblDate.Text = currentDate.ToString("MM/dd/yyyy");
            lblTime.Text = currentTime.ToString("hh:mm tt");

            DisplayTable();
        }
    }
}
