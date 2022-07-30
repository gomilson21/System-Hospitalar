namespace SistemaHospitalar2.frmConsulta
{
    partial class frmConsultarEspecialidadeMedico
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.especialidadeMedicoDataGridView = new System.Windows.Forms.DataGridView();
            this.codEspecialidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_especialidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao_especialidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadeMedicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_HospitalDataSet1 = new SistemaHospitalar2.db_HospitalDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.especialidade_MedicoTableAdapter = new SistemaHospitalar2.db_HospitalDataSetTableAdapters.Especialidade_MedicoTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.txtPesquisa = new Guna.UI.WinForms.GunaTextBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadeMedicoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadeMedicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.especialidadeMedicoDataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(613, 240);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // especialidadeMedicoDataGridView
            // 
            this.especialidadeMedicoDataGridView.AllowUserToAddRows = false;
            this.especialidadeMedicoDataGridView.AllowUserToDeleteRows = false;
            this.especialidadeMedicoDataGridView.AutoGenerateColumns = false;
            this.especialidadeMedicoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.especialidadeMedicoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codEspecialidadeDataGridViewTextBoxColumn,
            this.nome_especialidade,
            this.descricao_especialidade});
            this.especialidadeMedicoDataGridView.DataSource = this.especialidadeMedicoBindingSource;
            this.especialidadeMedicoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.especialidadeMedicoDataGridView.Location = new System.Drawing.Point(3, 22);
            this.especialidadeMedicoDataGridView.Name = "especialidadeMedicoDataGridView";
            this.especialidadeMedicoDataGridView.ReadOnly = true;
            this.especialidadeMedicoDataGridView.Size = new System.Drawing.Size(607, 215);
            this.especialidadeMedicoDataGridView.TabIndex = 32;
            // 
            // codEspecialidadeDataGridViewTextBoxColumn
            // 
            this.codEspecialidadeDataGridViewTextBoxColumn.DataPropertyName = "codEspecialidade";
            this.codEspecialidadeDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codEspecialidadeDataGridViewTextBoxColumn.Name = "codEspecialidadeDataGridViewTextBoxColumn";
            this.codEspecialidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nome_especialidade
            // 
            this.nome_especialidade.DataPropertyName = "nome_especialidade";
            this.nome_especialidade.HeaderText = "Nome da Especialidade";
            this.nome_especialidade.Name = "nome_especialidade";
            this.nome_especialidade.ReadOnly = true;
            this.nome_especialidade.Width = 220;
            // 
            // descricao_especialidade
            // 
            this.descricao_especialidade.DataPropertyName = "descricao_especialidade";
            this.descricao_especialidade.HeaderText = "Descrição da Especialidade";
            this.descricao_especialidade.Name = "descricao_especialidade";
            this.descricao_especialidade.ReadOnly = true;
            this.descricao_especialidade.Width = 300;
            // 
            // especialidadeMedicoBindingSource
            // 
            this.especialidadeMedicoBindingSource.DataMember = "Especialidade_Medico";
            this.especialidadeMedicoBindingSource.DataSource = this.db_HospitalDataSet1;
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
            this.groupBox1.Size = new System.Drawing.Size(613, 126);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(172, 50);
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
            this.lblLogin.Location = new System.Drawing.Point(257, 88);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(355, 23);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Consultar Especialidade do Médico";
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.ex4;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Location = new System.Drawing.Point(539, 132);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(71, 68);
            this.btnSair.TabIndex = 47;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // especialidade_MedicoTableAdapter
            // 
            this.especialidade_MedicoTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gunaButton1);
            this.groupBox3.Controls.Add(this.txtPesquisa);
            this.groupBox3.Location = new System.Drawing.Point(12, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(503, 68);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Faça a sua consulta";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.DarkCyan;
            this.gunaButton1.BorderColor = System.Drawing.Color.DarkCyan;
            this.gunaButton1.BorderSize = 1;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = global::SistemaHospitalar2.Properties.Resources.search_26px;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(416, 27);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.RosyBrown;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Red;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 15;
            this.gunaButton1.Size = new System.Drawing.Size(30, 26);
            this.gunaButton1.TabIndex = 35;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.txtPesquisa.BaseColor = System.Drawing.Color.White;
            this.txtPesquisa.BorderColor = System.Drawing.Color.DarkCyan;
            this.txtPesquisa.BorderSize = 1;
            this.txtPesquisa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesquisa.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPesquisa.FocusedBorderColor = System.Drawing.Color.Red;
            this.txtPesquisa.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPesquisa.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(6, 25);
            this.txtPesquisa.MaxLength = 50;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.PasswordChar = '\0';
            this.txtPesquisa.Radius = 18;
            this.txtPesquisa.SelectedText = "";
            this.txtPesquisa.Size = new System.Drawing.Size(444, 30);
            this.txtPesquisa.TabIndex = 34;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // frmConsultarEspecialidadeMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 441);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConsultarEspecialidadeMedico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Especialidade Médico";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmConsultarEspecialidadeMedico_FormClosed);
            this.Load += new System.EventHandler(this.frmConsultarEspecialidadeMedico_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.especialidadeMedicoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadeMedicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView especialidadeMedicoDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private db_HospitalDataSet db_HospitalDataSet1;
        private System.Windows.Forms.BindingSource especialidadeMedicoBindingSource;
        private db_HospitalDataSetTableAdapters.Especialidade_MedicoTableAdapter especialidade_MedicoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codEspecialidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_especialidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao_especialidade;
        private System.Windows.Forms.GroupBox groupBox3;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaTextBox txtPesquisa;
    }
}