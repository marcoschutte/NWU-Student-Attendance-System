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
    public partial class Update_Attendance_Record : Form
    {
        public Update_Attendance_Record()
        {
            InitializeComponent();
        }

        SqlCommand command;
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataSet dataset;

        DateTime currentDate = DateTime.Now;
        DateTime currentTime = DateTime.Now;

        public string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SAS_DB.mdf;Integrated Security = True";
        public string attendanceID;
        public string studentID;
        public string lecturerID;
        public string moduleID;
        public string date;
        public string time;

        public void DisplayRecord()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();

            string selectQuery = "SELECT * FROM ATTENDANCE WHERE Attendance_ID = '" + attendanceID + "'";

            command = new SqlCommand(selectQuery, connection);
            dataset = new DataSet();
            adapter = new SqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(dataset, "ATTENDANCE");
            dataGridView3.DataSource = dataset;
            dataGridView3.DataMember = "ATTENDANCE";

            connection.Close();
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
            dataGridView3.DataSource = dataset;
            dataGridView3.DataMember = "ATTENDANCE";

            connection.Close();
        }

        public void ClearFields()
        {
            txtAttendanceID.Text = "";
            txtStudentID.Text = "";
            txtLecturerID.Text = "";
            txtModuleID.Text = "";
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

        public void UpdateRecord()
        {
            studentID = txtStudentID.Text;
            lecturerID = txtLecturerID.Text;
            moduleID = txtModuleID.Text;
            date = currentDate.ToString();
            time = currentDate.ToString();

            connection = new SqlConnection(connectionString);
            connection.Open();

            string updateQuery = "UPDATE ATTENDANCE SET Student_ID = '" + studentID + "', Lecturer_ID = '" + lecturerID + "', Module_ID = '" + moduleID + "', Attendance_Date = '" + date + "', Attendance_Time = '" + time + "' WHERE Attendance_ID = '" + attendanceID + "'";

            command = new SqlCommand(updateQuery, connection);
            command.ExecuteNonQuery();

            connection.Close();

            lblErrorMessage.ForeColor = System.Drawing.Color.Green;
            lblErrorMessage.Text = "Record successfully updated!";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            attendanceID = txtAttendanceID.Text;

            if (attendanceID == "")
            {
                lblErrorMessage.ForeColor = System.Drawing.Color.Red;
                lblErrorMessage.Text = "Please enter a valid Attendance ID!";
                ClearFields();
            }
            else
            {
                try
                {
                    if (CheckIfRecordExists() == 1)
                    {
                        DisplayRecord();

                        lblAttendanceID.Text = txtAttendanceID.Text;

                        lblErrorMessage.Text = "";
                        lblMessage.Visible = true;
                        lbl1.Visible = true;
                        lbl2.Visible = true;
                        lbl3.Visible = true;
                        lbl4.Visible = true;
                        lbl5.Visible = true;
                        lbl6.Visible = true;
                        lblAttendanceID.Visible = true;
                        lblDate.Visible = true;
                        lblTime.Visible = true;
                        txtStudentID.Visible = true;
                        txtLecturerID.Visible = true;
                        txtModuleID.Visible = true;
                        btnUpdateRecord.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("The attendance record you are trying to update does not exist!\nPlease enter the Attendance ID of a valid record.");
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

        private void btnUpdateRecord_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateRecord();
                DisplayRecord();
                ClearFields();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void Update_Attendance_Record_Load(object sender, EventArgs e)
        {
            DisplayTable();

            lblErrorMessage.Text = "";
            lblMessage.Visible = false;
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            lbl5.Visible = false;
            lbl6.Visible = false;
            lblAttendanceID.Visible = false;
            lblDate.Visible = false;
            lblTime.Visible = false;
            txtStudentID.Visible = false;
            txtLecturerID.Visible = false;
            txtModuleID.Visible = false;
            btnUpdateRecord.Visible = false;

            lblDate.Text = currentDate.ToString("MM/dd/yyyy");
            lblTime.Text = currentTime.ToString("hh:mm tt");
        }

        private void btnReturnToAttendanceMenu_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
    }
}
