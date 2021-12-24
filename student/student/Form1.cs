using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using student.studentclass;
using System.Data.SqlClient;

namespace student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DM15ABA;Initial Catalog=student;Integrated Security=True");
        Student s = new Student();



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdbtnhumanities_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdbnbiologyscience_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtboxstudentname.Clear();
            txtboxmobileno.Clear();
            txtboxaddress.Clear();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            s.StudentName = txtboxstudentname.Text;
            s.StudentMobileNo = txtboxmobileno.Text;
            s.StudentAddress = txtboxaddress.Text;
            if(rdbnbiologyscience.Checked)
            {
                s.StudentCourse = rdbnbiologyscience.Text;
            }
            if(rdbncommerce.Checked)
            {
                s.StudentCourse = rdbncommerce.Text;
            }
            if(rdbtncomputerscience.Checked)
            {
                s.StudentCourse = rdbtncomputerscience.Text;
            }
            s.Insert(s);

            
        }

        private void rdbtncomputerscience_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbncommerce_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
