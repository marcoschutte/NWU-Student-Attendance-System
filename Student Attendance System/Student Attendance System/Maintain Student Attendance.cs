﻿using System;
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
            Add_Attendance addAttendance = new Add_Attendance();
        }
    }
}
