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
    public partial class frmConsultarPaciente : Form
    {
        public frmConsultarPaciente()
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
            else
            {
                btnBuscar.Hide();
                btnActualizar.Hide();
            }
        }

        public void CarregarDados()
        {
            pacienteDataGridView.DataSource = dados.ListarPaciente();
        }
        // Nome do Paciete
        public void PesquisarNomePaciente()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT * FROM Paciente WHERE nome_paciente LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adpter.Fill(dados);
            pacienteDataGridView.DataSource = dados;
        }
        // Endereço do Paciente
        public void PesquisarEnderecoPaciente()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT * FROM Paciente WHERE endereco_paciente LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adpter.Fill(dados);
            pacienteDataGridView.DataSource = dados;
        }
        // Sexo do Paciente
        public void PesquisarSexoPaciente()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT * FROM Paciente WHERE sexo_paciente = '" + txtPesquisa.Text + "'", Sqlcon);
            Adpter.Fill(dados);
            pacienteDataGridView.DataSource = dados;
        }
        // Data de Nascimento do Paciente
        public void PesquisarDataNascimento()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT * FROM Paciente WHERE dataNascimento_paciente = '" + Convert.ToDateTime(txtPesquisa.Text) + "'", Sqlcon);
            Adpter.Fill(dados);
            pacienteDataGridView.DataSource = dados;
        }

        private void frmConsultarPaciente_Load(object sender, EventArgs e)
        {
            // Carregar dados do Paciente no dataGridView
            this.CarregarDados();
            cbFormaPesquisa.SelectedItem = "Nome do Paciente";
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (cbFormaPesquisa.SelectedItem.Equals("Nome do Paciente"))
                this.PesquisarNomePaciente();
            else if (cbFormaPesquisa.SelectedItem.Equals("Endereco do Paciente"))
                this.PesquisarEnderecoPaciente();
            else if (cbFormaPesquisa.SelectedItem.Equals("Sexo do Paciente"))
                this.PesquisarSexoPaciente();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbFormaPesquisa.SelectedItem.Equals("Data de Nascimento"))
                this.PesquisarDataNascimento();
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

        private void cbFormaPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.MostrarBotao();
        }

        private void frmConsultarPaciente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.conPaciente = null;
        }
    }
}
