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
    public partial class IUServico : Form
    {
        ServicoDAO oDAO;
        Servicos obj;
        Form lista;
        IUContrato contr;
        IUConfigMovimento config;
        Boolean salvo = false;

        public IUServico(int id, Form lista, IUContrato contr, IUConfigMovimento config)
        {
            InitializeComponent();
            oDAO = new ServicoDAO();
            obj = new Servicos();
            this.lista = lista;
            this.contr = contr;
            this.config = config;

            cboTipoCobranca.SelectedIndex = 0;

            if (id != 0)
            {
                obj = oDAO.GetById(id);

                txtIdServico.Text = obj.Idservico.ToString();
                txtDescricao.Text = obj.Descricao;
                txtQuantidade.Value = obj.Quantidade;
                txtVCarro.Text = obj.ValorCarro.ToString();
                txtVMoto.Text = obj.ValorMoto.ToString();
                txtVOutros.Text = obj.ValorOutros.ToString();

                chkAtivo.Checked = (obj.Ativo == 1) ? true : false;

                switch (obj.TipoCobranca)
                {
                    case 'H':
                        {
                            cboTipoCobranca.SelectedIndex = 0;
                            break;
                        }
                    case 'I':
                        {
                            cboTipoCobranca.SelectedIndex = 1;
                            break;
                        }
                    case 'D':
                        {
                            cboTipoCobranca.SelectedIndex = 2;
                            break;
                        }
                    case 'M':
                        {
                            cboTipoCobranca.SelectedIndex = 3;
                            break;
                        }
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

        private void IUServico_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void IUServico_KeyDown(object sender, KeyEventArgs e)
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
            txtIdServico = null;
            txtDescricao.Text = null;
            txtQuantidade.Value = 0;
            txtVCarro.Text = null;
            txtVMoto.Text = null;
            txtVOutros.Text = null;
            chkAtivo.Checked = true;
            cboTipoCobranca.SelectedIndex = 0;

        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                DialogResult confirm = MessageBox.Show("Deseja Salvar o Registro?", "RTPark", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (validaCampos() && (confirm == DialogResult.Yes))
                {
                    if (obj == null)
                        obj = new Servicos();

                    obj.Descricao = txtDescricao.Text;
                    obj.TipoCobranca = (cboTipoCobranca.SelectedItem.ToString() == "Minuto") ? 'I' : cboTipoCobranca.SelectedItem.ToString()[0];
                    obj.Quantidade = (int)txtQuantidade.Value;
                    obj.Ativo = (chkAtivo.Checked == true) ? Convert.ToInt32(1) : Convert.ToInt32(0);

                    String vCarro = txtVCarro.Text.Replace(".", "").Replace(",", ".");
                    String vMoto = txtVMoto.Text.Replace(".", "").Replace(",", ".");
                    String vOutros = txtVOutros.Text.Replace(".", "").Replace(",", ".");

                    if (vCarro.Length > 0)
                        obj.ValorCarro = Convert.ToDecimal(vCarro, new CultureInfo("en-US"));

                    if (vMoto.Length > 0)
                        obj.ValorMoto = Convert.ToDecimal(vMoto, new CultureInfo("en-US"));

                    if (vOutros.Length > 0)
                        obj.ValorOutros = Convert.ToDecimal(vOutros, new CultureInfo("en-US"));

                    if (validaCampos())
                    {
                        if (obj.Idservico == 0)
                            obj.Idservico = oDAO.Inserir(obj);
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

            if (txtDescricao.TextLength == 0)
            {
                MessageBox.Show("O campo [ Descrição ] é obrigatório!");
                return false;
            }

            if (txtQuantidade.Value == 0)
            {
                MessageBox.Show("O campo [ Quantidade ] deve ser maior que 0!");
                return false;
            }


            if (cboTipoCobranca.SelectedItem == null)
            {
                MessageBox.Show("O campo [ Tipo de Cobrança ] é inválido!");
                return false;
            }

            return true;
        }

        private void IUServico_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!salvo)
            {
                DialogResult dr = MessageBox.Show("Tem Certeza que deseja sair ?", "RTPark", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (lista != null)
                        lista.Show();

                    if (contr != null && obj.Idservico != 0)
                        contr.CarregaServico(obj.Idservico);

                    if (config != null && obj.Idservico != 0)
                        config.CarregaServico(obj.Idservico);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                if (lista != null)
                    lista.Show();

                if (contr != null && obj.Idservico != 0)
                    contr.CarregaServico(obj.Idservico);

                if (config != null && obj.Idservico != 0)
                    config.CarregaServico(obj.Idservico);
            }

        }

        private void txtVCarro_TextChanged(object sender, EventArgs e)
        {
            FormataMoeda(ref txtVCarro);
        }

        private void txtVMoto_TextChanged(object sender, EventArgs e)
        {
            FormataMoeda(ref txtVMoto);
        }

        private void txtVOutros_TextChanged(object sender, EventArgs e)
        {
            FormataMoeda(ref txtVOutros);
        }
    }
}
