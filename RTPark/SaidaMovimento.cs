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
    public partial class SaidaMovimento : Form
    {
        Estabelecimentos est;
        ConfigMovimento config;
        Clientes cli;
        VeiculosClientes vc;
        Servicos sv;
        Contratos contr;
        Funcionarios fun;
        Movimentos obj;
        Financeiro fin = new Financeiro();

        TelaPrincipal telaMov;

        MovimentoDAO mDAO = new MovimentoDAO();

        String perm = "", exec = "";
        Decimal vServico = 0, vSubtotal = 0, vExecedente = 0, vDesconto = 0, vTotal = 0, vDinheiro = 0, vTroco = 0;

        public SaidaMovimento(int id, Estabelecimentos est, ConfigMovimento config, Funcionarios fun, Form tela)
        {
            InitializeComponent();
            this.est = est; // Estabelecimento
            this.config = config; // Configuração de Movimento
            this.fun = fun; // Funcionário
            telaMov = (TelaPrincipal)tela; // Tela de Movimento

            CarregaServico();
            CarregaFormaPagamento();

            CarregaFaturaExcedentePadrao();

            //busca um movimento caso venha um ID
            if (id != 0)
            {
                obj = mDAO.GetById(id);

                txtPlaca.ReadOnly = false;

                lblDHEntrada.Text = obj.DhEntrada;
                obj.DhSaida = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                lblDHSaida.Text = obj.DhSaida;
                txtPlaca.Text = obj.Placa;
                txtVeiculo.Text = obj.Veiculo;
                txtVaga.Value = obj.Vaga;

                if (obj.TipoVeiculo == 'C')
                    lblTipoVeiculo.Text = "Carro";
                else if (obj.TipoVeiculo == 'M')
                    lblTipoVeiculo.Text = "Moto";
                else if (obj.TipoVeiculo == 'O')
                    lblTipoVeiculo.Text = "Outro";

                cboServico.SelectedValue = obj.Idservico;

                if (obj.Idcontrato != 0)
                    BuscaContrato(obj.Idcontrato);

                if (obj.DocFed.Length == 14)
                {
                    cboTipoPessoa.SelectedIndex = 0;
                    txtDocFed.Text = obj.DocFed;
                }
                else
                {
                    cboTipoPessoa.SelectedIndex = 1;
                    txtDocFed.Text = obj.DocFed;
                }

                AtualizaValor();

                CalcularPeriodo();
            } //ok
        }

        private void CarregaFaturaExcedentePadrao()//ok
        {
            switch (config.FaturaExcedente)
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
        } //OK

        private void CalcularPeriodo()//OK
        {
            obj.Periodos = 0;
            obj.Excedente = 0;
            exec = "";
            perm = "";
            TimeSpan difDH = DateTime.Parse(obj.DhSaida).Subtract(DateTime.Parse(obj.DhEntrada));
            TimeSpan difD = DateTime.Parse(obj.DhSaida.Substring(0, 10)).Subtract(DateTime.Parse(obj.DhEntrada.Substring(0, 10)));
            int meses = (int)difD.TotalDays / 30;
            int dias = (int)difD.TotalDays % 30;
            int diasC = (int)difD.TotalDays;
            int horas = (int)difDH.TotalHours % 24;
            int horasC = (int)difDH.TotalHours;
            int minutos = (int)difDH.TotalMinutes % 60;
            int minutosC = (int)difDH.TotalMinutes;

            if (meses == 1)
                perm += meses + " mês, ";

            if (meses > 1)
                perm += meses + " meses, ";

            if (dias == 1)
                perm += dias + " dia, ";

            if (dias > 1)
                perm += dias + " dias, ";

            if (meses > 0 || horas > 0)
                perm += horas + " h, ";

            if (horas > 0 || minutos > 0)
                perm += minutos + " min";

            lblPermanencia.Text = perm;
            obj.Permanencia = minutosC;

            if (sv.TipoCobranca == 'M')
            {
                obj.Periodos = 1;
                exec = "";
            }
            else if (sv.TipoCobranca == 'D')
            {
                obj.Periodos = (diasC > 0) ? diasC : 1;
                obj.Periodos = (diasC > 0 && (horas > 0 || minutos > 0)) ? (obj.Periodos + 1) : obj.Periodos;
                exec = "";
            }
            else if (sv.TipoCobranca == 'H')
            {
                obj.Periodos = horasC / sv.Quantidade;
                exec = minutos + " min";
                obj.Excedente = minutos;
            }
            else if (sv.TipoCobranca == 'I')
            {
                obj.Periodos = minutosC / sv.Quantidade;
                exec = (minutosC % sv.Quantidade) + " min";
                obj.Excedente = (minutosC % sv.Quantidade);
            }

            lblExcedente.Text = exec;
            lblPeriodo.Text = obj.Periodos.ToString();
            CalcularPagamento(true);
        }

        private void CalcularPagamento(bool leave)//ok
        {
            if (obj.TipoVeiculo == 'C')
            {
                vSubtotal = obj.Periodos * sv.ValorCarro;
                txtSubTotal.Text = vSubtotal.ToString("0,0.00");
                vServico = sv.ValorCarro;
            }
            else if (obj.TipoVeiculo == 'M')
            {
                vSubtotal = obj.Periodos * sv.ValorMoto;
                txtSubTotal.Text = vSubtotal.ToString();
                vServico = sv.ValorMoto;
            }
            else if (obj.TipoVeiculo == 'O')
            {
                vSubtotal = obj.Periodos * sv.ValorOutros;
                txtSubTotal.Text = vSubtotal.ToString();
                vServico = sv.ValorOutros;
            }

            if (rbInteiro.Checked)
            {
                vExecedente = vServico;
                txtExcedente.Text = vExecedente.ToString();
            }
            else if (rbProporcional.Checked)
            {
                if (sv.TipoCobranca != 'H')
                {
                    vExecedente = (vServico * obj.Excedente) / sv.Quantidade;
                }
                else
                {
                    vExecedente = (vServico * obj.Excedente) / (sv.Quantidade * 60);
                }
                txtExcedente.Text = vExecedente.ToString("N2");
            }
            else if (rbManual.Checked)
            {
                vExecedente = Convert.ToDecimal(txtExcedente.Text);
            }
            else if (rbZero.Checked)
            {
                vExecedente = 0;
                txtExcedente.Text = "0";
            }

            vDesconto = Convert.ToDecimal(txtDesconto.Text);

            vTotal = (vSubtotal + vExecedente) - vDesconto;

            txtTotalPagar.Text = vTotal.ToString("N2");
            if (leave)
                txtDinheiro.Focus();
        }

        private void CalculaTroco()//ok
        {
            vDinheiro = Convert.ToDecimal(txtDinheiro.Text);
            if (vDinheiro > 0)
            {
                vTroco = vDinheiro - vTotal;
            }
            else
            {
                vTroco = 0;
            }

            txtTroco.Text = vTroco.ToString("N2");
        }

        private void txtPlaca_Leave(object sender, EventArgs e)
        {
            /*
            txtPlaca.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            if (txtPlaca.Text.Length == 7)
            {
                txtPlaca.TextMaskFormat = MaskFormat.IncludeLiterals;
                BuscaPlaca();
                btnSalvar.Enabled = true;
            }
            else if (txtPlaca.Text.Length < 7 && txtPlaca.Text.Length > 0)
            {
                MessageBox.Show("O campo [ PLACA ] está inválido!");
                txtPlaca.Focus();
                btnSalvar.Enabled = false;
            }
            txtPlaca.TextMaskFormat = MaskFormat.IncludeLiterals;
            */
        }

        private void cboTipoPessoa_SelectedIndexChanged(object sender, EventArgs e) // OK
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MontaCupom();

            obj.Placa = txtPlaca.Text;
            // obj.TipoVeiculo = gbTipoVeiculo.Controls.OfType<RadioButton>().SingleOrDefault(rad => rad.Checked == true).Text[0];
            obj.Veiculo = txtVeiculo.Text;
            obj.Vaga = (int)txtVaga.Value;
            obj.Idservico = Convert.ToInt32(cboServico.SelectedValue);
            obj.Idfuncionario = fun.Idfuncionario;
            obj.Idcontrato = (contr != null) ? contr.Idcontrato : 0;
            obj.DocFed = txtDocFed.Text;

            obj.Idmovimento = mDAO.Inserir(obj);

            MontaCupom();

            if (config.ImprimeSaida == 'P')
            {
                DialogResult dr = MessageBox.Show("Deseja Imprimir o Cupom de Entreda ?", "RTPark", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    Impressao();
                }
            }
            else if (config.ImprimeSaida == 'S')
            {
                Impressao();
            }

            telaMov.CarregaGrid();
            this.Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)//ok
        {
            telaMov.CarregaGrid();
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
                        lblTipoVeiculo.Text = "CARRO";
                        break;

                    case 'M':
                        lblTipoVeiculo.Text = "MOTO";
                        break;

                    case 'O':
                        lblTipoVeiculo.Text = "OUTROS";
                        break;
                }
                BuscaCLiente();
            }
            else
            {
                txtVeiculo.Text = null;
                lblTipoVeiculo.Text = "CARRO";

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

        public void BuscaContrato(int idContrato)//ok
        {
            ContratoDAO cDAO = new ContratoDAO();
            contr = cDAO.GetById(idContrato);

            if (contr != null)
            {
                txtIdContrato.Text = contr.Idcontrato.ToString();
                txtNomeContrato.Text = contr.Descricao;

                cboServico.SelectedValue = contr.Idservico;

                AtualizaValor();
            }
        }

        private void CarregaServico()
        {
            ServicoDAO sDAO = new ServicoDAO();
            cboServico.DataSource = sDAO.BuscaPorCampo("ativo", "1");
            cboServico.ValueMember = "ID";
            cboServico.DisplayMember = "Descrição";
        } //OK

        private void CarregaFormaPagamento()
        {
            FormaPagamentoDAO fDAO = new FormaPagamentoDAO();
            cboFormaPagamento.DataSource = fDAO.BuscaPorCampo("ativo", "1");
            cboFormaPagamento.ValueMember = "ID";
            cboFormaPagamento.DisplayMember = "Descrição";
        } //OK

        private void AtualizaValor()//ok
        {
            ServicoDAO sDAO = new ServicoDAO();

            sv = sDAO.GetById(Convert.ToInt32(cboServico.SelectedValue));
            if (sv != null)
            {
                obj.Idservico = sv.Idservico;
                if (obj.TipoVeiculo == 'C')
                    txtValor.Text = sv.ValorCarro.ToString();

                if (obj.TipoVeiculo == 'M')
                    txtValor.Text = sv.ValorMoto.ToString();

                if (obj.TipoVeiculo == 'O')
                    txtValor.Text = sv.ValorOutros.ToString();
            }
            MontaCupom();
        }

        private void cboServico_SelectedIndexChanged(object sender, EventArgs e)//OK
        {
            try
            {
                AtualizaValor();
                CalcularPeriodo();
            }
            catch (Exception)
            {

            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            FormataMoeda(ref txtValor);
        } //OK

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

        }//OK

        private void txtVaga_Leave(object sender, EventArgs e)
        {
            MontaCupom();
        } //OK

        private void cboServico_Leave(object sender, EventArgs e)
        {
            if (cboServico.SelectedIndex < 0)
            {
                cboServico.SelectedValue = sv.Idservico;

            }
            AtualizaValor();
            MontaCupom();
        } //OK

        private void txtVeiculo_Leave(object sender, EventArgs e)
        {
            MontaCupom();
        } //OK

        private void txtDocFed_Leave(object sender, EventArgs e)
        {
            MontaCupom();
        } //ok

        private void btnRemContrato_Click(object sender, EventArgs e) //OK
        {
            contr = null;
            txtIdContrato.Text = null;
            txtNomeContrato.Text = null;
            AtualizaValor();
        }

        private void txtExcedente_TextChanged(object sender, EventArgs e)//ok
        {
            FormataMoeda(ref txtExcedente);
            CalcularPagamento(false);
            CalculaTroco();
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)//ok
        {
            FormataMoeda(ref txtDesconto);
            CalcularPagamento(false);
            CalculaTroco();
        }

        private void txtDinheiro_TextChanged(object sender, EventArgs e)//ok
        {
            FormataMoeda(ref txtDinheiro);
            CalculaTroco();
        }

        private void cboTipoPessoa_Leave(object sender, EventArgs e)//OK
        {
            if (cboTipoPessoa.SelectedIndex < 0)
            {
                cboTipoPessoa.SelectedIndex = 0;
            }
        }

        private void btnBuscaContrato_Click(object sender, EventArgs e)//OK
        {
            BuscaContratos tela = new BuscaContratos(null, this);
            tela.ShowDialog();
        }

        private void txtExcedente_Leave(object sender, EventArgs e)
        {
            CalcularPagamento(true);
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

            cupom.Add("ENTRADA.: " + lblDHEntrada.Text);
            cupom.Add("SAIDA...: " + lblDHSaida.Text);

            cupom.Add("-----------------------------------------");
            cupom.Add(" ");
            cupom.Add(" ");
            cupom.Add(" ");

            // txtCupom.Lines = (String[])cupom.ToArray(typeof(string));
        }

        private void rbInteiro_CheckedChanged(object sender, EventArgs e)
        {
            CalcularPagamento(true);
        }

        private void rbProporcional_CheckedChanged(object sender, EventArgs e)
        {
            CalcularPagamento(true);
        }

        private void rbZero_CheckedChanged(object sender, EventArgs e)
        {
            CalcularPagamento(true);
        }

        private void rbManual_CheckedChanged(object sender, EventArgs e)
        {
            CalcularPagamento(false);
            txtExcedente.Focus();
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            CalcularPagamento(true);
        }

        private void Impressao()
        {
            // ImprimeCupom print = new ImprimeCupom(txtCupom);
            //print.Print();
        }
    }
}
