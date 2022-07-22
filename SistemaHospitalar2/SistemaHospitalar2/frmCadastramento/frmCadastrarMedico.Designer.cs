namespace SistemaHospitalar2
{
    partial class frmCadastrarMedico
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
            System.Windows.Forms.Label codEspecialidadeLabel;
            System.Windows.Forms.Label data_admissaoLabel;
            System.Windows.Forms.Label numero_carteiraLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label bILabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label codMedicoLabel;
            System.Windows.Forms.Label data_nascimentoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.medicoDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscarNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.data_admissaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.numero_carteiraTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.codMedicoTextBox = new System.Windows.Forms.TextBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.cbEspecialidade = new System.Windows.Forms.ComboBox();
            this.especialidadeMedicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_HospitalDataSet = new SistemaHospitalar2.db_HospitalDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.data_nascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.especialidade_MedicoTableAdapter = new SistemaHospitalar2.db_HospitalDataSetTableAdapters.Especialidade_MedicoTableAdapter();
            this.bITextBox = new System.Windows.Forms.MaskedTextBox();
            this.telefoneTextBox = new System.Windows.Forms.MaskedTextBox();
            codEspecialidadeLabel = new System.Windows.Forms.Label();
            data_admissaoLabel = new System.Windows.Forms.Label();
            numero_carteiraLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            bILabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            codMedicoLabel = new System.Windows.Forms.Label();
            data_nascimentoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicoDataGridView)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadeMedicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // codEspecialidadeLabel
            // 
            codEspecialidadeLabel.AutoSize = true;
            codEspecialidadeLabel.Location = new System.Drawing.Point(382, 155);
            codEspecialidadeLabel.Name = "codEspecialidadeLabel";
            codEspecialidadeLabel.Size = new System.Drawing.Size(127, 18);
            codEspecialidadeLabel.TabIndex = 54;
            codEspecialidadeLabel.Text = "Especialidade:";
            // 
            // data_admissaoLabel
            // 
            data_admissaoLabel.AutoSize = true;
            data_admissaoLabel.Location = new System.Drawing.Point(380, 129);
            data_admissaoLabel.Name = "data_admissaoLabel";
            data_admissaoLabel.Size = new System.Drawing.Size(139, 18);
            data_admissaoLabel.TabIndex = 52;
            data_admissaoLabel.Text = "Data Admissão:";
            // 
            // numero_carteiraLabel
            // 
            numero_carteiraLabel.AutoSize = true;
            numero_carteiraLabel.Location = new System.Drawing.Point(9, 192);
            numero_carteiraLabel.Name = "numero_carteiraLabel";
            numero_carteiraLabel.Size = new System.Drawing.Size(149, 18);
            numero_carteiraLabel.TabIndex = 50;
            numero_carteiraLabel.Text = "Número Carteira:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(12, 159);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(60, 18);
            emailLabel.TabIndex = 48;
            emailLabel.Text = "Email:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(380, 95);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(89, 18);
            enderecoLabel.TabIndex = 44;
            enderecoLabel.Text = "Endereço:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(380, 62);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(84, 18);
            telefoneLabel.TabIndex = 42;
            telefoneLabel.Text = "Telefone:";
            // 
            // bILabel
            // 
            bILabel.AutoSize = true;
            bILabel.Location = new System.Drawing.Point(6, 132);
            bILabel.Name = "bILabel";
            bILabel.Size = new System.Drawing.Size(128, 18);
            bILabel.TabIndex = 40;
            bILabel.Text = "Número do BI:";
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(380, 29);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(54, 18);
            sexoLabel.TabIndex = 38;
            sexoLabel.Text = "Sexo:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(8, 56);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(62, 18);
            nomeLabel.TabIndex = 34;
            nomeLabel.Text = "Nome:";
            // 
            // codMedicoLabel
            // 
            codMedicoLabel.AutoSize = true;
            codMedicoLabel.Location = new System.Drawing.Point(8, 23);
            codMedicoLabel.Name = "codMedicoLabel";
            codMedicoLabel.Size = new System.Drawing.Size(71, 18);
            codMedicoLabel.TabIndex = 32;
            codMedicoLabel.Text = "Código:";
            // 
            // data_nascimentoLabel
            // 
            data_nascimentoLabel.AutoSize = true;
            data_nascimentoLabel.Location = new System.Drawing.Point(6, 95);
            data_nascimentoLabel.Name = "data_nascimentoLabel";
            data_nascimentoLabel.Size = new System.Drawing.Size(182, 18);
            data_nascimentoLabel.TabIndex = 60;
            data_nascimentoLabel.Text = "Data de Nascimento:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblLogin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(322, 53);
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
            this.lblLogin.Location = new System.Drawing.Point(780, 87);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(187, 23);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Cadastrar Médico";
            // 
            // medicoDataGridView
            // 
            this.medicoDataGridView.AllowUserToAddRows = false;
            this.medicoDataGridView.AllowUserToDeleteRows = false;
            this.medicoDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.medicoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.medicoDataGridView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.medicoDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.medicoDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.medicoDataGridView.Location = new System.Drawing.Point(0, 126);
            this.medicoDataGridView.Name = "medicoDataGridView";
            this.medicoDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.medicoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicoDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.medicoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.medicoDataGridView.Size = new System.Drawing.Size(954, 220);
            this.medicoDataGridView.TabIndex = 27;
            this.medicoDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.medicoDataGridView_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnActualizar);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.txtBuscarCodigo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtBuscarNome);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(720, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(234, 129);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consultar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(127, 49);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(98, 30);
            this.btnActualizar.TabIndex = 26;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(78, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 30);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "OK";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(13, 50);
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
            this.txtBuscarNome.Size = new System.Drawing.Size(220, 27);
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
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.ex1;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Location = new System.Drawing.Point(901, 14);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(56, 103);
            this.btnSair.TabIndex = 32;
            this.toolTip1.SetToolTip(this.btnSair, "Fechar");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // data_admissaoDateTimePicker
            // 
            this.data_admissaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_admissaoDateTimePicker.Location = new System.Drawing.Point(522, 123);
            this.data_admissaoDateTimePicker.Name = "data_admissaoDateTimePicker";
            this.data_admissaoDateTimePicker.Size = new System.Drawing.Size(190, 27);
            this.data_admissaoDateTimePicker.TabIndex = 44;
            // 
            // numero_carteiraTextBox
            // 
            this.numero_carteiraTextBox.Location = new System.Drawing.Point(154, 189);
            this.numero_carteiraTextBox.MaxLength = 35;
            this.numero_carteiraTextBox.Name = "numero_carteiraTextBox";
            this.numero_carteiraTextBox.ReadOnly = true;
            this.numero_carteiraTextBox.Size = new System.Drawing.Size(222, 27);
            this.numero_carteiraTextBox.TabIndex = 39;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(92, 156);
            this.emailTextBox.MaxLength = 75;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(284, 27);
            this.emailTextBox.TabIndex = 38;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.Location = new System.Drawing.Point(475, 90);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.ReadOnly = true;
            this.enderecoTextBox.Size = new System.Drawing.Size(237, 27);
            this.enderecoTextBox.TabIndex = 42;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(90, 53);
            this.nomeTextBox.MaxLength = 75;
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.ReadOnly = true;
            this.nomeTextBox.Size = new System.Drawing.Size(284, 27);
            this.nomeTextBox.TabIndex = 35;
            // 
            // codMedicoTextBox
            // 
            this.codMedicoTextBox.Location = new System.Drawing.Point(90, 20);
            this.codMedicoTextBox.Name = "codMedicoTextBox";
            this.codMedicoTextBox.ReadOnly = true;
            this.codMedicoTextBox.Size = new System.Drawing.Size(226, 27);
            this.codMedicoTextBox.TabIndex = 33;
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbSexo.Location = new System.Drawing.Point(475, 21);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(121, 26);
            this.cbSexo.TabIndex = 40;
            // 
            // cbEspecialidade
            // 
            this.cbEspecialidade.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.especialidadeMedicoBindingSource, "codEspecialidade", true));
            this.cbEspecialidade.DataSource = this.especialidadeMedicoBindingSource;
            this.cbEspecialidade.DisplayMember = "nome_especialidade";
            this.cbEspecialidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspecialidade.FormattingEnabled = true;
            this.cbEspecialidade.Location = new System.Drawing.Point(524, 156);
            this.cbEspecialidade.Name = "cbEspecialidade";
            this.cbEspecialidade.Size = new System.Drawing.Size(190, 26);
            this.cbEspecialidade.TabIndex = 45;
            this.cbEspecialidade.ValueMember = "codEspecialidade";
            // 
            // especialidadeMedicoBindingSource
            // 
            this.especialidadeMedicoBindingSource.DataMember = "Especialidade_Medico";
            this.especialidadeMedicoBindingSource.DataSource = this.db_HospitalDataSet;
            // 
            // db_HospitalDataSet
            // 
            this.db_HospitalDataSet.DataSetName = "db_HospitalDataSet";
            this.db_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bITextBox);
            this.groupBox2.Controls.Add(this.telefoneTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(data_nascimentoLabel);
            this.groupBox2.Controls.Add(this.data_nascimentoDateTimePicker);
            this.groupBox2.Controls.Add(this.btnNovo);
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.cbEspecialidade);
            this.groupBox2.Controls.Add(this.cbSexo);
            this.groupBox2.Controls.Add(codMedicoLabel);
            this.groupBox2.Controls.Add(this.codMedicoTextBox);
            this.groupBox2.Controls.Add(nomeLabel);
            this.groupBox2.Controls.Add(this.nomeTextBox);
            this.groupBox2.Controls.Add(sexoLabel);
            this.groupBox2.Controls.Add(bILabel);
            this.groupBox2.Controls.Add(telefoneLabel);
            this.groupBox2.Controls.Add(enderecoLabel);
            this.groupBox2.Controls.Add(this.enderecoTextBox);
            this.groupBox2.Controls.Add(emailLabel);
            this.groupBox2.Controls.Add(this.emailTextBox);
            this.groupBox2.Controls.Add(numero_carteiraLabel);
            this.groupBox2.Controls.Add(this.numero_carteiraTextBox);
            this.groupBox2.Controls.Add(data_admissaoLabel);
            this.groupBox2.Controls.Add(this.data_admissaoDateTimePicker);
            this.groupBox2.Controls.Add(codEspecialidadeLabel);
            this.groupBox2.Controls.Add(this.btnSair);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 352);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(954, 274);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 61;
            this.label4.Text = "label4";
            // 
            // data_nascimentoDateTimePicker
            // 
            this.data_nascimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_nascimentoDateTimePicker.Location = new System.Drawing.Point(194, 90);
            this.data_nascimentoDateTimePicker.Name = "data_nascimentoDateTimePicker";
            this.data_nascimentoDateTimePicker.Size = new System.Drawing.Size(180, 27);
            this.data_nascimentoDateTimePicker.TabIndex = 36;
            this.data_nascimentoDateTimePicker.Value = new System.DateTime(1982, 12, 31, 0, 0, 0, 0);
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.fb1;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.Location = new System.Drawing.Point(724, 14);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(81, 50);
            this.btnNovo.TabIndex = 60;
            this.toolTip1.SetToolTip(this.btnNovo, "Novo");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.xde;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.Location = new System.Drawing.Point(814, 67);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(81, 50);
            this.btnSalvar.TabIndex = 59;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.exe;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.Location = new System.Drawing.Point(724, 67);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(81, 50);
            this.btnExcluir.TabIndex = 58;
            this.toolTip1.SetToolTip(this.btnExcluir, "Eliminar");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.edre;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Location = new System.Drawing.Point(814, 14);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(81, 50);
            this.btnEditar.TabIndex = 57;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // especialidade_MedicoTableAdapter
            // 
            this.especialidade_MedicoTableAdapter.ClearBeforeFill = true;
            // 
            // bITextBox
            // 
            this.bITextBox.Location = new System.Drawing.Point(147, 125);
            this.bITextBox.Mask = "000000000LA000";
            this.bITextBox.Name = "bITextBox";
            this.bITextBox.Size = new System.Drawing.Size(227, 27);
            this.bITextBox.TabIndex = 91;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Location = new System.Drawing.Point(475, 53);
            this.telefoneTextBox.Mask = "900000000";
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(175, 27);
            this.telefoneTextBox.TabIndex = 92;
            // 
            // frmCadastrarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(954, 626);
            this.Controls.Add(this.medicoDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmCadastrarMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Médico";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastrarMedico_FormClosed);
            this.Load += new System.EventHandler(this.frmCadastrarMedico_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicoDataGridView)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadeMedicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DateTimePicker data_admissaoDateTimePicker;
        private System.Windows.Forms.TextBox numero_carteiraTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox codMedicoTextBox;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.ComboBox cbEspecialidade;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DateTimePicker data_nascimentoDateTimePicker;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.DataGridView medicoDataGridView;
        private db_HospitalDataSet db_HospitalDataSet;
        private System.Windows.Forms.BindingSource especialidadeMedicoBindingSource;
        private db_HospitalDataSetTableAdapters.Especialidade_MedicoTableAdapter especialidade_MedicoTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.MaskedTextBox bITextBox;
        private System.Windows.Forms.MaskedTextBox telefoneTextBox;
    }
}