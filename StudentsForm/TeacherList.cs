using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using StudentsForm.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsForm
{
    public partial class TeacherList : Form
    {
        private readonly StudentDbContext _context = new();
        StudentGroup group;
        Teacher teacher;
        public TeacherList()
        {
            InitializeComponent();
        }
        #region VisibleButton
        private void VisibileBtn(string text)
        {
            if (text == "a")
            {
                btnCreate.Visible = false;
                btnEdit.Visible = true;
                btnDelete.Visible = true;
            }
            else
            {
                btnCreate.Visible = true;
                btnEdit.Visible = false;
                btnDelete.Visible = false;
            }
        }
        #endregion

        #region Clear Text
        private void ClearText()
        {
            txtAdress.Text = "";
            txtFullName.Text = "";
            txtPhoneNumber.Text = "";
        }
        #endregion

        #region FillGrid
        private void FillTeacherGrid()
        {
            try
            {
               
                dtgTeacherList.DataSource = _context.Teachers.Where(x =>!x.IsDeleted).Select(x => new
                {
                    id=x.ID,
                    AdSoyad =x.FullName,
                    Telefon= x.PhoneNumber != null ? x.PhoneNumber : "Məlumat Yoxdur",
                    Ünvan=x.Address != null ? x.Address : "Məlumat Yoxdur",
                }).ToList();
                for (int i = 0; i < dtgTeacherList.RowCount; i++)
                {
                    if (i % 2 == 0)
                    {
                        dtgTeacherList.Rows[i].DefaultCellStyle.BackColor = Color.DarkCyan;
                        dtgTeacherList.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            dtgTeacherList.Columns[0].Visible = false;
        }
        #endregion

        #region TeacherCrud
        private void AddTeacher()
        {
            string fullName = txtFullName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string adress = txtAdress.Text;
            string[] arr = { fullName };
            if (Utilities.IsEmpty(arr))
            {
                Teacher newTeacher = new()
                {
                    FullName = fullName,
                    PhoneNumber = phoneNumber,
                    Address = adress,
                };
                _context.Teachers.Add(newTeacher);
                _context.SaveChanges();
                MessageBox.Show("Müəllim uğurla əlavə edildi", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillTeacherGrid();
                ClearText();
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa ad,soyad daxil edin", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditTeacher()
        {
            string fullName = txtFullName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string adress = txtAdress.Text;
            string[] editArr = { fullName};
            if (Utilities.IsEmpty(editArr))
            {
                teacher.FullName = fullName;
                teacher.PhoneNumber = phoneNumber;
                teacher.Address = adress;
                _context.SaveChanges();
                MessageBox.Show("Dəyişiklik uğurla saxlanıldı", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillTeacherGrid();
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa ad,soyad daxil edin", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteTeacher()
        {
            DialogResult dg = MessageBox.Show("Silmək istədiyinizə əminsiniz?", "Silmək", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dg == DialogResult.Yes)
            {
                teacher.IsDeleted = true;
                _context.SaveChanges();
                VisibileBtn("b");
            }
        }
        #endregion

        private void dtgStudentList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            VisibileBtn("a");
            int TeacherId =(int)dtgTeacherList.Rows[e.RowIndex].Cells[0].Value;
            teacher=_context.Teachers.FirstOrDefault(x=>x.ID==TeacherId);
            if (teacher != null)
            {
                txtFullName.Text = teacher.FullName;
                txtAdress.Text = teacher.Address;
                txtPhoneNumber.Text = teacher.PhoneNumber;
            }
        }

        private void TeacherList_Load(object sender, EventArgs e)
        {
            FillTeacherGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditTeacher();
            VisibileBtn("b");
            ClearText();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteTeacher();
            FillTeacherGrid();
            VisibileBtn("b");
            ClearText();


        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            AddTeacher();
        }

        private void pckBack_Click(object sender, EventArgs e)
        {
            ClearText();
            VisibileBtn("b");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
