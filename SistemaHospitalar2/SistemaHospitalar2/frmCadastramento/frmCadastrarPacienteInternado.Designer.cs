namespace SistemaHospitalar2
{
    partial class frmCadastrarPacienteInternado
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
            System.Windows.Forms.Label estado_clinicoLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label data_internacaoLabel;
            System.Windows.Forms.Label hora_internacaoLabel;
            System.Windows.Forms.Label codTratamentoLabel;
            System.Windows.Forms.Label nome_pacienteLabel;
            System.Windows.Forms.Label numero_camaLabel;
            System.Windows.Forms.Label lblEstadoCama;
            System.Windows.Forms.Label lblMedico;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCodMedico = new System.Windows.Forms.Label();
            this.lblCodPacienteInternado = new System.Windows.Forms.Label();
            this.lblCodQuarto = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pacienteInternadoDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbCodMedico = new System.Windows.Forms.ComboBox();
            this.cbCodPaciente = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSolExame = new System.Windows.Forms.Button();
            this.btnObito = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnPrognostico = new System.Windows.Forms.Button();
            this.cbEstadoCama = new System.Windows.Forms.ComboBox();
            this.cbNumeroCama = new System.Windows.Forms.ComboBox();
            this.cbCodTratamento = new System.Windows.Forms.ComboBox();
            this.cbCodQuarto = new System.Windows.Forms.ComboBox();
            this.codPacienteInternadoTextBox = new System.Windows.Forms.TextBox();
            this.estado_clinicoTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.dtpHoraInternacao = new System.Windows.Forms.DateTimePicker();
            this.data_internacaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnNovo = new System.Windows.Forms.Button();
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            estado_clinicoLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            data_internacaoLabel = new System.Windows.Forms.Label();
            hora_internacaoLabel = new System.Windows.Forms.Label();
            codTratamentoLabel = new System.Windows.Forms.Label();
            nome_pacienteLabel = new System.Windows.Forms.Label();
            numero_camaLabel = new System.Windows.Forms.Label();
            lblEstadoCama = new System.Windows.Forms.Label();
            lblMedico = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteInternadoDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // estado_clinicoLabel
            // 
            estado_clinicoLabel.AutoSize = true;
            estado_clinicoLabel.Location = new System.Drawing.Point(9, 311);
            estado_clinicoLabel.Name = "estado_clinicoLabel";
            estado_clinicoLabel.Size = new System.Drawing.Size(131, 18);
            estado_clinicoLabel.TabIndex = 71;
            estado_clinicoLabel.Text = "Estado Clínico:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(9, 353);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(93, 18);
            descricaoLabel.TabIndex = 73;
            descricaoLabel.Text = "Descricão:";
            // 
            // data_internacaoLabel
            // 
            data_internacaoLabel.AutoSize = true;
            data_internacaoLabel.Location = new System.Drawing.Point(3, 249);
            data_internacaoLabel.Name = "data_internacaoLabel";
            data_internacaoLabel.Size = new System.Drawing.Size(174, 18);
            data_internacaoLabel.TabIndex = 75;
            data_internacaoLabel.Text = "Data da Internação:";
            // 
            // hora_internacaoLabel
            // 
            hora_internacaoLabel.AutoSize = true;
            hora_internacaoLabel.Location = new System.Drawing.Point(5, 281);
            hora_internacaoLabel.Name = "hora_internacaoLabel";
            hora_internacaoLabel.Size = new System.Drawing.Size(173, 18);
            hora_internacaoLabel.TabIndex = 77;
            hora_internacaoLabel.Text = "Hora da Internação:";
            // 
            // codTratamentoLabel
            // 
            codTratamentoLabel.AutoSize = true;
            codTratamentoLabel.Location = new System.Drawing.Point(7, 185);
            codTratamentoLabel.Name = "codTratamentoLabel";
            codTratamentoLabel.Size = new System.Drawing.Size(108, 18);
            codTratamentoLabel.TabIndex = 79;
            codTratamentoLabel.Text = "Tratamento:";
            // 
            // nome_pacienteLabel
            // 
            nome_pacienteLabel.AutoSize = true;
            nome_pacienteLabel.Location = new System.Drawing.Point(5, 56);
            nome_pacienteLabel.Name = "nome_pacienteLabel";
            nome_pacienteLabel.Size = new System.Drawing.Size(164, 18);
            nome_pacienteLabel.TabIndex = 80;
            nome_pacienteLabel.Text = "Nome do Paciente:";
            // 
            // numero_camaLabel
            // 
            numero_camaLabel.AutoSize = true;
            numero_camaLabel.Location = new System.Drawing.Point(10, 121);
            numero_camaLabel.Name = "numero_camaLabel";
            numero_camaLabel.Size = new System.Drawing.Size(156, 18);
            numero_camaLabel.TabIndex = 81;
            numero_camaLabel.Text = "Número da Cama:";
            // 
            // lblEstadoCama
            // 
            lblEstadoCama.AutoSize = true;
            lblEstadoCama.Location = new System.Drawing.Point(10, 153);
            lblEstadoCama.Name = "lblEstadoCama";
            lblEstadoCama.Size = new System.Drawing.Size(149, 18);
            lblEstadoCama.TabIndex = 81;
            lblEstadoCama.Text = "Estado da Cama:";
            // 
            // lblMedico
            // 
            lblMedico.AutoSize = true;
            lblMedico.Location = new System.Drawing.Point(5, 214);
            lblMedico.Name = "lblMedico";
            lblMedico.Size = new System.Drawing.Size(150, 18);
            lblMedico.TabIndex = 80;
            lblMedico.Text = "Nome do Médico:";
            // 
            // lblCodMedico
            // 
            this.lblCodMedico.AutoSize = true;
            this.lblCodMedico.Location = new System.Drawing.Point(277, 496);
            this.lblCodMedico.Name = "lblCodMedico";
            this.lblCodMedico.Size = new System.Drawing.Size(105, 18);
            this.lblCodMedico.TabIndex = 58;
            this.lblCodMedico.Text = "cod Medico:";
            // 
            // lblCodPacienteInternado
            // 
            this.lblCodPacienteInternado.AutoSize = true;
            this.lblCodPacienteInternado.Location = new System.Drawing.Point(9, 23);
            this.lblCodPacienteInternado.Name = "lblCodPacienteInternado";
            this.lblCodPacienteInternado.Size = new System.Drawing.Size(71, 18);
            this.lblCodPacienteInternado.TabIndex = 65;
            this.lblCodPacienteInternado.Text = "Código:";
            // 
            // lblCodQuarto
            // 
            this.lblCodQuarto.AutoSize = true;
            this.lblCodQuarto.Location = new System.Drawing.Point(5, 89);
            this.lblCodQuarto.Name = "lblCodQuarto";
            this.lblCodQuarto.Size = new System.Drawing.Size(150, 18);
            this.lblCodQuarto.TabIndex = 67;
            this.lblCodQuarto.Text = "Nome do Quarto:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblLogin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 126);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(178, 47);
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
            this.lblLogin.Location = new System.Drawing.Point(386, 89);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(308, 23);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Cadastrar Paciente Internado";
            // 
            // pacienteInternadoDataGridView
            // 
            this.pacienteInternadoDataGridView.AllowUserToAddRows = false;
            this.pacienteInternadoDataGridView.AllowUserToDeleteRows = false;
            this.pacienteInternadoDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pacienteInternadoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.pacienteInternadoDataGridView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pacienteInternadoDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.pacienteInternadoDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.pacienteInternadoDataGridView.Location = new System.Drawing.Point(0, 126);
            this.pacienteInternadoDataGridView.Name = "pacienteInternadoDataGridView";
            this.pacienteInternadoDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pacienteInternadoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.pacienteInternadoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pacienteInternadoDataGridView.Size = new System.Drawing.Size(698, 200);
            this.pacienteInternadoDataGridView.TabIndex = 28;
            this.pacienteInternadoDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pacienteInternadoDataGridView_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.cbCodMedico);
            this.groupBox2.Controls.Add(this.cbCodPaciente);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.cbEstadoCama);
            this.groupBox2.Controls.Add(this.cbNumeroCama);
            this.groupBox2.Controls.Add(this.cbCodTratamento);
            this.groupBox2.Controls.Add(this.cbCodQuarto);
            this.groupBox2.Controls.Add(lblEstadoCama);
            this.groupBox2.Controls.Add(lblMedico);
            this.groupBox2.Controls.Add(numero_camaLabel);
            this.groupBox2.Controls.Add(nome_pacienteLabel);
            this.groupBox2.Controls.Add(this.lblCodPacienteInternado);
            this.groupBox2.Controls.Add(this.codPacienteInternadoTextBox);
            this.groupBox2.Controls.Add(this.lblCodQuarto);
            this.groupBox2.Controls.Add(estado_clinicoLabel);
            this.groupBox2.Controls.Add(this.estado_clinicoTextBox);
            this.groupBox2.Controls.Add(descricaoLabel);
            this.groupBox2.Controls.Add(this.descricaoTextBox);
            this.groupBox2.Controls.Add(this.dtpHoraInternacao);
            this.groupBox2.Controls.Add(data_internacaoLabel);
            this.groupBox2.Controls.Add(this.data_internacaoDateTimePicker);
            this.groupBox2.Controls.Add(hora_internacaoLabel);
            this.groupBox2.Controls.Add(codTratamentoLabel);
            this.groupBox2.Controls.Add(this.btnNovo);
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.lblCodMedico);
            this.groupBox2.Controls.Add(this.codMedicoTextBox);
            this.groupBox2.Controls.Add(this.btnSair);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(698, 408);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(171, 212);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(267, 26);
            this.comboBox1.TabIndex = 16;
            // 
            // cbCodMedico
            // 
            this.cbCodMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodMedico.FormattingEnabled = true;
            this.cbCodMedico.Location = new System.Drawing.Point(171, 212);
            this.cbCodMedico.Name = "cbCodMedico";
            this.cbCodMedico.Size = new System.Drawing.Size(267, 26);
            this.cbCodMedico.TabIndex = 89;
            // 
            // cbCodPaciente
            // 
            this.cbCodPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodPaciente.FormattingEnabled = true;
            this.cbCodPaciente.Location = new System.Drawing.Point(171, 54);
            this.cbCodPaciente.Name = "cbCodPaciente";
            this.cbCodPaciente.Size = new System.Drawing.Size(267, 26);
            this.cbCodPaciente.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSolExame);
            this.groupBox4.Controls.Add(this.btnObito);
            this.groupBox4.Controls.Add(this.btnAlta);
            this.groupBox4.Controls.Add(this.btnPrognostico);
            this.groupBox4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(415, 281);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(279, 121);
            this.groupBox4.TabIndex = 88;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Acção";
            // 
            // btnSolExame
            // 
            this.btnSolExame.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSolExame.ForeColor = System.Drawing.Color.White;
            this.btnSolExame.Location = new System.Drawing.Point(5, 55);
            this.btnSolExame.Name = "btnSolExame";
            this.btnSolExame.Size = new System.Drawing.Size(192, 34);
            this.btnSolExame.TabIndex = 40;
            this.btnSolExame.Text = "Solicitação de Exame";
            this.btnSolExame.UseVisualStyleBackColor = false;
            this.btnSolExame.Click += new System.EventHandler(this.btnSolExame_Click);
            // 
            // btnObito
            // 
            this.btnObito.BackColor = System.Drawing.Color.Red;
            this.btnObito.ForeColor = System.Drawing.Color.White;
            this.btnObito.Location = new System.Drawing.Point(77, 19);
            this.btnObito.Name = "btnObito";
            this.btnObito.Size = new System.Drawing.Size(75, 33);
            this.btnObito.TabIndex = 38;
            this.btnObito.Text = "Óbito";
            this.btnObito.UseVisualStyleBackColor = false;
            this.btnObito.Click += new System.EventHandler(this.btnObito_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.DarkCyan;
            this.btnAlta.ForeColor = System.Drawing.Color.White;
            this.btnAlta.Location = new System.Drawing.Point(1, 18);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 34);
            this.btnAlta.TabIndex = 37;
            this.btnAlta.Text = "Alta";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnPrognostico
            // 
            this.btnPrognostico.BackColor = System.Drawing.Color.DarkCyan;
            this.btnPrognostico.ForeColor = System.Drawing.Color.White;
            this.btnPrognostico.Location = new System.Drawing.Point(158, 18);
            this.btnPrognostico.Name = "btnPrognostico";
            this.btnPrognostico.Size = new System.Drawing.Size(116, 34);
            this.btnPrognostico.TabIndex = 39;
            this.btnPrognostico.Text = "Prognóstico";
            this.btnPrognostico.UseVisualStyleBackColor = false;
            this.btnPrognostico.Click += new System.EventHandler(this.btnPrognostico_Click);
            // 
            // cbEstadoCama
            // 
            this.cbEstadoCama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoCama.FormattingEnabled = true;
            this.cbEstadoCama.Items.AddRange(new object[] {
            "Ocupada",
            "Desocupada"});
            this.cbEstadoCama.Location = new System.Drawing.Point(171, 150);
            this.cbEstadoCama.Name = "cbEstadoCama";
            this.cbEstadoCama.Size = new System.Drawing.Size(212, 26);
            this.cbEstadoCama.TabIndex = 12;
            // 
            // cbNumeroCama
            // 
            this.cbNumeroCama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNumeroCama.FormattingEnabled = true;
            this.cbNumeroCama.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cbNumeroCama.Location = new System.Drawing.Point(171, 118);
            this.cbNumeroCama.Name = "cbNumeroCama";
            this.cbNumeroCama.Size = new System.Drawing.Size(212, 26);
            this.cbNumeroCama.TabIndex = 10;
            // 
            // cbCodTratamento
            // 
            this.cbCodTratamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodTratamento.FormattingEnabled = true;
            this.cbCodTratamento.Location = new System.Drawing.Point(171, 182);
            this.cbCodTratamento.Name = "cbCodTratamento";
            this.cbCodTratamento.Size = new System.Drawing.Size(267, 26);
            this.cbCodTratamento.TabIndex = 14;
            // 
            // cbCodQuarto
            // 
            this.cbCodQuarto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodQuarto.FormattingEnabled = true;
            this.cbCodQuarto.Location = new System.Drawing.Point(171, 86);
            this.cbCodQuarto.Name = "cbCodQuarto";
            this.cbCodQuarto.Size = new System.Drawing.Size(212, 26);
            this.cbCodQuarto.TabIndex = 8;
            // 
            // codPacienteInternadoTextBox
            // 
            this.codPacienteInternadoTextBox.Location = new System.Drawing.Point(123, 20);
            this.codPacienteInternadoTextBox.Name = "codPacienteInternadoTextBox";
            this.codPacienteInternadoTextBox.ReadOnly = true;
            this.codPacienteInternadoTextBox.Size = new System.Drawing.Size(204, 27);
            this.codPacienteInternadoTextBox.TabIndex = 4;
            // 
            // estado_clinicoTextBox
            // 
            this.estado_clinicoTextBox.Location = new System.Drawing.Point(151, 308);
            this.estado_clinicoTextBox.Name = "estado_clinicoTextBox";
            this.estado_clinicoTextBox.ReadOnly = true;
            this.estado_clinicoTextBox.Size = new System.Drawing.Size(258, 27);
            this.estado_clinicoTextBox.TabIndex = 18;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(134, 341);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.ReadOnly = true;
            this.descricaoTextBox.Size = new System.Drawing.Size(275, 55);
            this.descricaoTextBox.TabIndex = 24;
            // 
            // dtpHoraInternacao
            // 
            this.dtpHoraInternacao.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInternacao.Location = new System.Drawing.Point(183, 275);
            this.dtpHoraInternacao.Name = "dtpHoraInternacao";
            this.dtpHoraInternacao.Size = new System.Drawing.Size(187, 27);
            this.dtpHoraInternacao.TabIndex = 22;
            // 
            // data_internacaoDateTimePicker
            // 
            this.data_internacaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_internacaoDateTimePicker.Location = new System.Drawing.Point(183, 244);
            this.data_internacaoDateTimePicker.Name = "data_internacaoDateTimePicker";
            this.data_internacaoDateTimePicker.Size = new System.Drawing.Size(187, 27);
            this.data_internacaoDateTimePicker.TabIndex = 79;
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.fb1;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.Location = new System.Drawing.Point(454, 20);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(81, 50);
            this.btnNovo.TabIndex = 26;
            this.toolTip1.SetToolTip(this.btnNovo, "Novo");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.xde;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.Location = new System.Drawing.Point(544, 73);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(81, 50);
            this.btnSalvar.TabIndex = 29;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.exe;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.Location = new System.Drawing.Point(454, 73);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(81, 50);
            this.btnExcluir.TabIndex = 28;
            this.toolTip1.SetToolTip(this.btnExcluir, "Eliminar");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.edre;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Location = new System.Drawing.Point(544, 20);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(81, 50);
            this.btnEditar.TabIndex = 27;
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
            this.btnSair.Location = new System.Drawing.Point(631, 18);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(59, 103);
            this.btnSair.TabIndex = 30;
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
            this.groupBox3.Location = new System.Drawing.Point(454, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 142);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consultar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(126, 47);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(98, 30);
            this.btnActualizar.TabIndex = 33;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(77, 47);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 30);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.Text = "OK";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(12, 48);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(62, 27);
            this.txtBuscarCodigo.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pelo nome";
            // 
            // txtBuscarNome
            // 
            this.txtBuscarNome.Location = new System.Drawing.Point(12, 102);
            this.txtBuscarNome.Name = "txtBuscarNome";
            this.txtBuscarNome.Size = new System.Drawing.Size(212, 27);
            this.txtBuscarNome.TabIndex = 35;
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCadastrarPacienteInternado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(698, 736);
            this.Controls.Add(this.pacienteInternadoDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarPacienteInternado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Paciente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastrarPaciente_FormClosed);
            this.Load += new System.EventHandler(this.frmCadastrarPaciente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteInternadoDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.DataGridView pacienteInternadoDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codMedicoTextBox;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox codPacienteInternadoTextBox;
        private System.Windows.Forms.TextBox estado_clinicoTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.DateTimePicker data_internacaoDateTimePicker;
        private System.Windows.Forms.Button btnPrognostico;
        private System.Windows.Forms.ComboBox cbCodTratamento;
        private System.Windows.Forms.ComboBox cbCodQuarto;
        private System.Windows.Forms.ComboBox cbNumeroCama;
        private System.Windows.Forms.Label lblCodMedico;
        private System.Windows.Forms.Label lblCodPacienteInternado;
        private System.Windows.Forms.Label lblCodQuarto;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnObito;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.ComboBox cbEstadoCama;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.ComboBox cbCodMedico;
        private System.Windows.Forms.ComboBox cbCodPaciente;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dtpHoraInternacao;
        private System.Windows.Forms.Button btnSolExame;
    }
}