using DataAccess;
using Entities;
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
    public partial class AdminForm : Form
    {
        private readonly StudentDbContext _context = new();
        readonly User selectedUser;
        readonly Student selectedStudent;
        public AdminForm(User us)
        {
            selectedUser = us;
            InitializeComponent();
        }

        private void pckStudent_Click(object sender, EventArgs e)
        {
            StudentList st = new();
            st.ShowDialog();

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
        }

        private void pckTeacher_Click(object sender, EventArgs e)
        {
            TeacherList tc = new();
            tc.ShowDialog();
        }

        private void pckGroups_Click(object sender, EventArgs e)
        {
            GroupList gr = new();
            gr.ShowDialog();
        }

        private void pckUser_Click(object sender, EventArgs e)
        {
            UsersForm user = new();
            user.ShowDialog();
        }

        private void pckInformationStudent_Click(object sender, EventArgs e)
        {
            InformationStudent ins = new();
            ins.ShowDialog();
        }

   

        private void lblPayment_Click(object sender, EventArgs e)
        {
                PaymentForm py = new();
                py.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            CostsList cs = new();
            cs.ShowDialog();
        }

       
    }
}
