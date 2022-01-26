using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms; //added

namespace Akademine_Sistema
{
    class Student_Grades
    {
        DBConnect dataB = new DBConnect();

        public bool student_to_subject(int student_id, string student_name, int subject_id, string subject_name)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `student_grades`(`student_id`, `student_name`, `subject_id`, `subject_name`) VALUES (@st_id, @st_name, @sbj_id, @sbj_name)", dataB.getConnection);

            command.Parameters.Add("@st_id", MySqlDbType.String).Value = student_id;
            command.Parameters.Add("@st_name", MySqlDbType.String).Value = student_name;
            command.Parameters.Add("@sbj_id", MySqlDbType.String).Value = subject_id;
            command.Parameters.Add("@sbj_name", MySqlDbType.String).Value = subject_name;
            //@gr_id, @gr_name, @sbj_id, @sbj_name
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
