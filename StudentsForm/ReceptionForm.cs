using DataAccess;
using Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
    public partial class ReceptionForm : Form
    {
        private readonly StudentDbContext _context=new();
        Student selectedStudent;
        public ReceptionForm()
        {
            InitializeComponent();
        }
        #region VisibleButton
        private void VisibileBtn(string text)
        {
            if (text == "a")
            {
                btnAdd.Visible = false;
                btnEdit.Visible = true;
                btnDelete.Visible = true;
            }
            else
            {
                btnAdd.Visible = true;
                btnEdit.Visible = false;
                btnDelete.Visible = false;
            }
        }
        #endregion

        #region FillComboBox
        private void FillComboGroup()
        {
            cmbStudentGroup.Items.AddRange(_context.StudentGroups.Where(x => !x.IsDeleted).Select(x => x.Number.ToString()).Distinct().ToArray());
        }
        private void FillComboStudent()
        {
            
            var selectedStudent = _context.Students.Where(x => !x.IsDeleted).ToArray();
            if(selectedStudent != null && selectedStudent.Length>0)
            {
                Dictionary<int, string> studentListDictionary = new();
                foreach (var stu in selectedStudent)
                {
                    studentListDictionary.Add(stu.ID, stu.FullName);
                }
                cmbStudent.DataSource = new BindingSource(studentListDictionary, null);
                cmbStudent.DisplayMember = "Value";
                cmbStudent.ValueMember = "Key";
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa əvvəlcə tələbə əlavə edin", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region ClearText
        private void ClearText()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtFatherName.Text = "";
            nmTotalPayment.Value = 0;
            nmRestAmount.Value = 0;
            cmbStudentGroup.Text = "";
            txtAddress.Text = "";
            txtPhoneNumber.Text = "";
        }
        #endregion

        #region StudentCrud
        private void AddStudent()
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string fatherName = txtFatherName.Text;
            decimal totalAmount = nmTotalPayment.Value;
            decimal restAmount = nmRestAmount.Value;
            string studentGroup = cmbStudentGroup.Text;
            string address = txtAddress.Text;
            bool IsDiscount = ckIsDiscount.Checked;
            bool IsSale = ckSale.Checked;
            string phoneNumber = txtPhoneNumber.Text;
            DateTime dateStudent = dtRegisterDate.Value;
            string[] myArr = { firstName, lastName, fatherName, totalAmount.ToString(), restAmount.ToString(),phoneNumber };
            if (Utilities.IsEmpty(myArr))
            {
                if (totalAmount >= restAmount)
                {
                    if (studentGroup != "")
                    {
                        int selectedGroupId = _context.StudentGroups.FirstOrDefault(x => x.Number == studentGroup).ID;
                        Student newStudent = new()
                        {
                            FirstName = firstName,
                            LastName = lastName,
                            FatherName = fatherName,
                            Address = address,
                            TotalPayment = totalAmount,
                            RestAmount = restAmount,
                            RegisterDate = dateStudent,
                            StudentGroupID = selectedGroupId,
                            IsDiscount= IsDiscount,
                            IsSale= IsSale,
                            PhoneNumber = phoneNumber,
                        };
                        _context.Students.Add(newStudent);
                        _context.SaveChanges();
                        MessageBox.Show("Tələbə uğurla əlavə edildi!", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillStudentGrid();
                        ClearText();
                    }
                    else
                    {
                        MessageBox.Show("Zəhmət olmasa qrup seçin", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Ödənilmiş məbləğ ümumi məbləğdən böyük ola bilməz", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Zəhmət olmasa xanaları tam doldurun", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditStudent()
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string fatherName = txtFatherName.Text;
            decimal totalAmount = nmTotalPayment.Value;
            decimal restAmount = nmRestAmount.Value;
            string studentGroup = cmbStudentGroup.Text;
            string address = txtAddress.Text;
            bool IsDiscount = ckIsDiscount.Checked;
            bool IsSale = ckSale.Checked;
            string phoneNumber=txtPhoneNumber.Text;
            DateTime dateStudent = dtRegisterDate.Value;
            int selectedGroupId = _context.StudentGroups.FirstOrDefault(x => x.Number == studentGroup).ID;
            string[] arr = { firstName, lastName, fatherName, totalAmount.ToString(), restAmount.ToString(), phoneNumber };
            if (Utilities.IsEmpty(arr))
            {
                if (totalAmount >= restAmount)
                {
                    if (studentGroup != "")
                    {
                        selectedStudent.FirstName = firstName;
                        selectedStudent.LastName = lastName;
                        selectedStudent.FatherName = fatherName;
                        selectedStudent.TotalPayment = totalAmount;
                        selectedStudent.RestAmount = restAmount;
                        selectedStudent.Address = address;
                        selectedStudent.StudentGroupID = selectedGroupId;
                        selectedStudent.IsDiscount= IsDiscount;
                        selectedStudent.IsSale= IsSale;
                        selectedStudent.RegisterDate = dateStudent;
                        selectedStudent.PhoneNumber = phoneNumber;
                        _context.SaveChanges();
                        MessageBox.Show("Dəyişiklik uğurla saxlanıldı", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillStudentGrid();
                    }
                    else
                    {
                        MessageBox.Show("Zəhmət olmasa qrup seçin", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Ödənilmiş məbləğ ümumi məbləğdən böyük ola bilməz", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa xanaları tam doldurun", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteStudent()
        {
            DialogResult dg = MessageBox.Show("Silmək istədiyinizə əminsiniz?", "Silmək", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dg == DialogResult.Yes)
            {
                selectedStudent.IsDeleted = true;
                _context.SaveChanges();
                panel1.Visible = false;
            }
        }
        #endregion

        #region FillGrid
        private void FillStudentGrid()
        {
            try
            {
                
                dtgStudentList.DataSource = _context.Students.Include(x => x.StudentGroup).ThenInclude(x => x.Specialities).Include(x => x.StudentGroup).ThenInclude(x => x.Teacher).Where(x => !x.IsDeleted && x.PhoneNumber.Contains(txtPhoneSearch.Text)).Select(x => new
                {
                    x.ID,
                    Ad = x.FirstName,
                    Soyad = x.LastName,
                    AtaAdı = x.FatherName != null ? x.FatherName : "Məlumat Yoxdur",
                    Ünvan = x.Address != null ? x.Address : "Məlumat Yoxdur",
                    Qrup = x.StudentGroup.Number,
                    ÖdənilmişMəbləğ = x.RestAmount,
                    ÜmumiÖdəniş = x.TotalPayment,
                    Telefon=x.PhoneNumber,
                    Müəllim = x.StudentGroup.Teacher.FullName != null ? x.StudentGroup.Teacher.FullName : "Müəllim Yoxdur",
                    İxtisas = x.StudentGroup.Specialities.Name != null ? x.StudentGroup.Specialities.Name : "İxtisas Seçilməyib",
                    QeydiyyatTarixi = x.RegisterDate,
                    Endirim = x.IsDiscount == true ? "Endirimli" : "Endirim Yoxdur",
                    Güzəşt = x.IsSale == true ? "Güzəştli" : "Güzəşt yoxdur",
                }).ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
              dtgStudentList.Columns[0].Visible = false;

            for (int i = 0; i < dtgStudentList.RowCount; i++)
            {
                decimal totalAmount = (decimal)dtgStudentList.Rows[i].Cells[7].Value;
                decimal restAmount = (decimal)dtgStudentList.Rows[i].Cells[6].Value;

                if (totalAmount == restAmount)
                {
                    dtgStudentList.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dtgStudentList.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
            }


        }
        #endregion

        private void ReceptionForm_Load(object sender, EventArgs e)
        {
            FillStudentGrid();
            FillComboGroup();
        }

        private void məlumataGələnTələbələrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformationStudent ins = new();
            ins.ShowDialog();
        }

        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
           
            panel1.Visible = true;
            panel2.Visible = false;
            btnStudentAdd.Visible = false;
            btnPayment.Visible = false;
            lblPhone.Visible = false;
            txtPhoneSearch.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible=false;
            btnStudentAdd.Visible=true;
            btnPayment.Visible=true;
            lblPhone.Visible = true;
            txtPhoneSearch.Visible = true;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            FillComboStudent();
            btnStudentAdd.Visible = false;
            btnPayment.Visible=false;
            panel2.Visible=true;
            lblPhone.Visible=false;
            txtPhoneSearch.Visible=false;
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudent();
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditStudent();
            ClearText();
            VisibileBtn("b");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteStudent();
            FillStudentGrid();
            ClearText();
            VisibileBtn("b");
            panel1.Visible = true; 
        }

        private void pckBack_Click(object sender, EventArgs e)
        {
            ClearText();
            VisibileBtn("b");
        }

        private void dtgStudentList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int StudentId = (int)dtgStudentList.Rows[e.RowIndex].Cells[0].Value;
            selectedStudent = _context.Students.Include(x => x.StudentGroup).FirstOrDefault(x => x.ID == StudentId);
            if (selectedStudent != null)
            {
                panel1.Visible = true;
                txtFirstName.Text = selectedStudent.FirstName;
                txtLastName.Text = selectedStudent.LastName;
                txtFatherName.Text = selectedStudent.FatherName;
                nmTotalPayment.Value = selectedStudent.TotalPayment;
                txtAddress.Text = selectedStudent.Address;
                txtPhoneNumber.Text = selectedStudent.PhoneNumber;
                nmRestAmount.Value = selectedStudent.RestAmount.Value != null ? selectedStudent.RestAmount.Value : 0;
                cmbStudentGroup.Text = selectedStudent.StudentGroup.Number;
                ckIsDiscount.Checked = selectedStudent.IsDiscount.Value? selectedStudent.IsDiscount.Value:false;
                ckSale.Checked = selectedStudent.IsSale.Value ? selectedStudent.IsSale.Value : false;
            }
            VisibileBtn("a");
            btnStudentAdd.Visible = false;
            btnPayment.Visible = false;
            panel2.Visible = false;
            lblPhone.Visible = false;
            txtPhoneSearch.Visible = false;
        }

        private void pckBackPayment_Click(object sender, EventArgs e)
        {
            cmbStudent.Text = "";
            nmPayAmount.Text ="0";
            dtPayment.Value = DateTime.Now;
        }

        private void btnPayAmount_Click(object sender, EventArgs e)
        {
            string fullName = cmbStudent.Text;
            decimal payAmount = nmPayAmount.Value;
            DateTime payDate = dtPayment.Value;
            if (fullName != "")
            {
                if (payAmount > 0)
                {
                    selectedStudent = _context.Students.Where(x => !x.IsDeleted).FirstOrDefault(x => x.ID.ToString() == cmbStudent.SelectedValue);
                    Payment newPay = new()
                    {
                        PayAmount = payAmount,
                        PayDate = payDate,
                        StudentID= selectedStudent.ID
                    };
                    if (selectedStudent.TotalPayment >= payAmount)
                    {
                        if (selectedStudent.TotalPayment >= selectedStudent.RestAmount+payAmount)
                        {
                            selectedStudent.RestAmount += payAmount;
                            _context.Payments.Add(newPay);
                            _context.SaveChanges();
                            MessageBox.Show("Ödəniş uğurla başa çatdı!", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Ödənilmiş məbləğ və ödəniş məbləğinin cəmi ümumi məbləğdən böyük ola bilməz", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ödəniş məbləği ümumi məbləğdən böyük ola bilməz", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                   
                }
                else
                {
                    MessageBox.Show("Zəhmət olmasa ödəniş məbləğini qeyd edin", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Zəhmət olmasa tələbə seçin", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FillStudentGrid();
            nmPayAmount.Value = 0;
            cmbStudent.Text = "";
            dtPayment.Value = DateTime.Now;

        }

        private void qrupYaratToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GroupList gr = new();
            gr.ShowDialog();
        }

        private void ödənişlərToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentForm py = new();
            py.ShowDialog();
        }

        private void txtPhoneSearch_KeyUp(object sender, KeyEventArgs e)
        {
            FillStudentGrid();
        }
    }
}
