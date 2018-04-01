using System;
using System.Windows.Forms;
using RTPark.DAO;
using RTPark.Entidades;
using System.Globalization;

namespace RTPark
{
    public partial class IUContrato : Form
    {
        ContratoDAO oDAO;
        Contratos obj;
        Form lista;
        Boolean salvo = false;

        public IUContrato(int id, Form lista)
        {
            InitializeComponent();
            CarregaClientes();

            oDAO = new ContratoDAO();
            obj = new Contratos();
            this.lista = lista;

            if (id != 0)
            {
                obj = oDAO.GetById(id);

                txtIdContrato.Text = obj.Idcontrato.ToString();
                txtDescricao.Text = obj.Descricao;
                cboCliente.SelectedValue = obj.Idcliente;
                txtDia.Value = obj.Vencimento;

                dtpInicio.Checked = (obj.DtInicio.Equals("")) ? false : true;
                if (dtpInicio.Checked)
                {
                    dtpInicio.Value = Convert.ToDateTime(obj.DtInicio);
                }
                dtpFim.Checked = (obj.DtTermino.Equals("")) ? false : true;
                if (dtpFim.Checked)
                {
                    dtpFim.Value = Convert.ToDateTime(obj.DtTermino);
                }

                CarregaServico(obj.Idservico);

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

        private void IUContrato_Load(object sender, EventArgs e)
        {
            if (!dtpInicio.Checked)
            {
                dtpInicio.Format = DateTimePickerFormat.Custom;
                dtpInicio.CustomFormat = " ";
                dtpInicio.ShowCheckBox = true;
            }
        }

        private void IUContrato_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void IUContrato_KeyDown(object sender, KeyEventArgs e)
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
            txtIdContrato = null;
            txtDescricao.Text = null;
            dtpInicio.Value = DateTime.Now;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (validaCampos())
            {
                DialogResult confirm = MessageBox.Show("Deseja Salvar o Registro?", "RTPark", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (validaCampos() && (confirm == DialogResult.Yes))
                {
                    if (obj == null)
                        obj = new Contratos();

                    obj.Descricao = txtDescricao.Text;
                    obj.Idcliente = Convert.ToInt32(cboCliente.SelectedValue);
                    obj.Idservico = Convert.ToInt32(txtIdServico.Text);
                    obj.Vencimento = (int)txtDia.Value;
                    obj.DtInicio = (dtpInicio.Checked != false) ? dtpInicio.Value.ToString("yyyy-MM-dd") : "";
                    obj.DtTermino = (dtpFim.Checked != false) ? dtpFim.Value.ToString("yyyy-MM-dd") : "";

                    if (validaCampos())
                    {
                        if (obj.Idcontrato == 0)
                            obj.Idcontrato = oDAO.Inserir(obj);
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
                MessageBox.Show("O campo [ Descrição ] obrigatório!");
                return false;
            }

            if (cboCliente.SelectedItem == null)
            {
                MessageBox.Show("O campo [ Tipo ] é inválido!");
                return false;
            }

            if (txtIdServico.TextLength == 0)
            {
                MessageBox.Show("O campo [ Serviço ] obrigatório!");
                return false;
            }

            return true;
        }

        private void IUContrato_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            IUCliente tela = new IUCliente(0, null);
            tela.ShowDialog();
            CarregaClientes();
        }

        private void btnAddServico_Click(object sender, EventArgs e)
        {
            IUServico tela = new IUServico(0, null, this, null);
            tela.ShowDialog();
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
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

        private void CarregaClientes()
        {
            ClienteDAO cDAO = new ClienteDAO();
            cboCliente.DataSource = cDAO.listarTodos();
            cboCliente.DisplayMember = "Nome";
            cboCliente.ValueMember = "ID";
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

        private void btnBuscaServico_Click(object sender, EventArgs e)
        {
            BuscaServico tela = new BuscaServico(this, null);
            tela.ShowDialog();
        }
    }
}
