using System;
using System.Data;
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
        private int maxFontSize = 20;
        private int maxHeigth = 50;

        public FormTabela()
        {
            InitializeComponent();
        }

        private void FormTabela_Load(object sender, EventArgs e)
        {

            DataLoader.GetDataLocal("select * from antibiotico", dataAdapter, table);
            updateDataGrid();

        }

        private void updateDataGrid()
        {
            if (gridAntibiotico.Columns.Count != 0)
            {
                return;
            }

            GridLoader.addDefaultCollumns(gridAntibiotico);

            // Populate the columns with formatted the data from the data table
            foreach (DataRow row in table.Rows)
            {
                string tipoAntibiotico = GridLoader.getTipoAntibioticoString(row);

                // returns an X or a checkmark according to the value of the gram_positiva and gram_negativa columns
                string gramPositiva = GridLoader.getGramPositivaString(row);

                string gramNegativa = GridLoader.getGramNegativaString(row);

                string morfologia = GridLoader.getMorfologiaString(row);

                // Change the antibioitc name(char[100]) to a correctly sized string (removes blank spaces)
                string nome = row["nome"].ToString().Trim();

                gridAntibiotico.Rows.Add(nome, tipoAntibiotico, gramPositiva, gramNegativa, morfologia);

                // change the color of the gram_positva and gram_negativa cells font. Puts the text in green
                // for the checmark and red for the X
                GridLoader.setGramForeColor(gridAntibiotico, gramNegativa, gramPositiva);

            }

            gridAntibiotico.Refresh();

        }

        private void labelTituloTab_SizeChanged(object sender, EventArgs e)
        {
            FontSizer.updateFontSize(labelTituloTab, maxFontSize);
        }

        private void label1Pesquisar_SizeChanged(object sender, EventArgs e)
        {
            FontSizer.updateFontSize(labelPesquisarNome, maxFontSize);
        }
        private string getTextNome()
        {
            string nome = textBoxNome.Text;
            return nome;
        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            string selectCommand = DataLoader.getPesquisaString(getTextNome(), checkBoxCocos.Checked,
                checkBoxBacilos.Checked,
                checkBoxGramNegativa.Checked,
                checkBoxGramPositiva.Checked,
                checkBoxMacrolideos.Checked,
                checkBoxPenicilinas.Checked,
                checkBoxCefalosporinas.Checked,
                checkBoxCarbapenemicos.Checked,
                checkBoxAminoglicosideos.Checked,
                checkBoxQuinolonas.Checked,
                checkBoxAnfenicois.Checked,
                checkBoxSulfonamidas.Checked,
                checkBoxGlicopeptideos.Checked,
                checkBoxNitroimidazolicos.Checked,
                checkBoxLicosamidas.Checked,
                checkBoxPolimixinas.Checked,
                checkBoxOxazolidinona.Checked,
                checkBoxGlicilciclina.Checked,
                checkBoxAntituberculosos.Checked);


            DataLoader.GetDataLocal(selectCommand, dataAdapter, table);
            GridLoader.clearGrid(gridAntibiotico);
            updateDataGrid();
        }

        private void tabelasPersonalizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuClickOpen.tabelasPersonalizadasOpen();
        }

        private void tabelaDeAntibióticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuClickOpen.tabelaDeAntibióticosOpen();
        }
    }
}
