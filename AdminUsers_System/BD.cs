using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Librerias Utilizadas
using MySql.Data.MySqlClient;

namespace AdminUsers_System
{
    class BD
    {
        //Instanciar la clase Connection de la BD
        private Connection connection = new Connection();

        //Metodo para selecionar los registros de la tabla de la BD
        public MySqlDataReader SelectData(string query)
        {
            MySqlDataReader dataReader;

            //Utilizar command de la clase Connection
            connection.command = new MySqlCommand(query, connection.openConnection());
            dataReader = connection.command.ExecuteReader();
            return dataReader;
        }

        //Metodo Ejecutar consultas SQL para insertar, editar y eliminar un Usuario.
        public void ExecuteQuery(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            connection.command = new MySqlCommand(query, connection.closeConnection());
            connection.openConnection();
            adapter.InsertCommand = connection.command;
            adapter.InsertCommand.ExecuteNonQuery();
            connection.command.Dispose();
            connection.closeConnection();
        }
    }
}
