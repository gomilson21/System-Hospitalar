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
    public partial class frmRelatorio_SolicitacaoExame : Form
    {
        public frmRelatorio_SolicitacaoExame()
        {
            InitializeComponent();
        }
        public int codMarcacao;
        public int codPacInternado;
        public string operacao = ""; 

        private void frmSolicitacaoExame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.relSolicitacaoExame = null;
        }

        private void frmRelatorio_SolicitacaoExame_Load(object sender, EventArgs e)
        {
            if(operacao.Equals("Marcação Consulta"))
            {
                ReportDocument rd = new ReportDocument();
                rd.Load(@"C:\Z_Gomilson\Gomilson programador\Meus_livros\TREI\Prof. Jc\Pré Projecto\Prático\Software\SistemaHospitalar2\SistemaHospitalar2\Relatorio\crvRelatorioJustificativo_Consulta.rpt");
                ParameterField parametro = rd.ParameterFields["codMarcacao"];
                parametro.CurrentValues.AddValue(codMarcacao);
                crvSolExame.ReportSource = rd;
            }
            else if(operacao.Equals("Paciente Internado"))
            {
                ReportDocument rd = new ReportDocument();
                rd.Load(@"C:\Z_Gomilson\Gomilson programador\Meus_livros\TREI\Prof. Jc\Pré Projecto\Prático\Software\SistemaHospitalar2\SistemaHospitalar2\Relatorio\crSolicitacaoExame.rpt");
                ParameterField parametro = rd.ParameterFields["codPacInternado"];
                parametro.CurrentValues.AddValue(codPacInternado);
                crvSolExame.ReportSource = rd;
            }
    
        }
    }
}
