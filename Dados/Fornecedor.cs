using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class Fornecedor
    {
        public Fornecedor(int? iD, TipoPessoa tipoPessoaForncedor, string nome, int? numero, string rua, string bairro, string email, string celular, string cep, string complemento, string telefone, string cpf_Cnpj, string razao_Social)
        {
            ID = iD;
            tipoPessoa = tipoPessoaForncedor;
            Nome = nome;
            Numero = numero;
            Rua = rua;
            Bairro = bairro;
            Email = email;
            Celular = celular;
            Cep = cep;
            Complemento = complemento;
            Telefone = telefone;
            Cpf_Cnpj = cpf_Cnpj;
            Razao_Social = razao_Social;
        }

        public Fornecedor(int? iD, TipoPessoa tipoForncedor, string nome, string email, string celular)
        {
            ID = iD;
            //Numero = numero;
            tipoPessoa = tipoForncedor;
            Nome = nome;
            Numero = 0;
            Rua = "";
            Bairro = "";
            Email = email;
            Celular = celular;
            Cep = "";
            Complemento = "";
            Telefone = "";
            Cpf_Cnpj = "";
            Razao_Social = "";
        }

        public Fornecedor()
        {
            /*ID = 0;
            //Numero = 0;
            tipoPessoa = 0;
            Nome = "";
            Numero = 0;
            Rua = "";
            Bairro = "";
            Email = "";
            Celular = "";
            Cep = "";
            Complemento = "";
            Telefone = "";
            Cpf_Cnpj = "";
            Razao_Social = "";*/
        }

        public int? ID { get; set; }
        public TipoPessoa tipoPessoa { get; set; }
        public string Nome { get; set; }
        public int? Numero { get; set; }
        public string Rua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Complemento { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public string Cpf_Cnpj { get; set; }
        public string Razao_Social { get; set; }

    }
}
