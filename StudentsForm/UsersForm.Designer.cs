namespace StudentsForm
{
    partial class UsersForm
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
            this.dtgUsers = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.pckBack = new System.Windows.Forms.PictureBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPas = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pckFalse = new System.Windows.Forms.PictureBox();
            this.pckTrue = new System.Windows.Forms.PictureBox();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pckBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pckFalse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pckTrue)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgUsers
            // 
            this.dtgUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsers.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtgUsers.Location = new System.Drawing.Point(660, 0);
            this.dtgUsers.Name = "dtgUsers";
            this.dtgUsers.RowHeadersWidth = 51;
            this.dtgUsers.RowTemplate.Height = 29;
            this.dtgUsers.Size = new System.Drawing.Size(597, 551);
            this.dtgUsers.TabIndex = 0;
            this.dtgUsers.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgUsers_RowHeaderMouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(123, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(418, 62);
            this.label4.TabIndex = 8;
            this.label4.Text = "Compar Academy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(340, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "İstifadəçi adı";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUserName.Location = new System.Drawing.Point(282, 135);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(263, 31);
            this.txtUserName.TabIndex = 10;
            // 
            // pckBack
            // 
            this.pckBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pckBack.Image = global::StudentsForm.Properties.Resources.PikPng_com_clean_icon_png_4296879;
            this.pckBack.Location = new System.Drawing.Point(598, 59);
            this.pckBack.Name = "pckBack";
            this.pckBack.Size = new System.Drawing.Size(56, 51);
            this.pckBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pckBack.TabIndex = 16;
            this.pckBack.TabStop = false;
            this.pckBack.Click += new System.EventHandler(this.pckBack_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(340, 464);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(145, 63);
            this.btnCreate.TabIndex = 19;
            this.btnCreate.Text = "Əlavə Et";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(478, 472);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 49);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Orange;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(230, 473);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(119, 48);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Dəyiş";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFullName.Location = new System.Drawing.Point(282, 218);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(263, 31);
            this.txtFullName.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(354, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 31);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ad, Soyad";
            // 
            // lblPas
            // 
            this.lblPas.AutoSize = true;
            this.lblPas.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPas.ForeColor = System.Drawing.Color.White;
            this.lblPas.Location = new System.Drawing.Point(354, 269);
            this.lblPas.Name = "lblPas";
            this.lblPas.Size = new System.Drawing.Size(115, 31);
            this.lblPas.TabIndex = 9;
            this.lblPas.Text = "Yeni Şifrə";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(281, 303);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(263, 31);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // pckFalse
            // 
            this.pckFalse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pckFalse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pckFalse.Image = global::StudentsForm.Properties.Resources.show_password_icon_19;
            this.pckFalse.Location = new System.Drawing.Point(550, 297);
            this.pckFalse.Name = "pckFalse";
            this.pckFalse.Size = new System.Drawing.Size(53, 44);
            this.pckFalse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pckFalse.TabIndex = 22;
            this.pckFalse.TabStop = false;
            this.pckFalse.Click += new System.EventHandler(this.pckFalse_Click);
            // 
            // pckTrue
            // 
            this.pckTrue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pckTrue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pckTrue.Image = global::StudentsForm.Properties.Resources.show_password_icon_18__1_;
            this.pckTrue.Location = new System.Drawing.Point(550, 297);
            this.pckTrue.Name = "pckTrue";
            this.pckTrue.Size = new System.Drawing.Size(53, 44);
            this.pckTrue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pckTrue.TabIndex = 23;
            this.pckTrue.TabStop = false;
            this.pckTrue.Visible = false;
            this.pckTrue.Click += new System.EventHandler(this.pckTrue_Click);
            // 
            // cmbRoles
            // 
            this.cmbRoles.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(282, 385);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(263, 33);
            this.cmbRoles.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(356, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 31);
            this.label5.TabIndex = 24;
            this.label5.Text = "Vəzifələr";
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOldPassword.ForeColor = System.Drawing.Color.White;
            this.lblOldPassword.Location = new System.Drawing.Point(69, 269);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(139, 31);
            this.lblOldPassword.TabIndex = 9;
            this.lblOldPassword.Text = "Köhnə Şifrə";
            this.lblOldPassword.Visible = false;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOldPassword.Location = new System.Drawing.Point(9, 303);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(263, 31);
            this.txtOldPassword.TabIndex = 10;
            this.txtOldPassword.UseSystemPasswordChar = true;
            this.txtOldPassword.Visible = false;
            this.txtOldPassword.TextChanged += new System.EventHandler(this.txtOldPassword_TextChanged);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1257, 551);
            this.Controls.Add(this.cmbRoles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pckFalse);
            this.Controls.Add(this.pckTrue);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pckBack);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblOldPassword);
            this.Controls.Add(this.lblPas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgUsers);
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pckBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pckFalse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pckTrue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgUsers;
        private Label label4;
        private Label label2;
        private TextBox txtUserName;
        private PictureBox pckBack;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnEdit;
        private TextBox txtFullName;
        private Label label1;
        private Label lblPas;
        private TextBox txtPassword;
        private PictureBox pckFalse;
        private PictureBox pckTrue;
        private ComboBox cmbRoles;
        private Label label5;
        private Label lblOldPassword;
        private TextBox txtOldPassword;
    }
}