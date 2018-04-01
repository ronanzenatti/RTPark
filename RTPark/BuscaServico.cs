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
    public partial class BuscaServico : Form
    {
        ServicoDAO oDAO = new ServicoDAO();
        IUContrato contr;
        IUConfigMovimento config;

        public BuscaServico(IUContrato contr, IUConfigMovimento config)
        {
            InitializeComponent();
            this.contr = contr;
            this.config = config;
        }

        private void BuscaServico_Load(object sender, EventArgs e)
        {
            cboCriterio.SelectedIndex = 0;
            CarregaGrid();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPesquisa.Text = null;
            cboCriterio.SelectedIndex = 0;
            CarregaGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ServicoDAO oDAO = new ServicoDAO();
            String campo = cboCriterio.SelectedItem.ToString();
            String busca = txtPesquisa.Text;

            if (campo != null && !busca.Equals(""))
            {
                if (campo == "Código")
                    campo = "idservico";

                if (campo == "Endereço")
                    campo = "endereco";

                dgvDados.DataSource = oDAO.BuscaPorCampo(campo.ToLower(), busca);
                dgvDados.Columns[0].ReadOnly = true;
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            IUServico tela = new IUServico(0, null, null, config);
            tela.Show();
            this.Hide();
        }

        private void CarregaGrid()
        {
            dgvDados.DataSource = oDAO.listarTodos();
            //dgvDados.Columns[0].ReadOnly = true;
        }

        private void BuscaServico_Shown(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void BuscaServico_Activated(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void btnSeleciona_Click(object sender, EventArgs e)
        {
            if (dgvDados.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value.ToString());

                if (contr != null)
                    contr.CarregaServico(id);

                if (config != null)
                    config.CarregaServico(id);

                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione apenas um Registro!!!");
            }
        }
    }
}
