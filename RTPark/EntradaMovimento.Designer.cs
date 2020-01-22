namespace RTPark
{
    partial class EntradaMovimento
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntradaMovimento));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtPlaca = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtCupom = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemContrato = new FontAwesome.Sharp.IconButton();
            this.btnBuscaContrato = new FontAwesome.Sharp.IconButton();
            this.txtNomeContrato = new System.Windows.Forms.TextBox();
            this.txtIdContrato = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHoraEntrada = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cboServico = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtVaga = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtDocFed = new System.Windows.Forms.MaskedTextBox();
            this.cboTipoPessoa = new System.Windows.Forms.ComboBox();
            this.timerEntrada = new System.Windows.Forms.Timer(this.components);
            this.gbTipoVeiculo = new System.Windows.Forms.GroupBox();
            this.rbOutros = new System.Windows.Forms.RadioButton();
            this.rbMoto = new System.Windows.Forms.RadioButton();
            this.rbCarro = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVaga)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.gbTipoVeiculo.SuspendLayout();
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
            this.txtPlaca.Mask = ">?>?>?-9A99";
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
            this.panel2.TabIndex = 6;
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
            // txtCupom
            // 
            this.txtCupom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCupom.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCupom.Location = new System.Drawing.Point(478, 101);
            this.txtCupom.Multiline = true;
            this.txtCupom.Name = "txtCupom";
            this.txtCupom.Size = new System.Drawing.Size(295, 384);
            this.txtCupom.TabIndex = 2;
            this.txtCupom.TabStop = false;
            this.txtCupom.Text = resources.GetString("txtCupom.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemContrato);
            this.groupBox1.Controls.Add(this.btnBuscaContrato);
            this.groupBox1.Controls.Add(this.txtNomeContrato);
            this.groupBox1.Controls.Add(this.txtIdContrato);
            this.groupBox1.Location = new System.Drawing.Point(12, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 59);
            this.groupBox1.TabIndex = 7;
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
            this.btnRemContrato.Location = new System.Drawing.Point(422, 23);
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
            this.btnBuscaContrato.TabStop = false;
            this.btnBuscaContrato.UseVisualStyleBackColor = false;
            this.btnBuscaContrato.Click += new System.EventHandler(this.btnBuscaContrato_Click);
            // 
            // txtNomeContrato
            // 
            this.txtNomeContrato.BackColor = System.Drawing.Color.White;
            this.txtNomeContrato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeContrato.Location = new System.Drawing.Point(109, 23);
            this.txtNomeContrato.Name = "txtNomeContrato";
            this.txtNomeContrato.ReadOnly = true;
            this.txtNomeContrato.Size = new System.Drawing.Size(307, 26);
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
            this.txtIdContrato.Size = new System.Drawing.Size(63, 26);
            this.txtIdContrato.TabIndex = 45;
            this.txtIdContrato.TabStop = false;
            this.txtIdContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHoraEntrada);
            this.groupBox2.Location = new System.Drawing.Point(12, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 59);
            this.groupBox2.TabIndex = 48;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Horário de Entrada:";
            // 
            // txtHoraEntrada
            // 
            this.txtHoraEntrada.BackColor = System.Drawing.Color.White;
            this.txtHoraEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHoraEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHoraEntrada.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraEntrada.ForeColor = System.Drawing.Color.Blue;
            this.txtHoraEntrada.Location = new System.Drawing.Point(6, 22);
            this.txtHoraEntrada.Name = "txtHoraEntrada";
            this.txtHoraEntrada.ReadOnly = true;
            this.txtHoraEntrada.Size = new System.Drawing.Size(444, 32);
            this.txtHoraEntrada.TabIndex = 46;
            this.txtHoraEntrada.TabStop = false;
            this.txtHoraEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtValor);
            this.groupBox3.Controls.Add(this.cboServico);
            this.groupBox3.Location = new System.Drawing.Point(12, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(456, 59);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Serviço:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(345, 25);
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
            this.cboServico.Size = new System.Drawing.Size(330, 28);
            this.cboServico.TabIndex = 0;
            this.cboServico.TabStop = false;
            this.cboServico.SelectedIndexChanged += new System.EventHandler(this.cboServico_SelectedIndexChanged);
            this.cboServico.Leave += new System.EventHandler(this.cboServico_Leave);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtVaga);
            this.groupBox5.Location = new System.Drawing.Point(348, 231);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(120, 59);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Vaga:";
            // 
            // txtVaga
            // 
            this.txtVaga.Location = new System.Drawing.Point(17, 25);
            this.txtVaga.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.txtVaga.Name = "txtVaga";
            this.txtVaga.Size = new System.Drawing.Size(87, 26);
            this.txtVaga.TabIndex = 9;
            this.txtVaga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVaga.Leave += new System.EventHandler(this.txtVaga_Leave);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtVeiculo);
            this.groupBox6.Location = new System.Drawing.Point(13, 361);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(456, 59);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Veiculo:";
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.BackColor = System.Drawing.Color.White;
            this.txtVeiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVeiculo.Location = new System.Drawing.Point(6, 25);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(444, 26);
            this.txtVeiculo.TabIndex = 1;
            this.txtVeiculo.Leave += new System.EventHandler(this.txtVeiculo_Leave);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtDocFed);
            this.groupBox7.Controls.Add(this.cboTipoPessoa);
            this.groupBox7.Location = new System.Drawing.Point(12, 426);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(456, 59);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "CPF / CNPJ do Cliente:";
            // 
            // txtDocFed
            // 
            this.txtDocFed.Font = new System.Drawing.Font("Bitstream Vera Sans Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocFed.Location = new System.Drawing.Point(122, 24);
            this.txtDocFed.Mask = "999,999,999-99";
            this.txtDocFed.Name = "txtDocFed";
            this.txtDocFed.Size = new System.Drawing.Size(328, 26);
            this.txtDocFed.TabIndex = 16;
            this.txtDocFed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDocFed.Leave += new System.EventHandler(this.txtDocFed_Leave);
            // 
            // cboTipoPessoa
            // 
            this.cboTipoPessoa.FormattingEnabled = true;
            this.cboTipoPessoa.ItemHeight = 20;
            this.cboTipoPessoa.Items.AddRange(new object[] {
            "Física",
            "Júridica"});
            this.cboTipoPessoa.Location = new System.Drawing.Point(6, 24);
            this.cboTipoPessoa.Name = "cboTipoPessoa";
            this.cboTipoPessoa.Size = new System.Drawing.Size(110, 28);
            this.cboTipoPessoa.TabIndex = 0;
            this.cboTipoPessoa.Text = "Física";
            this.cboTipoPessoa.SelectedIndexChanged += new System.EventHandler(this.cboTipoPessoa_SelectedIndexChanged);
            this.cboTipoPessoa.Leave += new System.EventHandler(this.cboTipoPessoa_Leave);
            // 
            // timerEntrada
            // 
            this.timerEntrada.Enabled = true;
            this.timerEntrada.Interval = 1000;
            this.timerEntrada.Tick += new System.EventHandler(this.timerEntrada_Tick);
            // 
            // gbTipoVeiculo
            // 
            this.gbTipoVeiculo.Controls.Add(this.rbOutros);
            this.gbTipoVeiculo.Controls.Add(this.rbMoto);
            this.gbTipoVeiculo.Controls.Add(this.rbCarro);
            this.gbTipoVeiculo.Location = new System.Drawing.Point(13, 231);
            this.gbTipoVeiculo.Name = "gbTipoVeiculo";
            this.gbTipoVeiculo.Size = new System.Drawing.Size(329, 59);
            this.gbTipoVeiculo.TabIndex = 2;
            this.gbTipoVeiculo.TabStop = false;
            this.gbTipoVeiculo.Text = "Tipo de Veiculo:";
            // 
            // rbOutros
            // 
            this.rbOutros.AutoSize = true;
            this.rbOutros.Location = new System.Drawing.Point(242, 25);
            this.rbOutros.Name = "rbOutros";
            this.rbOutros.Size = new System.Drawing.Size(81, 24);
            this.rbOutros.TabIndex = 2;
            this.rbOutros.TabStop = true;
            this.rbOutros.Text = "Outros";
            this.rbOutros.UseVisualStyleBackColor = true;
            this.rbOutros.CheckedChanged += new System.EventHandler(this.rbOutros_CheckedChanged);
            // 
            // rbMoto
            // 
            this.rbMoto.AutoSize = true;
            this.rbMoto.Location = new System.Drawing.Point(129, 25);
            this.rbMoto.Name = "rbMoto";
            this.rbMoto.Size = new System.Drawing.Size(67, 24);
            this.rbMoto.TabIndex = 1;
            this.rbMoto.Text = "Moto";
            this.rbMoto.UseVisualStyleBackColor = true;
            this.rbMoto.CheckedChanged += new System.EventHandler(this.rbMoto_CheckedChanged);
            // 
            // rbCarro
            // 
            this.rbCarro.AutoSize = true;
            this.rbCarro.Checked = true;
            this.rbCarro.Location = new System.Drawing.Point(8, 25);
            this.rbCarro.Name = "rbCarro";
            this.rbCarro.Size = new System.Drawing.Size(71, 24);
            this.rbCarro.TabIndex = 0;
            this.rbCarro.TabStop = true;
            this.rbCarro.Text = "Carro";
            this.rbCarro.UseVisualStyleBackColor = true;
            this.rbCarro.CheckedChanged += new System.EventHandler(this.rbCarro_CheckedChanged);
            // 
            // EntradaMovimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gbTipoVeiculo);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCupom);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "EntradaMovimento";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada de Veiculo";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EntradaMovimento_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtVaga)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.gbTipoVeiculo.ResumeLayout(false);
            this.gbTipoVeiculo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.MaskedTextBox txtPlaca;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtCupom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNomeContrato;
        private System.Windows.Forms.TextBox txtIdContrato;
        private FontAwesome.Sharp.IconButton btnBuscaContrato;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtHoraEntrada;
        private FontAwesome.Sharp.IconButton btnRemContrato;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboServico;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown txtVaga;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Timer timerEntrada;
        private System.Windows.Forms.MaskedTextBox txtDocFed;
        private System.Windows.Forms.ComboBox cboTipoPessoa;
        private System.Windows.Forms.GroupBox gbTipoVeiculo;
        private System.Windows.Forms.RadioButton rbOutros;
        private System.Windows.Forms.RadioButton rbMoto;
        private System.Windows.Forms.RadioButton rbCarro;
    }
}