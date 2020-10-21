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
    public partial class Lecturer_Menu_Help : Form
    {
        public Lecturer_Menu_Help()
        {
            InitializeComponent();
        }

        private void Lecturer_Menu_Help_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Lecturer_Menu menu = new Lecturer_Menu();
            menu.ShowDialog();
            this.Close();
        }
    }
}
