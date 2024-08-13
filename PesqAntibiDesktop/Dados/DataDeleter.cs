using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public abstract class DataDeleter
    {
        public static void deleteCustomTable(string name, string userId)
        {
            string deleteCommand = "DELETE FROM tabelaPersonalizada WHERE nomeTabela = @nomeTabela AND idUsuario = @idUsuario";

            SqlCommand sqlCommand = new SqlCommand(deleteCommand);
            sqlCommand.Parameters.AddWithValue("@nomeTabela", name);
            sqlCommand.Parameters.AddWithValue("@idUsuario", userId);
            
            using (SqlConnection connection = new SqlConnection(DataAdapter.connectionString))
            {
                connection.Open();
                sqlCommand.Connection = connection;
                sqlCommand.ExecuteNonQuery();
            } 
        }

        public static int deleteTableDataCloud(string nameTable, string userId, MySqlDataAdapter MysqlDataAdapter)
        {
            // delete the old data from the table in the cloud database
            using (MySqlConnection connection = new MySqlConnection(DataAdapter.connectionStringMySql))
            {
                string deleteCommand = "DELETE FROM TabelaPersonalizada WHERE nomeTabela = @nomeTabela AND idUsuario = @idUsuario";
                MySqlCommand command = new MySqlCommand(deleteCommand, connection);
                command.Parameters.AddWithValue("@nomeTabela", nameTable);
                command.Parameters.AddWithValue("@idUsuario", userId);

                connection.Open();

                int result = command.ExecuteNonQuery();

                if (result < 0)
                {
                    return (int)TipoErroSalvarTabela.ERRO_DESCONHECIDO;
                }
            }

            return 1;
        }
    }
}
