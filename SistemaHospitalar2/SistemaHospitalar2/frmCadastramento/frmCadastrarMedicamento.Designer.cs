namespace SistemaHospitalar2
{
    partial class frmCadastrarMedicamento
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
            System.Windows.Forms.Label codMedicamentoLabel;
            System.Windows.Forms.Label nome_comercialLabel;
            System.Windows.Forms.Label nome_genericoLabel;
            System.Windows.Forms.Label data_validadeLabel;
            System.Windows.Forms.Label codFornecedorLabel;
            System.Windows.Forms.Label quantidade_entradaLabel;
            System.Windows.Forms.Label quantidade_actualLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label quantidade_inicialLabel;
            System.Windows.Forms.Label quantidade_minimaLabel;
            System.Windows.Forms.Label quantidade_maximaLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.medicamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbCodFornecedor = new System.Windows.Forms.ComboBox();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_HospitalDataSet = new SistemaHospitalar2.db_HospitalDataSet();
            this.codMedicamentoTextBox = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscarNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.nome_comercialTextBox = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.nome_genericoTextBox = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.data_validadeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.quantidade_entradaTextBox = new System.Windows.Forms.TextBox();
            this.quantidade_actualTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.quantidade_inicialTextBox = new System.Windows.Forms.TextBox();
            this.quantidade_minimaTextBox = new System.Windows.Forms.TextBox();
            this.quantidade_maximaTextBox = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fornecedorTableAdapter = new SistemaHospitalar2.db_HospitalDataSetTableAdapters.FornecedorTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            codMedicamentoLabel = new System.Windows.Forms.Label();
            nome_comercialLabel = new System.Windows.Forms.Label();
            nome_genericoLabel = new System.Windows.Forms.Label();
            data_validadeLabel = new System.Windows.Forms.Label();
            codFornecedorLabel = new System.Windows.Forms.Label();
            quantidade_entradaLabel = new System.Windows.Forms.Label();
            quantidade_actualLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            quantidade_inicialLabel = new System.Windows.Forms.Label();
            quantidade_minimaLabel = new System.Windows.Forms.Label();
            quantidade_maximaLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // codMedicamentoLabel
            // 
            codMedicamentoLabel.AutoSize = true;
            codMedicamentoLabel.Location = new System.Drawing.Point(9, 20);
            codMedicamentoLabel.Name = "codMedicamentoLabel";
            codMedicamentoLabel.Size = new System.Drawing.Size(71, 18);
            codMedicamentoLabel.TabIndex = 66;
            codMedicamentoLabel.Text = "Código:";
            // 
            // nome_comercialLabel
            // 
            nome_comercialLabel.AutoSize = true;
            nome_comercialLabel.Location = new System.Drawing.Point(9, 86);
            nome_comercialLabel.Name = "nome_comercialLabel";
            nome_comercialLabel.Size = new System.Drawing.Size(148, 18);
            nome_comercialLabel.TabIndex = 68;
            nome_comercialLabel.Text = "Nome Comercial:";
            // 
            // nome_genericoLabel
            // 
            nome_genericoLabel.AutoSize = true;
            nome_genericoLabel.Location = new System.Drawing.Point(8, 53);
            nome_genericoLabel.Name = "nome_genericoLabel";
            nome_genericoLabel.Size = new System.Drawing.Size(139, 18);
            nome_genericoLabel.TabIndex = 70;
            nome_genericoLabel.Text = "Nome Genérico:";
            // 
            // data_validadeLabel
            // 
            data_validadeLabel.AutoSize = true;
            data_validadeLabel.Location = new System.Drawing.Point(9, 122);
            data_validadeLabel.Name = "data_validadeLabel";
            data_validadeLabel.Size = new System.Drawing.Size(156, 18);
            data_validadeLabel.TabIndex = 72;
            data_validadeLabel.Text = "Data de Validade:";
            // 
            // codFornecedorLabel
            // 
            codFornecedorLabel.AutoSize = true;
            codFornecedorLabel.Location = new System.Drawing.Point(9, 152);
            codFornecedorLabel.Name = "codFornecedorLabel";
            codFornecedorLabel.Size = new System.Drawing.Size(104, 18);
            codFornecedorLabel.TabIndex = 74;
            codFornecedorLabel.Text = "Fornecedor:";
            // 
            // quantidade_entradaLabel
            // 
            quantidade_entradaLabel.AutoSize = true;
            quantidade_entradaLabel.Location = new System.Drawing.Point(429, 23);
            quantidade_entradaLabel.Name = "quantidade_entradaLabel";
            quantidade_entradaLabel.Size = new System.Drawing.Size(179, 18);
            quantidade_entradaLabel.TabIndex = 76;
            quantidade_entradaLabel.Text = "Quantidade Entrada:";
            // 
            // quantidade_actualLabel
            // 
            quantidade_actualLabel.AutoSize = true;
            quantidade_actualLabel.Location = new System.Drawing.Point(429, 155);
            quantidade_actualLabel.Name = "quantidade_actualLabel";
            quantidade_actualLabel.Size = new System.Drawing.Size(167, 18);
            quantidade_actualLabel.TabIndex = 78;
            quantidade_actualLabel.Text = "Quantidade Actual:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(9, 205);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(93, 18);
            descricaoLabel.TabIndex = 80;
            descricaoLabel.Text = "Descrição:";
            // 
            // quantidade_inicialLabel
            // 
            quantidade_inicialLabel.AutoSize = true;
            quantidade_inicialLabel.Location = new System.Drawing.Point(429, 122);
            quantidade_inicialLabel.Name = "quantidade_inicialLabel";
            quantidade_inicialLabel.Size = new System.Drawing.Size(166, 18);
            quantidade_inicialLabel.TabIndex = 82;
            quantidade_inicialLabel.Text = "Quantidade Inicial:";
            // 
            // quantidade_minimaLabel
            // 
            quantidade_minimaLabel.AutoSize = true;
            quantidade_minimaLabel.Location = new System.Drawing.Point(429, 56);
            quantidade_minimaLabel.Name = "quantidade_minimaLabel";
            quantidade_minimaLabel.Size = new System.Drawing.Size(174, 18);
            quantidade_minimaLabel.TabIndex = 84;
            quantidade_minimaLabel.Text = "Quantidade Mínima:";
            // 
            // quantidade_maximaLabel
            // 
            quantidade_maximaLabel.AutoSize = true;
            quantidade_maximaLabel.Location = new System.Drawing.Point(429, 89);
            quantidade_maximaLabel.Name = "quantidade_maximaLabel";
            quantidade_maximaLabel.Size = new System.Drawing.Size(178, 18);
            quantidade_maximaLabel.TabIndex = 86;
            quantidade_maximaLabel.Text = "Quantidade Máxima:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblLogin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 126);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(332, 54);
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
            this.lblLogin.Location = new System.Drawing.Point(747, 89);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(249, 23);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Cadastrar Medicamento";
            // 
            // medicamentoDataGridView
            // 
            this.medicamentoDataGridView.AllowUserToAddRows = false;
            this.medicamentoDataGridView.AllowUserToDeleteRows = false;
            this.medicamentoDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.medicamentoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.medicamentoDataGridView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.medicamentoDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.medicamentoDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.medicamentoDataGridView.Location = new System.Drawing.Point(0, 126);
            this.medicamentoDataGridView.Name = "medicamentoDataGridView";
            this.medicamentoDataGridView.ReadOnly = true;
            this.medicamentoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.medicamentoDataGridView.Size = new System.Drawing.Size(1000, 200);
            this.medicamentoDataGridView.TabIndex = 28;
            this.medicamentoDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.medicamentoDataGridView_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbCodFornecedor);
            this.groupBox2.Controls.Add(codMedicamentoLabel);
            this.groupBox2.Controls.Add(this.codMedicamentoTextBox);
            this.groupBox2.Controls.Add(this.btnSair);
            this.groupBox2.Controls.Add(nome_comercialLabel);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.nome_comercialTextBox);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(nome_genericoLabel);
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.nome_genericoTextBox);
            this.groupBox2.Controls.Add(this.btnNovo);
            this.groupBox2.Controls.Add(data_validadeLabel);
            this.groupBox2.Controls.Add(this.data_validadeDateTimePicker);
            this.groupBox2.Controls.Add(codFornecedorLabel);
            this.groupBox2.Controls.Add(quantidade_entradaLabel);
            this.groupBox2.Controls.Add(this.quantidade_entradaTextBox);
            this.groupBox2.Controls.Add(quantidade_actualLabel);
            this.groupBox2.Controls.Add(this.quantidade_actualTextBox);
            this.groupBox2.Controls.Add(descricaoLabel);
            this.groupBox2.Controls.Add(this.descricaoTextBox);
            this.groupBox2.Controls.Add(quantidade_inicialLabel);
            this.groupBox2.Controls.Add(this.quantidade_inicialTextBox);
            this.groupBox2.Controls.Add(quantidade_minimaLabel);
            this.groupBox2.Controls.Add(this.quantidade_minimaTextBox);
            this.groupBox2.Controls.Add(quantidade_maximaLabel);
            this.groupBox2.Controls.Add(this.quantidade_maximaTextBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 326);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1000, 268);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // cbCodFornecedor
            // 
            this.cbCodFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fornecedorBindingSource, "codFornecedor", true));
            this.cbCodFornecedor.DataSource = this.fornecedorBindingSource;
            this.cbCodFornecedor.DisplayMember = "nome_fornecedor";
            this.cbCodFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodFornecedor.FormattingEnabled = true;
            this.cbCodFornecedor.Location = new System.Drawing.Point(173, 149);
            this.cbCodFornecedor.Name = "cbCodFornecedor";
            this.cbCodFornecedor.Size = new System.Drawing.Size(241, 26);
            this.cbCodFornecedor.TabIndex = 72;
            this.cbCodFornecedor.ValueMember = "codFornecedor";
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
            // codMedicamentoTextBox
            // 
            this.codMedicamentoTextBox.Enabled = false;
            this.codMedicamentoTextBox.Location = new System.Drawing.Point(156, 17);
            this.codMedicamentoTextBox.Name = "codMedicamentoTextBox";
            this.codMedicamentoTextBox.ReadOnly = true;
            this.codMedicamentoTextBox.Size = new System.Drawing.Size(177, 27);
            this.codMedicamentoTextBox.TabIndex = 67;
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.ex1;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Location = new System.Drawing.Point(945, 17);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(55, 103);
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
            this.groupBox3.Location = new System.Drawing.Point(768, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 129);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consultar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(124, 49);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(98, 30);
            this.btnActualizar.TabIndex = 26;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(75, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 30);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "OK";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(10, 50);
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
            this.txtBuscarNome.Size = new System.Drawing.Size(208, 27);
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
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.edre;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Location = new System.Drawing.Point(858, 17);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(81, 50);
            this.btnEditar.TabIndex = 42;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // nome_comercialTextBox
            // 
            this.nome_comercialTextBox.Location = new System.Drawing.Point(157, 83);
            this.nome_comercialTextBox.Name = "nome_comercialTextBox";
            this.nome_comercialTextBox.ReadOnly = true;
            this.nome_comercialTextBox.Size = new System.Drawing.Size(257, 27);
            this.nome_comercialTextBox.TabIndex = 70;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.exe;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.Location = new System.Drawing.Point(768, 70);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(81, 50);
            this.btnExcluir.TabIndex = 43;
            this.toolTip1.SetToolTip(this.btnExcluir, "Eliminar");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.xde;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.Location = new System.Drawing.Point(858, 70);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(81, 50);
            this.btnSalvar.TabIndex = 44;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // nome_genericoTextBox
            // 
            this.nome_genericoTextBox.Location = new System.Drawing.Point(156, 50);
            this.nome_genericoTextBox.Name = "nome_genericoTextBox";
            this.nome_genericoTextBox.ReadOnly = true;
            this.nome_genericoTextBox.Size = new System.Drawing.Size(257, 27);
            this.nome_genericoTextBox.TabIndex = 69;
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.fb1;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.Location = new System.Drawing.Point(768, 17);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(81, 50);
            this.btnNovo.TabIndex = 66;
            this.toolTip1.SetToolTip(this.btnNovo, "Novo");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // data_validadeDateTimePicker
            // 
            this.data_validadeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_validadeDateTimePicker.Location = new System.Drawing.Point(173, 116);
            this.data_validadeDateTimePicker.Name = "data_validadeDateTimePicker";
            this.data_validadeDateTimePicker.Size = new System.Drawing.Size(241, 27);
            this.data_validadeDateTimePicker.TabIndex = 71;
            // 
            // quantidade_entradaTextBox
            // 
            this.quantidade_entradaTextBox.Location = new System.Drawing.Point(612, 20);
            this.quantidade_entradaTextBox.Name = "quantidade_entradaTextBox";
            this.quantidade_entradaTextBox.ReadOnly = true;
            this.quantidade_entradaTextBox.Size = new System.Drawing.Size(142, 27);
            this.quantidade_entradaTextBox.TabIndex = 73;
            // 
            // quantidade_actualTextBox
            // 
            this.quantidade_actualTextBox.Location = new System.Drawing.Point(612, 148);
            this.quantidade_actualTextBox.Name = "quantidade_actualTextBox";
            this.quantidade_actualTextBox.ReadOnly = true;
            this.quantidade_actualTextBox.Size = new System.Drawing.Size(144, 27);
            this.quantidade_actualTextBox.TabIndex = 79;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(122, 181);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.ReadOnly = true;
            this.descricaoTextBox.Size = new System.Drawing.Size(292, 73);
            this.descricaoTextBox.TabIndex = 77;
            // 
            // quantidade_inicialTextBox
            // 
            this.quantidade_inicialTextBox.Location = new System.Drawing.Point(612, 119);
            this.quantidade_inicialTextBox.Name = "quantidade_inicialTextBox";
            this.quantidade_inicialTextBox.ReadOnly = true;
            this.quantidade_inicialTextBox.Size = new System.Drawing.Size(144, 27);
            this.quantidade_inicialTextBox.TabIndex = 76;
            // 
            // quantidade_minimaTextBox
            // 
            this.quantidade_minimaTextBox.Location = new System.Drawing.Point(612, 53);
            this.quantidade_minimaTextBox.Name = "quantidade_minimaTextBox";
            this.quantidade_minimaTextBox.ReadOnly = true;
            this.quantidade_minimaTextBox.Size = new System.Drawing.Size(142, 27);
            this.quantidade_minimaTextBox.TabIndex = 74;
            // 
            // quantidade_maximaTextBox
            // 
            this.quantidade_maximaTextBox.Location = new System.Drawing.Point(612, 86);
            this.quantidade_maximaTextBox.Name = "quantidade_maximaTextBox";
            this.quantidade_maximaTextBox.ReadOnly = true;
            this.quantidade_maximaTextBox.Size = new System.Drawing.Size(142, 27);
            this.quantidade_maximaTextBox.TabIndex = 75;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCadastrarMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1000, 594);
            this.Controls.Add(this.medicamentoDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarMedicamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Medicamento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastrarMedicamento_FormClosed);
            this.Load += new System.EventHandler(this.frmCadastrarMedicamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.DataGridView medicamentoDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox codMedicamentoTextBox;
        private System.Windows.Forms.TextBox nome_comercialTextBox;
        private System.Windows.Forms.TextBox nome_genericoTextBox;
        private System.Windows.Forms.DateTimePicker data_validadeDateTimePicker;
        private System.Windows.Forms.TextBox quantidade_entradaTextBox;
        private System.Windows.Forms.TextBox quantidade_actualTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox quantidade_inicialTextBox;
        private System.Windows.Forms.TextBox quantidade_minimaTextBox;
        private System.Windows.Forms.TextBox quantidade_maximaTextBox;
        private System.Windows.Forms.ComboBox cbCodFornecedor;
        private db_HospitalDataSet db_HospitalDataSet;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private db_HospitalDataSetTableAdapters.FornecedorTableAdapter fornecedorTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
    }
}