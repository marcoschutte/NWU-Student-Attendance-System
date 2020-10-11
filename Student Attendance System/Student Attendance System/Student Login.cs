//Donovan Heunis 30270707 11/10/2020 02:56
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_Attendance_System
{
    public partial class Student_Login : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SAS.mdf;Integrated Security=True");
        SqlCommand comm;
        SqlDataReader datRead;

        bool _redButtonClicked = true;

        public Student_Login()
        {
            InitializeComponent();
        }

        private void EmptyDataBase()
        {

            comm = new SqlCommand("SELECT Student_ID FROM STUDENTS", conn);

            try
            {
                int _i = 0;
                datRead = comm.ExecuteReader();

                while (datRead.Read())
                {
                    _i++;
                }
                if (_i == 0)
                    MessageBox.Show("Database empty");
            }
            catch
            {

            }
            datRead.Close();
        }

        private void btnReturnToMenu_Click(object sender, EventArgs e)
        {
            _redButtonClicked = false;
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtStudentID.Text = "";
            txtPassword.Text = "";
        }

        private void btnStudentLogIn_Click(object sender, EventArgs e)
        {
            //if login credentials are valid & exist within STUDENT table --> open student attendance form

            string name = txtFirstName.Text;
            string surname = txtLastName.Text;
            string id = txtStudentID.Text;
            string pass = txtPassword.Text;

            using (conn)
            {
                conn.Open();
                comm = new SqlCommand("SELECT * FROM STUDENTS WHERE Name,Last_Name,Student_ID,Password ='" + name + "','" + surname + "','" + id + "','" + pass + "'", conn);

                EmptyDataBase();
                try
                {
                    datRead = comm.ExecuteReader();

                    while (datRead.Read())
                    {
                        if ((datRead.GetValue(0).ToString() == name) && (datRead.GetValue(1).ToString() == surname) && (datRead.GetValue(2).ToString() == id) && (datRead.GetValue(3).ToString() == pass))
                        {
                            Student_Attendance studentAttendance = new Student_Attendance();
                            studentAttendance.Show();
                            break;
                        }
                        else
                        {
                            label5.Text = "Red textboxes indicate incorrect fields!";
                            label5.ForeColor = Color.Red;
                            if (datRead.GetValue(0).ToString() != txtFirstName.Text)
                            {
                                txtFirstName.BackColor = Color.Red;
                            }
                            if (datRead.GetValue(1).ToString() != txtLastName.Text)
                            {
                                txtLastName.BackColor = Color.Red;
                            }
                            if (datRead.GetValue(2).ToString() != txtStudentID.Text)
                            {
                                txtStudentID.BackColor = Color.Red;
                            }
                            if (datRead.GetValue(3).ToString() != txtPassword.Text)
                            {
                                txtPassword.BackColor = Color.Red;
                            }
                        }
                    }
                }
                catch (Exception er2)
                {
                    MessageBox.Show(er2.ToString());
                }
            }
        }

        private void Student_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_redButtonClicked == true)
            {
                DialogResult _closingForm = MessageBox.Show("Are you sure you want to close the Program", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (DialogResult.Yes == _closingForm)
                    Environment.Exit(0);
            }
        }
    }
}