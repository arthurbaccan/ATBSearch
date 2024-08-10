using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Dados
{
    public abstract class DataSaver
    {

        public static bool dataTableAdicionarHasNoData(DataTable table)
        {

             if (table == null || table.Rows.Count == 0) return true;
             for (int i = 0; i < table.Rows.Count; i++)
             {
                 if ((bool)table.Rows[i]["adicionar"] == true)
                 {
                     return false;
                 }
             }

             return true;
        }
        public static int saveTabelaPersonalizadaLocal(DataTable table, string name, SqlDataAdapter sqlDataAdapter, string userId)
        {
            if (table == null || table.Rows.Count == 0)
            {
                return 0;
            }

            // check if there's already a row in the database with the same name
            string selectCommand = "SELECT * FROM TabelaPersonalizada WHERE nome = @nome";

            bool? nameInTable = DataAdapter.isNameInTable("tabelaPersonalizada", "nomeTabela", name, sqlDataAdapter);

            if (nameInTable == true)
            {
                return (int)TipoErroSalvarTabela.NOME_TABELA_JA_EXISTE;
            }

            if (dataTableAdicionarHasNoData(table))
            {
                return (int)TipoErroSalvarTabela.TABELA_VAZIA;
            }

            foreach (DataRow row in table.Rows)
            {   
                try
                {

                    // insert the row in the database
                    using (SqlConnection connection = new SqlConnection(DataAdapter.connectionString))
                    {
                        string insertCommand = "INSERT INTO tabelaPersonalizada (idAntibiotico, idUsuario, nomeTabela) VALUES (@idAntibiotico, @idUsuario, @nomeTabela)";
                        SqlCommand command = new SqlCommand(insertCommand, connection);
                        command.Parameters.AddWithValue("@idAntibiotico", (int)row["idAntibiotico"]);
                        command.Parameters.AddWithValue("@idUsuario", userId);
                        command.Parameters.AddWithValue("@nomeTabela", name);

                        connection.Open();

                        int result = command.ExecuteNonQuery();

                        if (result < 0)
                        {
                            return (int)TipoErroSalvarTabela.ERRO_DESCONHECIDO;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                    return (int)TipoErroSalvarTabela.ERRO_DESCONHECIDO;
                }
                
            }

            return 1;
        }

        public static int saveTabelaPersonalizadaCloud(DataTable table, string name, MySqlDataAdapter MysqlDataAdapter, string userId)
        {
            // save the table but using the mysql cloud database

            if (table == null || table.Rows.Count == 0)
            {
                return 0;
            }

            // TODO: check if there's already a row in the database with the same name

            foreach (DataRow row in table.Rows)
            {
                if (row.RowState == DataRowState.Deleted)
                {
                    continue;
                }

                try
                {
                    // insert the row in the database
                    using (MySqlConnection connection = new MySqlConnection(DataAdapter.connectionStringMySql))
                    { 
                        

                        string insertCommand = "INSERT INTO TabelaPersonalizada (idAntibiotico, idUsuario, nomeTabela) VALUES (@idAntibiotico, @idUsuario, @nomeTabela)";
                        MySqlCommand command = new MySqlCommand(insertCommand, connection);
                        command.Parameters.AddWithValue("@idAntibiotico", (int)row["id"]);
                        command.Parameters.AddWithValue("@idUsuario", userId);
                        command.Parameters.AddWithValue("@nomeTabela", name);

                        connection.Open();

                        int result = command.ExecuteNonQuery();

                        if (result < 0)
                        {
                            return (int)TipoErroSalvarTabela.ERRO_DESCONHECIDO;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                    return (int)TipoErroSalvarTabela.ERRO_DESCONHECIDO;
                }

            }

            return 1;
        }


    }
}
