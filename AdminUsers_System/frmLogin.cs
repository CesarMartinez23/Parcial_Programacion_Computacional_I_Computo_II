using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Librerias Utilizadas
using MySql.Data.MySqlClient;

namespace AdminUsers_System
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public static string UserName = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            user._userName = txtUserNameLogin.Text;
            user._passwordUser = txtPasswordLogin.Text;
            user._timeLoggedln = Convert.ToString(DateTime.Now);

            if (user.loginUser() == true)
            {
                UserName = txtUserNameLogin.Text;
                user.insertUserLog();
                new frmMenu().Show();
                this.Hide();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "lo sentimos, debes estar registrado, para poder iniciar sesión.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                txtPasswordLogin.PasswordChar = '\0';
            }
            else
            {
                txtPasswordLogin.PasswordChar = Convert.ToChar('*');
            }
        }

        private void lblGoRegister_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }
    }
}
