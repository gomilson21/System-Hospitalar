namespace SistemaHospitalar2
{
    partial class frmCadastrarFuncionarioGeral
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
            this.lblCodFuncionario = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblBI = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNumero_carteira = new System.Windows.Forms.Label();
            this.lblData_admissao = new System.Windows.Forms.Label();
            this.lblCodFuncao = new System.Windows.Forms.Label();
            this.lblData_nascimento = new System.Windows.Forms.Label();
            this.funcionarioGeralDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.codFuncionarioTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.numero_carteiraTextBox = new System.Windows.Forms.TextBox();
            this.data_admissaoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cbCodFuncao = new System.Windows.Forms.ComboBox();
            this.data_nascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            this.bITextBox = new System.Windows.Forms.MaskedTextBox();
            this.telefoneTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioGeralDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodFuncionario
            // 
            this.lblCodFuncionario.AutoSize = true;
            this.lblCodFuncionario.Location = new System.Drawing.Point(6, 30);
            this.lblCodFuncionario.Name = "lblCodFuncionario";
            this.lblCodFuncionario.Size = new System.Drawing.Size(71, 18);
            this.lblCodFuncionario.TabIndex = 66;
            this.lblCodFuncionario.Text = "Código:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 63);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(62, 18);
            this.lblNome.TabIndex = 68;
            this.lblNome.Text = "Nome:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(423, 30);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(54, 18);
            this.lblSexo.TabIndex = 70;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblBI
            // 
            this.lblBI.AutoSize = true;
            this.lblBI.Location = new System.Drawing.Point(5, 129);
            this.lblBI.Name = "lblBI";
            this.lblBI.Size = new System.Drawing.Size(128, 18);
            this.lblBI.TabIndex = 72;
            this.lblBI.Text = "Número do BI:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 162);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 18);
            this.lblEmail.TabIndex = 74;
            this.lblEmail.Text = "Email:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(423, 66);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(84, 18);
            this.lblTelefone.TabIndex = 76;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(423, 99);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(89, 18);
            this.lblEndereco.TabIndex = 78;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblNumero_carteira
            // 
            this.lblNumero_carteira.AutoSize = true;
            this.lblNumero_carteira.Location = new System.Drawing.Point(6, 195);
            this.lblNumero_carteira.Name = "lblNumero_carteira";
            this.lblNumero_carteira.Size = new System.Drawing.Size(175, 18);
            this.lblNumero_carteira.TabIndex = 82;
            this.lblNumero_carteira.Text = "Número da Carteira:";
            // 
            // lblData_admissao
            // 
            this.lblData_admissao.AutoSize = true;
            this.lblData_admissao.Location = new System.Drawing.Point(423, 133);
            this.lblData_admissao.Name = "lblData_admissao";
            this.lblData_admissao.Size = new System.Drawing.Size(165, 18);
            this.lblData_admissao.TabIndex = 84;
            this.lblData_admissao.Text = "Data de Admissão:";
            // 
            // lblCodFuncao
            // 
            this.lblCodFuncao.AutoSize = true;
            this.lblCodFuncao.Location = new System.Drawing.Point(423, 165);
            this.lblCodFuncao.Name = "lblCodFuncao";
            this.lblCodFuncao.Size = new System.Drawing.Size(72, 18);
            this.lblCodFuncao.TabIndex = 86;
            this.lblCodFuncao.Text = "Funçao:";
            // 
            // lblData_nascimento
            // 
            this.lblData_nascimento.AutoSize = true;
            this.lblData_nascimento.Location = new System.Drawing.Point(6, 97);
            this.lblData_nascimento.Name = "lblData_nascimento";
            this.lblData_nascimento.Size = new System.Drawing.Size(182, 18);
            this.lblData_nascimento.TabIndex = 88;
            this.lblData_nascimento.Text = "Data de Nascimento:";
            // 
            // funcionarioGeralDataGridView
            // 
            this.funcionarioGeralDataGridView.AllowUserToAddRows = false;
            this.funcionarioGeralDataGridView.AllowUserToDeleteRows = false;
            this.funcionarioGeralDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.funcionarioGeralDataGridView.ColumnHeadersHeight = 30;
            this.funcionarioGeralDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.funcionarioGeralDataGridView.Location = new System.Drawing.Point(0, 126);
            this.funcionarioGeralDataGridView.Name = "funcionarioGeralDataGridView";
            this.funcionarioGeralDataGridView.ReadOnly = true;
            this.funcionarioGeralDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.funcionarioGeralDataGridView.Size = new System.Drawing.Size(1068, 200);
            this.funcionarioGeralDataGridView.TabIndex = 37;
            this.funcionarioGeralDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.funcionarioGeralDataGridView_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bITextBox);
            this.groupBox2.Controls.Add(this.telefoneTextBox);
            this.groupBox2.Controls.Add(this.cbSexo);
            this.groupBox2.Controls.Add(this.lblCodFuncionario);
            this.groupBox2.Controls.Add(this.codFuncionarioTextBox);
            this.groupBox2.Controls.Add(this.lblNome);
            this.groupBox2.Controls.Add(this.nomeTextBox);
            this.groupBox2.Controls.Add(this.lblSexo);
            this.groupBox2.Controls.Add(this.lblBI);
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.emailTextBox);
            this.groupBox2.Controls.Add(this.lblTelefone);
            this.groupBox2.Controls.Add(this.lblEndereco);
            this.groupBox2.Controls.Add(this.enderecoTextBox);
            this.groupBox2.Controls.Add(this.lblNumero_carteira);
            this.groupBox2.Controls.Add(this.numero_carteiraTextBox);
            this.groupBox2.Controls.Add(this.lblData_admissao);
            this.groupBox2.Controls.Add(this.data_admissaoDateTimePicker);
            this.groupBox2.Controls.Add(this.lblCodFuncao);
            this.groupBox2.Controls.Add(this.cbCodFuncao);
            this.groupBox2.Controls.Add(this.lblData_nascimento);
            this.groupBox2.Controls.Add(this.data_nascimentoDateTimePicker);
            this.groupBox2.Controls.Add(this.btnNovo);
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnSair);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1068, 272);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbSexo.Location = new System.Drawing.Point(518, 26);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(174, 26);
            this.cbSexo.TabIndex = 79;
            // 
            // codFuncionarioTextBox
            // 
            this.codFuncionarioTextBox.Enabled = false;
            this.codFuncionarioTextBox.Location = new System.Drawing.Point(94, 27);
            this.codFuncionarioTextBox.Name = "codFuncionarioTextBox";
            this.codFuncionarioTextBox.ReadOnly = true;
            this.codFuncionarioTextBox.Size = new System.Drawing.Size(210, 27);
            this.codFuncionarioTextBox.TabIndex = 67;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(94, 60);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(315, 27);
            this.nomeTextBox.TabIndex = 69;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(94, 159);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(315, 27);
            this.emailTextBox.TabIndex = 75;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.Location = new System.Drawing.Point(518, 96);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(309, 27);
            this.enderecoTextBox.TabIndex = 83;
            // 
            // numero_carteiraTextBox
            // 
            this.numero_carteiraTextBox.Location = new System.Drawing.Point(177, 192);
            this.numero_carteiraTextBox.Name = "numero_carteiraTextBox";
            this.numero_carteiraTextBox.Size = new System.Drawing.Size(232, 27);
            this.numero_carteiraTextBox.TabIndex = 77;
            // 
            // data_admissaoDateTimePicker
            // 
            this.data_admissaoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_admissaoDateTimePicker.Location = new System.Drawing.Point(594, 129);
            this.data_admissaoDateTimePicker.Name = "data_admissaoDateTimePicker";
            this.data_admissaoDateTimePicker.Size = new System.Drawing.Size(233, 27);
            this.data_admissaoDateTimePicker.TabIndex = 85;
            // 
            // cbCodFuncao
            // 
            this.cbCodFuncao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodFuncao.FormattingEnabled = true;
            this.cbCodFuncao.Location = new System.Drawing.Point(518, 162);
            this.cbCodFuncao.Name = "cbCodFuncao";
            this.cbCodFuncao.Size = new System.Drawing.Size(309, 26);
            this.cbCodFuncao.TabIndex = 87;
            // 
            // data_nascimentoDateTimePicker
            // 
            this.data_nascimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_nascimentoDateTimePicker.Location = new System.Drawing.Point(194, 93);
            this.data_nascimentoDateTimePicker.Name = "data_nascimentoDateTimePicker";
            this.data_nascimentoDateTimePicker.Size = new System.Drawing.Size(215, 27);
            this.data_nascimentoDateTimePicker.TabIndex = 71;
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.fb1;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.Location = new System.Drawing.Point(837, 15);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(81, 50);
            this.btnNovo.TabIndex = 66;
            this.toolTip1.SetToolTip(this.btnNovo, "Novo");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click_1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.xde;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.Location = new System.Drawing.Point(924, 69);
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
            this.btnExcluir.Location = new System.Drawing.Point(837, 69);
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
            this.btnEditar.Location = new System.Drawing.Point(924, 15);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(81, 50);
            this.btnEditar.TabIndex = 58;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.ex1;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Location = new System.Drawing.Point(1013, 15);
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
            this.groupBox3.Location = new System.Drawing.Point(837, 128);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(225, 129);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consultar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(121, 45);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(102, 30);
            this.btnActualizar.TabIndex = 26;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(72, 45);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(49, 30);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "OK";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(10, 46);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(59, 27);
            this.txtBuscarCodigo.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pelo nome";
            // 
            // txtBuscarNome
            // 
            this.txtBuscarNome.Location = new System.Drawing.Point(14, 97);
            this.txtBuscarNome.Name = "txtBuscarNome";
            this.txtBuscarNome.Size = new System.Drawing.Size(205, 27);
            this.txtBuscarNome.TabIndex = 2;
            this.txtBuscarNome.TextChanged += new System.EventHandler(this.txtBuscarNome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 21);
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
            this.groupBox1.Font = new System.Drawing.Font("Vivaldi", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1068, 126);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(447, 53);
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
            this.lblLogin.Location = new System.Drawing.Point(767, 88);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(299, 23);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Cadastrar Funcionário Geral";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // bITextBox
            // 
            this.bITextBox.Location = new System.Drawing.Point(182, 126);
            this.bITextBox.Mask = "000000000LA000";
            this.bITextBox.Name = "bITextBox";
            this.bITextBox.Size = new System.Drawing.Size(227, 27);
            this.bITextBox.TabIndex = 89;
            // 
            // telefoneTextBox
            // 
            this.telefoneTextBox.Location = new System.Drawing.Point(518, 60);
            this.telefoneTextBox.Mask = "900000000";
            this.telefoneTextBox.Name = "telefoneTextBox";
            this.telefoneTextBox.Size = new System.Drawing.Size(175, 27);
            this.telefoneTextBox.TabIndex = 90;
            // 
            // frmCadastrarFuncionarioGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1068, 599);
            this.Controls.Add(this.funcionarioGeralDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastrarFuncionarioGeral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Funcionario Geral";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastrarFuncionario_Geral_FormClosed);
            this.Load += new System.EventHandler(this.frmCadastrarAdministrativo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioGeralDataGridView)).EndInit();
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

        private System.Windows.Forms.DataGridView funcionarioGeralDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox codFuncionarioTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox numero_carteiraTextBox;
        private System.Windows.Forms.DateTimePicker data_admissaoDateTimePicker;
        private System.Windows.Forms.ComboBox cbCodFuncao;
        private System.Windows.Forms.DateTimePicker data_nascimentoDateTimePicker;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblCodFuncionario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblBI;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNumero_carteira;
        private System.Windows.Forms.Label lblData_admissao;
        private System.Windows.Forms.Label lblCodFuncao;
        private System.Windows.Forms.Label lblData_nascimento;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.MaskedTextBox bITextBox;
        private System.Windows.Forms.MaskedTextBox telefoneTextBox;
    }
}