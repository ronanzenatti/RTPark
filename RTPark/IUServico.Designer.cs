namespace RTPark
{
    partial class IUServico
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
            this.txtIdServico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.cboTipoCobranca = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVMoto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVOutros = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtVCarro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Blue;
            this.lblTitulo.Location = new System.Drawing.Point(39, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(743, 47);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CADASTRO DE SERVIÇOS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // txtIdServico
            // 
            this.txtIdServico.BackColor = System.Drawing.Color.White;
            this.txtIdServico.Enabled = false;
            this.txtIdServico.ForeColor = System.Drawing.Color.Blue;
            this.txtIdServico.Location = new System.Drawing.Point(119, 81);
            this.txtIdServico.Name = "txtIdServico";
            this.txtIdServico.ReadOnly = true;
            this.txtIdServico.Size = new System.Drawing.Size(122, 26);
            this.txtIdServico.TabIndex = 2;
            this.txtIdServico.TabStop = false;
            this.txtIdServico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(119, 124);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(663, 26);
            this.txtDescricao.TabIndex = 1;
            // 
            // cboTipoCobranca
            // 
            this.cboTipoCobranca.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTipoCobranca.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTipoCobranca.FormattingEnabled = true;
            this.cboTipoCobranca.Items.AddRange(new object[] {
            "Hora",
            "Minuto",
            "Diária",
            "Mensal"});
            this.cboTipoCobranca.Location = new System.Drawing.Point(119, 164);
            this.cboTipoCobranca.Name = "cboTipoCobranca";
            this.cboTipoCobranca.Size = new System.Drawing.Size(192, 28);
            this.cboTipoCobranca.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(42, 167);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "Tipo:";
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Checked = true;
            this.chkAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAtivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chkAtivo.Location = new System.Drawing.Point(685, 82);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(97, 29);
            this.chkAtivo.TabIndex = 36;
            this.chkAtivo.Text = "Ativo?";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(46, 320);
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
            this.btnLimpar.Location = new System.Drawing.Point(347, 320);
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
            this.btnSalvar.Location = new System.Drawing.Point(653, 320);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(129, 39);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtVMoto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtVOutros);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtVCarro);
            this.groupBox1.Location = new System.Drawing.Point(119, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 79);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valor por tipo de veiculo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(226, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Moto:";
            // 
            // txtVMoto
            // 
            this.txtVMoto.Location = new System.Drawing.Point(281, 35);
            this.txtVMoto.Name = "txtVMoto";
            this.txtVMoto.Size = new System.Drawing.Size(140, 26);
            this.txtVMoto.TabIndex = 6;
            this.txtVMoto.Text = "0,00";
            this.txtVMoto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVMoto.TextChanged += new System.EventHandler(this.txtVMoto_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(439, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "Outros:";
            // 
            // txtVOutros
            // 
            this.txtVOutros.Location = new System.Drawing.Point(509, 35);
            this.txtVOutros.Name = "txtVOutros";
            this.txtVOutros.Size = new System.Drawing.Size(140, 26);
            this.txtVOutros.TabIndex = 7;
            this.txtVOutros.Text = "0,00";
            this.txtVOutros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVOutros.TextChanged += new System.EventHandler(this.txtVOutros_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 20);
            this.label17.TabIndex = 37;
            this.label17.Text = "Carro:";
            // 
            // txtVCarro
            // 
            this.txtVCarro.Location = new System.Drawing.Point(66, 35);
            this.txtVCarro.Name = "txtVCarro";
            this.txtVCarro.Size = new System.Drawing.Size(140, 26);
            this.txtVCarro.TabIndex = 5;
            this.txtVCarro.Text = "0,00";
            this.txtVCarro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVCarro.TextChanged += new System.EventHandler(this.txtVCarro_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(544, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Quantidade:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(661, 165);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(120, 26);
            this.txtQuantidade.TabIndex = 3;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQuantidade.ThousandsSeparator = true;
            this.txtQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // IUServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 399);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.cboTipoCobranca);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdServico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(839, 438);
            this.MinimumSize = new System.Drawing.Size(839, 438);
            this.Name = "IUServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Serviço";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IUServico_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IUServico_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.IUServico_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdServico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ComboBox cboTipoCobranca;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVMoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVOutros;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtVCarro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtQuantidade;
    }
}