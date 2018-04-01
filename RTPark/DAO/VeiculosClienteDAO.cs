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
    class VeiculosClienteDAO
    {
        Conexao con;

        public int Inserir(VeiculosClientes obj)
        {
            try
            {
                con = new Conexao();
                con.Conectar();

                String sql = "INSERT INTO veiculos_clientes (idcliente, placa, veiculo, tipo, ativo) VALUES(";
                sql += "'" + obj.Idcliente + "', ";
                sql += "'" + obj.Placa.Replace("'", "''") + "', ";
                sql += "'" + obj.Veiculo.Replace("'", "''") + "', ";
                sql += "'" + obj.Tipo + "', ";
                sql += "'" + obj.Ativo + "'); ";
                sql += "SELECT LAST_INSERT_ID();";
                sql = sql.Replace("''", "NULL");
                System.Console.WriteLine(sql);
                int id = Convert.ToInt32(con.ExecutarComandoSQLRetorno(sql));

                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Veiculo para o Cliente !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                con = null;
            }
        }


        public void Alterar(VeiculosClientes obj)
        {
            try
            {
                con = new Conexao();
                con.Conectar();
                String sql = "UPDATE veiculos_clientes SET";
                sql += " idcliente = '" + obj.Idcliente + "', ";
                sql += " placa = '" + obj.Placa.Replace("'", "''") + "', ";
                sql += " veiculo = '" + obj.Veiculo.Replace("'", "''") + "', ";
                sql += " tipo = '" + obj.Tipo + "', ";
                sql += " ativo = '" + obj.Ativo + "' ";
                sql += " WHERE idvc = " + obj.Idvc + ";";
                sql = sql.Replace("''", "NULL");
                con.ExecutarComandoSQL(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar o Veiculo do Cliente !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                String sql = "DELETE FROM veiculos_clientes WHERE idvc = " + id + ";";
                con.ExecutarComandoSQL(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o VeiculosCliente !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con = null;
            }
        }

        public DataTable listarTodos(int idcliente)
        {
            DataTable dt = new DataTable();
            try
            {
                con = new Conexao();
                con.Conectar();

                String sql = "SELECT idvc AS ID, placa AS Placa, veiculo AS Veiculo, tipo AS Tipo, ativo AS Ativo FROM veiculos_clientes WHERE idcliente = " + idcliente.ToString() + ";";
                dt = con.RetDataTable(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar todos os registros !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con = null;
            return dt;
        }

        public DataTable BuscaPorCampo(string campo, string busca, int idcliente)
        {
            DataTable dt = new DataTable();
            try
            {
                con = new Conexao();
                con.Conectar();
                String sql = "SELECT idvc AS ID, placa AS Placa, veiculo AS Veiculo, tipo AS Tipo, ativo AS Ativo FROM veiculos_clientes WHERE idcliente = '" + idcliente.ToString();
                sql += "' AND " + campo + " LIKE '%" + busca + "%';";
                dt = con.RetDataTable(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar os registros !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con = null;
            return dt;
        }

        public VeiculosClientes GetById(int id)
        {
            VeiculosClientes obj = new VeiculosClientes();
            try
            {
                con = new Conexao();
                con.Conectar();
                String sql = "SELECT idvc, idcliente, placa, veiculo, tipo, ativo FROM veiculos_clientes";
                sql += " WHERE idvc = " + id;

                var dados = con.RetDataReader(sql);

                if (dados.Read())
                {
                    obj.Idvc = Convert.ToInt32(dados["idvc"].ToString());
                    obj.Idcliente = Convert.ToInt32(dados["idcliente"].ToString());
                    obj.Placa = dados["placa"].ToString();
                    obj.Veiculo = dados["veiculo"].ToString();
                    obj.Tipo = dados["tipo"].ToString()[0];
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
                MessageBox.Show("Erro ao buscar os registros (BY ID) !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            con = null;
            return obj;
        }
    }
}
