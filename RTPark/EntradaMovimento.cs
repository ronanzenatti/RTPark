using System;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using RTPark.Entidades;
using System.Linq;
using RTPark.DAO;
using RTPark.Util;


namespace RTPark
{
    public partial class EntradaMovimento : Form
    {
        Estabelecimentos est;
        ConfigMovimento config;
        Clientes cli;
        VeiculosClientes vc;
        Servicos sv;
        Contratos contr;
        Funcionarios fun;
        Movimentos obj;
        TelaPrincipal telaMov;
        MovimentoDAO oDAO;

        public EntradaMovimento(Estabelecimentos est, ConfigMovimento config, Funcionarios fun, Form tela)
        {
            InitializeComponent();
            txtHoraEntrada.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            this.est = est;
            this.config = config;
            this.fun = fun;
            CarregaServico();
            MontaCupom();
            obj = new Movimentos();
            oDAO = new MovimentoDAO();
            telaMov = (TelaPrincipal)tela;
        }

        private void timerEntrada_Tick(object sender, EventArgs e)
        {
            txtHoraEntrada.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private void txtPlaca_Leave(object sender, EventArgs e)
        {
            Movimentos test = oDAO.GetByCampo("placa = '", txtPlaca.Text + "' ", 'S');
            txtPlaca.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtPlaca.Text.Length == 7)
            {
                if (test != null)
                {
                    btnSalvar.Enabled = false;
                    MessageBox.Show("Veiculo Já Estacionado! Placa: " + test.Placa, "RTPark", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPlaca.Focus();
                }
                else
                {
                    txtPlaca.TextMaskFormat = MaskFormat.IncludeLiterals;
                    timerEntrada.Enabled = false;
                    txtHoraEntrada.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                    BuscaPlaca();
                    btnSalvar.Enabled = true;
                }
            }
            else if (txtPlaca.Text.Length < 7 && txtPlaca.Text.Length > 0)
            {
                MessageBox.Show("O campo [ PLACA ] está inválido!");
                txtPlaca.Focus();
                btnSalvar.Enabled = false;
            }
            txtPlaca.TextMaskFormat = MaskFormat.IncludeLiterals;
        }

        private void cboTipoPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDocFed.Text = null;

            if (cboTipoPessoa.SelectedItem.ToString() == "Física")
            {
                txtDocFed.Mask = "999,999,999-99";
            }
            else
            {
                txtDocFed.Mask = "99,999,999/9999-99";
            }
        }

        private void MontaCupom()
        {
            ArrayList cupom = new ArrayList();

            // ------------------------------------------
            cupom.Add(est.Nome);
            if (Convert.ToBoolean(config.ImprimeEnd))
                cupom.Add(est.Rua + ", " + est.Numero);

            if (Convert.ToBoolean(config.ImprimeCnpj))
                cupom.Add(est.Cnpj);

            if (Convert.ToBoolean(config.ImprimeTelefones))
                cupom.Add(est.Telefones);
            // ------------------------------------------

            cupom.Add("-----------------------------------------");
            cupom.Add("  ****** COMPROVANTE DE ENTRADA ******   ");
            cupom.Add("-----------------------------------------");

            cupom.Add("DOC.....: ");
            cupom.Add("PLACA...: " + txtPlaca.Text);

            if (cli != null)
                cupom.Add("CLIENTE.: " + cli.Nome);

            txtDocFed.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (cli != null || txtDocFed.Text.Length > 0)
            {
                txtDocFed.TextMaskFormat = MaskFormat.IncludeLiterals;
                cupom.Add("CPF/CNPJ: " + txtDocFed.Text);
            }

            if (contr != null)
                cupom.Add("CONTRATO: " + contr.Descricao);

            if (txtVeiculo.Text.Length > 0)
                cupom.Add("VEICULO.: " + txtVeiculo.Text);

            if (txtVaga.Value > 0)
                cupom.Add("VAGA....: " + txtVaga.Value.ToString().PadLeft(3, '0'));

            cupom.Add("ENTRADA.: " + txtHoraEntrada.Text);

            cupom.Add("-----------------------------------------");
            cupom.Add(" ");
            cupom.Add(" ");
            cupom.Add(" ");

            txtCupom.Lines = (String[])cupom.ToArray(typeof(string));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MontaCupom();

            if (obj == null)
                obj = new Movimentos();

            obj.DhEntrada = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            obj.Placa = txtPlaca.Text;
            obj.TipoVeiculo = gbTipoVeiculo.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text[0];
            obj.Veiculo = txtVeiculo.Text;
            obj.Vaga = (int)txtVaga.Value;
            obj.Idservico = Convert.ToInt32(cboServico.SelectedValue);
            obj.Idfuncionario = fun.Idfuncionario;
            obj.Idcontrato = (contr != null) ? contr.Idcontrato : 0;
            obj.DocFed = txtDocFed.Text;

            obj.Idmovimento = oDAO.Inserir(obj);

            MontaCupom();
            if (config.ImprimeEntrada == 'P')
            {
                DialogResult dr = MessageBox.Show("Deseja Imprimir o Cupom de Entreda ?", "RTPark", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    Impressao();
                }
            }
            else if (config.ImprimeEntrada == 'S')
            {
                Impressao();
            }

            telaMov.CarregaGrid();
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BuscaPlaca()
        {
            VeiculosClienteDAO vDAO = new VeiculosClienteDAO();
            vc = vDAO.GetByPlaca(txtPlaca.Text);

            if (vc != null)
            {
                txtVeiculo.Text = vc.Veiculo;
                switch (vc.Tipo)
                {
                    case 'C':
                        rbCarro.Checked = true;
                        break;

                    case 'M':
                        rbMoto.Checked = true;
                        break;

                    case 'O':
                        rbOutros.Checked = true;
                        break;
                }
                BuscaCLiente();
            }
            else
            {
                txtVeiculo.Text = null;
                rbCarro.Checked = true;

                txtIdContrato.Text = null;
                txtNomeContrato.Text = null;
                cboServico.SelectedValue = config.CobrancaPadrao;

                lblCliente.Text = null;
                txtDocFed.Text = null;
                cboTipoPessoa.SelectedIndex = 0;

                vc = null;
                cli = null;
                contr = null;

            }
            MontaCupom();
        }

        private void BuscaCLiente()
        {
            if (vc != null)
            {
                ClienteDAO cDAO = new ClienteDAO();
                cli = cDAO.GetById(vc.Idcliente);
                if (cli != null)
                {
                    lblCliente.Text = cli.Nome;
                    if (cli.Tipo_pessoa == 'F')
                    {
                        cboTipoPessoa.SelectedIndex = 0;
                    }
                    else
                    {
                        cboTipoPessoa.SelectedIndex = 1;
                    }
                    txtDocFed.Text = cli.Doc_fed;
                    BuscaContrato(0);
                }
                else
                {
                    lblCliente.Text = null;
                    txtDocFed.Text = null;
                    cboTipoPessoa.SelectedIndex = 0;
                }
            }
            MontaCupom();
        }

        public void BuscaContrato(int idContrato)
        {
            ContratoDAO cDAO = new ContratoDAO();
            if (idContrato == 0)
            {
                contr = cDAO.GetByCliente(cli.Idcliente);
            }
            else
            {
                contr = cDAO.GetById(idContrato);
            }

            if (contr != null)
            {
                txtIdContrato.Text = contr.Idcontrato.ToString();
                txtNomeContrato.Text = contr.Descricao;

                ServicoDAO sDAO = new ServicoDAO();
                cboServico.SelectedValue = contr.Idservico;
                sv = sDAO.GetById(Convert.ToInt32(cboServico.SelectedValue));
                AtualizaValor();
            }
            else
            {
                txtIdContrato.Text = null;
                txtNomeContrato.Text = null;
                cboServico.SelectedValue = config.CobrancaPadrao;
            }
        }

        private void CarregaServico()
        {
            ServicoDAO sDAO = new ServicoDAO();
            cboServico.DataSource = sDAO.BuscaPorCampo("ativo", "1");
            cboServico.ValueMember = "ID";
            cboServico.DisplayMember = "Descrição";
            MontaCupom();

            cboServico.SelectedValue = config.CobrancaPadrao;
            sv = sDAO.GetById(Convert.ToInt32(cboServico.SelectedValue));
            AtualizaValor();
        }

        private void AtualizaValor()
        {
            ServicoDAO sDAO = new ServicoDAO();
            sv = sDAO.GetById(Convert.ToInt32(cboServico.SelectedValue));
            if (sv != null)
            {
                if (rbCarro.Checked)
                    txtValor.Text = sv.ValorCarro.ToString();

                if (rbMoto.Checked)
                    txtValor.Text = sv.ValorMoto.ToString();

                if (rbOutros.Checked)
                    txtValor.Text = sv.ValorOutros.ToString();
            }
        }

        private void cboServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                AtualizaValor();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            FormataMoeda(ref txtValor);
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

        private void rbCarro_CheckedChanged(object sender, EventArgs e)
        {
            txtValor.Text = sv.ValorCarro.ToString();
        }

        private void rbMoto_CheckedChanged(object sender, EventArgs e)
        {
            txtValor.Text = sv.ValorMoto.ToString();
        }

        private void rbOutros_CheckedChanged(object sender, EventArgs e)
        {
            txtValor.Text = sv.ValorOutros.ToString();
        }

        private void txtVaga_Leave(object sender, EventArgs e)
        {
            if (txtVaga.Value != 0)
            {
                Movimentos test = oDAO.GetByCampo("vaga = '", txtVaga.Value.ToString() + "' ", 'S');
                if (test != null)
                {
                    btnSalvar.Enabled = false;
                    MessageBox.Show("Vaga OCUPADA, Placa: " + test.Placa, "RTPark", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtVaga.Focus();
                }
                return;
            }
            btnSalvar.Enabled = true;
            MontaCupom();
        }

        private void cboServico_Leave(object sender, EventArgs e)
        {
            if (cboServico.SelectedIndex < 0)
            {
                cboServico.SelectedValue = sv.Idservico;
            }
            MontaCupom();
        }

        private void txtVeiculo_Leave(object sender, EventArgs e)
        {
            MontaCupom();
        }

        private void txtDocFed_Leave(object sender, EventArgs e)
        {
            MontaCupom();
        }

        private void Impressao()
        {
            ImprimeCupom print = new ImprimeCupom(txtCupom);
            print.Print();
        }

        private void btnRemContrato_Click(object sender, EventArgs e)
        {
            contr = null;
            txtIdContrato.Text = null;
            txtNomeContrato.Text = null;
            AtualizaValor();
        }

        private void cboTipoPessoa_Leave(object sender, EventArgs e)
        {
            if (cboTipoPessoa.SelectedIndex < 0)
            {
                cboTipoPessoa.SelectedIndex = 0;
            }
        }

        private void btnBuscaContrato_Click(object sender, EventArgs e)
        {
            BuscaContratos tela = new BuscaContratos(this, null);
            tela.ShowDialog();
        }
    }
}
