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
    public partial class Student_Attendance : Form
    {
        public Student_Attendance()
        {
            InitializeComponent();
        }

        // Global variables.
        public String studentNumber;
        public String module_Code;
        public String Lecturer;

        //declare and initialize the connection string
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bernh\Source\Repos\CMPG223-Project\Student Attendance System\Student Attendance System\Database1.mdf;Integrated Security=True";

        //using System.Data.SqlClient namespace
        public SqlConnection connection;
        public SqlCommand command;
        public SqlDataAdapter adapter;
        public DataSet dataset;

        private void Student_Attendance_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString();
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }

        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            DialogResult close = MessageBox.Show("Are you sure you want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DialogResult.Yes == close)
                Application.Exit();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            studentNumber = txtStudent_ID.Text;
            module_Code = txtModuleID.Text;
            Lecturer = lecturerComboBox.Text;

            try
            {
                //query statement
                string insertQuery = "INSERT INTO ATTENDANCE_Table VALUES(@Student_ID,@Lecturer_ID,@Module_ID,@Attendance_Date,@Attendance_Time)";

                connection = new SqlConnection(connectionString);

                //open the connection
                connection.Open();

                command = new SqlCommand(insertQuery, connection);

                //store user input in a table
                command.Parameters.AddWithValue("@Student_ID", studentNumber);
                command.Parameters.AddWithValue("@Lecturer_ID", Lecturer);
                command.Parameters.AddWithValue("@Module_ID", module_Code);
                command.Parameters.AddWithValue("@Attendance_Date", lblDate);
                command.Parameters.AddWithValue("@Attendance_Time", lblTime);
                

                command.ExecuteNonQuery();

                //close the connection
                connection.Close();

                //message to the user
                MessageBox.Show("Attendance have been recorded");

                //close the current form
                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
