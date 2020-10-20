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
        Maintain_Helper maintainhelper = new Maintain_Helper();

        SqlConnection conn = null;
        SqlCommand comm;
        SqlDataAdapter adap;
        DataSet ds;
        SqlDataReader dreader;

        string spesificid;

        public Request_Reports()
        {
            InitializeComponent();
        }

        private void Request_Reports_Load(object sender, EventArgs e)
        {
            AllStudents();

            int year = DateTime.Now.Year;
            DateTime firstDay = new DateTime(year-1, 1, 1);

            calStart.MinDate = firstDay;
            calStart.MaxDate = DateTime.Now;

            calEnd.MinDate = firstDay;
            calEnd.MaxDate = DateTime.Now;
        }

        private void Connect()
        {
            if (conn == null)
                conn = new SqlConnection(maintainhelper.ConnectionString);
        }
        
        private void rbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            btnSelectStudent.Enabled = rbtnSpesific.Checked;

            if(rbtnAll.Checked)
                AllStudents();
        }

        private void cbxModules_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSelectDate.Enabled = true;
        }

        private void calStart_DateChanged(object sender, DateRangeEventArgs e)
        {
            calEnd.MinDate = calStart.SelectionStart;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            using (var frmstudent = new frmStudent_Select())
            {
                var result = frmstudent.ShowDialog();

                if(result == DialogResult.OK)
                {
                    string id = frmstudent.StudentID;

                    SpesificStudent(id);
                }
                else if(result == DialogResult.Cancel)
                {
                    MessageBox.Show("Student select was canceled");
                }
            }
        }

        private void btnSelectDate_Click(object sender, EventArgs e)
        {
            string module = cbxModules.SelectedItem.ToString();

            if (cbxModules.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a Module");
            }
            else
            {
                if (rbtnAll.Checked)
                    AStudentsSModules(module);
                else
                    SStudentsSModules(module);
            }
        }

        private void AllStudents()
        {
            string modulesql = "SELECT Module_ID FROM MODULES";

            Connect();
            cbxModules.Items.Clear();

            try
            {
                conn.Open();

                comm = new SqlCommand(modulesql, conn);

                dreader = comm.ExecuteReader();

                while (dreader.Read())
                {
                    cbxModules.Items.Add(dreader.GetString(0));
                }

                conn.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        private void SpesificStudent(string id)
        {
            string modulesql = "SELECT DISTINCT Module_ID FROM ATTENDANCE WHERE Student_ID = @id";
            spesificid = id;

            Connect();
            cbxModules.Items.Clear();

            try
            {
                conn.Open();

                comm = new SqlCommand(modulesql, conn);
                comm.Parameters.AddWithValue("@id", id);

                dreader = comm.ExecuteReader();

                while (dreader.Read())
                {
                    cbxModules.Items.Add(dreader.GetString(0));
                }

                conn.Close();
            }
            catch(SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        private void SStudentsSModules(string module)
        {
            DateTime start = calStart.SelectionStart;
            DateTime end = calEnd.SelectionStart;

            string datesql = "SELECT Attendance_Date, Module_ID FROM ATTENDANCE WHERE (Attendance_Date BETWEEN @datestart AND @dateend) AND (Module_ID = @module) AND (Student_ID = @id)";

            Connect();
            
            try
            {
                conn.Open();

                comm = new SqlCommand(datesql, conn);
                adap = new SqlDataAdapter();
                ds = new DataSet();

                comm.Parameters.AddWithValue("@datestart", start.ToString("d"));
                comm.Parameters.AddWithValue("@dateend", end.ToString("d"));
                comm.Parameters.AddWithValue("@module", module);
                comm.Parameters.AddWithValue("@id", spesificid);

                adap.SelectCommand = comm;
                adap.Fill(ds, "ATTENDANCE");

                dgvReport.DataSource = ds;
                dgvReport.DataMember = "ATTENDANCE";
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }

            dgvReport.Columns[0].Width = 150;
            dgvReport.Columns[1].Width = 150;


            conn.Close();
        }

        private void AStudentsSModules(string module)
        {
            DateTime start = calStart.SelectionStart;
            DateTime end = calEnd.SelectionStart;

            string datesql =  "SELECT DISTINCT ATTENDANCE.Student_ID, (COUNT(CASE WHEN ATTENDANCE.Module_ID =  @module THEN 1 END)) AS Classes " +
                              "FROM ATTENDANCE " +
                              "WHERE ATTENDANCE_Date BETWEEN @datestart AND @dateend " +
                              "GROUP BY ATTENDANCE.Student_ID " +
                              "HAVING COUNT(CASE WHEN ATTENDANCE.Module_ID =  @module THEN 1 END) > 0 " + 
                              "ORDER BY ATTENDANCE.Student_ID";

            Connect();

            try
            {
                conn.Open();

                comm = new SqlCommand(datesql, conn);
                adap = new SqlDataAdapter();
                ds = new DataSet();

                comm.Parameters.AddWithValue("@datestart", start.ToString("d"));
                comm.Parameters.AddWithValue("@dateend", end.ToString("d"));
                comm.Parameters.AddWithValue("@module", module);

                adap.SelectCommand = comm;
                adap.Fill(ds, "ATTENDANCE");

                dgvReport.DataSource = ds;
                dgvReport.DataMember = "ATTENDANCE";
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }

            dgvReport.Columns[0].Width = 150;
            dgvReport.Columns[1].Width = 150;

            conn.Close();
        }
    }
}
