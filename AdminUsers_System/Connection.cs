using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Librerias Utilizadas
using MySql.Data.MySqlClient;
using System.Data;

namespace AdminUsers_System
{
    class Connection
    {
        private MySqlConnection conn =
         //Nuestra password es "" vacia porque estamos usando Wampp entonces no le hemos asignado un password.
         new MySqlConnection("Server=localhost;Database=adminusers;Uid=root;Pwd=; SSL MODE= None");

        public MySqlCommand command;

        //Habilitar conexcion a la BD
        public MySqlConnection openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        //Desabilitar conexcion a la BD
        public MySqlConnection closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            return conn;
        }
    }
}
