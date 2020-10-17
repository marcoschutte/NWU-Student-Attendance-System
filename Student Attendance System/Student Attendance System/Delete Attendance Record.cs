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
    public partial class Delete_Attendance_Record : Form
    {
        public Delete_Attendance_Record()
        {
            InitializeComponent();
        }

        SqlCommand command;
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataSet dataset;

        public string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\marco\Desktop\Test\Test\Database1.mdf; Integrated Security = True";
        public string attendanceID;

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
            dataGridView1.DataSource = dataset;
            dataGridView1.DataMember = "ATTENDANCE";

            connection.Close();
        }

        public void ClearFields()
        {
            txtAttendanceID.Text = "";
        }

        public int CheckIfRecordExists()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();

            string existQuery = "SELECT count([Attendance_ID]) FROM ATTENDANCE WHERE ([Attendance_ID] = '" + attendanceID + "')";

            SqlCommand checkRecord = new SqlCommand(existQuery, connection);

            int recordExists = (int)checkRecord.ExecuteScalar();

            connection.Close();

            return recordExists;
        }

        public void DeleteRecord()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();

            string deleteQuery = "DELETE FROM ATTENDANCE WHERE Attendance_ID = '" + attendanceID + "'";

            command = new SqlCommand(deleteQuery, connection);
            command.ExecuteNonQuery();

            connection.Close();
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            attendanceID = txtAttendanceID.Text;

            if (attendanceID == "")
            {
                lblErrorMessage.ForeColor = System.Drawing.Color.Red;
                lblErrorMessage.Text = "Please enter a valid Attendance ID!";
            }
            else
            {
                try
                {
                    if (CheckIfRecordExists() == 1)
                    {
                        DeleteRecord();
                        DisplayTable();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("The attendance record you are trying to delete does not exist!\nPlease enter the Attendance ID of a valid record.");
                    }
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

        private void Delete_Attendance_Record_Load(object sender, EventArgs e)
        {
            DisplayTable();
            lblErrorMessage.Text = "";
        }
    }
}
