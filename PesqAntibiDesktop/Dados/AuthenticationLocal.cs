using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public abstract class AuthenticationLocal
    {

        public static bool IsAuthenticated = false;
        public static int? userId = null;
        public static string? username = null;

        public static bool userAccountExists(string username)
        {
            string selectCommand = "SELECT * FROM usuario WHERE username = @username";

            SqlConnection connection = new SqlConnection(DataAdapter.connectionString);

            SqlCommand sqlCommand = new SqlCommand(selectCommand, connection);
            sqlCommand.Parameters.AddWithValue("@username", username);

            SqlDataAdapter sqlDataAdapter =  DataAdapter.getDataAdapteSafe(sqlCommand, new SqlDataAdapter());
            
            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                return true;
            }

            return false;
        }

        public static bool createNewUserLocal(string username, string password)
        {
            string insertCommand = "INSERT INTO usuario (username, password) VALUES (@username, @password)";
            int result;

            using (SqlConnection connection = new SqlConnection(DataAdapter.connectionString))
            {
                SqlCommand sqlCommand = new SqlCommand(insertCommand, connection);
                sqlCommand.Parameters.AddWithValue("@username", username);
                sqlCommand.Parameters.AddWithValue("@password", password);

                sqlCommand.Connection.Open();

                result = sqlCommand.ExecuteNonQuery();
            }

            if (result > 0)
            {
                return true;
            }

            return false;
        }

        public static int login(string username, string password)
        {
            if (!userAccountExists(username))
            {
                return (int) TipoMensagemLogin.USERNAME_NAO_EXISTE;
            }

            if (password == null)
            {
                return (int) TipoMensagemLogin.LOGIN_VAZIO;
            }

            if (username == null)
            {
                return (int) TipoMensagemLogin.LOGIN_VAZIO;
            }

            bool success = loginLocal(username, password);

            if (success)
            {
                return (int) TipoMensagemLogin.LOGIN_SUCESSO;
            }

            return (int) TipoMensagemLogin.LOGIN_INCORRETO;
        }

        private static bool loginLocal(string username, string password)
        {
            string selectCommand = "SELECT * FROM usuario WHERE username = @username AND password = @password";

            SqlConnection connection = new SqlConnection(DataAdapter.connectionString);

            SqlCommand sqlCommand = new SqlCommand(selectCommand, connection);
            sqlCommand.Parameters.AddWithValue("@username", username);
            sqlCommand.Parameters.AddWithValue("@password", password);

            SqlDataAdapter sqlDataAdapter =  DataAdapter.getDataAdapteSafe(sqlCommand, new SqlDataAdapter());
            
            DataTable dataTable = new DataTable();

            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                IsAuthenticated = true;
                userId = (int)dataTable.Rows[0]["id"];
                username = (string)dataTable.Rows[0]["username"];
                return true;
            }

            return false;
        }
    }
}
