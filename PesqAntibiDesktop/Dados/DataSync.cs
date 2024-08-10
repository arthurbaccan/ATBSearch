using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;


namespace Dados
{

    public abstract class DataSync
    {
        public static readonly string sqlBackupAntibioticos = "..\\PesqAntibiDesktop\\APP_DATA\\AntibioticosBackup.sql";
        public static void exportMySqlAntibioticoTable()
        {
            string constring = DataAdapter.connectionStringMySql;
            string file = sqlBackupAntibioticos;
            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportInfo.TablesToBeExportedList = new List<string> { "Antibiotico" };
                        mb.ExportToFile(file);
                    }
                }
            }
        }

        public static string convertMySqlToSqlServer(string script)
        {
            // Replace MySQL-specific syntax with SQL Server syntax
            script = script.Replace("`", ""); // Remove backticks
            script = script.Replace("AUTO_INCREMENT", "IDENTITY(1,1)"); // Replace AUTO_INCREMENT with IDENTITY
            script = script.Replace("ENGINE=InnoDB", "--");
            script = script.Replace("int(11)", "INT"); // Replace int(11) with INT
            script = script.Replace("varchar(100)", "NVARCHAR(100)"); // Replace varchar with NVARCHAR
            script = script.Replace("tinyint(4)", "TINYINT"); // Replace tinyint with TINYINT

            // Handle specific SQL Server syntax
            script = script.Replace("DROP TABLE IF EXISTS", "IF OBJECT_ID('dbo.Antibiotico', 'U') IS NOT NULL DROP TABLE");
            script = script.Replace("CREATE TABLE IF NOT EXISTS", "CREATE TABLE");

            script = script.Replace("Antibiotico", "antibiotico");

            // Remove specific MySQL commands that are not compatible with SQL Server
            script = removeMySqlCommands(script);

            return script;
        }

        private static string removeMySqlCommands(string script)
        {
            // Remove MySQL-specific commands that are not applicable in SQL Server
            script = script.Replace("/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;", "");
            script = script.Replace("/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;", "");
            script = script.Replace("/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;", "");
            script = script.Replace("/*!40101 SET NAMES latin1 */;", "");
            script = script.Replace("/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;", "");
            script = script.Replace("/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;", "");
            script = script.Replace("/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;", "");
            script = script.Replace("/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;", "");
            script = script.Replace("/*!40000 ALTER TABLE `Antibiotico` DISABLE KEYS */;", "");
            script = script.Replace("/*!40000 ALTER TABLE `Antibiotico` ENABLE KEYS */;", "");
            script = script.Replace("/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;", "");
            script = script.Replace("/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;", "");
            script = script.Replace("/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;", "");
            script = script.Replace("/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;", "");
            script = script.Replace("/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;", "");
            script = script.Replace("/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;", "");
            script = script.Replace("/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;", "");
            script = script.Replace("/*!40000 ALTER TABLE antibiotico DISABLE KEYS */;", "SET IDENTITY_INSERT antibiotico ON;");
            script = script.Replace("/*!40000 ALTER TABLE antibiotico ENABLE KEYS */;", "SET IDENTITY_INSERT antibiotico OFF;");

            return script;
        }

        private static void updateLocalDbFromSqlFile()
        {
            string constring = DataAdapter.connectionString;
            string file = sqlBackupAntibioticos;

            string script = File.ReadAllText(sqlBackupAntibioticos);

            
            script = convertMySqlToSqlServer(script);
            

            using (SqlConnection conn = new SqlConnection(constring))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(script, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void syncAllAntibioticsData()
        {
            
            exportMySqlAntibioticoTable();
            updateLocalDbFromSqlFile();
        }

        
    }
}
