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
    public partial class Student_dashboard : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=academic_system");
        public Student_dashboard(string username)
        {
            InitializeComponent();

            label_login.Text = username;
        }

        private void Student_dashboard_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM student WHERE student_name='" + label_login.Text + "'", con);

                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                if (mySqlDataReader.Read() == true)
                {

                    this.label_login.Text = mySqlDataReader.GetString("student_login");
                    this.label_password.Text = mySqlDataReader.GetString("student_pass");
                    this.label_name.Text = mySqlDataReader.GetString("student_name");
                    this.label_surname.Text = mySqlDataReader.GetString("student_last_name");
                    this.label_user_id.Text = mySqlDataReader.GetString("id");
                    this.hello_name.Text = mySqlDataReader.GetString("student_name");
                    this.label_group_id.Text = mySqlDataReader.GetString("group_id");
                    this.label_group_name.Text = mySqlDataReader.GetString("group_name");

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }

            // load gridview

            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=academic_system");
                string commandString = "SELECT * FROM student_grades WHERE student_id='" + label_user_id.Text + "'";
                MySqlCommand mySqlCommand = new MySqlCommand(commandString, con);

                MySqlCommandBuilder sqlCommandBuilder = new MySqlCommandBuilder();
                MySqlDataAdapter MySqldataAdapter = new MySqlDataAdapter();

                sqlCommandBuilder.DataAdapter = MySqldataAdapter;
                MySqldataAdapter.SelectCommand = mySqlCommand;

                DataSet dataSet = new DataSet();
                MySqldataAdapter.Fill(dataSet, "student_grades");

                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = "student_grades";

                dataGridView1.ReadOnly = true;
                this.dataGridView1.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex);
            }



        }


        public void load_gridview()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=academic_system");
                string commandString = "SELECT * FROM student_grades WHERE subject_id='" + label_user_id.Text + "'";
                MySqlCommand mySqlCommand = new MySqlCommand(commandString, con);

                MySqlCommandBuilder sqlCommandBuilder = new MySqlCommandBuilder();
                MySqlDataAdapter MySqldataAdapter = new MySqlDataAdapter();

                sqlCommandBuilder.DataAdapter = MySqldataAdapter;
                MySqldataAdapter.SelectCommand = mySqlCommand;

                DataSet dataSet = new DataSet();
                MySqldataAdapter.Fill(dataSet, "student_grades");

                dataGridView1.DataSource = dataSet;
                dataGridView1.DataMember = "student_grades";

                dataGridView1.ReadOnly = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex);
            }
        }


        private void btn_log_out_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
