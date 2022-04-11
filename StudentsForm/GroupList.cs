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
    public partial class GroupList : Form
    {
       private readonly StudentDbContext _context = new();
        StudentGroup selectedGroup;
        public GroupList()
        {
            InitializeComponent();
        }
        #region FillComboBox
        private void FillTeacherCombo()
        {
            cmbTeachers.Items.AddRange(_context.Teachers.Where(x=>!x.IsDeleted).Select(x=>x.FullName).ToArray());
        }
        private void FillSpecialityCombo()
        {
            cmbSpecialities.Items.AddRange(_context.Specialities.Where(x=>!x.IsDeleted).Select(x=>x.Name).Distinct().ToArray());
        }
        #endregion

        #region ClearText
        private void ClearText()
        {
            txtNumber.Text = "";
            cmbTeachers.Text = "";
            dtStart.Text = "";
            cmbSpecialities.Text = "";
        }

        #endregion

        #region VisibleButton
        private void VisibileBtn(string text)
        {
            if (text == "a")
            {
                btnCreate.Visible = false;
                btnEdit.Visible = true;
            }
            else
            {
                btnCreate.Visible = true;
                btnEdit.Visible = false;
            }
        }
        #endregion

        #region FillGrid
        private void FillGridGroups()
        {
            dtgGroups.DataSource = _context.StudentGroups.Include(x=>x.Specialities).Where(x => !x.IsDeleted).Select(x => new
            {
                x.ID,
                QrupNömrəsi=x.Number,
                YaranmaTarixi=x.CreatedDate,
                BaşlamaTarixi=x.StartDate,
                Müəllim=x.Teacher.FullName,
                İxtisas=x.Specialities.Name!=null ? x.Specialities.Name :"İxtisas Seçilməyib"
            }).ToList();
            dtgGroups.Columns[0].Visible = false;
            for (int i = 0; i < dtgGroups.RowCount; i++)
            {
                if (i % 2 == 0)
                {
                    dtgGroups.Rows[i].DefaultCellStyle.BackColor = Color.DarkCyan;
                    dtgGroups.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }

            }
        }
        #endregion

        #region StudentGroupCrud
        private void AddGroup()
        {
           string groupNumber = txtNumber.Text;
           string groupTeacher=cmbTeachers.Text;
            string specialities=cmbSpecialities.Text;
            DateTime CreatedDate = dtRegisterGroup.Value;
           DateTime startTime = dtStart.Value;
           string[] myArr = {groupNumber, startTime.ToString()};
            if (Utilities.IsEmpty(myArr))
            {
               var selectedGroup = _context.StudentGroups.Where(x => !x.IsDeleted).Select(x=>x.Number).ToList();
                if (selectedGroup.Contains(groupNumber))
                {
                    MessageBox.Show("Belə qrup mövcuddur", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (groupTeacher != "" && specialities != "")
                    {
                        int TeacherId = _context.Teachers.FirstOrDefault(x => x.FullName == groupTeacher).ID;
                        int SpecialityId = _context.Specialities.FirstOrDefault(x => x.Name == specialities).ID;
                        if (startTime >= CreatedDate)
                        {
                            StudentGroup newGroup = new()
                            {
                                Number = groupNumber,
                                CreatedDate = CreatedDate,
                                StartDate = startTime,
                                TeacherId = TeacherId,
                                SpecialityId = SpecialityId,
                            };
                            _context.StudentGroups.Add(newGroup);
                            _context.SaveChanges();
                            MessageBox.Show("Qrup uğurla əlavə edildi!", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FillGridGroups();
                        }
                        else
                        {
                            MessageBox.Show("Zəhmət olmasa başlama tarixini düzgün qeyd edin", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        if (groupTeacher == "")
                        {
                            MessageBox.Show("Zəhmət olmasa müəllim əlavə edin!");
                        }
                        if (specialities == "")
                        {
                            MessageBox.Show("Zəhmət olmasa ixtisas əlavə edin!");
                        }
                    }
                }
           
             
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa xanaları tam doldurun", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void EditGroup()
        {
            string groupNumber = txtNumber.Text;
            string groupTeacher = cmbTeachers.Text;
            string specialities = cmbSpecialities.Text;
            DateTime startTime = dtStart.Value;
            DateTime CreatedDate=dtRegisterGroup.Value;
            string[] editArr = { groupNumber, groupNumber, specialities,startTime.ToString()};
            if (Utilities.IsEmpty(editArr))
            {
                int groupTeacherId = _context.Teachers.FirstOrDefault(x => x.FullName == groupTeacher).ID;
                int specialityId=_context.Specialities.FirstOrDefault(x => x.Name == specialities).ID;
                if (startTime>=selectedGroup.CreatedDate )
                {
                    selectedGroup.Number = groupNumber;
                    selectedGroup.TeacherId = groupTeacherId;
                    selectedGroup.SpecialityId = specialityId;
                    selectedGroup.StartDate = startTime;
                    selectedGroup.CreatedDate = CreatedDate;
                    _context.SaveChanges();
                    MessageBox.Show("Dəyişiklik uğurla saxlanıldı", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FillGridGroups();
                }
                else
                {
                    MessageBox.Show("Zəhmət olmasa başlanğıc tarixini düzgün qeyd edin", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa xanaları tam doldurun", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   
        
        #endregion
        private void GroupList_Load(object sender, EventArgs e)
        {
            FillTeacherCombo();
            FillSpecialityCombo();
            FillGridGroups();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            AddGroup();
            ClearText();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditGroup();
            VisibileBtn("b");
            ClearText();
        }

    

        private void pckBack_Click(object sender, EventArgs e)
        {
            ClearText();
            VisibileBtn("b");
        }

        private void dtgGroups_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int groupId = (int)dtgGroups.Rows[e.RowIndex].Cells[0].Value;
            selectedGroup=_context.StudentGroups.Include(x=>x.Teacher).Include(x=>x.Specialities).FirstOrDefault(x=>x.ID == groupId);
            if(selectedGroup != null)
            {
                txtNumber.Text = selectedGroup.Number;
                cmbTeachers.Text = selectedGroup.Teacher.FullName;
                cmbSpecialities.Text = selectedGroup.Specialities.Name;
                dtStart.Value = selectedGroup.StartDate.Value;
            }
            VisibileBtn("a");
        }
    }
}
