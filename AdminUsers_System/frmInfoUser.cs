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
    public partial class frmInfoUser : MetroFramework.Forms.MetroForm
    {
        public frmInfoUser()
        {
            InitializeComponent();
        }

        private void frmInfoUser_Load(object sender, EventArgs e)
        {
            User user = new User();

            /*Cuando hago la recepcion de una variable estatica (static) de otro formulario no debo obtenerla por instancia de objeto, si no solo hacer la referenica de clase y variable*/
            user._userName = frmLogin.UserName;


            MySqlDataReader dataReader = user.getByUserName();

            while (dataReader.Read())
            {
                labelUserNameProfileUser.Text = "User Name: " + dataReader.GetValue(5).ToString();
                labelFirstNameProfileUser.Text = "First Name: " + dataReader.GetValue(1).ToString();
                labelLastNameProfileUser.Text = "Last Name: " + dataReader.GetValue(2).ToString();
                labelEmailProfileUser.Text = "E-mail: " + dataReader.GetValue(3).ToString();
                labelRegisterDateProfileUser.Text = "Register Date: " + dataReader.GetValue(4).ToString();

            }
        }

        private void ReturnMenu_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            this.Hide();
        }
    }
}
