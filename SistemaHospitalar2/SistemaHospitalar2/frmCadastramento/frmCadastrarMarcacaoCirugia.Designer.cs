namespace SistemaHospitalar2.frmCadastramento
{
    partial class frmCadastrarMarcacaoCirugia
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
            System.Windows.Forms.Label codPacienteInternadoLabel;
            System.Windows.Forms.Label codMedicoLabel;
            System.Windows.Forms.Label data_cirugiaLabel;
            System.Windows.Forms.Label hora_cirugiaLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label codCirugiaLabel;
            System.Windows.Forms.Label codTipo_CirugiaLabel;
            this.marcacaoCirugiaDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbCodTipoCirugia = new System.Windows.Forms.ComboBox();
            this.cbCodMedico = new System.Windows.Forms.ComboBox();
            this.cbCodPacInternado = new System.Windows.Forms.ComboBox();
            this.data_cirugiaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.codCirugiaTextBox = new System.Windows.Forms.TextBox();
            this.btnRelatorio = new System.Windows.Forms.Button();
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtpHoraConsulta = new System.Windows.Forms.DateTimePicker();
            codPacienteInternadoLabel = new System.Windows.Forms.Label();
            codMedicoLabel = new System.Windows.Forms.Label();
            data_cirugiaLabel = new System.Windows.Forms.Label();
            hora_cirugiaLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            codCirugiaLabel = new System.Windows.Forms.Label();
            codTipo_CirugiaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.marcacaoCirugiaDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // codPacienteInternadoLabel
            // 
            codPacienteInternadoLabel.AutoSize = true;
            codPacienteInternadoLabel.Location = new System.Drawing.Point(8, 51);
            codPacienteInternadoLabel.Name = "codPacienteInternadoLabel";
            codPacienteInternadoLabel.Size = new System.Drawing.Size(171, 18);
            codPacienteInternadoLabel.TabIndex = 95;
            codPacienteInternadoLabel.Text = "Paciente Internado:";
            // 
            // codMedicoLabel
            // 
            codMedicoLabel.AutoSize = true;
            codMedicoLabel.Location = new System.Drawing.Point(12, 115);
            codMedicoLabel.Name = "codMedicoLabel";
            codMedicoLabel.Size = new System.Drawing.Size(71, 18);
            codMedicoLabel.TabIndex = 97;
            codMedicoLabel.Text = "Médico:";
            // 
            // data_cirugiaLabel
            // 
            data_cirugiaLabel.AutoSize = true;
            data_cirugiaLabel.Location = new System.Drawing.Point(12, 148);
            data_cirugiaLabel.Name = "data_cirugiaLabel";
            data_cirugiaLabel.Size = new System.Drawing.Size(143, 18);
            data_cirugiaLabel.TabIndex = 99;
            data_cirugiaLabel.Text = "Data da Cirugia:";
            // 
            // hora_cirugiaLabel
            // 
            hora_cirugiaLabel.AutoSize = true;
            hora_cirugiaLabel.Location = new System.Drawing.Point(12, 180);
            hora_cirugiaLabel.Name = "hora_cirugiaLabel";
            hora_cirugiaLabel.Size = new System.Drawing.Size(116, 18);
            hora_cirugiaLabel.TabIndex = 101;
            hora_cirugiaLabel.Text = "Hora Cirugia:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(12, 213);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(93, 18);
            descricaoLabel.TabIndex = 103;
            descricaoLabel.Text = "Descrição:";
            // 
            // codCirugiaLabel
            // 
            codCirugiaLabel.AutoSize = true;
            codCirugiaLabel.Location = new System.Drawing.Point(12, 18);
            codCirugiaLabel.Name = "codCirugiaLabel";
            codCirugiaLabel.Size = new System.Drawing.Size(71, 18);
            codCirugiaLabel.TabIndex = 105;
            codCirugiaLabel.Text = "Código:";
            // 
            // codTipo_CirugiaLabel
            // 
            codTipo_CirugiaLabel.AutoSize = true;
            codTipo_CirugiaLabel.Location = new System.Drawing.Point(12, 83);
            codTipo_CirugiaLabel.Name = "codTipo_CirugiaLabel";
            codTipo_CirugiaLabel.Size = new System.Drawing.Size(113, 18);
            codTipo_CirugiaLabel.TabIndex = 107;
            codTipo_CirugiaLabel.Text = "Tipo Cirugia:";
            // 
            // marcacaoCirugiaDataGridView
            // 
            this.marcacaoCirugiaDataGridView.AllowUserToAddRows = false;
            this.marcacaoCirugiaDataGridView.AllowUserToDeleteRows = false;
            this.marcacaoCirugiaDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.marcacaoCirugiaDataGridView.ColumnHeadersHeight = 30;
            this.marcacaoCirugiaDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.marcacaoCirugiaDataGridView.Location = new System.Drawing.Point(0, 134);
            this.marcacaoCirugiaDataGridView.Name = "marcacaoCirugiaDataGridView";
            this.marcacaoCirugiaDataGridView.ReadOnly = true;
            this.marcacaoCirugiaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.marcacaoCirugiaDataGridView.Size = new System.Drawing.Size(753, 219);
            this.marcacaoCirugiaDataGridView.TabIndex = 40;
            this.marcacaoCirugiaDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.marcacaoCirugiaDataGridView_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpHoraConsulta);
            this.groupBox2.Controls.Add(this.cbCodTipoCirugia);
            this.groupBox2.Controls.Add(this.cbCodMedico);
            this.groupBox2.Controls.Add(this.cbCodPacInternado);
            this.groupBox2.Controls.Add(codPacienteInternadoLabel);
            this.groupBox2.Controls.Add(codMedicoLabel);
            this.groupBox2.Controls.Add(data_cirugiaLabel);
            this.groupBox2.Controls.Add(this.data_cirugiaDateTimePicker);
            this.groupBox2.Controls.Add(hora_cirugiaLabel);
            this.groupBox2.Controls.Add(descricaoLabel);
            this.groupBox2.Controls.Add(this.descricaoTextBox);
            this.groupBox2.Controls.Add(codCirugiaLabel);
            this.groupBox2.Controls.Add(this.codCirugiaTextBox);
            this.groupBox2.Controls.Add(codTipo_CirugiaLabel);
            this.groupBox2.Controls.Add(this.btnRelatorio);
            this.groupBox2.Controls.Add(this.btnNovo);
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnSair);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 359);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(753, 310);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            // 
            // cbCodTipoCirugia
            // 
            this.cbCodTipoCirugia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodTipoCirugia.FormattingEnabled = true;
            this.cbCodTipoCirugia.Location = new System.Drawing.Point(179, 80);
            this.cbCodTipoCirugia.Name = "cbCodTipoCirugia";
            this.cbCodTipoCirugia.Size = new System.Drawing.Size(316, 26);
            this.cbCodTipoCirugia.TabIndex = 110;
            // 
            // cbCodMedico
            // 
            this.cbCodMedico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodMedico.FormattingEnabled = true;
            this.cbCodMedico.Location = new System.Drawing.Point(179, 112);
            this.cbCodMedico.Name = "cbCodMedico";
            this.cbCodMedico.Size = new System.Drawing.Size(316, 26);
            this.cbCodMedico.TabIndex = 112;
            // 
            // cbCodPacInternado
            // 
            this.cbCodPacInternado.DisplayMember = "codPacienteInternado";
            this.cbCodPacInternado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodPacInternado.FormattingEnabled = true;
            this.cbCodPacInternado.Location = new System.Drawing.Point(179, 48);
            this.cbCodPacInternado.Name = "cbCodPacInternado";
            this.cbCodPacInternado.Size = new System.Drawing.Size(310, 26);
            this.cbCodPacInternado.TabIndex = 108;
            this.cbCodPacInternado.ValueMember = "codPacienteInternado";
            // 
            // data_cirugiaDateTimePicker
            // 
            this.data_cirugiaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_cirugiaDateTimePicker.Location = new System.Drawing.Point(179, 144);
            this.data_cirugiaDateTimePicker.Name = "data_cirugiaDateTimePicker";
            this.data_cirugiaDateTimePicker.Size = new System.Drawing.Size(201, 27);
            this.data_cirugiaDateTimePicker.TabIndex = 114;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(138, 213);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.ReadOnly = true;
            this.descricaoTextBox.Size = new System.Drawing.Size(357, 75);
            this.descricaoTextBox.TabIndex = 118;
            // 
            // codCirugiaTextBox
            // 
            this.codCirugiaTextBox.Location = new System.Drawing.Point(179, 15);
            this.codCirugiaTextBox.Name = "codCirugiaTextBox";
            this.codCirugiaTextBox.ReadOnly = true;
            this.codCirugiaTextBox.Size = new System.Drawing.Size(212, 27);
            this.codCirugiaTextBox.TabIndex = 106;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.DarkCyan;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnRelatorio.Location = new System.Drawing.Point(509, 272);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(236, 35);
            this.btnRelatorio.TabIndex = 95;
            this.btnRelatorio.Text = "Emitir Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.fb1;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.Location = new System.Drawing.Point(509, 21);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(81, 50);
            this.btnNovo.TabIndex = 83;
            this.toolTip1.SetToolTip(this.btnNovo, "Novo");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.xde1;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.Location = new System.Drawing.Point(599, 74);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(81, 50);
            this.btnSalvar.TabIndex = 82;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.exe1;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.Location = new System.Drawing.Point(509, 74);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(81, 50);
            this.btnExcluir.TabIndex = 81;
            this.toolTip1.SetToolTip(this.btnExcluir, "Eliminar");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.edre1;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Location = new System.Drawing.Point(599, 21);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(81, 50);
            this.btnEditar.TabIndex = 80;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.ex3;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Location = new System.Drawing.Point(686, 22);
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
            this.groupBox3.Location = new System.Drawing.Point(509, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 129);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consultar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(129, 49);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(98, 30);
            this.btnActualizar.TabIndex = 26;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(80, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 30);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "OK";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(15, 50);
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
            this.txtBuscarNome.Size = new System.Drawing.Size(215, 27);
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
            this.groupBox1.Size = new System.Drawing.Size(753, 134);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(224, 49);
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
            this.lblLogin.Location = new System.Drawing.Point(427, 94);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(325, 23);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Cadastrar Marcação de Cirugia";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dtpHoraConsulta
            // 
            this.dtpHoraConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraConsulta.Location = new System.Drawing.Point(179, 177);
            this.dtpHoraConsulta.Name = "dtpHoraConsulta";
            this.dtpHoraConsulta.Size = new System.Drawing.Size(200, 27);
            this.dtpHoraConsulta.TabIndex = 119;
            // 
            // frmCadastrarMarcacaoCirugia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(753, 669);
            this.Controls.Add(this.marcacaoCirugiaDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCadastrarMarcacaoCirugia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Marcação Cirugia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastrarMarcacaoCirugia_FormClosed);
            this.Load += new System.EventHandler(this.frmCadastrarMarcacaoCirugia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marcacaoCirugiaDataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView marcacaoCirugiaDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRelatorio;
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
        private System.Windows.Forms.DateTimePicker data_cirugiaDateTimePicker;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox codCirugiaTextBox;
        private System.Windows.Forms.ComboBox cbCodTipoCirugia;
        private System.Windows.Forms.ComboBox cbCodMedico;
        private System.Windows.Forms.ComboBox cbCodPacInternado;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.DateTimePicker dtpHoraConsulta;
    }
}