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
    public partial class Student_Attendance : Form
    {
        public Student_Attendance()
        {
            InitializeComponent();
        }

        private void Student_Attendance_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString();
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }
    }
}
