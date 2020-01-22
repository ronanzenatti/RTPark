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
    public partial class IUFormaPagamento : Form
    {
        FormaPagamentoDAO oDAO;
        FormaPagamento obj;
        Form lista;
        int idestabelecimento;
        Boolean salvo = false;

        public IUFormaPagamento(int id, Form lista, int idestabelecimento)
        {
            InitializeComponent();
            oDAO = new FormaPagamentoDAO();
            obj = new FormaPagamento();
            this.lista = lista;
            this.idestabelecimento = idestabelecimento;

            if (id != 0)
            {
                obj = oDAO.GetById(id);

                txtIdServico.Text = obj.Idforma.ToString();
                txtDescricao.Text = obj.Descricao;                
                txtTaxa.Text = obj.Taxa.ToString();                
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
            txtTaxa.Text = null;     
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validaCampos())
            {
                DialogResult confirm = MessageBox.Show("Deseja Salvar o Registro?", "RTPark", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (validaCampos() && (confirm == DialogResult.Yes))
                {
                    if (obj == null)
                        obj = new FormaPagamento();

                    obj.Idestabelecimento = idestabelecimento;
                    obj.Descricao = txtDescricao.Text;                  
                    obj.Ativo = chkAtivo.Checked == true;
                    String vTaxa = txtTaxa.Text.Replace(".", "").Replace(",", ".");                    

                    if (vTaxa.Length > 0)
                        obj.Taxa = Convert.ToDecimal(vTaxa, new CultureInfo("en-US"));

                    if (validaCampos())
                    {
                        if (obj.Idforma == 0)
                            obj.Idforma = oDAO.Inserir(obj);
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
            }

        }

        private void txtTaxa_TextChanged(object sender, EventArgs e)
        {
            FormataMoeda(ref txtTaxa);
        }
    }
}
