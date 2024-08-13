using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dados;
using MySql.Data.MySqlClient;

namespace PesqAntibiDesktop
{
    public partial class FormTabelasPersonalizadas : Form
    {
        private int maxFontSize = 20;
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private DataTable table = new DataTable();
        private bool isSelectingTables = false;
        // Known bug: if the user opens a table and closes it, the table will not be removed from the dictionary
        // this doesnt affect the user experience in any way.
        private Dictionary<string, FormAbrirTabelaPersonalizada> openTables = new Dictionary<string, FormAbrirTabelaPersonalizada>();
        private List<Button> selectedButtons = new List<Button>();
        public FormTabelasPersonalizadas()
        {
            InitializeComponent();
        }

        private void tabelasPersonalizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuClickOpen.tabelasPersonalizadasOpen();
        }

        private void tabelaDeAntibióticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuClickOpen.tabelaDeAntibióticosOpen();
        }

        private void labelTituloTab_SizeChanged(object sender, EventArgs e)
        {
            FontSizer.updateFontSize(labelTituloTab, maxFontSize);
        }

        private void buttonCriar_Click(object sender, EventArgs e)
        {
            if (isSelectingTables)
            {
                MessageBox.Show("Você está selecionando tabelas para deletar, clique em cancelar seleção para criar uma nova tabela", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //check if there are any FormFiltrarAntibiotico open
            if (Application.OpenForms.OfType<FormCriarTabela>().Count() == 0)
            {
                FormCriarTabela formCriarTabela = new FormCriarTabela();
                formCriarTabela.Show();
            }
            else
            {
                Application.OpenForms.OfType<FormCriarTabela>().First().Focus();
            }
        }

        private void createButtonOpenTables()
        {
            string selectString = "SELECT * FROM tabelaPersonalizada where idUsuario='" + AuthenticationLocal.userId.ToString() + "'";
            dataAdapter = DataAdapter.getDataAdapter(selectString, dataAdapter, DataAdapter.connectionString);
            table.Clear();
            dataAdapter.Fill(table);

            List<string> tableNames = new List<string>();

            foreach (DataRow row in table.Rows)
            {

                if (tableNames.Contains(row["nomeTabela"].ToString()))
                {
                    continue;
                }

                Button button = new Button();
                button.Text = row["nomeTabela"].ToString();
                button.Size = buttonCriar.Size;
                button.Font = buttonCriar.Font;
                button.Click += new EventHandler(buttonTableClick);
                flowLayoutPanelTables.Controls.Add(button);

                tableNames.Add(row["nomeTabela"].ToString());

            }
        }
        private void selectButton(Button button)
        {
            selectedButtons.Add(button);
            button.BackColor = System.Drawing.Color.LightBlue;
        }

        private void deselectButton(Button button)
        {
            selectedButtons.Remove(button);
            button.BackColor = System.Drawing.Color.White;
        }

        private void buttonTableClick(object sender, EventArgs e)
        {
            string tableName = ((Button)sender).Text;

            if (isSelectingTables)
            {
                if (selectedButtons.Contains((Button)sender))
                {
                    deselectButton((Button)sender);
                }
                else
                {
                    selectButton((Button)sender);
                }
                return;
            }

            if (openTables.ContainsKey(tableName))
            {
                try
                {
                    // Weird trick so the form is always shown on top of the other windows
                    openTables[tableName].WindowState = FormWindowState.Minimized;
                    openTables[tableName].Show();
                    openTables[tableName].WindowState = FormWindowState.Maximized;

                    return;
                }
                catch (Exception ex) { openTables.Remove(tableName); }

            }

            FormAbrirTabelaPersonalizada formAbrirTabelaPersonalizada = new FormAbrirTabelaPersonalizada(tableName, AuthenticationLocal.userId.ToString());
            formAbrirTabelaPersonalizada.Show();
            openTables.Add(tableName, formAbrirTabelaPersonalizada);

        }

        private void FormTabelasPersonalizadas_Load(object sender, EventArgs e)
        {
            createButtonOpenTables();
        }

        private void buttonSelecionarTabelas_Click(object sender, EventArgs e)
        {
            isSelectingTables = true;
        }

        private void cancelSelection()
        {
            isSelectingTables = false;
            int selectedButtonsCount = selectedButtons.Count;
            for (int i = 0; i < selectedButtonsCount; i++)
            {
                deselectButton(selectedButtons.First<Button>());
            }
        }

        private void buttonCancelarSelecao_Click(object sender, EventArgs e)
        {
            cancelSelection();
        }

        private void buttonDeletarTabela_Click(object sender, EventArgs e)
        {
            if (!isSelectingTables)
            {
                MessageBox.Show("Selecione uma ou mais tabelas para deletar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmation message to delete the tables
            DialogResult dialogResult = MessageBox.Show("Você tem certeza que deseja deletar as tabelas selecionadas?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            foreach (Button button in selectedButtons)
            {
                DataDeleter.deleteCustomTable(button.Text, AuthenticationLocal.userId.ToString());
            }

            cancelSelection();

            refreshCustomTables();

        }

        private void removeAllTableNameButtons()
        {
            int buttonsAmmount = flowLayoutPanelTables.Controls.Count;
            for (int i = 0; i < buttonsAmmount - 1; i++)
            {
                flowLayoutPanelTables.Controls.RemoveAt(1);
            }
        }

        private void refreshCustomTables()
        {
            removeAllTableNameButtons();
            createButtonOpenTables();
        }

        private void buttonRecarregar_Click(object sender, EventArgs e)
        {
            if (isSelectingTables)
            {
                MessageBox.Show("Você está selecionando tabelas para deletar, clique em cancelar seleção para recarregar as tabelas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            refreshCustomTables();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuClickOpen.formLoginOpen();
        }

        private void showCloudLoginScreen()
        {
            if (Application.OpenForms.OfType<FormLoginCloud>().Count() == 0)
            {
                FormLoginCloud formLoginCloud = new FormLoginCloud();
                formLoginCloud.Show();
            }
            else
            {
                FormShow.forceShowform(Application.OpenForms.OfType<FormLoginCloud>().First(), false);
            }
        }

        bool isSavingCloud = false;

        private async void buttonSalvarNuvem_Click(object sender, EventArgs e)
        {

            if (isSavingCloud)
            {
                MessageBox.Show("Aguarde até que o processo de salvar as tabelas na nuvem seja concluído", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            isSavingCloud = true;

            if (!isSelectingTables)
            {
                MessageBox.Show("Selecione uma ou mais tabelas para salvar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isSavingCloud = false;
                return;
            }

            if (AuthenticationCloud.IsAuthenticated == false)
            {
                showCloudLoginScreen();
                isSavingCloud = false;
                return;
            }

            // Create a list to hold the tasks
            List<Task> tasks = new List<Task>();

            foreach (Button button in selectedButtons)
            {
                // Add each task to the list
                tasks.Add(Task.Run(() => saveCustomTableToCloud(button, dataAdapter)));
            }

            // Wait for all the tasks to complete
            await Task.WhenAll(tasks);

            MessageBox.Show("Tabelas salvas com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            isSavingCloud = false;

        }

        private static void saveCustomTableToCloud(Button button, SqlDataAdapter dataAdapter)
        {
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            DataTable allAntibiotics = new DataTable();
            DataLoader.GetDataLocal("SELECT * FROM antibiotico", dataAdapter, allAntibiotics);
            DataTable customTable = new DataTable();
            customTable = DataLoader.getCustomAntibioticData(allAntibiotics, button.Text, AuthenticationLocal.userId.ToString(), dataAdapter);
            DataDeleter.deleteTableDataCloud(button.Text, AuthenticationCloud.userId.ToString(), mySqlDataAdapter);
            DataSaver.saveTabelaPersonalizadaCloud(customTable, button.Text, mySqlDataAdapter, AuthenticationCloud.userId.ToString());
        }


        private static string getTableDataString(DataTable dataTable)
        {
            string stringOutput = "";

            foreach (DataRow row in dataTable.Rows)
            {

                if (row.RowState == DataRowState.Deleted)
                {
                    continue;
                }

                stringOutput += $"ID: {row[0]}, Name: {row[1]}\n";

            }

            return stringOutput;


        }

        private void buttonCarregarNuvem_Click(object sender, EventArgs e)
        {
            if (isSavingCloud)
            {
                MessageBox.Show("Aguarde até que o processo de salvar as tabelas na nuvem seja concluído", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (AuthenticationCloud.IsAuthenticated == false)
            {
                showCloudLoginScreen();
                return;
            }


        }

        private static void loadCustomTableFromCloud(Button button, SqlDataAdapter dataAdapter)
        {
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            DataTable allAntibiotics = new DataTable();
            DataLoader.GetDataLocal("SELECT * FROM antibiotico", dataAdapter, allAntibiotics);
            DataTable customTable = new DataTable();
            customTable = DataLoader.getCustomAntibioticData(allAntibiotics, button.Text, AuthenticationLocal.userId.ToString(), dataAdapter);
            DataDeleter.deleteTableDataCloud(button.Text, AuthenticationCloud.userId.ToString(), mySqlDataAdapter);
            DataSaver.saveTabelaPersonalizadaCloud(customTable, button.Text, mySqlDataAdapter, AuthenticationCloud.userId.ToString());
        }
    }
}
