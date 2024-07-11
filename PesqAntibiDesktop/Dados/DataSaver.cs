using System.Data;
using System.Data.SqlClient;

namespace Dados
{
    public class DataSaver
    {
        public static void saveTabelaPersonalizadaLocal(DataTable table, SqlDataAdapter sqlDataAdapter)
        {
            string insertCommand = "";



            sqlDataAdapter = DataAdapter.getDataAdapter(insertCommand, sqlDataAdapter);
        }
    }
}
