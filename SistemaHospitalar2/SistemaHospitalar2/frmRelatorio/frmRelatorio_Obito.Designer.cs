namespace SistemaHospitalar2.frmRelatorio
{
    partial class frmRelatorio_Obito
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
            this.crvObito = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvObito
            // 
            this.crvObito.ActiveViewIndex = -1;
            this.crvObito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvObito.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvObito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvObito.Location = new System.Drawing.Point(0, 0);
            this.crvObito.Name = "crvObito";
            this.crvObito.Size = new System.Drawing.Size(745, 486);
            this.crvObito.TabIndex = 0;
            this.crvObito.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmRelatorio_Obito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 486);
            this.Controls.Add(this.crvObito);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRelatorio_Obito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Óbito";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmRelatorio_Obito_FormClosed);
            this.Load += new System.EventHandler(this.frmRelatorio_Obito_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvObito;
    }
}