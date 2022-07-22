namespace SistemaHospitalar2.frmRelatorio
{
    partial class frmRelatorio_Justificativo
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
            this.crvJustificativo = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvJustificativo
            // 
            this.crvJustificativo.ActiveViewIndex = -1;
            this.crvJustificativo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvJustificativo.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvJustificativo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvJustificativo.Location = new System.Drawing.Point(0, 0);
            this.crvJustificativo.Name = "crvJustificativo";
            this.crvJustificativo.Size = new System.Drawing.Size(759, 472);
            this.crvJustificativo.TabIndex = 0;
            this.crvJustificativo.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmRelatorio_Justificativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 472);
            this.Controls.Add(this.crvJustificativo);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmRelatorio_Justificativo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Justificativo Médico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRelatorio_Justificativo_FormClosed);
            this.Load += new System.EventHandler(this.frmRelatorio_Justificativo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvJustificativo;
    }
}