using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Librerias Utilizadas
using MySql.Data.MySqlClient;

namespace AdminUsers_System
{
    class User
    {
        //Register
        public int _codUser { get; set; }
        public string _firstName { get; set; }
        public string _lasttName { get; set; }
        public string _email { get; set; }
        public string _registerDate { get; set; }
        public string _userName { get; set; }
        public string _passwordUser { get; set; }
        //Login
        public string _timeLoggedln { get; set; }
        public int _codLog { get; set; }

        //Intanciar la clase BD
        private BD bd = new BD();

        //Metodo para retornar los registros de la Tabla account
        public MySqlDataReader getTableAcoount()
        {
            string query = "SELECT * FROM account WHERE username<>'admin'";

            //Llamado al metodo select de la clase BD, para extraer los datos de la tabla account.
            return bd.SelectData(query);
        }

        public MySqlDataReader getTableAcoountWithAdmin()
        {
            string query = "SELECT * FROM account";

            //Llamado al metodo select de la clase BD, para extraer los datos de la tabla account.
            return bd.SelectData(query);
        }

        //Metodo para retornar los registros de la Tabla userlog
        public MySqlDataReader getTableUserLog()
        {
            string query = "SELECT * FROM userlog WHERE username<> 'admin'";

            //Llamado al metodo select de la clase BD, para extraer los datos de la tabla userlog.
            return bd.SelectData(query);
        }

        //Metodo para retornar los registros de la Tabla userlog
        public MySqlDataReader getTableUserLogWithAdmin()
        {
            string query = "SELECT * FROM userlog";

            //Llamado al metodo select de la clase BD, para extraer los datos de la tabla userlog.
            return bd.SelectData(query);
        }


        public bool newUser(string action)
        {
            if (action == "new")
            {
                //Insertar datos en la BD.
                string query = "INSERT INTO account(codUser, firstname, lastname, email, registerDate, username, password)" +
                    "VALUES ('" + _codUser + "', '" + _firstName + "','" + _lasttName + "','" + _email + "','" + _registerDate + "','" + _userName + "','" + _passwordUser + "')";
                //Llamado al metodo ExecuteQuery de la Clase BD
                bd.ExecuteQuery(query);
                return true;
            }
            return false;
            /* Se dejara esta parte de codigo, para integrarlo en ese proyecto
             * else if (action == "edit")
            {
                //Editar datos en la BD.
                string query = "UPDATE acoount SET "
                    + "firstname='" + _firstName + "',"
                    + "lastname='" + _lasttName + "',"
                    + "email='" + _email + "',"
                    + "username='" + _userName + "',"
                    + "password='" + _passwordUser + "'"
                    + "WHERE "
                    + "codUser='" + _codUser + "'";
                //Llamado al metodo ExecuteQuery de la Clase BD
                bd.ExecuteQuery(query);
                return true;
            }
            */
        }

        //Metodo para eliminar los registros de nuestra tabla account de la BD.
        public Boolean DeleteUser()
        {
            string query = "DELETE FROM account WHERE codUser='" + _codUser + "'";
            bd.ExecuteQuery(query);
            return true;
        }

        //Para verificar que el usuario se encuentre en los registros de la Base de Datos.
        public Boolean loginUser()
        {
            string query = "SELECT username, password FROM account WHERE username='" + _userName + "' AND password='" + _passwordUser + "'";

            if (bd.SelectData(query).HasRows)
            {
                return true;
            }
            return false;
        }

        //Metodo para insertar los datos de registros de los usuarios al iniciar sesion.
        public void insertUserLog()
        {
            string insertuserlog = "INSERT INTO userlog(codLog, username, timeLoggedln)" +
                "VALUES('" + _codLog + "','" + _userName + "','" + _timeLoggedln + "')";
            bd.ExecuteQuery(insertuserlog);
        }

        public MySqlDataReader getByUserName()
        {
            string query = "SELECT * FROM account WHERE username='" + _userName + "'";

            return bd.SelectData(query);
        }
    }
}
