using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Akademine_Sistema
{
    class Subject
    {
        DBConnect dataB = new DBConnect();

        public bool subject_Insert(string subject_name)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `subject`(`subject_name`) VALUES (@sbj_name)", dataB.getConnection);

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

        public bool subject_delete(int subject_id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `subject` WHERE id='" + subject_id + "'", dataB.getConnection);

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
