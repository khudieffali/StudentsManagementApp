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
    public partial class CostsList : Form
    {
        private readonly StudentDbContext _context = new();
        Cost selectedCost;
        public CostsList()
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
            }
            else
            {
                btnAdd.Visible = true;
                btnEdit.Visible = false;
            }
        }
        #endregion

        #region ClearText
        private void ClearText()
        {
            txtTitle.Text = "";
            nmCostPrice.Value = 0;
            dtCostDate.Value = DateTime.Now;
        }
        #endregion

        #region FillGrid
        private void FillGridCosts()
        {
            dtgCosts.DataSource = _context.Costs.Select(x => new
            {
                x.ID,
                Başlıq = x.Title,
                Məbləğ = x.CostPrice,
                Tarix = x.CostDate
            }).ToList();
            dtgCosts.Columns[0].Visible = false;
            for (int i = 0; i < dtgCosts.RowCount; i++)
            {
                if (i % 2 == 0)
                {
                    dtgCosts.Rows[i].DefaultCellStyle.BackColor = Color.DarkCyan;
                    dtgCosts.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }

            }
        }
        #endregion

        #region CostCrud
        private void AddCost()
        {
            string title=txtTitle.Text;
            decimal price=nmCostPrice.Value;
            DateTime date = dtCostDate.Value;
            string[] arr = { title, price.ToString() };
            if (Utilities.IsEmpty(arr))
            {
                Cost newCost = new()
                {
                    Title = title,
                    CostPrice = price,
                    CostDate = date,
                };
                _context.Costs.Add(newCost);
                _context.SaveChanges();
                MessageBox.Show("Xərc uğurla əlavə edildi!", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillGridCosts();
                ClearText();
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa xanaları tam doldurun", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Edit()
        {
            string title = txtTitle.Text;
            decimal price = nmCostPrice.Value;
            DateTime date = dtCostDate.Value;
            string[] arr = { title, price.ToString() };
            if (Utilities.IsEmpty(arr))
            {
                selectedCost.Title = title;
                selectedCost.CostPrice = price;
                selectedCost.CostDate = date;
                _context.SaveChanges();
                MessageBox.Show("Dəyişiklik uğurla saxlanıldı", "Uğurlu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillGridCosts();
                ClearText();
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa xanaları tam doldurun", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
         
        private void FindTotalCost()
        {
            decimal totalPrice = 0;
            for (int i = 0; i < dtgCosts.RowCount; i++)
            {
                decimal CostPrice = (decimal)dtgCosts.Rows[i].Cells[2].Value;
                totalPrice += CostPrice;

            }
            lblTotalPayment.Text = totalPrice.ToString();
        }
        private void CostsList_Load(object sender, EventArgs e)
        {
            FillGridCosts();
            FindTotalCost();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCost();
            FindTotalCost();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
            FindTotalCost();
        }

        private void dtgCosts_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int costId = (int)dtgCosts.Rows[e.RowIndex].Cells[0].Value;
            selectedCost = _context.Costs.FirstOrDefault(x => x.ID == costId);
            if (selectedCost != null)
            {
                txtTitle.Text = selectedCost.Title;
                nmCostPrice.Value = selectedCost.CostPrice;
                dtCostDate.Value = selectedCost.CostDate;
            }
            VisibileBtn("a");
        }

        private void pckBack_Click(object sender, EventArgs e)
        {
            ClearText();
            VisibileBtn("b");
        }
    }
}
