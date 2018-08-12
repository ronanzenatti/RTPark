namespace RTPark
{
    partial class SaidaMovimento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemContrato = new FontAwesome.Sharp.IconButton();
            this.btnBuscaContrato = new FontAwesome.Sharp.IconButton();
            this.txtNomeContrato = new System.Windows.Forms.TextBox();
            this.txtIdContrato = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblExcedente = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPermanencia = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDHSaida = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDHEntrada = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cboServico = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTipoVeiculo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVaga = new System.Windows.Forms.NumericUpDown();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.gbFinanceiro = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtExcedente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboFormaPagamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.rbZero = new System.Windows.Forms.RadioButton();
            this.rbProporcional = new System.Windows.Forms.RadioButton();
            this.rbInteiro = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtDocFed = new System.Windows.Forms.MaskedTextBox();
            this.cboTipoPessoa = new System.Windows.Forms.ComboBox();
            this.txtSubTotal = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.Label();
            this.txtTroco = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVaga)).BeginInit();
            this.gbFinanceiro.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Controls.Add(this.txtPlaca);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 85);
            this.panel1.TabIndex = 0;
            // 
            // lblCliente
            // 
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(267, 12);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(505, 62);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtPlaca.Location = new System.Drawing.Point(12, 12);
            this.txtPlaca.Mask = ">?>?>?-9999";
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(249, 63);
            this.txtPlaca.TabIndex = 1;
            this.txtPlaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPlaca.Leave += new System.EventHandler(this.txtPlaca_Leave);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Controls.Add(this.btnVoltar);
            this.panel2.Location = new System.Drawing.Point(0, 499);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 62);
            this.panel2.TabIndex = 50;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Location = new System.Drawing.Point(643, 11);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(129, 39);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(12, 11);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(129, 39);
            this.btnVoltar.TabIndex = 41;
            this.btnVoltar.Text = "&Cancelar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemContrato);
            this.groupBox1.Controls.Add(this.btnBuscaContrato);
            this.groupBox1.Controls.Add(this.txtNomeContrato);
            this.groupBox1.Controls.Add(this.txtIdContrato);
            this.groupBox1.Location = new System.Drawing.Point(13, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 59);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contrato:";
            // 
            // btnRemContrato
            // 
            this.btnRemContrato.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemContrato.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnRemContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemContrato.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRemContrato.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnRemContrato.IconColor = System.Drawing.Color.Coral;
            this.btnRemContrato.IconSize = 25;
            this.btnRemContrato.Location = new System.Drawing.Point(367, 23);
            this.btnRemContrato.Name = "btnRemContrato";
            this.btnRemContrato.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnRemContrato.Rotation = 0D;
            this.btnRemContrato.Size = new System.Drawing.Size(28, 26);
            this.btnRemContrato.TabIndex = 48;
            this.btnRemContrato.TabStop = false;
            this.btnRemContrato.UseVisualStyleBackColor = false;
            this.btnRemContrato.Click += new System.EventHandler(this.btnRemContrato_Click);
            // 
            // btnBuscaContrato
            // 
            this.btnBuscaContrato.BackColor = System.Drawing.SystemColors.Control;
            this.btnBuscaContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaContrato.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBuscaContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaContrato.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscaContrato.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscaContrato.IconColor = System.Drawing.Color.LightSkyBlue;
            this.btnBuscaContrato.IconSize = 25;
            this.btnBuscaContrato.Location = new System.Drawing.Point(6, 23);
            this.btnBuscaContrato.Name = "btnBuscaContrato";
            this.btnBuscaContrato.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnBuscaContrato.Rotation = 0D;
            this.btnBuscaContrato.Size = new System.Drawing.Size(28, 26);
            this.btnBuscaContrato.TabIndex = 3;
            this.btnBuscaContrato.UseVisualStyleBackColor = false;
            this.btnBuscaContrato.Click += new System.EventHandler(this.btnBuscaContrato_Click);
            // 
            // txtNomeContrato
            // 
            this.txtNomeContrato.BackColor = System.Drawing.Color.White;
            this.txtNomeContrato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeContrato.Location = new System.Drawing.Point(104, 23);
            this.txtNomeContrato.Name = "txtNomeContrato";
            this.txtNomeContrato.ReadOnly = true;
            this.txtNomeContrato.Size = new System.Drawing.Size(257, 26);
            this.txtNomeContrato.TabIndex = 46;
            this.txtNomeContrato.TabStop = false;
            // 
            // txtIdContrato
            // 
            this.txtIdContrato.BackColor = System.Drawing.Color.White;
            this.txtIdContrato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdContrato.Location = new System.Drawing.Point(40, 23);
            this.txtIdContrato.Name = "txtIdContrato";
            this.txtIdContrato.ReadOnly = true;
            this.txtIdContrato.Size = new System.Drawing.Size(58, 26);
            this.txtIdContrato.TabIndex = 45;
            this.txtIdContrato.TabStop = false;
            this.txtIdContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPeriodo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblExcedente);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblPermanencia);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblDHSaida);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblDHEntrada);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(13, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 134);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados da Permanência:";
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.BackColor = System.Drawing.SystemColors.Window;
            this.lblPeriodo.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPeriodo.Location = new System.Drawing.Point(295, 96);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(95, 30);
            this.lblPeriodo.TabIndex = 56;
            this.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label10.Location = new System.Drawing.Point(294, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 55;
            this.label10.Text = "Periodos:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExcedente
            // 
            this.lblExcedente.BackColor = System.Drawing.SystemColors.Window;
            this.lblExcedente.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExcedente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblExcedente.Location = new System.Drawing.Point(295, 43);
            this.lblExcedente.Name = "lblExcedente";
            this.lblExcedente.Size = new System.Drawing.Size(95, 30);
            this.lblExcedente.TabIndex = 54;
            this.lblExcedente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(294, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 53;
            this.label8.Text = "Excedente:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPermanencia
            // 
            this.lblPermanencia.BackColor = System.Drawing.SystemColors.Window;
            this.lblPermanencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermanencia.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPermanencia.Location = new System.Drawing.Point(130, 96);
            this.lblPermanencia.Name = "lblPermanencia";
            this.lblPermanencia.Size = new System.Drawing.Size(154, 30);
            this.lblPermanencia.TabIndex = 52;
            this.lblPermanencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(6, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Permanência:";
            // 
            // lblDHSaida
            // 
            this.lblDHSaida.BackColor = System.Drawing.SystemColors.Window;
            this.lblDHSaida.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDHSaida.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDHSaida.Location = new System.Drawing.Point(130, 57);
            this.lblDHSaida.Name = "lblDHSaida";
            this.lblDHSaida.Size = new System.Drawing.Size(154, 30);
            this.lblDHSaida.TabIndex = 50;
            this.lblDHSaida.Text = "00/00/0000 00:00";
            this.lblDHSaida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(6, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Saida:";
            // 
            // lblDHEntrada
            // 
            this.lblDHEntrada.BackColor = System.Drawing.SystemColors.Window;
            this.lblDHEntrada.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDHEntrada.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDHEntrada.Location = new System.Drawing.Point(130, 22);
            this.lblDHEntrada.Name = "lblDHEntrada";
            this.lblDHEntrada.Size = new System.Drawing.Size(154, 30);
            this.lblDHEntrada.TabIndex = 48;
            this.lblDHEntrada.Text = "00/00/0000 00:00";
            this.lblDHEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Entrada:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtValor);
            this.groupBox3.Controls.Add(this.cboServico);
            this.groupBox3.Location = new System.Drawing.Point(13, 286);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(401, 59);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Serviço:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(290, 24);
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            this.txtValor.Size = new System.Drawing.Size(105, 26);
            this.txtValor.TabIndex = 6;
            this.txtValor.TabStop = false;
            this.txtValor.Text = "0,00";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // cboServico
            // 
            this.cboServico.FormattingEnabled = true;
            this.cboServico.ItemHeight = 20;
            this.cboServico.Location = new System.Drawing.Point(9, 24);
            this.cboServico.Name = "cboServico";
            this.cboServico.Size = new System.Drawing.Size(275, 28);
            this.cboServico.TabIndex = 0;
            this.cboServico.SelectedIndexChanged += new System.EventHandler(this.cboServico_SelectedIndexChanged);
            this.cboServico.Leave += new System.EventHandler(this.cboServico_Leave);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.lblTipoVeiculo);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.txtVaga);
            this.groupBox6.Controls.Add(this.txtVeiculo);
            this.groupBox6.Location = new System.Drawing.Point(13, 346);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(401, 90);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Veiculo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(258, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 13;
            this.label11.Text = "Vaga:";
            // 
            // lblTipoVeiculo
            // 
            this.lblTipoVeiculo.BackColor = System.Drawing.SystemColors.Window;
            this.lblTipoVeiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTipoVeiculo.Location = new System.Drawing.Point(149, 58);
            this.lblTipoVeiculo.Name = "lblTipoVeiculo";
            this.lblTipoVeiculo.Size = new System.Drawing.Size(76, 25);
            this.lblTipoVeiculo.TabIndex = 12;
            this.lblTipoVeiculo.Text = "Carro";
            this.lblTipoVeiculo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tipo de Veiculo:";
            // 
            // txtVaga
            // 
            this.txtVaga.Location = new System.Drawing.Point(320, 57);
            this.txtVaga.Name = "txtVaga";
            this.txtVaga.Size = new System.Drawing.Size(75, 26);
            this.txtVaga.TabIndex = 10;
            this.txtVaga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.BackColor = System.Drawing.Color.White;
            this.txtVeiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVeiculo.Location = new System.Drawing.Point(6, 25);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(389, 26);
            this.txtVeiculo.TabIndex = 1;
            this.txtVeiculo.Leave += new System.EventHandler(this.txtVeiculo_Leave);
            // 
            // gbFinanceiro
            // 
            this.gbFinanceiro.Controls.Add(this.txtTroco);
            this.gbFinanceiro.Controls.Add(this.txtTotalPagar);
            this.gbFinanceiro.Controls.Add(this.txtSubTotal);
            this.gbFinanceiro.Controls.Add(this.label14);
            this.gbFinanceiro.Controls.Add(this.txtDinheiro);
            this.gbFinanceiro.Controls.Add(this.label13);
            this.gbFinanceiro.Controls.Add(this.label12);
            this.gbFinanceiro.Controls.Add(this.txtDesconto);
            this.gbFinanceiro.Controls.Add(this.label9);
            this.gbFinanceiro.Controls.Add(this.txtExcedente);
            this.gbFinanceiro.Controls.Add(this.label7);
            this.gbFinanceiro.Controls.Add(this.label5);
            this.gbFinanceiro.Controls.Add(this.cboFormaPagamento);
            this.gbFinanceiro.Controls.Add(this.label3);
            this.gbFinanceiro.Controls.Add(this.groupBox4);
            this.gbFinanceiro.ForeColor = System.Drawing.Color.Green;
            this.gbFinanceiro.Location = new System.Drawing.Point(420, 91);
            this.gbFinanceiro.Name = "gbFinanceiro";
            this.gbFinanceiro.Size = new System.Drawing.Size(353, 404);
            this.gbFinanceiro.TabIndex = 52;
            this.gbFinanceiro.TabStop = false;
            this.gbFinanceiro.Text = "Financeiro:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label14.Location = new System.Drawing.Point(10, 367);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 20);
            this.label14.TabIndex = 18;
            this.label14.Text = "Troco:";
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDinheiro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDinheiro.Location = new System.Drawing.Point(207, 327);
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(140, 32);
            this.txtDinheiro.TabIndex = 17;
            this.txtDinheiro.Text = "0,00";
            this.txtDinheiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDinheiro.TextChanged += new System.EventHandler(this.txtDinheiro_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label13.Location = new System.Drawing.Point(10, 333);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "Dinheiro:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(9, 291);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 25);
            this.label12.TabIndex = 14;
            this.label12.Text = "A PAGAR:";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.ForeColor = System.Drawing.Color.Green;
            this.txtDesconto.Location = new System.Drawing.Point(207, 235);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(140, 25);
            this.txtDesconto.TabIndex = 13;
            this.txtDesconto.Text = "0,00";
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesconto.TextChanged += new System.EventHandler(this.txtDesconto_TextChanged);
            this.txtDesconto.Leave += new System.EventHandler(this.txtDesconto_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label9.Location = new System.Drawing.Point(10, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Desconto ( - ):";
            // 
            // txtExcedente
            // 
            this.txtExcedente.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExcedente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtExcedente.Location = new System.Drawing.Point(207, 201);
            this.txtExcedente.Name = "txtExcedente";
            this.txtExcedente.Size = new System.Drawing.Size(140, 25);
            this.txtExcedente.TabIndex = 11;
            this.txtExcedente.Text = "0,00";
            this.txtExcedente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtExcedente.TextChanged += new System.EventHandler(this.txtExcedente_TextChanged);
            this.txtExcedente.Leave += new System.EventHandler(this.txtExcedente_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(9, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Excedente ( + ):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(8, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sub-Total:";
            // 
            // cboFormaPagamento
            // 
            this.cboFormaPagamento.FormattingEnabled = true;
            this.cboFormaPagamento.Location = new System.Drawing.Point(12, 106);
            this.cboFormaPagamento.Name = "cboFormaPagamento";
            this.cboFormaPagamento.Size = new System.Drawing.Size(335, 28);
            this.cboFormaPagamento.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(8, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Forma de Pagamento:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbManual);
            this.groupBox4.Controls.Add(this.rbZero);
            this.groupBox4.Controls.Add(this.rbProporcional);
            this.groupBox4.Controls.Add(this.rbInteiro);
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(6, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(341, 54);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fatura do Excedente:";
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbManual.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rbManual.Location = new System.Drawing.Point(259, 23);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(76, 20);
            this.rbManual.TabIndex = 3;
            this.rbManual.Text = "Manual";
            this.rbManual.UseVisualStyleBackColor = true;
            this.rbManual.CheckedChanged += new System.EventHandler(this.rbManual_CheckedChanged);
            // 
            // rbZero
            // 
            this.rbZero.AutoSize = true;
            this.rbZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbZero.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rbZero.Location = new System.Drawing.Point(202, 23);
            this.rbZero.Name = "rbZero";
            this.rbZero.Size = new System.Drawing.Size(58, 20);
            this.rbZero.TabIndex = 2;
            this.rbZero.Text = "Zero";
            this.rbZero.UseVisualStyleBackColor = true;
            this.rbZero.CheckedChanged += new System.EventHandler(this.rbZero_CheckedChanged);
            // 
            // rbProporcional
            // 
            this.rbProporcional.AutoSize = true;
            this.rbProporcional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProporcional.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rbProporcional.Location = new System.Drawing.Point(81, 23);
            this.rbProporcional.Name = "rbProporcional";
            this.rbProporcional.Size = new System.Drawing.Size(115, 20);
            this.rbProporcional.TabIndex = 1;
            this.rbProporcional.Text = "Proporcional";
            this.rbProporcional.UseVisualStyleBackColor = true;
            this.rbProporcional.CheckedChanged += new System.EventHandler(this.rbProporcional_CheckedChanged);
            // 
            // rbInteiro
            // 
            this.rbInteiro.AutoSize = true;
            this.rbInteiro.Checked = true;
            this.rbInteiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInteiro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rbInteiro.Location = new System.Drawing.Point(6, 23);
            this.rbInteiro.Name = "rbInteiro";
            this.rbInteiro.Size = new System.Drawing.Size(69, 20);
            this.rbInteiro.TabIndex = 0;
            this.rbInteiro.TabStop = true;
            this.rbInteiro.Text = "Inteiro";
            this.rbInteiro.UseVisualStyleBackColor = true;
            this.rbInteiro.CheckedChanged += new System.EventHandler(this.rbInteiro_CheckedChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtDocFed);
            this.groupBox7.Controls.Add(this.cboTipoPessoa);
            this.groupBox7.Location = new System.Drawing.Point(12, 436);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(402, 59);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "CPF / CNPJ do Cliente:";
            // 
            // txtDocFed
            // 
            this.txtDocFed.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocFed.Location = new System.Drawing.Point(150, 24);
            this.txtDocFed.Mask = "999,999,999-99";
            this.txtDocFed.Name = "txtDocFed";
            this.txtDocFed.Size = new System.Drawing.Size(241, 26);
            this.txtDocFed.TabIndex = 16;
            this.txtDocFed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboTipoPessoa
            // 
            this.cboTipoPessoa.FormattingEnabled = true;
            this.cboTipoPessoa.ItemHeight = 20;
            this.cboTipoPessoa.Items.AddRange(new object[] {
            "Física",
            "Júridica"});
            this.cboTipoPessoa.Location = new System.Drawing.Point(6, 23);
            this.cboTipoPessoa.Name = "cboTipoPessoa";
            this.cboTipoPessoa.Size = new System.Drawing.Size(119, 28);
            this.cboTipoPessoa.TabIndex = 0;
            this.cboTipoPessoa.Text = "Física";
            this.cboTipoPessoa.SelectedIndexChanged += new System.EventHandler(this.cboTipoPessoa_SelectedIndexChanged);
            this.cboTipoPessoa.Leave += new System.EventHandler(this.cboTipoPessoa_Leave);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.SystemColors.Window;
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotal.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.ForeColor = System.Drawing.Color.Blue;
            this.txtSubTotal.Location = new System.Drawing.Point(207, 158);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(140, 33);
            this.txtSubTotal.TabIndex = 20;
            this.txtSubTotal.Text = "0,00";
            this.txtSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalPagar.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPagar.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalPagar.Location = new System.Drawing.Point(207, 287);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(140, 33);
            this.txtTotalPagar.TabIndex = 21;
            this.txtTotalPagar.Text = "0,00";
            this.txtTotalPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTroco
            // 
            this.txtTroco.BackColor = System.Drawing.SystemColors.Window;
            this.txtTroco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTroco.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTroco.Location = new System.Drawing.Point(207, 369);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(140, 25);
            this.txtTroco.TabIndex = 22;
            this.txtTroco.Text = "0,00";
            this.txtTroco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SaidaMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gbFinanceiro);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "SaidaMovimento";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saida de Veiculo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVaga)).EndInit();
            this.gbFinanceiro.ResumeLayout(false);
            this.gbFinanceiro.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNomeContrato;
        private System.Windows.Forms.TextBox txtIdContrato;
        private FontAwesome.Sharp.IconButton btnBuscaContrato;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnRemContrato;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboServico;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.GroupBox gbFinanceiro;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.MaskedTextBox txtDocFed;
        private System.Windows.Forms.ComboBox cboTipoPessoa;
        private System.Windows.Forms.NumericUpDown txtVaga;
        private System.Windows.Forms.Label lblDHSaida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDHEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTipoVeiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPermanencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblExcedente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbProporcional;
        private System.Windows.Forms.RadioButton rbInteiro;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.RadioButton rbZero;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboFormaPagamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtExcedente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label txtSubTotal;
        private System.Windows.Forms.Label txtTotalPagar;
        private System.Windows.Forms.Label txtTroco;
    }
}