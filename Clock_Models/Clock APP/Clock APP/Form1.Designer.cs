
namespace Clock_APP
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
            this.lblTime = new System.Windows.Forms.Label();
            this.lblsec = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblday = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTime.Font = new System.Drawing.Font("Forte", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTime.Location = new System.Drawing.Point(82, 19);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(308, 134);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "22:22";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // lblsec
            // 
            this.lblsec.AutoSize = true;
            this.lblsec.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblsec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblsec.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblsec.Location = new System.Drawing.Point(418, 66);
            this.lblsec.Name = "lblsec";
            this.lblsec.Size = new System.Drawing.Size(64, 55);
            this.lblsec.TabIndex = 3;
            this.lblsec.Text = "10";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbldate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldate.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbldate.Location = new System.Drawing.Point(538, 19);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(217, 55);
            this.lbldate.TabIndex = 4;
            this.lbldate.Text = "12-12-2020";
            // 
            // lblday
            // 
            this.lblday.AutoSize = true;
            this.lblday.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblday.Font = new System.Drawing.Font("Impact", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblday.Location = new System.Drawing.Point(564, 81);
            this.lblday.Name = "lblday";
            this.lblday.Size = new System.Drawing.Size(190, 55);
            this.lblday.TabIndex = 5;
            this.lblday.Text = "Saturday ";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox1.Font = new System.Drawing.Font("Segoe Script", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(82, 277);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(584, 83);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Todo list ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(841, 485);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblday);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lblsec);
            this.Controls.Add(this.lblTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblsec;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblday;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox textBox1;
    }
}

