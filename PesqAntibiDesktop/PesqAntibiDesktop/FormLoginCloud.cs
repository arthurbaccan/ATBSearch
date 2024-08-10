using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Dados;

namespace PesqAntibiDesktop
{
    public partial class FormLoginCloud : Form
    {
        private int maxFontSize = 20;
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private DataTable table = new DataTable();

        public FormLoginCloud()
        {
            InitializeComponent();
            InternetConnectionChecker.isInternetConnected();

            if (InternetConnectionChecker.wasThereConnection)
            {
                DataSync.syncAllAntibioticsData();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            placePanelLoginMiddle();
        }

        private void placePanelLoginMiddle()
        {
            int x = (this.ClientSize.Width - panelLogin.Width) / 2;
            int y = (this.ClientSize.Height - panelLogin.Height) / 2;
            panelLogin.Location = new System.Drawing.Point(x, y);
        }

        private void labelTituloTab_SizeChanged(object sender, EventArgs e)
        {
            FontSizer.updateFontSize(labelTituloTab, maxFontSize);
        }

        private void FormLogin_SizeChanged(object sender, EventArgs e)
        {
            placePanelLoginMiddle();
        }

        private int tryLoginWithInternet(bool testInternetConection=false)
        {
            int loginResult = AuthenticationCloud.login(textBoxEmailTelefone.Text, textBoxSenha.Text, false);

            if (loginResult == (int)TipoMensagemLogin.LOGIN_VAZIO)
            {
                MessageBox.Show("Preencha todos os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (loginResult == (int)TipoMensagemLogin.LOGIN_INCORRETO)
            {
                MessageBox.Show("Email/telefone ou senha inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (loginResult == (int)TipoMensagemLogin.SEM_CONEXAO_INTERNET)
            {
                DialogResult dialogResult = MessageBox.Show("Sem conexão com a internet.\nQuer tentar novamente?", "Erro", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dialogResult == DialogResult.Yes)
                {
                    tryLoginWithInternet(true);
                }
            }

            return loginResult;
        }

        private void closeOtherForms()
        {
            

            List<Form> formsToClose = new List<Form>();

            // close all open forms except this one
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name != this.Name)
                {
                    formsToClose.Add(form);
                }
            }

            foreach (Form form in formsToClose)
            {
                form.Close();
            }

            formsToClose.Clear();


            FormTabela formTabela = new FormTabela();
            formTabela.Show();
            
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            int loginResult = tryLoginWithInternet();   

            if (loginResult == (int)TipoMensagemLogin.LOGIN_SUCESSO)
            {
                closeOtherForms();
            }
        }
    }
}
