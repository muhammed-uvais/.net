using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDetailsApplication
{
    public partial class Form1 : Form
    {
        STDTBL stdmodel = new STDTBL();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbStudentID.Clear();
            tbStudentName.Clear();
            tbStudentAge.Clear();
            tbStudentCourse.Clear();
            tbStudentCity.Clear();
            tbStudentCountry.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            stdmodel.StudentName = tbStudentName.Text;
            stdmodel.StudentAge = int.Parse(tbStudentAge.Text);
            stdmodel.StudentCourse = tbStudentCourse.Text;
            stdmodel.StudentCity = tbStudentCity.Text;
            stdmodel.StudentCountry = tbStudentCountry.Text;
            


            using (StudentDetaiIsEntities db = new StudentDetaiIsEntities())
            {
                db.STDTBLs.Add(stdmodel);
                db.SaveChanges();
                dgv1.DataSource = db.STDTBLs.ToList();
            }
            MessageBox.Show("submitted successfully");
            tbStudentID.Clear();
            tbStudentName.Clear();
            tbStudentAge.Clear();
            tbStudentCourse.Clear();
            tbStudentCity.Clear();
            tbStudentCountry.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (StudentDetaiIsEntities db = new StudentDetaiIsEntities())
            {
                
                dgv1.DataSource = db.STDTBLs.ToList();
            }
        }

        private void dgv1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            tbStudentID.Text = dgv1.Rows[rowindex].Cells[0].Value.ToString();
            tbStudentName.Text = dgv1.Rows[rowindex].Cells[1].Value.ToString();
            tbStudentAge.Text = dgv1.Rows[rowindex].Cells[2].Value.ToString();
            tbStudentCourse.Text = dgv1.Rows[rowindex].Cells[3].Value.ToString();
            tbStudentCountry.Text = dgv1.Rows[rowindex].Cells[4].Value.ToString();
            tbStudentCity.Text = dgv1.Rows[rowindex].Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            stdmodel.Id = Convert.ToInt32(dgv1.CurrentRow.Cells["Id"].Value);
            using(StudentDetaiIsEntities db =new StudentDetaiIsEntities())
            {
                stdmodel = db.STDTBLs.Where(x => x.Id == stdmodel.Id).FirstOrDefault();
                db.STDTBLs.Remove(stdmodel);
                db.SaveChanges();
                dgv1.DataSource = db.STDTBLs.ToList();
                tbStudentID.Clear();
                tbStudentName.Clear();
                tbStudentAge.Clear();
                tbStudentCourse.Clear();
                tbStudentCity.Clear();
                tbStudentCountry.Clear();
            }
               
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            using (StudentDetaiIsEntities db = new StudentDetaiIsEntities())
            {
                stdmodel.Id = Convert.ToInt32(dgv1.CurrentRow.Cells["Id"].Value);
                stdmodel.StudentName = tbStudentName.Text;
                stdmodel.StudentAge = int.Parse(tbStudentAge.Text);
                stdmodel.StudentCourse = tbStudentCourse.Text;
                stdmodel.StudentCity = tbStudentCity.Text;
                stdmodel.StudentCountry = tbStudentCountry.Text;
                db.STDTBLs.Attach(stdmodel);
                db.SaveChanges();
                dgv1.DataSource = db.STDTBLs.ToList();
                tbStudentID.Clear();
                tbStudentName.Clear();
                tbStudentAge.Clear();
                tbStudentCourse.Clear();
                tbStudentCity.Clear();
                tbStudentCountry.Clear();

            }

        }
    }
}
