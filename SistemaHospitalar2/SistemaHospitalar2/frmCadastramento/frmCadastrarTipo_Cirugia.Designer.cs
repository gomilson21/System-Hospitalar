namespace SistemaHospitalar2.frmCadastramento
{
    partial class frmCadastrarTipo_Cirugia
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
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label codTipo_CirugiaLabel;
            System.Windows.Forms.Label nome_cirugiaLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableAdapterManager = new SistemaHospitalar2.db_HospitalDataSetTableAdapters.TableAdapterManager();
            this.tipo_CirugiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_HospitalDataSet = new SistemaHospitalar2.db_HospitalDataSet();
            this.tipo_CirugiaTableAdapter = new SistemaHospitalar2.db_HospitalDataSetTableAdapters.Tipo_CirugiaTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscarNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.codTipo_CirugiaTextBox = new System.Windows.Forms.TextBox();
            this.nome_cirugiaTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tipoCirugiaDataGridView = new System.Windows.Forms.DataGridView();
            this.codTipoCirugiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeTipoCirugiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoTipoCirugiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            descricaoLabel = new System.Windows.Forms.Label();
            codTipo_CirugiaLabel = new System.Windows.Forms.Label();
            nome_cirugiaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tipo_CirugiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoCirugiaDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(11, 113);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(93, 18);
            descricaoLabel.TabIndex = 87;
            descricaoLabel.Text = "Descrição:";
            // 
            // codTipo_CirugiaLabel
            // 
            codTipo_CirugiaLabel.AutoSize = true;
            codTipo_CirugiaLabel.Location = new System.Drawing.Point(11, 28);
            codTipo_CirugiaLabel.Name = "codTipo_CirugiaLabel";
            codTipo_CirugiaLabel.Size = new System.Drawing.Size(71, 18);
            codTipo_CirugiaLabel.TabIndex = 83;
            codTipo_CirugiaLabel.Text = "Código:";
            // 
            // nome_cirugiaLabel
            // 
            nome_cirugiaLabel.AutoSize = true;
            nome_cirugiaLabel.Location = new System.Drawing.Point(11, 62);
            nome_cirugiaLabel.Name = "nome_cirugiaLabel";
            nome_cirugiaLabel.Size = new System.Drawing.Size(151, 18);
            nome_cirugiaLabel.TabIndex = 88;
            nome_cirugiaLabel.Text = "Nome da Cirugia:";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Ala_HospitalarTableAdapter = null;
            this.tableAdapterManager.Alta_Paciente_InternadoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
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
            this.tableAdapterManager.TratamentoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaHospitalar2.db_HospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // tipo_CirugiaBindingSource
            // 
            this.tipo_CirugiaBindingSource.DataMember = "Tipo_Cirugia";
            this.tipo_CirugiaBindingSource.DataSource = this.db_HospitalDataSet;
            // 
            // db_HospitalDataSet
            // 
            this.db_HospitalDataSet.DataSetName = "db_HospitalDataSet";
            this.db_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipo_CirugiaTableAdapter
            // 
            this.tipo_CirugiaTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnActualizar);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.txtBuscarCodigo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtBuscarNome);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(432, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 129);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consultar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(128, 49);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(98, 30);
            this.btnActualizar.TabIndex = 26;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(79, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 30);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "OK";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(14, 50);
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
            this.txtBuscarNome.Size = new System.Drawing.Size(222, 27);
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
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.ex3;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Location = new System.Drawing.Point(610, 25);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(62, 103);
            this.btnSair.TabIndex = 32;
            this.toolTip1.SetToolTip(this.btnSair, "Fechar");
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.edre1;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Location = new System.Drawing.Point(523, 24);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(81, 50);
            this.btnEditar.TabIndex = 80;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.exe1;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.Location = new System.Drawing.Point(433, 77);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(81, 50);
            this.btnExcluir.TabIndex = 81;
            this.toolTip1.SetToolTip(this.btnExcluir, "Eliminar");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.xde1;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.Location = new System.Drawing.Point(523, 77);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(81, 50);
            this.btnSalvar.TabIndex = 82;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.fb1;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.Location = new System.Drawing.Point(433, 24);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(81, 50);
            this.btnNovo.TabIndex = 83;
            this.toolTip1.SetToolTip(this.btnNovo, "Novo");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipo_CirugiaBindingSource, "descricao_TipoCirugia", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(110, 91);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.ReadOnly = true;
            this.descricaoTextBox.Size = new System.Drawing.Size(306, 94);
            this.descricaoTextBox.TabIndex = 88;
            // 
            // codTipo_CirugiaTextBox
            // 
            this.codTipo_CirugiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipo_CirugiaBindingSource, "codTipoCirugia", true));
            this.codTipo_CirugiaTextBox.Location = new System.Drawing.Point(110, 25);
            this.codTipo_CirugiaTextBox.Name = "codTipo_CirugiaTextBox";
            this.codTipo_CirugiaTextBox.ReadOnly = true;
            this.codTipo_CirugiaTextBox.Size = new System.Drawing.Size(196, 27);
            this.codTipo_CirugiaTextBox.TabIndex = 84;
            // 
            // nome_cirugiaTextBox
            // 
            this.nome_cirugiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tipo_CirugiaBindingSource, "nome_TipoCirugia", true));
            this.nome_cirugiaTextBox.Location = new System.Drawing.Point(168, 58);
            this.nome_cirugiaTextBox.Name = "nome_cirugiaTextBox";
            this.nome_cirugiaTextBox.ReadOnly = true;
            this.nome_cirugiaTextBox.Size = new System.Drawing.Size(248, 27);
            this.nome_cirugiaTextBox.TabIndex = 89;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(nome_cirugiaLabel);
            this.groupBox2.Controls.Add(this.nome_cirugiaTextBox);
            this.groupBox2.Controls.Add(codTipo_CirugiaLabel);
            this.groupBox2.Controls.Add(this.codTipo_CirugiaTextBox);
            this.groupBox2.Controls.Add(descricaoLabel);
            this.groupBox2.Controls.Add(this.descricaoTextBox);
            this.groupBox2.Controls.Add(this.btnNovo);
            this.groupBox2.Controls.Add(this.btnSalvar);
            this.groupBox2.Controls.Add(this.btnExcluir);
            this.groupBox2.Controls.Add(this.btnEditar);
            this.groupBox2.Controls.Add(this.btnSair);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 328);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(672, 272);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            // 
            // tipoCirugiaDataGridView
            // 
            this.tipoCirugiaDataGridView.AllowUserToAddRows = false;
            this.tipoCirugiaDataGridView.AllowUserToDeleteRows = false;
            this.tipoCirugiaDataGridView.AutoGenerateColumns = false;
            this.tipoCirugiaDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tipoCirugiaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tipoCirugiaDataGridView.ColumnHeadersHeight = 30;
            this.tipoCirugiaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codTipoCirugiaDataGridViewTextBoxColumn,
            this.nomeTipoCirugiaDataGridViewTextBoxColumn,
            this.descricaoTipoCirugiaDataGridViewTextBoxColumn});
            this.tipoCirugiaDataGridView.DataSource = this.tipo_CirugiaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tipoCirugiaDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.tipoCirugiaDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.tipoCirugiaDataGridView.Location = new System.Drawing.Point(0, 126);
            this.tipoCirugiaDataGridView.Name = "tipoCirugiaDataGridView";
            this.tipoCirugiaDataGridView.ReadOnly = true;
            this.tipoCirugiaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tipoCirugiaDataGridView.Size = new System.Drawing.Size(672, 199);
            this.tipoCirugiaDataGridView.TabIndex = 37;
            this.tipoCirugiaDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tipoCirugiaDataGridView_CellClick);
            // 
            // codTipoCirugiaDataGridViewTextBoxColumn
            // 
            this.codTipoCirugiaDataGridViewTextBoxColumn.DataPropertyName = "codTipoCirugia";
            this.codTipoCirugiaDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codTipoCirugiaDataGridViewTextBoxColumn.Name = "codTipoCirugiaDataGridViewTextBoxColumn";
            this.codTipoCirugiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeTipoCirugiaDataGridViewTextBoxColumn
            // 
            this.nomeTipoCirugiaDataGridViewTextBoxColumn.DataPropertyName = "nome_TipoCirugia";
            this.nomeTipoCirugiaDataGridViewTextBoxColumn.HeaderText = "Nome do Tipo da Cirugia";
            this.nomeTipoCirugiaDataGridViewTextBoxColumn.Name = "nomeTipoCirugiaDataGridViewTextBoxColumn";
            this.nomeTipoCirugiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeTipoCirugiaDataGridViewTextBoxColumn.Width = 230;
            // 
            // descricaoTipoCirugiaDataGridViewTextBoxColumn
            // 
            this.descricaoTipoCirugiaDataGridViewTextBoxColumn.DataPropertyName = "descricao_TipoCirugia";
            this.descricaoTipoCirugiaDataGridViewTextBoxColumn.HeaderText = "Descrição do Tipo da Cirugia";
            this.descricaoTipoCirugiaDataGridViewTextBoxColumn.Name = "descricaoTipoCirugiaDataGridViewTextBoxColumn";
            this.descricaoTipoCirugiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoTipoCirugiaDataGridViewTextBoxColumn.Width = 300;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblLogin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(672, 126);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(177, 49);
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
            this.lblLogin.Location = new System.Drawing.Point(404, 89);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(271, 23);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Cadastrar Tipo de Cirugia";
            // 
            // frmCadastrarTipo_Cirugia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(672, 600);
            this.Controls.Add(this.tipoCirugiaDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCadastrarTipo_Cirugia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Tipo de Cirugia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastrarTipo_Cirugia_FormClosed);
            this.Load += new System.EventHandler(this.frmCadastrarTipo_Cirugia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipo_CirugiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoCirugiaDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private db_HospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource tipo_CirugiaBindingSource;
        private db_HospitalDataSet db_HospitalDataSet;
        private db_HospitalDataSetTableAdapters.Tipo_CirugiaTableAdapter tipo_CirugiaTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox codTipo_CirugiaTextBox;
        private System.Windows.Forms.TextBox nome_cirugiaTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tipoCirugiaDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTipoCirugiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeTipoCirugiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoTipoCirugiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
    }
}