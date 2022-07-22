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
    public partial class frmConsultarTipoCirugia : Form
    {
        public frmConsultarTipoCirugia()
        {
            InitializeComponent();
        }
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");

        public void PesquisarTipoCirugia()
        {
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT * FROM Tipo_Cirugia WHERE nome_cirugia LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            DataTable dados = new DataTable();
            Adpter.Fill(dados);
            tipoCirugiaDataGridView.DataSource = dados;
        }

        private void frmConsultarTipoCirugia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_HospitalDataSet1.Tipo_Cirugia' table. You can move, or remove it, as needed.
            this.tipo_CirugiaTableAdapter.Fill(this.db_HospitalDataSet1.Tipo_Cirugia);
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            this.PesquisarTipoCirugia();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultarTipoCirugia_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.conTipoCirugia = null;
        }
    }
}
