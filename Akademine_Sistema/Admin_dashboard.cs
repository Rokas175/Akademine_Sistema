using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Akademine_Sistema
{
    public partial class Admin_dashboard : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=academic_system");
        public Admin_dashboard(string username)
        {
            InitializeComponent();

            label_username.Text = username;
        }

        private void Admin_dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
          
                MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM admin WHERE name='" + label_username.Text + "'", con);

                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                if (mySqlDataReader.Read() == true)
                {
                    this.hello_name.Text = mySqlDataReader.GetString("name");
                 
                    this.label_password.Text = mySqlDataReader.GetString("password");
                    this.label_name.Text = mySqlDataReader.GetString("name");
                    this.label_user_id.Text = mySqlDataReader.GetString("id");


                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            new Create_New().Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            new Deletions().Show();
        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
