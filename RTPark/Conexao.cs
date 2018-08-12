using System;

using System.Windows.Forms; // Namespace necessario para gerar uma Caixa de Mensagem.

using System.Data; //Namespace necessário para utilizar os recursos de manipulação de Banco de Dados do ADO.net framework

//Namespace necessário para utilizar os recursos específicos de manipulação de Banco de Dados MySQL
//NOTA: Deve-se importar a biblioteca do MySQL, obviamente ela precisa estar instalado no computador
using MySql.Data.MySqlClient;

namespace RTPark
{
    class Conexao
    {
        private MySqlConnection conn;
        private DataTable dataTable;
        private MySqlDataAdapter mysqlDA;

        private String server = "127.0.0.1";
        private String port = "3308";
        private String user = "root";
        private String password = "";
        private String database = "rtpark";

        public void Conectar()
        {
            if (conn != null)
            {
                conn.Close();
            }
            string connStr = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; pooling=false; CharSet=utf8;   convert zero datetime=True", server, port, user, password, database);
            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
            }
            catch (MySqlException ex)
            {                
                MessageBox.Show("Não foi possivel estabelecer conexão!!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }


        public int ExecutarComandoSQLRetorno(string comandoSql)
        {
            int id;
            MySqlCommand comando = new MySqlCommand(comandoSql, conn);
            id = Convert.ToInt32(comando.ExecuteScalar());
            conn.Close();
            return id;
        }

        public void ExecutarComandoSQL(string comandoSql)
        {
            MySqlCommand comando = new MySqlCommand(comandoSql, conn);

            comando.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable RetDataTable(string sql)
        {
            dataTable = new DataTable();
            mysqlDA = new MySqlDataAdapter(sql, conn);
            mysqlDA.Fill(dataTable);
            return dataTable;
        }

        public IDataReader RetDataReader(string sql)
        {
            MySqlDataReader reader;
            using (var cmd = new MySqlCommand(sql, conn))
            {

                reader = cmd.ExecuteReader();
                var dt = new DataTable();
                dt.Load(reader);
                return dt.CreateDataReader();
            }
        }
    }
}
