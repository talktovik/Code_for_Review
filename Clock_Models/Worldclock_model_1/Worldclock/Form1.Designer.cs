
namespace Worldclock
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Indian = new MetroFramework.Controls.MetroLabel();
            this.France = new MetroFramework.Controls.MetroLabel();
            this.brazil = new MetroFramework.Controls.MetroLabel();
            this.canada = new MetroFramework.Controls.MetroLabel();
            this.bang = new MetroFramework.Controls.MetroLabel();
            this.China = new MetroFramework.Controls.MetroLabel();
            this.UAE = new MetroFramework.Controls.MetroLabel();
            this.sing = new MetroFramework.Controls.MetroLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.timer8 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Indian
            // 
            this.Indian.AutoSize = true;
            this.Indian.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Indian.Location = new System.Drawing.Point(188, 286);
            this.Indian.Name = "Indian";
            this.Indian.Size = new System.Drawing.Size(80, 25);
            this.Indian.Style = MetroFramework.MetroColorStyle.Brown;
            this.Indian.TabIndex = 0;
            this.Indian.Text = "00:00:00";
            this.Indian.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // France
            // 
            this.France.AutoSize = true;
            this.France.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.France.Location = new System.Drawing.Point(188, 352);
            this.France.Name = "France";
            this.France.Size = new System.Drawing.Size(80, 25);
            this.France.Style = MetroFramework.MetroColorStyle.Brown;
            this.France.TabIndex = 1;
            this.France.Text = "00:00:00";
            // 
            // brazil
            // 
            this.brazil.AutoSize = true;
            this.brazil.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.brazil.Location = new System.Drawing.Point(188, 417);
            this.brazil.Name = "brazil";
            this.brazil.Size = new System.Drawing.Size(80, 25);
            this.brazil.Style = MetroFramework.MetroColorStyle.Brown;
            this.brazil.TabIndex = 2;
            this.brazil.Text = "00:00:00";
            // 
            // canada
            // 
            this.canada.AutoSize = true;
            this.canada.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.canada.Location = new System.Drawing.Point(188, 479);
            this.canada.Name = "canada";
            this.canada.Size = new System.Drawing.Size(80, 25);
            this.canada.Style = MetroFramework.MetroColorStyle.Brown;
            this.canada.TabIndex = 3;
            this.canada.Text = "00:00:00";
            // 
            // bang
            // 
            this.bang.AutoSize = true;
            this.bang.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.bang.Location = new System.Drawing.Point(816, 286);
            this.bang.Name = "bang";
            this.bang.Size = new System.Drawing.Size(80, 25);
            this.bang.Style = MetroFramework.MetroColorStyle.Brown;
            this.bang.TabIndex = 4;
            this.bang.Text = "00:00:00";
            // 
            // China
            // 
            this.China.AutoSize = true;
            this.China.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.China.Location = new System.Drawing.Point(816, 351);
            this.China.Name = "China";
            this.China.Size = new System.Drawing.Size(80, 25);
            this.China.Style = MetroFramework.MetroColorStyle.Brown;
            this.China.TabIndex = 5;
            this.China.Text = "00:00:00";
            // 
            // UAE
            // 
            this.UAE.AutoSize = true;
            this.UAE.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.UAE.Location = new System.Drawing.Point(816, 417);
            this.UAE.Name = "UAE";
            this.UAE.Size = new System.Drawing.Size(80, 25);
            this.UAE.Style = MetroFramework.MetroColorStyle.Brown;
            this.UAE.TabIndex = 6;
            this.UAE.Text = "00:00:00";
            // 
            // sing
            // 
            this.sing.AutoSize = true;
            this.sing.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.sing.Location = new System.Drawing.Point(816, 479);
            this.sing.Name = "sing";
            this.sing.Size = new System.Drawing.Size(80, 25);
            this.sing.Style = MetroFramework.MetroColorStyle.Brown;
            this.sing.TabIndex = 7;
            this.sing.Text = "00:00:00";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "India";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Brazil";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 480);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Canada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(591, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Bangladesh";
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(591, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "China";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(591, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "UAE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(591, 480);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Singapore";
            // 
            // timer5
            // 
            this.timer5.Interval = 1000;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Interval = 1000;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // timer7
            // 
            this.timer7.Interval = 1000;
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(195, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Date ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(304, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "Time";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(943, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 24);
            this.label11.TabIndex = 19;
            this.label11.Text = "Time";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(827, 244);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 24);
            this.label12.TabIndex = 18;
            this.label12.Text = "Date ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "France";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(654, 23);
            this.label13.TabIndex = 21;
            this.label13.Text = "This Clock Shows Date and Time of diffrent countries, { training Module #3 }";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 587);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sing);
            this.Controls.Add(this.UAE);
            this.Controls.Add(this.China);
            this.Controls.Add(this.bang);
            this.Controls.Add(this.canada);
            this.Controls.Add(this.brazil);
            this.Controls.Add(this.France);
            this.Controls.Add(this.Indian);
            this.Name = "Form1";
            this.Text = "World Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Indian;
        private MetroFramework.Controls.MetroLabel France;
        private MetroFramework.Controls.MetroLabel brazil;
        private MetroFramework.Controls.MetroLabel canada;
        private MetroFramework.Controls.MetroLabel bang;
        private MetroFramework.Controls.MetroLabel China;
        private MetroFramework.Controls.MetroLabel UAE;
        private MetroFramework.Controls.MetroLabel sing;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer timer8;
    }
}

