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
    public partial class Maintain_Modules : Form
    {
        public Maintain_Modules()
        {
            InitializeComponent();
        }

        private void btnAddModule_Click(object sender, EventArgs e)
        {

        }

        private void btnReturnToMenu_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
    }
}
