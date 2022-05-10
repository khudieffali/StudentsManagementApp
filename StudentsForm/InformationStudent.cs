using DataAccess;
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
    public partial class InformationStudent : Form
    {
       private readonly StudentDbContext _context = new();
        Entities.InformationStudent infoStudent;
        public InformationStudent()
        {
            InitializeComponent();
        }
        #region ClearText
        private void ClearText()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtFatherName.Text = "";
            txtAddress.Text ="";
            txtPhone.Text = "";
            cmbUsers.Text = "";
            txtWhereFrom.Text = "";
            rchDescription.Text = "";
            txtInterests.Text = "";
            dtInformationDate.Value = DateTime.Now;
        }
        #endregion

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
        private void FillComboUsers()
        {
            cmbUsers.Items.AddRange(_context.Users.Where(x => !x.IsDeleted).Select(x => x.FullName.ToString()).ToArray());
        }

        #endregion

        #region FillGrid
        private void FillInformationStudentGrid()
        {
            dtgInformationStudent.DataSource = _context.InformationStudents.Where(x => !x.IsDeleted).Include(x=>x.User).Select(x => new
            {
                x.ID,
                Ad = x.FirstName,
                Soyad = x.LastName,
                AtaAdı= x.FatherName != null ? x.FatherName : "Məlumat Yoxdur",
                Ünvan= x.Address != null ? x.Address : "Məlumat Yoxdur",
                Telefon= x.PhoneNumber != null? x.PhoneNumber : "Məlumat Yoxdur",
                MəlumatVerən=x.User.FullName.ToString(),
                NəyiMaraqlanıb = x.Interests != null ? x.Interests : "Məlumat Yoxdur",
                QeydiyyatTarixi=x.InformationDate,
                BiziHaradaGördünüz = x.WhereFrom!=null?x.WhereFrom:"Məlumat Yoxdur",
                Qeyd=x.Description != null?x.Description:"Məlumat yoxdur"
            }).ToList();
            dtgInformationStudent.Columns[0].Visible = false;
            for (int i = 0; i < dtgInformationStudent.RowCount; i++)
            {
                if(i % 2 == 0)
                {
                    dtgInformationStudent.Rows[i].DefaultCellStyle.BackColor = Color.DarkCyan;
                    dtgInformationStudent.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }

            }
        }
        #endregion

        #region InfoStudentCrud
        private void AddInfoStudent()
        {
            string firstName=txtFirstName.Text;
            string lastName=txtLastName.Text;
            string fatherName=txtFatherName.Text;
            string address=txtAddress.Text;
            string phoneNumber=txtPhone.Text;
            string infoUser=cmbUsers.Text;
            string whereFrom=txtWhereFrom.Text;
            string description=rchDescription.Text;
            string interests=txtInterests.Text;
            DateTime informationDate = dtInformationDate.Value;
            string[] arr ={ firstName,lastName,whereFrom};
            if (Utilities.IsEmpty(arr))
            {
                if(infoUser != "")
                {
                    int infoUserId = _context.Users.FirstOrDefault(x => x.FullName == infoUser).ID;
                  Entities.InformationStudent newInfoStudent = new()
                    {
                     FirstName=firstName,
                     LastName=lastName, 
                     FatherName=fatherName,
                     Address=address,
                     PhoneNumber=phoneNumber,
                     WhereFrom=whereFrom,
                     Interests=interests,
                     InformationDate=informationDate,
                     UserId=infoUserId,
                     Description=description,
                    };
                    _context.InformationStudents.Add(newInfoStudent);
                    _context.SaveChanges();
                    MessageBox.Show("Tələbə uğurla əlavə edildi!", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillInformationStudentGrid();
                    ClearText();
                }
                else
                {
                    MessageBox.Show("Zəhmət olmasa məlumat verən şəxsi seçin", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Zəhmət olmasa xanaları tam doldurun", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditInfoStudent()
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string fatherName = txtFatherName.Text;
            string address = txtAddress.Text;
            string phoneNumber = txtPhone.Text;
            string infoUser = cmbUsers.Text;
            string whereFrom = txtWhereFrom.Text;
            string decription=rchDescription.Text;
            string interests = txtInterests.Text;
            DateTime informationDate = dtInformationDate.Value;
            string[] arr = { firstName, lastName,whereFrom };
            if (Utilities.IsEmpty(arr))
            {
                if (infoUser != "")
                {
                    int infoUserId = _context.Users.FirstOrDefault(x => x.FullName == infoUser).ID;
                    infoStudent.FirstName = firstName;
                    infoStudent.LastName = lastName;
                    infoStudent.FatherName = fatherName;
                    infoStudent.Address = address;
                    infoStudent.PhoneNumber = phoneNumber;
                    infoStudent.UserId = infoUserId;
                    infoStudent.WhereFrom = whereFrom;
                    infoStudent.Description = decription;
                    infoStudent.Interests = interests;
                    infoStudent.InformationDate = informationDate;
                    _context.SaveChanges();
                    MessageBox.Show("Dəyişiklik uğurla saxlanıldı", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillInformationStudentGrid();
                    ClearText();
                }
                else
                {
                    MessageBox.Show("Zəhmət olmasa məlumat verən şəxsi seçin", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Zəhmət olmasa xanaları tam doldurun", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteInfoStudent()
        {
            DialogResult dg = MessageBox.Show("Silmək istədiyinizə əminsiniz?", "Silmək", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dg == DialogResult.Yes)
            {
                infoStudent.IsDeleted = true;
                _context.SaveChanges();
            }
        }
        #endregion
        private void pckBack_Click(object sender, EventArgs e)
        {
            ClearText();
            VisibileBtn("b");
        }

        private void InformationStudent_Load(object sender, EventArgs e)
        {
            FillInformationStudentGrid();
            FillComboUsers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddInfoStudent();
          
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditInfoStudent();
            ClearText();
            VisibileBtn("b");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteInfoStudent();
            ClearText();
            VisibileBtn("b");
        }

        private void dtgInformationStudent_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int infoStduentId = (int)dtgInformationStudent.Rows[e.RowIndex].Cells[0].Value;
            infoStudent = _context.InformationStudents.Include(x => x.User).FirstOrDefault(x => x.ID == infoStduentId);
            if (infoStudent != null)
            {
                txtFirstName.Text = infoStudent.FirstName;
                txtLastName.Text = infoStudent.LastName;
                txtFatherName.Text = infoStudent.FatherName;
                txtAddress.Text = infoStudent.Address;
                txtPhone.Text = infoStudent.PhoneNumber;
                cmbUsers.Text = infoStudent.User.FullName;
                txtWhereFrom.Text = infoStudent.WhereFrom;
                txtInterests.Text = infoStudent.Interests;
                dtInformationDate.Value= infoStudent.InformationDate;
                rchDescription.Text = infoStudent.Description;
            }
            VisibileBtn("a");
        }
    } 
}
