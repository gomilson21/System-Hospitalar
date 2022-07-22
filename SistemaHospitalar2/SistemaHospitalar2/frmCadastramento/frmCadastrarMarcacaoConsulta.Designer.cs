namespace SistemaHospitalar2.frmCadastramento
{
    partial class frmCadastrarMarcacaoConsulta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCodMarcacao = new System.Windows.Forms.Label();
            this.lblCodTipo_Consulta = new System.Windows.Forms.Label();
            this.lblCodMedico = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.marcacaoConsultaDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DiasRepouso = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnJustificativo = new System.Windows.Forms.Button();
            this.btnSolExame = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.cbCodPaciente = new System.Windows.Forms.ComboBox();
            this.dtpHoraConsulta = new System.Windows.Forms.DateTimePicker();
            this.lblDiasRepouso = new System.Windows.Forms.Label();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.codMarcacaoTextBox = new System.Windows.Forms.TextBox();
            this.lblNome_doente = new System.Windows.Forms.Label();
            this.cbCodTipoConsulta = new System.Windows.Forms.ComboBox();
            this.cbCodMedico = new System.Windows.Forms.ComboBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.marcacaoConsultaDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiasRepouso)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodMarcacao
            // 
            this.lblCodMarcacao.AutoSize = true;
            this.lblCodMarcacao.Location = new System.Drawing.Point(10, 26);
            this.lblCodMarcacao.Name = "lblCodMarcacao";
            this.lblCodMarcacao.Size = new System.Drawing.Size(71, 18);
            this.lblCodMarcacao.TabIndex = 83;
            this.lblCodMarcacao.Text = "Código:";
            // 
            // lblCodTipo_Consulta
            // 
            this.lblCodTipo_Consulta.AutoSize = true;
            this.lblCodTipo_Consulta.Location = new System.Drawing.Point(10, 92);
            this.lblCodTipo_Consulta.Name = "lblCodTipo_Consulta";
            this.lblCodTipo_Consulta.Size = new System.Drawing.Size(128, 18);
            this.lblCodTipo_Consulta.TabIndex = 87;
            this.lblCodTipo_Consulta.Text = "Tipo Consulta:";
            // 
            // lblCodMedico
            // 
            this.lblCodMedico.AutoSize = true;
            this.lblCodMedico.Location = new System.Drawing.Point(10, 124);
            this.lblCodMedico.Name = "lblCodMedico";
            this.lblCodMedico.Size = new System.Drawing.Size(175, 18);
            this.lblCodMedico.TabIndex = 89;
            this.lblCodMedico.Text = "Médico Especialista:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(12, 240);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(93, 18);
            this.lblDescricao.TabIndex = 93;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(12, 159);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(158, 18);
            this.lblData.TabIndex = 95;
            this.lblData.Text = "Data da Consulta:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(12, 189);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(157, 18);
            this.lblHora.TabIndex = 96;
            this.lblHora.Text = "Hora da Consulta:";
            // 
            // marcacaoConsultaDataGridView
            // 
            this.marcacaoConsultaDataGridView.AllowUserToAddRows = false;
            this.marcacaoConsultaDataGridView.AllowUserToDeleteRows = false;
            this.marcacaoConsultaDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.marcacaoConsultaDataGridView.ColumnHeadersHeight = 30;
            this.marcacaoConsultaDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.marcacaoConsultaDataGridView.Location = new System.Drawing.Point(0, 126);
            this.marcacaoConsultaDataGridView.Name = "marcacaoConsultaDataGridView";
            this.marcacaoConsultaDataGridView.ReadOnly = true;
            this.marcacaoConsultaDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.marcacaoConsultaDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.marcacaoConsultaDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.marcacaoConsultaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.marcacaoConsultaDataGridView.Size = new System.Drawing.Size(754, 186);
            this.marcacaoConsultaDataGridView.TabIndex = 37;
            this.marcacaoConsultaDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.marcacaoConsultaDataGridView_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DiasRepouso);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.cbCodPaciente);
            this.groupBox2.Controls.Add(this.dtpHoraConsulta);
            this.groupBox2.Controls.Add(this.lblHora);
            this.groupBox2.Controls.Add(this.lblDiasRepouso);
            this.groupBox2.Controls.Add(this.lblData);
            this.groupBox2.Controls.Add(this.dataDateTimePicker);
            this.groupBox2.Controls.Add(this.lblCodMarcacao);
            this.groupBox2.Controls.Add(this.codMarcacaoTextBox);
            this.groupBox2.Controls.Add(this.lblNome_doente);
            this.groupBox2.Controls.Add(this.lblCodTipo_Consulta);
            this.groupBox2.Controls.Add(this.cbCodTipoConsulta);
            this.groupBox2.Controls.Add(this.lblCodMedico);
            this.groupBox2.Controls.Add(this.cbCodMedico);
            this.groupBox2.Controls.Add(this.lblDescricao);
            this.groupBox2.Controls.Add(this.descricaoTextBox);
            this.groupBox2.Controls.Add(this.btnNovo);
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnSair);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(754, 350);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            // 
            // DiasRepouso
            // 
            this.DiasRepouso.Location = new System.Drawing.Point(171, 288);
            this.DiasRepouso.Name = "DiasRepouso";
            this.DiasRepouso.Size = new System.Drawing.Size(60, 27);
            this.DiasRepouso.TabIndex = 19;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnJustificativo);
            this.groupBox4.Controls.Add(this.btnSolExame);
            this.groupBox4.Controls.Add(this.btnRelatorio);
            this.groupBox4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(237, 282);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(514, 62);
            this.groupBox4.TabIndex = 99;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Acção";
            // 
            // btnJustificativo
            // 
            this.btnJustificativo.BackColor = System.Drawing.Color.Red;
            this.btnJustificativo.ForeColor = System.Drawing.Color.White;
            this.btnJustificativo.Location = new System.Drawing.Point(215, 17);
            this.btnJustificativo.Name = "btnJustificativo";
            this.btnJustificativo.Size = new System.Drawing.Size(135, 34);
            this.btnJustificativo.TabIndex = 33;
            this.btnJustificativo.Text = "Justificativo";
            this.btnJustificativo.UseVisualStyleBackColor = false;
            this.btnJustificativo.Click += new System.EventHandler(this.btnJustificativo_Click);
            // 
            // btnSolExame
            // 
            this.btnSolExame.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSolExame.ForeColor = System.Drawing.Color.White;
            this.btnSolExame.Location = new System.Drawing.Point(17, 17);
            this.btnSolExame.Name = "btnSolExame";
            this.btnSolExame.Size = new System.Drawing.Size(192, 34);
            this.btnSolExame.TabIndex = 32;
            this.btnSolExame.Text = "Solicitação de Exame";
            this.btnSolExame.UseVisualStyleBackColor = false;
            this.btnSolExame.Click += new System.EventHandler(this.btnSolExame_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRelatorio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnRelatorio.Location = new System.Drawing.Point(356, 17);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(156, 34);
            this.btnRelatorio.TabIndex = 34;
            this.btnRelatorio.Text = "Emitir Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // cbCodPaciente
            // 
            this.cbCodPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodPaciente.FormattingEnabled = true;
            this.cbCodPaciente.Location = new System.Drawing.Point(180, 56);
            this.cbCodPaciente.Name = "cbCodPaciente";
            this.cbCodPaciente.Size = new System.Drawing.Size(313, 26);
            this.cbCodPaciente.TabIndex = 7;
            // 
            // dtpHoraConsulta
            // 
            this.dtpHoraConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraConsulta.Location = new System.Drawing.Point(178, 186);
            this.dtpHoraConsulta.Name = "dtpHoraConsulta";
            this.dtpHoraConsulta.Size = new System.Drawing.Size(200, 27);
            this.dtpHoraConsulta.TabIndex = 15;
            // 
            // lblDiasRepouso
            // 
            this.lblDiasRepouso.AutoSize = true;
            this.lblDiasRepouso.Location = new System.Drawing.Point(12, 290);
            this.lblDiasRepouso.Name = "lblDiasRepouso";
            this.lblDiasRepouso.Size = new System.Drawing.Size(153, 18);
            this.lblDiasRepouso.TabIndex = 83;
            this.lblDiasRepouso.Text = "Dias de Repouso:";
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataDateTimePicker.Location = new System.Drawing.Point(178, 153);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.dataDateTimePicker.TabIndex = 13;
            // 
            // codMarcacaoTextBox
            // 
            this.codMarcacaoTextBox.Location = new System.Drawing.Point(178, 23);
            this.codMarcacaoTextBox.Name = "codMarcacaoTextBox";
            this.codMarcacaoTextBox.ReadOnly = true;
            this.codMarcacaoTextBox.Size = new System.Drawing.Size(200, 27);
            this.codMarcacaoTextBox.TabIndex = 5;
            // 
            // lblNome_doente
            // 
            this.lblNome_doente.AutoSize = true;
            this.lblNome_doente.Location = new System.Drawing.Point(10, 59);
            this.lblNome_doente.Name = "lblNome_doente";
            this.lblNome_doente.Size = new System.Drawing.Size(164, 18);
            this.lblNome_doente.TabIndex = 85;
            this.lblNome_doente.Text = "Nome do Paciente:";
            // 
            // cbCodTipoConsulta
            // 
            this.cbCodTipoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodTipoConsulta.FormattingEnabled = true;
            this.cbCodTipoConsulta.Location = new System.Drawing.Point(178, 89);
            this.cbCodTipoConsulta.Name = "cbCodTipoConsulta";
            this.cbCodTipoConsulta.Size = new System.Drawing.Size(315, 26);
            this.cbCodTipoConsulta.TabIndex = 9;
            // 
            // cbCodMedico
            // 
            this.cbCodMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodMedico.FormattingEnabled = true;
            this.cbCodMedico.Location = new System.Drawing.Point(191, 121);
            this.cbCodMedico.Name = "cbCodMedico";
            this.cbCodMedico.Size = new System.Drawing.Size(302, 26);
            this.cbCodMedico.TabIndex = 11;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(124, 219);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.ReadOnly = true;
            this.descricaoTextBox.Size = new System.Drawing.Size(369, 60);
            this.descricaoTextBox.TabIndex = 17;
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.fb1;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.Location = new System.Drawing.Point(509, 23);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(81, 50);
            this.btnNovo.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnNovo, "Novo");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.xde1;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.Location = new System.Drawing.Point(599, 76);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(81, 50);
            this.btnSalvar.TabIndex = 23;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.exe1;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.Location = new System.Drawing.Point(509, 76);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(81, 50);
            this.btnExcluir.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btnExcluir, "Eliminar");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.edre1;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Location = new System.Drawing.Point(599, 23);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(81, 50);
            this.btnEditar.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.ex3;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Location = new System.Drawing.Point(686, 24);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(56, 103);
            this.btnSair.TabIndex = 24;
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
            this.groupBox3.Location = new System.Drawing.Point(509, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 129);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consultar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(142, 48);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(97, 30);
            this.btnActualizar.TabIndex = 28;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(94, 48);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 30);
            this.btnBuscar.TabIndex = 27;
            this.btnBuscar.Text = "OK";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(12, 49);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(78, 27);
            this.txtBuscarCodigo.TabIndex = 26;
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
            this.txtBuscarNome.Size = new System.Drawing.Size(227, 27);
            this.txtBuscarNome.TabIndex = 30;
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
            this.groupBox1.Size = new System.Drawing.Size(754, 126);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(206, 48);
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
            this.lblLogin.Location = new System.Drawing.Point(417, 87);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(337, 23);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Cadastrar Marcação de Consulta\r\n";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCadastrarMarcacaoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(754, 668);
            this.Controls.Add(this.marcacaoConsultaDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCadastrarMarcacaoConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Marcação Consulta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastrarMarcacaoConsulta_FormClosed);
            this.Load += new System.EventHandler(this.frmCadastrarMarcacaoConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marcacaoConsultaDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DiasRepouso)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView marcacaoConsultaDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox codMarcacaoTextBox;
        private System.Windows.Forms.ComboBox cbCodTipoConsulta;
        private System.Windows.Forms.ComboBox cbCodMedico;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblCodMarcacao;
        private System.Windows.Forms.Label lblCodTipo_Consulta;
        private System.Windows.Forms.Label lblCodMedico;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.ComboBox cbCodPaciente;
        private System.Windows.Forms.DateTimePicker dtpHoraConsulta;
        private System.Windows.Forms.Label lblNome_doente;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnJustificativo;
        private System.Windows.Forms.Button btnSolExame;
        private System.Windows.Forms.NumericUpDown DiasRepouso;
        private System.Windows.Forms.Label lblDiasRepouso;
    }
}