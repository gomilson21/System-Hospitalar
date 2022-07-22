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

namespace SistemaHospitalar2.frmConsulta
{
    public partial class frmConsultarEspecialidadeMedico : Form
    {
        public frmConsultarEspecialidadeMedico()
        {
            InitializeComponent();
        }
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");

        public void PesquisarEspMedico()
        {
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT * FROM Especialidade_Medico WHERE nome LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            DataTable dados = new DataTable();
            Adpter.Fill(dados);
            especialidadeMedicoDataGridView.DataSource = dados;
        }

        private void frmConsultarEspecialidadeMedico_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_HospitalDataSet1.Especialidade_Medico' table. You can move, or remove it, as needed.
            this.especialidade_MedicoTableAdapter.Fill(this.db_HospitalDataSet1.Especialidade_Medico);
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            this.PesquisarEspMedico();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultarEspecialidadeMedico_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.conEspMedico = null;
        }
    }
}
