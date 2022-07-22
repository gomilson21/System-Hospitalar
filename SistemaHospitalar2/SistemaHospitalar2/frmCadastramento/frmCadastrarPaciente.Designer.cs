namespace SistemaHospitalar2.frmCadastramento
{
    partial class frmCadastrarPaciente
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
            System.Windows.Forms.Label codPacienteLabel;
            System.Windows.Forms.Label nome_pacienteLabel;
            System.Windows.Forms.Label dataNascimento_pacienteLabel;
            System.Windows.Forms.Label sexo_pacienteLabel;
            System.Windows.Forms.Label bI_pacienteLabel;
            System.Windows.Forms.Label telefone_pacienteLabel;
            System.Windows.Forms.Label endereco_pacienteLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pacienteDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bI_pacienteTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telefone_pacienteTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.codPacienteTextBox = new System.Windows.Forms.TextBox();
            this.nome_pacienteTextBox = new System.Windows.Forms.TextBox();
            this.dataNascimento_pacienteDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endereco_pacienteTextBox = new System.Windows.Forms.TextBox();
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
            codPacienteLabel = new System.Windows.Forms.Label();
            nome_pacienteLabel = new System.Windows.Forms.Label();
            dataNascimento_pacienteLabel = new System.Windows.Forms.Label();
            sexo_pacienteLabel = new System.Windows.Forms.Label();
            bI_pacienteLabel = new System.Windows.Forms.Label();
            telefone_pacienteLabel = new System.Windows.Forms.Label();
            endereco_pacienteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // codPacienteLabel
            // 
            codPacienteLabel.AutoSize = true;
            codPacienteLabel.Location = new System.Drawing.Point(11, 25);
            codPacienteLabel.Name = "codPacienteLabel";
            codPacienteLabel.Size = new System.Drawing.Size(64, 18);
            codPacienteLabel.TabIndex = 83;
            codPacienteLabel.Text = "Código";
            // 
            // nome_pacienteLabel
            // 
            nome_pacienteLabel.AutoSize = true;
            nome_pacienteLabel.Location = new System.Drawing.Point(11, 58);
            nome_pacienteLabel.Name = "nome_pacienteLabel";
            nome_pacienteLabel.Size = new System.Drawing.Size(164, 18);
            nome_pacienteLabel.TabIndex = 85;
            nome_pacienteLabel.Text = "Nome do Paciente:";
            // 
            // dataNascimento_pacienteLabel
            // 
            dataNascimento_pacienteLabel.AutoSize = true;
            dataNascimento_pacienteLabel.Location = new System.Drawing.Point(11, 92);
            dataNascimento_pacienteLabel.Name = "dataNascimento_pacienteLabel";
            dataNascimento_pacienteLabel.Size = new System.Drawing.Size(182, 18);
            dataNascimento_pacienteLabel.TabIndex = 87;
            dataNascimento_pacienteLabel.Text = "Data de Nascimento:";
            // 
            // sexo_pacienteLabel
            // 
            sexo_pacienteLabel.AutoSize = true;
            sexo_pacienteLabel.Location = new System.Drawing.Point(11, 124);
            sexo_pacienteLabel.Name = "sexo_pacienteLabel";
            sexo_pacienteLabel.Size = new System.Drawing.Size(156, 18);
            sexo_pacienteLabel.TabIndex = 89;
            sexo_pacienteLabel.Text = "Sexo do Paciente:";
            // 
            // bI_pacienteLabel
            // 
            bI_pacienteLabel.AutoSize = true;
            bI_pacienteLabel.Location = new System.Drawing.Point(11, 157);
            bI_pacienteLabel.Name = "bI_pacienteLabel";
            bI_pacienteLabel.Size = new System.Drawing.Size(135, 18);
            bI_pacienteLabel.TabIndex = 91;
            bI_pacienteLabel.Text = "BI do Paciente:";
            // 
            // telefone_pacienteLabel
            // 
            telefone_pacienteLabel.AutoSize = true;
            telefone_pacienteLabel.Location = new System.Drawing.Point(11, 190);
            telefone_pacienteLabel.Name = "telefone_pacienteLabel";
            telefone_pacienteLabel.Size = new System.Drawing.Size(179, 18);
            telefone_pacienteLabel.TabIndex = 93;
            telefone_pacienteLabel.Text = "Número do Telefone:";
            // 
            // endereco_pacienteLabel
            // 
            endereco_pacienteLabel.AutoSize = true;
            endereco_pacienteLabel.Location = new System.Drawing.Point(11, 223);
            endereco_pacienteLabel.Name = "endereco_pacienteLabel";
            endereco_pacienteLabel.Size = new System.Drawing.Size(191, 18);
            endereco_pacienteLabel.TabIndex = 95;
            endereco_pacienteLabel.Text = "Endereço do Paciente:";
            // 
            // pacienteDataGridView
            // 
            this.pacienteDataGridView.AllowUserToAddRows = false;
            this.pacienteDataGridView.AllowUserToDeleteRows = false;
            this.pacienteDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.pacienteDataGridView.ColumnHeadersHeight = 30;
            this.pacienteDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.pacienteDataGridView.Location = new System.Drawing.Point(0, 126);
            this.pacienteDataGridView.Name = "pacienteDataGridView";
            this.pacienteDataGridView.ReadOnly = true;
            this.pacienteDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pacienteDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.pacienteDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.pacienteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pacienteDataGridView.Size = new System.Drawing.Size(750, 186);
            this.pacienteDataGridView.TabIndex = 40;
            this.pacienteDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.marcacaoConsultaDataGridView_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bI_pacienteTextBox);
            this.groupBox2.Controls.Add(this.telefone_pacienteTextBox);
            this.groupBox2.Controls.Add(this.cbSexo);
            this.groupBox2.Controls.Add(codPacienteLabel);
            this.groupBox2.Controls.Add(this.codPacienteTextBox);
            this.groupBox2.Controls.Add(nome_pacienteLabel);
            this.groupBox2.Controls.Add(this.nome_pacienteTextBox);
            this.groupBox2.Controls.Add(dataNascimento_pacienteLabel);
            this.groupBox2.Controls.Add(this.dataNascimento_pacienteDateTimePicker);
            this.groupBox2.Controls.Add(sexo_pacienteLabel);
            this.groupBox2.Controls.Add(bI_pacienteLabel);
            this.groupBox2.Controls.Add(telefone_pacienteLabel);
            this.groupBox2.Controls.Add(endereco_pacienteLabel);
            this.groupBox2.Controls.Add(this.endereco_pacienteTextBox);
            this.groupBox2.Controls.Add(this.btnNovo);
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnSair);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(750, 270);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            // 
            // bI_pacienteTextBox
            // 
            this.bI_pacienteTextBox.Location = new System.Drawing.Point(200, 154);
            this.bI_pacienteTextBox.Mask = "000000000LA000";
            this.bI_pacienteTextBox.Name = "bI_pacienteTextBox";
            this.bI_pacienteTextBox.Size = new System.Drawing.Size(227, 27);
            this.bI_pacienteTextBox.TabIndex = 98;
            // 
            // telefone_pacienteTextBox
            // 
            this.telefone_pacienteTextBox.Location = new System.Drawing.Point(200, 187);
            this.telefone_pacienteTextBox.Mask = "900000000";
            this.telefone_pacienteTextBox.Name = "telefone_pacienteTextBox";
            this.telefone_pacienteTextBox.Size = new System.Drawing.Size(175, 27);
            this.telefone_pacienteTextBox.TabIndex = 99;
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbSexo.Location = new System.Drawing.Point(200, 121);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(200, 26);
            this.cbSexo.TabIndex = 97;
            // 
            // codPacienteTextBox
            // 
            this.codPacienteTextBox.Location = new System.Drawing.Point(200, 22);
            this.codPacienteTextBox.Name = "codPacienteTextBox";
            this.codPacienteTextBox.ReadOnly = true;
            this.codPacienteTextBox.Size = new System.Drawing.Size(293, 27);
            this.codPacienteTextBox.TabIndex = 84;
            // 
            // nome_pacienteTextBox
            // 
            this.nome_pacienteTextBox.Location = new System.Drawing.Point(200, 55);
            this.nome_pacienteTextBox.Name = "nome_pacienteTextBox";
            this.nome_pacienteTextBox.ReadOnly = true;
            this.nome_pacienteTextBox.Size = new System.Drawing.Size(293, 27);
            this.nome_pacienteTextBox.TabIndex = 86;
            // 
            // dataNascimento_pacienteDateTimePicker
            // 
            this.dataNascimento_pacienteDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNascimento_pacienteDateTimePicker.Location = new System.Drawing.Point(200, 88);
            this.dataNascimento_pacienteDateTimePicker.Name = "dataNascimento_pacienteDateTimePicker";
            this.dataNascimento_pacienteDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.dataNascimento_pacienteDateTimePicker.TabIndex = 88;
            // 
            // endereco_pacienteTextBox
            // 
            this.endereco_pacienteTextBox.Location = new System.Drawing.Point(200, 220);
            this.endereco_pacienteTextBox.Name = "endereco_pacienteTextBox";
            this.endereco_pacienteTextBox.ReadOnly = true;
            this.endereco_pacienteTextBox.Size = new System.Drawing.Size(293, 27);
            this.endereco_pacienteTextBox.TabIndex = 96;
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.fb1;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.Location = new System.Drawing.Point(509, 23);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(81, 50);
            this.btnNovo.TabIndex = 83;
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
            this.btnSalvar.TabIndex = 82;
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
            this.btnExcluir.TabIndex = 81;
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
            this.btnEditar.TabIndex = 80;
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
            this.btnSair.TabIndex = 32;
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
            this.groupBox3.Size = new System.Drawing.Size(241, 129);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consultar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(142, 48);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(97, 30);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(94, 48);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 30);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "OK";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(12, 49);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(78, 27);
            this.txtBuscarCodigo.TabIndex = 6;
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
            this.groupBox1.Size = new System.Drawing.Size(750, 126);
            this.groupBox1.TabIndex = 39;
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
            this.lblLogin.Location = new System.Drawing.Point(541, 89);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(203, 23);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Cadastrar Paciente";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCadastrarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(750, 585);
            this.Controls.Add(this.pacienteDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmCadastrarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Paciente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastrarPaciente_FormClosed);
            this.Load += new System.EventHandler(this.frmCadastrarPaciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacienteDataGridView)).EndInit();
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

        private System.Windows.Forms.DataGridView pacienteDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.TextBox codPacienteTextBox;
        private System.Windows.Forms.TextBox nome_pacienteTextBox;
        private System.Windows.Forms.DateTimePicker dataNascimento_pacienteDateTimePicker;
        private System.Windows.Forms.TextBox endereco_pacienteTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox bI_pacienteTextBox;
        private System.Windows.Forms.MaskedTextBox telefone_pacienteTextBox;
    }
}