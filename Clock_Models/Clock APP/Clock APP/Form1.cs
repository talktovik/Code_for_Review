using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock_APP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm");
            lblsec.Text = DateTime.Now.ToString("ss");
            lbldate.Text = DateTime.Now.ToString("MMM dd yyyy");
            lblday.Text = DateTime.Now.ToString("dddd");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }
    }
}
