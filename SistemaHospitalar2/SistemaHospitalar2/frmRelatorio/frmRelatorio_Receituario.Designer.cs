namespace SistemaHospitalar2.frmRelatorio
{
    partial class frmRelatorio_Receituario
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
            this.crvReceituario = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cbPacienteInternado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crvReceituario
            // 
            this.crvReceituario.ActiveViewIndex = 0;
            this.crvReceituario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvReceituario.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReceituario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crvReceituario.Location = new System.Drawing.Point(0, 99);
            this.crvReceituario.Name = "crvReceituario";
            this.crvReceituario.ReportSource = "C:\\Z_Gomilson\\#Começando\\Pré Projecto\\Prático\\Software\\SistemaHospitalar2\\Sistema" +
    "Hospitalar2\\Relatorio\\crReceituario.rpt";
            this.crvReceituario.Size = new System.Drawing.Size(818, 492);
            this.crvReceituario.TabIndex = 0;
            this.crvReceituario.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // cbPacienteInternado
            // 
            this.cbPacienteInternado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPacienteInternado.FormattingEnabled = true;
            this.cbPacienteInternado.Location = new System.Drawing.Point(174, 13);
            this.cbPacienteInternado.Name = "cbPacienteInternado";
            this.cbPacienteInternado.Size = new System.Drawing.Size(311, 26);
            this.cbPacienteInternado.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do Paciente:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(174, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Emitir Relatório";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmRelatorio_Receituario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 591);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPacienteInternado);
            this.Controls.Add(this.crvReceituario);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRelatorio_Receituario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Receituário";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRelatorio_Receituario_FormClosed);
            this.Load += new System.EventHandler(this.frmRelatorio_Receituario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReceituario;
        private System.Windows.Forms.ComboBox cbPacienteInternado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}