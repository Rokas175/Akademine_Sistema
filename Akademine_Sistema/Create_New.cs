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
    public partial class Create_New : Form
    {
        public Create_New()
        {
            InitializeComponent();

            load_subjects();
            load_groups();
            load_subjects_to_add_to_groups();
            load_groups_to_add_subjects();
            load_students();
            load_subjects_to_add_students();

        }


        //Stdents -------------------------------------------------------------------------------------------
        private void btn_add_student_Click_1(object sender, EventArgs e)
        {
            DBConnect dataB = new DBConnect();
            Student Add_student = new Student();

            //int category = Convert.ToInt32(comboBox1_Category.Text.ToString());
            //int category_id = Convert.ToInt32(comboBox1_Category.Text.ToString());
            string name = txt_student_name.Text;
            string lastname = txt_student_lastname.Text;
            string login = name.ToLower();
            string password = lastname.ToLower();
            int group_id = Convert.ToInt32(textBox_group_id.Text.ToString());
            string group_name = comboBox_groups.Text;


            if (verify())
            {

                if (Add_student.student_Insert(name, lastname, login, password, group_id, group_name))
                {
                    MessageBox.Show("Student has been added", "Student add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Input fields empty", "Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



            bool verify()
            {
                if ((txt_student_name.Text.Trim() == "") || (txt_student_lastname.Text.Trim() == ""))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            load_students();

        }

        public void load_groups()
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=; database=academic_system");
                mySqlConnection.Open();

                MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM student_groups", mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                this.comboBox_groups.Items.Clear();
                while (mySqlDataReader.Read())
                {
                    this.comboBox_groups.Items.Add(mySqlDataReader.GetString("group_name"));


                    //mySqlCommand = new MySqlCommand("SELECT id FROM subject where subject_name=''", mySqlConnection);
                    //mySqlDataReader = mySqlCommand.ExecuteReader();

                }
                mySqlDataReader.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex);
            }
        }

        private void comboBox_groups_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=; database=academic_system");
                mySqlConnection.Open();

                string query = "select id from student_groups where group_name='" + comboBox_groups.Text + "'";
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                    //string user_Selected = reader["username"].ToString();
                    textBox_group_id.Text = mySqlDataReader.GetString("id");

                }

                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }



        //LECTURER THINGS ------------------------------------------------------------------------------------------------------
        public void load_subjects()
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=; database=academic_system");
                mySqlConnection.Open();
                MySqlCommand mySqlCommand;
                MySqlDataReader mySqlDataReader;

                mySqlCommand = new MySqlCommand("SELECT * FROM subject", mySqlConnection);
                mySqlDataReader = mySqlCommand.ExecuteReader();
                this.comboBox_subject_name.Items.Clear();
                while (mySqlDataReader.Read())
                {
                    this.comboBox_subject_name.Items.Add(mySqlDataReader.GetString("subject_name"));


                    //mySqlCommand = new MySqlCommand("SELECT id FROM subject where subject_name=''", mySqlConnection);
                    //mySqlDataReader = mySqlCommand.ExecuteReader();

                }
                mySqlDataReader.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex);
            }
        }

        private void comboBox_subject_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=; database=academic_system");
                mySqlConnection.Open();
                //OleDbCommand command = new OleDbCommand();
                //command.Connection = connection;


                string query = "select id from subject where subject_name='" + comboBox_subject_name.Text + "'";
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();
                //command.CommandText = query;

                //OleDbDataReader reader = command.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                    //string user_Selected = reader["username"].ToString();
                    textBox_subject_id.Text = mySqlDataReader.GetString("id");

                }
                //SelectedUser.Text = comboBox1.Text;
                /////////////////////////////////////
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }


        private void btn_add_lecturer_Click_1(object sender, EventArgs e)
        {
            //DBConnect dataB = new DBConnect();
            Lecturer Add_lecturer = new Lecturer();

            //int category = Convert.ToInt32(comboBox1_Category.Text.ToString());
            //int category_id = Convert.ToInt32(comboBox1_Category.Text.ToString());
            string name = txt_lecturer_name.Text;
            string lastname = txt_lecturer_lastname.Text;
            string login = name.ToLower();
            string password = lastname.ToLower();
            int subject_id = Convert.ToInt32(textBox_subject_id.Text.ToString());
            string subject_name = comboBox_subject_name.Text;


            if (verify())
            {

                if (Add_lecturer.lecturer_Insert(name, lastname, login, password, subject_id, subject_name))
                {
                    MessageBox.Show("Lecturer has been added", "Lecturer add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Input fields empty", "Lecturer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



            bool verify()
            {
                if ((txt_lecturer_name.Text.Trim() == "") || (txt_lecturer_lastname.Text.Trim() == ""))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            //load_subjects();
        }

        // Group Things --------------------------------------------------------------------------------------------------------------
        private void btn_add_group_Click(object sender, EventArgs e)
        {
            //DBConnect dataB = new DBConnect();
            Group Add_group = new Group();

            string name = txt_group_name.Text;

            if (verify())
            {

                if (Add_group.student_groups_Insert(name))
                {
                    MessageBox.Show("Group has been added", "Group add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Input fields empty", "Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



            bool verify()
            {
                if ((txt_group_name.Text.Trim() == ""))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            load_groups();
            load_groups_to_add_subjects();
        }

        // Subject things --------------------------------------------------------------------------------------------------------------------
        private void btn_add_subject_Click(object sender, EventArgs e)
        {
            //DBConnect dataB = new DBConnect();
            Subject Add_subject = new Subject();

            string name = txt_subject_name.Text;

            if (verify())
            {

                if (Add_subject.subject_Insert(name))
                {
                    MessageBox.Show("Subject has been added", "Subject add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Input fields empty", "Subject", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            bool verify()
            {
                if ((txt_subject_name.Text.Trim() == ""))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            load_subjects();
            load_subjects_to_add_to_groups();
            load_subjects_to_add_students();
        }

        // Subject to group things  -----------------------------------------------------------------------------------------------------------
        // 1. Load groups
        public void load_groups_to_add_subjects()
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=; database=academic_system");
                mySqlConnection.Open();

                MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM student_groups", mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                this.comboBox_groups2.Items.Clear();

                while (mySqlDataReader.Read())
                {
                    this.comboBox_groups2.Items.Add(mySqlDataReader.GetString("group_name"));
                }
                mySqlDataReader.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex);
            }
        }
        private void comboBox_groups2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=; database=academic_system");
                mySqlConnection.Open();

                string query = "select id from student_groups where group_name='" + comboBox_groups2.Text + "'";
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                    //string user_Selected = reader["username"].ToString();
                    textBox_group_id2.Text = mySqlDataReader.GetString("id");

                }
                mySqlDataReader.Close(); // ar reik sito
                mySqlConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void textBox_group_id2_TextChanged(object sender, EventArgs e)
        {

        }

        // 2 load subjects

        public void load_subjects_to_add_to_groups()
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=; database=academic_system");
                mySqlConnection.Open();
                MySqlCommand mySqlCommand;
                MySqlDataReader mySqlDataReader;

                mySqlCommand = new MySqlCommand("SELECT * FROM subject", mySqlConnection);
                mySqlDataReader = mySqlCommand.ExecuteReader();
                this.comboBox_subject_name2.Items.Clear();
                while (mySqlDataReader.Read())
                {
                    this.comboBox_subject_name2.Items.Add(mySqlDataReader.GetString("subject_name"));

                }
                mySqlDataReader.Close();
                mySqlConnection.Close(); //ar reik sito
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex);
            }
        }

        private void textBox_subject_id2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_subject_name2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=; database=academic_system");
                mySqlConnection.Open();

                string query = "select id from subject where subject_name='" + comboBox_subject_name2.Text + "'";
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                    textBox_subject_id2.Text = mySqlDataReader.GetString("id");
                }
                //mySqlDataReader.Close(); // ar reik sito
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void btn_add_subject_to_group_Click(object sender, EventArgs e)
        {
            Group add_subject_to_group = new Group();
            
            string group_name = comboBox_groups2.Text;
            int group_id = Convert.ToInt32(textBox_group_id2.Text.ToString());
            string subject_name = comboBox_subject_name2.Text;
            int subject_id = Convert.ToInt32(textBox_subject_id2.Text.ToString());


            if (verify())
            {

                if (add_subject_to_group.subject_to_group_Insert(group_id, group_name, subject_id, subject_name))
                {
                    MessageBox.Show("Subject has been added to the Group", "Subject to Group add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Input fields empty", "Subject to Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



            bool verify()
            {
                if ((comboBox_groups2.Text.Trim() == "") || (comboBox_subject_name2.Text.Trim() == ""))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        //STUDENT TO SUBJECTS ------------------------------------------------------------------------------------------------------
        public void load_students()
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=; database=academic_system");
                mySqlConnection.Open();
                MySqlCommand mySqlCommand;
                MySqlDataReader mySqlDataReader;

                mySqlCommand = new MySqlCommand("SELECT * FROM student", mySqlConnection);
                mySqlDataReader = mySqlCommand.ExecuteReader();
                this.comboBox_student_name.Items.Clear();
                while (mySqlDataReader.Read())
                {
                    this.comboBox_student_name.Items.Add(mySqlDataReader.GetString("student_name"));


                    //mySqlCommand = new MySqlCommand("SELECT id FROM subject where subject_name=''", mySqlConnection);
                    //mySqlDataReader = mySqlCommand.ExecuteReader();

                }
                mySqlDataReader.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex);
            }
        }

        private void comboBox_student_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=; database=academic_system");
                mySqlConnection.Open();

                string query = "select id from student where student_name='" + comboBox_student_name.Text + "'";
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                    textBox_student_id.Text = mySqlDataReader.GetString("id");
                }
                //mySqlDataReader.Close(); // ar reik sito
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        public void load_subjects_to_add_students()
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=; database=academic_system");
                mySqlConnection.Open();
                MySqlCommand mySqlCommand;
                MySqlDataReader mySqlDataReader;

                mySqlCommand = new MySqlCommand("SELECT * FROM subject", mySqlConnection);
                mySqlDataReader = mySqlCommand.ExecuteReader();
                this.comboBox_subject_name3.Items.Clear();
                while (mySqlDataReader.Read())
                {
                    this.comboBox_subject_name3.Items.Add(mySqlDataReader.GetString("subject_name"));

                }
                mySqlDataReader.Close();
                mySqlConnection.Close(); //ar reik sito
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex);
            }
        }

        private void comboBox_subject_name3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("datasource=localhost; username=root; password=; database=academic_system");
                mySqlConnection.Open();

                string query = "select id from subject where subject_name='" + comboBox_subject_name3.Text + "'";
                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                    textBox_subject_id3.Text = mySqlDataReader.GetString("id");
                }
                //mySqlDataReader.Close(); // ar reik sito
                mySqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void btn_add_student_to_subject_Click(object sender, EventArgs e)
        {
            Student_Grades add_student_to_subject = new Student_Grades();

            string student_name = comboBox_student_name.Text;
            int student_id = Convert.ToInt32(textBox_student_id.Text.ToString());
            string subject_name = comboBox_subject_name3.Text;
            int subject_id = Convert.ToInt32(textBox_subject_id3.Text.ToString());


            if (verify())
            {

                if (add_student_to_subject.student_to_subject(student_id, student_name, subject_id, subject_name))
                {
                    MessageBox.Show("Student has been added to the Subject", "Student to Subject add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Input fields empty", "Student to Subject", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }



            bool verify()
            {
                if ((comboBox_student_name.Text.Trim() == "") || (comboBox_subject_name3.Text.Trim() == ""))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }


        }
    }
}
