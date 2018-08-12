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
    public partial class BuscaContratos : Form
    {
        ContratoDAO fDAO = new ContratoDAO();
        EntradaMovimento entr;
        SaidaMovimento said;

        public BuscaContratos(Form entr, Form said)
        {
            InitializeComponent();
            if (entr != null)
                this.entr = (EntradaMovimento)entr;

            if (said != null)
                this.said = (SaidaMovimento)said;
        }

        private void BuscaContratos_Load(object sender, EventArgs e)
        {
            cboCriterio.SelectedIndex = 0;
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            dgvDados.DataSource = fDAO.listarTodos();
            //dgvDados.Columns[0].ReadOnly = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPesquisa.Text = null;
            cboCriterio.SelectedIndex = 0;
            CarregaGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ContratoDAO fDAO = new ContratoDAO();
            String campo = cboCriterio.SelectedItem.ToString();
            String busca = txtPesquisa.Text;

            if (campo != null && !busca.Equals(""))
            {
                if (campo == "Código")
                    campo = "idcontrato";

                if (campo == "Endereço")
                    campo = "endereco";

                dgvDados.DataSource = fDAO.BuscaPorCampo(campo.ToLower(), busca);
                dgvDados.Columns[0].ReadOnly = true;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            IUContrato tela = new IUContrato(0, null, this);
            tela.Show();
        }

        private void btnSeleciona_Click(object sender, EventArgs e)
        {
            if (dgvDados.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value.ToString());

                if (entr != null)
                    entr.BuscaContrato(id);

                if (said != null)
                    said.BuscaContrato(id);

                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione apenas um Registro!!!");
            }
        }
    }
}
