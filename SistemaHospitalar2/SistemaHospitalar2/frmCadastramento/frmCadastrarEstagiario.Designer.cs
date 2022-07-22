namespace SistemaHospitalar2
{
    partial class frmCadastrarEstagiario
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
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label bILabel;
            System.Windows.Forms.Label telefoneLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label licenca_estagioLabel;
            System.Windows.Forms.Label data_admissaoLabel;
            System.Windows.Forms.Label codEscolaLabel;
            System.Windows.Forms.Label data_nascimentoLabel;
            System.Windows.Forms.Label nome_estagiarioLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblcodEstagiario = new System.Windows.Forms.Label();
            this.estagiarioDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.data_nascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.cbEscola = new System.Windows.Forms.ComboBox();
            this.escolaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_HospitalDataSet = new SistemaHospitalar2.db_HospitalDataSet();
            this.codEstagiarioTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.licenca_estagioTextBox = new System.Windows.Forms.TextBox();
            this.data_admissaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscarNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.escolaTableAdapter = new SistemaHospitalar2.db_HospitalDataSetTableAdapters.EscolaTableAdapter();
            this.bITextBox = new System.Windows.Forms.MaskedTextBox();
            this.telefoneTextBox = new System.Windows.Forms.MaskedTextBox();
            sexoLabel = new System.Windows.Forms.Label();
            bILabel = new System.Windows.Forms.Label();
            telefoneLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            licenca_estagioLabel = new System.Windows.Forms.Label();
            data_admissaoLabel = new System.Windows.Forms.Label();
            codEscolaLabel = new System.Windows.Forms.Label();
            data_nascimentoLabel = new System.Windows.Forms.Label();
            nome_estagiarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.estagiarioDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.escolaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(400, 22);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(54, 18);
            sexoLabel.TabIndex = 38;
            sexoLabel.Text = "Sexo:";
            // 
            // bILabel
            // 
            bILabel.AutoSize = true;
            bILabel.Location = new System.Drawing.Point(6, 122);
            bILabel.Name = "bILabel";
            bILabel.Size = new System.Drawing.Size(128, 18);
            bILabel.TabIndex = 40;
            bILabel.Text = "Número do BI:";
            // 
            // telefoneLabel
            // 
            telefoneLabel.AutoSize = true;
            telefoneLabel.Location = new System.Drawing.Point(394, 57);
            telefoneLabel.Name = "telefoneLabel";
            telefoneLabel.Size = new System.Drawing.Size(84, 18);
            telefoneLabel.TabIndex = 42;
            telefoneLabel.Text = "Telefone:";
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(394, 92);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(89, 18);
            enderecoLabel.TabIndex = 44;
            enderecoLabel.Text = "Endereço:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(9, 157);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(60, 18);
            emailLabel.TabIndex = 48;
            emailLabel.Text = "Email:";
            // 
            // licenca_estagioLabel
            // 
            licenca_estagioLabel.AutoSize = true;
            licenca_estagioLabel.Location = new System.Drawing.Point(9, 185);
            licenca_estagioLabel.Name = "licenca_estagioLabel";
            licenca_estagioLabel.Size = new System.Drawing.Size(142, 18);
            licenca_estagioLabel.TabIndex = 50;
            licenca_estagioLabel.Text = "Licença Estagio:";
            // 
            // data_admissaoLabel
            // 
            data_admissaoLabel.AutoSize = true;
            data_admissaoLabel.Location = new System.Drawing.Point(396, 125);
            data_admissaoLabel.Name = "data_admissaoLabel";
            data_admissaoLabel.Size = new System.Drawing.Size(165, 18);
            data_admissaoLabel.TabIndex = 52;
            data_admissaoLabel.Text = "Data de Admissão:";
            // 
            // codEscolaLabel
            // 
            codEscolaLabel.AutoSize = true;
            codEscolaLabel.Location = new System.Drawing.Point(398, 157);
            codEscolaLabel.Name = "codEscolaLabel";
            codEscolaLabel.Size = new System.Drawing.Size(67, 18);
            codEscolaLabel.TabIndex = 54;
            codEscolaLabel.Text = "Escola:";
            // 
            // data_nascimentoLabel
            // 
            data_nascimentoLabel.AutoSize = true;
            data_nascimentoLabel.Location = new System.Drawing.Point(7, 89);
            data_nascimentoLabel.Name = "data_nascimentoLabel";
            data_nascimentoLabel.Size = new System.Drawing.Size(182, 18);
            data_nascimentoLabel.TabIndex = 66;
            data_nascimentoLabel.Text = "Data de Nascimento:";
            // 
            // nome_estagiarioLabel
            // 
            nome_estagiarioLabel.AutoSize = true;
            nome_estagiarioLabel.Location = new System.Drawing.Point(11, 53);
            nome_estagiarioLabel.Name = "nome_estagiarioLabel";
            nome_estagiarioLabel.Size = new System.Drawing.Size(62, 18);
            nome_estagiarioLabel.TabIndex = 66;
            nome_estagiarioLabel.Text = "Nome:";
            // 
            // lblcodEstagiario
            // 
            this.lblcodEstagiario.AutoSize = true;
            this.lblcodEstagiario.Location = new System.Drawing.Point(7, 22);
            this.lblcodEstagiario.Name = "lblcodEstagiario";
            this.lblcodEstagiario.Size = new System.Drawing.Size(71, 18);
            this.lblcodEstagiario.TabIndex = 32;
            this.lblcodEstagiario.Text = "Código:";
            // 
            // estagiarioDataGridView
            // 
            this.estagiarioDataGridView.AllowUserToAddRows = false;
            this.estagiarioDataGridView.AllowUserToDeleteRows = false;
            this.estagiarioDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.estagiarioDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.estagiarioDataGridView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.estagiarioDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.estagiarioDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.estagiarioDataGridView.Location = new System.Drawing.Point(0, 126);
            this.estagiarioDataGridView.Name = "estagiarioDataGridView";
            this.estagiarioDataGridView.ReadOnly = true;
            this.estagiarioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.estagiarioDataGridView.Size = new System.Drawing.Size(969, 200);
            this.estagiarioDataGridView.TabIndex = 34;
            this.estagiarioDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.estagiarioDataGridView_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bITextBox);
            this.groupBox2.Controls.Add(this.telefoneTextBox);
            this.groupBox2.Controls.Add(nome_estagiarioLabel);
            this.groupBox2.Controls.Add(this.nomeTextBox);
            this.groupBox2.Controls.Add(data_nascimentoLabel);
            this.groupBox2.Controls.Add(this.data_nascimentoDateTimePicker);
            this.groupBox2.Controls.Add(this.btnNovo);
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.cbSexo);
            this.groupBox2.Controls.Add(this.cbEscola);
            this.groupBox2.Controls.Add(this.lblcodEstagiario);
            this.groupBox2.Controls.Add(this.codEstagiarioTextBox);
            this.groupBox2.Controls.Add(sexoLabel);
            this.groupBox2.Controls.Add(bILabel);
            this.groupBox2.Controls.Add(telefoneLabel);
            this.groupBox2.Controls.Add(enderecoLabel);
            this.groupBox2.Controls.Add(this.enderecoTextBox);
            this.groupBox2.Controls.Add(emailLabel);
            this.groupBox2.Controls.Add(this.emailTextBox);
            this.groupBox2.Controls.Add(licenca_estagioLabel);
            this.groupBox2.Controls.Add(this.licenca_estagioTextBox);
            this.groupBox2.Controls.Add(data_admissaoLabel);
            this.groupBox2.Controls.Add(this.data_admissaoDateTimePicker);
            this.groupBox2.Controls.Add(codEscolaLabel);
            this.groupBox2.Controls.Add(this.btnSair);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(969, 272);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(87, 50);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.ReadOnly = true;
            this.nomeTextBox.Size = new System.Drawing.Size(300, 27);
            this.nomeTextBox.TabIndex = 67;
            // 
            // data_nascimentoDateTimePicker
            // 
            this.data_nascimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_nascimentoDateTimePicker.Location = new System.Drawing.Point(195, 86);
            this.data_nascimentoDateTimePicker.Name = "data_nascimentoDateTimePicker";
            this.data_nascimentoDateTimePicker.Size = new System.Drawing.Size(189, 27);
            this.data_nascimentoDateTimePicker.TabIndex = 37;
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.fb1;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.Location = new System.Drawing.Point(745, 13);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(81, 50);
            this.btnNovo.TabIndex = 66;
            this.toolTip1.SetToolTip(this.btnNovo, "Novo");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.xde;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.Location = new System.Drawing.Point(835, 69);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(81, 50);
            this.btnSalvar.TabIndex = 60;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.exe;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.Location = new System.Drawing.Point(745, 69);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(81, 50);
            this.btnExcluir.TabIndex = 59;
            this.toolTip1.SetToolTip(this.btnExcluir, "Eliminar");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.edre;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Location = new System.Drawing.Point(835, 16);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(81, 50);
            this.btnEditar.TabIndex = 58;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbSexo.Location = new System.Drawing.Point(484, 22);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(134, 26);
            this.cbSexo.TabIndex = 45;
            // 
            // cbEscola
            // 
            this.cbEscola.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.escolaBindingSource, "codEscola", true));
            this.cbEscola.DataSource = this.escolaBindingSource;
            this.cbEscola.DisplayMember = "nome_escola";
            this.cbEscola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEscola.FormattingEnabled = true;
            this.cbEscola.Location = new System.Drawing.Point(482, 155);
            this.cbEscola.Name = "cbEscola";
            this.cbEscola.Size = new System.Drawing.Size(250, 26);
            this.cbEscola.TabIndex = 53;
            this.cbEscola.ValueMember = "codEscola";
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
            // codEstagiarioTextBox
            // 
            this.codEstagiarioTextBox.Location = new System.Drawing.Point(84, 17);
            this.codEstagiarioTextBox.Name = "codEstagiarioTextBox";
            this.codEstagiarioTextBox.ReadOnly = true;
            this.codEstagiarioTextBox.Size = new System.Drawing.Size(221, 27);
            this.codEstagiarioTextBox.TabIndex = 33;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.Location = new System.Drawing.Point(484, 89);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.ReadOnly = true;
            this.enderecoTextBox.Size = new System.Drawing.Size(250, 27);
            this.enderecoTextBox.TabIndex = 49;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(87, 149);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(297, 27);
            this.emailTextBox.TabIndex = 41;
            // 
            // licenca_estagioTextBox
            // 
            this.licenca_estagioTextBox.Location = new System.Drawing.Point(157, 182);
            this.licenca_estagioTextBox.Name = "licenca_estagioTextBox";
            this.licenca_estagioTextBox.ReadOnly = true;
            this.licenca_estagioTextBox.Size = new System.Drawing.Size(227, 27);
            this.licenca_estagioTextBox.TabIndex = 43;
            // 
            // data_admissaoDateTimePicker
            // 
            this.data_admissaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_admissaoDateTimePicker.Location = new System.Drawing.Point(567, 122);
            this.data_admissaoDateTimePicker.Name = "data_admissaoDateTimePicker";
            this.data_admissaoDateTimePicker.Size = new System.Drawing.Size(165, 27);
            this.data_admissaoDateTimePicker.TabIndex = 51;
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.ex1;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Location = new System.Drawing.Point(920, 16);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(49, 103);
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
            this.groupBox3.Location = new System.Drawing.Point(745, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 129);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consultar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(126, 49);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(98, 30);
            this.btnActualizar.TabIndex = 20;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(77, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 30);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.Text = "OK";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(12, 50);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(62, 27);
            this.txtBuscarCodigo.TabIndex = 18;
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
            this.txtBuscarNome.Size = new System.Drawing.Size(211, 27);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblLogin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(969, 126);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(359, 51);
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
            this.lblLogin.Location = new System.Drawing.Point(754, 89);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(223, 23);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Cadastrar Estagiario";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // escolaTableAdapter
            // 
            this.escolaTableAdapter.ClearBeforeFill = true;
            // 
            // bITextBox
            // 
            this.bITextBox.Location = new System.Drawing.Point(157, 117);
            this.bITextBox.Mask = "000000000LA000";
            this.bITextBox.Name = "bITextBox";
            this.bITextBox.Size = new System.Drawing.Size(227, 27);
            this.bITextBox.TabIndex = 79;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Location = new System.Drawing.Point(484, 57);
            this.telefoneTextBox.Mask = "900000000";
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(175, 27);
            this.telefoneTextBox.TabIndex = 80;
            // 
            // frmCadastrarEstagiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(969, 599);
            this.Controls.Add(this.estagiarioDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastrarEstagiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Estagiario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastrarEstagiario_FormClosed);
            this.Load += new System.EventHandler(this.frmCadastarEstagiario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estagiarioDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.escolaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView estagiarioDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox codEstagiarioTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox licenca_estagioTextBox;
        private System.Windows.Forms.DateTimePicker data_admissaoDateTimePicker;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.ComboBox cbEscola;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DateTimePicker data_nascimentoDateTimePicker;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.Label lblcodEstagiario;
        private db_HospitalDataSet db_HospitalDataSet;
        private System.Windows.Forms.BindingSource escolaBindingSource;
        private db_HospitalDataSetTableAdapters.EscolaTableAdapter escolaTableAdapter;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.MaskedTextBox bITextBox;
        private System.Windows.Forms.MaskedTextBox telefoneTextBox;
    }
}