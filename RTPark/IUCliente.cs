using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RTPark.DAO;
using RTPark.Entidades;
using System.Globalization;

namespace RTPark
{
    public partial class IUCliente : Form
    {
        ClienteDAO oDAO;
        Clientes obj;
        ListaClientes lista;
        Boolean salvo = false;

        public IUCliente(int id, ListaClientes lista)
        {
            InitializeComponent();
            oDAO = new ClienteDAO();
            obj = new Clientes();
            this.lista = lista;

            cboUF.SelectedIndex = 0;
            cboTipo.SelectedIndex = 0;

            if (id != 0)
            {
                obj = oDAO.GetById(id);

                txtIdCliente.Text = obj.Idcliente.ToString();
                txtNome.Text = obj.Nome;
                txtDoc_fed.Text = obj.Doc_fed;
                txtDoc_est.Text = obj.Doc_est;
                txtRua.Text = obj.Rua;
                txtNumero.Text = obj.Numero;
                txtBairro.Text = obj.Bairro;
                txtCidade.Text = obj.Cidade;
                txtCep.Text = obj.Cep;
                txtTelefones.Text = obj.Telefones;
                txtEmail.Text = obj.Email;

                dtpNasci.Checked = (obj.Dt_nasc.Equals("")) ? false : true;

                if (dtpNasci.Checked)
                {
                    dtpNasci.Value = Convert.ToDateTime(obj.Dt_nasc);
                }

                cboUF.SelectedIndex = cboUF.Items.IndexOf(obj.Estado);

                if (obj.Tipo_pessoa == 'F')
                {
                    cboTipo.SelectedIndex = 0;
                }
                else
                {
                    cboTipo.SelectedIndex = 1;
                }
                btnLimpar.Enabled = false;
            }
        }

        private void IUCliente_Load(object sender, EventArgs e)
        {
            if (!dtpNasci.Checked)
            {
                dtpNasci.Format = DateTimePickerFormat.Custom;
                dtpNasci.CustomFormat = " ";
                dtpNasci.ShowCheckBox = true;
            }
        }

        private void IUCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void IUCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                e.SuppressKeyPress = true;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIdCliente = null;
            txtNome.Text = null;
            txtDoc_fed.Text = null;
            txtDoc_est.Text = null;
            txtRua.Text = null;
            txtNumero.Text = null;
            txtBairro.Text = null;
            txtCidade.Text = "Bauru";
            txtCep.Text = null;
            txtTelefones.Text = null;
            txtEmail.Text = null;
            dtpNasci.Value = DateTime.Now;
            cboTipo.SelectedIndex = 0;
            cboUF.SelectedIndex = 0;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                DialogResult confirm = MessageBox.Show("Deseja Salvar o Registro?", "RTPark", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (validaCampos() && (confirm == DialogResult.Yes))
                {
                    if (obj == null)
                        obj = new Clientes();

                    obj.Nome = txtNome.Text;
                    txtDoc_fed.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    if (txtDoc_fed.Text.Length > 0)
                        txtDoc_fed.TextMaskFormat = MaskFormat.IncludeLiterals;
                    obj.Doc_fed = txtDoc_fed.Text;
                    obj.Doc_est = txtDoc_est.Text;
                    obj.Dt_nasc = (dtpNasci.Checked != false) ? dtpNasci.Value.ToString("yyyy-MM-dd") : "";
                    obj.Rua = txtRua.Text;
                    obj.Numero = txtNumero.Text;
                    obj.Bairro = txtBairro.Text;
                    obj.Cidade = txtCidade.Text;
                    obj.Estado = cboUF.SelectedItem.ToString();

                    txtCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    if (txtCep.Text.Length > 0)
                        txtCep.TextMaskFormat = MaskFormat.IncludeLiterals;
                    obj.Cep = txtCep.Text;
                    obj.Telefones = txtTelefones.Text;
                    obj.Email = txtEmail.Text;
                    obj.Tipo_pessoa = Convert.ToChar(cboTipo.SelectedItem.ToString()[0]);

                    if (validaCampos())
                    {
                        if (obj.Idcliente == 0)
                            oDAO.Inserir(obj);
                        else
                            oDAO.Alterar(obj);
                        MessageBox.Show("Salvo com Sucesso !!!");
                        salvo = true;
                        this.Close();
                    }
                }
            }
        }

        private Boolean validaCampos()
        {

            if (txtNome.TextLength == 0)
            {
                MessageBox.Show("O campo [ Nome ] é obrigatório!");
                return false;
            }

            txtDoc_fed.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtDoc_fed.Text.Length < 11 && txtDoc_fed.Text.Length > 0)
            {
                MessageBox.Show("O campo [ CPF ] é inválido!");
                return false;
            }
            txtDoc_fed.TextMaskFormat = MaskFormat.IncludeLiterals;

            txtCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtCep.Text.Length < 8 && txtCep.Text.Length > 0)
            {
                MessageBox.Show("O campo [ CEP ] é inválido!");
                return false;
            }
            txtCep.TextMaskFormat = MaskFormat.IncludeLiterals;

            if (cboUF.SelectedItem == null)
            {
                MessageBox.Show("O campo [ UF ] é inválido!");
                return false;
            }

            if (cboTipo.SelectedItem == null)
            {
                MessageBox.Show("O campo [ Tipo ] é inválido!");
                return false;
            }

            return true;
        }

        private void dtpNasci_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtp = (DateTimePicker)sender;
            if (dtp.ShowCheckBox == true)
            {
                if (dtp.Checked == false)
                {
                    dtp.CustomFormat = " ";
                    dtp.Format = DateTimePickerFormat.Custom;
                }
                else
                {
                    dtp.Format = DateTimePickerFormat.Short;
                }
            }
            else
            {
                dtp.Format = DateTimePickerFormat.Short;
            }
        }

        private void IUCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!salvo)
            {
                DialogResult dr = MessageBox.Show("Tem Certeza que deseja sair ?", "RTPark", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    lista.Show();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                lista.Show();
            }
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            String fed = txtDoc_fed.Text;
            String est = txtDoc_est.Text;
            String tipo = cboTipo.SelectedItem.ToString();

            txtDoc_fed.Text = null;
            txtDoc_est.Text = null;

            if (cboTipo.SelectedItem.ToString() == "Fisica")
            {
                lblFed.Text = "CPF:";
                lblEst.Text = "RG:";
                txtDoc_fed.Mask = "999,999,999-99";
            }
            else
            {
                lblFed.Text = "CNPJ:";
                lblEst.Text = "IE:";
                txtDoc_fed.Mask = "99,999,999/9999-99";
            }

            if (cboTipo.SelectedItem.ToString() == tipo)
            {
                txtDoc_fed.Text = fed;
                txtDoc_est.Text = est;
            }
        }
    }
}
