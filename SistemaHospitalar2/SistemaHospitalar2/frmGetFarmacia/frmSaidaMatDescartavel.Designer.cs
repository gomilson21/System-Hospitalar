namespace SistemaHospitalar2.frmGetFarmacia
{
    partial class frmSaidaMatDescartavel
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnImprimirComprovativo = new System.Windows.Forms.Button();
            this.btnEfectuarSaida = new System.Windows.Forms.Button();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.txtNomeMaterial = new System.Windows.Forms.TextBox();
            this.materialDescartavelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_HospitalDataSet = new SistemaHospitalar2.db_HospitalDataSet();
            this.lblQuantidadeSaida = new System.Windows.Forms.Label();
            this.txtQuantidadeSaida = new System.Windows.Forms.TextBox();
            this.materialDescartavelDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.material_DescartavelTableAdapter = new SistemaHospitalar2.db_HospitalDataSetTableAdapters.Material_DescartavelTableAdapter();
            this.codMatrialDescartavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeInicial_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeEntrada_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataValidade_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeActual_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeMinima_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeMaxima_material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialDescartavelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialDescartavelDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSair);
            this.groupBox2.Controls.Add(this.btnImprimirComprovativo);
            this.groupBox2.Controls.Add(this.btnEfectuarSaida);
            this.groupBox2.Controls.Add(this.lblMaterial);
            this.groupBox2.Controls.Add(this.txtNomeMaterial);
            this.groupBox2.Controls.Add(this.lblQuantidadeSaida);
            this.groupBox2.Controls.Add(this.txtQuantidadeSaida);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(733, 119);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.ex1;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Location = new System.Drawing.Point(660, 12);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(62, 96);
            this.btnSair.TabIndex = 46;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnImprimirComprovativo
            // 
            this.btnImprimirComprovativo.Location = new System.Drawing.Point(520, 57);
            this.btnImprimirComprovativo.Name = "btnImprimirComprovativo";
            this.btnImprimirComprovativo.Size = new System.Drawing.Size(135, 51);
            this.btnImprimirComprovativo.TabIndex = 45;
            this.btnImprimirComprovativo.Text = "Imprimir\r\nComprovativo";
            this.btnImprimirComprovativo.UseVisualStyleBackColor = true;
            // 
            // btnEfectuarSaida
            // 
            this.btnEfectuarSaida.Location = new System.Drawing.Point(520, 12);
            this.btnEfectuarSaida.Name = "btnEfectuarSaida";
            this.btnEfectuarSaida.Size = new System.Drawing.Size(135, 39);
            this.btnEfectuarSaida.TabIndex = 44;
            this.btnEfectuarSaida.Text = "Efectuar Saida";
            this.btnEfectuarSaida.UseVisualStyleBackColor = true;
            this.btnEfectuarSaida.Click += new System.EventHandler(this.btnEfectuarSaida_Click);
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(5, 19);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(140, 18);
            this.lblMaterial.TabIndex = 43;
            this.lblMaterial.Text = "Nome do Material";
            // 
            // txtNomeMaterial
            // 
            this.txtNomeMaterial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialDescartavelBindingSource, "nome_material", true));
            this.txtNomeMaterial.Location = new System.Drawing.Point(151, 16);
            this.txtNomeMaterial.Name = "txtNomeMaterial";
            this.txtNomeMaterial.Size = new System.Drawing.Size(307, 26);
            this.txtNomeMaterial.TabIndex = 42;
            // 
            // materialDescartavelBindingSource
            // 
            this.materialDescartavelBindingSource.DataMember = "Material_Descartavel";
            this.materialDescartavelBindingSource.DataSource = this.db_HospitalDataSet;
            // 
            // db_HospitalDataSet
            // 
            this.db_HospitalDataSet.DataSetName = "db_HospitalDataSet";
            this.db_HospitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblQuantidadeSaida
            // 
            this.lblQuantidadeSaida.AutoSize = true;
            this.lblQuantidadeSaida.Location = new System.Drawing.Point(3, 51);
            this.lblQuantidadeSaida.Name = "lblQuantidadeSaida";
            this.lblQuantidadeSaida.Size = new System.Drawing.Size(160, 18);
            this.lblQuantidadeSaida.TabIndex = 41;
            this.lblQuantidadeSaida.Text = "Quantidade de Saida";
            // 
            // txtQuantidadeSaida
            // 
            this.txtQuantidadeSaida.Location = new System.Drawing.Point(171, 48);
            this.txtQuantidadeSaida.Name = "txtQuantidadeSaida";
            this.txtQuantidadeSaida.Size = new System.Drawing.Size(287, 26);
            this.txtQuantidadeSaida.TabIndex = 40;
            this.txtQuantidadeSaida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidadeSaida_KeyPress);
            // 
            // materialDescartavelDataGridView
            // 
            this.materialDescartavelDataGridView.AllowUserToAddRows = false;
            this.materialDescartavelDataGridView.AllowUserToDeleteRows = false;
            this.materialDescartavelDataGridView.AutoGenerateColumns = false;
            this.materialDescartavelDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.materialDescartavelDataGridView.ColumnHeadersHeight = 30;
            this.materialDescartavelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codMatrialDescartavel,
            this.nome_material,
            this.quantidadeInicial_material,
            this.quantidadeEntrada_material,
            this.dataValidade_material,
            this.quantidadeActual_material,
            this.quantidadeMinima_material,
            this.quantidadeMaxima_material});
            this.materialDescartavelDataGridView.DataSource = this.materialDescartavelBindingSource;
            this.materialDescartavelDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialDescartavelDataGridView.Location = new System.Drawing.Point(0, 126);
            this.materialDescartavelDataGridView.Name = "materialDescartavelDataGridView";
            this.materialDescartavelDataGridView.ReadOnly = true;
            this.materialDescartavelDataGridView.Size = new System.Drawing.Size(733, 169);
            this.materialDescartavelDataGridView.TabIndex = 33;
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
            this.groupBox1.Size = new System.Drawing.Size(733, 126);
            this.groupBox1.TabIndex = 32;
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
            this.label1.Location = new System.Drawing.Point(215, 52);
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
            this.lblLogin.Location = new System.Drawing.Point(423, 91);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(310, 23);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Saida de Material Descartável";
            // 
            // material_DescartavelTableAdapter
            // 
            this.material_DescartavelTableAdapter.ClearBeforeFill = true;
            // 
            // codMatrialDescartavel
            // 
            this.codMatrialDescartavel.DataPropertyName = "codMatrialDescartavel";
            this.codMatrialDescartavel.HeaderText = "Código";
            this.codMatrialDescartavel.Name = "codMatrialDescartavel";
            this.codMatrialDescartavel.ReadOnly = true;
            // 
            // nome_material
            // 
            this.nome_material.DataPropertyName = "nome_material";
            this.nome_material.HeaderText = "Nome do Material Descartável";
            this.nome_material.Name = "nome_material";
            this.nome_material.ReadOnly = true;
            this.nome_material.Width = 280;
            // 
            // quantidadeInicial_material
            // 
            this.quantidadeInicial_material.DataPropertyName = "quantidadeInicial_material";
            this.quantidadeInicial_material.HeaderText = "Quantidade Em Stock";
            this.quantidadeInicial_material.Name = "quantidadeInicial_material";
            this.quantidadeInicial_material.ReadOnly = true;
            this.quantidadeInicial_material.Width = 210;
            // 
            // quantidadeEntrada_material
            // 
            this.quantidadeEntrada_material.DataPropertyName = "quantidadeEntrada_material";
            this.quantidadeEntrada_material.HeaderText = "Quantidade Entrada";
            this.quantidadeEntrada_material.Name = "quantidadeEntrada_material";
            this.quantidadeEntrada_material.ReadOnly = true;
            this.quantidadeEntrada_material.Width = 200;
            // 
            // dataValidade_material
            // 
            this.dataValidade_material.DataPropertyName = "dataValidade_material";
            this.dataValidade_material.HeaderText = "Data de Validade";
            this.dataValidade_material.Name = "dataValidade_material";
            this.dataValidade_material.ReadOnly = true;
            this.dataValidade_material.Width = 160;
            // 
            // quantidadeActual_material
            // 
            this.quantidadeActual_material.DataPropertyName = "quantidadeActual_material";
            this.quantidadeActual_material.HeaderText = "Quantidade Actual";
            this.quantidadeActual_material.Name = "quantidadeActual_material";
            this.quantidadeActual_material.ReadOnly = true;
            this.quantidadeActual_material.Width = 190;
            // 
            // quantidadeMinima_material
            // 
            this.quantidadeMinima_material.DataPropertyName = "quantidadeMinima_material";
            this.quantidadeMinima_material.HeaderText = "Quantidade Mínima";
            this.quantidadeMinima_material.Name = "quantidadeMinima_material";
            this.quantidadeMinima_material.ReadOnly = true;
            this.quantidadeMinima_material.Width = 190;
            // 
            // quantidadeMaxima_material
            // 
            this.quantidadeMaxima_material.DataPropertyName = "quantidadeMaxima_material";
            this.quantidadeMaxima_material.HeaderText = "Quantidade Máxima";
            this.quantidadeMaxima_material.Name = "quantidadeMaxima_material";
            this.quantidadeMaxima_material.ReadOnly = true;
            this.quantidadeMaxima_material.Width = 190;
            // 
            // frmSaidaMatDescartavel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 420);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.materialDescartavelDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSaidaMatDescartavel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saida de Material Descartável";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSaidaMatDescartavel_FormClosed);
            this.Load += new System.EventHandler(this.frmSaidaMatDescartavel_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialDescartavelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_HospitalDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialDescartavelDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnImprimirComprovativo;
        private System.Windows.Forms.Button btnEfectuarSaida;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.TextBox txtNomeMaterial;
        private System.Windows.Forms.Label lblQuantidadeSaida;
        private System.Windows.Forms.TextBox txtQuantidadeSaida;
        private System.Windows.Forms.DataGridView materialDescartavelDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private db_HospitalDataSet db_HospitalDataSet;
        private System.Windows.Forms.BindingSource materialDescartavelBindingSource;
        private db_HospitalDataSetTableAdapters.Material_DescartavelTableAdapter material_DescartavelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codMatrialDescartavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeInicial_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeEntrada_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataValidade_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeActual_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeMinima_material;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeMaxima_material;
    }
}