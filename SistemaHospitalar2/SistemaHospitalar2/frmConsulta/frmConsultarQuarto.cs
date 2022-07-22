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
    public partial class frmConsultarQuarto : Form
    {
        public frmConsultarQuarto()
        {
            InitializeComponent();
        }
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");

        public void PesquisarQuarto()
        {
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT * FROM Quarto WHERE nome LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            DataTable dados = new DataTable();
            Adpter.Fill(dados);
            quartoDataGridView.DataSource = dados;
        }

        private void frmConsultarQuarto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_HospitalDataSet1.Quarto' table. You can move, or remove it, as needed.
            this.quartoTableAdapter.Fill(this.db_HospitalDataSet1.Quarto);
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            this.PesquisarQuarto();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultarQuarto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.conQuarto = null;
        }
    }
}
