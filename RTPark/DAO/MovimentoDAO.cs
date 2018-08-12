using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RTPark.Entidades;
using System.Globalization;
using System.Windows.Forms;
using System.Data;

namespace RTPark.DAO
{
    class MovimentoDAO
    {
        Conexao con;

        public int Inserir(Movimentos obj)
        {
            try
            {
                con = new Conexao();
                con.Conectar();

                String sql = "INSERT INTO movimentos (dh_entrada, placa, tipo_veiculo, veiculo, vaga, idservico, idfuncionario, " +
                    "idcontrato, permanencia, excedente, periodos, doc_fed) VALUES(";
                sql += "'" + obj.DhEntrada.Replace("'", "''") + "', ";
                //sql += "'" + obj.DhSaida.Replace("'", "''") + "', ";
                sql += "'" + obj.Placa.Replace("'", "''") + "', ";
                sql += "'" + obj.TipoVeiculo + "', ";
                sql += "'" + obj.Veiculo.Replace("'", "''") + "', ";
                sql += "'" + obj.Vaga + "', ";
                sql += "'" + obj.Idservico + "', ";
                sql += "'" + obj.Idfuncionario + "', ";
                sql += "'" + obj.Idcontrato + "', ";
                sql += "'" + obj.Permanencia + "', ";
                sql += "'" + obj.Excedente + "', ";
                sql += "'" + obj.Periodos + "', ";
                sql += "'" + obj.DocFed.Replace("'", "''") + "'); ";
                sql += "SELECT LAST_INSERT_ID();";
                sql = sql.Replace("''", "NULL");
                Console.WriteLine(sql);
                int id = Convert.ToInt32(con.ExecutarComandoSQLRetorno(sql));

                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar Movimento !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
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

                String sql = "SELECT idmovimento AS '#', placa AS PLACA, dh_entrada AS ENTRADA, veiculo AS VEICULO, vaga AS VAGA, ";
                sql += "(case tipo_veiculo 	when 'C' then 'Carro' when 'M' then 'Moto' when 'O' then 'Outros' end) AS TIPO ";
                sql += "FROM movimentos ";
                sql += "WHERE dh_saida IS NULL ORDER BY idmovimento ";
                dt = con.RetDataTable(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar todos os registros !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con = null;
            return dt;
        }

        public IDataReader GetVagasOcupadas()
        {
            IDataReader dt = null;
            try
            {
                con = new Conexao();
                con.Conectar();
                String sql = "SELECT COUNT(idmovimento) AS qtde, tipo_veiculo ";
                sql += "FROM movimentos ";
                sql += "WHERE dh_saida IS NULL ";
                sql += "GROUP BY tipo_veiculo";

                dt = con.RetDataReader(sql);
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
            return dt;
        }

        public Movimentos GetById(int id)
        {
            Movimentos obj = new Movimentos();
            try
            {
                con = new Conexao();
                con.Conectar();
                String sql = "SELECT idmovimento, dh_entrada, dh_saida, placa, tipo_veiculo, veiculo, vaga, idservico, idfuncionario, idcontrato, permanencia, excedente, periodos, doc_fed FROM movimentos";
                sql += " WHERE idmovimento = " + id;

                var dados = con.RetDataReader(sql);

                if (dados.Read())
                {
                    obj.Idmovimento = Convert.ToInt32(dados["idmovimento"]);
                    obj.DhEntrada = Convert.ToDateTime(dados["dh_entrada"]).ToString("dd/MM/yyyy HH:mm");                    
                    obj.Placa = dados["placa"].ToString();
                    obj.TipoVeiculo = dados["tipo_veiculo"].ToString()[0];
                    obj.Veiculo = dados["veiculo"].ToString();
                    obj.Vaga = Convert.ToInt32(dados["vaga"]);
                    obj.Idservico = Convert.ToInt32(dados["idservico"]);
                    obj.Idfuncionario = Convert.ToInt32(dados["idfuncionario"]);
                    obj.Idcontrato = Convert.ToInt32(dados["idcontrato"]);
                    obj.Permanencia = Convert.ToInt32(dados["permanencia"]);
                    obj.Excedente = Convert.ToInt32(dados["excedente"]);
                    obj.Periodos = Convert.ToInt32(dados["periodos"]);
                    obj.DocFed = dados["doc_fed"].ToString();                   
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

        public Movimentos GetByCampo(string campo, string busca, char saida)
        {
            Movimentos obj = new Movimentos();
            try
            {
                con = new Conexao();
                con.Conectar();
                String sql = "SELECT idmovimento, dh_entrada, dh_saida, placa, tipo_veiculo, veiculo, vaga, idservico, idfuncionario, idcontrato, permanencia, excedente, periodos, doc_fed FROM movimentos";
                sql += " WHERE " + campo + busca;
                if (saida == 'S')
                {
                    sql += " AND dh_saida IS NULL";
                }
                else if (saida == 'N')
                {
                    sql += " dh_saida IS NOT NULL";
                }
                sql += " ORDER BY 1 ASC LIMIT 1";

                var dados = con.RetDataReader(sql);

                if (dados.Read())
                {
                    obj.Idmovimento = Convert.ToInt32(dados["idmovimento"]);
                    obj.DhEntrada = Convert.ToDateTime(dados["dh_entrada"]).ToString("dd/MM/yyyy HH:mm");
                    obj.Placa = dados["placa"].ToString();
                    obj.TipoVeiculo = dados["tipo_veiculo"].ToString()[0];
                    obj.Veiculo = dados["veiculo"].ToString();
                    obj.Vaga = Convert.ToInt32(dados["vaga"]);
                    obj.Idservico = Convert.ToInt32(dados["idservico"]);
                    obj.Idfuncionario = Convert.ToInt32(dados["idfuncionario"]);
                    obj.Idcontrato = Convert.ToInt32(dados["idcontrato"]);
                    obj.Permanencia = Convert.ToInt32(dados["permanencia"]);
                    obj.Excedente = Convert.ToInt32(dados["excedente"]);
                    obj.Periodos = Convert.ToInt32(dados["periodos"]);
                    obj.DocFed = dados["doc_fed"].ToString();
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
