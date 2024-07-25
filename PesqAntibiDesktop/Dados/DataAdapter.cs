using System.Data;
using System.Data.SqlClient;

namespace Dados
{
    public abstract class DataAdapter
    {
        public static string userId = "0";
        public static readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\arthu\\source\\repos\\Pesquisador-de-Antibioticos\\PesqAntibiDesktop\\PesqAntibiDesktop\\APP_DATA\\Database1.mdf;Integrated Security=True";
        /// <summary>
        /// Gets a data adapter based on the specified command and connection string. Works with
        /// Select
        /// </summary>
        /// <param name="command">The SQL command to execute (Select).</param>
        /// <param name="sqlDataAdapter">The SqlDataAdapter object to be initialized.</param>
        /// <returns>The initialized SqlDataAdapter object.</returns>
        public static SqlDataAdapter getDataAdapter(string command, SqlDataAdapter sqlDataAdapter, string connectionString)
        {

            // Create a new data adapter based on the specified query.
            sqlDataAdapter = new SqlDataAdapter(command, connectionString);

            // Create a command builder to generate SQL update, insert, and
            // delete commands based on selectCommand.
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDataAdapter);

            return sqlDataAdapter;
        }

        public static SqlDataAdapter getDataAdapteSafe(SqlCommand command, SqlDataAdapter sqlDataAdapter)
        {

            // Create a new data adapter based on the specified query.
            sqlDataAdapter = new SqlDataAdapter(command);

            // Create a command builder to generate SQL update, insert, and
            // delete commands based on selectCommand.
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDataAdapter);

            return sqlDataAdapter;
        }

        public static bool? isNameInTable(string databaseTableName, string column, string name, SqlDataAdapter sqlDataAdapter)
        {
            DataTable dataTable = new DataTable();

            // Specify a connection string.
            
            string commandString = "SELECT * FROM " + databaseTableName + " WHERE " + column + " = @name";

            try
            { 

            SqlCommand sqlCommand = new SqlCommand(commandString, new SqlConnection(connectionString));
            sqlCommand.Parameters.AddWithValue("@name", name);
            sqlCommand.Connection = new SqlConnection(connectionString);

            sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            }

            catch (Exception)
            {
                return null;
            }
            
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                return true;
            }

            return false;
        }
    }
}
