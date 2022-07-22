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
    public partial class frmRelatorio_Justificativo : Form
    {
        public frmRelatorio_Justificativo()
        {
            InitializeComponent();
        }
        public int codAlta;
        public int codMarcacao;
        public string operacao = "";

        private void frmRelatorio_Justificativo_Load(object sender, EventArgs e)
        {
            if(operacao.Equals("Alta Hospitalar"))
            {
                ReportDocument rd = new ReportDocument();
                rd.Load(@"C:\Z_Gomilson\Gomilson programador\Meus_livros\TREI\Prof. Jc\Pré Projecto\Prático\Software\SistemaHospitalar2\SistemaHospitalar2\Relatorio\crvRelatorioJustificativo.rpt");
                ParameterField parametro = rd.ParameterFields["codAlta"];
                parametro.CurrentValues.AddValue(codAlta);
                crvJustificativo.ReportSource = rd;
            }
            else if(operacao.Equals("Marcação Consulta"))
            {
                ReportDocument rd = new ReportDocument();
                rd.Load(@"C:\Z_Gomilson\Gomilson programador\Meus_livros\TREI\Prof. Jc\Pré Projecto\Prático\Software\SistemaHospitalar2\SistemaHospitalar2\Relatorio\crvRelatorioJustificativo_Consulta.rpt");
                ParameterField parametro = rd.ParameterFields["codMarcacao"];
                parametro.CurrentValues.AddValue(codMarcacao);
                crvJustificativo.ReportSource = rd;
            }
        }

        private void frmRelatorio_Justificativo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.relJustificativo = null;
        }
    }
}
