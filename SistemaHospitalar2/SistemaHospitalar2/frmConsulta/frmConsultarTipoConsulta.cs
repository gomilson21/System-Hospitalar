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
    public partial class frmConsultarTipoConsulta : Form
    {
        public frmConsultarTipoConsulta()
        {
            InitializeComponent();
        }
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");

        public void PesquisarTipoConsulta()
        {
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT * FROM Tipo_Consulta WHERE nome LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            DataTable dados = new DataTable();
            Adpter.Fill(dados);
            tipoConsultaDataGridView.DataSource = dados;
        }

        private void frmConsultarTipoConsulta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_HospitalDataSet1.Tipo_Consulta' table. You can move, or remove it, as needed.
            this.tipo_ConsultaTableAdapter.Fill(this.db_HospitalDataSet1.Tipo_Consulta);
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            this.PesquisarTipoConsulta();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultarTipoConsulta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.conTipoConsulta = null;
        }
    }
}
