using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace student.studentclass
{
    class Student
    {
        public string StudentName { get; set; }
        public string StudentMobileNo { get; set; }
        public string StudentCourse { get; set; }
        public string StudentAddress { get; set; }

        public void Insert(Student s)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DM15ABA;Initial Catalog=student;Integrated Security=True");
            try
            {
                string sql = "INSERT INTO student_details(StudentName, StudentMobileNo, StudentCourse, StudentAddress) VALUES(@StudentName, @StudentMobileNo, @StudentCourse, @StudentAddress)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@StudentName", s.StudentName);
                cmd.Parameters.AddWithValue("@StudentMobileNo", s.StudentMobileNo);
                cmd.Parameters.AddWithValue("@StudentCourse", s.StudentCourse);
                cmd.Parameters.AddWithValue("@StudentAddress", s.StudentAddress);
               
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
              

            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
                
        }
    }
}
