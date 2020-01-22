using System;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using RTPark.Entidades;
using System.Linq;
using RTPark.DAO;
using RTPark.Util;
using System.Drawing;

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
        Financeiro fin;

        TelaPrincipal telaMov;

        MovimentoDAO mDAO = new MovimentoDAO();

        String perm = "", exec = "";
        Decimal vServico = 0, vSubtotal = 0, vExecedente = 0, vDesconto = 0, vTotal = 0, vDinheiro = 0, vTroco = 0;

        public SaidaMovimento(int id, Estabelecimentos est, ConfigMovimento config, Funcionarios fun, Form tela)
        {
            InitializeComponent();

            groupBox4.TabStop = false;
            rbInteiro.TabStop = false;
            rbManual.TabStop = false;
            rbProporcional.TabStop = false;
            rbZero.TabStop = false;

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

                PreencheMovimento();
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

        private void txtPlaca_Leave(object sender, EventArgs e)
        {
            txtPlaca.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtPlaca.Text = txtPlaca.Text.Trim().Replace(" ", "");
            if (txtPlaca.Text.Length < 7 && txtPlaca.Text.Length >= 0)
            {
                txtPlaca.Focus();
                btnSalvar.Enabled = false;
                txtPlaca.Clear();
            }
            else if (txtPlaca.Text.Length == 7)
            {
                txtPlaca.TextMaskFormat = MaskFormat.IncludeLiterals;
                obj = mDAO.GetByCampo("placa = '", txtPlaca.Text + "' ", 'S');
                if (obj != null)
                {
                    btnSalvar.Enabled = true;
                    PreencheMovimento();
                }
                else
                {
                    MessageBox.Show("PLACA INVÁLIDA! \n" +
                        "Veiculo não estacionado.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPlaca.Focus();
                    btnSalvar.Enabled = false;
                    txtPlaca.Clear();
                }
            }
            else
            {
                MessageBox.Show("O campo [ PLACA ] está inválido!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPlaca.Focus();
                btnSalvar.Enabled = false;
            }
            txtPlaca.TextMaskFormat = MaskFormat.IncludeLiterals;
        }

        public void PreencheMovimento()
        {
            btnSalvar.Enabled = true;
            txtPlaca.TabStop = false;
            txtPlaca.ReadOnly = true;
            txtPlaca.BackColor = Color.White;
            txtPlaca.ForeColor = Color.Blue;

            lblDHEntrada.Text = obj.DhEntrada;
            obj.DhSaida = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            lblDHSaida.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            txtPlaca.Text = obj.Placa;
            txtVeiculo.Text = obj.Veiculo;
            txtVaga.Value = obj.Vaga;

            if (obj.TipoVeiculo == 'C')
                lblTipoVeiculo.Text = "CARRO";
            else if (obj.TipoVeiculo == 'M')
                lblTipoVeiculo.Text = "MOTO";
            else if (obj.TipoVeiculo == 'O')
                lblTipoVeiculo.Text = "OUTROS";

            cboServico.SelectedValue = obj.Idservico;

            if (obj.Idcontrato != 0)
                BuscaContrato(obj.Idcontrato);

            if (obj.DocFed.Length == 14 || obj.DocFed.Length < 14)
            {
                cboTipoPessoa.SelectedIndex = 0;
                txtDocFed.Text = obj.DocFed;
            }
            else if (obj.DocFed.Length == 18)
            {
                cboTipoPessoa.SelectedIndex = 1;
                txtDocFed.Text = obj.DocFed;
            }

            MontaCupom();

            BuscaCLiente();

            if (obj.Idcontrato > 0)
            {
                BuscaContrato(obj.Idcontrato);
            }

            AtualizaValor();

            CalcularPeriodo();
        }

        private void CalcularPeriodo()//OK/;
        {
            fin = new Financeiro();
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
            CalcularPagamento();
        }

        private void CalcularPagamento()//ok
        {
            if (obj != null)
            {
                if (sv.TipoCobranca == 'M')
                {
                    vSubtotal = 0;
                    txtSubTotal.Text = "0,00";
                    txtSubTotal.Enabled = false;

                    vExecedente = 0;
                    txtExcedente.Text = "0,00";
                    txtExcedente.Enabled = false;

                    vDesconto = 0;
                    txtDesconto.Text = "0,00";
                    txtDesconto.Enabled = false;

                    vTotal = 0;
                    txtTotalPagar.Text = "0,00";
                    txtTotalPagar.Enabled = false;

                    vDinheiro = 0;
                    txtDinheiro.Text = "0,00";
                    txtDinheiro.Enabled = false;

                    vTroco = 0;
                    txtTroco.Text = "0,00";
                    txtTroco.Enabled = false;

                    rbInteiro.Enabled = false;
                    rbProporcional.Enabled = false;
                    rbZero.Enabled = false;
                    rbManual.Enabled = false;
                }
                else
                {
                    txtSubTotal.Enabled = true;
                    txtExcedente.Enabled = true;
                    txtDesconto.Enabled = true;
                    txtTotalPagar.Enabled = true;
                    txtDinheiro.Enabled = true;
                    txtTroco.Enabled = true;

                    rbInteiro.Enabled = true;
                    rbProporcional.Enabled = true;
                    rbZero.Enabled = true;
                    rbManual.Enabled = true;

                    if (obj.TipoVeiculo == 'C')
                    {
                        vSubtotal = obj.Periodos * sv.ValorCarro;
                        txtSubTotal.Text = vSubtotal.ToString("N2");
                        vServico = sv.ValorCarro;
                    }
                    else if (obj.TipoVeiculo == 'M')
                    {
                        vSubtotal = obj.Periodos * sv.ValorMoto;
                        txtSubTotal.Text = vSubtotal.ToString("N2");
                        vServico = sv.ValorMoto;
                    }
                    else if (obj.TipoVeiculo == 'O')
                    {
                        vSubtotal = obj.Periodos * sv.ValorOutros;
                        txtSubTotal.Text = vSubtotal.ToString("N2");
                        vServico = sv.ValorOutros;
                    }

                    if (rbInteiro.Checked)
                    {
                        fin.FatExcedente = 'I';
                        vExecedente = vServico;
                        txtExcedente.Text = vExecedente.ToString("N2");
                        txtDesconto.Text = "0,00";
                    }
                    else if (rbProporcional.Checked)
                    {
                        fin.FatExcedente = 'P';
                        if (sv.TipoCobranca != 'H')
                        {
                            vExecedente = (vServico * obj.Excedente) / sv.Quantidade;
                        }
                        else
                        {
                            vExecedente = (vServico * obj.Excedente) / (sv.Quantidade * 60);
                        }
                        txtExcedente.Text = vExecedente.ToString("N2");
                        txtDesconto.Text = "0,00";
                    }
                    else if (rbManual.Checked)
                    {
                        fin.FatExcedente = 'M';
                        vExecedente = Convert.ToDecimal(txtExcedente.Text);
                        txtDesconto.Text = "0,00";
                    }
                    else if (rbZero.Checked)
                    {
                        fin.FatExcedente = 'Z';
                        vDesconto = (vSubtotal + vExecedente);
                        txtDesconto.Text = vDesconto.ToString("N2");

                        txtDinheiro.Text = "0,00";
                        vDinheiro = 0;
                    }

                    vTotal = (vSubtotal + vExecedente) - vDesconto;
                    vDesconto = Convert.ToDecimal(txtDesconto.Text);

                    txtTotalPagar.Text = vTotal.ToString("N2");
                }
            }
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

            if (vDinheiro < vTotal)
            {
                vDinheiro = vTotal;
                txtDinheiro.Text = vDinheiro.ToString("N2");
            }

            obj.Veiculo = txtVeiculo.Text;
            obj.Vaga = (int)txtVaga.Value;
            obj.Idservico = Convert.ToInt32(cboServico.SelectedValue);
            obj.Idfuncionario = fun.Idfuncionario;
            obj.Idcontrato = (contr != null) ? contr.Idcontrato : 0;
            obj.DocFed = txtDocFed.Text;

            mDAO.Alterar(obj);

            fin.IdEstabelecimento = est.Idestabelecimento;
            fin.IdFuncionario = fun.Idfuncionario;
            fin.IdMovimento = obj.Idmovimento;
            fin.DhLancamento = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            fin.TipoLancamento = 'M';
            fin.IdFormaPagamento = Convert.ToInt32(cboFormaPagamento.SelectedValue);

            fin.Subtotal = vSubtotal;
            fin.Excedente = vExecedente;
            fin.Desconto = vDesconto;
            fin.Total = vTotal;
            fin.Dinheiro = vDinheiro;
            fin.Troco = vTroco;

            FinanceiroDAO fDAO = new FinanceiroDAO();
            fDAO.InserirMovimento(fin);

            if (config.ImprimeSaida == 'P')
            {
                DialogResult dr = MessageBox.Show("Deseja Imprimir o Cupom de Saída ?", "RTPark", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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



        private void BuscaCLiente()
        {
            vc = new VeiculosClienteDAO().GetByPlaca(txtPlaca.Text);
            if (vc != null)
            {
                cli = new ClienteDAO().GetById(vc.Idcliente);
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

            cboServico.SelectedValue = config.CobrancaPadrao;

            AtualizaValor();
        }

        private void txtExcedente_TextChanged(object sender, EventArgs e)//ok
        {
            FormataMoeda(ref txtExcedente);
            CalcularPagamento();
            CalculaTroco();
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)//ok
        {
            FormataMoeda(ref txtDesconto);
            CalcularPagamento();
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
            CalcularPagamento();
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
            cupom.Add("  ******* COMPROVANTE DE SAIDA *******   ");
            cupom.Add("-----------------------------------------");

            cupom.Add("DOC.....: " + (obj != null ? obj.Idmovimento : 0));
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

            cupom.Add(" ");
            cupom.Add("ENTRADA....: " + lblDHEntrada.Text);
            cupom.Add("SAIDA......: " + lblDHSaida.Text);
            cupom.Add("Permanência: " + lblPermanencia.Text);
            cupom.Add("Periodos...: " + lblPeriodo.Text);
            cupom.Add("Excedente..: " + lblExcedente.Text);

            if (fin != null && sv.TipoCobranca != 'M')
            {
                cupom.Add(" ");
                cupom.Add("Sub-Total..: R$ " + txtSubTotal.Text.PadLeft(8, ' '));
                cupom.Add("Excedente..: R$ " + txtExcedente.Text.PadLeft(8, ' '));
                cupom.Add("Desconto...: R$ " + txtDesconto.Text.PadLeft(8, ' '));
                cupom.Add("Total......: R$ " + txtTotalPagar.Text.PadLeft(8, ' '));
                cupom.Add("Dinheiro...: R$ " + txtDinheiro.Text.PadLeft(8, ' '));
                cupom.Add("Troco......: R$ " + txtTroco.Text.PadLeft(8, ' '));
            }
            else
            {
                cupom.Add(" ");
                cupom.Add("   ******* PAGAMENTO MENSAL *******   ");
            }

            cupom.Add("");

            cupom.Add("-----------------------------------------");
            cupom.Add(" ");
            cupom.Add(" ");
            cupom.Add(" ");

            txtCupom.Lines = (String[])cupom.ToArray(typeof(string));
        }

        private void SaidaMovimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtDinheiro_Leave(object sender, EventArgs e)
        {

            if (vDinheiro == 0)
            {
                vDinheiro = vTotal;
                txtDinheiro.Text = vDinheiro.ToString("N2");
            }

            if (vDinheiro < vTotal)
            {
                MessageBox.Show("Valor do DINHEIRO menor que TOTAL!", "RTPark", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDinheiro.Focus();
            }

        }

        private void rbInteiro_CheckedChanged(object sender, EventArgs e)
        {
            CalcularPagamento();
        }

        private void rbProporcional_CheckedChanged(object sender, EventArgs e)
        {
            CalcularPagamento();
        }

        private void rbZero_CheckedChanged(object sender, EventArgs e)
        {
            CalcularPagamento();
        }

        private void rbManual_CheckedChanged(object sender, EventArgs e)
        {
            CalcularPagamento();
        }

        private void txtDesconto_Leave(object sender, EventArgs e)
        {
            CalcularPagamento();
        }

        private void Impressao()
        {
            ImprimeCupom print = new ImprimeCupom(txtCupom);
            print.Print();
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

        }//OK
    }
}
