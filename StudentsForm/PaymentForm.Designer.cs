namespace StudentsForm
{
    partial class PaymentForm
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
            this.dtgPayment = new System.Windows.Forms.DataGridView();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.nmPayment = new System.Windows.Forms.NumericUpDown();
            this.lblPay = new System.Windows.Forms.Label();
            this.pckBack = new System.Windows.Forms.PictureBox();
            this.dtPayment = new System.Windows.Forms.DateTimePicker();
            this.lblPayDate = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pckBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPayment
            // 
            this.dtgPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPayment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPayment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgPayment.Location = new System.Drawing.Point(0, 237);
            this.dtgPayment.Name = "dtgPayment";
            this.dtgPayment.RowHeadersWidth = 51;
            this.dtgPayment.RowTemplate.Height = 29;
            this.dtgPayment.Size = new System.Drawing.Size(1079, 327);
            this.dtgPayment.TabIndex = 0;
            this.dtgPayment.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgPayment_RowHeaderMouseDoubleClick);
            // 
            // cmbStudent
            // 
            this.cmbStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbStudent.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(12, 119);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(284, 33);
            this.cmbStudent.TabIndex = 1;
            this.cmbStudent.SelectedIndexChanged += new System.EventHandler(this.cmbStudent_SelectedIndexChanged);
            this.cmbStudent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbStudent_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tələbələr";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(344, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(418, 62);
            this.label4.TabIndex = 11;
            this.label4.Text = "Compar Academy";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(922, 167);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 49);
            this.btnDelete.TabIndex = 21;
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
            this.btnEdit.Location = new System.Drawing.Point(922, 85);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(119, 48);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Dəyiş";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // nmPayment
            // 
            this.nmPayment.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nmPayment.Location = new System.Drawing.Point(329, 119);
            this.nmPayment.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmPayment.Name = "nmPayment";
            this.nmPayment.Size = new System.Drawing.Size(284, 31);
            this.nmPayment.TabIndex = 24;
            this.nmPayment.Visible = false;
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPay.ForeColor = System.Drawing.Color.White;
            this.lblPay.Location = new System.Drawing.Point(329, 85);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(181, 31);
            this.lblPay.TabIndex = 10;
            this.lblPay.Text = "Ödəniş məbləği";
            this.lblPay.Visible = false;
            // 
            // pckBack
            // 
            this.pckBack.Image = global::StudentsForm.Properties.Resources.PikPng2;
            this.pckBack.Location = new System.Drawing.Point(1015, 25);
            this.pckBack.Name = "pckBack";
            this.pckBack.Size = new System.Drawing.Size(52, 46);
            this.pckBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pckBack.TabIndex = 25;
            this.pckBack.TabStop = false;
            this.pckBack.Click += new System.EventHandler(this.pckBack_Click);
            // 
            // dtPayment
            // 
            this.dtPayment.CalendarFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtPayment.Location = new System.Drawing.Point(638, 120);
            this.dtPayment.Name = "dtPayment";
            this.dtPayment.Size = new System.Drawing.Size(250, 27);
            this.dtPayment.TabIndex = 26;
            this.dtPayment.Visible = false;
            // 
            // lblPayDate
            // 
            this.lblPayDate.AutoSize = true;
            this.lblPayDate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPayDate.ForeColor = System.Drawing.Color.White;
            this.lblPayDate.Location = new System.Drawing.Point(638, 85);
            this.lblPayDate.Name = "lblPayDate";
            this.lblPayDate.Size = new System.Drawing.Size(153, 31);
            this.lblPayDate.TabIndex = 10;
            this.lblPayDate.Text = "Ödəniş Tarixi";
            this.lblPayDate.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::StudentsForm.Properties.Resources._38bk2udqspkggdn6dsrg2d1bos;
            this.pictureBox2.Location = new System.Drawing.Point(12, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1079, 564);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dtPayment);
            this.Controls.Add(this.pckBack);
            this.Controls.Add(this.nmPayment);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPayDate);
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbStudent);
            this.Controls.Add(this.dtgPayment);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pckBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtgPayment;
        private ComboBox cmbStudent;
        private Label label2;
        private Label label4;
        private Button btnDelete;
        private Button btnEdit;
        private NumericUpDown nmPayment;
        private Label lblPay;
        private PictureBox pckBack;
        private DateTimePicker dtPayment;
        private Label lblPayDate;
        private PictureBox pictureBox2;
    }
}