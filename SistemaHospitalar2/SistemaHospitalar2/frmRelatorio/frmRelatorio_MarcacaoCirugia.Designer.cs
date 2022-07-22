namespace SistemaHospitalar2.frmRelatorio
{
    partial class frmRelatorio_MarcacaoCirugia
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
            this.crvMarcacaoCirugia = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvMarcacaoCirugia
            // 
            this.crvMarcacaoCirugia.ActiveViewIndex = -1;
            this.crvMarcacaoCirugia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvMarcacaoCirugia.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvMarcacaoCirugia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvMarcacaoCirugia.Location = new System.Drawing.Point(0, 0);
            this.crvMarcacaoCirugia.Name = "crvMarcacaoCirugia";
            this.crvMarcacaoCirugia.Size = new System.Drawing.Size(1008, 633);
            this.crvMarcacaoCirugia.TabIndex = 0;
            this.crvMarcacaoCirugia.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmRelatorio_MarcacaoCirugia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 633);
            this.Controls.Add(this.crvMarcacaoCirugia);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRelatorio_MarcacaoCirugia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório para Marcação de Cirugia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRelatorio_MarcacaoCirugia_FormClosed);
            this.Load += new System.EventHandler(this.frmRelatorio_MarcacaoCirugia_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvMarcacaoCirugia;
    }
}