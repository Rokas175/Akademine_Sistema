using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Akademine_Sistema
{
    class Lecturer
    {
        DBConnect dataB = new DBConnect();

        public bool lecturer_Insert(string lecturer_name, string lecturer_lastname, string lecturer_login, string lecturer_pass, int subject_id, string subject_name)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `lecturer`(`lecturer_name`, `lecturer_last_name`, `lecturer_login`, `lecturer_pass`, `subject_id`, `subject_name`) VALUES (@lc_name, @lc_lastname, @lc_login, @lc_pass, @sbj_id, @sbj_name)", dataB.getConnection);

            command.Parameters.Add("@lc_login", MySqlDbType.String).Value = lecturer_login;
            command.Parameters.Add("@lc_pass", MySqlDbType.String).Value = lecturer_pass;
            command.Parameters.Add("@lc_name", MySqlDbType.String).Value = lecturer_name;
            command.Parameters.Add("@lc_lastname", MySqlDbType.String).Value = lecturer_lastname;
            command.Parameters.Add("@sbj_id", MySqlDbType.Int32).Value = subject_id;
            command.Parameters.Add("@sbj_name", MySqlDbType.String).Value = subject_name;

            //sbj_id, @sbj_name

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

        public bool lecturer_delete(int lecturer_id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `lecturer` WHERE id='" + lecturer_id + "'", dataB.getConnection);

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
