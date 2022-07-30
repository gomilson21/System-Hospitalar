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
    public partial class frmConsultarExame : Form
    {
        public frmConsultarExame()
        {
            InitializeComponent();
        }
        Dados.Listar exame = new Dados.Listar();
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");
        DataTable dados;
        SqlDataAdapter Adpter;

        public void PesquisarExame()
        {
            dados = new DataTable();
            Adpter = new SqlDataAdapter("SELECT codExame, nome_exame, descricao_exame, nome_tipoExame FROM Exame INNER JOIN Tipo_Exame ON (Exame.codTipoExame = Tipo_Exame.codTipoExame) WHERE nome_exame LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adpter.Fill(dados);
            exameDataGridView.DataSource = dados;
        }

        public void PesquisarTipoExame()
        {
            dados = new DataTable();
            Adpter = new SqlDataAdapter("SELECT codExame, nome_exame, descricao_exame, nome_tipoExame FROM Exame INNER JOIN Tipo_Exame ON (Exame.codTipoExame = Tipo_Exame.codTipoExame) WHERE nome_tipoExame LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adpter.Fill(dados);
            exameDataGridView.DataSource = dados;
        }

        private void frmConsultarExame_Load(object sender, EventArgs e)
        {   // Carregando os dados no DataGridView
            exameDataGridView.DataSource = exame.ListarExame();
            //Combobox
            cbFormaPesquisa.SelectedItem = "Nome do Exame";
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
           if (cbFormaPesquisa.SelectedItem.Equals("Nome do Exame"))
                this.PesquisarExame();
            else if(cbFormaPesquisa.SelectedItem.Equals("Tipo de Exame"))
                this.PesquisarTipoExame();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultarExame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.conExame = null;
        }
    }
}
