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

                String sql = "INSERT INTO clientes (nome, cpf, rg, dt_nasc, rua, numero, bairro, cidade, estado, cep, telefones, email, salario, usuario, senha, tipo, ativo) VALUES(";
                sql += "'" + obj.Nome.Replace("'", "''") + "', ";
                sql += "'" + obj.Cpf.Replace("'", "''") + "', ";
                sql += "'" + obj.Rg.Replace("'", "''") + "', ";
                sql += "'" + obj.Dt_nasc.Replace("'", "''") + "', ";
                sql += "'" + obj.Rua.Replace("'", "''") + "', ";
                sql += "'" + obj.Numero.Replace("'", "''") + "', ";
                sql += "'" + obj.Bairro.Replace("'", "''") + "', ";
                sql += "'" + obj.Cidade.Replace("'", "''") + "', ";
                sql += "'" + obj.Estado + "', ";
                sql += "'" + obj.Cep.Replace("'", "''") + "', ";
                sql += "'" + obj.Telefones.Replace("'", "''") + "', ";
                sql += "'" + obj.Email.Replace("'", "''") + "', ";
                sql += "'" + obj.Salario.ToString(new CultureInfo("en-US")) + "', ";
                sql += "'" + obj.Usuario.Replace("'", "''") + "', ";
                sql += "'" + Encode64.Base64Encode(Encode64.Base64Encode(obj.Senha.Replace("'", "''"))) + "', ";
                sql += "'" + obj.Tipo + "', ";
                sql += "'" + obj.Ativo + "');";
                sql += "SELECT LAST_INSERT_ID();";
                sql = sql.Replace("''", "NULL");
                System.Console.WriteLine(sql);
                int id = Convert.ToInt32(con.ExecutarComandoSQLRetorno(sql));

                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Funcionário !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                sql += " cpf = '" + obj.Cpf.Replace("'", "''") + "', ";
                sql += " rg = '" + obj.Rg.Replace("'", "''") + "', ";
                sql += " dt_nasc = '" + obj.Dt_nasc.Replace("'", "''") + "', ";
                sql += " rua = '" + obj.Rua.Replace("'", "''") + "', ";
                sql += " numero = '" + obj.Numero.Replace("'", "''") + "', ";
                sql += " bairro = '" + obj.Bairro.Replace("'", "''") + "', ";
                sql += " cidade = '" + obj.Cidade.Replace("'", "''") + "', ";
                sql += " estado = '" + obj.Estado + "', ";
                sql += " cep = '" + obj.Cep.Replace("'", "''") + "', ";
                sql += " telefones = '" + obj.Telefones.Replace("'", "''") + "', ";
                sql += " email = '" + obj.Email.Replace("'", "''") + "', ";
                sql += " salario = '" + obj.Salario + "', ";
                sql += " usuario = '" + obj.Usuario.Replace("'", "''") + "', ";
                sql += " usuario = '" + Encode64.Base64Encode(Encode64.Base64Encode(obj.Senha.Replace("'", "''"))) + "', ";
                sql += " tipo = '" + obj.Tipo + "', ";
                sql += " ativo = '" + obj.Ativo + "'";
                sql += " WHERE idcliente = " + obj.Idcliente + ";";
                sql = sql.Replace("''", "NULL");
                con.ExecutarComandoSQL(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o Funcionário !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Erro ao excluir o Funcionário !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                String sql = "SELECT idcliente AS ID, nome AS Nome, cpf AS CPF, rg AS RG, dt_nasc AS Nascimento, rua AS Rua, numero AS `Num`, " +
                    "bairro AS Bairro, cidade AS Cidade, estado AS UF, cep AS CEP, telefones AS Telefones, email AS `E-mail`, salario AS Salario, " +
                    "usuario AS Usuario, tipo AS Tipo, ativo AS Ativo FROM clientes";
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
                String sql = "SELECT idcliente, nome, cpf, rg, dt_nasc, rua, numero, bairro, cidade, estado, cep, telefones, email, salario, usuario, tipo, ativo FROM clientes";
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
                String sql = "SELECT idcliente, nome, cpf, rg, dt_nasc, rua, numero, bairro, cidade, estado, cep, telefones, email, salario, usuario, senha, tipo, ativo FROM clientes";
                sql += " WHERE idcliente = " + id;

                var dados = con.RetDataReader(sql);

                dados.Read();

                obj.Idcliente = Convert.ToInt32(dados["idcliente"].ToString());
                obj.Nome = dados["nome"].ToString();
                obj.Cpf = dados["cpf"].ToString();
                obj.Rg = dados["rg"].ToString();
                obj.Dt_nasc = dados["dt_nasc"].ToString();
                obj.Rua = dados["rua"].ToString();
                obj.Numero = dados["numero"].ToString();
                obj.Bairro = dados["bairro"].ToString();
                obj.Cidade = dados["cidade"].ToString();
                obj.Estado = dados["estado"].ToString();
                obj.Cep = dados["cep"].ToString();
                obj.Telefones = dados["telefones"].ToString();
                obj.Email = dados["email"].ToString();
                obj.Salario = Convert.ToDecimal(dados["salario"].ToString(), new CultureInfo("en-US"));
                obj.Usuario = dados["usuario"].ToString();
                obj.Senha = dados["senha"].ToString();
                obj.Tipo = Convert.ToChar(dados["tipo"].ToString());
                obj.Ativo = Convert.ToInt32(dados["ativo"]);

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

        public Clientes Login(String usr, String senha)
        {
            Clientes obj = new Clientes();
            try
            {
                con = new Conexao();
                con.Conectar();
                String sql = "SELECT idcliente, nome, cpf, rg, dt_nasc, rua, numero, bairro, cidade, estado, cep, telefones, email," +
                    " salario, usuario, senha, tipo, ativo FROM clientes";
                sql += " WHERE usuario = '" + usr + "' AND senha = '" + senha + "';";

                var dados = con.RetDataReader(sql);

                if (dados.Read())
                {
                    obj.Idcliente = Convert.ToInt32(dados["idcliente"].ToString());
                    obj.Nome = dados["nome"].ToString();
                    obj.Cpf = dados["cpf"].ToString();
                    obj.Rg = dados["rg"].ToString();
                    obj.Dt_nasc = dados["dt_nasc"].ToString();
                    obj.Rua = dados["rua"].ToString();
                    obj.Numero = dados["numero"].ToString();
                    obj.Bairro = dados["bairro"].ToString();
                    obj.Cidade = dados["cidade"].ToString();
                    obj.Estado = dados["estado"].ToString();
                    obj.Cep = dados["cep"].ToString();
                    obj.Telefones = dados["telefones"].ToString();
                    obj.Email = dados["email"].ToString();
                    obj.Salario = Convert.ToDecimal(dados["salario"].ToString(), new CultureInfo("en-US"));
                    obj.Usuario = dados["usuario"].ToString();
                    obj.Senha = dados["senha"].ToString();
                    obj.Tipo = Convert.ToChar(dados["tipo"].ToString());
                    obj.Ativo = Convert.ToInt32(dados["ativo"]);
                }
                else
                {
                    obj = null;
                }
            }
            catch (FormatException e)
            {
                MessageBox.Show("Erro ao converter !!! \n" + e.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar os registros (LOGIN) !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con = null;
            return obj;
        }

    }
}
