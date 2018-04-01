namespace RTPark
{
    partial class IUContrato
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdContrato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVMoto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVOutros = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtVCarro = new System.Windows.Forms.TextBox();
            this.btnAddCliente = new FontAwesome.Sharp.IconButton();
            this.txtIdServico = new System.Windows.Forms.TextBox();
            this.txtNomeServico = new System.Windows.Forms.TextBox();
            this.btnAddServico = new FontAwesome.Sharp.IconButton();
            this.btnBuscaServico = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Blue;
            this.lblTitulo.Location = new System.Drawing.Point(39, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(743, 47);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CADASTRO DE CONTRATO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // txtIdContrato
            // 
            this.txtIdContrato.BackColor = System.Drawing.Color.White;
            this.txtIdContrato.Enabled = false;
            this.txtIdContrato.ForeColor = System.Drawing.Color.Blue;
            this.txtIdContrato.Location = new System.Drawing.Point(137, 71);
            this.txtIdContrato.Name = "txtIdContrato";
            this.txtIdContrato.ReadOnly = true;
            this.txtIdContrato.Size = new System.Drawing.Size(122, 26);
            this.txtIdContrato.TabIndex = 2;
            this.txtIdContrato.TabStop = false;
            this.txtIdContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(137, 113);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(645, 26);
            this.txtDescricao.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(42, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "Cliente:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(46, 427);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(129, 39);
            this.btnVoltar.TabIndex = 37;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(347, 427);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(129, 39);
            this.btnLimpar.TabIndex = 38;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSalvar.Location = new System.Drawing.Point(653, 427);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(129, 39);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cboCliente
            // 
            this.cboCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(137, 158);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(611, 28);
            this.cboCliente.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Serviço:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtVMoto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtVOutros);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtVCarro);
            this.groupBox1.Location = new System.Drawing.Point(119, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 71);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valor do serviço por tipo de veiculo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Moto:";
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
            // btnAddCliente
            // 
            this.btnAddCliente.BackColor = System.Drawing.Color.Green;
            this.btnAddCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCliente.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAddCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCliente.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddCliente.IconColor = System.Drawing.Color.White;
            this.btnAddCliente.IconSize = 25;
            this.btnAddCliente.Location = new System.Drawing.Point(754, 158);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnAddCliente.Rotation = 0D;
            this.btnAddCliente.Size = new System.Drawing.Size(28, 28);
            this.btnAddCliente.TabIndex = 41;
            this.btnAddCliente.UseVisualStyleBackColor = false;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // txtIdServico
            // 
            this.txtIdServico.BackColor = System.Drawing.Color.White;
            this.txtIdServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIdServico.Location = new System.Drawing.Point(171, 202);
            this.txtIdServico.Name = "txtIdServico";
            this.txtIdServico.ReadOnly = true;
            this.txtIdServico.Size = new System.Drawing.Size(88, 26);
            this.txtIdServico.TabIndex = 42;
            this.txtIdServico.TabStop = false;
            this.txtIdServico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNomeServico
            // 
            this.txtNomeServico.BackColor = System.Drawing.Color.White;
            this.txtNomeServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeServico.Location = new System.Drawing.Point(265, 202);
            this.txtNomeServico.Name = "txtNomeServico";
            this.txtNomeServico.ReadOnly = true;
            this.txtNomeServico.Size = new System.Drawing.Size(483, 26);
            this.txtNomeServico.TabIndex = 43;
            this.txtNomeServico.TabStop = false;
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
            this.btnAddServico.Location = new System.Drawing.Point(754, 202);
            this.btnAddServico.Name = "btnAddServico";
            this.btnAddServico.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnAddServico.Rotation = 0D;
            this.btnAddServico.Size = new System.Drawing.Size(28, 26);
            this.btnAddServico.TabIndex = 44;
            this.btnAddServico.UseVisualStyleBackColor = false;
            this.btnAddServico.Click += new System.EventHandler(this.btnAddServico_Click);
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
            this.btnBuscaServico.Location = new System.Drawing.Point(137, 202);
            this.btnBuscaServico.Name = "btnBuscaServico";
            this.btnBuscaServico.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.btnBuscaServico.Rotation = 0D;
            this.btnBuscaServico.Size = new System.Drawing.Size(28, 26);
            this.btnBuscaServico.TabIndex = 3;
            this.btnBuscaServico.UseVisualStyleBackColor = false;
            this.btnBuscaServico.Click += new System.EventHandler(this.btnBuscaServico_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpFim);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtpInicio);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(119, 321);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(663, 81);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Periodo de Vigência:";
            // 
            // dtpFim
            // 
            this.dtpFim.Checked = false;
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFim.Location = new System.Drawing.Point(480, 33);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.ShowCheckBox = true;
            this.dtpFim.Size = new System.Drawing.Size(164, 26);
            this.dtpFim.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(396, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Término:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicio.Location = new System.Drawing.Point(77, 32);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.ShowCheckBox = true;
            this.dtpInicio.Size = new System.Drawing.Size(164, 26);
            this.dtpInicio.TabIndex = 5;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(14, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Inicio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(526, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "Dia de Vencimento:";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(698, 72);
            this.txtDia.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.txtDia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(84, 26);
            this.txtDia.TabIndex = 7;
            this.txtDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // IUContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 498);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBuscaServico);
            this.Controls.Add(this.btnAddServico);
            this.Controls.Add(this.txtNomeServico);
            this.Controls.Add(this.txtIdServico);
            this.Controls.Add(this.btnAddCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdContrato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(839, 537);
            this.MinimumSize = new System.Drawing.Size(839, 537);
            this.Name = "IUContrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Contrato";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IUContrato_FormClosing);
            this.Load += new System.EventHandler(this.IUContrato_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IUContrato_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.IUContrato_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdContrato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton btnAddCliente;
        private System.Windows.Forms.TextBox txtIdServico;
        private System.Windows.Forms.TextBox txtNomeServico;
        private FontAwesome.Sharp.IconButton btnAddServico;
        private FontAwesome.Sharp.IconButton btnBuscaServico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVMoto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVOutros;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtVCarro;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtDia;
    }
}