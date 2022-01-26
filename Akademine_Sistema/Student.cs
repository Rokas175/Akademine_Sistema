using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Akademine_Sistema
{
    class Student
    {
        DBConnect dataB = new DBConnect();


        public bool student_Insert(string student_name, string student_lastname, string student_login, string student_pass, int group_id, string group_name)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `student`(`student_name`, `student_last_name`, `student_login`, `student_pass`, `group_id`, `group_name`) VALUES (@st_name, @st_lastname, @st_login, @st_pass, @gr_id, @gr_name)", dataB.getConnection);
            //MySqlCommand command = new MySqlCommand("INSERT INTO `student`(`student_login`, `student_pass`, `student_name`, `student_last_name`) VALUES (@st_login, @st_pass, @st_name, @st_lastname)", dataB.getConnection);


            command.Parameters.Add("@st_name", MySqlDbType.String).Value = student_name;
            command.Parameters.Add("@st_lastname", MySqlDbType.String).Value = student_lastname;
            command.Parameters.Add("@st_login", MySqlDbType.String).Value = student_login;
            command.Parameters.Add("@st_pass", MySqlDbType.String).Value = student_pass;
            command.Parameters.Add("@gr_id", MySqlDbType.Int32).Value = group_id;
            command.Parameters.Add("@gr_name", MySqlDbType.String).Value = group_name;

            dataB.openConnection();


            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                dataB.closeConnection();
                return false;
            }
        }

        public bool student_delete(int student_id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `student` WHERE id='" + student_id + "'", dataB.getConnection);

            dataB.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                dataB.closeConnection();
                return true;
            }
            else
            {
                dataB.closeConnection();
                return false;
            }
        }

    }
}
