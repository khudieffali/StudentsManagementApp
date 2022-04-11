namespace StudentsForm
{
    partial class LoginForm
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
            this.pckCompar = new System.Windows.Forms.PictureBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pckTrue = new System.Windows.Forms.PictureBox();
            this.pckFalse = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pckCompar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pckTrue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pckFalse)).BeginInit();
            this.SuspendLayout();
            // 
            // pckCompar
            // 
            this.pckCompar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pckCompar.Image = global::StudentsForm.Properties.Resources.compar_100;
            this.pckCompar.Location = new System.Drawing.Point(0, 0);
            this.pckCompar.Name = "pckCompar";
            this.pckCompar.Size = new System.Drawing.Size(553, 163);
            this.pckCompar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pckCompar.TabIndex = 0;
            this.pckCompar.TabStop = false;
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.Location = new System.Drawing.Point(199, 259);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(162, 26);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "İstifadəçi Adı :";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(230, 369);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 26);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = " Şifrə :";
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLogin.Location = new System.Drawing.Point(136, 300);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(288, 30);
            this.txtLogin.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.HideSelection = false;
            this.txtPassword.Location = new System.Drawing.Point(136, 415);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(288, 30);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(219, 477);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(113, 44);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Daxil ol";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pckTrue
            // 
            this.pckTrue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pckTrue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pckTrue.Image = global::StudentsForm.Properties.Resources.show_password_icon_18__1_;
            this.pckTrue.Location = new System.Drawing.Point(429, 411);
            this.pckTrue.Name = "pckTrue";
            this.pckTrue.Size = new System.Drawing.Size(52, 41);
            this.pckTrue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pckTrue.TabIndex = 4;
            this.pckTrue.TabStop = false;
            this.pckTrue.Visible = false;
            this.pckTrue.Click += new System.EventHandler(this.pckTrue_Click);
            // 
            // pckFalse
            // 
            this.pckFalse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pckFalse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pckFalse.Image = global::StudentsForm.Properties.Resources.show_password_icon_19;
            this.pckFalse.Location = new System.Drawing.Point(429, 411);
            this.pckFalse.Name = "pckFalse";
            this.pckFalse.Size = new System.Drawing.Size(52, 41);
            this.pckFalse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pckFalse.TabIndex = 4;
            this.pckFalse.TabStop = false;
            this.pckFalse.Click += new System.EventHandler(this.pckFalse_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(553, 617);
            this.Controls.Add(this.pckFalse);
            this.Controls.Add(this.pckTrue);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.pckCompar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pckCompar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pckTrue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pckFalse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pckCompar;
        private Label lblLogin;
        private Label lblPassword;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private Button btnLogin;
        private PictureBox pckTrue;
        private PictureBox pckFalse;
    }
}