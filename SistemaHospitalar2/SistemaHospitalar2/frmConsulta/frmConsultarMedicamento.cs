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
    public partial class frmConsultarMedicamento : Form
    {
        public frmConsultarMedicamento()
        {
            InitializeComponent();
        }
        Dados.Listar dados = new Dados.Listar();
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");

        private void MostrarBotao()
        {
            if (cbFormaPesquisa.SelectedItem.Equals("Data de Validade"))
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
            medicamentoDataGridView.DataSource = dados.ListarMedicamento();
        }
        //  Nome Comercial
        public void PesquisarNomeComercial()
        {
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codMedicamento, nomeGenerico_medicamento, nomeComercial_medicamento, quantidadeInicial_medicamento, quantidadeEntrada_medicamento, dataValidade_medicamento, nome_fornecedor, descricao_medicamento, quantidadeActual_medicamento, quantidadeMinima_medicamento, quantidadeMaxima_medicamento FROM Medicamento INNER JOIN Fornecedor ON (Medicamento.codFornecedor = Fornecedor.codFornecedor) WHERE nome_comercial LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            DataTable dados = new DataTable();
            Adpter.Fill(dados);
            medicamentoDataGridView.DataSource = dados;
        }
        //  Nome Genérico
        public void PesquisarNomeGenerico()
        {
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codMedicamento, nomeGenerico_medicamento, nomeComercial_medicamento, quantidadeInicial_medicamento, quantidadeEntrada_medicamento, dataValidade_medicamento, nome_fornecedor, descricao_medicamento, quantidadeActual_medicamento, quantidadeMinima_medicamento, quantidadeMaxima_medicamento FROM Medicamento INNER JOIN Fornecedor ON (Medicamento.codFornecedor = Fornecedor.codFornecedor) WHERE nome_generico LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            DataTable dados = new DataTable();
            Adpter.Fill(dados);
            medicamentoDataGridView.DataSource = dados;
        }
        //  Nome do Fornecedor
        public void PesquisarNomeFornecedor()
        {
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codMedicamento, nomeGenerico_medicamento, nomeComercial_medicamento, quantidadeInicial_medicamento, quantidadeEntrada_medicamento, dataValidade_medicamento, nome_fornecedor, descricao_medicamento, quantidadeActual_medicamento, quantidadeMinima_medicamento, quantidadeMaxima_medicamento FROM Medicamento INNER JOIN Fornecedor ON (Medicamento.codFornecedor = Fornecedor.codFornecedor) WHERE nome_fornecedor LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            DataTable dados = new DataTable();
            Adpter.Fill(dados);
            medicamentoDataGridView.DataSource = dados;
        }
        //  Data de Validade
        public void PesquisarDataValidade()
        {
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codMedicamento, nomeGenerico_medicamento, nomeComercial_medicamento, quantidadeInicial_medicamento, quantidadeEntrada_medicamento, dataValidade_medicamento, nome_fornecedor, descricao_medicamento, quantidadeActual_medicamento, quantidadeMinima_medicamento, quantidadeMaxima_medicamento FROM Medicamento INNER JOIN Fornecedor ON (Medicamento.codFornecedor = Fornecedor.codFornecedor) WHERE dataValidade_medicamento '" + txtPesquisa.Text + "'", Sqlcon);
            DataTable dados = new DataTable();
            Adpter.Fill(dados);
            medicamentoDataGridView.DataSource = dados;
        }

        private void frmConsultarMedicamento_Load(object sender, EventArgs e)
        {
            // Carregar dados do Medicamento no DataGridView
            this.CarregarDados();
            cbFormaPesquisa.SelectedItem = "Nome Comercial";
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (cbFormaPesquisa.SelectedItem.Equals("Nome Comercial"))
                this.PesquisarNomeComercial();
            else if (cbFormaPesquisa.SelectedItem.Equals("Nome Genérico"))
                this.PesquisarNomeGenerico();
            else if (cbFormaPesquisa.SelectedItem.Equals("Nome do Fornecedor"))
                this.PesquisarNomeFornecedor();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultarMedicamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.conMedicamento = null;
        }

        private void cbFormaPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.MostrarBotao();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbFormaPesquisa.SelectedItem.Equals("Data da Validade"))
                this.PesquisarDataValidade();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtPesquisa.Clear();
            this.CarregarDados();
        }
    }
}
