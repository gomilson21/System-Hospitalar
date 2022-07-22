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
    public partial class frmConsultarMarcacaoCirugia : Form
    {
        public frmConsultarMarcacaoCirugia()
        {
            InitializeComponent();
        }
        Dados.Listar dados = new Dados.Listar();
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");

        private void MostrarBotao()
        {
            if (cbFormaPesquisa.SelectedItem.Equals("Data de Cirugia"))
            {
                btnBuscar.Show();
                btnActualizar.Show();
            }
            else if (cbFormaPesquisa.SelectedItem.Equals("Hora da Cirugia"))
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
            marcacaoCirugiaDataGridView.DataSource = dados.ListarMarcacaoCirugia();
        }
        // Nome do Paciente
        public void PesquisarNomePaciente()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codCirugia, nome_paciente, nome_TipoCirugia, nome_medico, data_cirugia, hora_cirugia, descricao_cirugia FROM Marcacao_Cirugia INNER JOIN Paciente_Internado ON (Marcacao_Cirugia.codPacienteInternado = Paciente_Internado.codPacienteInternado) INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Tipo_Cirugia ON (Marcacao_Cirugia.codTipoCirugia = Tipo_Cirugia.codTipoCirugia) INNER JOIN Medico ON (Marcacao_Cirugia.codMedico = Medico.codMedico) WHERE nome_paciente LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adpter.Fill(dados);
            marcacaoCirugiaDataGridView.DataSource = dados;
        }
        // Nome do Tipo de Cirugia
        public void PesquisarNomeTipoCirugia()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codCirugia, nome_paciente, nome_TipoCirugia, nome_medico, data_cirugia, hora_cirugia, descricao_cirugia FROM Marcacao_Cirugia INNER JOIN Paciente_Internado ON (Marcacao_Cirugia.codPacienteInternado = Paciente_Internado.codPacienteInternado) INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Tipo_Cirugia ON (Marcacao_Cirugia.codTipoCirugia = Tipo_Cirugia.codTipoCirugia) INNER JOIN Medico ON (Marcacao_Cirugia.codMedico = Medico.codMedico) WHERE nome_TipoCirugia LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adpter.Fill(dados);
            marcacaoCirugiaDataGridView.DataSource = dados;
        }
        // Nome do Médico
        public void PesquisarNomeMedico()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codCirugia, nome_paciente, nome_TipoCirugia, nome_medico, data_cirugia, hora_cirugia, descricao_cirugia FROM Marcacao_Cirugia INNER JOIN Paciente_Internado ON (Marcacao_Cirugia.codPacienteInternado = Paciente_Internado.codPacienteInternado) INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Tipo_Cirugia ON (Marcacao_Cirugia.codTipoCirugia = Tipo_Cirugia.codTipoCirugia) INNER JOIN Medico ON (Marcacao_Cirugia.codMedico = Medico.codMedico) WHERE nome_medico LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adpter.Fill(dados);
            marcacaoCirugiaDataGridView.DataSource = dados;
        }
        // Data da Cirugia
        public void PesquisarDataCirugia()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codCirugia, nome_paciente, nome_TipoCirugia, nome_medico, data_cirugia, hora_cirugia, descricao_cirugia FROM Marcacao_Cirugia INNER JOIN Paciente_Internado ON (Marcacao_Cirugia.codPacienteInternado = Paciente_Internado.codPacienteInternado) INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Tipo_Cirugia ON (Marcacao_Cirugia.codTipoCirugia = Tipo_Cirugia.codTipoCirugia) INNER JOIN Medico ON (Marcacao_Cirugia.codMedico = Medico.codMedico) WHERE data_cirugia = '" + txtPesquisa.Text + "'", Sqlcon);
            Adpter.Fill(dados);
            marcacaoCirugiaDataGridView.DataSource = dados;
        }
        // Hora da Cirugia
        public void PesquisarHoraCirugia()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codCirugia, nome_paciente, nome_TipoCirugia, nome_medico, data_cirugia, hora_cirugia, descricao_cirugia FROM Marcacao_Cirugia INNER JOIN Paciente_Internado ON (Marcacao_Cirugia.codPacienteInternado = Paciente_Internado.codPacienteInternado) INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Tipo_Cirugia ON (Marcacao_Cirugia.codTipoCirugia = Tipo_Cirugia.codTipoCirugia) INNER JOIN Medico ON (Marcacao_Cirugia.codMedico = Medico.codMedico) WHERE hora_cirugia = '" + txtPesquisa.Text + "'", Sqlcon);
            Adpter.Fill(dados);
            marcacaoCirugiaDataGridView.DataSource = dados;
        }

        private void frmConsultarMarcacaoCirugia_Load(object sender, EventArgs e)
        {
            cbFormaPesquisa.SelectedItem = "Nome do Paciente";
            //  Carregar dados da Marcação da Cirugia do DataGridView
            this.CarregarDados();
        }
        
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
           if(cbFormaPesquisa.SelectedItem.Equals("Nome do Médico"))
                this.PesquisarNomeMedico();
            else if(cbFormaPesquisa.SelectedItem.Equals("Nome do Paciente"))
                this.PesquisarNomePaciente();
            else if(cbFormaPesquisa.SelectedItem.Equals("Nome do Tipo de Cirugia"))
                this.PesquisarNomeTipoCirugia();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultarMarcacaoCirugia_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.conMarcarCirugia = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbFormaPesquisa.SelectedItem.Equals("Data de Cirugia"))
                this.PesquisarDataCirugia();
            else if (cbFormaPesquisa.SelectedItem.Equals("Hora da Cirugia"))
                this.PesquisarHoraCirugia();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtPesquisa.Clear();
            this.CarregarDados();
        }

        private void cbFormaPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbFormaPesquisa.SelectedItem = "Nome do Paciente";
            this.MostrarBotao();
        }
    }
}
