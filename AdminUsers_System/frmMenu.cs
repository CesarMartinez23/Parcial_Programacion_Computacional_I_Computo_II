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
    public partial class frmMenu : MetroFramework.Forms.MetroForm
    {

        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if (frmLogin.UserName.ToString() == "admin")
            {

            }
            else
            {
                OptionMenuOtherUser();
            }
        }

        private void metroTilefrmProfileUser_Click(object sender, EventArgs e)
        {
            new frmInfoUser().Show();
            this.Hide();
        }

        private void OptionMenuOtherUser()
        {
            metroTilefrmInfoUsers.Visible = false;
            metroTilefrmInfoLogs.Visible = false;
        }

        private void metroTilefrmInfoLogs_Click(object sender, EventArgs e)
        {
            new frmLogs().Show();
            this.Hide();
        }

        private void metroTilefrmInfoUsers_Click(object sender, EventArgs e)
        {
            new frmInfoRegisterUsers().Show();
            this.Hide();
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmInfoUser().Show();
            this.Hide();
        }

        private void signInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Close();
        }
    }
}
