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
    public partial class LoginForm : Form
    {
        StudentDbContext _context = new();

        public LoginForm()
        {
            InitializeComponent();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtLogin.Text;
            string password = txtPassword.Text;
            string[] arr = new string[] { userName, password };
            var selectedUser = _context.Users.FirstOrDefault(x => x.UserName == userName);
            if (Utilities.IsEmpty(arr))
            {
                if (selectedUser != null)
                {
                    var RoleName = _context.RoleToUsers.Include(x => x.Role).FirstOrDefault(x => x.UserID == selectedUser.ID);
                    if (RoleName != null && RoleName.Role.Name == "Admin")
                    {
                        if (password.Hashed() == selectedUser.Password)
                        {
                            AdminForm ad = new(selectedUser);
                    ad.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Parol düzgün deyil!");
                        }

                    }
                    else if (RoleName != null && RoleName.Role.Name == "Reception")
                    {
                        if (password.Hashed() == selectedUser.Password)
                        {
                            ReceptionForm us = new();
                            us.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Parol düzgün deyil!");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Belə bir istifadəçi mövcud deyil!");
                }
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa xanaları doldurun");
            }

            }
        
        private void pckTrue_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            pckTrue.Visible = false;
            pckFalse.Visible = true;
        }

        private void pckFalse_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            pckFalse.Visible = false;
            pckTrue.Visible=true;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
