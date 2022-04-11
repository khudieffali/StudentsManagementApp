namespace StudentsForm
{
    partial class StudentList
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
            this.dtgStudentList = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPhoneSearch = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.ckSale = new System.Windows.Forms.CheckBox();
            this.ckIsDiscount = new System.Windows.Forms.CheckBox();
            this.pckBack = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cmbStudentGroup = new System.Windows.Forms.ComboBox();
            this.nmRestAmount = new System.Windows.Forms.NumericUpDown();
            this.nmTotalPayment = new System.Windows.Forms.NumericUpDown();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudentList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pckBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmRestAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTotalPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgStudentList
            // 
            this.dtgStudentList.AllowUserToOrderColumns = true;
            this.dtgStudentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgStudentList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStudentList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgStudentList.Location = new System.Drawing.Point(0, 281);
            this.dtgStudentList.Name = "dtgStudentList";
            this.dtgStudentList.RowHeadersWidth = 51;
            this.dtgStudentList.RowTemplate.Height = 29;
            this.dtgStudentList.Size = new System.Drawing.Size(1209, 343);
            this.dtgStudentList.TabIndex = 0;
            this.dtgStudentList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgStudentList_RowHeaderMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPhoneSearch);
            this.panel1.Controls.Add(this.txtPhoneNumber);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.dtRegisterDate);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.ckSale);
            this.panel1.Controls.Add(this.ckIsDiscount);
            this.panel1.Controls.Add(this.pckBack);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.cmbStudentGroup);
            this.panel1.Controls.Add(this.nmRestAmount);
            this.panel1.Controls.Add(this.nmTotalPayment);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtFatherName);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1191, 275);
            this.panel1.TabIndex = 1;
            // 
            // txtPhoneSearch
            // 
            this.txtPhoneSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhoneSearch.Location = new System.Drawing.Point(934, 146);
            this.txtPhoneSearch.Name = "txtPhoneSearch";
            this.txtPhoneSearch.Size = new System.Drawing.Size(222, 30);
            this.txtPhoneSearch.TabIndex = 31;
            this.txtPhoneSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPhoneSearch_KeyUp);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhoneNumber.Location = new System.Drawing.Point(651, 39);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(222, 30);
            this.txtPhoneNumber.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(934, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 28);
            this.label8.TabIndex = 30;
            this.label8.Text = "Nömrə ilə axtarış";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(651, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 28);
            this.label12.TabIndex = 30;
            this.label12.Text = "Telefon";
            // 
            // dtRegisterDate
            // 
            this.dtRegisterDate.CalendarFont = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtRegisterDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtRegisterDate.Location = new System.Drawing.Point(335, 245);
            this.dtRegisterDate.Name = "dtRegisterDate";
            this.dtRegisterDate.Size = new System.Drawing.Size(223, 30);
            this.dtRegisterDate.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(334, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 28);
            this.label11.TabIndex = 28;
            this.label11.Text = "Qeydiyyat tarixi";
            // 
            // ckSale
            // 
            this.ckSale.AutoSize = true;
            this.ckSale.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckSale.ForeColor = System.Drawing.Color.White;
            this.ckSale.Location = new System.Drawing.Point(768, 91);
            this.ckSale.Name = "ckSale";
            this.ckSale.Size = new System.Drawing.Size(84, 27);
            this.ckSale.TabIndex = 3;
            this.ckSale.Text = "Güzəşt";
            this.ckSale.UseVisualStyleBackColor = true;
            // 
            // ckIsDiscount
            // 
            this.ckIsDiscount.AutoSize = true;
            this.ckIsDiscount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ckIsDiscount.ForeColor = System.Drawing.Color.White;
            this.ckIsDiscount.Location = new System.Drawing.Point(651, 91);
            this.ckIsDiscount.Name = "ckIsDiscount";
            this.ckIsDiscount.Size = new System.Drawing.Size(90, 27);
            this.ckIsDiscount.TabIndex = 3;
            this.ckIsDiscount.Text = "Endirim";
            this.ckIsDiscount.UseVisualStyleBackColor = true;
            // 
            // pckBack
            // 
            this.pckBack.Image = global::StudentsForm.Properties.Resources.PikPng1;
            this.pckBack.Location = new System.Drawing.Point(1141, 3);
            this.pckBack.Name = "pckBack";
            this.pckBack.Size = new System.Drawing.Size(47, 42);
            this.pckBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pckBack.TabIndex = 7;
            this.pckBack.TabStop = false;
            this.pckBack.Click += new System.EventHandler(this.pckBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(711, 220);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 49);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(686, 162);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(173, 66);
            this.btnAdd.TabIndex = 4;
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
            this.btnEdit.Location = new System.Drawing.Point(711, 133);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(119, 48);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Dəyiş";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cmbStudentGroup
            // 
            this.cmbStudentGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbStudentGroup.FormattingEnabled = true;
            this.cmbStudentGroup.Location = new System.Drawing.Point(335, 178);
            this.cmbStudentGroup.Name = "cmbStudentGroup";
            this.cmbStudentGroup.Size = new System.Drawing.Size(223, 28);
            this.cmbStudentGroup.TabIndex = 3;
            // 
            // nmRestAmount
            // 
            this.nmRestAmount.Location = new System.Drawing.Point(335, 102);
            this.nmRestAmount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmRestAmount.Name = "nmRestAmount";
            this.nmRestAmount.Size = new System.Drawing.Size(223, 27);
            this.nmRestAmount.TabIndex = 2;
            // 
            // nmTotalPayment
            // 
            this.nmTotalPayment.Location = new System.Drawing.Point(335, 37);
            this.nmTotalPayment.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmTotalPayment.Name = "nmTotalPayment";
            this.nmTotalPayment.Size = new System.Drawing.Size(223, 27);
            this.nmTotalPayment.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddress.Location = new System.Drawing.Point(3, 245);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(222, 30);
            this.txtAddress.TabIndex = 1;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFatherName.Location = new System.Drawing.Point(3, 178);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(222, 30);
            this.txtFatherName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.Location = new System.Drawing.Point(3, 102);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(222, 30);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(3, 32);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(222, 30);
            this.txtFirstName.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ünvan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ata Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(334, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Qrup";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(335, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ödənilmiş Məbləğ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(335, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ümumi Məbləğ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(785, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 28);
            this.lblUser.TabIndex = 0;
            // 
            // StudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1209, 624);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgStudentList);
            this.Controls.Add(this.lblUser);
            this.Name = "StudentList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StudentList";
            this.Load += new System.EventHandler(this.StudentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudentList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pckBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmRestAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmTotalPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgStudentList;
        private Panel panel1;
        private TextBox txtFatherName;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown nmRestAmount;
        private NumericUpDown nmTotalPayment;
        private Label label5;
        private Label label4;
        private Button btnDelete;
        private Button btnEdit;
        private ComboBox cmbStudentGroup;
        private Label label6;
        private Label lblUser;
        private PictureBox pckBack;
        private Button btnAdd;
        private TextBox txtAddress;
        private Label label7;
        private CheckBox ckSale;
        private CheckBox ckIsDiscount;
        private DateTimePicker dtRegisterDate;
        private Label label11;
        private TextBox txtPhoneNumber;
        private Label label12;
        private TextBox txtPhoneSearch;
        private Label label8;
    }
}