using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RTPark.Entidades;
using System.Windows.Forms;
using System.Data;
using System.Globalization;

namespace RTPark.DAO
{
    class ConfigMovimentoDAO
    {
        Conexao con;

        public int Inserir(ConfigMovimento obj)
        {
            try
            {
                con = new Conexao();
                con.Conectar();

                String sql = "INSERT INTO config_movimento (idestabelecimento, cobranca_padrao, imprime_entrada, imprime_saida, imprime_end, imprime_telefones, imprime_cnpj) VALUES(";
                sql += "'" + obj.Idestabelecimento + "', ";
                sql += "'" + obj.CobrancaPadrao + "', ";
                sql += "'" + obj.ImprimeEntrada + "', ";
                sql += "'" + obj.ImprimeSaida + "', ";
                sql += "'" + obj.ImprimeEnd + "', ";
                sql += "'" + obj.ImprimeTelefones + "', ";
                sql += "'" + obj.ImprimeCnpj + "'); ";
                sql += "SELECT LAST_INSERT_ID();";
                sql = sql.Replace("''", "NULL");
                System.Console.WriteLine(sql);
                int id = Convert.ToInt32(con.ExecutarComandoSQLRetorno(sql));

                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar a Configurações !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                con = null;
            }
        }


        public void Alterar(ConfigMovimento obj)
        {
            try
            {
                con = new Conexao();
                con.Conectar();
                String sql = "UPDATE config_movimento SET";
                sql += " idestabelecimento = '" + obj.Idestabelecimento + "', ";
                sql += " cobranca_padrao = '" + obj.CobrancaPadrao + "', ";
                sql += " imprime_entrada = '" + obj.ImprimeEntrada + "', ";
                sql += " imprime_saida = '" + obj.ImprimeSaida + "', ";
                sql += " imprime_end = '" + obj.ImprimeEnd + "', ";
                sql += " imprime_telefones = '" + obj.ImprimeTelefones + "', ";
                sql += " imprime_cnpj = '" + obj.ImprimeCnpj + "' ";
                sql += " WHERE idconfig = " + obj.Idconfig + ";";
                sql = sql.Replace("''", "NULL");
                con.ExecutarComandoSQL(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar a Configuração !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                String sql = "DELETE FROM config_movimento WHERE idconfig = " + id + ";";
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

                String sql = "SELECT idservico AS ID, descricao AS Descrição, tipo_cobranca AS Tipo, quantidade AS QTDE, valor_carro AS Carro, valor_moto AS Moto, valor_outros AS Outros, " +
                    "ativo AS Ativo FROM config_movimento";
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
                String sql = "SELECT idservico AS ID, descricao AS Descrição, tipo_cobranca AS Tipo, quantidade AS QTDE, valor_carro AS Carro, valor_moto AS Moto, valor_outros AS Outros, ativo AS Ativo FROM config_movimento";
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

        public ConfigMovimento GetById(int id)
        {
            ConfigMovimento obj = new ConfigMovimento();
            try
            {
                con = new Conexao();
                con.Conectar();
                String sql = "SELECT idconfig, idestabelecimento, cobranca_padrao, imprime_entrada, imprime_saida, imprime_end, imprime_telefones, imprime_cnpj  FROM config_movimento";
                sql += " WHERE idconfig = " + id;

                var dados = con.RetDataReader(sql);

                if (dados.Read())
                {
                    obj.Idconfig = Convert.ToInt32(dados["idconfig"].ToString());
                    obj.Idestabelecimento = Convert.ToInt32(dados["idestabelecimento"].ToString());
                    obj.CobrancaPadrao = Convert.ToInt32(dados["cobranca_padrao"].ToString());
                    obj.ImprimeEntrada = dados["imprime_entrada"].ToString()[0];
                    obj.ImprimeSaida = dados["imprime_saida"].ToString()[0];
                    obj.ImprimeEnd = Convert.ToInt32(dados["imprime_end"].ToString());
                    obj.ImprimeTelefones = Convert.ToInt32(dados["imprime_telefones"].ToString());
                    obj.ImprimeCnpj = Convert.ToInt32(dados["imprime_cnpj"].ToString());
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

        public ConfigMovimento GetLast(int idEst)
        {
            ConfigMovimento obj = new ConfigMovimento();
            try
            {
                con = new Conexao();
                con.Conectar();
                String sql = "SELECT idconfig, idestabelecimento, cobranca_padrao, imprime_entrada, imprime_saida, imprime_end, imprime_telefones, imprime_cnpj  FROM config_movimento";
                sql += " WHERE idestabelecimento = '" + idEst + "' ORDER BY 1 DESC LIMIT 1;";

                var dados = con.RetDataReader(sql);

                if (dados.Read())
                {
                    obj.Idconfig = Convert.ToInt32(dados["idconfig"].ToString());
                    obj.Idestabelecimento = Convert.ToInt32(dados["idestabelecimento"].ToString());
                    obj.CobrancaPadrao = Convert.ToInt32(dados["cobranca_padrao"].ToString());
                    obj.ImprimeEntrada = dados["imprime_entrada"].ToString()[0];
                    obj.ImprimeSaida = dados["imprime_saida"].ToString()[0];
                    obj.ImprimeEnd = Convert.ToInt32(dados["imprime_end"].ToString());
                    obj.ImprimeTelefones = Convert.ToInt32(dados["imprime_telefones"].ToString());
                    obj.ImprimeCnpj = Convert.ToInt32(dados["imprime_cnpj"].ToString());
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
