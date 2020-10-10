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
        public Lecturer_Menu()
        {
            InitializeComponent();
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
            maintainStudents.Show();
            this.Close();
        }

        private void btnMaintainLecturers_Click(object sender, EventArgs e)
        {
            Maintain_Lecturers maintainLecturers = new Maintain_Lecturers();
            maintainLecturers.Show();
            this.Close();
        }

        private void btnMaintainModules_Click(object sender, EventArgs e)
        {
            Maintain_Modules maintainModules = new Maintain_Modules();
            maintainModules.Show();
            this.Hide();
        }
    }
}
