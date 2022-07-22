namespace SistemaHospitalar2.frmCadastramento
{
    partial class frmCadastrarMorte_Paciente
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
            System.Windows.Forms.Label codMorteLabel;
            System.Windows.Forms.Label codPacienteInternadoLabel;
            System.Windows.Forms.Label data_morteLabel;
            System.Windows.Forms.Label hora_morteLabel;
            System.Windows.Forms.Label descricao_morteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarMorte_Paciente));
            System.Windows.Forms.Label lblCausaMorte;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mortePacienteDataGridView = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbCodPacInternado = new System.Windows.Forms.ComboBox();
            this.dtpHoraMorte = new System.Windows.Forms.DateTimePicker();
            this.data_morteDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtCodMorte = new System.Windows.Forms.TextBox();
            this.descricao_morteTextBox = new System.Windows.Forms.TextBox();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.codMedicoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarNome = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCausaMorte = new System.Windows.Forms.TextBox();
            codMedicoLabel = new System.Windows.Forms.Label();
            codMorteLabel = new System.Windows.Forms.Label();
            codPacienteInternadoLabel = new System.Windows.Forms.Label();
            data_morteLabel = new System.Windows.Forms.Label();
            hora_morteLabel = new System.Windows.Forms.Label();
            descricao_morteLabel = new System.Windows.Forms.Label();
            lblCausaMorte = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mortePacienteDataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            // codMorteLabel
            // 
            codMorteLabel.AutoSize = true;
            codMorteLabel.Location = new System.Drawing.Point(8, 19);
            codMorteLabel.Name = "codMorteLabel";
            codMorteLabel.Size = new System.Drawing.Size(71, 18);
            codMorteLabel.TabIndex = 83;
            codMorteLabel.Text = "Código:";
            // 
            // codPacienteInternadoLabel
            // 
            codPacienteInternadoLabel.AutoSize = true;
            codPacienteInternadoLabel.Location = new System.Drawing.Point(8, 51);
            codPacienteInternadoLabel.Name = "codPacienteInternadoLabel";
            codPacienteInternadoLabel.Size = new System.Drawing.Size(164, 18);
            codPacienteInternadoLabel.TabIndex = 85;
            codPacienteInternadoLabel.Text = "Nome do Paciente:";
            // 
            // data_morteLabel
            // 
            data_morteLabel.AutoSize = true;
            data_morteLabel.Location = new System.Drawing.Point(8, 84);
            data_morteLabel.Name = "data_morteLabel";
            data_morteLabel.Size = new System.Drawing.Size(132, 18);
            data_morteLabel.TabIndex = 87;
            data_morteLabel.Text = "Data da Morte:";
            // 
            // hora_morteLabel
            // 
            hora_morteLabel.AutoSize = true;
            hora_morteLabel.Location = new System.Drawing.Point(8, 116);
            hora_morteLabel.Name = "hora_morteLabel";
            hora_morteLabel.Size = new System.Drawing.Size(131, 18);
            hora_morteLabel.TabIndex = 89;
            hora_morteLabel.Text = "Hora da Morte:";
            // 
            // descricao_morteLabel
            // 
            descricao_morteLabel.AutoSize = true;
            descricao_morteLabel.Location = new System.Drawing.Point(8, 198);
            descricao_morteLabel.Name = "descricao_morteLabel";
            descricao_morteLabel.Size = new System.Drawing.Size(171, 18);
            descricao_morteLabel.TabIndex = 91;
            descricao_morteLabel.Text = "Descrição da Morte:";
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
            this.groupBox1.Size = new System.Drawing.Size(787, 126);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(273, 54);
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
            this.lblLogin.Location = new System.Drawing.Point(491, 90);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(294, 23);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Cadastrar Morte do Paciente";
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
            // mortePacienteDataGridView
            // 
            this.mortePacienteDataGridView.AllowUserToAddRows = false;
            this.mortePacienteDataGridView.AllowUserToDeleteRows = false;
            this.mortePacienteDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.mortePacienteDataGridView.ColumnHeadersHeight = 30;
            this.mortePacienteDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.mortePacienteDataGridView.Location = new System.Drawing.Point(0, 126);
            this.mortePacienteDataGridView.Name = "mortePacienteDataGridView";
            this.mortePacienteDataGridView.ReadOnly = true;
            this.mortePacienteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mortePacienteDataGridView.Size = new System.Drawing.Size(787, 188);
            this.mortePacienteDataGridView.TabIndex = 32;
            this.mortePacienteDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mortePacienteDataGridView_CellClick);
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.fb1;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.Location = new System.Drawing.Point(545, 18);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(81, 50);
            this.btnNovo.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnNovo, "Novo");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.xde;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.Location = new System.Drawing.Point(635, 71);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(81, 50);
            this.btnSalvar.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.exe;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.Location = new System.Drawing.Point(545, 71);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(81, 50);
            this.btnExcluir.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnExcluir, "Eliminar");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.edre;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Location = new System.Drawing.Point(635, 18);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(81, 50);
            this.btnEditar.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.ex1;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Location = new System.Drawing.Point(722, 16);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(59, 103);
            this.btnSair.TabIndex = 17;
            this.toolTip1.SetToolTip(this.btnSair, "Fechar");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(lblCausaMorte);
            this.groupBox2.Controls.Add(codMorteLabel);
            this.groupBox2.Controls.Add(codPacienteInternadoLabel);
            this.groupBox2.Controls.Add(this.cbCodPacInternado);
            this.groupBox2.Controls.Add(data_morteLabel);
            this.groupBox2.Controls.Add(this.dtpHoraMorte);
            this.groupBox2.Controls.Add(this.data_morteDateTimePicker);
            this.groupBox2.Controls.Add(hora_morteLabel);
            this.groupBox2.Controls.Add(this.txtCausaMorte);
            this.groupBox2.Controls.Add(this.txtCodMorte);
            this.groupBox2.Controls.Add(descricao_morteLabel);
            this.groupBox2.Controls.Add(this.descricao_morteTextBox);
            this.groupBox2.Controls.Add(this.btnRelatorio);
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
            this.groupBox2.Size = new System.Drawing.Size(787, 317);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // cbCodPacInternado
            // 
            this.cbCodPacInternado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodPacInternado.FormattingEnabled = true;
            this.cbCodPacInternado.Location = new System.Drawing.Point(173, 48);
            this.cbCodPacInternado.Name = "cbCodPacInternado";
            this.cbCodPacInternado.Size = new System.Drawing.Size(355, 26);
            this.cbCodPacInternado.TabIndex = 4;
            // 
            // dtpHoraMorte
            // 
            this.dtpHoraMorte.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraMorte.Location = new System.Drawing.Point(173, 113);
            this.dtpHoraMorte.Name = "dtpHoraMorte";
            this.dtpHoraMorte.Size = new System.Drawing.Size(209, 27);
            this.dtpHoraMorte.TabIndex = 8;
            // 
            // data_morteDateTimePicker
            // 
            this.data_morteDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data_morteDateTimePicker.Location = new System.Drawing.Point(173, 80);
            this.data_morteDateTimePicker.Name = "data_morteDateTimePicker";
            this.data_morteDateTimePicker.Size = new System.Drawing.Size(209, 27);
            this.data_morteDateTimePicker.TabIndex = 6;
            // 
            // txtCodMorte
            // 
            this.txtCodMorte.Location = new System.Drawing.Point(173, 16);
            this.txtCodMorte.Name = "txtCodMorte";
            this.txtCodMorte.ReadOnly = true;
            this.txtCodMorte.Size = new System.Drawing.Size(209, 27);
            this.txtCodMorte.TabIndex = 2;
            // 
            // descricao_morteTextBox
            // 
            this.descricao_morteTextBox.Location = new System.Drawing.Point(173, 179);
            this.descricao_morteTextBox.Multiline = true;
            this.descricao_morteTextBox.Name = "descricao_morteTextBox";
            this.descricao_morteTextBox.ReadOnly = true;
            this.descricao_morteTextBox.Size = new System.Drawing.Size(355, 81);
            this.descricao_morteTextBox.TabIndex = 12;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.DarkRed;
            this.btnRelatorio.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnRelatorio.Location = new System.Drawing.Point(545, 268);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(223, 45);
            this.btnRelatorio.TabIndex = 24;
            this.btnRelatorio.Text = "Emitir Relatório de Óbito";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
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
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtBuscarNome);
            this.groupBox3.Location = new System.Drawing.Point(545, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 135);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consultar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(129, 46);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(98, 30);
            this.btnActualizar.TabIndex = 21;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(80, 46);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 30);
            this.btnBuscar.TabIndex = 20;
            this.btnBuscar.Text = "OK";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(15, 47);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(62, 27);
            this.txtBuscarCodigo.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pelo nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pelo Nome";
            // 
            // txtBuscarNome
            // 
            this.txtBuscarNome.Location = new System.Drawing.Point(14, 100);
            this.txtBuscarNome.Name = "txtBuscarNome";
            this.txtBuscarNome.Size = new System.Drawing.Size(214, 27);
            this.txtBuscarNome.TabIndex = 23;
            this.txtBuscarNome.TextChanged += new System.EventHandler(this.txtBuscarNome_TextChanged_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtCausaMorte
            // 
            this.txtCausaMorte.Location = new System.Drawing.Point(173, 146);
            this.txtCausaMorte.Name = "txtCausaMorte";
            this.txtCausaMorte.ReadOnly = true;
            this.txtCausaMorte.Size = new System.Drawing.Size(355, 27);
            this.txtCausaMorte.TabIndex = 10;
            // 
            // lblCausaMorte
            // 
            lblCausaMorte.AutoSize = true;
            lblCausaMorte.Location = new System.Drawing.Point(8, 149);
            lblCausaMorte.Name = "lblCausaMorte";
            lblCausaMorte.Size = new System.Drawing.Size(143, 18);
            lblCausaMorte.TabIndex = 83;
            lblCausaMorte.Text = "Causa da Morte:";
            // 
            // frmCadastrarMorte_PacienteInternado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(787, 637);
            this.Controls.Add(this.mortePacienteDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCadastrarMorte_PacienteInternado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Morte do Paciente Internado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastrarMorte_PacienteInternado_FormClosed);
            this.Load += new System.EventHandler(this.frmAlta_PacienteInternado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mortePacienteDataGridView)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView mortePacienteDataGridView;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.TextBox codMedicoTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.DateTimePicker data_morteDateTimePicker;
        private System.Windows.Forms.TextBox txtCodMorte;
        private System.Windows.Forms.TextBox descricao_morteTextBox;
        public System.Windows.Forms.ComboBox cbCodPacInternado;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.DateTimePicker dtpHoraMorte;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtCausaMorte;
    }
}