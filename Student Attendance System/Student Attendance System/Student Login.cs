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
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AttendanceDB.mdf;Integrated Security=True");

        SqlCommand comm;
        SqlDataReader datRead;

        bool _redButtonClicked = true;

        public Student_Login()
        {
            InitializeComponent();
            _redButtonClicked = true;
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
            User us = new User();
            us.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtStudentID.Text = "";
            txtPassword.Text = "";
        }

        private void btnStudentLogIn_Click(object sender, EventArgs e)
        {
            //if login credentials are valid & exist within STUDENT table --> open student attendance form
            string _id = txtStudentID.Text;
            string _pass = txtPassword.Text;

            using (conn)
            {
                conn.Open();
                EmptyDataBase();

                comm = new SqlCommand("SELECT Student_ID,Password FROM STUDENTS", conn);
                try
                {
                    datRead = comm.ExecuteReader();

                    while (datRead.Read())
                    {
                        if ((datRead.GetValue(0).ToString() == _id) && (datRead.GetValue(1).ToString() == _pass))
                        {
                            Student_Attendance studentAttendance = new Student_Attendance();
                            studentAttendance.Show();
                            _redButtonClicked = false;
                            this.Close();
                            break;
                        }
                        else
                        {
                            label5.Text = "Red textboxes indicate incorrect fields!";
                            label5.ForeColor = Color.Red;

                            if (datRead.GetValue(0).ToString() != _id)
                            {
                                txtStudentID.BackColor = Color.Red;
                            }
                            if (datRead.GetValue(1).ToString() != _pass)
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
                else
                    e.Cancel = true;
            }
        }
    }
}