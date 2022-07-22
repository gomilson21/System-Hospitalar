namespace SistemaHospitalar2.frmCadastramento
{
    partial class frmCadastrarAlta_PacienteInternado
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
            System.Windows.Forms.Label codAltaLabel;
            System.Windows.Forms.Label codPacienteInternadoLabel;
            System.Windows.Forms.Label data_altaLabel;
            System.Windows.Forms.Label hora_altaLabel;
            System.Windows.Forms.Label descricao_altaLabel;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label lblDataRegresso;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.altaPacienteDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnJustificativo = new System.Windows.Forms.Button();
            this.btnRelAlta = new System.Windows.Forms.Button();
            this.diasRepouso = new System.Windows.Forms.NumericUpDown();
            this.dtpHoraConsulta = new System.Windows.Forms.DateTimePicker();
            this.codAltaTextBox = new System.Windows.Forms.TextBox();
            this.cbCodPacInternado = new System.Windows.Forms.ComboBox();
            this.dtpDataRegresso = new System.Windows.Forms.DateTimePicker();
            this.data_altaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descricao_altaTextBox = new System.Windows.Forms.TextBox();
            this.codMedicoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscarNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            codMedicoLabel = new System.Windows.Forms.Label();
            codAltaLabel = new System.Windows.Forms.Label();
            codPacienteInternadoLabel = new System.Windows.Forms.Label();
            data_altaLabel = new System.Windows.Forms.Label();
            hora_altaLabel = new System.Windows.Forms.Label();
            descricao_altaLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lblDataRegresso = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.altaPacienteDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diasRepouso)).BeginInit();
            this.groupBox3.SuspendLayout();
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
            // codAltaLabel
            // 
            codAltaLabel.AutoSize = true;
            codAltaLabel.Location = new System.Drawing.Point(6, 22);
            codAltaLabel.Name = "codAltaLabel";
            codAltaLabel.Size = new System.Drawing.Size(71, 18);
            codAltaLabel.TabIndex = 83;
            codAltaLabel.Text = "Código:";
            // 
            // codPacienteInternadoLabel
            // 
            codPacienteInternadoLabel.AutoSize = true;
            codPacienteInternadoLabel.Location = new System.Drawing.Point(6, 55);
            codPacienteInternadoLabel.Name = "codPacienteInternadoLabel";
            codPacienteInternadoLabel.Size = new System.Drawing.Size(138, 18);
            codPacienteInternadoLabel.TabIndex = 85;
            codPacienteInternadoLabel.Text = "Nome Paciente:";
            // 
            // data_altaLabel
            // 
            data_altaLabel.AutoSize = true;
            data_altaLabel.Location = new System.Drawing.Point(6, 88);
            data_altaLabel.Name = "data_altaLabel";
            data_altaLabel.Size = new System.Drawing.Size(119, 18);
            data_altaLabel.TabIndex = 87;
            data_altaLabel.Text = "Data da Alta:";
            // 
            // hora_altaLabel
            // 
            hora_altaLabel.AutoSize = true;
            hora_altaLabel.Location = new System.Drawing.Point(6, 120);
            hora_altaLabel.Name = "hora_altaLabel";
            hora_altaLabel.Size = new System.Drawing.Size(92, 18);
            hora_altaLabel.TabIndex = 89;
            hora_altaLabel.Text = "Hora Alta:";
            // 
            // descricao_altaLabel
            // 
            descricao_altaLabel.AutoSize = true;
            descricao_altaLabel.Location = new System.Drawing.Point(6, 232);
            descricao_altaLabel.Name = "descricao_altaLabel";
            descricao_altaLabel.Size = new System.Drawing.Size(132, 18);
            descricao_altaLabel.TabIndex = 91;
            descricao_altaLabel.Text = "Descrição Alta:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(5, 186);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(153, 18);
            label4.TabIndex = 89;
            label4.Text = "Dias de Repouso:";
            // 
            // lblDataRegresso
            // 
            lblDataRegresso.AutoSize = true;
            lblDataRegresso.Location = new System.Drawing.Point(5, 154);
            lblDataRegresso.Name = "lblDataRegresso";
            lblDataRegresso.Size = new System.Drawing.Size(161, 18);
            lblDataRegresso.TabIndex = 87;
            lblDataRegresso.Text = "Data de Regresso:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblLogin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 126);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(252, 49);
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
            this.lblLogin.Location = new System.Drawing.Point(487, 88);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(278, 23);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Cadastrar alta do Paciente";
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.fb1;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.Location = new System.Drawing.Point(518, 21);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(81, 50);
            this.btnNovo.TabIndex = 61;
            this.toolTip1.SetToolTip(this.btnNovo, "Novo");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.xde;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.Location = new System.Drawing.Point(608, 74);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(81, 50);
            this.btnSalvar.TabIndex = 64;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.exe;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.Location = new System.Drawing.Point(518, 72);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(81, 50);
            this.btnExcluir.TabIndex = 63;
            this.toolTip1.SetToolTip(this.btnExcluir, "Eliminar");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.edre;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Location = new System.Drawing.Point(608, 21);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(81, 50);
            this.btnEditar.TabIndex = 62;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.ex1;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Location = new System.Drawing.Point(701, 19);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(59, 103);
            this.btnSair.TabIndex = 65;
            this.toolTip1.SetToolTip(this.btnSair, "Fechar");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // altaPacienteDataGridView
            // 
            this.altaPacienteDataGridView.AllowUserToAddRows = false;
            this.altaPacienteDataGridView.AllowUserToDeleteRows = false;
            this.altaPacienteDataGridView.ColumnHeadersHeight = 30;
            this.altaPacienteDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.altaPacienteDataGridView.Location = new System.Drawing.Point(0, 126);
            this.altaPacienteDataGridView.Name = "altaPacienteDataGridView";
            this.altaPacienteDataGridView.ReadOnly = true;
            this.altaPacienteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.altaPacienteDataGridView.Size = new System.Drawing.Size(766, 188);
            this.altaPacienteDataGridView.TabIndex = 34;
            this.altaPacienteDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.altaPacienteDataGridView_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.diasRepouso);
            this.groupBox2.Controls.Add(this.dtpHoraConsulta);
            this.groupBox2.Controls.Add(codAltaLabel);
            this.groupBox2.Controls.Add(this.codAltaTextBox);
            this.groupBox2.Controls.Add(codPacienteInternadoLabel);
            this.groupBox2.Controls.Add(this.cbCodPacInternado);
            this.groupBox2.Controls.Add(lblDataRegresso);
            this.groupBox2.Controls.Add(data_altaLabel);
            this.groupBox2.Controls.Add(this.dtpDataRegresso);
            this.groupBox2.Controls.Add(label4);
            this.groupBox2.Controls.Add(this.data_altaDateTimePicker);
            this.groupBox2.Controls.Add(hora_altaLabel);
            this.groupBox2.Controls.Add(descricao_altaLabel);
            this.groupBox2.Controls.Add(this.descricao_altaTextBox);
            this.groupBox2.Controls.Add(this.btnNovo);
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(codMedicoLabel);
            this.groupBox2.Controls.Add(this.codMedicoTextBox);
            this.groupBox2.Controls.Add(this.btnSair);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(766, 340);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnJustificativo);
            this.groupBox4.Controls.Add(this.btnRelAlta);
            this.groupBox4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(144, 274);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(216, 60);
            this.groupBox4.TabIndex = 122;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Emitir Relatório de:";
            // 
            // btnJustificativo
            // 
            this.btnJustificativo.BackColor = System.Drawing.Color.DarkCyan;
            this.btnJustificativo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJustificativo.ForeColor = System.Drawing.Color.White;
            this.btnJustificativo.Location = new System.Drawing.Point(78, 21);
            this.btnJustificativo.Name = "btnJustificativo";
            this.btnJustificativo.Size = new System.Drawing.Size(122, 39);
            this.btnJustificativo.TabIndex = 83;
            this.btnJustificativo.Text = "Justificativo";
            this.btnJustificativo.UseVisualStyleBackColor = false;
            this.btnJustificativo.Click += new System.EventHandler(this.btnJustificativo_Click);
            // 
            // btnRelAlta
            // 
            this.btnRelAlta.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRelAlta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelAlta.ForeColor = System.Drawing.Color.White;
            this.btnRelAlta.Location = new System.Drawing.Point(6, 21);
            this.btnRelAlta.Name = "btnRelAlta";
            this.btnRelAlta.Size = new System.Drawing.Size(66, 39);
            this.btnRelAlta.TabIndex = 83;
            this.btnRelAlta.Text = "Alta";
            this.btnRelAlta.UseVisualStyleBackColor = false;
            this.btnRelAlta.Click += new System.EventHandler(this.btnRelAlta_Click);
            // 
            // diasRepouso
            // 
            this.diasRepouso.Location = new System.Drawing.Point(171, 184);
            this.diasRepouso.Name = "diasRepouso";
            this.diasRepouso.ReadOnly = true;
            this.diasRepouso.Size = new System.Drawing.Size(75, 27);
            this.diasRepouso.TabIndex = 121;
            // 
            // dtpHoraConsulta
            // 
            this.dtpHoraConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraConsulta.Location = new System.Drawing.Point(144, 117);
            this.dtpHoraConsulta.Name = "dtpHoraConsulta";
            this.dtpHoraConsulta.Size = new System.Drawing.Size(200, 27);
            this.dtpHoraConsulta.TabIndex = 120;
            // 
            // codAltaTextBox
            // 
            this.codAltaTextBox.Location = new System.Drawing.Point(144, 19);
            this.codAltaTextBox.Name = "codAltaTextBox";
            this.codAltaTextBox.ReadOnly = true;
            this.codAltaTextBox.Size = new System.Drawing.Size(238, 27);
            this.codAltaTextBox.TabIndex = 84;
            // 
            // cbCodPacInternado
            // 
            this.cbCodPacInternado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodPacInternado.FormattingEnabled = true;
            this.cbCodPacInternado.Location = new System.Drawing.Point(144, 52);
            this.cbCodPacInternado.Name = "cbCodPacInternado";
            this.cbCodPacInternado.Size = new System.Drawing.Size(354, 26);
            this.cbCodPacInternado.TabIndex = 86;
            // 
            // dtpDataRegresso
            // 
            this.dtpDataRegresso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataRegresso.Location = new System.Drawing.Point(171, 150);
            this.dtpDataRegresso.Name = "dtpDataRegresso";
            this.dtpDataRegresso.Size = new System.Drawing.Size(173, 27);
            this.dtpDataRegresso.TabIndex = 88;
            // 
            // data_altaDateTimePicker
            // 
            this.data_altaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_altaDateTimePicker.Location = new System.Drawing.Point(144, 84);
            this.data_altaDateTimePicker.Name = "data_altaDateTimePicker";
            this.data_altaDateTimePicker.Size = new System.Drawing.Size(201, 27);
            this.data_altaDateTimePicker.TabIndex = 88;
            // 
            // descricao_altaTextBox
            // 
            this.descricao_altaTextBox.Location = new System.Drawing.Point(144, 217);
            this.descricao_altaTextBox.Multiline = true;
            this.descricao_altaTextBox.Name = "descricao_altaTextBox";
            this.descricao_altaTextBox.ReadOnly = true;
            this.descricao_altaTextBox.Size = new System.Drawing.Size(354, 45);
            this.descricao_altaTextBox.TabIndex = 92;
            // 
            // codMedicoTextBox
            // 
            this.codMedicoTextBox.Location = new System.Drawing.Point(435, 493);
            this.codMedicoTextBox.Name = "codMedicoTextBox";
            this.codMedicoTextBox.Size = new System.Drawing.Size(200, 27);
            this.codMedicoTextBox.TabIndex = 59;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnActualizar);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.txtBuscarCodigo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtBuscarNome);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(523, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 131);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consultar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(135, 43);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(98, 30);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(85, 43);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 30);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "OK";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(7, 44);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(74, 27);
            this.txtBuscarCodigo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pelo nome";
            // 
            // txtBuscarNome
            // 
            this.txtBuscarNome.Location = new System.Drawing.Point(7, 96);
            this.txtBuscarNome.Name = "txtBuscarNome";
            this.txtBuscarNome.Size = new System.Drawing.Size(221, 27);
            this.txtBuscarNome.TabIndex = 2;
            this.txtBuscarNome.TextChanged += new System.EventHandler(this.txtBuscarNome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pelo código";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCadastrarAlta_PacienteInternado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(766, 660);
            this.Controls.Add(this.altaPacienteDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCadastrarAlta_PacienteInternado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta do Paciente Internado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastrarAlta_PacienteInternado_FormClosed);
            this.Load += new System.EventHandler(this.frmCadastrarAlta_PacienteInternado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.altaPacienteDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.diasRepouso)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView altaPacienteDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRelAlta;
        private System.Windows.Forms.TextBox codMedicoTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox codAltaTextBox;
        private System.Windows.Forms.DateTimePicker data_altaDateTimePicker;
        private System.Windows.Forms.TextBox descricao_altaTextBox;
        public System.Windows.Forms.ComboBox cbCodPacInternado;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.DateTimePicker dtpHoraConsulta;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown diasRepouso;
        private System.Windows.Forms.DateTimePicker dtpDataRegresso;
        private System.Windows.Forms.Button btnJustificativo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}