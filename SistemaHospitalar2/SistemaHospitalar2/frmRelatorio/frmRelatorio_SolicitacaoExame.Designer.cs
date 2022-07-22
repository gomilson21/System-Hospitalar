namespace SistemaHospitalar2.frmRelatorio
{
    partial class frmRelatorio_SolicitacaoExame
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
            this.crvSolExame = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvSolExame
            // 
            this.crvSolExame.ActiveViewIndex = -1;
            this.crvSolExame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvSolExame.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvSolExame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvSolExame.Location = new System.Drawing.Point(0, 0);
            this.crvSolExame.Name = "crvSolExame";
            this.crvSolExame.Size = new System.Drawing.Size(885, 478);
            this.crvSolExame.TabIndex = 0;
            this.crvSolExame.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmRelatorio_SolicitacaoExame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 478);
            this.Controls.Add(this.crvSolExame);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRelatorio_SolicitacaoExame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitação Exame";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSolicitacaoExame_FormClosed);
            this.Load += new System.EventHandler(this.frmRelatorio_SolicitacaoExame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSolExame;
    }
}