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
    public partial class IUEstabelecimento : Form
    {
        EstabelecimentoDAO oDAO;
        Estabelecimentos obj;
        Boolean salvo = false;
        TelaPrincipal tela;

        public IUEstabelecimento(int id, TelaPrincipal tela)
        {
            InitializeComponent();
            oDAO = new EstabelecimentoDAO();
            obj = new Estabelecimentos();
            this.tela = tela;

            cboUF.SelectedIndex = 0;

            if (id != 0)
            {
                obj = oDAO.GetById(id);

                txtIdEstabelecimento.Text = obj.Idestabelecimento.ToString();
                txtNome.Text = obj.Nome;
                txtCnpj.Text = obj.Cnpj;
                txtRua.Text = obj.Rua;
                txtNumero.Text = obj.Numero;
                txtBairro.Text = obj.Bairro;
                txtCidade.Text = obj.Cidade;
                txtCep.Text = obj.Cep;
                txtTelefones.Text = obj.Telefones;
                txtEmail.Text = obj.Email;
                txtVCarros.Value = obj.Vagas_carro;
                txtVMotos.Value = obj.Vagas_moto;
                txtVOutros.Value = obj.Vagas_outros;

                cboUF.SelectedIndex = cboUF.Items.IndexOf(obj.Estado);

                btnLimpar.Enabled = false;
            }
        }


        private void IUEstabelecimento_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void IUEstabelecimento_KeyDown(object sender, KeyEventArgs e)
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
            txtIdEstabelecimento.Text = null;
            txtNome.Text = null;
            txtCnpj.Text = null;
            txtRua.Text = null;
            txtNumero.Text = null;
            txtBairro.Text = null;
            txtCidade.Text = "Bauru";
            txtCep.Text = null;
            txtTelefones.Text = null;
            txtEmail.Text = null;
            txtVCarros.Value = 0;
            txtVMotos.Value = 0;
            txtVOutros.Value = 0;

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
                        obj = new Estabelecimentos();

                    obj.Nome = txtNome.Text;
                    txtCnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    if (txtCnpj.Text.Length > 0)
                        txtCnpj.TextMaskFormat = MaskFormat.IncludeLiterals;
                    obj.Cnpj = txtCnpj.Text;
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
                    obj.Vagas_carro = (int)txtVCarros.Value;
                    obj.Vagas_moto = (int)txtVMotos.Value;
                    obj.Vagas_outros = (int)txtVOutros.Value;

                    if (validaCampos())
                    {
                        if (obj.Idestabelecimento == 0)
                            oDAO.Inserir(obj);
                        else
                        {
                            oDAO.Alterar(obj);
                            tela.SetEst(obj);
                        }
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
            txtCnpj.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtCnpj.Text.Length < 14 && txtCnpj.Text.Length > 0)
            {
                MessageBox.Show("O campo [ CNPJ ] é inválido!");
                return false;
            }
            txtCnpj.TextMaskFormat = MaskFormat.IncludeLiterals;

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

            return true;
        }

        private void IUEstabelecimento_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!salvo)
            {
                DialogResult dr = MessageBox.Show("Tem Certeza que deseja sair ?", "RTPark", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}

