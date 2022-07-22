namespace SistemaHospitalar2.frmRelatorio
{
    partial class frmRelatorio_MarcacaoConsulta
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
            this.crvMarcacaoConsulta = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvMarcacaoConsulta
            // 
            this.crvMarcacaoConsulta.ActiveViewIndex = -1;
            this.crvMarcacaoConsulta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvMarcacaoConsulta.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvMarcacaoConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvMarcacaoConsulta.Location = new System.Drawing.Point(0, 0);
            this.crvMarcacaoConsulta.Name = "crvMarcacaoConsulta";
            this.crvMarcacaoConsulta.Size = new System.Drawing.Size(822, 483);
            this.crvMarcacaoConsulta.TabIndex = 0;
            this.crvMarcacaoConsulta.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmRelatorio_MarcacaoConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 483);
            this.Controls.Add(this.crvMarcacaoConsulta);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRelatorio_MarcacaoConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Marcação de Consulta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRelatorio_MarcacaoConsulta_FormClosed);
            this.Load += new System.EventHandler(this.frmRelatorio_MarcacaoConsulta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvMarcacaoConsulta;
    }
}