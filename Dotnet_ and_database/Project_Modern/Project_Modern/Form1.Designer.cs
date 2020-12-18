
namespace Project_Modern
{
    partial class Login
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
            this.usernamex = new System.Windows.Forms.Label();
            this.passwordx = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_Modern.Properties.Resources.Wallpaper;
            this.pictureBox1.Location = new System.Drawing.Point(191, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1161, 662);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "META &DATA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Version 0.1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(652, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "LOGIN HURDLE";
            // 
            // usernamex
            // 
            this.usernamex.AutoSize = true;
            this.usernamex.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.usernamex.Font = new System.Drawing.Font("Juice ITC", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamex.ForeColor = System.Drawing.Color.Lime;
            this.usernamex.Location = new System.Drawing.Point(475, 446);
            this.usernamex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernamex.Name = "usernamex";
            this.usernamex.Size = new System.Drawing.Size(150, 39);
            this.usernamex.TabIndex = 4;
            this.usernamex.Text = "USERNAME   :";
            // 
            // passwordx
            // 
            this.passwordx.AutoSize = true;
            this.passwordx.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passwordx.Font = new System.Drawing.Font("Juice ITC", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordx.ForeColor = System.Drawing.Color.Lime;
            this.passwordx.Location = new System.Drawing.Point(459, 517);
            this.passwordx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordx.Name = "passwordx";
            this.passwordx.Size = new System.Drawing.Size(153, 39);
            this.passwordx.TabIndex = 5;
            this.passwordx.Text = "  USER KEY   :";
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.Red;
            this.loginbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginbtn.CausesValidation = false;
            this.loginbtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.loginbtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.loginbtn.Location = new System.Drawing.Point(705, 578);
            this.loginbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(144, 55);
            this.loginbtn.TabIndex = 8;
            this.loginbtn.Text = "Access";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.SystemColors.Info;
            this.username.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(686, 443);
            this.username.Name = "username";
            this.username.PasswordChar = '#';
            this.username.Size = new System.Drawing.Size(242, 43);
            this.username.TabIndex = 9;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.Info;
            this.password.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.password.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(686, 513);
            this.password.Name = "password";
            this.password.PasswordChar = '#';
            this.password.Size = new System.Drawing.Size(242, 43);
            this.password.TabIndex = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 692);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.passwordx);
            this.Controls.Add(this.usernamex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome User";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label usernamex;
        private System.Windows.Forms.Label passwordx;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
    }
}

