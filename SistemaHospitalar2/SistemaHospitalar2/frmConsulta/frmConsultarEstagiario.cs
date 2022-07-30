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
    public partial class frmConsultarEstagiario : Form
    {
        public frmConsultarEstagiario()
        {
            InitializeComponent();
        }
        Dados.Listar dados = new Dados.Listar();
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");

        private void HabilitarBotao()
        {
            if (cbFormaPesquisa.SelectedItem.Equals("Data de Nascimento"))
            {
                btnBuscar.Enabled = true;
                btnActualizar.Enabled = true;
            }
            else if (cbFormaPesquisa.SelectedItem.Equals("Data de Admissão"))
            {
                btnBuscar.Enabled = true;
                btnActualizar.Enabled = true;
            }
            else
            {
                btnBuscar.Enabled = false;
                btnActualizar.Enabled = false;
            }
        }

        public void CarregarDados()
        {
            estagiarioDataGridView.DataSource = dados.ListarEstagiario();
        }
        // Nome do Estagiario
        public void PesquisarNomeEstagiario()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codEstagiario, nome_estagiario, dataNascimento_estagiario, sexo_estagiario, BI_estagiario, telefone_estagiario, endereco_estagiario, email_estagiario, licencaEstagio_estagiario, dataAdmissao_estagiario, nome_escola FROM Estagiario INNER JOIN Escola ON (Estagiario.codEscola = Escola.codEscola) WHERE nome_estagiario LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adpter.Fill(dados);
            estagiarioDataGridView.DataSource = dados;
        }
        // Nome da Escola
        public void PesquisarNomeEscola()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codEstagiario, nome_estagiario, dataNascimento_estagiario, sexo_estagiario, BI_estagiario, telefone_estagiario, endereco_estagiario, email_estagiario, licencaEstagio_estagiario, dataAdmissao_estagiario, nome_escola FROM Estagiario INNER JOIN Escola ON (Estagiario.codEscola = Escola.codEscola) WHERE nome_escola LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adpter.Fill(dados);
            estagiarioDataGridView.DataSource = dados;
        }
        // Sexo do Estagiario
        public void PesquisarSexo()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codEstagiario, nome_estagiario, dataNascimento_estagiario, sexo_estagiario, BI_estagiario, telefone_estagiario, endereco_estagiario, email_estagiario, licencaEstagio_estagiario, dataAdmissao_estagiario, nome_escola FROM Estagiario INNER JOIN Escola ON (Estagiario.codEscola = Escola.codEscola) WHERE sexo_estagiario = '" + txtPesquisa.Text + "'", Sqlcon);
            Adpter.Fill(dados);
            estagiarioDataGridView.DataSource = dados;
        }
        // Data de Nascimento do Estagiario
        public void PesquisarDataNascimento()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codEstagiario, nome_estagiario, dataNascimento_estagiario, sexo_estagiario, BI_estagiario, telefone_estagiario, endereco_estagiario, email_estagiario, licencaEstagio_estagiario, dataAdmissao_estagiario, nome_escola FROM Estagiario INNER JOIN Escola ON (Estagiario.codEscola = Escola.codEscola) WHERE dataNascimento_estagiario = '" + Convert.ToDateTime(txtPesquisa.Text) + "'", Sqlcon);
            Adpter.Fill(dados);
            estagiarioDataGridView.DataSource = dados;
        }
        // Data de Admissão do Estagiario
        public void PesquisarDataAdmissao()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codEstagiario, nome_estagiario, dataNascimento_estagiario, sexo_estagiario, BI_estagiario, telefone_estagiario, endereco_estagiario, email_estagiario, licencaEstagio_estagiario, dataAdmissao_estagiario, nome_escola FROM Estagiario INNER JOIN Escola ON (Estagiario.codEscola = Escola.codEscola) WHERE dataAdmissao_estagiario = '" + Convert.ToDateTime(txtPesquisa.Text) + "'", Sqlcon);
            Adpter.Fill(dados);
            estagiarioDataGridView.DataSource = dados;
        }

        private void frmConsultarEstagiario_Load(object sender, EventArgs e)
        {
            // Carregar dados do Estagiario no DataGriView
            this.CarregarDados();
            cbFormaPesquisa.SelectedItem = "Nome do Estagiario";
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (cbFormaPesquisa.SelectedItem.Equals("Nome do Estagiario"))
                this.PesquisarNomeEstagiario();
            else if (cbFormaPesquisa.SelectedItem.Equals("Sexo"))
                this.PesquisarSexo();
            else if (cbFormaPesquisa.SelectedItem.Equals("Data de Nascimento"))
                this.PesquisarDataNascimento();
            else if (cbFormaPesquisa.SelectedItem.Equals("Data de Admissão"))
                this.PesquisarDataAdmissao();
            else if (cbFormaPesquisa.SelectedItem.Equals("Nome da Escola"))
                this.PesquisarNomeEscola();
        }

        private void cbFormaPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.HabilitarBotao();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbFormaPesquisa.SelectedItem.Equals("Data de Nascimento"))
                this.PesquisarDataNascimento();
            else if (cbFormaPesquisa.SelectedItem.Equals("Data de Admissão"))
                this.PesquisarDataAdmissao();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtPesquisa.Clear();
            this.CarregarDados();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultarEstagiario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.conEstagiario = null;
        }
    }
}
