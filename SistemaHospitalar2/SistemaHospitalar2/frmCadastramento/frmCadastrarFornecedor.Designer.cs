namespace SistemaHospitalar2
{
    partial class frmCadastrarFornecedor
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
            System.Windows.Forms.Label codMedicoLabel;
            System.Windows.Forms.Label codFornecedorLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label nacionalidadeLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label inicio_contratoLabel;
            System.Windows.Forms.Label fim_contratoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fornecedorDataGridView = new System.Windows.Forms.DataGridView();
            this.codFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacionalidade_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iniciocontratoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fimcontratoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_HospitalDataSet = new SistemaHospitalar2.db_HospitalDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.codFornecedorTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.nacionalidadeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.inicio_contratoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fim_contratoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.codMedicoTextBox = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscarNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fornecedorTableAdapter = new SistemaHospitalar2.db_HospitalDataSetTableAdapters.FornecedorTableAdapter();
            this.tableAdapterManager = new SistemaHospitalar2.db_HospitalDataSetTableAdapters.TableAdapterManager();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.telefoneTextBox = new System.Windows.Forms.MaskedTextBox();
            codMedicoLabel = new System.Windows.Forms.Label();
            codFornecedorLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            nacionalidadeLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            inicio_contratoLabel = new System.Windows.Forms.Label();
            fim_contratoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // codMedicoLabel
            // 
            codMedicoLabel.AutoSize = true;
            codMedicoLabel.Location = new System.Drawing.Point(277, 496);
            codMedicoLabel.Name = "codMedicoLabel";
            codMedicoLabel.Size = new System.Drawing.Size(105, 18);
            codMedicoLabel.TabIndex = 58;
            codMedicoLabel.Text = "cod Medico:";
            // 
            // codFornecedorLabel
            // 
            codFornecedorLabel.AutoSize = true;
            codFornecedorLabel.Location = new System.Drawing.Point(7, 30);
            codFornecedorLabel.Name = "codFornecedorLabel";
            codFornecedorLabel.Size = new System.Drawing.Size(71, 18);
            codFornecedorLabel.TabIndex = 62;
            codFornecedorLabel.Text = "Código:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(7, 63);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(62, 18);
            nomeLabel.TabIndex = 64;
            nomeLabel.Text = "Nome:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(12, 125);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(84, 18);
            telefoneLabel.TabIndex = 66;
            telefoneLabel.Text = "Telefone:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(356, 27);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(89, 18);
            enderecoLabel.TabIndex = 68;
            enderecoLabel.Text = "Endereço:";
            // 
            // nacionalidadeLabel
            // 
            nacionalidadeLabel.AutoSize = true;
            nacionalidadeLabel.Location = new System.Drawing.Point(7, 98);
            nacionalidadeLabel.Name = "nacionalidadeLabel";
            nacionalidadeLabel.Size = new System.Drawing.Size(130, 18);
            nacionalidadeLabel.TabIndex = 70;
            nacionalidadeLabel.Text = "Nacionalidade:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(356, 62);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(60, 18);
            emailLabel.TabIndex = 72;
            emailLabel.Text = "Email:";
            // 
            // inicio_contratoLabel
            // 
            inicio_contratoLabel.AutoSize = true;
            inicio_contratoLabel.Location = new System.Drawing.Point(350, 98);
            inicio_contratoLabel.Name = "inicio_contratoLabel";
            inicio_contratoLabel.Size = new System.Drawing.Size(163, 18);
            inicio_contratoLabel.TabIndex = 74;
            inicio_contratoLabel.Text = "Início do Contrato:";
            // 
            // fim_contratoLabel
            // 
            fim_contratoLabel.AutoSize = true;
            fim_contratoLabel.Location = new System.Drawing.Point(352, 131);
            fim_contratoLabel.Name = "fim_contratoLabel";
            fim_contratoLabel.Size = new System.Drawing.Size(163, 18);
            fim_contratoLabel.TabIndex = 76;
            fim_contratoLabel.Text = "Fim  do Conntrato:";
            // 
            // fornecedorDataGridView
            // 
            this.fornecedorDataGridView.AllowUserToAddRows = false;
            this.fornecedorDataGridView.AllowUserToDeleteRows = false;
            this.fornecedorDataGridView.AutoGenerateColumns = false;
            this.fornecedorDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fornecedorDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.fornecedorDataGridView.ColumnHeadersHeight = 30;
            this.fornecedorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codFornecedorDataGridViewTextBoxColumn,
            this.nome_fornecedor,
            this.telefone_fornecedor,
            this.endereco_fornecedor,
            this.nacionalidade_fornecedor,
            this.email_fornecedor,
            this.iniciocontratoDataGridViewTextBoxColumn,
            this.fimcontratoDataGridViewTextBoxColumn});
            this.fornecedorDataGridView.DataSource = this.fornecedorBindingSource;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.fornecedorDataGridView.DefaultCellStyle = dataGridViewCellStyle20;
            this.fornecedorDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.fornecedorDataGridView.Location = new System.Drawing.Point(0, 126);
            this.fornecedorDataGridView.Name = "fornecedorDataGridView";
            this.fornecedorDataGridView.ReadOnly = true;
            this.fornecedorDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fornecedorDataGridView.Size = new System.Drawing.Size(936, 200);
            this.fornecedorDataGridView.TabIndex = 31;
            // 
            // codFornecedorDataGridViewTextBoxColumn
            // 
            this.codFornecedorDataGridViewTextBoxColumn.DataPropertyName = "codFornecedor";
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codFornecedorDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle17;
            this.codFornecedorDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codFornecedorDataGridViewTextBoxColumn.Name = "codFornecedorDataGridViewTextBoxColumn";
            this.codFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.codFornecedorDataGridViewTextBoxColumn.Width = 85;
            // 
            // nome_fornecedor
            // 
            this.nome_fornecedor.DataPropertyName = "nome_fornecedor";
            this.nome_fornecedor.HeaderText = "Nome do Fornecedor";
            this.nome_fornecedor.Name = "nome_fornecedor";
            this.nome_fornecedor.ReadOnly = true;
            this.nome_fornecedor.Width = 200;
            // 
            // telefone_fornecedor
            // 
            this.telefone_fornecedor.DataPropertyName = "telefone_fornecedor";
            this.telefone_fornecedor.HeaderText = "Telefone";
            this.telefone_fornecedor.Name = "telefone_fornecedor";
            this.telefone_fornecedor.ReadOnly = true;
            this.telefone_fornecedor.Width = 115;
            // 
            // endereco_fornecedor
            // 
            this.endereco_fornecedor.DataPropertyName = "endereco_fornecedor";
            this.endereco_fornecedor.HeaderText = "Endereço";
            this.endereco_fornecedor.Name = "endereco_fornecedor";
            this.endereco_fornecedor.ReadOnly = true;
            this.endereco_fornecedor.Width = 140;
            // 
            // nacionalidade_fornecedor
            // 
            this.nacionalidade_fornecedor.DataPropertyName = "nacionalidade_fornecedor";
            this.nacionalidade_fornecedor.HeaderText = "Nacionalidade";
            this.nacionalidade_fornecedor.Name = "nacionalidade_fornecedor";
            this.nacionalidade_fornecedor.ReadOnly = true;
            this.nacionalidade_fornecedor.Width = 135;
            // 
            // email_fornecedor
            // 
            this.email_fornecedor.DataPropertyName = "email_fornecedor";
            this.email_fornecedor.HeaderText = "Email do Fornecedor";
            this.email_fornecedor.Name = "email_fornecedor";
            this.email_fornecedor.ReadOnly = true;
            this.email_fornecedor.Width = 230;
            // 
            // iniciocontratoDataGridViewTextBoxColumn
            // 
            this.iniciocontratoDataGridViewTextBoxColumn.DataPropertyName = "inicio_contrato";
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.Format = "d";
            dataGridViewCellStyle18.NullValue = null;
            this.iniciocontratoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle18;
            this.iniciocontratoDataGridViewTextBoxColumn.HeaderText = "Início do Contrato";
            this.iniciocontratoDataGridViewTextBoxColumn.Name = "iniciocontratoDataGridViewTextBoxColumn";
            this.iniciocontratoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iniciocontratoDataGridViewTextBoxColumn.Width = 150;
            // 
            // fimcontratoDataGridViewTextBoxColumn
            // 
            this.fimcontratoDataGridViewTextBoxColumn.DataPropertyName = "fim_contrato";
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fimcontratoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle19;
            this.fimcontratoDataGridViewTextBoxColumn.HeaderText = "Fim do Contrato";
            this.fimcontratoDataGridViewTextBoxColumn.Name = "fimcontratoDataGridViewTextBoxColumn";
            this.fimcontratoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fimcontratoDataGridViewTextBoxColumn.Width = 150;
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "Fornecedor";
            this.fornecedorBindingSource.DataSource = this.db_HospitalDataSet;
            // 
            // db_HospitalDataSet
            // 
            this.db_HospitalDataSet.DataSetName = "db_HospitalDataSet";
            this.db_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.telefoneTextBox);
            this.groupBox2.Controls.Add(codFornecedorLabel);
            this.groupBox2.Controls.Add(this.codFornecedorTextBox);
            this.groupBox2.Controls.Add(nomeLabel);
            this.groupBox2.Controls.Add(this.nomeTextBox);
            this.groupBox2.Controls.Add(telefoneLabel);
            this.groupBox2.Controls.Add(enderecoLabel);
            this.groupBox2.Controls.Add(this.enderecoTextBox);
            this.groupBox2.Controls.Add(nacionalidadeLabel);
            this.groupBox2.Controls.Add(this.nacionalidadeTextBox);
            this.groupBox2.Controls.Add(emailLabel);
            this.groupBox2.Controls.Add(this.emailTextBox);
            this.groupBox2.Controls.Add(inicio_contratoLabel);
            this.groupBox2.Controls.Add(this.inicio_contratoDateTimePicker);
            this.groupBox2.Controls.Add(fim_contratoLabel);
            this.groupBox2.Controls.Add(this.fim_contratoDateTimePicker);
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(codMedicoLabel);
            this.groupBox2.Controls.Add(this.codMedicoTextBox);
            this.groupBox2.Controls.Add(this.btnSair);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnNovo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(936, 268);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // codFornecedorTextBox
            // 
            this.codFornecedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "codFornecedor", true));
            this.codFornecedorTextBox.Location = new System.Drawing.Point(84, 20);
            this.codFornecedorTextBox.Name = "codFornecedorTextBox";
            this.codFornecedorTextBox.ReadOnly = true;
            this.codFornecedorTextBox.Size = new System.Drawing.Size(189, 27);
            this.codFornecedorTextBox.TabIndex = 63;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "nome_fornecedor", true));
            this.nomeTextBox.Location = new System.Drawing.Point(84, 53);
            this.nomeTextBox.MaxLength = 75;
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.ReadOnly = true;
            this.nomeTextBox.Size = new System.Drawing.Size(262, 27);
            this.nomeTextBox.TabIndex = 65;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "endereco_fornecedor", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(451, 27);
            this.enderecoTextBox.MaxLength = 30;
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.ReadOnly = true;
            this.enderecoTextBox.Size = new System.Drawing.Size(238, 27);
            this.enderecoTextBox.TabIndex = 71;
            // 
            // nacionalidadeTextBox
            // 
            this.nacionalidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "nacionalidade_fornecedor", true));
            this.nacionalidadeTextBox.Location = new System.Drawing.Point(143, 88);
            this.nacionalidadeTextBox.MaxLength = 20;
            this.nacionalidadeTextBox.Name = "nacionalidadeTextBox";
            this.nacionalidadeTextBox.ReadOnly = true;
            this.nacionalidadeTextBox.Size = new System.Drawing.Size(203, 27);
            this.nacionalidadeTextBox.TabIndex = 67;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "email_fornecedor", true));
            this.emailTextBox.Location = new System.Drawing.Point(422, 62);
            this.emailTextBox.MaxLength = 100;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(267, 27);
            this.emailTextBox.TabIndex = 73;
            // 
            // inicio_contratoDateTimePicker
            // 
            this.inicio_contratoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fornecedorBindingSource, "inicio_contrato", true));
            this.inicio_contratoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "inicio_contrato", true));
            this.inicio_contratoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inicio_contratoDateTimePicker.Location = new System.Drawing.Point(519, 94);
            this.inicio_contratoDateTimePicker.Name = "inicio_contratoDateTimePicker";
            this.inicio_contratoDateTimePicker.Size = new System.Drawing.Size(170, 27);
            this.inicio_contratoDateTimePicker.TabIndex = 75;
            // 
            // fim_contratoDateTimePicker
            // 
            this.fim_contratoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fornecedorBindingSource, "fim_contrato", true));
            this.fim_contratoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedorBindingSource, "fim_contrato", true));
            this.fim_contratoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fim_contratoDateTimePicker.Location = new System.Drawing.Point(526, 127);
            this.fim_contratoDateTimePicker.Name = "fim_contratoDateTimePicker";
            this.fim_contratoDateTimePicker.Size = new System.Drawing.Size(163, 27);
            this.fim_contratoDateTimePicker.TabIndex = 77;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.xde1;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.Location = new System.Drawing.Point(795, 72);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(81, 50);
            this.btnSalvar.TabIndex = 62;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.exe1;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.Location = new System.Drawing.Point(705, 72);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(81, 50);
            this.btnExcluir.TabIndex = 61;
            this.toolTip1.SetToolTip(this.btnExcluir, "Eliminar");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.edre1;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Location = new System.Drawing.Point(795, 19);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(81, 50);
            this.btnEditar.TabIndex = 60;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // codMedicoTextBox
            // 
            this.codMedicoTextBox.Location = new System.Drawing.Point(435, 493);
            this.codMedicoTextBox.Name = "codMedicoTextBox";
            this.codMedicoTextBox.Size = new System.Drawing.Size(200, 27);
            this.codMedicoTextBox.TabIndex = 59;
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.ex1;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Location = new System.Drawing.Point(882, 19);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(52, 103);
            this.btnSair.TabIndex = 32;
            this.toolTip1.SetToolTip(this.btnSair, "Fechar");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnActualizar);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.txtBuscarCodigo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtBuscarNome);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(705, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 129);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consultar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(123, 49);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(98, 30);
            this.btnActualizar.TabIndex = 26;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(74, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 30);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "OK";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(9, 50);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(62, 27);
            this.txtBuscarCodigo.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pelo nome";
            // 
            // txtBuscarNome
            // 
            this.txtBuscarNome.Location = new System.Drawing.Point(12, 97);
            this.txtBuscarNome.Name = "txtBuscarNome";
            this.txtBuscarNome.Size = new System.Drawing.Size(213, 27);
            this.txtBuscarNome.TabIndex = 2;
            this.txtBuscarNome.TextChanged += new System.EventHandler(this.txtBuscarNome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pelo código";
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.fb2;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.Location = new System.Drawing.Point(705, 17);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(81, 50);
            this.btnNovo.TabIndex = 27;
            this.toolTip1.SetToolTip(this.btnNovo, "Novo");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblLogin);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(936, 126);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(335, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hospital EG Esperança";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(701, 88);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(229, 23);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Cadastrar Fornecedor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaHospitalar2.Properties.Resources._forr;
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Ala_HospitalarTableAdapter = null;
            this.tableAdapterManager.Alta_Paciente_InternadoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EscolaTableAdapter = null;
            this.tableAdapterManager.Especialidade_MedicoTableAdapter = null;
            this.tableAdapterManager.EstagiarioTableAdapter = null;
            this.tableAdapterManager.ExameTableAdapter = null;
            this.tableAdapterManager.FornecedorTableAdapter = this.fornecedorTableAdapter;
            this.tableAdapterManager.FuncaoTableAdapter = null;
            this.tableAdapterManager.FuncionariosTableAdapter = null;
            this.tableAdapterManager.Marcacao_CirugiaTableAdapter = null;
            this.tableAdapterManager.Marcacao_ConsultaTableAdapter = null;
            this.tableAdapterManager.Material_DescartavelTableAdapter = null;
            this.tableAdapterManager.MedicamentoTableAdapter = null;
            this.tableAdapterManager.MedicoTableAdapter = null;
            this.tableAdapterManager.Morte_PacienteTableAdapter = null;
            this.tableAdapterManager.Paciente_InternadoTableAdapter = null;
            this.tableAdapterManager.PacienteTableAdapter = null;
            this.tableAdapterManager.QuartoTableAdapter = null;
            this.tableAdapterManager.Tipo_CirugiaTableAdapter = null;
            this.tableAdapterManager.Tipo_ConsultaTableAdapter = null;
            this.tableAdapterManager.Tipo_ExameTableAdapter = null;
            this.tableAdapterManager.TratamentoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaHospitalar2.db_HospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Location = new System.Drawing.Point(143, 125);
            this.telefoneTextBox.Mask = "900000000";
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(175, 27);
            this.telefoneTextBox.TabIndex = 78;
            // 
            // frmCadastrarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(936, 598);
            this.Controls.Add(this.fornecedorDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastrarFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Fornecedor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastrarFornecedor_FormClosed);
            this.Load += new System.EventHandler(this.frmCadastrarFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView fornecedorDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox codMedicoTextBox;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private db_HospitalDataSet db_HospitalDataSet;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private db_HospitalDataSetTableAdapters.FornecedorTableAdapter fornecedorTableAdapter;
        private db_HospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox codFornecedorTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox nacionalidadeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DateTimePicker inicio_contratoDateTimePicker;
        private System.Windows.Forms.DateTimePicker fim_contratoDateTimePicker;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacionalidade_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn iniciocontratoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fimcontratoDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox telefoneTextBox;
    }
}