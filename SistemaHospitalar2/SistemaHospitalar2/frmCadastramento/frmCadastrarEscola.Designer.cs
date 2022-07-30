namespace SistemaHospitalar2
{
    partial class frmCadastrarEscola
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
            System.Windows.Forms.Label codEscolaLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label nIFLabel;
            System.Windows.Forms.Label telefone_escolaLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.escolaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_HospitalDataSet = new SistemaHospitalar2.db_HospitalDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.escolaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeescolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIFescolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneescolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoescolaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.telefone_escolaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.codEscolaTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.nIFTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscarNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.escolaTableAdapter = new SistemaHospitalar2.db_HospitalDataSetTableAdapters.EscolaTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableAdapterManager = new SistemaHospitalar2.db_HospitalDataSetTableAdapters.TableAdapterManager();
            codEscolaLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            nIFLabel = new System.Windows.Forms.Label();
            telefone_escolaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.escolaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.escolaDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // codEscolaLabel
            // 
            codEscolaLabel.AutoSize = true;
            codEscolaLabel.Location = new System.Drawing.Point(15, 23);
            codEscolaLabel.Name = "codEscolaLabel";
            codEscolaLabel.Size = new System.Drawing.Size(64, 18);
            codEscolaLabel.TabIndex = 66;
            codEscolaLabel.Text = "Código";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(15, 56);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(62, 18);
            nomeLabel.TabIndex = 68;
            nomeLabel.Text = "Nome:";
            // 
            // nIFLabel
            // 
            nIFLabel.AutoSize = true;
            nIFLabel.Location = new System.Drawing.Point(15, 89);
            nIFLabel.Name = "nIFLabel";
            nIFLabel.Size = new System.Drawing.Size(43, 18);
            nIFLabel.TabIndex = 70;
            nIFLabel.Text = "NIF:";
            // 
            // telefone_escolaLabel
            // 
            telefone_escolaLabel.AutoSize = true;
            telefone_escolaLabel.Location = new System.Drawing.Point(15, 122);
            telefone_escolaLabel.Name = "telefone_escolaLabel";
            telefone_escolaLabel.Size = new System.Drawing.Size(111, 18);
            telefone_escolaLabel.TabIndex = 73;
            telefone_escolaLabel.Text = "Nº Telefone:";
            // 
            // escolaBindingSource
            // 
            this.escolaBindingSource.DataMember = "Escola";
            this.escolaBindingSource.DataSource = this.db_HospitalDataSet;
            // 
            // db_HospitalDataSet
            // 
            this.db_HospitalDataSet.DataSetName = "db_HospitalDataSet";
            this.db_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblLogin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 126);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(152, 47);
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
            this.lblLogin.Location = new System.Drawing.Point(480, 89);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(183, 23);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Cadastrar Escola";
            // 
            // escolaDataGridView
            // 
            this.escolaDataGridView.AllowUserToAddRows = false;
            this.escolaDataGridView.AllowUserToDeleteRows = false;
            this.escolaDataGridView.AutoGenerateColumns = false;
            this.escolaDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.escolaDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.escolaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.escolaDataGridView.ColumnHeadersHeight = 30;
            this.escolaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nomeescolaDataGridViewTextBoxColumn,
            this.nIFescolaDataGridViewTextBoxColumn,
            this.telefoneescolaDataGridViewTextBoxColumn,
            this.enderecoescolaDataGridViewTextBoxColumn});
            this.escolaDataGridView.DataSource = this.escolaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.escolaDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.escolaDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.escolaDataGridView.Location = new System.Drawing.Point(0, 126);
            this.escolaDataGridView.Name = "escolaDataGridView";
            this.escolaDataGridView.ReadOnly = true;
            this.escolaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.escolaDataGridView.Size = new System.Drawing.Size(694, 213);
            this.escolaDataGridView.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "codEscola";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nomeescolaDataGridViewTextBoxColumn
            // 
            this.nomeescolaDataGridViewTextBoxColumn.DataPropertyName = "nome_escola";
            this.nomeescolaDataGridViewTextBoxColumn.HeaderText = "Nome Escola";
            this.nomeescolaDataGridViewTextBoxColumn.Name = "nomeescolaDataGridViewTextBoxColumn";
            this.nomeescolaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeescolaDataGridViewTextBoxColumn.Width = 280;
            // 
            // nIFescolaDataGridViewTextBoxColumn
            // 
            this.nIFescolaDataGridViewTextBoxColumn.DataPropertyName = "NIF_escola";
            this.nIFescolaDataGridViewTextBoxColumn.HeaderText = "NIF da Escola";
            this.nIFescolaDataGridViewTextBoxColumn.Name = "nIFescolaDataGridViewTextBoxColumn";
            this.nIFescolaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nIFescolaDataGridViewTextBoxColumn.Width = 150;
            // 
            // telefoneescolaDataGridViewTextBoxColumn
            // 
            this.telefoneescolaDataGridViewTextBoxColumn.DataPropertyName = "telefone_escola";
            this.telefoneescolaDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneescolaDataGridViewTextBoxColumn.Name = "telefoneescolaDataGridViewTextBoxColumn";
            this.telefoneescolaDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneescolaDataGridViewTextBoxColumn.Width = 110;
            // 
            // enderecoescolaDataGridViewTextBoxColumn
            // 
            this.enderecoescolaDataGridViewTextBoxColumn.DataPropertyName = "endereco_escola";
            this.enderecoescolaDataGridViewTextBoxColumn.HeaderText = "Endereço";
            this.enderecoescolaDataGridViewTextBoxColumn.Name = "enderecoescolaDataGridViewTextBoxColumn";
            this.enderecoescolaDataGridViewTextBoxColumn.ReadOnly = true;
            this.enderecoescolaDataGridViewTextBoxColumn.Width = 120;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.telefone_escolaTextBox);
            this.groupBox2.Controls.Add(this.lblEndereco);
            this.groupBox2.Controls.Add(telefone_escolaLabel);
            this.groupBox2.Controls.Add(codEscolaLabel);
            this.groupBox2.Controls.Add(this.codEscolaTextBox);
            this.groupBox2.Controls.Add(nomeLabel);
            this.groupBox2.Controls.Add(this.nomeTextBox);
            this.groupBox2.Controls.Add(nIFLabel);
            this.groupBox2.Controls.Add(this.nIFTextBox);
            this.groupBox2.Controls.Add(this.enderecoTextBox);
            this.groupBox2.Controls.Add(this.btnNovo);
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnSair);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(694, 274);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // telefone_escolaTextBox
            // 
            this.telefone_escolaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.escolaBindingSource, "telefone_escola", true));
            this.telefone_escolaTextBox.Location = new System.Drawing.Point(132, 119);
            this.telefone_escolaTextBox.Mask = "900000000";
            this.telefone_escolaTextBox.Name = "telefone_escolaTextBox";
            this.telefone_escolaTextBox.Size = new System.Drawing.Size(268, 27);
            this.telefone_escolaTextBox.TabIndex = 76;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(15, 152);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(89, 18);
            this.lblEndereco.TabIndex = 75;
            this.lblEndereco.Text = "Endereço:";
            // 
            // codEscolaTextBox
            // 
            this.codEscolaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.escolaBindingSource, "codEscola", true));
            this.codEscolaTextBox.Location = new System.Drawing.Point(85, 20);
            this.codEscolaTextBox.Name = "codEscolaTextBox";
            this.codEscolaTextBox.ReadOnly = true;
            this.codEscolaTextBox.Size = new System.Drawing.Size(188, 27);
            this.codEscolaTextBox.TabIndex = 67;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.escolaBindingSource, "nome_escola", true));
            this.nomeTextBox.Location = new System.Drawing.Point(85, 53);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.ReadOnly = true;
            this.nomeTextBox.Size = new System.Drawing.Size(315, 27);
            this.nomeTextBox.TabIndex = 69;
            // 
            // nIFTextBox
            // 
            this.nIFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.escolaBindingSource, "NIF_escola", true));
            this.nIFTextBox.Location = new System.Drawing.Point(85, 86);
            this.nIFTextBox.Name = "nIFTextBox";
            this.nIFTextBox.ReadOnly = true;
            this.nIFTextBox.Size = new System.Drawing.Size(315, 27);
            this.nIFTextBox.TabIndex = 71;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.escolaBindingSource, "endereco_escola", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(110, 152);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.ReadOnly = true;
            this.enderecoTextBox.Size = new System.Drawing.Size(290, 27);
            this.enderecoTextBox.TabIndex = 73;
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.fb1;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.Location = new System.Drawing.Point(410, 20);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(81, 50);
            this.btnNovo.TabIndex = 66;
            this.toolTip1.SetToolTip(this.btnNovo, "Novo");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.xde1;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.Location = new System.Drawing.Point(500, 73);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(81, 50);
            this.btnSalvar.TabIndex = 57;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.exe1;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.Location = new System.Drawing.Point(410, 73);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(81, 50);
            this.btnExcluir.TabIndex = 56;
            this.toolTip1.SetToolTip(this.btnExcluir, "Eliminar");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.edre1;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Location = new System.Drawing.Point(500, 20);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(81, 50);
            this.btnEditar.TabIndex = 55;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.ex3;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Location = new System.Drawing.Point(593, 20);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(64, 103);
            this.btnSair.TabIndex = 32;
            this.toolTip1.SetToolTip(this.btnSair, "Fechar");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnActualizar);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.txtBuscarCodigo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtBuscarNome);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(406, 138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 129);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consultar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(143, 49);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(98, 30);
            this.btnActualizar.TabIndex = 14;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(93, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 30);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "OK";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(15, 50);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(74, 27);
            this.txtBuscarCodigo.TabIndex = 12;
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
            this.txtBuscarNome.Size = new System.Drawing.Size(234, 27);
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
            // escolaTableAdapter
            // 
            this.escolaTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Ala_HospitalarTableAdapter = null;
            this.tableAdapterManager.Alta_Paciente_InternadoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EscolaTableAdapter = this.escolaTableAdapter;
            this.tableAdapterManager.Especialidade_MedicoTableAdapter = null;
            this.tableAdapterManager.EstagiarioTableAdapter = null;
            this.tableAdapterManager.ExameTableAdapter = null;
            this.tableAdapterManager.FornecedorTableAdapter = null;
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
            // frmCadastrarEscola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(694, 613);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.escolaDataGridView);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarEscola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Escola";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastrarEscola_FormClosed);
            this.Load += new System.EventHandler(this.frmCadastrarEsola_Load);
            ((System.ComponentModel.ISupportInitialize)(this.escolaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.escolaDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.DataGridView escolaDataGridView;
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
        private System.Windows.Forms.TextBox codEscolaTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox nIFTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private db_HospitalDataSet db_HospitalDataSet;
        private System.Windows.Forms.BindingSource escolaBindingSource;
        private db_HospitalDataSetTableAdapters.EscolaTableAdapter escolaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeescolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFescolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneescolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoescolaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox telefone_escolaTextBox;
        private db_HospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}