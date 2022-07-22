namespace SistemaHospitalar2
{
    partial class frmCadastrarTratamento
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
            System.Windows.Forms.Label codTratamentoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tratamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.codTratamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_tratamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao_tratamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tratamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_HospitalDataSet = new SistemaHospitalar2.db_HospitalDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.codTratamentoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
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
            this.btnNovo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tratamentoTableAdapter = new SistemaHospitalar2.db_HospitalDataSetTableAdapters.TratamentoTableAdapter();
            this.tableAdapterManager = new SistemaHospitalar2.db_HospitalDataSetTableAdapters.TableAdapterManager();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            codTratamentoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tratamentoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // codTratamentoLabel
            // 
            codTratamentoLabel.AutoSize = true;
            codTratamentoLabel.Location = new System.Drawing.Point(12, 24);
            codTratamentoLabel.Name = "codTratamentoLabel";
            codTratamentoLabel.Size = new System.Drawing.Size(71, 18);
            codTratamentoLabel.TabIndex = 62;
            codTratamentoLabel.Text = "Código:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(12, 57);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(62, 18);
            nomeLabel.TabIndex = 64;
            nomeLabel.Text = "Nome:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(12, 97);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(93, 18);
            descricaoLabel.TabIndex = 65;
            descricaoLabel.Text = "Descrição:";
            // 
            // tratamentoDataGridView
            // 
            this.tratamentoDataGridView.AllowUserToAddRows = false;
            this.tratamentoDataGridView.AllowUserToDeleteRows = false;
            this.tratamentoDataGridView.AutoGenerateColumns = false;
            this.tratamentoDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tratamentoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tratamentoDataGridView.ColumnHeadersHeight = 30;
            this.tratamentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codTratamentoDataGridViewTextBoxColumn,
            this.nome_tratamento,
            this.descricao_tratamento});
            this.tratamentoDataGridView.DataSource = this.tratamentoBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tratamentoDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.tratamentoDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.tratamentoDataGridView.Location = new System.Drawing.Point(0, 126);
            this.tratamentoDataGridView.Name = "tratamentoDataGridView";
            this.tratamentoDataGridView.ReadOnly = true;
            this.tratamentoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tratamentoDataGridView.Size = new System.Drawing.Size(630, 200);
            this.tratamentoDataGridView.TabIndex = 31;
            this.tratamentoDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tratamentoDataGridView_CellClick);
            // 
            // codTratamentoDataGridViewTextBoxColumn
            // 
            this.codTratamentoDataGridViewTextBoxColumn.DataPropertyName = "codTratamento";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codTratamentoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.codTratamentoDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codTratamentoDataGridViewTextBoxColumn.Name = "codTratamentoDataGridViewTextBoxColumn";
            this.codTratamentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nome_tratamento
            // 
            this.nome_tratamento.DataPropertyName = "nome_tratamento";
            this.nome_tratamento.HeaderText = "Nome do Tratamento";
            this.nome_tratamento.Name = "nome_tratamento";
            this.nome_tratamento.ReadOnly = true;
            this.nome_tratamento.Width = 220;
            // 
            // descricao_tratamento
            // 
            this.descricao_tratamento.DataPropertyName = "descricao_tratamento";
            this.descricao_tratamento.HeaderText = "Descrição do Tratamento";
            this.descricao_tratamento.Name = "descricao_tratamento";
            this.descricao_tratamento.ReadOnly = true;
            this.descricao_tratamento.Width = 300;
            // 
            // tratamentoBindingSource
            // 
            this.tratamentoBindingSource.DataMember = "Tratamento";
            this.tratamentoBindingSource.DataSource = this.db_HospitalDataSet;
            // 
            // db_HospitalDataSet
            // 
            this.db_HospitalDataSet.DataSetName = "db_HospitalDataSet";
            this.db_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(descricaoLabel);
            this.groupBox2.Controls.Add(this.descricaoTextBox);
            this.groupBox2.Controls.Add(codTratamentoLabel);
            this.groupBox2.Controls.Add(this.codTratamentoTextBox);
            this.groupBox2.Controls.Add(nomeLabel);
            this.groupBox2.Controls.Add(this.nomeTextBox);
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnSair);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnNovo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 270);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamentoBindingSource, "descricao_tratamento", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(111, 94);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.ReadOnly = true;
            this.descricaoTextBox.Size = new System.Drawing.Size(264, 141);
            this.descricaoTextBox.TabIndex = 66;
            // 
            // codTratamentoTextBox
            // 
            this.codTratamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamentoBindingSource, "codTratamento", true));
            this.codTratamentoTextBox.Location = new System.Drawing.Point(89, 21);
            this.codTratamentoTextBox.Name = "codTratamentoTextBox";
            this.codTratamentoTextBox.ReadOnly = true;
            this.codTratamentoTextBox.Size = new System.Drawing.Size(184, 27);
            this.codTratamentoTextBox.TabIndex = 63;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamentoBindingSource, "nome_tratamento", true));
            this.nomeTextBox.Location = new System.Drawing.Point(89, 54);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.ReadOnly = true;
            this.nomeTextBox.Size = new System.Drawing.Size(286, 27);
            this.nomeTextBox.TabIndex = 65;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.xde2;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.Location = new System.Drawing.Point(475, 71);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(81, 50);
            this.btnSalvar.TabIndex = 62;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.exe2;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.Location = new System.Drawing.Point(385, 71);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(81, 50);
            this.btnExcluir.TabIndex = 61;
            this.toolTip1.SetToolTip(this.btnExcluir, "Eliminar");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.edre3;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Location = new System.Drawing.Point(475, 18);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(81, 50);
            this.btnEditar.TabIndex = 60;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.ex4;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Location = new System.Drawing.Point(562, 18);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(56, 103);
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
            this.groupBox3.Location = new System.Drawing.Point(381, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 129);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consultar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(130, 49);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(98, 30);
            this.btnActualizar.TabIndex = 26;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(81, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 30);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "OK";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(16, 50);
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
            this.txtBuscarNome.Size = new System.Drawing.Size(216, 27);
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
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.fb1;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.Location = new System.Drawing.Point(385, 16);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(84, 50);
            this.btnNovo.TabIndex = 27;
            this.toolTip1.SetToolTip(this.btnNovo, "Novo");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblLogin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 126);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(155, 50);
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
            this.lblLogin.Location = new System.Drawing.Point(395, 89);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(236, 23);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Cadastrar Tratamento";
            // 
            // tratamentoTableAdapter
            // 
            this.tratamentoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Ala_HospitalarTableAdapter = null;
            this.tableAdapterManager.Alta_Paciente_InternadoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EscolaTableAdapter = null;
            this.tableAdapterManager.Especialidade_MedicoTableAdapter = null;
            this.tableAdapterManager.EstagiarioTableAdapter = null;
            this.tableAdapterManager.ExameTableAdapter = null;
            this.tableAdapterManager.FornecedorTableAdapter = null;
            this.tableAdapterManager.FuncaoTableAdapter = null;
            this.tableAdapterManager.FuncionariosTableAdapter = null;
            this.tableAdapterManager.Marcacao_CirugiaTableAdapter = null;
            this.tableAdapterManager.Marcacao_ConsultaTableAdapter = null;
            this.tableAdapterManager.Material_DescartavelTableAdapter = null;
            this.tableAdapterManager.MedicamentoTableAdapter = null;
            this.tableAdapterManager.MedicoTableAdapter = null;
            this.tableAdapterManager.Paciente_InternadoTableAdapter = null;
            this.tableAdapterManager.QuartoTableAdapter = null;
            this.tableAdapterManager.Tipo_CirugiaTableAdapter = null;
            this.tableAdapterManager.Tipo_ConsultaTableAdapter = null;
            this.tableAdapterManager.Tipo_ExameTableAdapter = null;
            this.tableAdapterManager.TratamentoTableAdapter = this.tratamentoTableAdapter;
            this.tableAdapterManager.UpdateOrder = SistemaHospitalar2.db_HospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // frmCadastrarTratamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(630, 602);
            this.Controls.Add(this.tratamentoDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadastrarTratamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Tratamento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastrarTratamento_FormClosed);
            this.Load += new System.EventHandler(this.frmCadastrarTratamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tratamentoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tratamentoDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private db_HospitalDataSet db_HospitalDataSet;
        private System.Windows.Forms.BindingSource tratamentoBindingSource;
        private db_HospitalDataSetTableAdapters.TratamentoTableAdapter tratamentoTableAdapter;
        private db_HospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox codTratamentoTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTratamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_tratamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao_tratamento;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
    }
}