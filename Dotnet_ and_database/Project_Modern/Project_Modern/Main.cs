using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Modern
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Timetable var = new Timetable();
            var.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu var = new Menu();
            var.Show();
        }
    }
}
