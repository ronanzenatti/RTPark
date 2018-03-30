using System;
using System.Collections.Generic;
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

        }

        public void SetUsr(Object obj)
        {
            usr = (Funcionarios)obj;
        }

        public void SetEst(Object obj)
        {
            est = (Estabelecimentos)obj;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            if (est.Idestabelecimento != 0)
            {
                lblNomeEstacionamento.Text = est.Nome;
                CalculaVagas();
            }
        }

        private void CalculaVagas()
        {
            lblCarrosD.Text = est.Vagas_carro.ToString().PadLeft(3, '0');
            lblMotosD.Text = est.Vagas_moto.ToString().PadLeft(3, '0');
            lblOutrosD.Text = est.Vagas_outros.ToString().PadLeft(3, '0');
        }
    }
}
