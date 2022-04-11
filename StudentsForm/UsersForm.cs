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
    public partial class UsersForm : Form
    {
        private readonly StudentDbContext _context = new();
        User user;
        public UsersForm()
        {
            InitializeComponent();
        }
        #region ClearText
        private void ClearText()
        {
            txtFullName.Text = "";
            txtPassword.Text = "";
            txtUserName.Text = "";
            cmbRoles.Text = "";
        }

        #endregion

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

        #region FillComboBox
        private void FillComboRoles()
        {
            cmbRoles.Items.AddRange(_context.Roles.Select(x => x.Name).ToArray());
        }
        #endregion

        #region FillGrid
        private void FillUsersGrid()
        {

            dtgUsers.DataSource = _context.Users.Where(x => !x.IsDeleted).Include(x => x.RoleToUsers).ThenInclude(x => x.Role).Select(x => new
            {
                x.ID,
                İstifadəçiAdı = x.UserName,
                AdSoyad = x.FullName,
                Vəzifə = UserRoleHelper.getUserRole(x.ID, x.RoleToUsers),
            }).ToList();
            dtgUsers.Columns[0].Visible = false;
            for (int i = 0; i < dtgUsers.RowCount; i++)
            {
                if (i % 2 == 0)
                {
                    dtgUsers.Rows[i].DefaultCellStyle.BackColor = Color.DarkCyan;
                    dtgUsers.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }

            }
        }
        #endregion

        #region UserCrud
        private void AddUser()
        {
            string fullName = txtFullName.Text;
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            string role = cmbRoles.Text;
            string[] myArr = { fullName, userName, password };
            if (Utilities.IsEmpty(myArr))
            {
                var selectedUser = _context.Users.Where(x => !x.IsDeleted).Select(x => x.UserName).ToList();
                if (selectedUser.Contains(userName))
                {
                    MessageBox.Show("Belə istifadəçi adı artıq mövcuddur", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (role != "" && role != null)
                    {
                        int RoleId = _context.Roles.FirstOrDefault(x => x.Name == role).ID;
                        User newUser = new()
                        {
                            UserName = userName,
                            FullName = fullName,
                            Password = password.Hashed(),
                        };
                        _context.Users.Add(newUser);
                        _context.SaveChanges();
                        RoleToUser roleToUser = new()
                        {
                            UserID = newUser.ID,
                            RoleID = RoleId
                        };
                        _context.RoleToUsers.Add(roleToUser);
                        _context.SaveChanges();

                        FillUsersGrid();
                        ClearText();
                        MessageBox.Show("İstifadəçi uğurla əlavə edildi!", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Zəhmət olmasa vəzifə seçin", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa xanaları tam doldurun", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditUser()
        {

            
            string fullName = txtFullName.Text;
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            string oldPassword = txtOldPassword.Text;
            string role = cmbRoles.Text;
            string[] myArr = { fullName, userName };
            if (Utilities.IsEmpty(myArr))
            {

                if (role != "" && role != null)
                {

                    int RoleId = _context.Roles.FirstOrDefault(x => x.Name == role).ID;
                    var roleToUser = _context.RoleToUsers.FirstOrDefault(x => x.UserID == user.ID);
                    user.FullName = fullName;
                    user.UserName = userName;

                    if (password != null && password != "")
                    {
                        if (!String.IsNullOrWhiteSpace(oldPassword))
                        {
                            if (oldPassword.Hashed() == user.Password)
                            {
                                user.Password = password.Hashed();

                            }
                        }
                        else
                        {
                            MessageBox.Show("Zəhmət olmasa köhnə şifrəni daxil edin", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            user.Password = user.Password;
                            return;
                        }

                    }
                    else
                    {
                        user.Password = user.Password;
                    }
                    roleToUser.RoleID = RoleId;
                    _context.SaveChanges();
                    FillUsersGrid();
                    ClearText();
                    lblOldPassword.Visible = false;
                    txtOldPassword.Visible = false;
                    MessageBox.Show("Dəyişiklik uğurla saxlanıldı!", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Zəhmət olmasa vəzifə seçin", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa xanaları tam doldurun", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeleteUser()
        {
            DialogResult dg = MessageBox.Show("Silmək istədiyinizə əminsiniz?", "Silmək", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dg == DialogResult.Yes)
            {
                user.IsDeleted = true;
                _context.SaveChanges();
                FillUsersGrid();
            }
        }
        #endregion
        private void pckFalse_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            pckFalse.Visible = false;
            pckTrue.Visible = true;
            txtOldPassword.UseSystemPasswordChar = false;
        }

        private void pckTrue_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            pckTrue.Visible = false;
            pckFalse.Visible = true;
            txtOldPassword.UseSystemPasswordChar = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            AddUser();
            ClearText();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditUser();
            VisibileBtn("b");
            ClearText();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteUser();
            VisibileBtn("b");
            ClearText();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            FillUsersGrid();
            FillComboRoles();
         
        }

        private void pckBack_Click(object sender, EventArgs e)
        {
            txtPassword.Enabled = true;
            txtPassword.BackColor = Color.White;
            txtOldPassword.Visible = false;
            lblOldPassword.Visible = false;
            ClearText();
            VisibileBtn("b");
        }

        private void dtgUsers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int userId = (int)dtgUsers.Rows[e.RowIndex].Cells[0].Value;
            user = _context.Users.Where(x => !x.IsDeleted).FirstOrDefault(x => x.ID == userId);
            if (user != null)
            {
                txtFullName.Text = user.FullName;
                txtUserName.Text = user.UserName;
                cmbRoles.Text = UserRoleHelper.getUserRole(userId, user.RoleToUsers);
            }
            if (txtPassword.Enabled == false)
            {
                txtPassword.BackColor = Color.Gray;
            }
            txtOldPassword.Visible = true;
            lblOldPassword.Visible = true;
            VisibileBtn("a");
        }

        private void txtOldPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.Enabled = true;
            txtPassword.BackColor = Color.White;
            if (String.IsNullOrWhiteSpace(txtOldPassword.Text))
            {
                txtPassword.Enabled = false;
                txtPassword.BackColor = Color.Gray;
            }
        }
    }
}
