namespace RTPark
{
    partial class IUConfigMovimento
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
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscaServico = new FontAwesome.Sharp.IconButton();
            this.btnAddServico = new FontAwesome.Sharp.IconButton();
            this.txtNomeServico = new System.Windows.Forms.TextBox();
            this.txtIdServico = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVMoto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVOutros = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtVCarro = new System.Windows.Forms.TextBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gbSaida = new System.Windows.Forms.GroupBox();
            this.rbNaoS = new System.Windows.Forms.RadioButton();
            this.rbSimS = new System.Windows.Forms.RadioButton();
            this.rbPergS = new System.Windows.Forms.RadioButton();
            this.gbEntrada = new System.Windows.Forms.GroupBox();
            this.rbNaoE = new System.Windows.Forms.RadioButton();
            this.rbSimE = new System.Windows.Forms.RadioButton();
            this.rbPergE = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkCnpj = new System.Windows.Forms.CheckBox();
            this.chkTelefones = new System.Windows.Forms.CheckBox();
            this.chkEndereco = new System.Windows.Forms.CheckBox();
            this.gbExcedente = new System.Windows.Forms.GroupBox();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.rbZero = new System.Windows.Forms.RadioButton();
            this.rbProporcional = new System.Windows.Forms.RadioButton();
            this.rbInteiro = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbSaida.SuspendLayout();
            this.gbEntrada.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbExcedente.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEmpresa.Location = new System.Drawing.Point(99, 69);
            this.lblEmpresa.MaximumSize = new System.Drawing.Size(642, 30);
            this.lblEmpresa.MinimumSize = new System.Drawing.Size(642, 30);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(642, 30);
            this.lblEmpresa.TabIndex = 48;
            this.lblEmpresa.Text = "Nome da Empresa";
            this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Empresa:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Blue;
            this.lblTitulo.Location = new System.Drawing.Point(14, 9);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(726, 50);
            this.lblTitulo.TabIndex = 43;
            this.lblTitulo.Text = "CONFIGURAÇÕES DE MOVIMENTO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Location = new System.Drawing.Point(591, 512);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(129, 39);
            this.btnSalvar.TabIndex = 55;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gbExcedente);
            this.groupBox2.Controls.Add(this.btnBuscaServico);
            this.groupBox2.Controls.Add(this.btnAddServico);
            this.groupBox2.Controls.Add(this.txtNomeServico);
            this.groupBox2.Controls.Add(this.txtIdServico);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(13, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(730, 198);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "COBRANÇA PADRÃO:";
            // 
            // btnBuscaServico
            // 
            this.btnBuscaServico.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscaServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscaServico.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBuscaServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscaServico.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscaServico.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnBuscaServico.IconColor = System.Drawing.Color.White;
            this.btnBuscaServico.IconSize = 25;
            this.btnBuscaServico.Location = new System.Drawing.Point(32, 25);
            this.btnBuscaServico.Name = "btnBuscaServico";
            this.btnBuscaServico.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnBuscaServico.Rotation = 0D;
            this.btnBuscaServico.Size = new System.Drawing.Size(28, 26);
            this.btnBuscaServico.TabIndex = 55;
            this.btnBuscaServico.UseVisualStyleBackColor = false;
            this.btnBuscaServico.Click += new System.EventHandler(this.btnBuscaServico_Click);
            // 
            // btnAddServico
            // 
            this.btnAddServico.BackColor = System.Drawing.Color.Green;
            this.btnAddServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddServico.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAddServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddServico.ForeColor = System.Drawing.Color.White;
            this.btnAddServico.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddServico.IconColor = System.Drawing.Color.White;
            this.btnAddServico.IconSize = 25;
            this.btnAddServico.Location = new System.Drawing.Point(667, 25);
            this.btnAddServico.Name = "btnAddServico";
            this.btnAddServico.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnAddServico.Rotation = 0D;
            this.btnAddServico.Size = new System.Drawing.Size(28, 26);
            this.btnAddServico.TabIndex = 59;
            this.btnAddServico.UseVisualStyleBackColor = false;
            this.btnAddServico.Click += new System.EventHandler(this.btnAddServico_Click);
            // 
            // txtNomeServico
            // 
            this.txtNomeServico.BackColor = System.Drawing.Color.White;
            this.txtNomeServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeServico.Location = new System.Drawing.Point(176, 25);
            this.txtNomeServico.Name = "txtNomeServico";
            this.txtNomeServico.ReadOnly = true;
            this.txtNomeServico.Size = new System.Drawing.Size(483, 26);
            this.txtNomeServico.TabIndex = 58;
            this.txtNomeServico.TabStop = false;
            // 
            // txtIdServico
            // 
            this.txtIdServico.BackColor = System.Drawing.Color.White;
            this.txtIdServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdServico.Location = new System.Drawing.Point(66, 25);
            this.txtIdServico.Name = "txtIdServico";
            this.txtIdServico.ReadOnly = true;
            this.txtIdServico.Size = new System.Drawing.Size(104, 26);
            this.txtIdServico.TabIndex = 57;
            this.txtIdServico.TabStop = false;
            this.txtIdServico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtVMoto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtVOutros);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtVCarro);
            this.groupBox1.Location = new System.Drawing.Point(33, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 71);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valor do serviço por tipo de veiculo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(229, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Moto:";
            // 
            // txtVMoto
            // 
            this.txtVMoto.BackColor = System.Drawing.Color.White;
            this.txtVMoto.Location = new System.Drawing.Point(284, 30);
            this.txtVMoto.Name = "txtVMoto";
            this.txtVMoto.ReadOnly = true;
            this.txtVMoto.Size = new System.Drawing.Size(140, 26);
            this.txtVMoto.TabIndex = 43;
            this.txtVMoto.TabStop = false;
            this.txtVMoto.Text = "0,00";
            this.txtVMoto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVMoto.TextChanged += new System.EventHandler(this.txtVMoto_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(442, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Outros:";
            // 
            // txtVOutros
            // 
            this.txtVOutros.BackColor = System.Drawing.Color.White;
            this.txtVOutros.Location = new System.Drawing.Point(512, 30);
            this.txtVOutros.Name = "txtVOutros";
            this.txtVOutros.ReadOnly = true;
            this.txtVOutros.Size = new System.Drawing.Size(140, 26);
            this.txtVOutros.TabIndex = 44;
            this.txtVOutros.TabStop = false;
            this.txtVOutros.Text = "0,00";
            this.txtVOutros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVOutros.TextChanged += new System.EventHandler(this.txtVOutros_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(10, 33);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 20);
            this.label17.TabIndex = 45;
            this.label17.Text = "Carro:";
            // 
            // txtVCarro
            // 
            this.txtVCarro.BackColor = System.Drawing.Color.White;
            this.txtVCarro.Location = new System.Drawing.Point(69, 30);
            this.txtVCarro.Name = "txtVCarro";
            this.txtVCarro.ReadOnly = true;
            this.txtVCarro.Size = new System.Drawing.Size(140, 26);
            this.txtVCarro.TabIndex = 42;
            this.txtVCarro.TabStop = false;
            this.txtVCarro.Text = "0,00";
            this.txtVCarro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVCarro.TextChanged += new System.EventHandler(this.txtVCarro_TextChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(29, 512);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(129, 39);
            this.btnVoltar.TabIndex = 56;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gbSaida);
            this.groupBox3.Controls.Add(this.gbEntrada);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(10, 317);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(730, 181);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CONFIGURAÇÃO DE IMPRESSÃO:";
            // 
            // gbSaida
            // 
            this.gbSaida.Controls.Add(this.rbNaoS);
            this.gbSaida.Controls.Add(this.rbSimS);
            this.gbSaida.Controls.Add(this.rbPergS);
            this.gbSaida.Location = new System.Drawing.Point(427, 102);
            this.gbSaida.Name = "gbSaida";
            this.gbSaida.Size = new System.Drawing.Size(283, 71);
            this.gbSaida.TabIndex = 2;
            this.gbSaida.TabStop = false;
            this.gbSaida.Text = "Imprimir Cupom de Saida:";
            // 
            // rbNaoS
            // 
            this.rbNaoS.AutoSize = true;
            this.rbNaoS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbNaoS.Location = new System.Drawing.Point(211, 33);
            this.rbNaoS.Name = "rbNaoS";
            this.rbNaoS.Size = new System.Drawing.Size(59, 24);
            this.rbNaoS.TabIndex = 2;
            this.rbNaoS.Text = "Não";
            this.rbNaoS.UseVisualStyleBackColor = true;
            // 
            // rbSimS
            // 
            this.rbSimS.AutoSize = true;
            this.rbSimS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbSimS.Location = new System.Drawing.Point(138, 33);
            this.rbSimS.Name = "rbSimS";
            this.rbSimS.Size = new System.Drawing.Size(57, 24);
            this.rbSimS.TabIndex = 1;
            this.rbSimS.Text = "Sim";
            this.rbSimS.UseVisualStyleBackColor = true;
            // 
            // rbPergS
            // 
            this.rbPergS.AutoSize = true;
            this.rbPergS.Checked = true;
            this.rbPergS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbPergS.Location = new System.Drawing.Point(17, 33);
            this.rbPergS.Name = "rbPergS";
            this.rbPergS.Size = new System.Drawing.Size(106, 24);
            this.rbPergS.TabIndex = 0;
            this.rbPergS.TabStop = true;
            this.rbPergS.Text = "Perguntar";
            this.rbPergS.UseVisualStyleBackColor = true;
            // 
            // gbEntrada
            // 
            this.gbEntrada.Controls.Add(this.rbNaoE);
            this.gbEntrada.Controls.Add(this.rbSimE);
            this.gbEntrada.Controls.Add(this.rbPergE);
            this.gbEntrada.Location = new System.Drawing.Point(427, 25);
            this.gbEntrada.Name = "gbEntrada";
            this.gbEntrada.Size = new System.Drawing.Size(283, 71);
            this.gbEntrada.TabIndex = 1;
            this.gbEntrada.TabStop = false;
            this.gbEntrada.Text = "Imprimir Cupom de Entrada:";
            // 
            // rbNaoE
            // 
            this.rbNaoE.AutoSize = true;
            this.rbNaoE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbNaoE.Location = new System.Drawing.Point(211, 33);
            this.rbNaoE.Name = "rbNaoE";
            this.rbNaoE.Size = new System.Drawing.Size(59, 24);
            this.rbNaoE.TabIndex = 2;
            this.rbNaoE.Text = "Não";
            this.rbNaoE.UseVisualStyleBackColor = true;
            // 
            // rbSimE
            // 
            this.rbSimE.AutoSize = true;
            this.rbSimE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbSimE.Location = new System.Drawing.Point(138, 33);
            this.rbSimE.Name = "rbSimE";
            this.rbSimE.Size = new System.Drawing.Size(57, 24);
            this.rbSimE.TabIndex = 1;
            this.rbSimE.Text = "Sim";
            this.rbSimE.UseVisualStyleBackColor = true;
            // 
            // rbPergE
            // 
            this.rbPergE.AutoSize = true;
            this.rbPergE.Checked = true;
            this.rbPergE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rbPergE.Location = new System.Drawing.Point(17, 33);
            this.rbPergE.Name = "rbPergE";
            this.rbPergE.Size = new System.Drawing.Size(106, 24);
            this.rbPergE.TabIndex = 0;
            this.rbPergE.TabStop = true;
            this.rbPergE.Text = "Perguntar";
            this.rbPergE.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkCnpj);
            this.groupBox4.Controls.Add(this.chkTelefones);
            this.groupBox4.Controls.Add(this.chkEndereco);
            this.groupBox4.Location = new System.Drawing.Point(19, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(321, 71);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Imprimir:";
            // 
            // chkCnpj
            // 
            this.chkCnpj.AutoSize = true;
            this.chkCnpj.Checked = true;
            this.chkCnpj.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCnpj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkCnpj.Location = new System.Drawing.Point(240, 33);
            this.chkCnpj.Name = "chkCnpj";
            this.chkCnpj.Size = new System.Drawing.Size(72, 24);
            this.chkCnpj.TabIndex = 2;
            this.chkCnpj.Text = "CNPJ";
            this.chkCnpj.UseVisualStyleBackColor = true;
            // 
            // chkTelefones
            // 
            this.chkTelefones.AutoSize = true;
            this.chkTelefones.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkTelefones.Location = new System.Drawing.Point(127, 34);
            this.chkTelefones.Name = "chkTelefones";
            this.chkTelefones.Size = new System.Drawing.Size(107, 24);
            this.chkTelefones.TabIndex = 1;
            this.chkTelefones.Text = "Telefones";
            this.chkTelefones.UseVisualStyleBackColor = true;
            // 
            // chkEndereco
            // 
            this.chkEndereco.AutoSize = true;
            this.chkEndereco.Checked = true;
            this.chkEndereco.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEndereco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkEndereco.Location = new System.Drawing.Point(16, 34);
            this.chkEndereco.Name = "chkEndereco";
            this.chkEndereco.Size = new System.Drawing.Size(105, 24);
            this.chkEndereco.TabIndex = 0;
            this.chkEndereco.Text = "Endereço";
            this.chkEndereco.UseVisualStyleBackColor = true;
            // 
            // gbExcedente
            // 
            this.gbExcedente.Controls.Add(this.rbManual);
            this.gbExcedente.Controls.Add(this.rbZero);
            this.gbExcedente.Controls.Add(this.rbProporcional);
            this.gbExcedente.Controls.Add(this.rbInteiro);
            this.gbExcedente.ForeColor = System.Drawing.Color.Blue;
            this.gbExcedente.Location = new System.Drawing.Point(33, 134);
            this.gbExcedente.Name = "gbExcedente";
            this.gbExcedente.Size = new System.Drawing.Size(341, 54);
            this.gbExcedente.TabIndex = 60;
            this.gbExcedente.TabStop = false;
            this.gbExcedente.Text = "Fatura do Excedente:";
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
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Manual";
            this.rbManual.UseVisualStyleBackColor = true;
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
            this.rbZero.TabStop = true;
            this.rbZero.Text = "Zero";
            this.rbZero.UseVisualStyleBackColor = true;
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
            this.rbProporcional.TabStop = true;
            this.rbProporcional.Text = "Proporcional";
            this.rbProporcional.UseVisualStyleBackColor = true;
            // 
            // rbInteiro
            // 
            this.rbInteiro.AutoSize = true;
            this.rbInteiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbInteiro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rbInteiro.Location = new System.Drawing.Point(6, 23);
            this.rbInteiro.Name = "rbInteiro";
            this.rbInteiro.Size = new System.Drawing.Size(69, 20);
            this.rbInteiro.TabIndex = 0;
            this.rbInteiro.TabStop = true;
            this.rbInteiro.Text = "Inteiro";
            this.rbInteiro.UseVisualStyleBackColor = true;
            // 
            // IUConfigMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(776, 600);
            this.MinimumSize = new System.Drawing.Size(776, 600);
            this.Name = "IUConfigMovimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações de Movimento";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.gbSaida.ResumeLayout(false);
            this.gbSaida.PerformLayout();
            this.gbEntrada.ResumeLayout(false);
            this.gbEntrada.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbExcedente.ResumeLayout(false);
            this.gbExcedente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton btnBuscaServico;
        private FontAwesome.Sharp.IconButton btnAddServico;
        private System.Windows.Forms.TextBox txtNomeServico;
        private System.Windows.Forms.TextBox txtIdServico;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVMoto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVOutros;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtVCarro;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkCnpj;
        private System.Windows.Forms.CheckBox chkTelefones;
        private System.Windows.Forms.CheckBox chkEndereco;
        private System.Windows.Forms.GroupBox gbEntrada;
        private System.Windows.Forms.RadioButton rbNaoE;
        private System.Windows.Forms.RadioButton rbSimE;
        private System.Windows.Forms.RadioButton rbPergE;
        private System.Windows.Forms.GroupBox gbSaida;
        private System.Windows.Forms.RadioButton rbNaoS;
        private System.Windows.Forms.RadioButton rbSimS;
        private System.Windows.Forms.RadioButton rbPergS;
        private System.Windows.Forms.GroupBox gbExcedente;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.RadioButton rbZero;
        private System.Windows.Forms.RadioButton rbProporcional;
        private System.Windows.Forms.RadioButton rbInteiro;
    }
}