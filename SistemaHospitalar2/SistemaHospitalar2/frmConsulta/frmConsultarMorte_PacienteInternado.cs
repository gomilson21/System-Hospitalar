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
    public partial class frmConsultarMorte_PacienteInternado : Form
    {
        public frmConsultarMorte_PacienteInternado()
        {
            InitializeComponent();
        }
        Dados.Listar dados = new Dados.Listar();
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");

        private void MostarBotao()
        {
            if (cbFormaPesquisa.SelectedItem.Equals("Data da Morte"))
            {
                btnBuscar.Show();
                btnActualizar.Show();
            }
            else if (cbFormaPesquisa.SelectedItem.Equals("Data da Internação"))
            {
                btnBuscar.Show();
                btnActualizar.Show();
            }
            else if (cbFormaPesquisa.SelectedItem.Equals("Hora da Morte"))
            {
                btnBuscar.Show();
                btnActualizar.Show();
            }
            else if (cbFormaPesquisa.SelectedItem.Equals("Hora da Internação"))
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
            mortePacienteDataGridView.DataSource = dados.ListarMortePaciente();
        }
        // Nome do Paciente
        public void PesquisarNomePaciente()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codMorte, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, data_internacao, hora_internacao, data_morte, hora_morte, causa_morte, descricao_morte FROM Morte_Paciente INNER JOIN Paciente On (Morte_Paciente.codPaciente = Paciente.codPaciente) INNER JOIN Paciente_Internado ON (Paciente.codPaciente = Paciente_Internado.codPaciente) INNER JOIN Quarto ON (Quarto.codQuarto = Paciente_Internado.codQuarto) INNER JOIN Tratamento ON (Tratamento.codTratamento = Paciente_Internado.codTratamento) WHERE nome_paciente LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adpter.Fill(dados);
            mortePacienteDataGridView.DataSource = dados;
        }
        // Nome da Quarto
        public void PesquisarNomeQuarto()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codMorte, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, data_internacao, hora_internacao, data_morte, hora_morte, causa_morte, descricao_morte FROM Morte_Paciente INNER JOIN Paciente On (Morte_Paciente.codPaciente = Paciente.codPaciente) INNER JOIN Paciente_Internado ON (Paciente.codPaciente = Paciente_Internado.codPaciente) INNER JOIN Quarto ON (Quarto.codQuarto = Paciente_Internado.codQuarto) INNER JOIN Tratamento ON (Tratamento.codTratamento = Paciente_Internado.codTratamento) WHERE nome_quarto LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adpter.Fill(dados);
            mortePacienteDataGridView.DataSource = dados;
        }
        // Nome do Tramento
        public void PesquisarNomeTratamento()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codMorte, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, data_internacao, hora_internacao, data_morte, hora_morte, causa_morte, descricao_morte FROM Morte_Paciente INNER JOIN Paciente On (Morte_Paciente.codPaciente = Paciente.codPaciente) INNER JOIN Paciente_Internado ON (Paciente.codPaciente = Paciente_Internado.codPaciente) INNER JOIN Quarto ON (Quarto.codQuarto = Paciente_Internado.codQuarto) INNER JOIN Tratamento ON (Tratamento.codTratamento = Paciente_Internado.codTratamento) WHERE nome_tratamento LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adpter.Fill(dados);
            mortePacienteDataGridView.DataSource = dados;
        }
        // Causa da Morte
        public void PesquisarCausaMorte()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codMorte, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, data_internacao, hora_internacao, data_morte, hora_morte, causa_morte, descricao_morte FROM Morte_Paciente INNER JOIN Paciente On (Morte_Paciente.codPaciente = Paciente.codPaciente) INNER JOIN Paciente_Internado ON (Paciente.codPaciente = Paciente_Internado.codPaciente) INNER JOIN Quarto ON (Quarto.codQuarto = Paciente_Internado.codQuarto) INNER JOIN Tratamento ON (Tratamento.codTratamento = Paciente_Internado.codTratamento) WHERE causa_morte LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adpter.Fill(dados);
            mortePacienteDataGridView.DataSource = dados;
        }
        // Número da Cama
        public void PesquisarNumeroCama()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codMorte, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, data_internacao, hora_internacao, data_morte, hora_morte, causa_morte, descricao_morte FROM Morte_Paciente INNER JOIN Paciente On (Morte_Paciente.codPaciente = Paciente.codPaciente) INNER JOIN Paciente_Internado ON (Paciente.codPaciente = Paciente_Internado.codPaciente) INNER JOIN Quarto ON (Quarto.codQuarto = Paciente_Internado.codQuarto) INNER JOIN Tratamento ON (Tratamento.codTratamento = Paciente_Internado.codTratamento) WHERE numeroCama_PacienteInternado = '" + Convert.ToInt32(txtPesquisa.Text) + "'", Sqlcon);
            Adpter.Fill(dados);
            mortePacienteDataGridView.DataSource = dados;
        }
        // Data da Morte
        public void PesquisarDataMorte()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codMorte, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, data_internacao, hora_internacao, data_morte, hora_morte, causa_morte, descricao_morte FROM Morte_Paciente INNER JOIN Paciente On (Morte_Paciente.codPaciente = Paciente.codPaciente) INNER JOIN Paciente_Internado ON (Paciente.codPaciente = Paciente_Internado.codPaciente) INNER JOIN Quarto ON (Quarto.codQuarto = Paciente_Internado.codQuarto) INNER JOIN Tratamento ON (Tratamento.codTratamento = Paciente_Internado.codTratamento) WHERE data_morte = '" + Convert.ToDateTime(txtPesquisa.Text) + "'", Sqlcon);
            Adpter.Fill(dados);
            mortePacienteDataGridView.DataSource = dados;
        }
        // Data da Internação
        public void PesquisarDataInternacao()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codMorte, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, data_internacao, hora_internacao, data_morte, hora_morte, causa_morte, descricao_morte FROM Morte_Paciente INNER JOIN Paciente On (Morte_Paciente.codPaciente = Paciente.codPaciente) INNER JOIN Paciente_Internado ON (Paciente.codPaciente = Paciente_Internado.codPaciente) INNER JOIN Quarto ON (Quarto.codQuarto = Paciente_Internado.codQuarto) INNER JOIN Tratamento ON (Tratamento.codTratamento = Paciente_Internado.codTratamento) WHERE data_internacao = '" + Convert.ToDateTime(txtPesquisa.Text) + "'", Sqlcon);
            Adpter.Fill(dados);
            mortePacienteDataGridView.DataSource = dados;
        }
        // Hora da Morte
        public void PesquisarHoraMorte()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codMorte, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, data_internacao, hora_internacao, data_morte, hora_morte, causa_morte, descricao_morte FROM Morte_Paciente INNER JOIN Paciente On (Morte_Paciente.codPaciente = Paciente.codPaciente) INNER JOIN Paciente_Internado ON (Paciente.codPaciente = Paciente_Internado.codPaciente) INNER JOIN Quarto ON (Quarto.codQuarto = Paciente_Internado.codQuarto) INNER JOIN Tratamento ON (Tratamento.codTratamento = Paciente_Internado.codTratamento) WHERE hora_morte = '" + txtPesquisa.Text + "'", Sqlcon);
            Adpter.Fill(dados);
            mortePacienteDataGridView.DataSource = dados;
        }
        // Hora da Morte
        public void PesquisarHoraIntenacao()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codMorte, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, data_internacao, hora_internacao, data_morte, hora_morte, causa_morte, descricao_morte FROM Morte_Paciente INNER JOIN Paciente On (Morte_Paciente.codPaciente = Paciente.codPaciente) INNER JOIN Paciente_Internado ON (Paciente.codPaciente = Paciente_Internado.codPaciente) INNER JOIN Quarto ON (Quarto.codQuarto = Paciente_Internado.codQuarto) INNER JOIN Tratamento ON (Tratamento.codTratamento = Paciente_Internado.codTratamento) WHERE hora_internacao = '" + txtPesquisa.Text + "'", Sqlcon);
            Adpter.Fill(dados);
            mortePacienteDataGridView.DataSource = dados;
        }

        private void frmConsultarMorte_PacienteInternado_Load(object sender, EventArgs e)
        {
            cbFormaPesquisa.SelectedItem = "Nome do Paciente";
            //  Carregar dados do Óbito do Paciente Internado do DataGridView
            this.CarregarDados();
            this.MostarBotao();          
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (cbFormaPesquisa.SelectedItem.Equals("Nome do Paciente"))
                this.PesquisarNomePaciente();
            else if (cbFormaPesquisa.SelectedItem.Equals("Nome do Quarto"))
                this.PesquisarNomeQuarto();
            else if (cbFormaPesquisa.SelectedItem.Equals("Número da Cama"))
                this.PesquisarNumeroCama();
            else if (cbFormaPesquisa.SelectedItem.Equals("Nome do Tratamento"))
                this.PesquisarNomeTratamento();
            else if (cbFormaPesquisa.SelectedItem.Equals("Causa da Morte"))
                this.PesquisarCausaMorte();
        }

        private void cbFormaPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.MostarBotao();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbFormaPesquisa.SelectedItem.Equals("Data da Morte"))
                this.PesquisarDataMorte();
            else if (cbFormaPesquisa.SelectedItem.Equals("Data da Internação"))
                this.PesquisarDataInternacao();
            else if (cbFormaPesquisa.SelectedItem.Equals("Hora da Morte"))
                this.PesquisarHoraMorte();
            else if (cbFormaPesquisa.SelectedItem.Equals("Hora da Intenação"))
                this.PesquisarHoraMorte();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtPesquisa.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultarMorte_PacienteInternado_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.conMortePaciente = null;
        }
    }
}
