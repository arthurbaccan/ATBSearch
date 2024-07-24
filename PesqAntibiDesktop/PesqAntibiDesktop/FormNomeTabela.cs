using Dados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesqAntibiDesktop
{
    public partial class FormNomeTabela : Form
    {
        private DataTable tableAdicionar;
        private SqlDataAdapter dataAdapter;
        private string userId;
        public FormNomeTabela(DataTable tableAdicionar, SqlDataAdapter dataAdapter, string userId)
        {
            InitializeComponent();
            this.tableAdicionar = tableAdicionar;
            this.dataAdapter = dataAdapter;
            this.userId = userId;
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {

            int result = DataSaver.saveTabelaPersonalizadaLocal(tableAdicionar, textBoxNomeTabela.Text, dataAdapter, userId);
            if(result == 1)
            {
                MessageBox.Show("Tabela salva com sucesso!");
                this.Close();
            }
            else if(result == (int)TipoErroSalvarTabela.NOME_TABELA_JA_EXISTE)
            {
                MessageBox.Show("Já existe uma tabela com esse nome. Por favor, escolha outro nome.");
            }
            else if(result == (int)TipoErroSalvarTabela.TABELA_VAZIA)
            {
                MessageBox.Show("A tabela está vazia. Por favor, adicione pelo menos um antibiótico.");
            }
            else
            {
                MessageBox.Show("Erro ao salvar a tabela. Por favor, tente novamente.");
            }
        }
    }
}
