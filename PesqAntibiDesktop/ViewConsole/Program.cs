using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using Dados;

internal class Program
{
    private static void Main(string[] args)
    {
        static void printDBTableData(string tableName)
        {
            string selectCommand = "SELECT * FROM " + tableName;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            sqlDataAdapter = Dados.DataAdapter.getDataAdapter(selectCommand, sqlDataAdapter, Dados.DataAdapter.connectionString);
            sqlDataAdapter.Fill(table);
            Console.WriteLine("Id | IdAntibiotico | IdUsuario | nomeTabela ");
            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine(row["id"] + "      | " + row["idAntibiotico"] + "        | " + row["idUsuario"] + "      | " + row["nomeTabela"]);
                
            }
        }

        printDBTableData("tabelaPersonalizada");
    }
}