using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace SistemaHospitalar2.frmRelatorio
{
    public partial class frmRelatorio_Obito : Form
    {
        public frmRelatorio_Obito()
        {
            InitializeComponent();
        }
        public int codObito;

        private void frmRelatorio_Obito_Load(object sender, EventArgs e)
        {
            ReportDocument rd = new ReportDocument();
            rd.Load(@"C:\Z_Gomilson\Gomilson programador\Meus_livros\TREI\Prof. Jc\Pré Projecto\Prático\Software\SistemaHospitalar2\SistemaHospitalar2\Relatorio\crvRelatorioObito.rpt");
            ParameterField parametro = rd.ParameterFields["codObito"];
            parametro.CurrentValues.AddValue(codObito);
            crvObito.ReportSource = rd;
        }

        private void frmRelatorio_Obito_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.relObito = null;
        }
    }
}
