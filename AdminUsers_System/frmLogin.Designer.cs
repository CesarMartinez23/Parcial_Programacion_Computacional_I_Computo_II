
namespace AdminUsers_System
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUserNameLogin = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.lblGoRegister = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.txtPasswordLogin = new System.Windows.Forms.TextBox();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserNameLogin
            // 
            this.txtUserNameLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtUserNameLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserNameLogin.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNameLogin.Location = new System.Drawing.Point(8, 220);
            this.txtUserNameLogin.Name = "txtUserNameLogin";
            this.txtUserNameLogin.Size = new System.Drawing.Size(261, 27);
            this.txtUserNameLogin.TabIndex = 1;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(70)))), ((int)(((byte)(180)))));
            this.labelUsername.Location = new System.Drawing.Point(11, 192);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(109, 25);
            this.labelUsername.TabIndex = 30;
            this.labelUsername.Text = "User Name";
            // 
            // lblGoRegister
            // 
            this.lblGoRegister.AutoSize = true;
            this.lblGoRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGoRegister.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(70)))), ((int)(((byte)(180)))));
            this.lblGoRegister.Location = new System.Drawing.Point(59, 452);
            this.lblGoRegister.Name = "lblGoRegister";
            this.lblGoRegister.Size = new System.Drawing.Size(165, 23);
            this.lblGoRegister.TabIndex = 5;
            this.lblGoRegister.Text = "Go to Register UGB";
            this.lblGoRegister.Click += new System.EventHandler(this.lblGoRegister_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "I don\'t have account in UGB";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(8, 369);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(261, 44);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxShowPassword.FlatAppearance.BorderSize = 0;
            this.checkBoxShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxShowPassword.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowPassword.ForeColor = System.Drawing.Color.Gray;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(142, 330);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(131, 23);
            this.checkBoxShowPassword.TabIndex = 3;
            this.checkBoxShowPassword.Text = "Show Password";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // txtPasswordLogin
            // 
            this.txtPasswordLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtPasswordLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasswordLogin.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordLogin.Location = new System.Drawing.Point(8, 297);
            this.txtPasswordLogin.Name = "txtPasswordLogin";
            this.txtPasswordLogin.PasswordChar = '*';
            this.txtPasswordLogin.Size = new System.Drawing.Size(261, 27);
            this.txtPasswordLogin.TabIndex = 2;
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(70)))), ((int)(((byte)(180)))));
            this.LabelPassword.Location = new System.Drawing.Point(11, 269);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(96, 25);
            this.LabelPassword.TabIndex = 24;
            this.LabelPassword.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdminUsers_System.Properties.Resources.logo_ugb;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(70)))), ((int)(((byte)(200)))));
            this.label1.Location = new System.Drawing.Point(71, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Login UGB";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 487);
            this.Controls.Add(this.txtUserNameLogin);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.lblGoRegister);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.txtPasswordLogin);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmLogin";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserNameLogin;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label lblGoRegister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.TextBox txtPasswordLogin;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

