namespace SistemaHospitalar2.frmConsulta
{
    partial class frmConsultarFornecedor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fornecedorDataGridView = new System.Windows.Forms.DataGridView();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_HospitalDataSet = new SistemaHospitalar2.db_HospitalDataSet();
            this.fornecedorTableAdapter = new SistemaHospitalar2.db_HospitalDataSetTableAdapters.FornecedorTableAdapter();
            this.codFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endereco_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacionalidade_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iniciocontratoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fimcontratoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFormaPesquisa = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblLogin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 126);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(251, 50);
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
            this.lblLogin.Location = new System.Drawing.Point(476, 89);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(224, 23);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Consultar Fornecedor";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnActualizar);
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cbFormaPesquisa);
            this.groupBox3.Controls.Add(this.txtPesquisa);
            this.groupBox3.Location = new System.Drawing.Point(12, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(581, 100);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Faça a sua consulta";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(14, 26);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(451, 27);
            this.txtPesquisa.TabIndex = 33;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.ex4;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Location = new System.Drawing.Point(630, 138);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(70, 75);
            this.btnSair.TabIndex = 38;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fornecedorDataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(705, 240);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // fornecedorDataGridView
            // 
            this.fornecedorDataGridView.AllowUserToAddRows = false;
            this.fornecedorDataGridView.AllowUserToDeleteRows = false;
            this.fornecedorDataGridView.AutoGenerateColumns = false;
            this.fornecedorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fornecedorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codFornecedorDataGridViewTextBoxColumn,
            this.nome_fornecedor,
            this.telefone_fornecedor,
            this.endereco_fornecedor,
            this.nacionalidade_fornecedor,
            this.email_fornecedor,
            this.iniciocontratoDataGridViewTextBoxColumn,
            this.fimcontratoDataGridViewTextBoxColumn});
            this.fornecedorDataGridView.DataSource = this.fornecedorBindingSource;
            this.fornecedorDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fornecedorDataGridView.Location = new System.Drawing.Point(3, 23);
            this.fornecedorDataGridView.Name = "fornecedorDataGridView";
            this.fornecedorDataGridView.ReadOnly = true;
            this.fornecedorDataGridView.Size = new System.Drawing.Size(699, 214);
            this.fornecedorDataGridView.TabIndex = 32;
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "Fornecedor";
            this.fornecedorBindingSource.DataSource = this.db_HospitalDataSet;
            // 
            // db_HospitalDataSet
            // 
            this.db_HospitalDataSet.DataSetName = "db_HospitalDataSet";
            this.db_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // codFornecedorDataGridViewTextBoxColumn
            // 
            this.codFornecedorDataGridViewTextBoxColumn.DataPropertyName = "codFornecedor";
            this.codFornecedorDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codFornecedorDataGridViewTextBoxColumn.Name = "codFornecedorDataGridViewTextBoxColumn";
            this.codFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.codFornecedorDataGridViewTextBoxColumn.Width = 80;
            // 
            // nome_fornecedor
            // 
            this.nome_fornecedor.DataPropertyName = "nome_fornecedor";
            this.nome_fornecedor.HeaderText = "Nome do Fornecedor";
            this.nome_fornecedor.Name = "nome_fornecedor";
            this.nome_fornecedor.ReadOnly = true;
            this.nome_fornecedor.Width = 230;
            // 
            // telefone_fornecedor
            // 
            this.telefone_fornecedor.DataPropertyName = "telefone_fornecedor";
            this.telefone_fornecedor.HeaderText = "Nº do Telefone";
            this.telefone_fornecedor.Name = "telefone_fornecedor";
            this.telefone_fornecedor.ReadOnly = true;
            this.telefone_fornecedor.Width = 160;
            // 
            // endereco_fornecedor
            // 
            this.endereco_fornecedor.DataPropertyName = "endereco_fornecedor";
            this.endereco_fornecedor.HeaderText = "Endereço";
            this.endereco_fornecedor.Name = "endereco_fornecedor";
            this.endereco_fornecedor.ReadOnly = true;
            this.endereco_fornecedor.Width = 120;
            // 
            // nacionalidade_fornecedor
            // 
            this.nacionalidade_fornecedor.DataPropertyName = "nacionalidade_fornecedor";
            this.nacionalidade_fornecedor.HeaderText = "Nacionalidade ";
            this.nacionalidade_fornecedor.Name = "nacionalidade_fornecedor";
            this.nacionalidade_fornecedor.ReadOnly = true;
            this.nacionalidade_fornecedor.Width = 140;
            // 
            // email_fornecedor
            // 
            this.email_fornecedor.DataPropertyName = "email_fornecedor";
            this.email_fornecedor.HeaderText = "Email do Fornecedor";
            this.email_fornecedor.Name = "email_fornecedor";
            this.email_fornecedor.ReadOnly = true;
            this.email_fornecedor.Width = 200;
            // 
            // iniciocontratoDataGridViewTextBoxColumn
            // 
            this.iniciocontratoDataGridViewTextBoxColumn.DataPropertyName = "inicio_contrato";
            this.iniciocontratoDataGridViewTextBoxColumn.HeaderText = "Início do Contrato";
            this.iniciocontratoDataGridViewTextBoxColumn.Name = "iniciocontratoDataGridViewTextBoxColumn";
            this.iniciocontratoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iniciocontratoDataGridViewTextBoxColumn.Width = 150;
            // 
            // fimcontratoDataGridViewTextBoxColumn
            // 
            this.fimcontratoDataGridViewTextBoxColumn.DataPropertyName = "fim_contrato";
            this.fimcontratoDataGridViewTextBoxColumn.HeaderText = "Fim Contrato";
            this.fimcontratoDataGridViewTextBoxColumn.Name = "fimcontratoDataGridViewTextBoxColumn";
            this.fimcontratoDataGridViewTextBoxColumn.ReadOnly = true;
            this.fimcontratoDataGridViewTextBoxColumn.Width = 120;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(460, 58);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(95, 30);
            this.btnActualizar.TabIndex = 47;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Visible = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(480, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 30);
            this.btnBuscar.TabIndex = 48;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 18);
            this.label2.TabIndex = 46;
            this.label2.Text = "Consultar por:";
            // 
            // cbFormaPesquisa
            // 
            this.cbFormaPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPesquisa.FormattingEnabled = true;
            this.cbFormaPesquisa.Items.AddRange(new object[] {
            "Data do Fim do Contrato",
            "Data do Início do Contrato",
            "Email do Fornecedor",
            "Endereço do Fornecedor",
            "Nacionalidade do Fornecedor",
            "Nome do Fornecedor"});
            this.cbFormaPesquisa.Location = new System.Drawing.Point(142, 60);
            this.cbFormaPesquisa.Name = "cbFormaPesquisa";
            this.cbFormaPesquisa.Size = new System.Drawing.Size(263, 26);
            this.cbFormaPesquisa.Sorted = true;
            this.cbFormaPesquisa.TabIndex = 45;
            this.cbFormaPesquisa.SelectedIndexChanged += new System.EventHandler(this.cbFormaPesquisa_SelectedIndexChanged);
            // 
            // frmConsultarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 478);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmConsultarFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Fornecedor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmConsultarFornecedor_FormClosed);
            this.Load += new System.EventHandler(this.frmConsultarFornecedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView fornecedorDataGridView;
        private db_HospitalDataSet db_HospitalDataSet;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private db_HospitalDataSetTableAdapters.FornecedorTableAdapter fornecedorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn endereco_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacionalidade_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn iniciocontratoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fimcontratoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFormaPesquisa;
    }
}