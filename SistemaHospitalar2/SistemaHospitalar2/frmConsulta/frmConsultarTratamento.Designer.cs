namespace SistemaHospitalar2.frmConsulta
{
    partial class frmConsultarTratamento
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
            this.tratamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.tratamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_HospitalDataSet = new SistemaHospitalar2.db_HospitalDataSet();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.tratamentoTableAdapter = new SistemaHospitalar2.db_HospitalDataSetTableAdapters.TratamentoTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.codTratamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_tratamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao_tratamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tratamentoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(621, 126);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 51);
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
            this.lblLogin.Location = new System.Drawing.Point(387, 88);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(231, 23);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Consultar Tratamento";
            // 
            // tratamentoDataGridView
            // 
            this.tratamentoDataGridView.AllowUserToAddRows = false;
            this.tratamentoDataGridView.AllowUserToDeleteRows = false;
            this.tratamentoDataGridView.AutoGenerateColumns = false;
            this.tratamentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tratamentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codTratamentoDataGridViewTextBoxColumn,
            this.nome_tratamento,
            this.descricao_tratamento});
            this.tratamentoDataGridView.DataSource = this.tratamentoBindingSource;
            this.tratamentoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tratamentoDataGridView.Location = new System.Drawing.Point(3, 22);
            this.tratamentoDataGridView.Name = "tratamentoDataGridView";
            this.tratamentoDataGridView.ReadOnly = true;
            this.tratamentoDataGridView.Size = new System.Drawing.Size(615, 215);
            this.tratamentoDataGridView.TabIndex = 32;
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
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(6, 26);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(444, 26);
            this.txtPesquisa.TabIndex = 33;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // tratamentoTableAdapter
            // 
            this.tratamentoTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tratamentoDataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 240);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.ex4;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Location = new System.Drawing.Point(538, 132);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(71, 68);
            this.btnSair.TabIndex = 35;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPesquisa);
            this.groupBox3.Location = new System.Drawing.Point(12, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(497, 68);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Faça a sua consulta";
            // 
            // codTratamentoDataGridViewTextBoxColumn
            // 
            this.codTratamentoDataGridViewTextBoxColumn.DataPropertyName = "codTratamento";
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
            this.nome_tratamento.Width = 200;
            // 
            // descricao_tratamento
            // 
            this.descricao_tratamento.DataPropertyName = "descricao_tratamento";
            this.descricao_tratamento.HeaderText = "Descrição do Tratamento";
            this.descricao_tratamento.Name = "descricao_tratamento";
            this.descricao_tratamento.ReadOnly = true;
            this.descricao_tratamento.Width = 300;
            // 
            // frmConsultarTratamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 446);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConsultarTratamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Tratamento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmConsultarTratamento_FormClosed);
            this.Load += new System.EventHandler(this.frmConsultarTratamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tratamentoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.DataGridView tratamentoDataGridView;
        private System.Windows.Forms.TextBox txtPesquisa;
        private db_HospitalDataSet db_HospitalDataSet;
        private System.Windows.Forms.BindingSource tratamentoBindingSource;
        private db_HospitalDataSetTableAdapters.TratamentoTableAdapter tratamentoTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTratamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_tratamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao_tratamento;
    }
}