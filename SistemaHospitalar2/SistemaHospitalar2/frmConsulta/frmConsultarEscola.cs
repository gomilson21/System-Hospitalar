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
    public partial class frmConsultarEscola : Form
    {
        public frmConsultarEscola()
        {
            InitializeComponent();
        }
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");

        public void PesquisarEscola()
        {
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT * FROM Escola WHERE nome_escola LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            DataTable dados = new DataTable();
            Adpter.Fill(dados);
            escolaDataGridView.DataSource = dados;
        }

        private void frmConsultarEscola_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_HospitalDataSet1.Escola' table. You can move, or remove it, as needed.
            this.escolaTableAdapter.Fill(this.db_HospitalDataSet1.Escola);
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            this.PesquisarEscola();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultarEscola_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.conEscola = null;
        }
    }
}
