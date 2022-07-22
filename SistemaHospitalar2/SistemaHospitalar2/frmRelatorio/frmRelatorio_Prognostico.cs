using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace SistemaHospitalar2.frmRelatorio
{
    public partial class frmRelatorio_Prognostico : Form
    {
        public frmRelatorio_Prognostico()
        {
            InitializeComponent();
        }
        public int codPacInternado;

        private void frmRelatorio_Prognostico_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.relPrognostico = null;
        }

        private void frmRelatorio_Prognostico_Load(object sender, EventArgs e)
        {
            ReportDocument rd = new ReportDocument();
            rd.Load(@"C:\Z_Gomilson\Gomilson programador\Meus_livros\TREI\Prof. Jc\Pré Projecto\Prático\Software\SistemaHospitalar2\SistemaHospitalar2\Relatorio\crPrognostico.rpt");
            ParameterField parametro = rd.ParameterFields["codPacInternado"];
            parametro.CurrentValues.AddValue(codPacInternado);
            crvPrognostico.ReportSource = rd;
        }
    }
}
