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
    public partial class frmConsultarFuncionario_Geral : Form
    {
        public frmConsultarFuncionario_Geral()
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
            funcionarioGeralDataGridView.DataSource = dados.ListarFuncionario();
        }
        // Nome do Funcionário
        public void PesquisarNomeFuncionario()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codFuncionario, nome_funcionario, dataNascimento_funcionario, sexo_funcionario, BI_funcionario, email_funcionario, telefone_funcionario, endereco_funcionario, numeroCarteira_funcionario, dataAdmissao_funcionario, nome_funcao FROM Funcionarios INNER JOIN Funcao ON (Funcionarios.codFuncao = Funcao.codFuncao) WHERE nome_funcionario LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adpter.Fill(dados);
            funcionarioGeralDataGridView.DataSource = dados;
        }
        // Nome da Função
        public void PesquisarNomeFuncao()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codFuncionario, nome_funcionario, dataNascimento_funcionario, sexo_funcionario, BI_funcionario, email_funcionario, telefone_funcionario, endereco_funcionario, numeroCarteira_funcionario, dataAdmissao_funcionario, nome_funcao FROM Funcionarios INNER JOIN Funcao ON (Funcionarios.codFuncao = Funcao.codFuncao) WHERE nome_funcao LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adpter.Fill(dados);
            funcionarioGeralDataGridView.DataSource = dados;
        }
        // Sexo do Funcionário
        public void PesquisarSexo()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codFuncionario, nome_funcionario, dataNascimento_funcionario, sexo_funcionario, BI_funcionario, email_funcionario, telefone_funcionario, endereco_funcionario, numeroCarteira_funcionario, dataAdmissao_funcionario, nome_funcao FROM Funcionarios INNER JOIN Funcao ON (Funcionarios.codFuncao = Funcao.codFuncao) WHERE sexo_funcionario = '" + txtPesquisa.Text + "'", Sqlcon);
            Adpter.Fill(dados);
            funcionarioGeralDataGridView.DataSource = dados;
        }
        // Endereço do Funcionário
        public void PesquisarEndereco()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codFuncionario, nome_funcionario, dataNascimento_funcionario, sexo_funcionario, BI_funcionario, email_funcionario, telefone_funcionario, endereco_funcionario, numeroCarteira_funcionario, dataAdmissao_funcionario, nome_funcao FROM Funcionarios INNER JOIN Funcao ON (Funcionarios.codFuncao = Funcao.codFuncao) WHERE endereco_funcionario LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adpter.Fill(dados);
            funcionarioGeralDataGridView.DataSource = dados;
        }
        // Data de Nascimento de funcionário
        public void PesquisarDataNascimento()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codFuncionario, nome_funcionario, dataNascimento_funcionario, sexo_funcionario, BI_funcionario, email_funcionario, telefone_funcionario, endereco_funcionario, numeroCarteira_funcionario, dataAdmissao_funcionario, nome_funcao FROM Funcionarios INNER JOIN Funcao ON (Funcionarios.codFuncao = Funcao.codFuncao) WHERE dataNascimento_funcionario = '" + Convert.ToDateTime(txtPesquisa.Text) + "'", Sqlcon);
            Adpter.Fill(dados);
            funcionarioGeralDataGridView.DataSource = dados;
        }
        // Data de Nascimento de funcionário
        public void PesquisarDataAdmissao()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codFuncionario, nome_funcionario, dataNascimento_funcionario, sexo_funcionario, BI_funcionario, email_funcionario, telefone_funcionario, endereco_funcionario, numeroCarteira_funcionario, dataAdmissao_funcionario, nome_funcao FROM Funcionarios INNER JOIN Funcao ON (Funcionarios.codFuncao = Funcao.codFuncao) WHERE dataAdmissao_funcionario = '" + txtPesquisa.Text + "'", Sqlcon);
            Adpter.Fill(dados);
            funcionarioGeralDataGridView.DataSource = dados;
        }

        private void frmConsultarFuncionario_Geral_Load(object sender, EventArgs e)
        {
            // Carregar dados do Funcionário no DataGriView
            this.CarregarDados();
            cbFormaPesquisa.SelectedItem = "Nome do Funcionário";
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (cbFormaPesquisa.SelectedItem.Equals("Nome do Funcionário"))
                this.PesquisarNomeFuncionario();
            else if (cbFormaPesquisa.SelectedItem.Equals("Sexo do Funcionário"))
                this.PesquisarSexo();
            else if (cbFormaPesquisa.SelectedItem.Equals("Nome da Função"))
                this.PesquisarNomeFuncao();
            else if (cbFormaPesquisa.SelectedItem.Equals("Endereço do Funcionário"))
                this.PesquisarEndereco();
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
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultarFuncionario_Geral_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.conFunGeral = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
