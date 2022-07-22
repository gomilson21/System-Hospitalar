namespace SistemaHospitalar2
{
    partial class frmCadastrarUsuario
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
            System.Windows.Forms.Label codUsuarioLabel;
            System.Windows.Forms.Label senhaLabel;
            System.Windows.Forms.Label codFuncionarioLabel;
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label confirmar_senhaLabel;
            System.Windows.Forms.Label estado_usuarioLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.estado_usuarioComboBox = new System.Windows.Forms.ComboBox();
            this.codUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.cbCodFuncionarios = new System.Windows.Forms.ComboBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.confirmar_senhaTextBox = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscarNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            codUsuarioLabel = new System.Windows.Forms.Label();
            senhaLabel = new System.Windows.Forms.Label();
            codFuncionarioLabel = new System.Windows.Forms.Label();
            loginLabel = new System.Windows.Forms.Label();
            confirmar_senhaLabel = new System.Windows.Forms.Label();
            estado_usuarioLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // codUsuarioLabel
            // 
            codUsuarioLabel.AutoSize = true;
            codUsuarioLabel.Location = new System.Drawing.Point(7, 23);
            codUsuarioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            codUsuarioLabel.Name = "codUsuarioLabel";
            codUsuarioLabel.Size = new System.Drawing.Size(71, 18);
            codUsuarioLabel.TabIndex = 40;
            codUsuarioLabel.Text = "Código:";
            // 
            // senhaLabel
            // 
            senhaLabel.AutoSize = true;
            senhaLabel.Location = new System.Drawing.Point(7, 85);
            senhaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            senhaLabel.Name = "senhaLabel";
            senhaLabel.Size = new System.Drawing.Size(65, 18);
            senhaLabel.TabIndex = 42;
            senhaLabel.Text = "Senha:";
            // 
            // codFuncionarioLabel
            // 
            codFuncionarioLabel.AutoSize = true;
            codFuncionarioLabel.Location = new System.Drawing.Point(8, 189);
            codFuncionarioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            codFuncionarioLabel.Name = "codFuncionarioLabel";
            codFuncionarioLabel.Size = new System.Drawing.Size(108, 18);
            codFuncionarioLabel.TabIndex = 44;
            codFuncionarioLabel.Text = "Funcionário:";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new System.Drawing.Point(7, 49);
            loginLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(59, 18);
            loginLabel.TabIndex = 46;
            loginLabel.Text = "Login:";
            // 
            // confirmar_senhaLabel
            // 
            confirmar_senhaLabel.AutoSize = true;
            confirmar_senhaLabel.Location = new System.Drawing.Point(7, 111);
            confirmar_senhaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            confirmar_senhaLabel.Name = "confirmar_senhaLabel";
            confirmar_senhaLabel.Size = new System.Drawing.Size(93, 36);
            confirmar_senhaLabel.TabIndex = 48;
            confirmar_senhaLabel.Text = "Confirmar \r\nsenha:";
            // 
            // estado_usuarioLabel
            // 
            estado_usuarioLabel.AutoSize = true;
            estado_usuarioLabel.Location = new System.Drawing.Point(6, 156);
            estado_usuarioLabel.Name = "estado_usuarioLabel";
            estado_usuarioLabel.Size = new System.Drawing.Size(165, 18);
            estado_usuarioLabel.TabIndex = 49;
            estado_usuarioLabel.Text = "Estado do Usuário:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(estado_usuarioLabel);
            this.groupBox2.Controls.Add(this.estado_usuarioComboBox);
            this.groupBox2.Controls.Add(codUsuarioLabel);
            this.groupBox2.Controls.Add(this.codUsuarioTextBox);
            this.groupBox2.Controls.Add(senhaLabel);
            this.groupBox2.Controls.Add(this.senhaTextBox);
            this.groupBox2.Controls.Add(codFuncionarioLabel);
            this.groupBox2.Controls.Add(this.cbCodFuncionarios);
            this.groupBox2.Controls.Add(loginLabel);
            this.groupBox2.Controls.Add(this.loginTextBox);
            this.groupBox2.Controls.Add(confirmar_senhaLabel);
            this.groupBox2.Controls.Add(this.confirmar_senhaTextBox);
            this.groupBox2.Controls.Add(this.btnNovo);
            this.groupBox2.Controls.Add(this.btnSair);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 283);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(639, 245);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // estado_usuarioComboBox
            // 
            this.estado_usuarioComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estado_usuarioComboBox.FormattingEnabled = true;
            this.estado_usuarioComboBox.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.estado_usuarioComboBox.Location = new System.Drawing.Point(181, 147);
            this.estado_usuarioComboBox.Name = "estado_usuarioComboBox";
            this.estado_usuarioComboBox.Size = new System.Drawing.Size(206, 26);
            this.estado_usuarioComboBox.TabIndex = 50;
            // 
            // codUsuarioTextBox
            // 
            this.codUsuarioTextBox.Location = new System.Drawing.Point(80, 20);
            this.codUsuarioTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.codUsuarioTextBox.Name = "codUsuarioTextBox";
            this.codUsuarioTextBox.ReadOnly = true;
            this.codUsuarioTextBox.Size = new System.Drawing.Size(173, 27);
            this.codUsuarioTextBox.TabIndex = 46;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(80, 82);
            this.senhaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.ReadOnly = true;
            this.senhaTextBox.Size = new System.Drawing.Size(307, 27);
            this.senhaTextBox.TabIndex = 43;
            // 
            // cbCodFuncionarios
            // 
            this.cbCodFuncionarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodFuncionarios.FormattingEnabled = true;
            this.cbCodFuncionarios.Location = new System.Drawing.Point(123, 184);
            this.cbCodFuncionarios.Margin = new System.Windows.Forms.Padding(2);
            this.cbCodFuncionarios.Name = "cbCodFuncionarios";
            this.cbCodFuncionarios.Size = new System.Drawing.Size(264, 26);
            this.cbCodFuncionarios.TabIndex = 45;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(80, 51);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.ReadOnly = true;
            this.loginTextBox.Size = new System.Drawing.Size(307, 27);
            this.loginTextBox.TabIndex = 47;
            // 
            // confirmar_senhaTextBox
            // 
            this.confirmar_senhaTextBox.Location = new System.Drawing.Point(123, 113);
            this.confirmar_senhaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.confirmar_senhaTextBox.Name = "confirmar_senhaTextBox";
            this.confirmar_senhaTextBox.ReadOnly = true;
            this.confirmar_senhaTextBox.Size = new System.Drawing.Size(264, 27);
            this.confirmar_senhaTextBox.TabIndex = 49;
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.fb1;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.Location = new System.Drawing.Point(410, 15);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(80, 49);
            this.btnNovo.TabIndex = 40;
            this.toolTip1.SetToolTip(this.btnNovo, "Novo");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click_1);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.ex1;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Location = new System.Drawing.Point(578, 15);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(57, 96);
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
            this.groupBox3.Location = new System.Drawing.Point(404, 119);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(231, 124);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consultar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(126, 37);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(98, 30);
            this.btnActualizar.TabIndex = 26;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(77, 37);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 30);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "OK";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(8, 38);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(66, 27);
            this.txtBuscarCodigo.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pelo nome";
            // 
            // txtBuscarNome
            // 
            this.txtBuscarNome.Location = new System.Drawing.Point(8, 89);
            this.txtBuscarNome.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscarNome.Name = "txtBuscarNome";
            this.txtBuscarNome.Size = new System.Drawing.Size(216, 27);
            this.txtBuscarNome.TabIndex = 2;
            this.txtBuscarNome.TextChanged += new System.EventHandler(this.txtBuscarNome_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pelo código";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.xde;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.Location = new System.Drawing.Point(494, 66);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(80, 49);
            this.btnSalvar.TabIndex = 30;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.exe;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.Location = new System.Drawing.Point(410, 66);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(80, 49);
            this.btnExcluir.TabIndex = 29;
            this.toolTip1.SetToolTip(this.btnExcluir, "Eliminar");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.edre;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Location = new System.Drawing.Point(494, 13);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(80, 49);
            this.btnEditar.TabIndex = 28;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // usuarioDataGridView
            // 
            this.usuarioDataGridView.AllowUserToAddRows = false;
            this.usuarioDataGridView.AllowUserToDeleteRows = false;
            this.usuarioDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usuarioDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.usuarioDataGridView.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usuarioDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.usuarioDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.usuarioDataGridView.Location = new System.Drawing.Point(0, 99);
            this.usuarioDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.usuarioDataGridView.Name = "usuarioDataGridView";
            this.usuarioDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usuarioDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.usuarioDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usuarioDataGridView.Size = new System.Drawing.Size(639, 182);
            this.usuarioDataGridView.TabIndex = 32;
            this.usuarioDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usuarioDataGridView_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblLogin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(639, 99);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(103, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.lblLogin.Location = new System.Drawing.Point(436, 61);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(197, 23);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Cadastrar Usuário";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmCadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(639, 528);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.usuarioDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Usuário";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastrarUsuario_FormClosed);
            this.Load += new System.EventHandler(this.frmCadastrarUsuario_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridView usuarioDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox codUsuarioTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.ComboBox cbCodFuncionarios;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox confirmar_senhaTextBox;
        private System.Windows.Forms.ComboBox estado_usuarioComboBox;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
    }
}