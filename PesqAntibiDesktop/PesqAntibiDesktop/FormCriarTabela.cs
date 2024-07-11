using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Dados;
using System.Globalization;

namespace PesqAntibiDesktop
{
    public partial class FormCriarTabela : Form
    {
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private DataTable table = new DataTable
        {
            Locale = CultureInfo.InvariantCulture
        };
        private DataTable tableAdicionar = new DataTable
        {
            Locale = CultureInfo.InvariantCulture
        };

        private int maxFontSize = 20;
        private int maxHeigth = 50;

        public FormCriarTabela()
        {
            InitializeComponent();
            
        }

        private void loadTableAdicionar()
        {
            tableAdicionar.Columns.Add("idAntibiotico", typeof(int));

            tableAdicionar.Columns.Add("adicionar", typeof(bool));
            tableAdicionar.Columns["adicionar"].DefaultValue = false;

            foreach (DataRow row in table.Rows)
            {
                tableAdicionar.Rows.Add((int)row["id"]);
            }
        }

        private void updateAdicionarValue(int idAntibiotico, bool adicionar)
        {
            foreach (DataRow row in tableAdicionar.Rows)
            {
                if ((int)row["idAntibiotico"] == idAntibiotico)
                {
                    row["adicionar"] = adicionar;
                    break;
                }
            }
        }

        private DataRow getAdicionarRowFromIdAntibiotico(int idAntibiotico)
        {
            foreach (DataRow row in tableAdicionar.Rows)
            {
                if ((int)row["idAntibiotico"] == idAntibiotico)
                {
                    return row;
                }
            }
            return null;
        }

        private int getIdAntibioticoFromGridRow(int rowIndex)
        {
           foreach (DataRow dataRow in table.Rows)
            {
                if (dataRow["nome"].ToString().Trim() == gridAntibiotico.Rows[rowIndex].Cells["nome"].Value.ToString().Trim())
                {
                    return (int)dataRow["id"];
                }
            }
            return -1;
        }
        
        private void FormTabela_Load(object sender, EventArgs e)
        {

            DataLoader.GetDataLocal("select * from antibiotico", dataAdapter, table);

            loadTableAdicionar();

            updateDataGrid();

        }


        private void myDataGrid_OnCellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            // End of edition on each click on column of checkbox
            if (e.ColumnIndex == gridAntibiotico.Columns["adicionar"].Index && e.RowIndex != -1)
            {
                bool checkedBool = !Convert.ToBoolean(gridAntibiotico.Rows[e.RowIndex].Cells["adicionar"].Value);
                gridAntibiotico.Rows[e.RowIndex].Cells["adicionar"].Value = checkedBool;
                int antibioticoId = getIdAntibioticoFromGridRow(e.RowIndex);
                updateAdicionarValue(antibioticoId, checkedBool);
                gridAntibiotico.EndEdit();
            }
        }

        private void updateDataGrid()
        {

            if (gridAntibiotico.Columns.Count != 0)
            {
                return;
            }

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Adicionar";
            checkBoxColumn.Name = "adicionar";
            checkBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            checkBoxColumn.Resizable = DataGridViewTriState.False;
            checkBoxColumn.ReadOnly = false;

            gridAntibiotico.Columns.Add(checkBoxColumn);

            GridLoader.addDefaultCollumns(gridAntibiotico);

            // Populate the columns with formatted the data from the data table
            foreach (DataRow row in table.Rows)
            {

                bool adicionar = (bool)getAdicionarRowFromIdAntibiotico((int)row["id"])["adicionar"];

                string tipoAntibiotico = GridLoader.getTipoAntibioticoString(row);

                string gramPositiva = GridLoader.getGramPositivaString(row);

                string gramNegativa = GridLoader.getGramNegativaString(row);
                
                // Change the antibioitc name(char[100]) to a correctly sized string (removes blank spaces)
                string nome = row["nome"].ToString().Trim();

                gridAntibiotico.Rows.Add(adicionar, nome, tipoAntibiotico, gramPositiva, gramNegativa, row["morfologia"]);
                
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
            string selectCommand = DataLoader.getPesquisaString(getTextNome(), checkBoxGramNegativa.Checked,
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
