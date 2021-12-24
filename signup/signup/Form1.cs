using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using signup.signupclass;
using System.Data.SqlClient;

namespace signup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DM15ABA;Initial Catalog=ubook;Integrated Security=True");
        Signupclass c = new Signupclass();
        private void txtboxpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblpassword_Click(object sender, EventArgs e)
        {

        }

        private void lbllastname_Click(object sender, EventArgs e)
        {

        }

        private void lblfirstname_Click(object sender, EventArgs e)
        {

        }

        private void lblusernamelogin_Click(object sender, EventArgs e)
        {

        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            c.FirstName = txtboxfirstname.Text;
            c.LastName = txtboxlastname.Text;
            c.UserName = txtboxusername.Text;
            c.Password = txtboxpassword.Text;

            c.Insert(c);
            txtboxpassword.Clear();
            MessageBox.Show("SignUp Complete");


        }

        private void txtboxusernamelogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txtboxusernamelogin.Text;
            password = txtboxpasswordlogin.Text;
            try
            {
                string query  = "SELECT * FROM signup WHERE username = '" + txtboxusernamelogin.Text + "' AND password = '" + txtboxpasswordlogin.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                if(dtable.Rows.Count >0)
                {
                    home form2 = new home();
                    home form3 = new home();
                    form2.Show();
                    txtboxusernamelogin.Clear();
                    txtboxpasswordlogin.Clear();

                }
                else
                {
                    MessageBox.Show("invalid details", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
