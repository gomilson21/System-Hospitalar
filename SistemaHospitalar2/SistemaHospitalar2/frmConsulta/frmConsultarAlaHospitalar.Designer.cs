namespace SistemaHospitalar2.frmConsulta
{
    partial class frmConsultarAlaHospitalar
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
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.alaHospitalarDataGridView = new System.Windows.Forms.DataGridView();
            this.alaHospitalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_HospitalDataSet1 = new SistemaHospitalar2.db_HospitalDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.ala_HospitalarTableAdapter = new SistemaHospitalar2.db_HospitalDataSetTableAdapters.Ala_HospitalarTableAdapter();
            this.codAlaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_ala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao_ala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alaHospitalarDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alaHospitalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPesquisa);
            this.groupBox3.Location = new System.Drawing.Point(12, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(497, 68);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Faça a sua consulta";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(6, 26);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(444, 24);
            this.txtPesquisa.TabIndex = 33;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.ex4;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Location = new System.Drawing.Point(538, 132);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(71, 68);
            this.btnSair.TabIndex = 39;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.alaHospitalarDataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 240);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // alaHospitalarDataGridView
            // 
            this.alaHospitalarDataGridView.AllowUserToAddRows = false;
            this.alaHospitalarDataGridView.AllowUserToDeleteRows = false;
            this.alaHospitalarDataGridView.AutoGenerateColumns = false;
            this.alaHospitalarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alaHospitalarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codAlaDataGridViewTextBoxColumn,
            this.nome_ala,
            this.descricao_ala});
            this.alaHospitalarDataGridView.DataSource = this.alaHospitalarBindingSource;
            this.alaHospitalarDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alaHospitalarDataGridView.Location = new System.Drawing.Point(3, 20);
            this.alaHospitalarDataGridView.Name = "alaHospitalarDataGridView";
            this.alaHospitalarDataGridView.ReadOnly = true;
            this.alaHospitalarDataGridView.Size = new System.Drawing.Size(615, 217);
            this.alaHospitalarDataGridView.TabIndex = 32;
            // 
            // alaHospitalarBindingSource
            // 
            this.alaHospitalarBindingSource.DataMember = "Ala_Hospitalar";
            this.alaHospitalarBindingSource.DataSource = this.db_HospitalDataSet1;
            // 
            // db_HospitalDataSet1
            // 
            this.db_HospitalDataSet1.DataSetName = "db_HospitalDataSet1";
            this.db_HospitalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.groupBox1.TabIndex = 37;
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
            this.lblLogin.Location = new System.Drawing.Point(329, 88);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(290, 23);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Consultar Sessão Hospitalar";
            // 
            // ala_HospitalarTableAdapter
            // 
            this.ala_HospitalarTableAdapter.ClearBeforeFill = true;
            // 
            // codAlaDataGridViewTextBoxColumn
            // 
            this.codAlaDataGridViewTextBoxColumn.DataPropertyName = "codAla";
            this.codAlaDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codAlaDataGridViewTextBoxColumn.Name = "codAlaDataGridViewTextBoxColumn";
            this.codAlaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nome_ala
            // 
            this.nome_ala.DataPropertyName = "nome_ala";
            this.nome_ala.HeaderText = "Nome da Sessão";
            this.nome_ala.Name = "nome_ala";
            this.nome_ala.ReadOnly = true;
            this.nome_ala.Width = 190;
            // 
            // descricao_ala
            // 
            this.descricao_ala.DataPropertyName = "descricao_ala";
            this.descricao_ala.HeaderText = "Descrição da Sessão";
            this.descricao_ala.Name = "descricao_ala";
            this.descricao_ala.ReadOnly = true;
            this.descricao_ala.Width = 300;
            // 
            // frmConsultarAlaHospitalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 440);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConsultarAlaHospitalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Sessão Hospitalar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmConsultarAlaHospitalar_FormClosed);
            this.Load += new System.EventHandler(this.frmConsultarAlaHospitalar_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alaHospitalarDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alaHospitalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView alaHospitalarDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private db_HospitalDataSet db_HospitalDataSet1;
        private System.Windows.Forms.BindingSource alaHospitalarBindingSource;
        private db_HospitalDataSetTableAdapters.Ala_HospitalarTableAdapter ala_HospitalarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codAlaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_ala;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao_ala;
    }
}