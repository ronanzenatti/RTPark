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
    public partial class ListaClientes : Form
    {
        ClienteDAO fDAO = new ClienteDAO();

        public ListaClientes()
        {
            InitializeComponent();
        }

        private void ListaClientes_Load(object sender, EventArgs e)
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
            ClienteDAO fDAO = new ClienteDAO();
            String campo = cboCriterio.SelectedItem.ToString();
            String busca = txtPesquisa.Text;

            if (campo != null && !busca.Equals(""))
            {
                if (campo == "Código")
                    campo = "idcliente";

                if (campo == "Endereço")
                    campo = "endereco";

                dgvDados.DataSource = fDAO.BuscaPorCampo(campo.ToLower(), busca);
                dgvDados.Columns[0].ReadOnly = true;
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvDados.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value.ToString());
                DialogResult dr = MessageBox.Show("Deseja realmente EXCLUIR ?", "RTPark", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Yes)
                {
                    fDAO.Excluir(id);
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
                IUCliente tela = new IUCliente(id, this);
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
            IUCliente tela = new IUCliente(0, this);
            tela.Show();
            this.Hide();
        }

        private void CarregaGrid()
        {
            dgvDados.DataSource = fDAO.listarTodos();
            //dgvDados.Columns[0].ReadOnly = true;
        }

        private void ListaClientes_Shown(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void ListaClientes_Activated(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void dgvDados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value.ToString());
            IUCliente tela = new IUCliente(id, this);
            tela.Show();
            this.Hide();

        }
    }
}
