using System;
using System.Collections.Generic;
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
            // try
            //{
            con = new Conexao();
            con.Conectar();

            String sql = "INSERT INTO movimentos (dh_entrada, dh_saida, placa, tipo_veiculo, veiculo, vaga, idservico, idfuncionario, " +
                "idcontrato, permanencia, excedente, periodos, doc_fed) VALUES(";
            sql += "'" + obj.DhEntrada.Replace("'", "''") + "', ";
            sql += "'" + obj.DhSaida.Replace("'", "''") + "', ";
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
            /*  }
              catch (Exception ex)
              {
                  MessageBox.Show("Erro ao cadastrar Movimento !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  return 0;
              }
              finally
              {
                  con = null;
              }*/
        }


    }
}
