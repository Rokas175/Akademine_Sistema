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
    public partial class Deletions : Form
    {
        public Deletions()
        {
            InitializeComponent();

            load_student_DataGrid();
            load_lecturer_DataGrid();
            load_groups_DataGrid();
            load_subjects_DataGrid();
        }


        //Student things
        public void load_student_DataGrid()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=academic_system");
                string commandString = "SELECT * FROM student";
                MySqlCommand mySqlCommand = new MySqlCommand(commandString, con);

                MySqlCommandBuilder sqlCommandBuilder = new MySqlCommandBuilder();
                MySqlDataAdapter MySqldataAdapter = new MySqlDataAdapter();

                sqlCommandBuilder.DataAdapter = MySqldataAdapter;
                MySqldataAdapter.SelectCommand = mySqlCommand;

                DataSet dataSet = new DataSet();
                MySqldataAdapter.Fill(dataSet, "student");

                dataGridView_students.DataSource = dataSet;
                dataGridView_students.DataMember = "student";
                dataGridView_students.ReadOnly = true;
                this.dataGridView_students.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex);
            }

            
        }

        private void btn_delete_student_Click(object sender, EventArgs e)
        {
            Student delete_student = new Student();
            int student_id = Convert.ToInt32(dataGridView_students.CurrentRow.Cells[0].Value.ToString());
            //int user_id = Convert.ToInt32(label_user_id.Text);
            delete_student.student_delete(student_id);

            load_student_DataGrid();

        }

        //Lecturer things
        public void load_lecturer_DataGrid()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=academic_system");
                string commandString = "SELECT * FROM lecturer";
                MySqlCommand mySqlCommand = new MySqlCommand(commandString, con);

                MySqlCommandBuilder sqlCommandBuilder = new MySqlCommandBuilder();
                MySqlDataAdapter MySqldataAdapter = new MySqlDataAdapter();

                sqlCommandBuilder.DataAdapter = MySqldataAdapter;
                MySqldataAdapter.SelectCommand = mySqlCommand;

                DataSet dataSet = new DataSet();
                MySqldataAdapter.Fill(dataSet, "lecturer");

                dataGridView_lecturers.DataSource = dataSet;
                dataGridView_lecturers.DataMember = "lecturer";
                dataGridView_lecturers.ReadOnly = true;
                this.dataGridView_lecturers.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex);
            }


        }

        private void btn_delete_lecturer_Click(object sender, EventArgs e)
        {
            Lecturer delete_lecturer = new Lecturer();
            int lecturer_id = Convert.ToInt32(dataGridView_lecturers.CurrentRow.Cells[0].Value.ToString());
            //int user_id = Convert.ToInt32(label_user_id.Text);
            delete_lecturer.lecturer_delete(lecturer_id);

            load_lecturer_DataGrid();
        }

        //Group things
        public void load_groups_DataGrid()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=academic_system");
                string commandString = "SELECT * FROM student_groups";
                MySqlCommand mySqlCommand = new MySqlCommand(commandString, con);

                MySqlCommandBuilder sqlCommandBuilder = new MySqlCommandBuilder();
                MySqlDataAdapter MySqldataAdapter = new MySqlDataAdapter();

                sqlCommandBuilder.DataAdapter = MySqldataAdapter;
                MySqldataAdapter.SelectCommand = mySqlCommand;

                DataSet dataSet = new DataSet();
                MySqldataAdapter.Fill(dataSet, "student_groups");

                dataGridView_groups.DataSource = dataSet;
                dataGridView_groups.DataMember = "student_groups";
                dataGridView_groups.ReadOnly = true;
                this.dataGridView_groups.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex);
            }


        }

        private void btn_delete_group_Click(object sender, EventArgs e)
        {
            Group delete_group = new Group();
            int group_id = Convert.ToInt32(dataGridView_groups.CurrentRow.Cells[0].Value.ToString());
            //int user_id = Convert.ToInt32(label_user_id.Text);
            delete_group.group_delete(group_id);

            load_groups_DataGrid();
        }

        //Subject things
        public void load_subjects_DataGrid()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=academic_system");
                string commandString = "SELECT * FROM subject";
                MySqlCommand mySqlCommand = new MySqlCommand(commandString, con);

                MySqlCommandBuilder sqlCommandBuilder = new MySqlCommandBuilder();
                MySqlDataAdapter MySqldataAdapter = new MySqlDataAdapter();

                sqlCommandBuilder.DataAdapter = MySqldataAdapter;
                MySqldataAdapter.SelectCommand = mySqlCommand;

                DataSet dataSet = new DataSet();
                MySqldataAdapter.Fill(dataSet, "subject");

                dataGridView_subjects.DataSource = dataSet;
                dataGridView_subjects.DataMember = "subject";
                dataGridView_subjects.ReadOnly = true;
                this.dataGridView_subjects.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error " + ex);
            }


        }

        private void btn_delete_subject_Click(object sender, EventArgs e)
        {
            Subject delete_subject = new Subject();
            int subject_id = Convert.ToInt32(dataGridView_subjects.CurrentRow.Cells[0].Value.ToString());
            //int user_id = Convert.ToInt32(label_user_id.Text);
            delete_subject.subject_delete(subject_id);

            load_subjects_DataGrid();
        }


    }
}
