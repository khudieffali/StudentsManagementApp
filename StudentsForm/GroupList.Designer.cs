namespace StudentsForm
{
    partial class GroupList
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
            this.dtgGroups = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.cmbTeachers = new System.Windows.Forms.ComboBox();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pckBack = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSpecialities = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtRegisterGroup = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dtgGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pckBack)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgGroups
            // 
            this.dtgGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgGroups.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgGroups.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtgGroups.Location = new System.Drawing.Point(489, 0);
            this.dtgGroups.Name = "dtgGroups";
            this.dtgGroups.RowHeadersWidth = 51;
            this.dtgGroups.RowTemplate.Height = 29;
            this.dtgGroups.Size = new System.Drawing.Size(688, 577);
            this.dtgGroups.TabIndex = 0;
            this.dtgGroups.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgGroups_RowHeaderMouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(418, 62);
            this.label4.TabIndex = 7;
            this.label4.Text = "Compar Academy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(182, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Qrup Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(170, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Müəllimlər";
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumber.Location = new System.Drawing.Point(105, 105);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(263, 31);
            this.txtNumber.TabIndex = 9;
            // 
            // cmbTeachers
            // 
            this.cmbTeachers.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTeachers.FormattingEnabled = true;
            this.cmbTeachers.Location = new System.Drawing.Point(105, 181);
            this.cmbTeachers.Name = "cmbTeachers";
            this.cmbTeachers.Size = new System.Drawing.Size(263, 33);
            this.cmbTeachers.TabIndex = 10;
            // 
            // dtStart
            // 
            this.dtStart.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtStart.Location = new System.Drawing.Point(106, 429);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(263, 31);
            this.dtStart.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(148, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Başlama Tarixi";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(148, 486);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(145, 63);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "Əlavə Et";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Orange;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(160, 494);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(119, 48);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Dəyiş";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pckBack
            // 
            this.pckBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pckBack.Image = global::StudentsForm.Properties.Resources.PikPng_com_clean_icon_png_4296879;
            this.pckBack.Location = new System.Drawing.Point(428, 65);
            this.pckBack.Name = "pckBack";
            this.pckBack.Size = new System.Drawing.Size(40, 37);
            this.pckBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pckBack.TabIndex = 15;
            this.pckBack.TabStop = false;
            this.pckBack.Click += new System.EventHandler(this.pckBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(183, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 31);
            this.label5.TabIndex = 8;
            this.label5.Text = "İxtisaslar";
            // 
            // cmbSpecialities
            // 
            this.cmbSpecialities.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSpecialities.FormattingEnabled = true;
            this.cmbSpecialities.Location = new System.Drawing.Point(105, 273);
            this.cmbSpecialities.Name = "cmbSpecialities";
            this.cmbSpecialities.Size = new System.Drawing.Size(263, 33);
            this.cmbSpecialities.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(142, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "Yaradılma Tarixi";
            // 
            // dtRegisterGroup
            // 
            this.dtRegisterGroup.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtRegisterGroup.Location = new System.Drawing.Point(106, 353);
            this.dtRegisterGroup.Name = "dtRegisterGroup";
            this.dtRegisterGroup.Size = new System.Drawing.Size(263, 31);
            this.dtRegisterGroup.TabIndex = 11;
            // 
            // GroupList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1177, 577);
            this.Controls.Add(this.pckBack);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dtRegisterGroup);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.cmbSpecialities);
            this.Controls.Add(this.cmbTeachers);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgGroups);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "GroupList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GroupList";
            this.Load += new System.EventHandler(this.GroupList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pckBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgGroups;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtNumber;
        private ComboBox cmbTeachers;
        private DateTimePicker dtStart;
        private Label label3;
        private Button btnCreate;
        private Button btnEdit;
        private PictureBox pckBack;
        private Label label5;
        private ComboBox cmbSpecialities;
        private Label label6;
        private DateTimePicker dtRegisterGroup;
    }
}