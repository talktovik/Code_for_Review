using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoldMapModified
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var inTimeZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            DateTime inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, inTimeZone);
            Indian.Text = Convert.ToString(inTime.Hour + ":" + inTime.Minute + ":"+ inTime.Second);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
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
            timer11.Start();
            timer12.Start();
            timer13.Start();
            timer14.Start();
            timer15.Start();
            timer16.Start();
            timer17.Start();
            timer18.Start();
            timer19.Start();
            timer20.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            var ChTimeZone = TimeZoneInfo.FindSystemTimeZoneById("China Standard Time");
            DateTime ChTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, ChTimeZone);
            china.Text = Convert.ToString(ChTime.Hour + ":" + ChTime.Minute + ":" + ChTime.Second);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            var BnTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Bangladesh Standard Time");
            DateTime inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, BnTimeZone);
            Ban.Text = Convert.ToString(inTime.Hour + ":" + inTime.Minute + ":" + inTime.Second);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            var CaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Canada Central Standard Time");
            DateTime inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, CaTimeZone);
            Canada.Text = Convert.ToString(inTime.Hour + ":" + inTime.Minute + ":" + inTime.Second);
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            
            var CaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
            DateTime inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, CaTimeZone);
            Usa.Text = Convert.ToString(inTime.Hour + ":" + inTime.Minute + ":" + inTime.Second);

        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            var CaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Argentina Standard Time");
            DateTime inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, CaTimeZone);
            Arg.Text = Convert.ToString(inTime.Hour + ":" + inTime.Minute + ":" + inTime.Second);
            
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            var CaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central Brazilian Standard Time");
            DateTime inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, CaTimeZone);
            Bra.Text = Convert.ToString(inTime.Hour + ":" + inTime.Minute + ":" + inTime.Second);

        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            var CaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Singapore Standard Time");
            DateTime inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, CaTimeZone);
            sing.Text = Convert.ToString(inTime.Hour + ":" + inTime.Minute + ":" + inTime.Second);

        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            var CaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Cen. Australia Standard Time");
            DateTime inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, CaTimeZone);
            Aus.Text = Convert.ToString(inTime.Hour + ":" + inTime.Minute + ":" + inTime.Second);
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            
            var CaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("New Zealand Standard Time");
            DateTime inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, CaTimeZone);
            New.Text = Convert.ToString(inTime.Hour + ":" + inTime.Minute + ":" + inTime.Second);
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            var CaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Sri Lanka Standard Time");
            DateTime inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, CaTimeZone);
            Sri.Text = Convert.ToString(inTime.Hour + ":" + inTime.Minute + ":" + inTime.Second);
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            var CaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time");
            DateTime inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, CaTimeZone);
            Jap.Text = Convert.ToString(inTime.Hour + ":" + inTime.Minute + ":" + inTime.Second);

        }

        private void timer13_Tick(object sender, EventArgs e)
        {
            var CaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Greenland Standard Time");
            DateTime inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, CaTimeZone);
            Green.Text = Convert.ToString(inTime.Hour + ":" + inTime.Minute + ":" + inTime.Second);

        }

        private void timer14_Tick(object sender, EventArgs e)
        {
            
            var CaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Russian Standard Time");
            DateTime inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, CaTimeZone);
            Rus1.Text = Convert.ToString(inTime.Hour + ":" + inTime.Minute + ":" + inTime.Second);
        }

        private void timer15_Tick(object sender, EventArgs e)
        {
            var CaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");
            DateTime inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, CaTimeZone);
            Fra.Text = Convert.ToString(inTime.Hour + ":" + inTime.Minute + ":" + inTime.Second);
        }

        private void timer16_Tick(object sender, EventArgs e)
        {
            var CaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Arabian Standard Time");
            DateTime inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, CaTimeZone);
            Uae.Text = Convert.ToString(inTime.Hour + ":" + inTime.Minute + ":" + inTime.Second);
        }

        private void timer17_Tick(object sender, EventArgs e)
        {
            var CaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("South Africa Standard Time");
            DateTime inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, CaTimeZone);
            Saf.Text = Convert.ToString(inTime.Hour + ":" + inTime.Minute + ":" + inTime.Second);
        }

        private void timer18_Tick(object sender, EventArgs e)
        {
            var CaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("E. Africa Standard Time");
            DateTime inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, CaTimeZone);
            Eastaf.Text = Convert.ToString(inTime.Hour + ":" + inTime.Minute + ":" + inTime.Second);

        }

        private void timer19_Tick(object sender, EventArgs e)
        {
            var CaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("UTC+12");
            DateTime inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, CaTimeZone);
            Eastrus.Text = Convert.ToString(inTime.Hour + ":" + inTime.Minute + ":" + inTime.Second);
        }

        private void timer20_Tick(object sender, EventArgs e)
        {
            var CaTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Alaskan Standard Time");
            DateTime inTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, CaTimeZone);
            alsaka.Text = Convert.ToString(inTime.Hour + ":" + inTime.Minute + ":" + inTime.Second);

        }
    }
}
