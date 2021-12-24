using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace signup.signupclass
{
    class Signupclass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }


        public bool Insert(Signupclass c)
        {
            bool IsSuccess = false;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DM15ABA;Initial Catalog=ubook;Integrated Security=True");
            try
            {
                string sql = "INSERT INTO signup(FirstName,LastName,UserName,Password) VALUES(@FirstName,@LastName,@UserName,@Password)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@UserName", c.UserName);
                cmd.Parameters.AddWithValue("@Password", c.Password);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dtable = new DataTable();

                sda.Fill(dtable);
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    IsSuccess = true;
                }
                else
                {
                    IsSuccess = false;

                }

                
            }
            catch(Exception ex)
            {
                
            }
            finally
            {
                conn.Close();
            }
            return IsSuccess;
        
        }
    }
}
