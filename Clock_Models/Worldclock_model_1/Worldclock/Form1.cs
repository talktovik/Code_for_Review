using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Worldclock
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            var inTimeZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            DateTime inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, inTimeZone);
            Indian.Text = Convert.ToString(inTime);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            timer5.Start();
            timer6.Start();
            timer7.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var euTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");
            DateTime euTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, euTimeZone);
            France.Text = Convert.ToString(euTime);
           
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            var BrTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central Brazilian Standard Time");
            DateTime BrTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, BrTimeZone);
            brazil.Text = Convert.ToString(BrTime);
         
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            var CaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Canada Central Standard Time");
            DateTime CaTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, CaTimeZone);
            canada.Text = Convert.ToString(CaTime);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            var BnTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Bangladesh Standard Time");
            DateTime BaTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, BnTimeZone);
            bang.Text = Convert.ToString(BaTime);
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            var ChTimeZone = TimeZoneInfo.FindSystemTimeZoneById("China Standard Time");
            DateTime ChTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, ChTimeZone);
            China.Text = Convert.ToString(ChTime);
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            var ArTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Arabian Standard Time");
            DateTime ArTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, ArTimeZone);
            UAE.Text = Convert.ToString(ArTime);
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            var siTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Singapore Standard Time");
            DateTime siTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, siTimeZone);
            sing.Text = Convert.ToString(siTime);
        }
    }
}
