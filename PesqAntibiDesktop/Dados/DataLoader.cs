using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using MySql.Data.MySqlClient; 

namespace Dados
{
    public abstract class DataLoader
    {
        public static bool GetDataLocal(string selectCommand, SqlDataAdapter sqlDataAdapter, DataTable table)
        {
            table.Clear();
            try
            {
                sqlDataAdapter = DataAdapter.getDataAdapter(selectCommand, sqlDataAdapter, DataAdapter.connectionString);

                // Populate the data table and bind it to the BindingSource.
                sqlDataAdapter.Fill(table);
            }
            catch (SqlException ex)
            {

                return false;
            }
            return true;
        }

        public static bool GetDataLocalSafe(SqlCommand selectCommand, SqlDataAdapter sqlDataAdapter, DataTable table)
        {
            table.Clear();
            try
            {
                sqlDataAdapter = DataAdapter.getDataAdapteSafe(selectCommand, sqlDataAdapter);

                // Populate the data table and bind it to the BindingSource.
                sqlDataAdapter.Fill(table);
            }
            catch (SqlException ex)
            {

                return false;
            }
            return true;
        }

        public static string getPesquisaString(string textNome, bool cocos, bool bacilos, bool gramNegativa, bool gramPositiva, bool macrolideos,
                                     bool penicilinas, bool cefalosporinas, bool carbapenemicos, bool aminoglicosideos,
                                     bool quinolonas, bool anfenicois, bool sulfonamidas, bool glicopeptideos,
                                     bool nitroimidazolicos, bool licosamidas, bool polimixinas, bool oxazolidinona,
                                     bool glicilciclina, bool antituberculosos)
        {
            string selectCommand = "select * from antibiotico where";
            bool useAnd = false;
            bool filterSelected = false;

            if (!string.IsNullOrEmpty(textNome))
            {
                selectCommand += " nome like '%" + textNome + "%'";
                useAnd = true;
                filterSelected = true;
            }

            // if the box is not checked, it means that it should not show gram negativa antibiotics
            if (!gramNegativa)
            {
                if (useAnd)
                {
                    selectCommand += " and gram_negativa = 0";
                }
                else
                {
                    selectCommand += " gram_negativa = 0";
                    useAnd = true;
                }
                filterSelected = true;
            }

            if (!gramPositiva)
            {
                if (useAnd)
                {
                    selectCommand += " and gram_positiva = 0";
                }
                else
                {
                    selectCommand += " gram_positiva = 0";
                    useAnd = true;
                }
                filterSelected = true;
            }

            if (!cocos)
            {
                if (useAnd)
                {
                    selectCommand += $" and morfologia != {((int)TipoMorfologia.Cocos)} and morfologia != {((int)TipoMorfologia.Cocos_e_Bacilos)}";
                }
                else
                {
                    selectCommand += $" morfologia != {((int)TipoMorfologia.Cocos)} and morfologia != {((int)TipoMorfologia.Cocos_e_Bacilos)}";
                    useAnd = true;
                }
                filterSelected = true;
            }

            if (!bacilos)
            {
                if (useAnd)
                {
                    selectCommand += $" and morfologia != {((int)TipoMorfologia.Bacilos)} and morfologia !=  {((int)TipoMorfologia.Cocos_e_Bacilos)}";
                }
                else
                {
                    selectCommand += $" morfologia != {((int)TipoMorfologia.Bacilos)} and morfologia !=  {((int)TipoMorfologia.Cocos_e_Bacilos)}";
                    useAnd = true;
                }
                filterSelected = true;
            }

            if (!macrolideos)
            {
                if (useAnd)
                {
                    selectCommand += $" and tipo_antibiotico != {((int)TipoAntibiotico.Macrolídeos)}";
                }
                else
                {
                    selectCommand += $" tipo_antibiotico != {((int)TipoAntibiotico.Macrolídeos)}";
                    useAnd = true;
                }
                filterSelected = true;
            }

            if (!penicilinas)
            {
                if (useAnd)
                {
                    selectCommand += $" and tipo_antibiotico != {((int)TipoAntibiotico.Penicilinas)}";
                }
                else
                {
                    selectCommand += $" tipo_antibiotico != {((int)TipoAntibiotico.Penicilinas)}";
                    useAnd = true;
                }
                filterSelected = true;
            }

            if (!cefalosporinas)
            {
                if (useAnd)
                {
                    selectCommand += $" and tipo_antibiotico != {((int)TipoAntibiotico.Cefalosporinas)}";
                }
                else
                {
                    selectCommand += $" tipo_antibiotico != {((int)TipoAntibiotico.Cefalosporinas)}";
                    useAnd = true;
                }
                filterSelected = true;
            }

            if (!carbapenemicos)
            {
                if (useAnd)
                {
                    selectCommand += $" and tipo_antibiotico != {((int)TipoAntibiotico.Carbapenêmicos)}";
                }
                else
                {
                    selectCommand += $" tipo_antibiotico != {((int)TipoAntibiotico.Carbapenêmicos)}";
                    useAnd = true;
                }
                filterSelected = true;
            }

            if (!aminoglicosideos)
            {
                if (useAnd)
                {
                    selectCommand += $" and tipo_antibiotico != {((int)TipoAntibiotico.Aminoglicosídeos)}";
                }
                else
                {
                    selectCommand += $" tipo_antibiotico != {((int)TipoAntibiotico.Aminoglicosídeos)}";
                    useAnd = true;
                }
                filterSelected = true;
            }

            if (!quinolonas)
            {
                if (useAnd)
                {
                    selectCommand += $" and tipo_antibiotico != {((int)TipoAntibiotico.Quinolonas)}";
                }
                else
                {
                    selectCommand += $" tipo_antibiotico != {((int)TipoAntibiotico.Quinolonas)}";
                    useAnd = true;
                }
                filterSelected = true;
            }

            if (!anfenicois)
            {
                if (useAnd)
                {
                    selectCommand += $" and tipo_antibiotico != {((int)TipoAntibiotico.Anfenicóis)}";
                }
                else
                {
                    selectCommand += $" tipo_antibiotico != {((int)TipoAntibiotico.Anfenicóis)}";
                    useAnd = true;
                }
                filterSelected = true;
            }

            if (!sulfonamidas)
            {
                if (useAnd)
                {
                    selectCommand += $" and tipo_antibiotico != {((int)TipoAntibiotico.Sulfonamidas)}";
                }
                else
                {
                    selectCommand += $" tipo_antibiotico != {((int)TipoAntibiotico.Sulfonamidas)}";
                    useAnd = true;
                }
                filterSelected = true;
            }

            if (!glicopeptideos)
            {
                if (useAnd)
                {
                    selectCommand += $" and tipo_antibiotico != {((int)TipoAntibiotico.Glicopeptídeos)}";
                }
                else
                {
                    selectCommand += $" tipo_antibiotico != {((int)TipoAntibiotico.Glicopeptídeos)}";
                    useAnd = true;
                }
                filterSelected = true;
            }

            if (!nitroimidazolicos)
            {
                if (useAnd)
                {
                    selectCommand += $" and tipo_antibiotico != {((int)TipoAntibiotico.Nitroimidazólicos)}";
                }
                else
                {
                    selectCommand += $" tipo_antibiotico != {((int)TipoAntibiotico.Nitroimidazólicos)}";
                    useAnd = true;
                }
                filterSelected = true;
            }

            if (!licosamidas)
            {
                if (useAnd)
                {
                    selectCommand += $" and tipo_antibiotico != {((int)TipoAntibiotico.Licosamidas)}";
                }
                else
                {
                    selectCommand += $" tipo_antibiotico != {((int)TipoAntibiotico.Licosamidas)}";
                    useAnd = true;
                }
                filterSelected = true;
            }

            if (!polimixinas)
            {
                if (useAnd)
                {
                    selectCommand += $" and tipo_antibiotico != {((int)TipoAntibiotico.Polimixinas)}";
                }
                else
                {
                    selectCommand += $" tipo_antibiotico != {((int)TipoAntibiotico.Polimixinas)}";
                    useAnd = true;
                }
                filterSelected = true;
            }

            if (!oxazolidinona)
            {
                if (useAnd)
                {
                    selectCommand += $" and tipo_antibiotico != {((int)TipoAntibiotico.Oxazolidinona)}";
                }
                else
                {
                    selectCommand += $" tipo_antibiotico != {((int)TipoAntibiotico.Oxazolidinona)}";
                    useAnd = true;
                }
                filterSelected = true;
            }

            if (!glicilciclina)
            {
                if (useAnd)
                {
                    selectCommand += $" and tipo_antibiotico != {((int)TipoAntibiotico.Glicilciclina)}";
                }
                else
                {
                    selectCommand += $" tipo_antibiotico != {((int)TipoAntibiotico.Glicilciclina)}";
                    useAnd = true;
                }
                filterSelected = true;
            }

            if (!antituberculosos)
            {
                if (useAnd)
                {
                    selectCommand += $" and tipo_antibiotico != {((int)TipoAntibiotico.Antituberculosos)}";
                }
                else
                {
                    selectCommand += $" tipo_antibiotico != {((int)TipoAntibiotico.Antituberculosos)}";
                    useAnd = true;
                }
                filterSelected = true;
            }

            if (!filterSelected)
            {
                selectCommand = "select * from antibiotico";
            }

            return selectCommand;
        }

        public static DataTable getCustomAntibioticData(DataTable antibioticsData, string tableName, string userId, SqlDataAdapter dataAdapter)
        {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM tabelaPersonalizada WHERE nomeTabela = @nomeTabela AND idUsuario = @idUsuario");
            sqlCommand.Parameters.AddWithValue("@nomeTabela", tableName);
            sqlCommand.Parameters.AddWithValue("@idUsuario", userId);
            sqlCommand.Connection = new SqlConnection(DataAdapter.connectionString);

            DataTable tableAntibioticIds = new DataTable();

            // gets the data of the antibiotics that should appear in the user's table
            DataLoader.GetDataLocalSafe(sqlCommand, dataAdapter, tableAntibioticIds);

            // Changes the data of the table to include only the user chosen antibioitics
            // (checks if the antibiotic Id is in the other table and removes the row if not)
            foreach (DataRow row in antibioticsData.Rows)
            {
                if (tableAntibioticIds.Select("idAntibiotico = " + row["id"]).Length == 0)
                {
                    row.Delete();
                }
            }

            return antibioticsData;
        }

    }

    
}
