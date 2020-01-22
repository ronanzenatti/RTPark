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
    public partial class IUFuncionario : Form
    {
        FuncionarioDAO fDAO;
        Funcionarios obj;
        Form lista;
        Boolean salvo = false;

        public IUFuncionario(int id, Form lista)
        {
            InitializeComponent();
            fDAO = new FuncionarioDAO();
            obj = new Funcionarios();
            this.lista = lista;

            cboUF.SelectedIndex = 0;
            cboTipo.SelectedIndex = 0;

            if (id != 0)
            {
                obj = fDAO.GetById(id);

                txtIdFuncionario.Text = obj.Idfuncionario.ToString();
                txtNome.Text = obj.Nome;
                txtCpf.Text = obj.Cpf;
                txtRg.Text = obj.Rg;
                txtRua.Text = obj.Rua;
                txtNumero.Text = obj.Numero;
                txtBairro.Text = obj.Bairro;
                txtCidade.Text = obj.Cidade;
                txtCep.Text = obj.Cep;
                txtTelefones.Text = obj.Telefones;
                txtEmail.Text = obj.Email;
                txtSalario.Text = obj.Salario.ToString();
                txtUsuario.Text = obj.Usuario;
                chkAtivo.Checked = (obj.Ativo == 1) ? true : false;

                dtpNasci.Checked = (obj.Dt_nasc.Equals("")) ? false : true;

                if (dtpNasci.Checked)
                {
                    dtpNasci.Value = Convert.ToDateTime(obj.Dt_nasc);
                }

                cboUF.SelectedIndex = cboUF.Items.IndexOf(obj.Estado);

                if (obj.Tipo == 'A')
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

        public static void FormataMoeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;

            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                {
                    n = "";
                }
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                {
                    n = n.Substring(1, n.Length - 1);
                }

                if (n.Substring(n.Length - 1, 1) == "-")
                {
                    n = n.Substring(0, n.Length - 1);
                    v = Convert.ToDouble(n) / 100;
                    v = v * -1;
                }
                else
                {
                    v = Convert.ToDouble(n) / 100;
                }

                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception)
            {

            }

        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            FormataMoeda(ref txtSalario);
        }

        private void IUFuncionario_Load(object sender, EventArgs e)
        {
            if (!dtpNasci.Checked)
            {
                dtpNasci.Format = DateTimePickerFormat.Custom;
                dtpNasci.CustomFormat = " ";
                dtpNasci.ShowCheckBox = true;
            }
        }

        private void IUFuncionario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void IUFuncionario_KeyDown(object sender, KeyEventArgs e)
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
            txtIdFuncionario = null;
            txtNome.Text = null;
            txtCpf.Text = null;
            txtRg.Text = null;
            txtRua.Text = null;
            txtNumero.Text = null;
            txtBairro.Text = null;
            txtCidade.Text = "Bauru";
            txtCep.Text = null;
            txtTelefones.Text = null;
            txtEmail.Text = null;
            txtUsuario.Text = null;
            txtSenha.Text = null;
            txtSalario.Text = null;
            chkAtivo.Checked = true;
            dtpNasci.Value = DateTime.Now;
            cboTipo.SelectedIndex = 0;
            cboUF.SelectedIndex = 0;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                DialogResult confirm = MessageBox.Show("Deseja Salvar o Registro?", "RTPark", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (validaCampos() && (confirm == DialogResult.Yes))
                {
                    if (obj == null)
                        obj = new Funcionarios();

                    obj.Ativo = (chkAtivo.Checked == true) ? Convert.ToInt32(1) : Convert.ToInt32(0);
                    obj.Nome = txtNome.Text;
                    txtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    if (txtCpf.Text.Length > 0)
                        txtCpf.TextMaskFormat = MaskFormat.IncludeLiterals;
                    obj.Cpf = txtCpf.Text;
                    obj.Rg = txtRg.Text;
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
                    obj.Tipo = Convert.ToChar(cboTipo.SelectedItem.ToString()[0]);
                    obj.Usuario = txtUsuario.Text;
                    obj.Senha = txtSenha.Text;
                    String sal = txtSalario.Text.Replace(".", "").Replace(",", ".");

                    if (sal.Length > 0)
                    {
                        obj.Salario = Convert.ToDecimal(sal, new CultureInfo("en-US"));

                    }

                    if (validaCampos())
                    {
                        if (obj.Idfuncionario == 0)
                            fDAO.Inserir(obj);
                        else
                            fDAO.Alterar(obj);
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

            txtCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtCpf.Text.Length < 11 && txtCpf.Text.Length > 0)
            {
                MessageBox.Show("O campo [ CPF ] é inválido!");
                return false;
            }
            txtCpf.TextMaskFormat = MaskFormat.IncludeLiterals;

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

            if (txtUsuario.TextLength == 0)
            {
                MessageBox.Show("O campo [ Usuário ] é obrigatório!");
                return false;
            }

            if (txtSenha.TextLength == 0)
            {
                MessageBox.Show("O campo [ Senha ] é obrigatório!");
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

        private void IUFuncionario_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
