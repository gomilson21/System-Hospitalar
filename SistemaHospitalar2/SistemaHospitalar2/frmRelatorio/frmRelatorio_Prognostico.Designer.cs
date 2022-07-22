namespace SistemaHospitalar2.frmRelatorio
{
    partial class frmRelatorio_Prognostico
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
            this.crvPrognostico = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvPrognostico
            // 
            this.crvPrognostico.ActiveViewIndex = -1;
            this.crvPrognostico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvPrognostico.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvPrognostico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvPrognostico.Location = new System.Drawing.Point(0, 0);
            this.crvPrognostico.Name = "crvPrognostico";
            this.crvPrognostico.Size = new System.Drawing.Size(667, 489);
            this.crvPrognostico.TabIndex = 0;
            this.crvPrognostico.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmRelatorio_Prognostico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 489);
            this.Controls.Add(this.crvPrognostico);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRelatorio_Prognostico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prognóstico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRelatorio_Prognostico_FormClosed);
            this.Load += new System.EventHandler(this.frmRelatorio_Prognostico_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvPrognostico;
    }
}