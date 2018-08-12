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
    class ContratoDAO
    {
        Conexao con;

        public int Inserir(Contratos obj)
        {
            try
            {
                con = new Conexao();
                con.Conectar();

                String sql = "INSERT INTO contratos (descricao, idcliente, idservico, tipo_pagamento, vencimento, dt_inicio, dt_fim) VALUES(";
                sql += "'" + obj.Descricao.Replace("'", "''") + "', ";
                sql += "'" + obj.Idcliente + "', ";
                sql += "'" + obj.Idservico + "', ";
                sql += "'" + obj.TipoPagamento + "', ";
                sql += "'" + obj.Vencimento + "', ";
                sql += "'" + obj.DtInicio.Replace("'", "''") + "', ";
                sql += "'" + obj.DtTermino.Replace("'", "''") + "'); ";
                sql += " SELECT LAST_INSERT_ID();";
                sql = sql.Replace("''", "NULL");
                System.Console.WriteLine(sql);
                int id = Convert.ToInt32(con.ExecutarComandoSQLRetorno(sql));

                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Contrato !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                con = null;
            }
        }


        public void Alterar(Contratos obj)
        {
            try
            {
                con = new Conexao();
                con.Conectar();
                String sql = "UPDATE contratos SET";
                sql += " descricao = '" + obj.Descricao.Replace("'", "''") + "', ";
                sql += " idcliente = '" + obj.Idcliente + "', ";
                sql += " idservico = '" + obj.Idservico + "', ";
                sql += " tipo_pagamento = '" + obj.TipoPagamento + "', ";
                sql += " vencimento = '" + obj.Vencimento + "', ";
                sql += " dt_inicio = '" + obj.DtInicio.Replace("'", "''") + "', ";
                sql += " dt_fim = '" + obj.DtTermino.Replace("'", "''") + "' ";
                sql += " WHERE idcontrato = " + obj.Idcontrato + ";";
                sql = sql.Replace("''", "NULL");
                con.ExecutarComandoSQL(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o Contrato !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                String sql = "DELETE FROM contratos WHERE idcontrato = " + id + ";";
                con.ExecutarComandoSQL(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o Contrato !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                String sql = "SELECT co.idcontrato AS ID, co.descricao AS `Descrição`, cli.nome AS Cliente, s.descricao AS `Serviço`, " +
                    "vencimento AS Dia, dt_inicio AS Inicio, dt_fim AS Fim FROM contratos AS co ";
                sql += "INNER JOIN clientes AS cli ON (cli.idcliente = co.idcliente) ";
                sql += "INNER JOIN servicos AS s ON (s.idservico = co.idservico) ORDER BY co.idcontrato;";
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
                String sql = "SELECT co.idcontrato AS ID, co.descricao AS `Descrição`, cli.nome AS Cliente, s.descricao AS `Serviço`, " +
                    "vencimento AS Dia, dt_inicio AS Inicio, dt_fim AS Fim FROM contratos AS co ";
                sql += "INNER JOIN clientes AS cli ON (cli.idcliente = co.idcliente) ";
                sql += "INNER JOIN servicos AS s ON (s.idservico = co.idservico) ";
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

        public Contratos GetById(int id)
        {
            Contratos obj = new Contratos();
            try
            {
                con = new Conexao();
                con.Conectar();
                String sql = "SELECT idcontrato, descricao, idcliente, idservico, vencimento, dt_inicio, dt_fim FROM contratos";
                sql += " WHERE idcontrato = " + id;

                var dados = con.RetDataReader(sql);

                if (dados.Read())
                {
                    obj.Idcontrato = Convert.ToInt32(dados["idcontrato"].ToString());
                    obj.Descricao = dados["descricao"].ToString();
                    obj.Idcliente = Convert.ToInt32(dados["idcliente"].ToString());
                    obj.Idservico = Convert.ToInt32(dados["idservico"].ToString());
                    obj.Vencimento = Convert.ToInt32(dados["vencimento"].ToString());
                    obj.DtInicio = dados["dt_inicio"].ToString();
                    obj.DtTermino = dados["dt_fim"].ToString();
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

        public Contratos GetByCliente(int id)
        {
            Contratos obj = new Contratos();
            try
            {
                con = new Conexao();
                con.Conectar();
                String sql = "SELECT idcontrato, descricao, idcliente, idservico, vencimento, dt_inicio, dt_fim FROM contratos";
                sql += " WHERE idcliente = " + id + " AND (dt_inicio <= '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND dt_fim >= '" + DateTime.Now.ToString("yyyy-MM-dd") + "') OR ";
                sql += "dt_inicio <= '" + DateTime.Now.ToString("yyyy-MM-dd") + "' AND dt_fim IS NULL";
                Console.WriteLine(sql);
                var dados = con.RetDataReader(sql);

                if (dados.Read())
                {
                    obj.Idcontrato = Convert.ToInt32(dados["idcontrato"].ToString());
                    obj.Descricao = dados["descricao"].ToString();
                    obj.Idcliente = Convert.ToInt32(dados["idcliente"].ToString());
                    obj.Idservico = Convert.ToInt32(dados["idservico"].ToString());
                    obj.Vencimento = Convert.ToInt32(dados["vencimento"].ToString());
                    obj.DtInicio = dados["dt_inicio"].ToString();
                    obj.DtTermino = dados["dt_fim"].ToString();
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
    }
}
