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
using Negocio;
using MySql.Data.MySqlClient;
using FluentValidation.Results;

namespace Apresentacao
{
    public partial class frmFornecedor : Form
    {
        private readonly FornecedorService _fornecedorService ;
        private DataTable tblFornecedor = new DataTable();

        //sinaliza qual operação está em andamento
        //0 = nada
        //1 = inclusão (novo)
        //2 = alteração
        private int modo = 0; //sinaliza qual operação está em andamento
        public frmFornecedor()
        {
            InitializeComponent();
            _fornecedorService = new FornecedorService();

            dgFornecedor.Columns.Add("Id", "ID");
            dgFornecedor.Columns.Add("Nome", "NOME");
            dgFornecedor.Columns.Add("TipoPessoa", "TIPO PESSOA");
            dgFornecedor.Columns.Add("email", "EMAIL");
            dgFornecedor.Columns.Add("Numero", "NUMERO"); 
            dgFornecedor.Columns.Add("Rua", "RUA"); 
            dgFornecedor.Columns.Add("Bairro", "BAIRRO"); 
            dgFornecedor.Columns.Add("Complemento", "COMPLEMENTO"); 
            dgFornecedor.Columns.Add("Celular", "CELULAR"); 
            dgFornecedor.Columns.Add("Cep", "CEP"); 
            dgFornecedor.Columns.Add("Telefone", "TELEFONE"); 
            dgFornecedor.Columns.Add("CpfCnpj", "CPF/CNPJ"); 
            dgFornecedor.Columns.Add("RazaoSocial", "RAZÃO SOCIAL"); 

            dgFornecedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgFornecedor.AllowUserToAddRows = false;
            dgFornecedor.AllowUserToDeleteRows = false;
            dgFornecedor.AllowUserToOrderColumns = true;
            dgFornecedor.ReadOnly = true;

            tblFornecedor = _fornecedorService.getAll();
        }


        private void cadastroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmCliente>().Count() >= 1)
            {
                Application.OpenForms.OfType<frmCliente>().First().Focus();
                return;
            }

            frmCliente formCliente = new frmCliente();
            formCliente.Show();
        }

        private void HabilitaFornecedor()
        {
            switch (modo)
            {
                case 0: //neutro
                    btnInclui.Enabled = true;
                    btnAltera.Enabled = true;
                    btnExclui.Enabled = true;
                    btnSalva.Enabled = false;
                    btnCancela.Enabled = false;
                    grpDados.Enabled = true;
                    txtNome.Enabled = false;
                    txtEmail.Enabled = false;
                    txtId.Enabled = false;
                    txtNumero.Enabled = false;
                    txtRua.Enabled = false; 
                    txtBairro.Enabled = false;
                    txtComplemento.Enabled = false;
                    txtCelular.Enabled = false; 
                    txtCep.Enabled = false; 
                    txtTelefone.Enabled = false; 
                    txtCpfCnpj.Enabled = false; 
                    txtRazaoSocial.Enabled = false; 
                    radioPessoaFisica.Enabled = false;
                    radioPessoaJuridica.Enabled = false;
                    dgFornecedor.Enabled = true;
                    break;
                case 1: //inclusão
                    btnInclui.Enabled = false;
                    btnAltera.Enabled = false;
                    btnExclui.Enabled = false;
                    btnSalva.Enabled = true;
                    btnCancela.Enabled = true;
                    grpDados.Enabled = true;
                    txtNome.Enabled = true;
                    txtEmail.Enabled = true;
                    txtId.Enabled = true;
                    txtNumero.Enabled = true; 
                    txtRua.Enabled = true; 
                    txtBairro.Enabled = true; 
                    txtComplemento.Enabled = true; 
                    txtCelular.Enabled = true; 
                    txtCep.Enabled = true; 
                    txtTelefone.Enabled = true; 
                    txtCpfCnpj.Enabled = true; 
                    txtRazaoSocial.Enabled = true; 
                    radioPessoaFisica.Enabled = true;
                    radioPessoaJuridica.Enabled = true;
                    dgFornecedor.Enabled = false;
                    break;
                case 2: //alteração
                    btnInclui.Enabled = false;
                    btnAltera.Enabled = false;
                    btnExclui.Enabled = false;
                    btnSalva.Enabled = true;
                    btnCancela.Enabled = true;
                    grpDados.Enabled = true;
                    txtNome.Enabled = true;
                    txtEmail.Enabled = true;
                    txtId.Enabled = true;
                    txtNumero.Enabled = true; 
                    txtRua.Enabled = true; 
                    txtBairro.Enabled = true; 
                    txtComplemento.Enabled = true; 
                    txtCelular.Enabled = true; 
                    txtCep.Enabled = true; 
                    txtTelefone.Enabled = true; 
                    txtCpfCnpj.Enabled = true;
                    txtRazaoSocial.Enabled = true;
                    radioPessoaFisica.Enabled = true;
                    radioPessoaJuridica.Enabled = true;
                    dgFornecedor.Enabled = false;
                    break;
            }
        }

        public void LimpaFormFornecedor()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtId.Clear();
            txtNumero.Clear();
            txtRua.Clear();
            txtBairro.Clear();
            txtComplemento.Clear();
            txtCelular.Clear();
            txtCep.Clear();
            txtTelefone.Clear();
            txtCpfCnpj.Clear();
            txtRazaoSocial.Clear();
            radioPessoaFisica.Checked = false;
            radioPessoaJuridica.Checked = false;

            txtNome.Focus();
        }

        private void frmFornecedor_Load(object sender, System.EventArgs e)
        {
            radioPessoaFisica.Text = TipoPessoa.PESSOA_FISICA.ToString();
            radioPessoaJuridica.Text = TipoPessoa.PESSOA_JURIDICA.ToString();

            dgFornecedor.ColumnCount = 13;
            dgFornecedor.AutoGenerateColumns = false;
            dgFornecedor.Columns[0].Width = 20;
            dgFornecedor.Columns[0].HeaderText = "ID";
            dgFornecedor.Columns[0].DataPropertyName = "Id";
            dgFornecedor.Columns[1].Width = 275;
            dgFornecedor.Columns[1].HeaderText = "NOME";
            dgFornecedor.Columns[1].DataPropertyName = "Nome";
            dgFornecedor.Columns[2].Width = 100;
            dgFornecedor.Columns[2].HeaderText = "TIPO";
            dgFornecedor.Columns[2].DataPropertyName = "TipoPessoa";
            dgFornecedor.Columns[3].Width = 300;
            dgFornecedor.Columns[3].HeaderText = "EMAIL";
            dgFornecedor.Columns[3].DataPropertyName = "Email";
            dgFornecedor.Columns[4].Width = 100;
            dgFornecedor.Columns[4].HeaderText = "NUMERO";
            dgFornecedor.Columns[4].DataPropertyName = "Numero";
            dgFornecedor.Columns[5].Width = 150;
            dgFornecedor.Columns[5].HeaderText = "RUA";
            dgFornecedor.Columns[5].DataPropertyName = "Rua";
            dgFornecedor.Columns[6].Width = 100;
            dgFornecedor.Columns[6].HeaderText = "BAIRRO";
            dgFornecedor.Columns[6].DataPropertyName = "Bairro";
            dgFornecedor.Columns[7].Width = 100;
            dgFornecedor.Columns[7].HeaderText = "COMPLEMENTO";
            dgFornecedor.Columns[7].DataPropertyName = "Complemento";
            dgFornecedor.Columns[8].Width = 100;
            dgFornecedor.Columns[8].HeaderText = "CELULAR";
            dgFornecedor.Columns[8].DataPropertyName = "Celular";
            dgFornecedor.Columns[9].Width = 100;
            dgFornecedor.Columns[9].HeaderText = "CEP";
            dgFornecedor.Columns[9].DataPropertyName = "Cep";
            dgFornecedor.Columns[10].Width = 100;
            dgFornecedor.Columns[10].HeaderText = "TELEFONE";
            dgFornecedor.Columns[10].DataPropertyName = "Telefone";
            dgFornecedor.Columns[11].Width = 100;
            dgFornecedor.Columns[11].HeaderText = "CPF/CNPJ";
            dgFornecedor.Columns[11].DataPropertyName = "CpfCnpj";
            dgFornecedor.Columns[12].Width = 100;
            dgFornecedor.Columns[12].HeaderText = "RAZÃO SOCIAL";
            dgFornecedor.Columns[12].DataPropertyName = "RazaoSocial";

            dgFornecedor.AllowUserToAddRows = false;
            dgFornecedor.AllowUserToDeleteRows = false;
            dgFornecedor.MultiSelect = false;
            dgFornecedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            carregaGridViewFornecedor();
        }

        private void carregaGridViewFornecedor()
        {
            dgFornecedor.DataSource = _fornecedorService.getAll();
            dgFornecedor.Refresh();
        }

        private void dgFornecedor_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (dgv.CurrentRow == null)
                return;

            // Limpa os TextBoxes
            txtId.Text = dgv.CurrentRow.Cells["Id"].Value.ToString();
            txtNome.Text = dgv.CurrentRow.Cells["Nome"].Value.ToString();
            txtEmail.Text = dgv.CurrentRow.Cells["Email"].Value.ToString();
            txtNumero.Text = dgv.CurrentRow.Cells["Numero"].Value.ToString();
            txtRua.Text = dgv.CurrentRow.Cells["Rua"].Value.ToString();
            txtBairro.Text = dgv.CurrentRow.Cells["Bairro"].Value.ToString();
            txtComplemento.Text = dgv.CurrentRow.Cells["Complemento"].Value.ToString();
            txtCelular.Text = dgv.CurrentRow.Cells["Celular"].Value.ToString();
            txtCep.Text = dgv.CurrentRow.Cells["Cep"].Value.ToString();
            txtTelefone.Text = dgv.CurrentRow.Cells["Telefone"].Value.ToString();
            txtCpfCnpj.Text = dgv.CurrentRow.Cells["CpfCnpj"].Value.ToString();
            txtRazaoSocial.Text = dgv.CurrentRow.Cells["RazaoSocial"].Value.ToString();
            if (dgv.CurrentRow.Cells["TipoPessoa"].Value.ToString() == ((int)TipoPessoa.PESSOA_FISICA).ToString())
                radioPessoaFisica.Checked = true;
            else
                radioPessoaJuridica.Checked = true;
        }


        private void btnAltera_Click(object sender, EventArgs e)
        {
            modo = 2; //alteração
            HabilitaFornecedor();
        }

        private void btnInclui_Click(object sender, EventArgs e)
        {
            modo = 1; //inclusão
            HabilitaFornecedor();
            LimpaFormFornecedor();
            radioPessoaFisica.Checked = true;
        }

        // retorna false se o campo estiver nulo (falhou a checagem)
        private bool checaNulo(TextBox campo, string nome)
        {
            if (string.IsNullOrEmpty(campo.Text))
            {
                MessageBox.Show("O campo " + nome + " não pode ser nulo", "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
             
        }

        private bool checaCPF_CNPJ(TextBox campo)
        {
            if (campo.Text.Length != 11 && radioPessoaFisica.Checked)
            {
                MessageBox.Show("O campo CPF/CNPJ deve ter 11 dígitos para pessoa Física", "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (campo.Text.Length != 14 && radioPessoaJuridica.Checked)
            {
                MessageBox.Show("O campo CPF/CNPJ deve ter 14 dígitos para pessoa Jurídica", "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool soTemNumeros(TextBox campo, string nome)
        {
            if (campo.Text.Any(c => !char.IsDigit(c)))
            {
                MessageBox.Show("O campo " + nome + " deve conter apenas números", "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool temArroba(TextBox campo, string nome)
        {
            if (!campo.Text.Contains("@"))
            {
                MessageBox.Show("O campo " + nome + " deve conter um \"@\"", "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool checaCelular(TextBox campo)
        {
            if (campo.Text.Length != 11)
            {
                MessageBox.Show("O campo Celular deve conter 11 dígitos (ddd123456789)", "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool checaMaskBox(MaskedTextBox campo, string msg)
        {
            if (!campo.MaskFull)
            {
                MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool checaNulo(MaskedTextBox campo, string msg)
        {
            campo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (campo.Text == string.Empty)
            {
                MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private bool checaTelefone(MaskedTextBox campo)
        {
            campo.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (campo.Text == string.Empty)
                return true;

            if (!campo.MaskFull)
            {
                MessageBox.Show("O telefone deve ser vazio ou completo", "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            int id = 0;
            string resultado;
            string msg;

            if (String.IsNullOrEmpty(txtId.Text))
                id = -1;
            else
                id = Convert.ToInt32(txtId.Text);

            txtCelular.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            string nome = txtNome.Text; // validado
            string email = txtEmail.Text; // validado
            string rua = txtRua.Text; // validado
            string bairro = txtBairro.Text; // validado
            string complemento = txtComplemento.Text; // não precisa
            string celular = txtCelular.Text;// validado
            string cep = txtCep.Text; // validado
            string telefone = txtTelefone.Text; // validado
            string cpfCnpj = txtCpfCnpj.Text; // validado
            string razaoSocial = txtRazaoSocial.Text; // validado
            int numero;
            try
            {
                numero = int.Parse(txtNumero.Text); // validado
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite apenas números no campo Número!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Fornecedor fornecedor = new Fornecedor();

            fornecedor.Nome = nome;
            fornecedor.Email = email;
            fornecedor.Rua = rua;
            fornecedor.Bairro = bairro;
            fornecedor.Complemento = complemento;
            fornecedor.Celular = celular;
            fornecedor.Cep = cep;
            fornecedor.Telefone = telefone;
            fornecedor.Cpf_Cnpj = cpfCnpj;
            fornecedor.Razao_Social = razaoSocial;

            //Inicio da validação
            if (fornecedor != null)
            {
                FornecedorValidator validator = new FornecedorValidator();
                ValidationResult results = validator.Validate(fornecedor);
                IList<ValidationFailure> failures = results.Errors;
                if (!results.IsValid)
                {
                    foreach (ValidationFailure failure in failures)
                    {
                        MessageBox.Show(failure.ErrorMessage, "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            //Fim da validação

            if (checaMaskBox(txtCep, "O campo CEP deve estar preenchido") == false) return;

            //if (checaNulo(txtTelefone, "Telefone") == false) return;

            if (checaNulo(txtCpfCnpj, "CPF/CNPJ") == false) return;
            if (soTemNumeros(txtCpfCnpj, "CPF/CNPJ") == false) return;
            if (checaCPF_CNPJ(txtCpfCnpj) == false) return;

            //if (checaNulo(txtRazaoSocial, "Razão Social") == false) return;
            //if (checaNulo(txtNumero, "Número") == false) return;

            //Campos comentados acima não são obrigatórios

            // checa o número de telefone se ele tiver sido digitado
            if (checaTelefone(txtTelefone) == false) return;

            int? numero = null;

            if (checaNulo(txtNumero, "Número") == false) return;
            
            try
            {
                
                
                numero = int.Parse(txtNumero.Text);
                if (numero < 0)
                {
                    MessageBox.Show("O campo Número não pode ser negativo", "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Valor para Número inválido", "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            


            
            TipoPessoa tp = radioPessoaFisica.Checked ? TipoPessoa.PESSOA_FISICA : TipoPessoa.PESSOA_JURIDICA;

            if (modo == 1) //inclusão
            {
                resultado = _fornecedorService.Update(null, tp, nome, email, numero, rua, bairro, complemento, celular, cpfCnpj, cep, telefone, razaoSocial);
                if (resultado == "SUCESSO")
                {
                    msg = "FORNECEDOR cadastrado com sucesso!";
                    carregaGridViewFornecedor();
                }
                else
                {
                    msg = "Falha ao cadastrar FORNECEDOR!";
                }
                MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (modo == 2) //alteração
            {
                resultado = _fornecedorService.Update(id, tp, nome, email, numero, rua, bairro, complemento, celular, cpfCnpj, cep, telefone, razaoSocial);
                if (resultado == "SUCESSO")
                {
                    msg = "FORNECEDOR atualizado com sucesso!";
                    carregaGridViewFornecedor();
                }
                else
                {
                    msg = "Falha ao atualizar FORNECEDOR!";
                }
                MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            modo = 0; //neutro
            HabilitaFornecedor();
        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            string resultado;
            String msg;
            DialogResult resposta;
            resposta = MessageBox.Show("Confirma exclusão?", "Aviso do sistema!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resposta == DialogResult.OK)
            {
                int idFornecedor = Convert.ToInt32(txtId.Text);
                resultado = _fornecedorService.Remove(idFornecedor);
                if (resultado == "SUCESSO")
                {
                    msg = "FORNECEDOR excluido com sucesso!";
                    carregaGridViewFornecedor();
                }
                else
                {
                    msg = "Falha ao excluir FORNECEDOR!";
                }
                MessageBox.Show(msg, "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            modo = 0; //neutro
            HabilitaFornecedor();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            frmPrompt f = new frmPrompt();
            string txtBusca = "";
            f.ShowDialog();
            txtBusca = f.Texto;
            DataTable tbFornecedores = _fornecedorService.filterByName(txtBusca);
            if (tbFornecedores != null)
            {
                dgFornecedor.DataSource = tbFornecedores;
                dgFornecedor.Refresh();
            }
        }
    }
}
