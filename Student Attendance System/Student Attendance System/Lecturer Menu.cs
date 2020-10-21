using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_System
{
    public partial class Lecturer_Menu : Form
    {
        Maintain_Helper maintainhelper = new Maintain_Helper();
        string currentID;

        public Lecturer_Menu()
        {
            InitializeComponent();
        }

        public Lecturer_Menu(string id)
        {
            InitializeComponent();
            currentID = id;
        }

        private void btnExitApplication_Click(object sender, EventArgs e)
        {
            DialogResult close = MessageBox.Show("Are you sure you want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (DialogResult.Yes == close)
                Application.Exit();
        }

        private void btnMaintainStudents_Click(object sender, EventArgs e)
        {            
            Maintain_Students maintainStudents = new Maintain_Students();
            maintainStudents.Show(this);
            //Keep lecturer menu open for later use rather than closing it?
            this.Hide();
        }

        private void btnMaintainLecturers_Click(object sender, EventArgs e)
        {
            if (maintainhelper.CheckPrivilege(currentID))
            {
                Maintain_Lecturers maintainLecturers = new Maintain_Lecturers();
                maintainLecturers.Show(this);
                this.Hide();
            }
            else
                MessageBox.Show("Only admins may maintain admins");
        }

        private void btnMaintainModules_Click(object sender, EventArgs e)
        {
            Maintain_Modules maintainModules = new Maintain_Modules();
            maintainModules.Show(this);
            this.Hide();
        }

        private void btnMaintainStudentAttendance_Click(object sender, EventArgs e)
        {
            Maintain_Student_Attendance maintainAttendance = new Maintain_Student_Attendance();
            maintainAttendance.Show(this);
            this.Hide();
        }

        private void btnRequestReports_Click(object sender, EventArgs e)
        {
            Request_Reports requestreports = new Request_Reports();
            requestreports.Show(this);
            this.Hide();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lecturer_Menu_Help _help = new Lecturer_Menu_Help();
            _help.Show(this);
            this.Hide();

        }
    }
}
