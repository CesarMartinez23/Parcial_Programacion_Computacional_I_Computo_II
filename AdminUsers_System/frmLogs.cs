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
    public partial class frmLogs : MetroFramework.Forms.MetroForm
    {
        public frmLogs()
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
            dataGridViewInfoLogs.Columns.Clear();
            dataGridViewInfoLogs.Rows.Clear();
        }

        private void fillDataGridViewInfoLogs()
        {
            User user = new User();

            clearDataGridView();

            dataGridViewInfoLogs.Columns.Add("codLog", "ID Log");
            dataGridViewInfoLogs.Columns.Add("username", "Usuario");
            dataGridViewInfoLogs.Columns.Add("timeLoggedln", "Fecha Y Hora de Entrada");

            MySqlDataReader dataReader = user.getTableUserLog();

            //Leer el resulatdo y mostrarlo en el DataGridView
            while (dataReader.Read())
            {
                dataGridViewInfoLogs.Rows.Add(
               dataReader.GetValue(0),
               dataReader.GetValue(1),
               dataReader.GetValue(2));
            }
        }

        private void metroToggleMyInfoLogsAdmin_CheckedChanged(object sender, EventArgs e)
        {
            if (metroToggleMyInfoLogsAdmin.Checked == true)
            {
                BackColor = Color.DodgerBlue;
                User user = new User();

                clearDataGridView();

                dataGridViewInfoLogs.Columns.Add("codLog", "ID Log");
                dataGridViewInfoLogs.Columns.Add("username", "Usuario");
                dataGridViewInfoLogs.Columns.Add("timeLoggedln", "Fecha Y Hora de Entrada");

                MySqlDataReader dataReader = user.getTableUserLogWithAdmin();

                //Leer el resulatdo y mostrarlo en el DataGridView
                while (dataReader.Read())
                {
                    dataGridViewInfoLogs.Rows.Add(
                   dataReader.GetValue(0),
                   dataReader.GetValue(1),
                   dataReader.GetValue(2));
                }
            }
            else
            {
                fillDataGridViewInfoLogs();
            }
        }

        private void frmLogs_Load(object sender, EventArgs e)
        {
            fillDataGridViewInfoLogs();
        }
    }
}
