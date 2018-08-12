using System;
using RTPark.Entidades;
using System.Windows.Forms;
using System.Data;
using System.Globalization;

namespace RTPark.DAO
{
    class FormaPagamentoDAO
    {
        Conexao con;

        public int Inserir(FormaPagamento obj)
        {
            try
            {
                con = new Conexao();
                con.Conectar();

                String sql = "INSERT INTO forma_pagamento (descricao, taxa, ativo, idestabelecimento) VALUES(";
                sql += "'" + obj.Descricao.Replace("'", "''") + "', ";               
                sql += "'" + obj.Taxa.ToString(new CultureInfo("en-US")) + "', ";
                sql += "'" + ((obj.Ativo) ? "1" : "0") + "', ";
                sql += "'" + obj.Idestabelecimento + "');";
                sql += "SELECT LAST_INSERT_ID();";
                sql = sql.Replace("''", "NULL");
                int id = Convert.ToInt32(con.ExecutarComandoSQLRetorno(sql));

                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Forma de Pagamento !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                con = null;
            }
        }


        public void Alterar(FormaPagamento obj)
        {
            try
            {
                con = new Conexao();
                con.Conectar();
                String sql = "UPDATE forma_pagamento SET";
                sql += " descricao = '" + obj.Descricao.Replace("'", "''") + "', ";                
                sql += " taxa = '" + obj.Taxa.ToString(new CultureInfo("en-US")) + "', ";
                sql += " idestabelecimento = '" + obj.Idestabelecimento + "', ";
                sql += " ativo = '" + ((obj.Ativo) ? "1" : "0") + "'";
                sql += " WHERE idforma = " + obj.Idforma + ";";
                sql = sql.Replace("''", "NULL");
                con.ExecutarComandoSQL(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar a Forma de Pagamento !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con = null;
            }
        }

        public void Excluir(FormaPagamento obj)
        {
            try
            {
                con = new Conexao();
                con.Conectar();
                String sql = "UPDATE forma_pagamento SET";               
                sql += " ativo = '0'";
                sql += " WHERE idforma = " + obj.Idforma + ";";
                sql = sql.Replace("''", "NULL");
                con.ExecutarComandoSQL(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar a Forma de Pagamento !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                String sql = "SELECT idforma AS ID, descricao AS `Descrição`, taxa AS Taxa, ativo as Ativo FROM forma_pagamento";
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
                String sql = "SELECT idforma AS ID, descricao AS `Descrição`, taxa AS Taxa, ativo as Ativo FROM forma_pagamento";
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

        public FormaPagamento GetById(int id)
        {
            FormaPagamento obj = new FormaPagamento();
            try
            {
                con = new Conexao();
                con.Conectar();
                String sql = "SELECT idforma, descricao, taxa, ativo, idestabelecimento FROM forma_pagamento";
                sql += " WHERE idforma = " + id;

                var dados = con.RetDataReader(sql);

                dados.Read();

                obj.Idforma = Convert.ToInt32(dados["idforma"].ToString());
                obj.Descricao = dados["descricao"].ToString();                
                obj.Taxa = Convert.ToDecimal(dados["taxa"].ToString(), new CultureInfo("en-US"));
                obj.Ativo = Convert.ToBoolean(dados["ativo"]);
                obj.Idestabelecimento = Convert.ToInt32(dados["idestabelecimento"].ToString());
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
