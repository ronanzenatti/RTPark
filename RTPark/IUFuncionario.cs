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

namespace RTPark
{
    public partial class IUFuncionario : Form
    {
        FuncionarioDAO fDAO;
        Funcionarios obj;

        public IUFuncionario(int id)
        {
            InitializeComponent();

            obj = new Funcionarios();

            if (id != 0)
            {
                fDAO = new FuncionarioDAO();
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
                v = Convert.ToDouble(n) / 100;
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
            cboUF.SelectedIndex = 0;
            cboTipo.SelectedIndex = 0;

            dtpNasci.Format = DateTimePickerFormat.Custom;
            dtpNasci.CustomFormat = " ";
            dtpNasci.ShowCheckBox = true;
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
            ListaFuncionarios lf = new ListaFuncionarios();
            lf.Show();
            //this.Close();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
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
            DialogResult confirm = MessageBox.Show("Deseja Salvar o Registro?", "RTPark", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (validaCampos() && (confirm == DialogResult.Yes))
            {
                obj = new Funcionarios();

                obj.Ativo = (chkAtivo.Checked == true) ? Convert.ToByte(1) : Convert.ToByte(0);
                obj.Nome = txtNome.Text;
                obj.Cpf = txtCpf.Text;
                obj.Rg = txtRg.Text;
                obj.Dt_nasc = dtpNasci.Value;
                obj.Rua = txtRua.Text;
                obj.Numero = txtNumero.Text;
                obj.Bairro = txtBairro.Text;
                obj.Cidade = txtCidade.Text;
                obj.Estado = cboUF.SelectedItem.ToString();
                obj.Cep = txtCep.Text;
                obj.Telefones = txtTelefones.Text;
                obj.Email = txtEmail.Text;
                obj.Tipo = Convert.ToChar(cboTipo.SelectedItem.ToString()[0]);
                obj.Usuario = txtUsuario.Text;
                obj.Senha = txtSenha.Text;
                String sal = txtSalario.Text.Replace(".", "").Replace(",", ".");
                if (sal.Length > 0)
                {
                    obj.Salario = Convert.ToDecimal(sal);
                }

                MessageBox.Show(txtCep.Text.Length.ToString());

                if (validaCampos())
                {
                    // fDAO.Inserir(obj);
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
            if (txtCpf.TextLength < 11 && txtCpf.Text.Length > 0)
            {
                MessageBox.Show("O campo [ CPF ] é inválido!");
                return false;
            }
            txtCpf.TextMaskFormat = MaskFormat.IncludeLiterals;

            txtCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtCep.TextLength < 8 && txtCep.TextLength > 0)
            {
                MessageBox.Show("O campo [ CEP ] é inválido!");
                return false;
            }
            txtCep.TextMaskFormat = MaskFormat.IncludeLiterals;

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
    }
}
