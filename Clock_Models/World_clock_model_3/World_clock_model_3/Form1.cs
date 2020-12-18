using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace World_clock_model_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            timer5.Start();
            timer6.Start();
            timer7.Start();
            timer8.Start();
            timer9.Start();
            timer10.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            var ChTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
            DateTime ChTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, ChTimeZone);
            USA.Text = Convert.ToString(ChTime.Hour + ":" + ChTime.Minute + ":" + ChTime.Second);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            var ChTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central Standard Time");
            DateTime ChTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, ChTimeZone);
            canada.Text = Convert.ToString(ChTime.Hour + ":" + ChTime.Minute + ":" + ChTime.Second);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            var CaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central Brazilian Standard Time");
            DateTime inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, CaTimeZone);
            bra.Text = Convert.ToString(inTime.Hour + ":" + inTime.Minute + ":" + inTime.Second);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            var CaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Cape Verde Standard Time");
            DateTime inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, CaTimeZone);
            cape.Text = Convert.ToString(inTime.Hour + ":" + inTime.Minute + ":" + inTime.Second);
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            var CaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");
            DateTime inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, CaTimeZone);
            nig.Text = Convert.ToString(inTime.Hour + ":" + inTime.Minute + ":" + inTime.Second);
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            var CaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Turkey Standard Time");
            DateTime inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, CaTimeZone);
            tur.Text = Convert.ToString(inTime.Hour + ":" + inTime.Minute + ":" + inTime.Second);
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            var CaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Pakistan Standard Time");
            DateTime inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, CaTimeZone);
            Pak.Text = Convert.ToString(inTime.Hour + ":" + inTime.Minute + ":" + inTime.Second);
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            var CaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Tomsk Standard Time");
            DateTime inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, CaTimeZone);
            thai.Text = Convert.ToString(inTime.Hour + ":" + inTime.Minute + ":" + inTime.Second);
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            
            var CaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("AUS Central Standard Time");
            DateTime inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, CaTimeZone);
            aus.Text = Convert.ToString(inTime.Hour + ":" + inTime.Minute + ":" + inTime.Second);

        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            
            var CaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("New Zealand Standard Time");
            DateTime inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, CaTimeZone);
            newz.Text = Convert.ToString(inTime.Hour + ":" + inTime.Minute + ":" + inTime.Second);
        }
    }
}
