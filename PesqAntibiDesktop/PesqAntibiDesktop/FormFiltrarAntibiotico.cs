using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dados;
using System.Globalization;

namespace PesqAntibiDesktop
{
    public partial class FormTabela : Form
    {
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private DataTable table = new DataTable
        {
            Locale = CultureInfo.InvariantCulture
        };

        public FormTabela()
        {
            InitializeComponent();
            Load += new EventHandler(FormTabela_Load);
        }

        private void GetData(string selectCommand)
        {
            try
            {
                // Specify a connection string.
                // Replace <SQL Server> with the SQL Server for your Northwind sample database.
                // Replace "Integrated Security=True" with user login information if necessary.
                String connectionString =
                    "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\arthu\\source\\repos\\Pesquisador-de-Antibioticos\\PesqAntibiDesktop\\PesqAntibiDesktop\\APP_DATA\\Database1.mdf;Integrated Security=True";

                // Create a new data adapter based on the specified query.
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate the data table and bind it to the BindingSource.
                dataAdapter.Fill(table);
            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }

        private void FormTabela_Load(object sender, EventArgs e)
        {

            //gridAntibiotico.DataSource = bindingSource1;
            GetData("select * from antibiotico");
            updateDataGrid();
        }

        private void updateDataGrid()
        {
            if (gridAntibiotico.Columns.Count != 0)
            {
                return;
            }
            // Create the columns with the desired names
            gridAntibiotico.Columns.Add("nome", "Nome do Antibiótico");
            gridAntibiotico.Columns.Add("tipo_antibiotico", "Tipo de Antibiótico");
            gridAntibiotico.Columns.Add("gram_positiva", "Age em Gram Positiva");
            gridAntibiotico.Columns.Add("gram_negativa", "Age em Gram Negativa");
            gridAntibiotico.Columns.Add("morfologia", "Morfologia Bacteriana");

            // Populate the columns with formatted the data from the data table
            foreach (DataRow row in table.Rows)
            {
                string tipoAntibiotico = Enum.GetName(typeof(TipoAntibiotico), row["tipo_antibiotico"]);
                
                string gramPositiva = "Não informado";
                if ((byte) row["gram_positiva"] == 0)
                {
                    gramPositiva = "❌";
                }
                else if ((byte)row["gram_positiva"] == 1)
                {
                    gramPositiva = "✅";
                }

                string gramNegativa = "Não informado";
                if ((byte)row["gram_negativa"] == 0)
                {
                    gramNegativa = "❌";
                }
                else if ((byte)row["gram_negativa"] == 1)
                {
                   gramNegativa = "✅";
                }

                // Change the antibioitc name(char[100]) to a correctly sized string (removes blank spaces)
                string nome = row["nome"].ToString().Trim();

                gridAntibiotico.Rows.Add(nome, tipoAntibiotico, gramPositiva, gramNegativa, row["morfologia"]);

                // change the color of the gram_positva and gram_negativa cells font. Puts the text in green
                // for the checmark and red for the X
                if (gramNegativa == "❌")
                {
                    gridAntibiotico.Rows[gridAntibiotico.Rows.Count - 1].Cells["gram_negativa"].Style.ForeColor = Color.Red;
                }
                else
                {
                    gridAntibiotico.Rows[gridAntibiotico.Rows.Count - 1].Cells["gram_negativa"].Style.ForeColor = Color.Green;
                }

                if (gramPositiva == "❌")
                {
                    gridAntibiotico.Rows[gridAntibiotico.Rows.Count - 1].Cells["gram_positiva"].Style.ForeColor = Color.Red;
                }
                else
                {
                    gridAntibiotico.Rows[gridAntibiotico.Rows.Count - 1].Cells["gram_positiva"].Style.ForeColor = Color.Green;
                }
                
            }

            gridAntibiotico.Refresh();

        }

        private void updateFontSize(Label label)
        {
            // Desired font size and adjustment factor (you may adjust these as needed)
            float scaleFactor = Math.Min(label.Width / TextRenderer.MeasureText(label.Text, label.Font).Width,
                                         label.Height / TextRenderer.MeasureText(label.Text, label.Font).Height);
            float sizeIncrease = 1;

            // Calculate the new font size
            float newFontSize = label.Font.Size * scaleFactor * sizeIncrease;

            if (newFontSize < 8)
            {
                newFontSize = 8;
            }

            // Create a new font instance with the new size
            label.Font = new Font(label.Font.FontFamily, newFontSize, label.Font.Style);
        }

        private void labelTituloTab_SizeChanged(object sender, EventArgs e)
        {
            updateFontSize(labelTituloTab);
        }

        private void label1Pesquisar_SizeChanged(object sender, EventArgs e)
        {
            updateFontSize(labelPesquisarNome);
        }

        private void labelTipoBacteria_SizeChanged(object sender, EventArgs e)
        {
            updateFontSize(labelTipoBacteria);
        }
    }
}
