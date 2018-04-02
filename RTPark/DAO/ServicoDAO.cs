using System;
using RTPark.Entidades;
using System.Windows.Forms;
using System.Data;
using System.Globalization;

namespace RTPark.DAO
{
    class ServicoDAO
    {
        Conexao con;

        public int Inserir(Servicos obj)
        {
            try
            {
                con = new Conexao();
                con.Conectar();

                String sql = "INSERT INTO servicos (descricao, tipo_cobranca, quantidade, valor_carro, valor_moto, valor_outros, ativo) VALUES(";
                sql += "'" + obj.Descricao.Replace("'", "''") + "', ";
                sql += "'" + obj.TipoCobranca + "', ";
                sql += "'" + obj.Quantidade + "', ";
                sql += "'" + obj.ValorCarro.ToString(new CultureInfo("en-US")) + "', ";
                sql += "'" + obj.ValorMoto.ToString(new CultureInfo("en-US")) + "', ";
                sql += "'" + obj.ValorOutros.ToString(new CultureInfo("en-US")) + "', ";
                sql += "'" + obj.Ativo + "');";
                sql += "SELECT LAST_INSERT_ID();";
                sql = sql.Replace("''", "NULL");
                int id = Convert.ToInt32(con.ExecutarComandoSQLRetorno(sql));

                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Serviço !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                con = null;
            }
        }


        public void Alterar(Servicos obj)
        {
            try
            {
                con = new Conexao();
                con.Conectar();
                String sql = "UPDATE servicos SET";
                sql += " descricao = '" + obj.Descricao.Replace("'", "''") + "', ";
                sql += " tipo_cobranca = '" + obj.TipoCobranca + "', ";
                sql += " quantidade = '" + obj.Quantidade + "', ";
                sql += " valor_carro = '" + obj.ValorCarro.ToString(new CultureInfo("en-US")) + "', ";
                sql += " valor_moto = '" + obj.ValorMoto.ToString(new CultureInfo("en-US")) + "', ";
                sql += " valor_outros = '" + obj.ValorOutros.ToString(new CultureInfo("en-US")) + "', ";
                sql += " ativo = '" + obj.Ativo + "'";
                sql += " WHERE idservico = " + obj.Idservico + ";";
                sql = sql.Replace("''", "NULL");
                con.ExecutarComandoSQL(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o Serviço !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                String sql = "DELETE FROM servicos WHERE idservico = " + id + ";";
                con.ExecutarComandoSQL(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o Serviço !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                String sql = "SELECT idservico AS ID, descricao AS `Descrição`, tipo_cobranca AS Tipo, quantidade AS QTDE, valor_carro AS Carro, valor_moto AS Moto, valor_outros AS Outros, " +
                    "ativo AS Ativo FROM servicos";
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
                String sql = "SELECT idservico AS ID, descricao AS `Descrição`, tipo_cobranca AS Tipo, quantidade AS QTDE, valor_carro AS Carro, valor_moto AS Moto, valor_outros AS Outros, ativo AS Ativo FROM servicos";
                sql += " WHERE " + campo + " LIKE '%" + busca + "%';";
                dt = con.RetDataTable(sql);
                Console.WriteLine(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar os registros !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con = null;
            return dt;
        }

        public Servicos GetById(int id)
        {
            Servicos obj = new Servicos();
            try
            {
                con = new Conexao();
                con.Conectar();
                String sql = "SELECT idservico, descricao, tipo_cobranca, quantidade, valor_carro, valor_moto, valor_outros, ativo FROM servicos";
                sql += " WHERE idservico = " + id;

                var dados = con.RetDataReader(sql);

                dados.Read();

                obj.Idservico = Convert.ToInt32(dados["idservico"].ToString());
                obj.Descricao = dados["descricao"].ToString();
                obj.TipoCobranca = dados["tipo_cobranca"].ToString()[0];
                obj.Quantidade = Convert.ToInt32(dados["quantidade"]);
                obj.ValorCarro = Convert.ToDecimal(dados["valor_carro"].ToString(), new CultureInfo("en-US"));
                obj.ValorMoto = Convert.ToDecimal(dados["valor_moto"].ToString(), new CultureInfo("en-US"));
                obj.ValorOutros = Convert.ToDecimal(dados["valor_outros"].ToString(), new CultureInfo("en-US"));
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
    }
}
