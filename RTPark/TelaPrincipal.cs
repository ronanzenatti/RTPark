using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RTPark.Entidades;
using RTPark.DAO;

namespace RTPark
{
    public partial class TelaPrincipal : Form
    {
        private Funcionarios usr;
        private Estabelecimentos est;
        private ConfigMovimento config;

        public TelaPrincipal()
        {
            InitializeComponent();
            lblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            BuscaEstabelecimento();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaFuncionarios tela = new ListaFuncionarios();
            tela.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {
            btnEntrada.Focus();
            while (usr == null)
            {
                this.Hide();
                Login tela = new Login(this);
                tela.ShowDialog();
            }
            if (usr.Idfuncionario == 0)
            {
                Application.Exit();
            }
            else
            {
                string[] nomeSplit = usr.Nome.Split(' ');
                lblUser.Text = nomeSplit[0];
                this.Show();
            }
            while (est == null && usr.Idfuncionario != 0)
            {
                IUEstabelecimento tela = new IUEstabelecimento(0, this);
                tela.ShowDialog();
                BuscaEstabelecimento();
            }

            while (config == null && usr.Idfuncionario != 0)
            {
                IUConfigMovimento tela = new IUConfigMovimento(est);
                tela.ShowDialog();
                BuscaConfiguracao();
            }

            CarregaGrid();
        }

        public void CarregaGrid()
        {
            MovimentoDAO mDAO = new MovimentoDAO();

            dgvDados.DataSource = mDAO.listarTodos();

            dgvDados.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDados.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //deixa os titulos centralizados.
            dgvDados.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            CalculaVagas();
        }

        public void SetUsr(Funcionarios obj)
        {
            usr = (Funcionarios)obj;
        }

        public void SetEst(Estabelecimentos obj)
        {
            est = (Estabelecimentos)obj;
        }

        public void SetConfig(ConfigMovimento obj)
        {
            config = (ConfigMovimento)obj;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void estabelecimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IUEstabelecimento tela = new IUEstabelecimento(est.Idestabelecimento, this);
            tela.ShowDialog();
            BuscaEstabelecimento();
        }

        private void BuscaEstabelecimento()
        {
            EstabelecimentoDAO oDAO = new EstabelecimentoDAO();
            est = oDAO.GetLast();
            if (est != null)
            {
                lblNomeEstacionamento.Text = est.Nome;
                BuscaConfiguracao();
                CalculaVagas();
            }
        }

        private void BuscaConfiguracao()
        {
            ConfigMovimentoDAO oDAO = new ConfigMovimentoDAO();
            config = oDAO.GetLast(est.Idestabelecimento);
        }

        private void CalculaVagas()
        {
            int vC = 0, vM = 0, vO = 0;
            int vOC = 0, vOM = 0, vOO = 0;
            int vDC = 0, vDM = 0, vDO = 0;

            MovimentoDAO mDAO = new MovimentoDAO();
            IDataReader vagas = mDAO.GetVagasOcupadas();

            vC = est.Vagas_carro;
            vM = est.Vagas_moto;
            vO = est.Vagas_outros;

            while (vagas.Read())
            {
                if (vagas["tipo_veiculo"].ToString().Equals("C"))
                {
                    vOC = Convert.ToInt32(vagas["qtde"].ToString());
                }
                else if (vagas["tipo_veiculo"].ToString().Equals("M"))
                {
                    vOM = Convert.ToInt32(vagas["qtde"].ToString());
                }
                else if (vagas["tipo_veiculo"].ToString().Equals("O"))
                {
                    vOO = Convert.ToInt32(vagas["qtde"].ToString());
                }
            }

            vDC = vC - vOC;
            vDM = vM - vOM;
            vDO = vO - vOO;

            lblCarrosD.Text = vDC.ToString().PadLeft(3, '0');
            lblMotosD.Text = vDM.ToString().PadLeft(3, '0');
            lblOutrosD.Text = vDO.ToString().PadLeft(3, '0');

            lblCarrosO.Text = vOC.ToString().PadLeft(3, '0');
            lblMotosO.Text = vOM.ToString().PadLeft(3, '0');
            lblOutrosO.Text = vOO.ToString().PadLeft(3, '0');
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ListaClientes tela = new ListaClientes();
            tela.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaClientes tela = new ListaClientes();
            tela.Show();
        }

        private void serviçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaServicos tela = new ListaServicos();
            tela.Show();
        }

        private void contratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaContratos tela = new ListaContratos();
            tela.Show();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            EntradaMovimento tela = new EntradaMovimento(est, config, usr, this);
            tela.ShowDialog();
        }

        private void estabelecimentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IUEstabelecimento tela = new IUEstabelecimento(est.Idestabelecimento, this);
            tela.ShowDialog();
            BuscaEstabelecimento();
        }

        private void configuraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IUConfigMovimento tela = new IUConfigMovimento(est);
            tela.ShowDialog();
            BuscaConfiguracao();
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            SaidaMovimento tela = new SaidaMovimento(0, est, config, usr, this);
            tela.ShowDialog();
        }

        private void formasDePagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaFormaPagamento tela = new ListaFormaPagamento(est.Idestabelecimento);
            tela.Show();
        }

        private void dgvDados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value.ToString());
                SaidaMovimento tela = new SaidaMovimento(id, est, config, usr, this);
                tela.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Escolha um movimento válido.", "RTPark", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TelaPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                Environment.Exit(0);
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.F2:
                        btnEntrada_Click(sender, e);
                        break;

                    case Keys.F3:
                        btnSaida_Click(sender, e);
                        break;

                    case Keys.F4:
                        btnClientes_Click(sender, e);
                        break;
                }
            }
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value.ToString());
                SaidaMovimento tela = new SaidaMovimento(id, est, config, usr, this);
                tela.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Escolha um movimento válido.", "RTPark", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void faturarContratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaFaturas tela = new ListaFaturas();
            tela.Show();
        }
    }
}
