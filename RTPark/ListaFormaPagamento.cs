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
    public partial class ListaFormaPagamento : Form
    {
        FormaPagamentoDAO oDAO = new FormaPagamentoDAO();
        int idestabelecimento;

        public ListaFormaPagamento(int idestabelecimento)
        {
            InitializeComponent();
            this.idestabelecimento = idestabelecimento;
        }

        private void ListaServicos_Load(object sender, EventArgs e)
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
            FormaPagamentoDAO oDAO = new FormaPagamentoDAO();
            String campo = cboCriterio.SelectedItem.ToString();
            String busca = txtPesquisa.Text;

            if (campo != null && !busca.Equals(""))
            {
                if (campo == "Código")
                    campo = "idforma";

                if (campo == "Descrição")
                    campo = "descricao";

                dgvDados.DataSource = oDAO.BuscaPorCampo(campo.ToLower(), busca);               
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvDados.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value.ToString());
                FormaPagamento obj = oDAO.GetById(id);
                DialogResult dr = MessageBox.Show("Deseja realmente EXCLUIR ?", "RTPark", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    oDAO.Excluir(obj);
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione apenas um Registro!!!");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDados.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value.ToString());
                IUFormaPagamento tela = new IUFormaPagamento(id, this, idestabelecimento);
                tela.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Selecione apenas um Registro!!!");
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            IUFormaPagamento tela = new IUFormaPagamento(0, this, idestabelecimento);
            tela.Show();
            this.Hide();
        }

        private void CarregaGrid()
        {
            dgvDados.DataSource = oDAO.listarTodos();
        }

        private void ListaServicos_Shown(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void ListaServicos_Activated(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void dgvDados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value.ToString());
            IUFormaPagamento tela = new IUFormaPagamento(id, this, idestabelecimento);
            tela.Show();
            this.Hide();

        }
    }
}
