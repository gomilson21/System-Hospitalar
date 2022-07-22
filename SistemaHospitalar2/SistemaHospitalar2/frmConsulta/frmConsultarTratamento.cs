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
    public partial class frmConsultarTratamento : Form
    {
        public frmConsultarTratamento()
        {
            InitializeComponent();
        }

        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");

        public void PesquisarTratamento()
        {
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT * FROM Tratamento WHERE nome LIKE '%"+ txtPesquisa.Text +"%'", Sqlcon);
            DataTable dados = new DataTable();
            Adpter.Fill(dados);
            tratamentoDataGridView.DataSource = dados;
        }

        private void frmConsultarTratamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_HospitalDataSet.Tratamento' table. You can move, or remove it, as needed.
            this.tratamentoTableAdapter.Fill(this.db_HospitalDataSet.Tratamento);

            txtPesquisa.Focus();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            PesquisarTratamento();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void frmConsultarTratamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.conTratamento = null;
        }
    }
}
