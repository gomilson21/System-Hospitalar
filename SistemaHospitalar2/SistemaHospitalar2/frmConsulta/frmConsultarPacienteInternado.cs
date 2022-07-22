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
    public partial class frmConsultarPacienteInternado : Form
    {
        public frmConsultarPacienteInternado()
        {
            InitializeComponent();
        }
        Dados.Listar dados = new Dados.Listar();
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");

        private void MostrarBotao()
        {
            if (cbFormaPesquisa.SelectedItem.Equals("Data da Internação"))
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
            pacienteInternadoDataGridView.DataSource = dados.ListarPacienteInternado();
        }
        // Nome do Paciete
        public void PesquisarNomePaciente()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codPacienteInternado, nome_paciente, nome_quarto, numeroCama_PacienteInternado, estadoCama_PacienteInternado, nome_tratamento, nome_medico,  EstadoClinico_PacienteInternado, data_internacao, hora_internacao, descricao_PacienteInternado FROM Paciente_Internado INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Quarto ON (Paciente_Internado.codQuarto = Quarto.codQuarto) INNER JOIN Tratamento ON (Paciente_Internado.codTratamento = Tratamento.codTratamento) INNER JOIN Medico ON (Paciente_Internado.codMedico = Medico.codMedico) WHERE nome_paciente LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adpter.Fill(dados);
            pacienteInternadoDataGridView.DataSource = dados;
        }
        // Nome do Quarto
        public void PesquisarNomeQuarto()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codPacienteInternado, nome_paciente, nome_quarto, numeroCama_PacienteInternado, estadoCama_PacienteInternado, nome_tratamento, nome_medico,  EstadoClinico_PacienteInternado, data_internacao, hora_internacao, descricao_PacienteInternado FROM Paciente_Internado INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Quarto ON (Paciente_Internado.codQuarto = Quarto.codQuarto) INNER JOIN Tratamento ON (Paciente_Internado.codTratamento = Tratamento.codTratamento) INNER JOIN Medico ON (Paciente_Internado.codMedico = Medico.codMedico) WHERE nome_quarto LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adpter.Fill(dados);
            pacienteInternadoDataGridView.DataSource = dados;
        }
        // Nome do Tramento
        public void PesquisarNomeTratamento()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codPacienteInternado, nome_paciente, nome_quarto, numeroCama_PacienteInternado, estadoCama_PacienteInternado, nome_tratamento, nome_medico,  EstadoClinico_PacienteInternado, data_internacao, hora_internacao, descricao_PacienteInternado FROM Paciente_Internado INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Quarto ON (Paciente_Internado.codQuarto = Quarto.codQuarto) INNER JOIN Tratamento ON (Paciente_Internado.codTratamento = Tratamento.codTratamento) INNER JOIN Medico ON (Paciente_Internado.codMedico = Medico.codMedico) WHERE nome_tratamento LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adpter.Fill(dados);
            pacienteInternadoDataGridView.DataSource = dados;
        }
        // Nome do Tramento
        public void PesquisarNomeMedico()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codPacienteInternado, nome_paciente, nome_quarto, numeroCama_PacienteInternado, estadoCama_PacienteInternado, nome_tratamento, nome_medico,  EstadoClinico_PacienteInternado, data_internacao, hora_internacao, descricao_PacienteInternado FROM Paciente_Internado INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Quarto ON (Paciente_Internado.codQuarto = Quarto.codQuarto) INNER JOIN Tratamento ON (Paciente_Internado.codTratamento = Tratamento.codTratamento) INNER JOIN Medico ON (Paciente_Internado.codMedico = Medico.codMedico) WHERE nome_medico LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adpter.Fill(dados);
            pacienteInternadoDataGridView.DataSource = dados;
        }
        // Número da Cama 
        public void PesquisarNumeroCama()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codPacienteInternado, nome_paciente, nome_quarto, numeroCama_PacienteInternado, estadoCama_PacienteInternado, nome_tratamento, nome_medico,  EstadoClinico_PacienteInternado, data_internacao, hora_internacao, descricao_PacienteInternado FROM Paciente_Internado INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Quarto ON (Paciente_Internado.codQuarto = Quarto.codQuarto) INNER JOIN Tratamento ON (Paciente_Internado.codTratamento = Tratamento.codTratamento) INNER JOIN Medico ON (Paciente_Internado.codMedico = Medico.codMedico) WHERE numeroCama_PacienteInternado = '" + Convert.ToInt32(txtPesquisa.Text) + "'", Sqlcon);
            Adpter.Fill(dados);
            pacienteInternadoDataGridView.DataSource = dados;
        }
        // Data da Internação
        public void PesquisarDataInternacao()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codPacienteInternado, nome_PacienteInternado, nome_quarto, numeroCama_PacienteInternado, estadoCama_PacienteInternado, nome_tratamento, EstadoClinico_PacienteInternado, data_internacao, hora_internacao, descricao_PacienteInternado FROM Paciente_Internado INNER JOIN Quarto ON (Paciente_Internado.codQuarto = Quarto.codQuarto) INNER JOIN Tratamento ON (Paciente_Internado.codTratamento = Tratamento.codTratamento)SELECT codPacienteInternado, nome_paciente, nome_quarto, numeroCama_PacienteInternado, estadoCama_PacienteInternado, nome_tratamento, nome_medico,  EstadoClinico_PacienteInternado, data_internacao, hora_internacao, descricao_PacienteInternado FROM Paciente_Internado INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Quarto ON (Paciente_Internado.codQuarto = Quarto.codQuarto) INNER JOIN Tratamento ON (Paciente_Internado.codTratamento = Tratamento.codTratamento) INNER JOIN Medico ON (Paciente_Internado.codMedico = Medico.codMedico) WHERE data_internacao = '" + Convert.ToDateTime(txtPesquisa.Text) + "'", Sqlcon);
            Adpter.Fill(dados);
            pacienteInternadoDataGridView.DataSource = dados;
        }
        // Hora da Internação
        public void PesquisarHoraInternacao()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codPacienteInternado, nome_paciente, nome_quarto, numeroCama_PacienteInternado, estadoCama_PacienteInternado, nome_tratamento, nome_medico,  EstadoClinico_PacienteInternado, data_internacao, hora_internacao, descricao_PacienteInternado FROM Paciente_Internado INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Quarto ON (Paciente_Internado.codQuarto = Quarto.codQuarto) INNER JOIN Tratamento ON (Paciente_Internado.codTratamento = Tratamento.codTratamento) INNER JOIN Medico ON (Paciente_Internado.codMedico = Medico.codMedico) WHERE hora_internacao = '" + txtPesquisa.Text + "'", Sqlcon);
            Adpter.Fill(dados);
            pacienteInternadoDataGridView.DataSource = dados;
        }

        private void frmConsultarPacienteInternado_Load(object sender, EventArgs e)
        {
            //  Carregar dados da Marcação da Cirugia do DataGridView
            this.CarregarDados();
            cbFormaPesquisa.SelectedItem = "Nome do Paciente";
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
            else if (cbFormaPesquisa.SelectedItem.Equals("Nome do Médico"))
                this.PesquisarNomeTratamento();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultarPacienteInternado_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.conPacienteInternado = null;
        }

        private void cbFormaPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.MostrarBotao();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbFormaPesquisa.SelectedItem.Equals("Data da Internação"))
                this.PesquisarDataInternacao();
            else if (cbFormaPesquisa.SelectedItem.Equals("Hora da Internação"))
                this.PesquisarHoraInternacao();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtPesquisa.Clear();
            this.CarregarDados();
        }
    }
}
