using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dados;

namespace Dados
{
    public class FornecedorRepository
    {

        public string Insert(Fornecedor fornecedor)
        {
            string resp = "";
            try
            {
                Connection.getConnection();

                MySqlCommand SqlCmd = new MySqlCommand
                {
                    Connection = Connection.SqlCon,
                    CommandText = "INSERT INTO Fornecedor (tipoPessoa, nome, numero, rua, bairro, complemento, email, celular, cep, telefone, cpfCnpj, razaoSocial) VALUES (@pTipoPessoa, @pNome, @pNumero, @pRua, @pBairro, @pComplemento, @pEmail, @pCelular, @pCep, @pTelefone, @pCpfCnpj, @pRazaoSocial)",
                    CommandType = CommandType.Text
                };
                SqlCmd.Parameters.AddWithValue("pNome", fornecedor.Nome);
                SqlCmd.Parameters.AddWithValue("pEmail", fornecedor.Email);
                SqlCmd.Parameters.AddWithValue("pTipoPessoa", fornecedor.tipoPessoa);
                SqlCmd.Parameters.AddWithValue("pNumero", fornecedor.Numero);
                SqlCmd.Parameters.AddWithValue("pRua", fornecedor.Rua);
                SqlCmd.Parameters.AddWithValue("pBairro", fornecedor.Bairro);
                SqlCmd.Parameters.AddWithValue("pComplemento", fornecedor.Complemento);
                SqlCmd.Parameters.AddWithValue("pCelular", fornecedor.Celular);
                SqlCmd.Parameters.AddWithValue("pCep", fornecedor.Cep);
                SqlCmd.Parameters.AddWithValue("pTelefone", fornecedor.Telefone);
                SqlCmd.Parameters.AddWithValue("pCpfCnpj", fornecedor.Cpf_Cnpj);
                SqlCmd.Parameters.AddWithValue("pRazaoSocial", fornecedor.Razao_Social);

            //executa o stored procedure
            resp = SqlCmd.ExecuteNonQuery() == 1 ? "SUCESSO" : "FALHA";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (Connection.SqlCon.State == ConnectionState.Open)
                    Connection.SqlCon.Close();
            }

            return resp;
        }

        public string Update(Fornecedor fornecedor)
        {
            string resp = "";
            try
            {
                Connection.getConnection();

                string updateSql = "UPDATE Fornecedor SET " +
                                    "nome = @pNome, " +
                                    "tipoPessoa = @pTipoPessoa, " +
                                    "numero = @pNumero, " +
                                    "rua = @pRua, " +
                                    "bairro = @pBairro, " +
                                    "complemento = @pComplemento, " +
                                    "email = @pEmail, " +
                                    "celular = @pCelular, " +
                                    "cep = @pCep, " +
                                    "telefone = @pTelefone, " +
                                    "CpfCnpj = @pCpfCnpj, " +
                                    "razaoSocial = @pRazaoSocial " +
                                    "WHERE id = @pId";

                MySqlCommand SqlCmd = new MySqlCommand(updateSql, Connection.SqlCon);
                SqlCmd.Parameters.AddWithValue("pNome", fornecedor.Nome);
                SqlCmd.Parameters.AddWithValue("pTipoPessoa", fornecedor.tipoPessoa);
                SqlCmd.Parameters.AddWithValue("pNumero", fornecedor.Numero);
                SqlCmd.Parameters.AddWithValue("pRua", fornecedor.Rua);
                SqlCmd.Parameters.AddWithValue("pBairro", fornecedor.Bairro);
                SqlCmd.Parameters.AddWithValue("pComplemento", fornecedor.Complemento);
                SqlCmd.Parameters.AddWithValue("pEmail", fornecedor.Email);
                SqlCmd.Parameters.AddWithValue("pCelular", fornecedor.Celular);
                SqlCmd.Parameters.AddWithValue("pCep", fornecedor.Cep);
                SqlCmd.Parameters.AddWithValue("pTelefone", fornecedor.Telefone);
                SqlCmd.Parameters.AddWithValue("pCpfCnpj", fornecedor.Cpf_Cnpj);
                SqlCmd.Parameters.AddWithValue("pRazaoSocial", fornecedor.Razao_Social);
                SqlCmd.Parameters.AddWithValue("pId", fornecedor.ID);

                // Execute o comando SQL e verifique se foi bem-sucedido
                int rowsAffected = SqlCmd.ExecuteNonQuery();
                resp = rowsAffected == 1 ? "SUCESSO" : "Nenhum registro atualizado";

            }
            catch (Exception ex)
            {
                resp = "Erro ao atualizar registro: " + ex.Message;
            }
            finally
            {
                // Certifique-se de fechar a conexão
                if (Connection.SqlCon.State == ConnectionState.Open)
                    Connection.SqlCon.Close();
            }
            return resp;
        }


        public string Remove(int idFornecedor)
        {
            string resp = "";
            try
            {
                Connection.getConnection();

                string updateSql = String.Format("DELETE FROM Fornecedor " +
                                    "WHERE id = @pId ");
                MySqlCommand SqlCmd = new MySqlCommand(updateSql, Connection.SqlCon);
                SqlCmd.Parameters.AddWithValue("pId", idFornecedor);

                //executa o stored procedure
                resp = SqlCmd.ExecuteNonQuery() == 1 ? "SUCESSO" : "FALHA";
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (Connection.SqlCon.State == ConnectionState.Open)
                    Connection.SqlCon.Close();
            }
            return resp;
        }

        public DataTable getAll()
        {
            DataTable DtResultado = new DataTable("fornecedor");
            try
            {
                Connection.getConnection();
                String sqlSelect = "select * from Fornecedor";

                MySqlCommand SqlCmd = new MySqlCommand();
                SqlCmd.Connection = Connection.SqlCon;
                SqlCmd.CommandText = sqlSelect;
                SqlCmd.CommandType = CommandType.Text;
                MySqlDataAdapter SqlData = new MySqlDataAdapter(SqlCmd);
                SqlData.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public DataTable filterByName(string pNome)
        {
            DataTable DtResultado = new DataTable("fornecedor");
            string selectSql;
            try
            {
                Connection.getConnection();
                if (!string.IsNullOrEmpty(pNome))
                {
                    selectSql = String.Format("SELECT * FROM Fornecedor WHERE nome LIKE @pNome");
                    pNome = '%' + pNome + '%';
                }
                else
                {
                    selectSql = String.Format("SELECT * FROM Fornecedor");
                }
                MySqlCommand SqlCmd = new MySqlCommand(selectSql, Connection.SqlCon);
                if (!string.IsNullOrEmpty(pNome))
                    SqlCmd.Parameters.AddWithValue("pNome", pNome);
                MySqlDataAdapter SqlData = new MySqlDataAdapter(SqlCmd);
                SqlData.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
    }
}
