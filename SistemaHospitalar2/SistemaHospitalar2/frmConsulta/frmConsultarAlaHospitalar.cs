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
    public partial class frmConsultarAlaHospitalar : Form
    {
        public frmConsultarAlaHospitalar()
        {
            InitializeComponent();
        }

        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");

        public void PesquisarALaHospitalar()
        {
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT * FROM Ala_Hospitalar WHERE nome LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            DataTable dados = new DataTable();
            Adpter.Fill(dados);
            alaHospitalarDataGridView.DataSource = dados;
        }

        private void frmConsultarAlaHospitalar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_HospitalDataSet1.Ala_Hospitalar' table. You can move, or remove it, as needed.
            this.ala_HospitalarTableAdapter.Fill(this.db_HospitalDataSet1.Ala_Hospitalar);

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            this.PesquisarALaHospitalar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultarAlaHospitalar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.conAlaHospitalar = null;
        }
    }
}
