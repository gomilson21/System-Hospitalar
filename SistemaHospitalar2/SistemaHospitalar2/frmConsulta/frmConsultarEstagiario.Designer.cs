namespace SistemaHospitalar2.frmConsulta
{
    partial class frmConsultarEstagiario
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFormaPesquisa = new System.Windows.Forms.ComboBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.estagiarioDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnBuscar = new Guna.UI.WinForms.GunaButton();
            this.txtPesquisa = new Guna.UI.WinForms.GunaTextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estagiarioDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscar);
            this.groupBox3.Controls.Add(this.txtPesquisa);
            this.groupBox3.Controls.Add(this.btnActualizar);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cbFormaPesquisa);
            this.groupBox3.Location = new System.Drawing.Point(12, 113);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(607, 88);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Faça a sua consulta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 37;
            this.label2.Text = "Consultar por:";
            // 
            // cbFormaPesquisa
            // 
            this.cbFormaPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPesquisa.FormattingEnabled = true;
            this.cbFormaPesquisa.Items.AddRange(new object[] {
            "Data de Admissão",
            "Data de Nascimento",
            "Nome da Escola",
            "Nome do Estagiario",
            "Sexo"});
            this.cbFormaPesquisa.Location = new System.Drawing.Point(135, 56);
            this.cbFormaPesquisa.Name = "cbFormaPesquisa";
            this.cbFormaPesquisa.Size = new System.Drawing.Size(264, 26);
            this.cbFormaPesquisa.Sorted = true;
            this.cbFormaPesquisa.TabIndex = 36;
            this.cbFormaPesquisa.SelectedIndexChanged += new System.EventHandler(this.cbFormaPesquisa_SelectedIndexChanged);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::SistemaHospitalar2.Properties.Resources.ex4;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Location = new System.Drawing.Point(660, 113);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(76, 64);
            this.btnSair.TabIndex = 50;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.estagiarioDataGridView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 208);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(740, 268);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // estagiarioDataGridView
            // 
            this.estagiarioDataGridView.AllowUserToAddRows = false;
            this.estagiarioDataGridView.AllowUserToDeleteRows = false;
            this.estagiarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.estagiarioDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.estagiarioDataGridView.Location = new System.Drawing.Point(4, 23);
            this.estagiarioDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.estagiarioDataGridView.Name = "estagiarioDataGridView";
            this.estagiarioDataGridView.ReadOnly = true;
            this.estagiarioDataGridView.Size = new System.Drawing.Size(732, 241);
            this.estagiarioDataGridView.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblLogin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(740, 106);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(210, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.lblLogin.Location = new System.Drawing.Point(503, 66);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(218, 23);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Consultar Estagiario";
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
            this.btnBuscar.Location = new System.Drawing.Point(466, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OnHoverBaseColor = System.Drawing.Color.RosyBrown;
            this.btnBuscar.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnBuscar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuscar.OnHoverImage = null;
            this.btnBuscar.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuscar.Radius = 15;
            this.btnBuscar.Size = new System.Drawing.Size(30, 26);
            this.btnBuscar.TabIndex = 45;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.txtPesquisa.Location = new System.Drawing.Point(16, 22);
            this.txtPesquisa.MaxLength = 50;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.PasswordChar = '\0';
            this.txtPesquisa.Radius = 18;
            this.txtPesquisa.SelectedText = "";
            this.txtPesquisa.Size = new System.Drawing.Size(484, 30);
            this.txtPesquisa.TabIndex = 44;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnActualizar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(405, 54);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(95, 30);
            this.btnActualizar.TabIndex = 43;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmConsultarEstagiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 476);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConsultarEstagiario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Estagiario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmConsultarEstagiario_FormClosed);
            this.Load += new System.EventHandler(this.frmConsultarEstagiario_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.estagiarioDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView estagiarioDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFormaPesquisa;
        private Guna.UI.WinForms.GunaButton btnBuscar;
        private Guna.UI.WinForms.GunaTextBox txtPesquisa;
        private System.Windows.Forms.Button btnActualizar;
    }
}