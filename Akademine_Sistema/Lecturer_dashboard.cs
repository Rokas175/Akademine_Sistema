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
    public partial class Lecturer_dashboard : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=academic_system");
        public Lecturer_dashboard(string username)
        {
            InitializeComponent();

            label_login.Text = username;
        }

        private void Lecturer_dashboard_Load(object sender, EventArgs e)
        {
            
            try
            {
                con.Open();

                MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM lecturer WHERE lecturer_name='" + label_login.Text + "'", con);

                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                if (mySqlDataReader.Read() == true)
                {

                    this.label_login.Text = mySqlDataReader.GetString("lecturer_login");
                    this.label_password.Text = mySqlDataReader.GetString("lecturer_pass");
                    this.label_name.Text = mySqlDataReader.GetString("lecturer_name");
                    this.label_surname.Text = mySqlDataReader.GetString("lecturer_last_name");

                    this.label_user_id.Text = mySqlDataReader.GetString("id");
                    this.label_subject_id.Text = mySqlDataReader.GetString("subject_id");
                    this.label_subject_name.Text = mySqlDataReader.GetString("subject_name");
                    this.hello_name.Text = mySqlDataReader.GetString("lecturer_name");
                    //this.label_group_id.Text = mySqlDataReader.GetString("group_id");
                    load_gridview();

                }
                con.Close();
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
                string commandString = "SELECT * FROM student_grades WHERE subject_id='" + label_subject_id.Text + "'";
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

        private void btn_add_grade_Click(object sender, EventArgs e)
        {
            try
            {
     
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=academic_system");
                con.Open();

                int grade = Convert.ToInt32(this.txtBox_grade.Text);
                int student_grade_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                MySqlCommand mySqlCommand = new MySqlCommand("UPDATE student_grades SET grade= " + grade + " WHERE id=" + student_grade_id + "", con);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                while (mySqlDataReader.Read()) { }

                mySqlDataReader.Close();

                load_gridview();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }








            //Student_Grades add_grade = new Student_Grades();

            //int student_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            //int grade = Convert.ToInt32(txtBox_grade.Text.ToString());

            ////textBox_selected_student_id.Text = dataGridView1.CurrentRow.Cells[0].Value;

            //if (verify())
            //{

            //    if (add_grade.insert_grade_student(grade, student_id))
            //    {
            //        MessageBox.Show("Student has been added", "Student add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Error");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Input fields empty", "Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}



            //bool verify()
            //{
            //    if ((txtBox_grade.Text.Trim() == ""))
            //    {
            //        return false;
            //    }
            //    else
            //    {
            //        return true;
            //    }
            //}

        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
