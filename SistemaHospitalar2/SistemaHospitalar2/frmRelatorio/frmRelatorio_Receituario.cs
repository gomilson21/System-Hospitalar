using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace SistemaHospitalar2.frmRelatorio
{
    public partial class frmRelatorio_Receituario : Form
    {
        public frmRelatorio_Receituario()
        {
            InitializeComponent();
        }
        Dados.Listar dados = new Dados.Listar();
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");

        private void ListarPacienteInternado()
        {
            cbPacienteInternado.DataSource = dados.ComboBoxListarPacienteInternado();
            cbPacienteInternado.DisplayMember = "nome_PacienteInternado";
            cbPacienteInternado.ValueMember = "codPacienteInternado";
        }

        private void frmRelatorio_Receituario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.relReceituario = null;
        }

        private void frmRelatorio_Receituario_Load(object sender, EventArgs e)
        {
            this.ListarPacienteInternado();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDocument rd = new ReportDocument();
            rd.Load(@"C:\Z_Gomilson\#Começando\Pré Projecto\Prático\Software\SistemaHospitalar2\SistemaHospitalar2\Relatorio\crReceituario.rpt");
            ParameterField parametro = rd.ParameterFields["codPacienteInternado"];
            parametro.CurrentValues.AddValue(Convert.ToInt32(cbPacienteInternado.SelectedValue));
            crvReceituario.ReportSource = rd;
        }
    }
}
