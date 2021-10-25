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
    public partial class frmRegister : MetroFramework.Forms.MetroForm
    {
        private string action = "";

        public frmRegister()
        {
            InitializeComponent();
        }

        public void clearControlsRegister()
        {
            txtFirsname.Text = "";
            txtLastname.Text = "";
            txtEmail.Text = "";
            txtUserName.Text = "";
            txtPassword.Text = "";
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            action = "new";

            if (txtFirsname.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "El campo First Name, se encuentra vacio, por favor completalo.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFirsname.Focus();
            }
            else if (txtLastname.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "El campo Last Name, se encuentra vacio, por favor completalo.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLastname.Focus();
            }
            else if (txtEmail.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "El campo E-mail, se encuentra vacio, por favor completalo.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
            }
            else if (txtUserName.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "El campo User Name, se encuentra vacio, por favor completalo.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MetroFramework.MetroMessageBox.Show(this, "El campo Password, se encuentra vacio, por favor completalo.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            }
            else
            {
                User user = new User();
                //user._codUser = Convert.ToInt32("");
                user._firstName = txtFirsname.Text;
                user._lasttName = txtLastname.Text;
                user._email = txtEmail.Text;
                user._registerDate = Convert.ToString(DateTime.Now);
                user._userName = txtUserName.Text;
                user._passwordUser = txtPassword.Text;

                string messageGuardar = "¿Deseas continuar y registrarte en el sistema?";
                if (MetroFramework.MetroMessageBox.Show(this, messageGuardar, "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Llamar al metodo Guardar
                    if (user.newUser(action))
                    {
                        MetroFramework.MetroMessageBox.Show(this, $"Bienvenido {txtUserName.Text}, te has registrado correctamente. ", "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, $"Lo lamentamos {txtUserName.Text},no te has podido registrar, hubo un problema, intenta de nuevo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            clearControlsRegister();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = Convert.ToChar('*');
            }
        }

        private void lblGoLogin_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
    }
}
