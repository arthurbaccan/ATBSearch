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
    }
}
