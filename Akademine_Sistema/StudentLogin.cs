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
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=academic_system");

                string query = "SELECT * FROM student WHERE student_login='" + txtUsername.Text + "' AND student_pass='" + txtPassword.Text + "' ";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, con);

                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                if (dataTable.Rows.Count == 1)
                {
                    MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM student", con);
                    MySqlDataReader mySqlDataReader;

                    con.Open();
                    mySqlDataReader = mySqlCommand.ExecuteReader();

                    while (mySqlDataReader.Read())
                    {

                        //string username = mySqlDataReader.GetString("name");
                        //dataTable.Rows.Count == 1
                        // if (txtUsername.Text == "admin")
                        if (dataTable.Rows.Count == 1)
                        {
                            new Student_dashboard(txtUsername.Text).Show();
                            this.Hide();
                            break;
                        }

                    }
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
                else
                {
                    MessageBox.Show("Error: Username or password is incorrect.");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void StudentLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
