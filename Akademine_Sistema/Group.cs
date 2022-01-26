using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Akademine_Sistema
{
    class Group
    {
        DBConnect dataB = new DBConnect();

        public bool student_groups_Insert(string student_group_name)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `student_groups`(`group_name`) VALUES (@gr_name)", dataB.getConnection);

            command.Parameters.Add("@gr_name", MySqlDbType.String).Value = student_group_name;

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

        public bool group_delete(int group_id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `student_groups` WHERE id='" + group_id + "'", dataB.getConnection);

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

        public bool subject_to_group_Insert(int group_id, string group_name, int subject_id, string subject_name)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `student_group_subjects`(`group_id`, `group_name`, `subject_id`, `subject_name`) VALUES (@gr_id, @gr_name, @sbj_id, @sbj_name)", dataB.getConnection);

            command.Parameters.Add("@gr_id", MySqlDbType.String).Value = group_id;
            command.Parameters.Add("@gr_name", MySqlDbType.String).Value = group_name;
            command.Parameters.Add("@sbj_id", MySqlDbType.String).Value = subject_id;
            command.Parameters.Add("@sbj_name", MySqlDbType.String).Value = subject_name;
           
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



    }
}
