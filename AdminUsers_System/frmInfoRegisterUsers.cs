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
    public partial class frmInfoRegisterUsers : MetroFramework.Forms.MetroForm
    {
        public frmInfoRegisterUsers()
        {
            InitializeComponent();
        }

        private void ReturnMenu_Click(object sender, EventArgs e)
        {
            new frmMenu().Show();
            this.Hide();
        }

        //Vaciar los registros del DataGridView
        private void clearDataGridView()
        {
            dataGridViewInfoUsers.Columns.Clear();
            dataGridViewInfoUsers.Rows.Clear();
        }

        private void fillDataGridView()
        {
            User user = new User();

            clearDataGridView();

            dataGridViewInfoUsers.Columns.Add("codUser", "ID");
            dataGridViewInfoUsers.Columns.Add("firstname", "Nombres");
            dataGridViewInfoUsers.Columns.Add("lastname", "Apellidos");
            dataGridViewInfoUsers.Columns.Add("email", "E-mail");
            dataGridViewInfoUsers.Columns.Add("reisterDate", "Fecha de Registro");
            dataGridViewInfoUsers.Columns.Add("username", "UserName");

            MySqlDataReader dataReader = user.getTableAcoount();

            //Leer el resulatdo y mostrarlo en el DataGridView
            while (dataReader.Read())
            {
                dataGridViewInfoUsers.Rows.Add(
               dataReader.GetValue(0),
               dataReader.GetValue(1),
               dataReader.GetValue(2),
               dataReader.GetValue(3),
               dataReader.GetValue(4),
               dataReader.GetValue(5));
            }
        }

        private void frmInfoRegisterUsers_Load(object sender, EventArgs e)
        {
            fillDataGridView();
        }

        private void metroToggleShowInfoAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (metroToggleShowInfoAdmin.Checked == true)
            {
                BackColor = Color.DodgerBlue;
                User user = new User();

                clearDataGridView();

                dataGridViewInfoUsers.Columns.Add("codUser", "ID");
                dataGridViewInfoUsers.Columns.Add("firstname", "Nombres");
                dataGridViewInfoUsers.Columns.Add("lastname", "Apellidos");
                dataGridViewInfoUsers.Columns.Add("email", "E-mail");
                dataGridViewInfoUsers.Columns.Add("reisterDate", "Fecha de Registro");
                dataGridViewInfoUsers.Columns.Add("username", "UserName");

                MySqlDataReader dataReader = user.getTableAcoountWithAdmin();

                //Leer el resulatdo y mostrarlo en el DataGridView
                while (dataReader.Read())
                {
                    dataGridViewInfoUsers.Rows.Add(
                   dataReader.GetValue(0),
                   dataReader.GetValue(1),
                   dataReader.GetValue(2),
                   dataReader.GetValue(3),
                   dataReader.GetValue(4),
                   dataReader.GetValue(5));
                }
            }
            else
            {
                fillDataGridView();
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En mantenimiento");
        }

        private void delete_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Estas seguro que deseas eliminar el al usuario seleccionado?";
            if (MetroFramework.MetroMessageBox.Show(this, mensaje, "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                User user = new User();
                user._codUser = Convert.ToInt32(dataGridViewInfoUsers.CurrentRow.Cells[0].Value);

                if (user.DeleteUser())
                {
                    MetroFramework.MetroMessageBox.Show(this, "El usuario seleccionado se ha eliminado correctamente!", "CONFIRMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    fillDataGridView();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "El usuario seleccionado no se ha podido eliminar, hubo un error, intente de nuevo!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
