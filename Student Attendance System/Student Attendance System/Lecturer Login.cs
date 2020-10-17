//Donovan Heunis 30270707 11/10/2020 03:51
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
    public partial class Lecturer_Login : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\AttendanceDB.mdf;Integrated Security = True");
        
        SqlCommand comm;
        SqlDataReader datRead;

        bool _redButtonClicked = true;

        public Lecturer_Login()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
            _redButtonClicked = true;
        }

        private void EmptyDataBase()
        {

            comm = new SqlCommand("SELECT Lecturer_ID FROM LECTURERS", conn);

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
                datRead.Close();
            }
            catch
            {

            }
            
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
            txtLecturerID.Text = "";
            txtPassword.Text = "";
        }

        private void btnLecturerLogIn_Click(object sender, EventArgs e)
        {
            string _id = txtLecturerID.Text;
            string _pass = txtPassword.Text;

            using (conn)
            {
                conn.Open();
                EmptyDataBase();

                comm = new SqlCommand("SELECT Lecturer_ID,Password FROM LECTURERS", conn);
                try
                {
                    datRead = comm.ExecuteReader();

                    while (datRead.Read())
                    {
                        if ((datRead.GetValue(0).ToString() == _id) && (datRead.GetValue(1).ToString() == _pass))
                        {
                            Lecturer_Menu lecturerMenu = new Lecturer_Menu();
                            lecturerMenu.Show();
                            _redButtonClicked = false;
                            this.Close();
                            break;
                        }
                        else
                        {
                            label5.Text = "Red textboxes indicate incorrect fields!";
                            label5.ForeColor = Color.Red;

                            if (datRead.GetValue(0).ToString() != _id)
                                txtLecturerID.BackColor = Color.Red;
                            else
                                txtLecturerID.BackColor = Color.White;
                            if (datRead.GetValue(1).ToString() != _pass)
                                txtPassword.BackColor = Color.Red;
                            else
                                txtPassword.BackColor = Color.White;
                        }
                    }
                }
                catch (Exception er2)
                {
                    MessageBox.Show(er2.ToString());
                }
            }
            
        }

        private void Lecturer_Login_FormClosing(object sender, FormClosingEventArgs e)
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
