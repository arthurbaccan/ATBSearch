using MySql.Data.MySqlClient;
using Mysqlx.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public abstract class AuthenticationCloud
    {

        public static bool IsAuthenticated = false;
        public static int? userId = null;
        public static string? email = null;
        public static string? cellphone = null;

        public static void cleanAuthentication()
        {
            IsAuthenticated = false;
            userId = null;
            email = null;
            cellphone = null;

        }

        public static bool userAccountExists(string credentialEmailCellphone)
        {
            string selectCommand = "SELECT * FROM Usuario WHERE (email = @credentialEmailCellphone OR telefone = @credentialEmailCellphone)";

            MySqlConnection connection = new MySqlConnection(DataAdapter.connectionStringMySql);

            MySqlDataReader reader;
            using MySqlCommand cmd = new MySqlCommand(selectCommand, connection);
            {
                connection.Open();
                cmd.Parameters.AddWithValue("@credentialEmailCellphone", credentialEmailCellphone);
                reader = cmd.ExecuteReader();
            }

            if (reader.HasRows)
            {
                return true;
            }

            return false;
        }

        public static int login(string credentialEmailCellphone, string password, bool checkInternetConnection)
        {
            if (checkInternetConnection) InternetConnectionChecker.isInternetConnected();

            if (InternetConnectionChecker.wasThereConnection)
            {
                return loginWithInternet(credentialEmailCellphone, password);
            }

            return (int) TipoMensagemLogin.SEM_CONEXAO_INTERNET;
        }


        public static int loginWithInternet(string credentialEmailCellphone, string password)
        {
            string selectCommand = "SELECT * FROM Usuario WHERE (email = @credentialEmailCellphone OR telefone = @credentialEmailCellphone) AND senha = @senha";

            if (credentialEmailCellphone == null || password == null)
            {
                return (int)TipoMensagemLogin.LOGIN_VAZIO;
            }

            MySqlConnection connection = new MySqlConnection(DataAdapter.connectionStringMySql);

            MySqlDataReader reader;

            using MySqlCommand cmd = new MySqlCommand(selectCommand, connection);
            {
                connection.Open();
                cmd.Parameters.AddWithValue("@credentialEmailCellphone", credentialEmailCellphone);
                cmd.Parameters.AddWithValue("@senha", password);
                reader = cmd.ExecuteReader();
            }

            if (reader.HasRows)
            {
                IsAuthenticated = true;

                reader.Read();

                // gets the user data
                userId = reader.GetInt32("userId");
                IsAuthenticated = true;
                email = reader.GetString("email");
                cellphone = reader.GetString("telefone");

                return (int)TipoMensagemLogin.LOGIN_SUCESSO;
            }

            return (int)TipoMensagemLogin.LOGIN_INCORRETO;

        }
    }
}
