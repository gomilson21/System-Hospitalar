namespace SistemaHospitalar2
{
    partial class frmCadastrarAla_Hospitalar
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
            System.Windows.Forms.Label codAlaLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.alaHospitalarDataGridView = new System.Windows.Forms.DataGridView();
            this.codAlaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_ala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao_ala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ala_HospitalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_HospitalDataSet = new SistemaHospitalar2.db_HospitalDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.codAlaTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ala_HospitalarTableAdapter = new SistemaHospitalar2.db_HospitalDataSetTableAdapters.Ala_HospitalarTableAdapter();
            this.tableAdapterManager = new SistemaHospitalar2.db_HospitalDataSetTableAdapters.TableAdapterManager();
            codAlaLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alaHospitalarDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ala_HospitalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // codAlaLabel
            // 
            codAlaLabel.AutoSize = true;
            codAlaLabel.Location = new System.Drawing.Point(12, 23);
            codAlaLabel.Name = "codAlaLabel";
            codAlaLabel.Size = new System.Drawing.Size(71, 18);
            codAlaLabel.TabIndex = 58;
            codAlaLabel.Text = "Código:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(12, 56);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(62, 18);
            nomeLabel.TabIndex = 60;
            nomeLabel.Text = "Nome:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(12, 110);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(93, 18);
            descricaoLabel.TabIndex = 62;
            descricaoLabel.Text = "Descrição:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblLogin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 126);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 48);
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
            this.lblLogin.Location = new System.Drawing.Point(331, 90);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(295, 23);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Cadastrar Sessão Hospitalar";
            // 
            // alaHospitalarDataGridView
            // 
            this.alaHospitalarDataGridView.AllowUserToAddRows = false;
            this.alaHospitalarDataGridView.AllowUserToDeleteRows = false;
            this.alaHospitalarDataGridView.AutoGenerateColumns = false;
            this.alaHospitalarDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.alaHospitalarDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.alaHospitalarDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.alaHospitalarDataGridView.ColumnHeadersHeight = 30;
            this.alaHospitalarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codAlaDataGridViewTextBoxColumn,
            this.nome_ala,
            this.descricao_ala});
            this.alaHospitalarDataGridView.DataSource = this.ala_HospitalarBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.alaHospitalarDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.alaHospitalarDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.alaHospitalarDataGridView.Location = new System.Drawing.Point(0, 126);
            this.alaHospitalarDataGridView.Name = "alaHospitalarDataGridView";
            this.alaHospitalarDataGridView.ReadOnly = true;
            this.alaHospitalarDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.alaHospitalarDataGridView.Size = new System.Drawing.Size(629, 200);
            this.alaHospitalarDataGridView.TabIndex = 28;
            this.alaHospitalarDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.alaHospitalarDataGridView_CellClick);
            // 
            // codAlaDataGridViewTextBoxColumn
            // 
            this.codAlaDataGridViewTextBoxColumn.DataPropertyName = "codAla";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codAlaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.codAlaDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codAlaDataGridViewTextBoxColumn.Name = "codAlaDataGridViewTextBoxColumn";
            this.codAlaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nome_ala
            // 
            this.nome_ala.DataPropertyName = "nome_ala";
            this.nome_ala.HeaderText = "Nome Sessão";
            this.nome_ala.Name = "nome_ala";
            this.nome_ala.ReadOnly = true;
            this.nome_ala.Width = 220;
            // 
            // descricao_ala
            // 
            this.descricao_ala.DataPropertyName = "descricao_ala";
            this.descricao_ala.HeaderText = "Descrição Sessão";
            this.descricao_ala.Name = "descricao_ala";
            this.descricao_ala.ReadOnly = true;
            this.descricao_ala.Width = 300;
            // 
            // ala_HospitalarBindingSource
            // 
            this.ala_HospitalarBindingSource.DataMember = "Ala_Hospitalar";
            this.ala_HospitalarBindingSource.DataSource = this.db_HospitalDataSet;
            // 
            // db_HospitalDataSet
            // 
            this.db_HospitalDataSet.DataSetName = "db_HospitalDataSet";
            this.db_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(codAlaLabel);
            this.groupBox2.Controls.Add(this.codAlaTextBox);
            this.groupBox2.Controls.Add(nomeLabel);
            this.groupBox2.Controls.Add(this.nomeTextBox);
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
            this.groupBox2.Location = new System.Drawing.Point(0, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 277);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // codAlaTextBox
            // 
            this.codAlaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ala_HospitalarBindingSource, "codAla", true));
            this.codAlaTextBox.Location = new System.Drawing.Point(94, 20);
            this.codAlaTextBox.Name = "codAlaTextBox";
            this.codAlaTextBox.ReadOnly = true;
            this.codAlaTextBox.Size = new System.Drawing.Size(179, 27);
            this.codAlaTextBox.TabIndex = 59;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ala_HospitalarBindingSource, "nome_ala", true));
            this.nomeTextBox.Location = new System.Drawing.Point(94, 53);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.ReadOnly = true;
            this.nomeTextBox.Size = new System.Drawing.Size(272, 27);
            this.nomeTextBox.TabIndex = 61;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ala_HospitalarBindingSource, "descricao_ala", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(109, 86);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.ReadOnly = true;
            this.descricaoTextBox.Size = new System.Drawing.Size(257, 122);
            this.descricaoTextBox.TabIndex = 63;
            // 
            // btnNovo
            // 
            this.btnNovo.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.fb2;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.Location = new System.Drawing.Point(382, 18);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(81, 50);
            this.btnNovo.TabIndex = 58;
            this.toolTip1.SetToolTip(this.btnNovo, "Novo");
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.xde;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.Location = new System.Drawing.Point(472, 73);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(81, 50);
            this.btnSalvar.TabIndex = 57;
            this.toolTip1.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.exe;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.Location = new System.Drawing.Point(382, 73);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(81, 50);
            this.btnExcluir.TabIndex = 56;
            this.toolTip1.SetToolTip(this.btnExcluir, "Eliminar");
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.edre;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditar.Location = new System.Drawing.Point(472, 20);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(81, 50);
            this.btnEditar.TabIndex = 55;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.ex1;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Location = new System.Drawing.Point(564, 20);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(54, 102);
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
            this.groupBox3.Location = new System.Drawing.Point(378, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 134);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consultar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(139, 48);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(98, 30);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(89, 48);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(45, 30);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "OK";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(11, 49);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(74, 27);
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
            this.txtBuscarNome.Location = new System.Drawing.Point(11, 98);
            this.txtBuscarNome.Name = "txtBuscarNome";
            this.txtBuscarNome.Size = new System.Drawing.Size(226, 27);
            this.txtBuscarNome.TabIndex = 2;
            this.txtBuscarNome.TextChanged += new System.EventHandler(this.txtBuscarNome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pelo código";
            // 
            // ala_HospitalarTableAdapter
            // 
            this.ala_HospitalarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Ala_HospitalarTableAdapter = this.ala_HospitalarTableAdapter;
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
            this.tableAdapterManager.TratamentoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaHospitalar2.db_HospitalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // frmCadastrarAla_Hospitalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(629, 604);
            this.Controls.Add(this.alaHospitalarDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmCadastrarAla_Hospitalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Ala Hospitalar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadastrarAla_Hospitalar_FormClosed);
            this.Load += new System.EventHandler(this.frmCadastrarAla_Hospitalar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alaHospitalarDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ala_HospitalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.DataGridView alaHospitalarDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscarNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnNovo;
        private db_HospitalDataSet db_HospitalDataSet;
        private System.Windows.Forms.BindingSource ala_HospitalarBindingSource;
        private db_HospitalDataSetTableAdapters.Ala_HospitalarTableAdapter ala_HospitalarTableAdapter;
        private db_HospitalDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox codAlaTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAlaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_ala;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao_ala;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
    }
}