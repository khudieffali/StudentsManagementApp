namespace StudentsForm
{
    partial class CostsList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nmCostPrice = new System.Windows.Forms.NumericUpDown();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtCostDate = new System.Windows.Forms.DateTimePicker();
            this.dtgCosts = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblTotalPayment = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pckBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmCostPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCosts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pckBack)).BeginInit();
            this.SuspendLayout();
            // 
            // nmCostPrice
            // 
            this.nmCostPrice.Location = new System.Drawing.Point(322, 74);
            this.nmCostPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmCostPrice.Name = "nmCostPrice";
            this.nmCostPrice.Size = new System.Drawing.Size(223, 27);
            this.nmCostPrice.TabIndex = 7;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTitle.Location = new System.Drawing.Point(12, 73);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(222, 30);
            this.txtTitle.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(322, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Məbləğ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Başlıq";
            // 
            // dtCostDate
            // 
            this.dtCostDate.Location = new System.Drawing.Point(622, 74);
            this.dtCostDate.Name = "dtCostDate";
            this.dtCostDate.Size = new System.Drawing.Size(250, 27);
            this.dtCostDate.TabIndex = 8;
            // 
            // dtgCosts
            // 
            this.dtgCosts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCosts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgCosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCosts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgCosts.Location = new System.Drawing.Point(0, 245);
            this.dtgCosts.Name = "dtgCosts";
            this.dtgCosts.RowHeadersWidth = 51;
            this.dtgCosts.RowTemplate.Height = 29;
            this.dtgCosts.Size = new System.Drawing.Size(887, 243);
            this.dtgCosts.TabIndex = 9;
            this.dtgCosts.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgCosts_RowHeaderMouseDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(622, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tarix";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(745, 128);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 56);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Əlavə Et";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Orange;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(753, 136);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(119, 48);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Dəyiş";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.AutoSize = true;
            this.lblTotalPayment.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPayment.ForeColor = System.Drawing.Color.White;
            this.lblTotalPayment.Location = new System.Drawing.Point(806, 214);
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(62, 25);
            this.lblTotalPayment.TabIndex = 13;
            this.lblTotalPayment.Text = "xərclər";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(666, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ümumi xərclər :";
            // 
            // pckBack
            // 
            this.pckBack.Image = global::StudentsForm.Properties.Resources.PikPng2;
            this.pckBack.Location = new System.Drawing.Point(823, 2);
            this.pckBack.Name = "pckBack";
            this.pckBack.Size = new System.Drawing.Size(52, 46);
            this.pckBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pckBack.TabIndex = 26;
            this.pckBack.TabStop = false;
            this.pckBack.Click += new System.EventHandler(this.pckBack_Click);
            // 
            // CostsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(887, 488);
            this.Controls.Add(this.pckBack);
            this.Controls.Add(this.lblTotalPayment);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dtgCosts);
            this.Controls.Add(this.dtCostDate);
            this.Controls.Add(this.nmCostPrice);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CostsList";
            this.Text = "CostsList";
            this.Load += new System.EventHandler(this.CostsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmCostPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCosts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pckBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown nmCostPrice;
        private TextBox txtTitle;
        private Label label4;
        private Label label1;
        private DateTimePicker dtCostDate;
        private DataGridView dtgCosts;
        private Label label2;
        private Button btnAdd;
        private Button btnEdit;
        private Label lblTotalPayment;
        private Label label3;
        private PictureBox pckBack;
    }
}