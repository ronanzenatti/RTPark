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
    public partial class IUConfigMovimento : Form
    {
        Estabelecimentos est;
        ConfigMovimento obj;
        ConfigMovimentoDAO oDAO;

        public IUConfigMovimento(Estabelecimentos est)
        {
            InitializeComponent();
            this.est = est;
            lblEmpresa.Text = est.Nome;
            oDAO = new ConfigMovimentoDAO();
            obj = oDAO.GetLast(est.Idestabelecimento);

            if (obj.Idconfig != 0)
            {
                chkCnpj.Checked = Convert.ToBoolean(obj.ImprimeCnpj);
                chkTelefones.Checked = Convert.ToBoolean(obj.ImprimeTelefones);
                chkEndereco.Checked = Convert.ToBoolean(obj.ImprimeEnd);

                switch (obj.ImprimeEntrada)
                {
                    case 'P':
                        rbPergE.Checked = true;
                        break;
                    case 'S':
                        rbSimE.Checked = true;
                        break;
                    case 'N':
                        rbNaoE.Checked = true;
                        break;
                }

                switch (obj.ImprimeSaida)
                {
                    case 'P':
                        rbPergS.Checked = true;
                        break;
                    case 'S':
                        rbSimS.Checked = true;
                        break;
                    case 'N':
                        rbNaoS.Checked = true;
                        break;
                }

                switch (obj.FaturaExcedente)
                {
                    case 'I':
                        rbInteiro.Checked = true;
                        break;
                    case 'P':
                        rbProporcional.Checked = true;
                        break;
                    case 'Z':
                        rbZero.Checked = true;
                        break;
                    case 'M':
                        rbManual.Checked = true;
                        break;
                }

                CarregaServico(obj.CobrancaPadrao);
            }
        }

        private void btnBuscaServico_Click(object sender, EventArgs e)
        {
            BuscaServico tela = new BuscaServico(null, this);
            tela.ShowDialog();
        }

        private void btnAddServico_Click(object sender, EventArgs e)
        {
            IUServico tela = new IUServico(0, null, null, this);
            tela.ShowDialog();
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

        public void CarregaServico(int id)
        {
            ServicoDAO sDAO = new ServicoDAO();
            Servicos sObj = sDAO.GetById(id);

            txtIdServico.Text = sObj.Idservico.ToString();
            txtNomeServico.Text = sObj.Descricao;
            txtVCarro.Text = sObj.ValorCarro.ToString();
            txtVMoto.Text = sObj.ValorMoto.ToString();
            txtVOutros.Text = sObj.ValorOutros.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                DialogResult confirm = MessageBox.Show("Deseja Salvar o Registro?", "RTPark", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (ValidarCampos() && (confirm == DialogResult.Yes))
                {
                    if (obj == null)
                        obj = new ConfigMovimento();

                    obj.Idestabelecimento = est.Idestabelecimento;
                    obj.CobrancaPadrao = Convert.ToInt32(txtIdServico.Text);
                    obj.ImprimeCnpj = (chkCnpj.Checked) ? 1 : 0;
                    obj.ImprimeEnd = (chkEndereco.Checked) ? 1 : 0;
                    obj.ImprimeTelefones = (chkTelefones.Checked) ? 1 : 0;
                    obj.ImprimeEntrada = gbEntrada.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text[0];
                    obj.ImprimeSaida = gbSaida.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text[0];
                    obj.FaturaExcedente = gbExcedente.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text[0];

                    if (obj.Idconfig == 0)
                        obj.Idconfig = oDAO.Inserir(obj);
                    else
                        oDAO.Alterar(obj);
                    MessageBox.Show("Salvo com Sucesso !!!");
                    this.Close();
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Boolean ValidarCampos()
        {
            if (txtIdServico.TextLength == 0)
            {
                MessageBox.Show("O campo [ Serviço ] obrigatório!");
                return false;
            }

            return true;
        }
    }
}
