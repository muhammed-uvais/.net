using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uv.contactclasses;

namespace uv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        contactclass c = new contactclass();
        

        private void lblcontactid_Click(object sender, EventArgs e)
        {

        }

        private void lblfirstname_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblcontactno_Click(object sender, EventArgs e)
        {

        }

        private void lblgender_Click(object sender, EventArgs e)
        {

        }

        private void txtboxcontactid_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.FirstName = txtboxfirstname.Text;
            c.LastName = txtboxlastname.Text;
            c.Contactno = txtboxcontactno.Text;
            c.Address = txtboxaddress.Text;
            c.Gender = cmbgender.Text;


            bool success = c.Insert(c);
            if(success == true)
            {
                MessageBox.Show("new contact addeed sucessfully inserted");
                clear();
            }
            else
            {
                MessageBox.Show("failed to add new contact.try again");

            }
            DataTable dt = c.Select();
            dgvcontactlist.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.contactid = int.Parse(txtboxcontactid.Text);
            c.FirstName = txtboxfirstname.Text;
            c.LastName = txtboxlastname.Text;
            c.Contactno = txtboxcontactno.Text;
            c.Address = txtboxaddress.Text;
            c.Gender = cmbgender.Text;

            bool success = c.Update(c);
            if(success == true)
            {
                MessageBox.Show("contact has been succesfully updated");
                DataTable dt = c.Select();
                dgvcontactlist.DataSource = dt;
                clear();

            }
            else
            {
                MessageBox.Show("failed to update contact");

            }
                
        }

        private void lblsearch_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            c.contactid = Convert.ToInt32(txtboxcontactid.Text);
            bool success = c.Delete(c);

            if(success ==true)
            {
                MessageBox.Show("successfully deleted");
                DataTable dt = c.Select();
                dgvcontactlist.DataSource = dt;
                clear();

            }
            else
            {
                MessageBox.Show("failed to delete");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = c.Select();
            dgvcontactlist.DataSource = dt;

        }

        public void clear()
        {
            txtboxfirstname.Text = "";
            txtboxlastname.Text = "";
            txtboxcontactno.Text = "";
            txtboxaddress.Text = "";
            cmbgender.Text = "";
            txtboxcontactid.Text = "";


        }

        private void dgvcontactlist_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = e.RowIndex;
            txtboxcontactid.Text = dgvcontactlist.Rows[rowindex].Cells[0].Value.ToString();
            txtboxfirstname.Text = dgvcontactlist.Rows[rowindex].Cells[1].Value.ToString();
            txtboxlastname.Text = dgvcontactlist.Rows[rowindex].Cells[2].Value.ToString();
            txtboxcontactno.Text = dgvcontactlist.Rows[rowindex].Cells[3].Value.ToString();
            txtboxaddress.Text = dgvcontactlist.Rows[rowindex].Cells[4].Value.ToString();
            cmbgender.Text = dgvcontactlist.Rows[rowindex].Cells[5].Value.ToString();

        }

        private void txtboxsearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DM15ABA;Initial Catalog=uv;Integrated Security=True");

            string keyword = txtboxsearch.Text;

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM contact WHERE FirstName LIKE '%" + keyword + "%' OR LastName LIKE '%" + keyword + "%' OR Address LIKE '%" + keyword + "%'", conn);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            dgvcontactlist.DataSource = dtable;

        }
    }
}
