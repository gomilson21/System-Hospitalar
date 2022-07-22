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
    public partial class frmConsultarAlta_PacienteInternado : Form
    {
        public frmConsultarAlta_PacienteInternado()
        {
            InitializeComponent();
        }
        Dados.Listar dados = new Dados.Listar();
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");

        private void MostarBotao()
        {
            if(cbFormaPesquisa.SelectedItem.Equals("Data da Alta"))
            {
                btnBuscar.Show();
                btnActualizar.Show();
            }
            else if (cbFormaPesquisa.SelectedItem.Equals("Data da Internação"))
            {
                btnBuscar.Show();
                btnActualizar.Show();
            }
            else if (cbFormaPesquisa.SelectedItem.Equals("Data de Regresso"))
            {
                btnBuscar.Show();
                btnActualizar.Show();
            }
            else if (cbFormaPesquisa.SelectedItem.Equals("Hora da Alta"))
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
            altaPacienteDataGridView.DataSource = dados.ListarAltaPacienteInternado();
        }
        // Nome do Paciente
        public void PesquisarNomePaciente()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codAlta, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, data_internacao, hora_internacao, data_alta, hora_alta, data_regresso, dias_repouso, descricao_alta FROM Alta_Paciente_Internado INNER JOIN Paciente_Internado ON (Alta_Paciente_Internado.codPacienteInternado = Paciente_Internado.codPacienteInternado) INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Quarto ON (Quarto.codQuarto = Paciente_Internado.codQuarto) INNER JOIN Tratamento ON (Tratamento.codTratamento = Paciente_Internado.codTratamento) WHERE nome_paciente LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adpter.Fill(dados);
            altaPacienteDataGridView.DataSource = dados;
        }
        // Nome da Quarto
        public void PesquisarNomeQuarto()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codAlta, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, data_internacao, hora_internacao, data_alta, hora_alta, data_regresso, dias_repouso, descricao_alta FROM Alta_Paciente_Internado INNER JOIN Paciente_Internado ON (Alta_Paciente_Internado.codPacienteInternado = Paciente_Internado.codPacienteInternado) INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Quarto ON (Quarto.codQuarto = Paciente_Internado.codQuarto) INNER JOIN Tratamento ON (Tratamento.codTratamento = Paciente_Internado.codTratamento) WHERE nome_quarto LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adpter.Fill(dados);
            altaPacienteDataGridView.DataSource = dados;
        }
        // Nome do Tramento
        public void PesquisarNomeTratamento()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codAlta, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, data_internacao, hora_internacao, data_alta, hora_alta, data_regresso, dias_repouso, descricao_alta FROM Alta_Paciente_Internado INNER JOIN Paciente_Internado ON (Alta_Paciente_Internado.codPacienteInternado = Paciente_Internado.codPacienteInternado) INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Quarto ON (Quarto.codQuarto = Paciente_Internado.codQuarto) INNER JOIN Tratamento ON (Tratamento.codTratamento = Paciente_Internado.codTratamento) WHERE nome_tratamento LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adpter.Fill(dados);
            altaPacienteDataGridView.DataSource = dados;
        }
        // Número da Cama
        public void PesquisarNumeroCama()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codAlta, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, data_internacao, hora_internacao, data_alta, hora_alta, data_regresso, dias_repouso, descricao_alta FROM Alta_Paciente_Internado INNER JOIN Paciente_Internado ON (Alta_Paciente_Internado.codPacienteInternado = Paciente_Internado.codPacienteInternado) INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Quarto ON (Quarto.codQuarto = Paciente_Internado.codQuarto) INNER JOIN Tratamento ON (Tratamento.codTratamento = Paciente_Internado.codTratamento) WHERE numeroCama_PacienteInternado = '" + Convert.ToInt32(txtPesquisa.Text) + "'", Sqlcon);
            Adpter.Fill(dados);
            altaPacienteDataGridView.DataSource = dados;
        }
        // Data da Alta
        public void PesquisarDataAlta()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codAlta, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, data_internacao, hora_internacao, data_alta, hora_alta, data_regresso, dias_repouso, descricao_alta FROM Alta_Paciente_Internado INNER JOIN Paciente_Internado ON (Alta_Paciente_Internado.codPacienteInternado = Paciente_Internado.codPacienteInternado) INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Quarto ON (Quarto.codQuarto = Paciente_Internado.codQuarto) INNER JOIN Tratamento ON (Tratamento.codTratamento = Paciente_Internado.codTratamento) WHERE data_alta = '" + Convert.ToDateTime(txtPesquisa.Text) + "'", Sqlcon);
            Adpter.Fill(dados);
            altaPacienteDataGridView.DataSource = dados;
        }
        // Data da Internacao
        public void PesquisarDataInternacao()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codAlta, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, data_internacao, hora_internacao, data_alta, hora_alta, data_regresso, dias_repouso, descricao_alta FROM Alta_Paciente_Internado INNER JOIN Paciente_Internado ON (Alta_Paciente_Internado.codPacienteInternado = Paciente_Internado.codPacienteInternado) INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Quarto ON (Quarto.codQuarto = Paciente_Internado.codQuarto) INNER JOIN Tratamento ON (Tratamento.codTratamento = Paciente_Internado.codTratamento) WHERE data_internacao = '" + Convert.ToDateTime(txtPesquisa.Text) + "'", Sqlcon);
            Adpter.Fill(dados);
            altaPacienteDataGridView.DataSource = dados;
        }
        // Data de Regresso
        public void PesquisarDataRegresso()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codAlta, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, data_internacao, hora_internacao, data_alta, hora_alta, data_regresso, dias_repouso, descricao_alta FROM Alta_Paciente_Internado INNER JOIN Paciente_Internado ON (Alta_Paciente_Internado.codPacienteInternado = Paciente_Internado.codPacienteInternado) INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Quarto ON (Quarto.codQuarto = Paciente_Internado.codQuarto) INNER JOIN Tratamento ON (Tratamento.codTratamento = Paciente_Internado.codTratamento) WHERE data_regresso = '" + Convert.ToDateTime(txtPesquisa.Text) + "'", Sqlcon);
            Adpter.Fill(dados);
            altaPacienteDataGridView.DataSource = dados;
        }
        // Hora da Alta
        public void PesquisarHoraAlta()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codAlta, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, data_internacao, hora_internacao, data_alta, hora_alta, data_regresso, dias_repouso, descricao_alta FROM Alta_Paciente_Internado INNER JOIN Paciente_Internado ON (Alta_Paciente_Internado.codPacienteInternado = Paciente_Internado.codPacienteInternado) INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Quarto ON (Quarto.codQuarto = Paciente_Internado.codQuarto) INNER JOIN Tratamento ON (Tratamento.codTratamento = Paciente_Internado.codTratamento) WHERE hora_alta = '" + txtPesquisa.Text + "'", Sqlcon);
            Adpter.Fill(dados);
            altaPacienteDataGridView.DataSource = dados;
        }
        // Hora da Internação
        public void PesquisarHoraInternacao()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codAlta, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, data_internacao, hora_internacao, data_alta, hora_alta, data_regresso, dias_repouso, descricao_alta FROM Alta_Paciente_Internado INNER JOIN Paciente_Internado ON (Alta_Paciente_Internado.codPacienteInternado = Paciente_Internado.codPacienteInternado) INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Quarto ON (Quarto.codQuarto = Paciente_Internado.codQuarto) INNER JOIN Tratamento ON (Tratamento.codTratamento = Paciente_Internado.codTratamento) WHERE hora_internacao = '" + txtPesquisa.Text + "'", Sqlcon);
            Adpter.Fill(dados);
            altaPacienteDataGridView.DataSource = dados;
        }

        private void frmConsultarAlta_PacienteInternado_Load(object sender, EventArgs e)
        {
            cbFormaPesquisa.SelectedItem = "Nome do Paciente";
            //  Carregar dados da Alta do Paciente Internado do DataGridView
            this.CarregarDados();
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
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultarAlta_PacienteInternado_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.conAltaPaciente = null;
        }

        private void cbFormaPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.MostarBotao();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbFormaPesquisa.SelectedItem.Equals("Data da Alta"))
                this.PesquisarDataAlta();
            else if (cbFormaPesquisa.SelectedItem.Equals("Data da Internação"))
                this.PesquisarDataInternacao();
            else if (cbFormaPesquisa.SelectedItem.Equals("Data de Regresso"))
                this.PesquisarDataRegresso();
            else if (cbFormaPesquisa.SelectedItem.Equals("Hora da Alta"))
                this.PesquisarHoraAlta();
            else if (cbFormaPesquisa.SelectedItem.Equals("Hora da Intenação"))
                this.PesquisarHoraInternacao();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtPesquisa.Clear();
        }
    }
}
