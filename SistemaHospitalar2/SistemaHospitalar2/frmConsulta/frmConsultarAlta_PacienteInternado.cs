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
        DataTable dados1;
        SqlDataAdapter Adapter;

        private void HabilitarBotao()
        {
            if(cbFormaPesquisa.SelectedItem.Equals("Data da Alta"))
            {
                btnBuscar.Enabled = true;
                btnActualizar.Enabled = true;
            }
            else if (cbFormaPesquisa.SelectedItem.Equals("Data da Internação"))
            {
                btnBuscar.Enabled = true;
                btnActualizar.Enabled = true;
            }
            else if (cbFormaPesquisa.SelectedItem.Equals("Data de Regresso"))
            {
                btnBuscar.Enabled = true;
                btnActualizar.Enabled = true;
            }
            else if (cbFormaPesquisa.SelectedItem.Equals("Hora da Alta"))
            {
                btnBuscar.Enabled = true;
                btnActualizar.Enabled = true;
            }
            else if (cbFormaPesquisa.SelectedItem.Equals("Hora da Internação"))
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
            altaPacienteDataGridView.DataSource = dados.ListarAltaPacienteInternado();
        }
        // Nome do Paciente
        public void PesquisarNomePaciente()
        {
            dados1 = new DataTable();
            Adapter = new SqlDataAdapter("SELECT codAlta, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, nome_medico, data_internacao, hora_internacao, data_alta, hora_alta, data_regresso, dias_repouso, descricao_alta FROM Alta_Paciente_Internado INNER JOIN Paciente_Internado ON (Alta_Paciente_Internado.codPacienteInternado = Paciente_Internado.codPacienteInternado) INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Quarto ON (Quarto.codQuarto = Paciente_Internado.codQuarto) INNER JOIN Tratamento ON (Tratamento.codTratamento = Paciente_Internado.codTratamento) INNER JOIN Medico ON (Medico.codMedico = Paciente_Internado.codMedico) WHERE nome_paciente LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adapter.Fill(dados1);
            altaPacienteDataGridView.DataSource = dados1;
        }
        // Nome da Quarto
        public void PesquisarNomeQuarto()
        {
            dados1 = new DataTable();
            Adapter = new SqlDataAdapter("SELECT codAlta, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, nome_medico, data_internacao, hora_internacao, data_alta, hora_alta, data_regresso, dias_repouso, descricao_alta FROM Alta_Paciente_Internado INNER JOIN Paciente_Internado ON (Alta_Paciente_Internado.codPacienteInternado = Paciente_Internado.codPacienteInternado) INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Quarto ON (Quarto.codQuarto = Paciente_Internado.codQuarto) INNER JOIN Tratamento ON (Tratamento.codTratamento = Paciente_Internado.codTratamento) INNER JOIN Medico ON (Medico.codMedico = Paciente_Internado.codMedico) WHERE nome_quarto LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adapter.Fill(dados1);
            altaPacienteDataGridView.DataSource = dados1;
        }
        // Nome do Tramento
        public void PesquisarNomeTratamento()
        {
            dados1 = new DataTable();
            Adapter = new SqlDataAdapter("SELECT codAlta, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, nome_medico, data_internacao, hora_internacao, data_alta, hora_alta, data_regresso, dias_repouso, descricao_alta FROM Alta_Paciente_Internado INNER JOIN Paciente_Internado ON (Alta_Paciente_Internado.codPacienteInternado = Paciente_Internado.codPacienteInternado) INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Quarto ON (Quarto.codQuarto = Paciente_Internado.codQuarto) INNER JOIN Tratamento ON (Tratamento.codTratamento = Paciente_Internado.codTratamento) INNER JOIN Medico ON (Medico.codMedico = Paciente_Internado.codMedico) WHERE nome_tratamento LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adapter.Fill(dados1);
            altaPacienteDataGridView.DataSource = dados1;
        }
        // Nome do Médico
        public void PesquisarNomeMedico()
        {
            dados1 = new DataTable();
            Adapter = new SqlDataAdapter("SELECT codAlta, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, nome_medico, data_internacao, hora_internacao, data_alta, hora_alta, data_regresso, dias_repouso, descricao_alta FROM Alta_Paciente_Internado INNER JOIN Paciente_Internado ON (Alta_Paciente_Internado.codPacienteInternado = Paciente_Internado.codPacienteInternado) INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Quarto ON (Quarto.codQuarto = Paciente_Internado.codQuarto) INNER JOIN Tratamento ON (Tratamento.codTratamento = Paciente_Internado.codTratamento) INNER JOIN Medico ON (Medico.codMedico = Paciente_Internado.codMedico) WHERE nome_medico LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adapter.Fill(dados1);
            altaPacienteDataGridView.DataSource = dados1;
        }
        // Número da Cama
        public void PesquisarNumeroCama()
        {
            dados1 = new DataTable();
            Adapter = new SqlDataAdapter("SELECT codAlta, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, nome_medico, data_internacao, hora_internacao, data_alta, hora_alta, data_regresso, dias_repouso, descricao_alta FROM Alta_Paciente_Internado INNER JOIN Paciente_Internado ON (Alta_Paciente_Internado.codPacienteInternado = Paciente_Internado.codPacienteInternado) INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Quarto ON (Quarto.codQuarto = Paciente_Internado.codQuarto) INNER JOIN Tratamento ON (Tratamento.codTratamento = Paciente_Internado.codTratamento) INNER JOIN Medico ON (Medico.codMedico = Paciente_Internado.codMedico) WHERE numeroCama_PacienteInternado = '" + Convert.ToInt32(txtPesquisa.Text) + "'", Sqlcon);
            Adapter.Fill(dados1);
            altaPacienteDataGridView.DataSource = dados1;
        }
        // Data da Alta
        public void PesquisarDataAlta()
        {
            dados1 = new DataTable();
            Adapter = new SqlDataAdapter("SELECT codAlta, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, nome_medico, data_internacao, hora_internacao, data_alta, hora_alta, data_regresso, dias_repouso, descricao_alta FROM Alta_Paciente_Internado INNER JOIN Paciente_Internado ON (Alta_Paciente_Internado.codPacienteInternado = Paciente_Internado.codPacienteInternado) INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Quarto ON (Quarto.codQuarto = Paciente_Internado.codQuarto) INNER JOIN Tratamento ON (Tratamento.codTratamento = Paciente_Internado.codTratamento) INNER JOIN Medico ON (Medico.codMedico = Paciente_Internado.codMedico) WHERE data_alta = '" + Convert.ToDateTime(txtPesquisa.Text) + "'", Sqlcon);
            Adapter.Fill(dados1);
            altaPacienteDataGridView.DataSource = dados1;
        }
        // Data da Internacao
        public void PesquisarDataInternacao()
        {
            dados1 = new DataTable();
            Adapter = new SqlDataAdapter("SELECT codAlta, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, nome_medico, data_internacao, hora_internacao, data_alta, hora_alta, data_regresso, dias_repouso, descricao_alta FROM Alta_Paciente_Internado INNER JOIN Paciente_Internado ON (Alta_Paciente_Internado.codPacienteInternado = Paciente_Internado.codPacienteInternado) INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Quarto ON (Quarto.codQuarto = Paciente_Internado.codQuarto) INNER JOIN Tratamento ON (Tratamento.codTratamento = Paciente_Internado.codTratamento) INNER JOIN Medico ON (Medico.codMedico = Paciente_Internado.codMedico) WHERE data_internacao = '" + Convert.ToDateTime(txtPesquisa.Text) + "'", Sqlcon);
            Adapter.Fill(dados1);
            altaPacienteDataGridView.DataSource = dados1;
        }
        // Data de Regresso
        public void PesquisarDataRegresso()
        {
            dados1 = new DataTable();
            Adapter = new SqlDataAdapter("SELECT codAlta, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, nome_medico, data_internacao, hora_internacao, data_alta, hora_alta, data_regresso, dias_repouso, descricao_alta FROM Alta_Paciente_Internado INNER JOIN Paciente_Internado ON (Alta_Paciente_Internado.codPacienteInternado = Paciente_Internado.codPacienteInternado) INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Quarto ON (Quarto.codQuarto = Paciente_Internado.codQuarto) INNER JOIN Tratamento ON (Tratamento.codTratamento = Paciente_Internado.codTratamento) INNER JOIN Medico ON (Medico.codMedico = Paciente_Internado.codMedico) WHERE data_regresso = '" + Convert.ToDateTime(txtPesquisa.Text) + "'", Sqlcon);
            Adapter.Fill(dados1);
            altaPacienteDataGridView.DataSource = dados1;
        }
        // Hora da Alta
        public void PesquisarHoraAlta()
        {
            dados1 = new DataTable();
            Adapter = new SqlDataAdapter("SELECT codAlta, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, nome_medico, data_internacao, hora_internacao, data_alta, hora_alta, data_regresso, dias_repouso, descricao_alta FROM Alta_Paciente_Internado INNER JOIN Paciente_Internado ON (Alta_Paciente_Internado.codPacienteInternado = Paciente_Internado.codPacienteInternado) INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Quarto ON (Quarto.codQuarto = Paciente_Internado.codQuarto) INNER JOIN Tratamento ON (Tratamento.codTratamento = Paciente_Internado.codTratamento) INNER JOIN Medico ON (Medico.codMedico = Paciente_Internado.codMedico) WHERE hora_alta = '" + txtPesquisa.Text + "'", Sqlcon);
            Adapter.Fill(dados1);
            altaPacienteDataGridView.DataSource = dados1;
        }
        // Hora da Internação
        public void PesquisarHoraInternacao()
        {
            dados1 = new DataTable();
            Adapter = new SqlDataAdapter("SELECT codAlta, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, nome_medico, data_internacao, hora_internacao, data_alta, hora_alta, data_regresso, dias_repouso, descricao_alta FROM Alta_Paciente_Internado INNER JOIN Paciente_Internado ON (Alta_Paciente_Internado.codPacienteInternado = Paciente_Internado.codPacienteInternado) INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Quarto ON (Quarto.codQuarto = Paciente_Internado.codQuarto) INNER JOIN Tratamento ON (Tratamento.codTratamento = Paciente_Internado.codTratamento) INNER JOIN Medico ON (Medico.codMedico = Paciente_Internado.codMedico) WHERE WHERE hora_internacao = '" + txtPesquisa.Text + "'", Sqlcon);
            Adapter.Fill(dados1);
            altaPacienteDataGridView.DataSource = dados1;
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
                this.PesquisarNomeMedico();
            else if (cbFormaPesquisa.SelectedItem.Equals("Nome do Médico"))
                this.PesquisarNomeTratamento();
        }

        private void cbFormaPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.HabilitarBotao();
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
            this.CarregarDados();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultarAlta_PacienteInternado_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.conAltaPaciente = null;
        }

       
    }
}
