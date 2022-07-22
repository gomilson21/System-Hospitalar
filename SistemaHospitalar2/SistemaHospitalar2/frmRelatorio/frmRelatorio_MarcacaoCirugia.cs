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
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace SistemaHospitalar2.frmRelatorio
{
    public partial class frmRelatorio_MarcacaoCirugia : Form
    {
        public frmRelatorio_MarcacaoCirugia()
        {
            InitializeComponent();
        }
        public int codCirugia;

        private void frmRelatorio_MarcacaoCirugia_Load(object sender, EventArgs e)
        {
            ReportDocument rd = new ReportDocument();
            rd.Load(@"C:\Z_Gomilson\Gomilson programador\Meus_livros\TREI\Prof. Jc\Pré Projecto\Prático\Software\SistemaHospitalar2\SistemaHospitalar2\Relatorio\crvMarcacaoCirugia.rpt");
            ParameterField parametro = rd.ParameterFields["codCirugia"];
            parametro.CurrentValues.AddValue(codCirugia);
            crvMarcacaoCirugia.ReportSource = rd;
        }

        private void frmRelatorio_MarcacaoCirugia_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.relMarcacaoCirugia = null;
        }
    }
}
