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
    }
}
