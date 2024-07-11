using System.Data.SqlClient;

namespace Dados
{
    public class DataAdapter
    {
        /// <summary>
        /// Gets a data adapter based on the specified command and connection string. Works with
        /// Insert, Select, Update, Delete comands.
        /// </summary>
        /// <param name="command">The SQL command to execute (Insert, Select, Update, Delete).</param>
        /// <param name="sqlDataAdapter">The SqlDataAdapter object to be initialized.</param>
        /// <returns>The initialized SqlDataAdapter object.</returns>
        public static SqlDataAdapter getDataAdapter(string command, SqlDataAdapter sqlDataAdapter)
        {
            // Specify a connection string.
            string connectionString =
                "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\arthu\\source\\repos\\Pesquisador-de-Antibioticos\\PesqAntibiDesktop\\PesqAntibiDesktop\\APP_DATA\\Database1.mdf;Integrated Security=True";

            // Create a new data adapter based on the specified query.
            sqlDataAdapter = new SqlDataAdapter(command, connectionString);

            // Create a command builder to generate SQL update, insert, and
            // delete commands based on selectCommand.
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(sqlDataAdapter);

            return sqlDataAdapter;
        }
    }
}
