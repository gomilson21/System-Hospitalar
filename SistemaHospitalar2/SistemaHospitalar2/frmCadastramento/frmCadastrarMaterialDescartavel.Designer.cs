namespace SistemaHospitalar2
{
    partial class frmCadastrarMaterialDescartavel
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
            System.Windows.Forms.Label codMatrial_descartavelLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label data_validadeLabel;
            System.Windows.Forms.Label codFornecedorLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label quantidade_entradaLabel;
            System.Windows.Forms.Label quantidade_actualLabel;
            System.Windows.Forms.Label quantidade_inicialLabel;
            System.Windows.Forms.Label quantidade_maximaLabel;
            System.Windows.Forms.Label quantidade_minimaLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarMaterialDescartavel));
            this.matDescartavelDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_HospitalDataSet = new SistemaHospitalar2.db_HospitalDataSet();
            this.codMatrial_descartavelTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.data_validadeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.quantidade_entradaTextBox = new System.Windows.Forms.TextBox();
            this.quantidade_actualTextBox = new System.Windows.Forms.TextBox();
            this.quantidade_inicialTextBox = new System.Windows.Forms.TextBox();
            this.quantidade_maximaTextBox = new System.Windows.Forms.TextBox();
            this.quantidade_minimaTextBox = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscarNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fornecedorTableAdapter = new SistemaHospitalar2.db_HospitalDataSetTableAdapters.FornecedorTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            codMatrial_descartavelLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            data_validadeLabel = new System.Windows.Forms.Label();
            codFornecedorLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            quantidade_entradaLabel = new System.Windows.Forms.Label();
            quantidade_actualLabel = new System.Windows.Forms.Label();
            quantidade_inicialLabel = new System.Windows.Forms.Label();
            quantidade_maximaLabel = new System.Windows.Forms.Label();
            quantidade_minimaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.matDescartavelDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // codMatrial_descartavelLabel
            // 
            codMatrial_descartavelLabel.AutoSize = true;
            codMatrial_descartavelLabel.Location = new System.Drawing.Point(10, 27);
            codMatrial_descartavelLabel.Name = "codMatrial_descartavelLabel";
            codMatrial_descartavelLabel.Size = new System.Drawing.Size(71, 18);
            codMatrial_descartavelLabel.TabIndex = 44;
            codMatrial_descartavelLabel.Text = "Código:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(10, 60);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(62, 18);
            nomeLabel.TabIndex = 46;
            nomeLabel.Text = "Nome:";
            // 
            // data_validadeLabel
            // 
            data_validadeLabel.AutoSize = true;
            data_validadeLabel.Location = new System.Drawing.Point(10, 94);
            data_validadeLabel.Name = "data_validadeLabel";
            data_validadeLabel.Size = new System.Drawing.Size(130, 18);
            data_validadeLabel.TabIndex = 48;
            data_validadeLabel.Text = "Data Validade:";
            // 
            // codFornecedorLabel
            // 
            codFornecedorLabel.AutoSize = true;
            codFornecedorLabel.Location = new System.Drawing.Point(10, 126);
            codFornecedorLabel.Name = "codFornecedorLabel";
            codFornecedorLabel.Size = new System.Drawing.Size(104, 18);
            codFornecedorLabel.TabIndex = 50;
            codFornecedorLabel.Text = "Fornecedor:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(10, 176);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(93, 18);
            descricaoLabel.TabIndex = 52;
            descricaoLabel.Text = "Descrição:";
            // 
            // quantidade_entradaLabel
            // 
            quantidade_entradaLabel.AutoSize = true;
            quantidade_entradaLabel.Location = new System.Drawing.Point(383, 60);
            quantidade_entradaLabel.Name = "quantidade_entradaLabel";
            quantidade_entradaLabel.Size = new System.Drawing.Size(179, 18);
            quantidade_entradaLabel.TabIndex = 54;
            quantidade_entradaLabel.Text = "Quantidade Entrada:";
            // 
            // quantidade_actualLabel
            // 
            quantidade_actualLabel.AutoSize = true;
            quantidade_actualLabel.Location = new System.Drawing.Point(384, 159);
            quantidade_actualLabel.Name = "quantidade_actualLabel";
            quantidade_actualLabel.Size = new System.Drawing.Size(167, 18);
            quantidade_actualLabel.TabIndex = 56;
            quantidade_actualLabel.Text = "Quantidade Actual:";
            // 
            // quantidade_inicialLabel
            // 
            quantidade_inicialLabel.AutoSize = true;
            quantidade_inicialLabel.Location = new System.Drawing.Point(383, 27);
            quantidade_inicialLabel.Name = "quantidade_inicialLabel";
            quantidade_inicialLabel.Size = new System.Drawing.Size(166, 18);
            quantidade_inicialLabel.TabIndex = 58;
            quantidade_inicialLabel.Text = "Quantidade Inicial:";
            // 
            // quantidade_maximaLabel
            // 
            quantidade_maximaLabel.AutoSize = true;
            quantidade_maximaLabel.Location = new System.Drawing.Point(384, 126);
            quantidade_maximaLabel.Name = "quantidade_maximaLabel";
            quantidade_maximaLabel.Size = new System.Drawing.Size(178, 18);
            quantidade_maximaLabel.TabIndex = 60;
            quantidade_maximaLabel.Text = "Quantidade Máxima:";
            // 
            // quantidade_minimaLabel
            // 
            quantidade_minimaLabel.AutoSize = true;
            quantidade_minimaLabel.Location = new System.Drawing.Point(383, 93);
            quantidade_minimaLabel.Name = "quantidade_minimaLabel";
            quantidade_minimaLabel.Size = new System.Drawing.Size(174, 18);
            quantidade_minimaLabel.TabIndex = 62;
            quantidade_minimaLabel.Text = "Quantidade Mínima:";
            // 
            // matDescartavelDataGridView
            // 
            this.matDescartavelDataGridView.AllowUserToAddRows = false;
            this.matDescartavelDataGridView.AllowUserToDeleteRows = false;
            this.matDescartavelDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.matDescartavelDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.matDescartavelDataGridView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.matDescartavelDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.matDescartavelDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.matDescartavelDataGridView.Location = new System.Drawing.Point(0, 126);
            this.matDescartavelDataGridView.Name = "matDescartavelDataGridView";
            this.matDescartavelDataGridView.ReadOnly = true;
            this.matDescartavelDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.matDescartavelDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matDescartavelDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.matDescartavelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.matDescartavelDataGridView.Size = new System.Drawing.Size(941, 200);
            this.matDescartavelDataGridView.TabIndex = 31;
            this.matDescartavelDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.matDescartavelDataGridView_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbFornecedor);
            this.groupBox2.Controls.Add(codMatrial_descartavelLabel);
            this.groupBox2.Controls.Add(this.codMatrial_descartavelTextBox);
            this.groupBox2.Controls.Add(nomeLabel);
            this.groupBox2.Controls.Add(this.nomeTextBox);
            this.groupBox2.Controls.Add(data_validadeLabel);
            this.groupBox2.Controls.Add(this.data_validadeDateTimePicker);
            this.groupBox2.Controls.Add(codFornecedorLabel);
            this.groupBox2.Controls.Add(descricaoLabel);
            this.groupBox2.Controls.Add(this.descricaoTextBox);
            this.groupBox2.Controls.Add(quantidade_entradaLabel);
            this.groupBox2.Controls.Add(this.quantidade_entradaTextBox);
            this.groupBox2.Controls.Add(quantidade_actualLabel);
            this.groupBox2.Controls.Add(this.quantidade_actualTextBox);
            this.groupBox2.Controls.Add(quantidade_inicialLabel);
            this.groupBox2.Controls.Add(this.quantidade_inicialTextBox);
            this.groupBox2.Controls.Add(quantidade_maximaLabel);
            this.groupBox2.Controls.Add(this.quantidade_maximaTextBox);
            this.groupBox2.Controls.Add(quantidade_minimaLabel);
            this.groupBox2.Controls.Add(this.quantidade_minimaTextBox);
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnSair);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnNovo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(941, 274);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fornecedorBindingSource, "codFornecedor", true));
            this.cbFornecedor.DataSource = this.fornecedorBindingSource;
            this.cbFornecedor.DisplayMember = "nome_fornecedor";
            this.cbFornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(120, 123);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(251, 26);
            this.cbFornecedor.TabIndex = 49;
            this.cbFornecedor.ValueMember = "codFornecedor";
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
            // codMatrial_descartavelTextBox
            // 
            this.codMatrial_descartavelTextBox.Location = new System.Drawing.Point(100, 24);
            this.codMatrial_descartavelTextBox.Name = "codMatrial_descartavelTextBox";
            this.codMatrial_descartavelTextBox.ReadOnly = true;
            this.codMatrial_descartavelTextBox.Size = new System.Drawing.Size(186, 27);
            this.codMatrial_descartavelTextBox.TabIndex = 45;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(100, 57);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.ReadOnly = true;
            this.nomeTextBox.Size = new System.Drawing.Size(271, 27);
            this.nomeTextBox.TabIndex = 48;
            // 
            // data_validadeDateTimePicker
            // 
            this.data_validadeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_validadeDateTimePicker.Location = new System.Drawing.Point(143, 90);
            this.data_validadeDateTimePicker.Name = "data_validadeDateTimePicker";
            this.data_validadeDateTimePicker.Size = new System.Drawing.Size(228, 27);
            this.data_validadeDateTimePicker.TabIndex = 49;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(109, 156);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.ReadOnly = true;
            this.descricaoTextBox.Size = new System.Drawing.Size(262, 83);
            this.descricaoTextBox.TabIndex = 54;
            // 
            // quantidade_entradaTextBox
            // 
            this.quantidade_entradaTextBox.Location = new System.Drawing.Point(566, 57);
            this.quantidade_entradaTextBox.Name = "quantidade_entradaTextBox";
            this.quantidade_entradaTextBox.ReadOnly = true;
            this.quantidade_entradaTextBox.Size = new System.Drawing.Size(127, 27);
            this.quantidade_entradaTextBox.TabIndex = 50;
            // 
            // quantidade_actualTextBox
            // 
            this.quantidade_actualTextBox.Location = new System.Drawing.Point(564, 156);
            this.quantidade_actualTextBox.Name = "quantidade_actualTextBox";
            this.quantidade_actualTextBox.ReadOnly = true;
            this.quantidade_actualTextBox.Size = new System.Drawing.Size(127, 27);
            this.quantidade_actualTextBox.TabIndex = 57;
            // 
            // quantidade_inicialTextBox
            // 
            this.quantidade_inicialTextBox.Location = new System.Drawing.Point(563, 24);
            this.quantidade_inicialTextBox.Name = "quantidade_inicialTextBox";
            this.quantidade_inicialTextBox.ReadOnly = true;
            this.quantidade_inicialTextBox.Size = new System.Drawing.Size(127, 27);
            this.quantidade_inicialTextBox.TabIndex = 51;
            // 
            // quantidade_maximaTextBox
            // 
            this.quantidade_maximaTextBox.Location = new System.Drawing.Point(564, 123);
            this.quantidade_maximaTextBox.Name = "quantidade_maximaTextBox";
            this.quantidade_maximaTextBox.ReadOnly = true;
            this.quantidade_maximaTextBox.Size = new System.Drawing.Size(127, 27);
            this.quantidade_maximaTextBox.TabIndex = 53;
            // 
            // quantidade_minimaTextBox
            // 
            this.quantidade_minimaTextBox.Location = new System.Drawing.Point(563, 90);
            this.quantidade_minimaTextBox.Name = "quantidade_minimaTextBox";
            this.quantidade_minimaTextBox.ReadOnly = true;
            this.quantidade_minimaTextBox.Size = new System.Drawing.Size(127, 27);
            this.quantidade_minimaTextBox.TabIndex = 52;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.xde1;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.Location = new System.Drawing.Point(789, 74);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(81, 50);
            this.btnSalvar.TabIndex = 44;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.exe1;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.Location = new System.Drawing.Point(699, 74);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(81, 50);
            this.btnExcluir.TabIndex = 43;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.edre3;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Location = new System.Drawing.Point(789, 21);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(81, 50);
            this.btnEditar.TabIndex = 42;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.ex4;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Location = new System.Drawing.Point(877, 21);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(63, 103);
            this.btnSair.TabIndex = 32;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnActualizar);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtBuscarNome);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtBuscarCodigo);
            this.groupBox3.Location = new System.Drawing.Point(700, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 129);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consultar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(130, 46);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(101, 30);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(82, 46);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 30);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "OK";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.txtBuscarNome.Size = new System.Drawing.Size(217, 27);
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
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(12, 46);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(68, 27);
            this.txtBuscarCodigo.TabIndex = 0;
            this.txtBuscarCodigo.TextChanged += new System.EventHandler(this.txtBuscarCodigo_TextChanged);
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.fb;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.Location = new System.Drawing.Point(699, 21);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(81, 50);
            this.btnNovo.TabIndex = 27;
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
            this.groupBox1.Size = new System.Drawing.Size(941, 126);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(319, 54);
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
            this.lblLogin.Location = new System.Drawing.Point(619, 85);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(326, 23);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Cadastrar Material Descartável";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCadastrarMaterialDescartavel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(941, 602);
            this.Controls.Add(this.matDescartavelDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCadastrarMaterialDescartavel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Material Descartável";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastrarMaterialDescartavel_FormClosed);
            this.Load += new System.EventHandler(this.frmCadastrarMaterialDescartavel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.matDescartavelDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView matDescartavelDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox codMatrial_descartavelTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.DateTimePicker data_validadeDateTimePicker;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox quantidade_entradaTextBox;
        private System.Windows.Forms.TextBox quantidade_actualTextBox;
        private System.Windows.Forms.TextBox quantidade_inicialTextBox;
        private System.Windows.Forms.TextBox quantidade_maximaTextBox;
        private System.Windows.Forms.TextBox quantidade_minimaTextBox;
        private System.Windows.Forms.ComboBox cbFornecedor;
        private System.Windows.Forms.ToolTip toolTip1;
        private db_HospitalDataSet db_HospitalDataSet;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private db_HospitalDataSetTableAdapters.FornecedorTableAdapter fornecedorTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
    }
}