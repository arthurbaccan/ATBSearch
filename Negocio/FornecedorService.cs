using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dados;
using MySql.Data.MySqlClient;


namespace Negocio
{
    public class FornecedorService
    {
        private FornecedorRepository _repository;

        public FornecedorService()
        {
            _repository = new FornecedorRepository();
        }

        public string Update(int? id, TipoPessoa tipoPessoa, string nome, string email, int? numero, string rua, string bairro, string complemento, string celular, string cpfCnpj, string cep, string telefone, string razaoSocial)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            var fornecedor = new Fornecedor
            {
                ID = id,
                tipoPessoa = tipoPessoa,
                Nome = nome,
                Email = email,
                Numero = numero,
                Rua = rua,
                Bairro = bairro,
                Complemento = complemento,
                Celular = celular,
                Cpf_Cnpj = cpfCnpj,
                Cep = cep,
                Telefone = telefone,
                Razao_Social  = razaoSocial
            };

            if (id == null)
                return _repository.Insert(fornecedor);
            else
                return _repository.Update(fornecedor);

        }

        public string Insert(Fornecedor fornecedor)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            return _repository.Insert(fornecedor);

        }
        public string Remove(int idCliente)
        {
            // Insira as validações e regras de negócio aqui
            // Por exemplo, verificar se o email já está cadastrado

            return _repository.Remove(idCliente);

        }

        public DataTable getAll()
        {
            return _repository.getAll();
        }
        public DataTable filterByName(string nome)
        {
            return _repository.filterByName(nome);
        }

    }
}
