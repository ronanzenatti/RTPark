namespace RTPark
{
    partial class IUCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblFed = new System.Windows.Forms.Label();
            this.txtDoc_fed = new System.Windows.Forms.MaskedTextBox();
            this.txtDoc_est = new System.Windows.Forms.TextBox();
            this.lblEst = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNasci = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.txtTelefones = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gbVeiculos = new System.Windows.Forms.GroupBox();
            this.btnDelV = new System.Windows.Forms.Button();
            this.btnEditV = new System.Windows.Forms.Button();
            this.btnAddV = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.gbVeiculos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
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
            this.lblTitulo.Text = "CADASTRO DE CLIENTE";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.BackColor = System.Drawing.Color.White;
            this.txtIdCliente.Enabled = false;
            this.txtIdCliente.ForeColor = System.Drawing.Color.Blue;
            this.txtIdCliente.Location = new System.Drawing.Point(119, 62);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(122, 26);
            this.txtIdCliente.TabIndex = 2;
            this.txtIdCliente.TabStop = false;
            this.txtIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(119, 105);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(663, 26);
            this.txtNome.TabIndex = 2;
            // 
            // lblFed
            // 
            this.lblFed.AutoSize = true;
            this.lblFed.Location = new System.Drawing.Point(42, 150);
            this.lblFed.Name = "lblFed";
            this.lblFed.Size = new System.Drawing.Size(48, 20);
            this.lblFed.TabIndex = 5;
            this.lblFed.Text = "CPF:";
            // 
            // txtDoc_fed
            // 
            this.txtDoc_fed.Location = new System.Drawing.Point(119, 147);
            this.txtDoc_fed.Mask = "999,999,999-99";
            this.txtDoc_fed.Name = "txtDoc_fed";
            this.txtDoc_fed.Size = new System.Drawing.Size(185, 26);
            this.txtDoc_fed.TabIndex = 3;
            this.txtDoc_fed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDoc_est
            // 
            this.txtDoc_est.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDoc_est.Location = new System.Drawing.Point(348, 147);
            this.txtDoc_est.Name = "txtDoc_est";
            this.txtDoc_est.Size = new System.Drawing.Size(175, 26);
            this.txtDoc_est.TabIndex = 4;
            this.txtDoc_est.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEst
            // 
            this.lblEst.AutoSize = true;
            this.lblEst.Location = new System.Drawing.Point(309, 150);
            this.lblEst.Name = "lblEst";
            this.lblEst.Size = new System.Drawing.Size(41, 20);
            this.lblEst.TabIndex = 7;
            this.lblEst.Text = "RG:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nascimento:";
            // 
            // dtpNasci
            // 
            this.dtpNasci.Checked = false;
            this.dtpNasci.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNasci.Location = new System.Drawing.Point(629, 147);
            this.dtpNasci.Name = "dtpNasci";
            this.dtpNasci.ShowCheckBox = true;
            this.dtpNasci.Size = new System.Drawing.Size(153, 26);
            this.dtpNasci.TabIndex = 5;
            this.dtpNasci.ValueChanged += new System.EventHandler(this.dtpNasci_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Rua: ";
            // 
            // txtRua
            // 
            this.txtRua.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRua.Location = new System.Drawing.Point(119, 189);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(487, 26);
            this.txtRua.TabIndex = 6;
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.White;
            this.txtNumero.Location = new System.Drawing.Point(660, 189);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(122, 26);
            this.txtNumero.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(625, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nº:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Bairro:";
            // 
            // txtBairro
            // 
            this.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairro.Location = new System.Drawing.Point(119, 231);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(220, 26);
            this.txtBairro.TabIndex = 8;
            // 
            // txtCidade
            // 
            this.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidade.Location = new System.Drawing.Point(425, 231);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(220, 26);
            this.txtCidade.TabIndex = 9;
            this.txtCidade.Text = "BAURU";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(353, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Cidade:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(667, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "UF:";
            // 
            // cboUF
            // 
            this.cboUF.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboUF.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboUF.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboUF.FormattingEnabled = true;
            this.cboUF.ItemHeight = 20;
            this.cboUF.Items.AddRange(new object[] {
            "SP",
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SE",
            "TO"});
            this.cboUF.Location = new System.Drawing.Point(707, 231);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(74, 28);
            this.cboUF.TabIndex = 20;
            // 
            // txtTelefones
            // 
            this.txtTelefones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefones.Location = new System.Drawing.Point(356, 276);
            this.txtTelefones.Name = "txtTelefones";
            this.txtTelefones.Size = new System.Drawing.Size(425, 26);
            this.txtTelefones.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(261, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Telefones:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 276);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "CEP:";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(119, 273);
            this.txtCep.Mask = "00,000-000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(122, 26);
            this.txtCep.TabIndex = 11;
            this.txtCep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtEmail.Location = new System.Drawing.Point(119, 318);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(662, 26);
            this.txtEmail.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(42, 321);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "E-mail: ";
            // 
            // cboTipo
            // 
            this.cboTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Fisica",
            "Juridica"});
            this.cboTipo.Location = new System.Drawing.Point(629, 62);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(153, 28);
            this.cboTipo.TabIndex = 1;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(486, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "Tipo de Pessoa:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Location = new System.Drawing.Point(45, 362);
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
            this.btnLimpar.Location = new System.Drawing.Point(346, 362);
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
            this.btnSalvar.Location = new System.Drawing.Point(652, 362);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(129, 39);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gbVeiculos
            // 
            this.gbVeiculos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbVeiculos.Controls.Add(this.btnDelV);
            this.gbVeiculos.Controls.Add(this.btnEditV);
            this.gbVeiculos.Controls.Add(this.btnAddV);
            this.gbVeiculos.Controls.Add(this.dgvDados);
            this.gbVeiculos.Enabled = false;
            this.gbVeiculos.ForeColor = System.Drawing.Color.Blue;
            this.gbVeiculos.Location = new System.Drawing.Point(46, 408);
            this.gbVeiculos.Name = "gbVeiculos";
            this.gbVeiculos.Size = new System.Drawing.Size(735, 271);
            this.gbVeiculos.TabIndex = 39;
            this.gbVeiculos.TabStop = false;
            this.gbVeiculos.Text = "VEICULOS DO CLIENTE:";
            // 
            // btnDelV
            // 
            this.btnDelV.BackColor = System.Drawing.Color.Salmon;
            this.btnDelV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDelV.Location = new System.Drawing.Point(624, 224);
            this.btnDelV.Name = "btnDelV";
            this.btnDelV.Size = new System.Drawing.Size(103, 39);
            this.btnDelV.TabIndex = 46;
            this.btnDelV.Text = "&Excluir";
            this.btnDelV.UseVisualStyleBackColor = false;
            this.btnDelV.Click += new System.EventHandler(this.btnDelV_Click);
            // 
            // btnEditV
            // 
            this.btnEditV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditV.Location = new System.Drawing.Point(624, 154);
            this.btnEditV.Name = "btnEditV";
            this.btnEditV.Size = new System.Drawing.Size(103, 39);
            this.btnEditV.TabIndex = 45;
            this.btnEditV.Text = "&Editar";
            this.btnEditV.UseVisualStyleBackColor = false;
            this.btnEditV.Click += new System.EventHandler(this.btnEditV_Click);
            // 
            // btnAddV
            // 
            this.btnAddV.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddV.Location = new System.Drawing.Point(624, 81);
            this.btnAddV.Name = "btnAddV";
            this.btnAddV.Size = new System.Drawing.Size(105, 39);
            this.btnAddV.TabIndex = 44;
            this.btnAddV.Text = "&Adicionar";
            this.btnAddV.UseVisualStyleBackColor = false;
            this.btnAddV.Click += new System.EventHandler(this.btnAddV_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(6, 25);
            this.dgvDados.MultiSelect = false;
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDados.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvDados.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(612, 238);
            this.dgvDados.TabIndex = 8;
            // 
            // IUCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 691);
            this.Controls.Add(this.gbVeiculos);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCep);
            this.Controls.Add(this.txtTelefones);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cboUF);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpNasci);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDoc_est);
            this.Controls.Add(this.lblEst);
            this.Controls.Add(this.txtDoc_fed);
            this.Controls.Add(this.lblFed);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(839, 730);
            this.MinimumSize = new System.Drawing.Size(839, 730);
            this.Name = "IUCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IUCliente_FormClosing);
            this.Load += new System.EventHandler(this.IUCliente_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IUCliente_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.IUCliente_KeyUp);
            this.gbVeiculos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblFed;
        private System.Windows.Forms.MaskedTextBox txtDoc_fed;
        private System.Windows.Forms.TextBox txtDoc_est;
        private System.Windows.Forms.Label lblEst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNasci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboUF;
        private System.Windows.Forms.TextBox txtTelefones;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gbVeiculos;
        private System.Windows.Forms.Button btnDelV;
        private System.Windows.Forms.Button btnEditV;
        private System.Windows.Forms.Button btnAddV;
        private System.Windows.Forms.DataGridView dgvDados;
    }
}