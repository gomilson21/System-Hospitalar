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
    public partial class frmConsultarMedico : Form
    {
        public frmConsultarMedico()
        {
            InitializeComponent();
        }
        Dados.Listar dados = new Dados.Listar();
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");

        private void MostrarBotao()
        {
            if (cbFormaPesquisa.SelectedItem.Equals("Data de Nascimento"))
            {
                btnBuscar.Show();
                btnActualizar.Show();
            }
            else if (cbFormaPesquisa.SelectedItem.Equals("Data de Admissão"))
            {
                btnBuscar.Show();
                btnActualizar.Show();
            }
            else
            {
                btnBuscar.Hide();
                btnActualizar.Hide();
            }
        }

        public void CarregarDados()
        {
            medicoDataGridView.DataSource = dados.ListarMedico();
        }
        // Nome do Funcionário
        public void PesquisarNomeMedico()
        {
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codMedico, nome_medico, dataNascimento_medico, sexo_medico, BI_medico, telefone_medico, email_medico, endereco_medico, numeroCarteira_medico, dataAdmissao_medico, nome_especialidade FROM Medico INNER JOIN Especialidade_Medico ON (Medico.codEspecialidade = Especialidade_Medico.codEspecialidade) WHERE nome_medico LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            DataTable dados = new DataTable();
            Adpter.Fill(dados);
            medicoDataGridView.DataSource = dados;
        }
        // Nome da Função
        public void PesquisarNomeEspecialidade()
        {
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codMedico, nome_medico, dataNascimento_medico, sexo_medico, BI_medico, telefone_medico, email_medico, endereco_medico, numeroCarteira_medico, dataAdmissao_medico, nome_especialidade FROM Medico INNER JOIN Especialidade_Medico ON (Medico.codEspecialidade = Especialidade_Medico.codEspecialidade) WHERE nome_especialidade LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            DataTable dados = new DataTable();
            Adpter.Fill(dados);
            medicoDataGridView.DataSource = dados;
        }
        // Sexo do Funcionário
        public void PesquisarSexo()
        {
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codMedico, nome_medico, dataNascimento_medico, sexo_medico, BI_medico, telefone_medico, email_medico, endereco_medico, numeroCarteira_medico, dataAdmissao_medico, nome_especialidade FROM Medico INNER JOIN Especialidade_Medico ON (Medico.codEspecialidade = Especialidade_Medico.codEspecialidade) WHERE sexo_medico = '" + txtPesquisa.Text + "'", Sqlcon);
            DataTable dados = new DataTable();
            Adpter.Fill(dados);
            medicoDataGridView.DataSource = dados;
        }
        // Endereço do Funcionário
        public void PesquisarEndereco()
        {
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codMedico, nome_medico, dataNascimento_medico, sexo_medico, BI_medico, telefone_medico, email_medico, endereco_medico, numeroCarteira_medico, dataAdmissao_medico, nome_especialidade FROM Medico INNER JOIN Especialidade_Medico ON (Medico.codEspecialidade = Especialidade_Medico.codEspecialidade) WHERE endereco_medico LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            DataTable dados = new DataTable();
            Adpter.Fill(dados);
            medicoDataGridView.DataSource = dados;
        }
        // Data de Nascimento de funcionário
        public void PesquisarDataNascimento()
        {
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codMedico, nome_medico, dataNascimento_medico, sexo_medico, BI_medico, telefone_medico, email_medico, endereco_medico, numeroCarteira_medico, dataAdmissao_medico, nome_especialidade FROM Medico INNER JOIN Especialidade_Medico ON (Medico.codEspecialidade = Especialidade_Medico.codEspecialidade) WHERE dataNascimento_medico = '" + txtPesquisa.Text + "'", Sqlcon);
            DataTable dados = new DataTable();
            Adpter.Fill(dados);
            medicoDataGridView.DataSource = dados;
        }
        // Data de Nascimento de funcionário
        public void PesquisarDataAdmissao()
        { 
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codMedico, nome_medico, dataNascimento_medico, sexo_medico, BI_medico, telefone_medico, email_medico, endereco_medico, numeroCarteira_medico, dataAdmissao_medico, nome_especialidade FROM Medico INNER JOIN Especialidade_Medico ON (Medico.codEspecialidade = Especialidade_Medico.codEspecialidade) WHERE dataAdmissao_medico = '" + txtPesquisa.Text + "'", Sqlcon);
            DataTable dados = new DataTable();
            Adpter.Fill(dados);
            medicoDataGridView.DataSource = dados;
        }

        private void frmConsultarMedico_Load(object sender, EventArgs e)
        {
            //  Carregar dados do Médico no DataGridView 
            this.CarregarDados();
            cbFormaPesquisa.SelectedItem = "Nome do Médico";
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
          if (cbFormaPesquisa.SelectedItem.Equals("Nome do Médico"))
                this.PesquisarNomeMedico();
            else if (cbFormaPesquisa.SelectedItem.Equals("Sexo do Médico"))
                this.PesquisarSexo();
            else if (cbFormaPesquisa.SelectedItem.Equals("Nome da Especialidade"))
                this.PesquisarNomeEspecialidade();
            else if (cbFormaPesquisa.SelectedItem.Equals("Endereço do Médico"))
                this.PesquisarEndereco();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultarMedico_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.conMedico = null;
        }

        private void cbFormaPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.MostrarBotao();
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
    }
}
