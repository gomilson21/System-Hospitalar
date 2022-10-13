namespace SistemaHospitalar2.frmConsulta
{
    partial class frmConsultarTipoConsulta
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tipoConsultaDataGridView = new System.Windows.Forms.DataGridView();
            this.tipoConsultaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_HospitalDataSet1 = new SistemaHospitalar2.db_HospitalDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.tipo_ConsultaTableAdapter = new SistemaHospitalar2.db_HospitalDataSetTableAdapters.Tipo_ConsultaTableAdapter();
            this.codTipoConsultaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeTipoConsultaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoTipoConsultaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new Guna.UI.WinForms.GunaButton();
            this.txtPesquisa = new Guna.UI.WinForms.GunaTextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoConsultaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoConsultaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.txtPesquisa);
            this.groupBox3.Location = new System.Drawing.Point(12, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(452, 68);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Faça a sua consulta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tipoConsultaDataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(577, 240);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // tipoConsultaDataGridView
            // 
            this.tipoConsultaDataGridView.AllowUserToAddRows = false;
            this.tipoConsultaDataGridView.AllowUserToDeleteRows = false;
            this.tipoConsultaDataGridView.AutoGenerateColumns = false;
            this.tipoConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tipoConsultaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codTipoConsultaDataGridViewTextBoxColumn,
            this.nomeTipoConsultaDataGridViewTextBoxColumn,
            this.descricaoTipoConsultaDataGridViewTextBoxColumn});
            this.tipoConsultaDataGridView.DataSource = this.tipoConsultaBindingSource;
            this.tipoConsultaDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tipoConsultaDataGridView.Location = new System.Drawing.Point(3, 22);
            this.tipoConsultaDataGridView.Name = "tipoConsultaDataGridView";
            this.tipoConsultaDataGridView.ReadOnly = true;
            this.tipoConsultaDataGridView.Size = new System.Drawing.Size(571, 215);
            this.tipoConsultaDataGridView.TabIndex = 32;
            // 
            // tipoConsultaBindingSource
            // 
            this.tipoConsultaBindingSource.DataMember = "Tipo_Consulta";
            this.tipoConsultaBindingSource.DataSource = this.db_HospitalDataSet1;
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
            this.groupBox1.Size = new System.Drawing.Size(577, 126);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(135, 49);
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
            this.lblLogin.Location = new System.Drawing.Point(296, 88);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(278, 23);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Consultar Tipo de Consulta";
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.ex4;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Location = new System.Drawing.Point(500, 132);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(71, 68);
            this.btnSair.TabIndex = 39;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tipo_ConsultaTableAdapter
            // 
            this.tipo_ConsultaTableAdapter.ClearBeforeFill = true;
            // 
            // codTipoConsultaDataGridViewTextBoxColumn
            // 
            this.codTipoConsultaDataGridViewTextBoxColumn.DataPropertyName = "codTipoConsulta";
            this.codTipoConsultaDataGridViewTextBoxColumn.HeaderText = "codTipoConsulta";
            this.codTipoConsultaDataGridViewTextBoxColumn.Name = "codTipoConsultaDataGridViewTextBoxColumn";
            this.codTipoConsultaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeTipoConsultaDataGridViewTextBoxColumn
            // 
            this.nomeTipoConsultaDataGridViewTextBoxColumn.DataPropertyName = "nome_TipoConsulta";
            this.nomeTipoConsultaDataGridViewTextBoxColumn.HeaderText = "nome_TipoConsulta";
            this.nomeTipoConsultaDataGridViewTextBoxColumn.Name = "nomeTipoConsultaDataGridViewTextBoxColumn";
            this.nomeTipoConsultaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoTipoConsultaDataGridViewTextBoxColumn
            // 
            this.descricaoTipoConsultaDataGridViewTextBoxColumn.DataPropertyName = "descricao_TipoConsulta";
            this.descricaoTipoConsultaDataGridViewTextBoxColumn.HeaderText = "descricao_TipoConsulta";
            this.descricaoTipoConsultaDataGridViewTextBoxColumn.Name = "descricaoTipoConsultaDataGridViewTextBoxColumn";
            this.descricaoTipoConsultaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AnimationHoverSpeed = 0.07F;
            this.btnBuscar.AnimationSpeed = 0.03F;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BaseColor = System.Drawing.Color.DarkCyan;
            this.btnBuscar.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnBuscar.BorderSize = 1;
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscar.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::SistemaHospitalar2.Properties.Resources.search_26px;
            this.btnBuscar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBuscar.Location = new System.Drawing.Point(408, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OnHoverBaseColor = System.Drawing.Color.RosyBrown;
            this.btnBuscar.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnBuscar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscar.OnHoverImage = null;
            this.btnBuscar.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscar.Radius = 15;
            this.btnBuscar.Size = new System.Drawing.Size(30, 26);
            this.btnBuscar.TabIndex = 44;
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
            this.txtPesquisa.Size = new System.Drawing.Size(436, 30);
            this.txtPesquisa.TabIndex = 43;
            // 
            // frmConsultarTipoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 441);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConsultarTipoConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Tipo Consulta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmConsultarTipoConsulta_FormClosed);
            this.Load += new System.EventHandler(this.frmConsultarTipoConsulta_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tipoConsultaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoConsultaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tipoConsultaDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private db_HospitalDataSet db_HospitalDataSet1;
        private System.Windows.Forms.BindingSource tipoConsultaBindingSource;
        private db_HospitalDataSetTableAdapters.Tipo_ConsultaTableAdapter tipo_ConsultaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codTipoConsultaDataGridViewTextBoxColumn;
        // private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        // private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private Guna.UI.WinForms.GunaButton btnBuscar;
        private Guna.UI.WinForms.GunaTextBox txtPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeTipoConsultaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoTipoConsultaDataGridViewTextBoxColumn;
    }
}