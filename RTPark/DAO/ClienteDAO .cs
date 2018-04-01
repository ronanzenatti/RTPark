using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RTPark.Entidades;
using System.Windows.Forms;
using System.Data;
using System.Globalization;
using System.Security.Cryptography;

namespace RTPark.DAO
{
    class ClienteDAO
    {
        Conexao con;

        public int Inserir(Clientes obj)
        {
            try
            {
                con = new Conexao();
                con.Conectar();

                String sql = "INSERT INTO clientes (nome, tipo_pessoa, doc_fed, doc_est, dt_nasc, rua, numero, bairro, cidade, estado, cep, telefones, email) VALUES(";
                sql += "'" + obj.Nome.Replace("'", "''") + "', ";
                sql += "'" + obj.Tipo_pessoa + "', ";
                sql += "'" + obj.Doc_fed.Replace("'", "''") + "', ";
                sql += "'" + obj.Doc_est.Replace("'", "''") + "', ";
                sql += "'" + obj.Dt_nasc.Replace("'", "''") + "', ";
                sql += "'" + obj.Rua.Replace("'", "''") + "', ";
                sql += "'" + obj.Numero.Replace("'", "''") + "', ";
                sql += "'" + obj.Bairro.Replace("'", "''") + "', ";
                sql += "'" + obj.Cidade.Replace("'", "''") + "', ";
                sql += "'" + obj.Estado + "', ";
                sql += "'" + obj.Cep.Replace("'", "''") + "', ";
                sql += "'" + obj.Telefones.Replace("'", "''") + "', ";
                sql += "'" + obj.Email.Replace("'", "''") + "'); "; 
                sql += "SELECT LAST_INSERT_ID();";
                sql = sql.Replace("''", "NULL");
                System.Console.WriteLine(sql);
                int id = Convert.ToInt32(con.ExecutarComandoSQLRetorno(sql));

                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Cliente !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                con = null;
            }
        }


        public void Alterar(Clientes obj)
        {
            try
            {
                con = new Conexao();
                con.Conectar();
                String sql = "UPDATE clientes SET";
                sql += " nome = '" + obj.Nome.Replace("'", "''") + "', ";
                sql += " tipo_pessoa = '" + obj.Tipo_pessoa + "', ";
                sql += " doc_fed = '" + obj.Doc_fed.Replace("'", "''") + "', ";
                sql += " doc_est = '" + obj.Doc_est.Replace("'", "''") + "', ";
                sql += " dt_nasc = '" + obj.Dt_nasc.Replace("'", "''") + "', ";
                sql += " rua = '" + obj.Rua.Replace("'", "''") + "', ";
                sql += " numero = '" + obj.Numero.Replace("'", "''") + "', ";
                sql += " bairro = '" + obj.Bairro.Replace("'", "''") + "', ";
                sql += " cidade = '" + obj.Cidade.Replace("'", "''") + "', ";
                sql += " estado = '" + obj.Estado + "', ";
                sql += " cep = '" + obj.Cep.Replace("'", "''") + "', ";
                sql += " telefones = '" + obj.Telefones.Replace("'", "''") + "', ";
                sql += " email = '" + obj.Email.Replace("'", "''") + "' ";                
                sql += " WHERE idcliente = " + obj.Idcliente + ";";
                sql = sql.Replace("''", "NULL");
                con.ExecutarComandoSQL(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o Cliente !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con = null;
            }
        }

        public void Excluir(int id)
        {
            try
            {
                con = new Conexao();
                con.Conectar();
                String sql = "DELETE FROM clientes WHERE idcliente = " + id + ";";
                con.ExecutarComandoSQL(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o Cliente !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con = null;
            }
        }

        public DataTable listarTodos()
        {
            DataTable dt = new DataTable();
            try
            {
                con = new Conexao();
                con.Conectar();

                String sql = "SELECT idcliente AS ID, tipo_pessoa AS Tipo, nome AS Nome, doc_fed AS `CPF/CNPJ`, doc_est AS `RG/IE`, dt_nasc AS Nascimento, rua AS Rua, numero AS `Num`, " +
                    "bairro AS Bairro, cidade AS Cidade, estado AS UF, cep AS CEP, telefones AS Telefones, email AS `E-mail` FROM clientes";
                dt = con.RetDataTable(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar todos os registros !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con = null;
            return dt;
        }

        public DataTable BuscaPorCampo(string campo, string busca)
        {
            DataTable dt = new DataTable();
            try
            {
                con = new Conexao();
                con.Conectar();
                String sql = "SELECT idcliente, nome, tipo_pessoa, doc_fed, doc_est, dt_nasc, rua, numero, bairro, cidade, estado, cep, telefones, email FROM clientes";
                sql += " WHERE " + campo + " LIKE '%" + busca + "%';";
                dt = con.RetDataTable(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar os registros !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con = null;
            return dt;
        }

        public Clientes GetById(int id)
        {
            Clientes obj = new Clientes();
            try
            {
                con = new Conexao();
                con.Conectar();
                String sql = "SELECT idcliente, nome, tipo_pessoa, doc_fed, doc_est, dt_nasc, rua, numero, bairro, cidade, estado, cep, telefones, email FROM clientes";
                sql += " WHERE idcliente = " + id;

                var dados = con.RetDataReader(sql);

                dados.Read();

                obj.Idcliente = Convert.ToInt32(dados["idcliente"].ToString());
                obj.Nome = dados["nome"].ToString();
                obj.Tipo_pessoa = dados["tipo_pessoa"].ToString()[0];
                obj.Doc_fed = dados["doc_fed"].ToString();
                obj.Doc_est = dados["doc_est"].ToString();
                obj.Dt_nasc = dados["dt_nasc"].ToString();
                obj.Rua = dados["rua"].ToString();
                obj.Numero = dados["numero"].ToString();
                obj.Bairro = dados["bairro"].ToString();
                obj.Cidade = dados["cidade"].ToString();
                obj.Estado = dados["estado"].ToString();
                obj.Cep = dados["cep"].ToString();
                obj.Telefones = dados["telefones"].ToString();
                obj.Email = dados["email"].ToString();
            }
            catch (FormatException e)
            {
                MessageBox.Show("Erro ao converter !!! \n" + e.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar os registros (BY ID) !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con = null;
            return obj;
        }
    }
}
