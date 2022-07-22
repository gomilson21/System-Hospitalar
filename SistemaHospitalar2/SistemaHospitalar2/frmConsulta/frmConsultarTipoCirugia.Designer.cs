namespace SistemaHospitalar2.frmConsulta
{
    partial class frmConsultarTipoCirugia
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tipoCirugiaDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.db_HospitalDataSet1 = new SistemaHospitalar2.db_HospitalDataSet();
            this.tipoCirugiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipo_CirugiaTableAdapter = new SistemaHospitalar2.db_HospitalDataSetTableAdapters.Tipo_CirugiaTableAdapter();
            this.codTipoCirugiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomecirugiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoCirugiaDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoCirugiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPesquisa);
            this.groupBox3.Location = new System.Drawing.Point(12, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(497, 68);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Faça a sua consulta";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(6, 26);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(444, 26);
            this.txtPesquisa.TabIndex = 33;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tipoCirugiaDataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(606, 258);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // tipoCirugiaDataGridView
            // 
            this.tipoCirugiaDataGridView.AllowUserToAddRows = false;
            this.tipoCirugiaDataGridView.AllowUserToDeleteRows = false;
            this.tipoCirugiaDataGridView.AutoGenerateColumns = false;
            this.tipoCirugiaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tipoCirugiaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codTipoCirugiaDataGridViewTextBoxColumn,
            this.nomecirugiaDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.tipoCirugiaDataGridView.DataSource = this.tipoCirugiaBindingSource;
            this.tipoCirugiaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tipoCirugiaDataGridView.Location = new System.Drawing.Point(3, 22);
            this.tipoCirugiaDataGridView.Name = "tipoCirugiaDataGridView";
            this.tipoCirugiaDataGridView.ReadOnly = true;
            this.tipoCirugiaDataGridView.Size = new System.Drawing.Size(600, 233);
            this.tipoCirugiaDataGridView.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblLogin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 126);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(145, 48);
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
            this.lblLogin.Location = new System.Drawing.Point(334, 88);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(266, 23);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Consultar Tipo de Cirugia";
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.ex4;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Location = new System.Drawing.Point(531, 132);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(71, 68);
            this.btnSair.TabIndex = 43;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // db_HospitalDataSet1
            // 
            this.db_HospitalDataSet1.DataSetName = "db_HospitalDataSet1";
            this.db_HospitalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoCirugiaBindingSource
            // 
            this.tipoCirugiaBindingSource.DataMember = "Tipo_Cirugia";
            this.tipoCirugiaBindingSource.DataSource = this.db_HospitalDataSet1;
            // 
            // tipo_CirugiaTableAdapter
            // 
            this.tipo_CirugiaTableAdapter.ClearBeforeFill = true;
            // 
            // codTipoCirugiaDataGridViewTextBoxColumn
            // 
            this.codTipoCirugiaDataGridViewTextBoxColumn.DataPropertyName = "codTipo_Cirugia";
            this.codTipoCirugiaDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codTipoCirugiaDataGridViewTextBoxColumn.Name = "codTipoCirugiaDataGridViewTextBoxColumn";
            this.codTipoCirugiaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomecirugiaDataGridViewTextBoxColumn
            // 
            this.nomecirugiaDataGridViewTextBoxColumn.DataPropertyName = "nome_cirugia";
            this.nomecirugiaDataGridViewTextBoxColumn.HeaderText = "Nome da Cirugia";
            this.nomecirugiaDataGridViewTextBoxColumn.Name = "nomecirugiaDataGridViewTextBoxColumn";
            this.nomecirugiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomecirugiaDataGridViewTextBoxColumn.Width = 200;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Width = 300;
            // 
            // frmConsultarTipoCirugia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 464);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmConsultarTipoCirugia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Tipo Cirugia";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmConsultarTipoCirugia_FormClosed);
            this.Load += new System.EventHandler(this.frmConsultarTipoCirugia_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tipoCirugiaDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoCirugiaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tipoCirugiaDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private db_HospitalDataSet db_HospitalDataSet1;
        private System.Windows.Forms.BindingSource tipoCirugiaBindingSource;
        private db_HospitalDataSetTableAdapters.Tipo_CirugiaTableAdapter tipo_CirugiaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTipoCirugiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomecirugiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
    }
}