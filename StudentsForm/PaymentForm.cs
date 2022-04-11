using DataAccess;
using Entities;
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
    public partial class PaymentForm : Form
    {
        private readonly StudentDbContext _context = new();
        Student selectedStudent;
        Payment selectedPayment;
        public PaymentForm()
        {
            InitializeComponent();
        }
        #region ClearText
        private void ClearText()
        {
            cmbStudent.Text = string.Empty;
            nmPayment.Value = 0;
            dtPayment.Value = DateTime.Now;
        }
        #endregion
        #region VisibleButton
        private void VisibileBtn(string text)
        {
            if (text == "a")
            {
                btnEdit.Visible = true;
                btnDelete.Visible = true;
                lblPay.Visible = true;
                lblPayDate.Visible = true;
                nmPayment.Visible = true;
                dtPayment.Visible = true;
            }
            else
            {
                btnEdit.Visible = false;
                btnDelete.Visible = false;
                lblPay.Visible = false;
                lblPayDate.Visible=false;
                nmPayment.Visible = false;
                dtPayment.Visible = false;
            }
        }
        #endregion

        #region FillCombo
        private void FillStudentCombo()
        {
            var selectedStudent = _context.Students.Where(x => !x.IsDeleted).ToArray();
            if(selectedStudent != null && selectedStudent.Count()>0)
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

        #region FillGrid
        private void FillPaymentGrid()
        {
            if (cmbStudent.Items.Count> 0)
            {
                var firstName = cmbStudent.Text.Split(" ")[0];
                var lastName = cmbStudent.Text.Split(" ")[1];
                dtgPayment.DataSource = _context.Payments.Include(x => x.Student).ThenInclude(x => x.StudentGroup).Where(x => !x.IsDeleted && x.Student.FirstName.Contains(firstName) && x.Student.LastName.Contains(lastName)).Select(x => new
                {
                    x.ID,
                    Tələbə = x.Student.FullName,
                    ÖdənişMəbəlği = x.PayAmount,
                    ÖdənişTarixi = x.PayDate,
                    Qrup = x.Student.StudentGroup.Number,
                    ÜmumiÖdəniş = x.Student.TotalPayment,
                    ÖdənilmişMəbləğ = x.Student.RestAmount,
                    Endirim = x.Student.IsDiscount == true ? "Endirimli" : "Endirim Yoxdur",
                    Güzəşt = x.Student.IsSale == true ? "Güzəştli" : "Güzəşt yoxdur",
                }).OrderByDescending(x => x.ÖdənişTarixi).ToList();
                dtgPayment.Columns[0].Visible = false;
            }
            for (int i = 0; i < dtgPayment.RowCount; i++)
            {
                if (i % 2 == 0)
                {
                    dtgPayment.Rows[i].DefaultCellStyle.BackColor = Color.DarkCyan;
                    dtgPayment.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }

            }
            for (int i = 0; i < dtgPayment.RowCount; i++)
            {
                decimal totalAmount = (decimal)dtgPayment.Rows[i].Cells[5].Value;
                decimal restAmount = (decimal)dtgPayment.Rows[i].Cells[6].Value;

                if (totalAmount == restAmount)
                {
                    dtgPayment.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dtgPayment.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }
        #endregion

        #region PaymentCrud
        private void EditStudentPayment()
        {
            decimal studentPayment = nmPayment.Value;
            DateTime payDate = dtPayment.Value;
            selectedStudent = _context.Students.Where(x => !x.IsDeleted).FirstOrDefault(x => x.ID.ToString() == cmbStudent.SelectedValue);
            var selectedPayment = _context.Payments.Where(x => !x.IsDeleted).FirstOrDefault(x => x.StudentID == selectedStudent.ID);
            if(selectedStudent != null)
            {
                if (studentPayment >= 0)
                {
                    if (selectedStudent.TotalPayment>= studentPayment)
                    {
                        if (selectedStudent.TotalPayment>studentPayment + selectedStudent.RestAmount )
                        {
                            selectedPayment.StudentID = selectedStudent.ID;
                            selectedPayment.PayAmount = studentPayment;
                            selectedPayment.PayDate = payDate;
                            _context.SaveChanges();
                            FillPaymentGrid();
                            MessageBox.Show("Dəyişiklik uğurla saxlanıldı", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Zəhmət olmasa ödəniş məbləğini qeyd edin!", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            

        }
        private void DeletePayment()
        {
            DialogResult dg = MessageBox.Show("Silmək istədiyinizə əminsiniz?", "Silmək", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dg == DialogResult.Yes)
            {
                selectedPayment.IsDeleted = true;
                _context.SaveChanges();
            }
        }
        #endregion
        private void PaymentForm_Load(object sender, EventArgs e)
        {
            FillStudentCombo();
            FillPaymentGrid();
        }

    

        private void dtgPayment_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int paymentId = (int)dtgPayment.Rows[e.RowIndex].Cells[0].Value;
            var selectedPayment = _context.Payments.Include(x => x.Student).FirstOrDefault(x => x.ID == paymentId);
            if (selectedPayment != null)
            {
                cmbStudent.Text = selectedPayment.Student.FullName;
                nmPayment.Value= selectedPayment.PayAmount;
                dtPayment.Value = selectedPayment.PayDate;
            }

            VisibileBtn("a");
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditStudentPayment();
            VisibileBtn("b");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeletePayment();
            VisibileBtn("b");
        }

        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillPaymentGrid();
        }

        private void cmbStudent_KeyUp(object sender, KeyEventArgs e)
        {
                FillPaymentGrid();
            
        }

        private void pckBack_Click(object sender, EventArgs e)
        {
            ClearText();
            VisibileBtn("b");
        }

     
    }
}
