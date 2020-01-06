using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RTPark.Entidades;
using System.Windows.Forms;
using System.Data;

namespace RTPark.DAO
{
    class EstabelecimentoDAO
    {
        Conexao con;

        public int Inserir(Estabelecimentos obj)
        {
            try
            {
                con = new Conexao();
                con.Conectar();

                String sql = "INSERT INTO estabelecimentos (nome, cnpj, rua, numero, bairro, cidade, estado, cep, telefones, email, vagas_carro, vagas_moto, vagas_outros) VALUES(";
                sql += "'" + obj.Nome.Replace("'", "''") + "', ";
                sql += "'" + obj.Cnpj.Replace("'", "''") + "', ";
                sql += "'" + obj.Rua.Replace("'", "''") + "', ";
                sql += "'" + obj.Numero.Replace("'", "''") + "', ";
                sql += "'" + obj.Bairro.Replace("'", "''") + "', ";
                sql += "'" + obj.Cidade.Replace("'", "''") + "', ";
                sql += "'" + obj.Estado + "', ";
                sql += "'" + obj.Cep.Replace("'", "''") + "', ";
                sql += "'" + obj.Telefones.Replace("'", "''") + "', ";
                sql += "'" + obj.Email.Replace("'", "''") + "', ";
                sql += "'" + obj.Vagas_carro + "', ";
                sql += "'" + obj.Vagas_moto + "', ";
                sql += "'" + obj.Vagas_outros + "');";
                sql += "SELECT LAST_INSERT_ID();";
                sql = sql.Replace("''", "NULL");
                System.Console.WriteLine(sql);
                int id = Convert.ToInt32(con.ExecutarComandoSQLRetorno(sql));

                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Estabelecimento !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                con = null;
            }
        }


        public void Alterar(Estabelecimentos obj)
        {
            try
            {
                con = new Conexao();
                con.Conectar();
                String sql = "UPDATE estabelecimentos SET";
                sql += " nome = '" + obj.Nome.Replace("'", "''") + "', ";
                sql += " cnpj = '" + obj.Cnpj.Replace("'", "''") + "', ";
                sql += " rua = '" + obj.Rua.Replace("'", "''") + "', ";
                sql += " numero = '" + obj.Numero.Replace("'", "''") + "', ";
                sql += " bairro = '" + obj.Bairro.Replace("'", "''") + "', ";
                sql += " cidade = '" + obj.Cidade.Replace("'", "''") + "', ";
                sql += " estado = '" + obj.Estado + "', ";
                sql += " cep = '" + obj.Cep.Replace("'", "''") + "', ";
                sql += " telefones = '" + obj.Telefones.Replace("'", "''") + "', ";
                sql += " email = '" + obj.Email.Replace("'", "''") + "', ";
                sql += " vagas_carro = '" + obj.Vagas_carro + "', ";
                sql += " vagas_moto = '" + obj.Vagas_moto + "', ";
                sql += " vagas_outros = '" + obj.Vagas_outros + "'";
                sql += " WHERE idestabelecimento = " + obj.Idestabelecimento + ";";
                sql = sql.Replace("''", "NULL");
                con.ExecutarComandoSQL(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o Estabelecimento !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                String sql = "DELETE FROM estabelecimentos WHERE idestabelecimento = " + id + ";";
                con.ExecutarComandoSQL(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o Estabelecimento !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                String sql = "SELECT idestabelecimento AS ID, nome AS Nome, cnpj AS CNPJ, rua AS Rua, numero AS `Num`, " +
                    "bairro AS Bairro, cidade AS Cidade, estado AS UF, cep AS CEP, telefones AS Telefones, email AS `E-mail`, " +
                    "vagas_carro AS `Carros`, vagas_moto AS Motos, vagas_outros AS Outros FROM estabelecimentos";
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
                String sql = "SELECT idestabelecimento, nome, cnpj, rua, numero, bairro, cidade, estado, cep, telefones, email, vagas_carro, vagas_moto, vagas_outros FROM estabelecimentos";
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

        public Estabelecimentos GetById(int id)
        {
            Estabelecimentos obj = new Estabelecimentos();
            try
            {
                con = new Conexao();
                con.Conectar();
                String sql = "SELECT idestabelecimento, nome, cnpj, rua, numero, bairro, cidade, estado, cep, telefones, email, vagas_carro, vagas_moto, vagas_outros FROM estabelecimentos";
                sql += " WHERE idestabelecimento = " + id;

                var dados = con.RetDataReader(sql);

                if (dados.Read())
                {

                    obj.Idestabelecimento = Convert.ToInt32(dados["idestabelecimento"].ToString());
                    obj.Nome = dados["nome"].ToString();
                    obj.Cnpj = dados["cnpj"].ToString();
                    obj.Rua = dados["rua"].ToString();
                    obj.Numero = dados["numero"].ToString();
                    obj.Bairro = dados["bairro"].ToString();
                    obj.Cidade = dados["cidade"].ToString();
                    obj.Estado = dados["estado"].ToString();
                    obj.Cep = dados["cep"].ToString();
                    obj.Telefones = dados["telefones"].ToString();
                    obj.Email = dados["email"].ToString();
                    obj.Vagas_carro = Convert.ToInt32(dados["vagas_carro"].ToString());
                    obj.Vagas_moto = Convert.ToInt32(dados["vagas_moto"].ToString());
                    obj.Vagas_outros = Convert.ToInt32(dados["vagas_outros"]);
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
                MessageBox.Show("Erro ao buscar os registros (BY ID) !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con = null;
            return obj;
        }

        public Estabelecimentos GetLast()
        {
            Estabelecimentos obj = new Estabelecimentos();
            try
            {
                con = new Conexao();
                con.Conectar();
                String sql = "SELECT idestabelecimento, nome, cnpj, rua, numero, bairro, cidade, estado, cep, telefones, email, vagas_carro, vagas_moto, vagas_outros FROM estabelecimentos";
                sql += " ORDER BY 1 DESC LIMIT 1;";

                var dados = con.RetDataReader(sql);

                if (dados.Read())
                {

                    obj.Idestabelecimento = Convert.ToInt32(dados["idestabelecimento"].ToString());
                    obj.Nome = dados["nome"].ToString();
                    obj.Cnpj = dados["cnpj"].ToString();
                    obj.Rua = dados["rua"].ToString();
                    obj.Numero = dados["numero"].ToString();
                    obj.Bairro = dados["bairro"].ToString();
                    obj.Cidade = dados["cidade"].ToString();
                    obj.Estado = dados["estado"].ToString();
                    obj.Cep = dados["cep"].ToString();
                    obj.Telefones = dados["telefones"].ToString();
                    obj.Email = dados["email"].ToString();
                    obj.Vagas_carro = Convert.ToInt32(dados["vagas_carro"].ToString());
                    obj.Vagas_moto = Convert.ToInt32(dados["vagas_moto"].ToString());
                    obj.Vagas_outros = Convert.ToInt32(dados["vagas_outros"]);
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
                MessageBox.Show("Erro ao buscar os registros (LAST) !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con = null;
            return obj;
        }

    }
}
