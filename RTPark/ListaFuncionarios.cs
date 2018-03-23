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
    public partial class ListaFuncionarios : Form
    {
        Funcionarios obj;
        FuncionarioDAO fDAO = new FuncionarioDAO();

        public ListaFuncionarios()
        {
            InitializeComponent();
        }

        private void ListaFuncionarios_Load(object sender, EventArgs e)
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

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void CarregaGrid()
        {
            dgvDados.DataSource = fDAO.listarTodos();
            dgvDados.Columns[0].ReadOnly = true;

            //deixa a fonte dos titulos em negrito.
            dgvDados.ColumnHeadersDefaultCellStyle.Font = new Font(dgvDados.Font, FontStyle.Bold);
            //deixa os titulos centralizados.
            dgvDados.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
