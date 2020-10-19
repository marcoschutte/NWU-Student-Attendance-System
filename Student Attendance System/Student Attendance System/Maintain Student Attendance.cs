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
    public partial class Maintain_Student_Attendance : Form
    {
        public Maintain_Student_Attendance()
        {
            InitializeComponent();
        }

        private void btnAddAttendance_Click(object sender, EventArgs e)
        {
            
            Add_Attendance_Record addAttendance = new Add_Attendance_Record();
            addAttendance.Show(this);
            this.Hide();
        }

        private void btnDeleteAttendance_Click(object sender, EventArgs e)
        {
            Delete_Attendance_Record deleteAttendance = new Delete_Attendance_Record();
            deleteAttendance.Show(this);
            this.Hide();
        }

        private void btnUpdateAttendance_Click(object sender, EventArgs e)
        {
            Update_Attendance_Record updateAttendance = new Update_Attendance_Record();
            updateAttendance.Show(this);
            this.Hide();
        }

        private void btnReturnToMainMenu_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
    }
}
