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
    public partial class IUVeiculoCliente : Form
    {
        VeiculosClientes obj;
        Clientes cli;
        VeiculosClienteDAO oDAO;

        public IUVeiculoCliente(int id, Clientes cli)
        {
            InitializeComponent();

            cboTipo.SelectedIndex = 0;

            this.cli = cli;
            lblCliente.Text = cli.Nome;

            obj = new VeiculosClientes();
            oDAO = new VeiculosClienteDAO();

            if (id != 0)
            {
                obj = oDAO.GetById(id);
                txtIdvc.Text = obj.Idvc.ToString();
                txtPlaca.Text = obj.Placa;
                txtVeiculo.Text = obj.Veiculo;
                chkAtivo.Checked = (obj.Ativo == 1) ? true : false;

                if (obj.Tipo == 'C')
                {
                    cboTipo.SelectedIndex = 0;
                }
                else if (obj.Tipo == 'M')
                {
                    cboTipo.SelectedIndex = 1;
                }
                else
                {
                    cboTipo.SelectedIndex = 2;
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                DialogResult confirm = MessageBox.Show("Deseja Salvar o Registro?", "RTPark", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (ValidarCampos() && (confirm == DialogResult.Yes))
                {
                    if (obj == null)
                        obj = new VeiculosClientes();

                    obj.Idcliente = cli.Idcliente;
                    obj.Placa = txtPlaca.Text;
                    obj.Veiculo = txtVeiculo.Text;
                    obj.Tipo = cboTipo.SelectedItem.ToString()[0];
                    obj.Ativo = (chkAtivo.Checked) ? 1 : 0;

                    if (obj.Idvc == 0)
                    {
                        oDAO.Inserir(obj);
                    }
                    else
                    {
                        oDAO.Alterar(obj);
                    }
                    MessageBox.Show("Salvo com Sucesso !!!");
                    this.Close();
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IUVeiculoCliente_Load(object sender, EventArgs e)
        {

        }

        private Boolean ValidarCampos()
        {
            txtPlaca.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtPlaca.Text.Length < 7)
            {
                MessageBox.Show("O campo [ Placa ] é inválido!");
                return false;
            }
            txtPlaca.TextMaskFormat = MaskFormat.IncludeLiterals;

            if (txtVeiculo.TextLength == 0)
            {
                MessageBox.Show("O campo [ Veiculo ] é obrigatório!");
                return false;
            }

            if (cboTipo.SelectedItem == null)
            {
                MessageBox.Show("O campo [ Tipo de Veiculo ] é inválido!");
                return false;
            }

            return true;
        }

        private void txtPlaca_Leave(object sender, EventArgs e)
        {
            txtPlaca.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtPlaca.Text = txtPlaca.Text.Trim().Replace(" ", "");
            if (txtPlaca.Text.Length < 7 && txtPlaca.Text.Length >= 0)
            {
                MessageBox.Show("O campo [ PLACA ] está inválido!");
                txtPlaca.Focus();
                btnSalvar.Enabled = false;
            }
            else if (txtPlaca.Text.Length == 7)
            {
                txtPlaca.TextMaskFormat = MaskFormat.IncludeLiterals;
                var teste = oDAO.GetByPlaca(txtPlaca.Text, cli.Idcliente);
                if (teste != null)
                {
                    btnSalvar.Enabled = false;
                    Clientes old_cli = new ClienteDAO().GetById(teste.Idcliente);
                    MessageBox.Show("Veiculo Já Cadastrado para: \n" + old_cli.Idcliente + " - " + old_cli.Nome, "RTPark", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPlaca.Focus();
                }
                else
                {
                    txtPlaca.TextMaskFormat = MaskFormat.IncludeLiterals;
                    btnSalvar.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("O campo [ PLACA ] está inválido!");
                txtPlaca.Focus();
                btnSalvar.Enabled = false;
            }
            txtPlaca.TextMaskFormat = MaskFormat.IncludeLiterals;
        }

        private void IUVeiculoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
