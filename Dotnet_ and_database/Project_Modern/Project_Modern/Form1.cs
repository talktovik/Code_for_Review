using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_Modern
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.; Initial Catalog=Metadata; Integrated Security=True; ");
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Login  where username ='"+username.Text+"' and password = '"+password.Text+"' ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                Main ss = new Main();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Error in Login");
            }
        }
    }
    }

