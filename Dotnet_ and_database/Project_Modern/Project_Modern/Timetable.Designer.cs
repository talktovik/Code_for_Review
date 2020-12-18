
namespace Project_Modern
{
    partial class Timetable
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dname = new System.Windows.Forms.Label();
            this.dtime = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_Modern.Properties.Resources.k8_sWEpcc0Rm0U_unsplash;
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1168, 740);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(373, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time table for the mess ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(248, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(681, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please Put your ID and get the details ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(364, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID ::";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(353, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Details :";
            // 
            // dname
            // 
            this.dname.AutoSize = true;
            this.dname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dname.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dname.ForeColor = System.Drawing.Color.Red;
            this.dname.Location = new System.Drawing.Point(519, 397);
            this.dname.Name = "dname";
            this.dname.Size = new System.Drawing.Size(112, 30);
            this.dname.TabIndex = 5;
            this.dname.Text = "Detail 1";
            // 
            // dtime
            // 
            this.dtime.AutoSize = true;
            this.dtime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtime.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtime.ForeColor = System.Drawing.Color.Red;
            this.dtime.Location = new System.Drawing.Point(519, 466);
            this.dtime.Name = "dtime";
            this.dtime.Size = new System.Drawing.Size(123, 30);
            this.dtime.TabIndex = 6;
            this.dtime.Text = "Details 2";
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.SystemColors.Info;
            this.id.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(503, 311);
            this.id.Name = "id";
            this.id.PasswordChar = '#';
            this.id.Size = new System.Drawing.Size(242, 43);
            this.id.TabIndex = 10;
            this.id.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.Info;
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(503, 523);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(198, 82);
            this.btn1.TabIndex = 11;
            this.btn1.Text = "Search";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Timetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1210, 741);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.dtime);
            this.Controls.Add(this.dname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Timetable";
            this.Text = "Timetable";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dname;
        private System.Windows.Forms.Label dtime;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button btn1;
    }
}