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
    public partial class frmConsultarMatDescartavel : Form
    {
        public frmConsultarMatDescartavel()
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
            matDescartavelDataGridView.DataSource = dados.ListarMaterialDescartavel();
        }
        //  Nome Material Descartável
        public void PesquisarNomeMaterialDescartavel()
        {
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codMatrialDescartavel, nome_material, quantidadeInicial_material, quantidadeEntrada_material, dataValidade_material, nome_fornecedor, descricao_material, quantidadeActual_material, quantidadeMinima_material, quantidadeMaxima_material from Material_Descartavel inner join Fornecedor on (Material_Descartavel.codFornecedor = Fornecedor.codFornecedor) WHERE nome_material LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            DataTable dados = new DataTable();
            Adpter.Fill(dados);
            matDescartavelDataGridView.DataSource = dados;
        }
        //  Nome do Fornecedor
        public void PesquisarNomeFornecedor()
        {
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT  codMatrialDescartavel, nome_material, quantidadeInicial_material, quantidadeEntrada_material, dataValidade_material, nome_fornecedor, descricao_material, quantidadeActual_material, quantidadeMinima_material, quantidadeMaxima_material from Material_Descartavel inner join Fornecedor on (Material_Descartavel.codFornecedor = Fornecedor.codFornecedor) WHERE nome_fornecedor LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            DataTable dados = new DataTable();
            Adpter.Fill(dados);
            matDescartavelDataGridView.DataSource = dados;
        }
        //  Data de validade
        public void PesquisarDataValidade()
        {
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT  codMatrialDescartavel, nome_material, quantidadeInicial_material, quantidadeEntrada_material, dataValidade_material, nome_fornecedor, descricao_material, quantidadeActual_material, quantidadeMinima_material, quantidadeMaxima_material from Material_Descartavel inner join Fornecedor on (Material_Descartavel.codFornecedor = Fornecedor.codFornecedor) WHERE dataValidade_material = '" + txtPesquisa.Text + "'", Sqlcon);
            DataTable dados = new DataTable();
            Adpter.Fill(dados);
            matDescartavelDataGridView.DataSource = dados;
        }

        private void frmConsultarMatDescartavel_Load(object sender, EventArgs e)
        {
            // Carregar dados do Material Descartável no DataGridView
            this.CarregarDados();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (cbFormaPesquisa.SelectedItem.Equals("Nome Material Descartável"))
                this.PesquisarNomeMaterialDescartavel();
            else if (cbFormaPesquisa.SelectedItem.Equals("Nome do Fornecedor"))
                this.PesquisarNomeFornecedor();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultarMatDescartavel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.conMatDescartavel = null;
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
