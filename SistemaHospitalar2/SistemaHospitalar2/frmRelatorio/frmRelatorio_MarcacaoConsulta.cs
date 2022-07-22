using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace SistemaHospitalar2.frmRelatorio
{
    public partial class frmRelatorio_MarcacaoConsulta : Form
    {
        public frmRelatorio_MarcacaoConsulta()
        {
            InitializeComponent();
        }
        public int codMarcacao;

        private void frmRelatorio_MarcacaoConsulta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.relMarcacaoConsulta = null;
        }

        private void frmRelatorio_MarcacaoConsulta_Load(object sender, EventArgs e)
        {
            ReportDocument rd = new ReportDocument();
            rd.Load(@"C:\Z_Gomilson\Gomilson programador\Meus_livros\TREI\Prof. Jc\Pré Projecto\Prático\Software\SistemaHospitalar2\SistemaHospitalar2\Relatorio\crvMarcacaoConsulta.rpt");
            ParameterField parametro = rd.ParameterFields["codMarcacao"];
            parametro.CurrentValues.AddValue(codMarcacao);
            crvMarcacaoConsulta.ReportSource = rd;
        }
    }
}
