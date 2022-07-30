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
    public partial class frmConsultarFornecedor : Form
    {
        public frmConsultarFornecedor()
        {
            InitializeComponent();
        }

        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");
        DataTable dados;
        SqlDataAdapter Adapter;

        private void MostrarBotao()
        {
            if (cbFormaPesquisa.SelectedItem.Equals("Data do Início do Contrato"))
            {
                btnBuscar.Enabled = true;
                btnActualizar.Enabled = true;
            }
            else if (cbFormaPesquisa.SelectedItem.Equals("Data do Fim do Contrato"))
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
        // Nome do Fornecedor
        public void PesquisarNomeFornecedor()
        {
            dados = new DataTable();
            Adapter = new SqlDataAdapter("SELECT * FROM Fornecedor WHERE nome_fornecedor LIKE '%" + txtPesquisa.Text +"%'", Sqlcon);
            Adapter.Fill(dados);
            fornecedorDataGridView.DataSource = dados;
        }
        // Nome da Email
        public void PesquisarEmail()
        {
            dados = new DataTable();
            Adapter = new SqlDataAdapter("SELECT * FROM Fornecedor WHERE email_fornedor LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adapter.Fill(dados);
            fornecedorDataGridView.DataSource = dados;
        }
        // Nacionalidade do Fornecedor
        public void PesquisarNacionalidade()
        {
            dados = new DataTable();
            Adapter = new SqlDataAdapter("SELECT * FROM Fornecedor nacionalidade_fornecedor LIKE  '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adapter.Fill(dados);
            fornecedorDataGridView.DataSource = dados;
        }
        // Endereço do Forncedor
        public void PesquisarEndereco()
        {
            dados = new DataTable();
            Adapter = new SqlDataAdapter("SELECT * FROM Fornecedor endereco_fornecedor LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adapter.Fill(dados);
            fornecedorDataGridView.DataSource = dados;
        }
        // Data do Início do Contratato do Fornecedor
        public void PesquisarDataInicioContrato()
        {
            dados = new DataTable();
            Adapter = new SqlDataAdapter("SELECT * FROM Fornecedor WHERE inicio_contrato = '" + txtPesquisa.Text + "'", Sqlcon);
            Adapter.Fill(dados);
            fornecedorDataGridView.DataSource = dados;
        }
        // Data do Fim do Contratato do Fornecedor
        public void PesquisarDataFimContrato()
        {
            dados = new DataTable();
            Adapter = new SqlDataAdapter("SELECT * FROM Fornecedor WHERE fim_contrato = '" + txtPesquisa.Text + "'", Sqlcon);
            Adapter.Fill(dados);
            fornecedorDataGridView.DataSource = dados;
        }

        private void frmConsultarFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_HospitalDataSet.Fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.db_HospitalDataSet.Fornecedor);
            cbFormaPesquisa.SelectedItem = "Nome do Fornecedor";
            txtPesquisa.Focus();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {   
            if (cbFormaPesquisa.SelectedItem.Equals("Nome do Fornecedor"))
                this.PesquisarNomeFornecedor();
            else if (cbFormaPesquisa.SelectedItem.Equals("Email do Fornecedor"))
                this.PesquisarEmail();
            else if (cbFormaPesquisa.SelectedItem.Equals("Endereco do Fornecedor"))
                this.PesquisarEndereco();
            else if (cbFormaPesquisa.SelectedItem.Equals("Nacionalidade do Fornecedor"))
                this.PesquisarNacionalidade();
        }

        private void cbFormaPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.MostrarBotao();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbFormaPesquisa.SelectedItem.Equals("Data do Início do Contrato"))
                this.PesquisarDataInicioContrato();
            else if (cbFormaPesquisa.SelectedItem.Equals("Data do Fim do Contrato"))
                this.PesquisarDataFimContrato();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtPesquisa.Clear();
            this.fornecedorTableAdapter.Fill(this.db_HospitalDataSet.Fornecedor);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultarFornecedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.conFornecedor = null;
        }
    }
}
