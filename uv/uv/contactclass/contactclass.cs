using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace uv.contactclasses
{
    class contactclass
    {
        public int contactid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Contactno { get; set; }

        public string Address { get; set; }
        
        public string Gender { get; set; }

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DM15ABA;Initial Catalog=uv;Integrated Security=True");
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM contact";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);



            }

            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public bool Insert(contactclass c)
        {
            bool issuccess = false;

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DM15ABA;Initial Catalog=ubook;Integrated Security=True");
            try
            {
                string sql = "INSERT INTO contact(FirstName,LastName,Contactno,Address,Gender) VALUES(@FirstName,@LastName,@Contactno,@Address,@Gender)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@Contactno", c.Contactno);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);


                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if(rows > 0)
                {
                    issuccess = true;
                }
                else
                {
                    issuccess = false;

                }
            }

            catch(Exception ex)
            {


            }

            finally
            {
                conn.Close();
            }
            return issuccess;
        }

        public bool Update(contactclass c)
        {
            bool issuccess = false;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DM15ABA;Initial Catalog=uv;Integrated Security=True");
            try
            {
                string sql = "UPDATE contact SET FirstName=@FirstName,LastName=@LastName,Contactno=@Contactno,Address=@Address,Gender=@Gender WHERE contactid=@contactid";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@Contactno", c.Contactno);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@contactid", c.contactid);


                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    issuccess = true;
                }
                else
                {
                    issuccess = false;

                }


            }

            catch(Exception ex)
            {

            }

            finally
            {
                conn.Close();

            }

            return issuccess;
        }

        public bool Delete(contactclass c)
        {
            bool issuccess = false;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DM15ABA;Initial Catalog=uv;Integrated Security=True");

            try
            {
                string sql = "DELETE FROM contact WHERE contactid=@contactid";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@contactid", c.contactid);
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    issuccess = true;
                }
                else
                {
                    issuccess = false;

                }

            }
            catch(Exception ex)
            {

            }
            finally
            {

            }
            return issuccess;
        }
    }
}
