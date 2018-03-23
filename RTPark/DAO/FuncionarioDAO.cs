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
    class FuncionarioDAO
    {
        Conexao con;

        public int Inserir(Funcionarios obj)
        {
            try
            {
                con = new Conexao();
                con.Conectar();

                String sql = "INSERT INTO funcionarios (nome, cpf, rg, dt_nasc, rua, numero, bairro, cidade, estado, cep, telefones, email, salario, usuario, senha, tipo, ativo) VALUES(";
                sql += "'" + obj.Nome.Replace("'", "''") + "', ";
                sql += "'" + obj.Cpf.Replace("'", "''") + "', ";
                sql += "'" + obj.Rg.Replace("'", "''") + "', ";
                sql += "'" + obj.Dt_nasc.ToString("yyyy-MM-dd") + "', ";
                sql += "'" + obj.Rua.Replace("'", "''") + "', ";
                sql += "'" + obj.Numero.Replace("'", "''") + "', ";
                sql += "'" + obj.Bairro.Replace("'", "''") + "', ";
                sql += "'" + obj.Cidade.Replace("'", "''") + "', ";
                sql += "'" + obj.Estado + "', ";
                sql += "'" + obj.Cep.Replace("'", "''") + "', ";
                sql += "'" + obj.Telefones.Replace("'", "''") + "', ";
                sql += "'" + obj.Email.Replace("'", "''") + "', ";
                sql += "'" + obj.Salario + "', ";
                sql += "'" + obj.Usuario.Replace("'", "''") + "', ";
                sql += "'" + obj.Senha.Replace("'", "''") + "', ";
                sql += "'" + obj.Tipo + "', ";
                sql += "'" + obj.Ativo + "');";
                sql += "SELECT LAST_INSERT_ID();";

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


        public void Alterar(Funcionarios obj)
        {
            try
            {
                con = new Conexao();
                con.Conectar();
                String sql = "UPDATE funcionarios SET";
                sql += " nome = '" + obj.Nome.Replace("'", "''") + "', ";
                sql += " cpf = '" + obj.Email.Replace("'", "''") + "', ";
                sql += " rg = '" + obj.Rg.Replace("'", "''") + "', ";
                sql += " dt_nasc = '" + obj.Dt_nasc.ToString("yyyy-MM-dd") + "', ";
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
                sql += " tipo = '" + obj.Tipo + "', ";
                sql += " ativo = '" + obj.Ativo + "'";
                sql += " WHERE idfuncionario = " + obj.Idfuncionario + ";";
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
                String sql = "DELETE FROM funcionarios WHERE iddepartamento = " + id + ";";
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
                String sql = "SELECT idfuncionario, nome, cpf, rg, dt_nasc, rua, numero, bairro, cidade, estado, cep, telefones, email, salario, usuario, tipo, ativo FROM funcionarios";
                dt = con.RetDataTable(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar todos os registros !!! \n" + ex.Message, "ERRO !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con = null;
            return dt;
        }

    }
}
