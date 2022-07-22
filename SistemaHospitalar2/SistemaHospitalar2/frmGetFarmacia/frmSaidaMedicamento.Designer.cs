namespace SistemaHospitalar2.frmGetFarmacia
{
    partial class frmSaidaMedicamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.medicamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.medicamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_HospitalDataSet = new SistemaHospitalar2.db_HospitalDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.medicamentoTableAdapter = new SistemaHospitalar2.db_HospitalDataSetTableAdapters.MedicamentoTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNomeGenerico = new System.Windows.Forms.Label();
            this.txtNomeGenerico = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnImprimirComprovativo = new System.Windows.Forms.Button();
            this.btnEfectuarSaida = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeComercial = new System.Windows.Forms.TextBox();
            this.lblQuantidadeSaida = new System.Windows.Forms.Label();
            this.txtQuantidadeSaida = new System.Windows.Forms.TextBox();
            this.codMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_generico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeComercial_medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeInicial_medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeEntrada_medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataValidade_medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeActual_medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeMinima_medicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // medicamentoDataGridView
            // 
            this.medicamentoDataGridView.AllowUserToAddRows = false;
            this.medicamentoDataGridView.AllowUserToDeleteRows = false;
            this.medicamentoDataGridView.AutoGenerateColumns = false;
            this.medicamentoDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.medicamentoDataGridView.ColumnHeadersHeight = 30;
            this.medicamentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codMedicamento,
            this.nome_generico,
            this.nomeComercial_medicamento,
            this.quantidadeInicial_medicamento,
            this.quantidadeEntrada_medicamento,
            this.dataValidade_medicamento,
            this.quantidadeActual_medicamento,
            this.quantidadeMinima_medicamento});
            this.medicamentoDataGridView.DataSource = this.medicamentoBindingSource;
            this.medicamentoDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.medicamentoDataGridView.Location = new System.Drawing.Point(0, 126);
            this.medicamentoDataGridView.Name = "medicamentoDataGridView";
            this.medicamentoDataGridView.ReadOnly = true;
            this.medicamentoDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.medicamentoDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicamentoDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.medicamentoDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicamentoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.medicamentoDataGridView.Size = new System.Drawing.Size(688, 176);
            this.medicamentoDataGridView.TabIndex = 30;
            // 
            // medicamentoBindingSource
            // 
            this.medicamentoBindingSource.DataMember = "Medicamento";
            this.medicamentoBindingSource.DataSource = this.db_HospitalDataSet;
            // 
            // db_HospitalDataSet
            // 
            this.db_HospitalDataSet.DataSetName = "db_HospitalDataSet";
            this.db_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblLogin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 126);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaHospitalar2.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(209, 47);
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
            this.lblLogin.Location = new System.Drawing.Point(455, 90);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(233, 23);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Saida de Medicamento";
            // 
            // medicamentoTableAdapter
            // 
            this.medicamentoTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNomeGenerico);
            this.groupBox2.Controls.Add(this.txtNomeGenerico);
            this.groupBox2.Controls.Add(this.btnSair);
            this.groupBox2.Controls.Add(this.btnImprimirComprovativo);
            this.groupBox2.Controls.Add(this.btnEfectuarSaida);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNomeComercial);
            this.groupBox2.Controls.Add(this.lblQuantidadeSaida);
            this.groupBox2.Controls.Add(this.txtQuantidadeSaida);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(688, 121);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            // 
            // lblNomeGenerico
            // 
            this.lblNomeGenerico.AutoSize = true;
            this.lblNomeGenerico.Location = new System.Drawing.Point(3, 19);
            this.lblNomeGenerico.Name = "lblNomeGenerico";
            this.lblNomeGenerico.Size = new System.Drawing.Size(131, 18);
            this.lblNomeGenerico.TabIndex = 50;
            this.lblNomeGenerico.Text = "Nome Genérico:";
            // 
            // txtNomeGenerico
            // 
            this.txtNomeGenerico.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicamentoBindingSource, "nomeGenerico_medicamento", true));
            this.txtNomeGenerico.Location = new System.Drawing.Point(143, 16);
            this.txtNomeGenerico.Name = "txtNomeGenerico";
            this.txtNomeGenerico.Size = new System.Drawing.Size(286, 26);
            this.txtNomeGenerico.TabIndex = 49;
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.ex1;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Location = new System.Drawing.Point(621, 16);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(62, 96);
            this.btnSair.TabIndex = 46;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnImprimirComprovativo
            // 
            this.btnImprimirComprovativo.Location = new System.Drawing.Point(481, 61);
            this.btnImprimirComprovativo.Name = "btnImprimirComprovativo";
            this.btnImprimirComprovativo.Size = new System.Drawing.Size(135, 51);
            this.btnImprimirComprovativo.TabIndex = 45;
            this.btnImprimirComprovativo.Text = "Imprimir\r\nComprovativo";
            this.btnImprimirComprovativo.UseVisualStyleBackColor = true;
            // 
            // btnEfectuarSaida
            // 
            this.btnEfectuarSaida.Location = new System.Drawing.Point(481, 16);
            this.btnEfectuarSaida.Name = "btnEfectuarSaida";
            this.btnEfectuarSaida.Size = new System.Drawing.Size(135, 39);
            this.btnEfectuarSaida.TabIndex = 44;
            this.btnEfectuarSaida.Text = "Efectuar Saida";
            this.btnEfectuarSaida.UseVisualStyleBackColor = true;
            this.btnEfectuarSaida.Click += new System.EventHandler(this.btnEfectuarSaida_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 43;
            this.label3.Text = "Nome Comercial:";
            // 
            // txtNomeComercial
            // 
            this.txtNomeComercial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicamentoBindingSource, "nomeComercial_medicamento", true));
            this.txtNomeComercial.Location = new System.Drawing.Point(143, 48);
            this.txtNomeComercial.Name = "txtNomeComercial";
            this.txtNomeComercial.Size = new System.Drawing.Size(286, 26);
            this.txtNomeComercial.TabIndex = 42;
            // 
            // lblQuantidadeSaida
            // 
            this.lblQuantidadeSaida.AutoSize = true;
            this.lblQuantidadeSaida.Location = new System.Drawing.Point(3, 86);
            this.lblQuantidadeSaida.Name = "lblQuantidadeSaida";
            this.lblQuantidadeSaida.Size = new System.Drawing.Size(167, 18);
            this.lblQuantidadeSaida.TabIndex = 41;
            this.lblQuantidadeSaida.Text = "Quantidade de Saida:";
            // 
            // txtQuantidadeSaida
            // 
            this.txtQuantidadeSaida.Location = new System.Drawing.Point(171, 80);
            this.txtQuantidadeSaida.Name = "txtQuantidadeSaida";
            this.txtQuantidadeSaida.Size = new System.Drawing.Size(258, 26);
            this.txtQuantidadeSaida.TabIndex = 40;
            this.txtQuantidadeSaida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadeSaida_KeyPress);
            // 
            // codMedicamento
            // 
            this.codMedicamento.DataPropertyName = "codMedicamento";
            this.codMedicamento.HeaderText = "Código";
            this.codMedicamento.Name = "codMedicamento";
            this.codMedicamento.ReadOnly = true;
            // 
            // nome_generico
            // 
            this.nome_generico.DataPropertyName = "nome_generico";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.nome_generico.DefaultCellStyle = dataGridViewCellStyle1;
            this.nome_generico.HeaderText = "Nome Génerico";
            this.nome_generico.Name = "nome_generico";
            this.nome_generico.ReadOnly = true;
            this.nome_generico.Width = 200;
            // 
            // nomeComercial_medicamento
            // 
            this.nomeComercial_medicamento.DataPropertyName = "nomeComercial_medicamento";
            this.nomeComercial_medicamento.HeaderText = "Nome Comercial";
            this.nomeComercial_medicamento.Name = "nomeComercial_medicamento";
            this.nomeComercial_medicamento.ReadOnly = true;
            this.nomeComercial_medicamento.Width = 200;
            // 
            // quantidadeInicial_medicamento
            // 
            this.quantidadeInicial_medicamento.DataPropertyName = "quantidadeInicial_medicamento";
            this.quantidadeInicial_medicamento.HeaderText = "Quantidade em Stock";
            this.quantidadeInicial_medicamento.Name = "quantidadeInicial_medicamento";
            this.quantidadeInicial_medicamento.ReadOnly = true;
            this.quantidadeInicial_medicamento.Width = 210;
            // 
            // quantidadeEntrada_medicamento
            // 
            this.quantidadeEntrada_medicamento.DataPropertyName = "quantidadeEntrada_medicamento";
            this.quantidadeEntrada_medicamento.HeaderText = "Quantidade Entrada";
            this.quantidadeEntrada_medicamento.Name = "quantidadeEntrada_medicamento";
            this.quantidadeEntrada_medicamento.ReadOnly = true;
            this.quantidadeEntrada_medicamento.Width = 185;
            // 
            // dataValidade_medicamento
            // 
            this.dataValidade_medicamento.DataPropertyName = "dataValidade_medicamento";
            this.dataValidade_medicamento.HeaderText = "Data de Validade";
            this.dataValidade_medicamento.Name = "dataValidade_medicamento";
            this.dataValidade_medicamento.ReadOnly = true;
            this.dataValidade_medicamento.Width = 150;
            // 
            // quantidadeActual_medicamento
            // 
            this.quantidadeActual_medicamento.DataPropertyName = "quantidadeActual_medicamento";
            this.quantidadeActual_medicamento.HeaderText = "Quantidade Actual";
            this.quantidadeActual_medicamento.Name = "quantidadeActual_medicamento";
            this.quantidadeActual_medicamento.ReadOnly = true;
            this.quantidadeActual_medicamento.Width = 180;
            // 
            // quantidadeMinima_medicamento
            // 
            this.quantidadeMinima_medicamento.DataPropertyName = "quantidadeMinima_medicamento";
            this.quantidadeMinima_medicamento.HeaderText = "Quantidade Mínima";
            this.quantidadeMinima_medicamento.Name = "quantidadeMinima_medicamento";
            this.quantidadeMinima_medicamento.ReadOnly = true;
            this.quantidadeMinima_medicamento.Width = 185;
            // 
            // frmSaidaMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 429);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.medicamentoDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSaidaMedicamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saida de Medicamento";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSaidaMedicamento_FormClosed);
            this.Load += new System.EventHandler(this.frmSaidaMedicamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView medicamentoDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private db_HospitalDataSet db_HospitalDataSet;
        private System.Windows.Forms.BindingSource medicamentoBindingSource;
        private db_HospitalDataSetTableAdapters.MedicamentoTableAdapter medicamentoTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnImprimirComprovativo;
        private System.Windows.Forms.Button btnEfectuarSaida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeComercial;
        private System.Windows.Forms.Label lblQuantidadeSaida;
        private System.Windows.Forms.TextBox txtQuantidadeSaida;
        private System.Windows.Forms.Label lblNomeGenerico;
        private System.Windows.Forms.TextBox txtNomeGenerico;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_generico;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeComercial_medicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeInicial_medicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeEntrada_medicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataValidade_medicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeActual_medicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeMinima_medicamento;
    }
}