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
    public partial class frmConsultarMarcacaoConsulta : Form
    {
        public frmConsultarMarcacaoConsulta()
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
            marcacaoConsultaDataGridView.DataSource = dados.ListarMarcacaoConsulta();
        }
        // Nome do Doente
        public void PesquisarNomePaciente()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codMarcacao, nome_paciente, nome_TipoConsulta, nome_medico, data_consulta, hora_consulta, diasRepouso_consulta, descricao_consulta  FROM Marcacao_Consulta INNER JOIN Paciente ON (Marcacao_Consulta.codPaciente = Paciente.codPaciente) INNER JOIN Tipo_Consulta ON (Marcacao_Consulta.codTipoConsulta = Tipo_Consulta.codTipoConsulta) INNER JOIN Medico ON (Marcacao_Consulta.codMedico = Medico.codMedico) nome_paciente LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adpter.Fill(dados);
            marcacaoConsultaDataGridView.DataSource = dados;
        }
        // Nome do Tipo de Consulta
        public void PesquisarNomeTipoConsulta()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codMarcacao, nome_paciente, nome_TipoConsulta, nome_medico, data_consulta, hora_consulta, diasRepouso_consulta, descricao_consulta  FROM Marcacao_Consulta INNER JOIN Paciente ON (Marcacao_Consulta.codPaciente = Paciente.codPaciente) INNER JOIN Tipo_Consulta ON (Marcacao_Consulta.codTipoConsulta = Tipo_Consulta.codTipoConsulta) INNER JOIN Medico ON (Marcacao_Consulta.codMedico = Medico.codMedico) nome_TipoConsulta LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adpter.Fill(dados);
            marcacaoConsultaDataGridView.DataSource = dados;
        }
        // Nome do Médico
        public void PesquisarNomeMedico()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codMarcacao, nome_paciente, nome_TipoConsulta, nome_medico, data_consulta, hora_consulta, diasRepouso_consulta, descricao_consulta  FROM Marcacao_Consulta INNER JOIN Paciente ON (Marcacao_Consulta.codPaciente = Paciente.codPaciente) INNER JOIN Tipo_Consulta ON (Marcacao_Consulta.codTipoConsulta = Tipo_Consulta.codTipoConsulta) INNER JOIN Medico ON (Marcacao_Consulta.codMedico = Medico.codMedico) WHERE nome_medico LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adpter.Fill(dados);
            marcacaoConsultaDataGridView.DataSource = dados;
        }
        // Data da Consulta
        public void PesquisarDataConsulta()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codMarcacao, nome_paciente, nome_TipoConsulta, nome_medico, data_consulta, hora_consulta, diasRepouso_consulta, descricao_consulta  FROM Marcacao_Consulta INNER JOIN Paciente ON (Marcacao_Consulta.codPaciente = Paciente.codPaciente) INNER JOIN Tipo_Consulta ON (Marcacao_Consulta.codTipoConsulta = Tipo_Consulta.codTipoConsulta) INNER JOIN Medico ON (Marcacao_Consulta.codMedico = Medico.codMedico) data_consulta = '" + txtPesquisa.Text + "'", Sqlcon);
            Adpter.Fill(dados);
            marcacaoConsultaDataGridView.DataSource = dados;
        }
        // Hora da Consulta
        public void PesquisarHoraConsulta()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codMarcacao, nome_paciente, nome_TipoConsulta, nome_medico, data_consulta, hora_consulta, diasRepouso_consulta, descricao_consulta  FROM Marcacao_Consulta INNER JOIN Paciente ON (Marcacao_Consulta.codPaciente = Paciente.codPaciente) INNER JOIN Tipo_Consulta ON (Marcacao_Consulta.codTipoConsulta = Tipo_Consulta.codTipoConsulta) INNER JOIN Medico ON (Marcacao_Consulta.codMedico = Medico.codMedico) WHERE hora_consulta = '" + txtPesquisa.Text + "'", Sqlcon);
            Adpter.Fill(dados);
            marcacaoConsultaDataGridView.DataSource = dados;
        }

        private void frmConsultarMarcacaoConsulta_Load(object sender, EventArgs e)
        {
            //  Carregar dados da Marcação da Cirugia do DataGridView
            this.CarregarDados();
            cbFormaPesquisa.SelectedItem = "Nome do Paciente";
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (cbFormaPesquisa.SelectedItem.Equals("Nome do Médico"))
                this.PesquisarNomeMedico();
            else if (cbFormaPesquisa.SelectedItem.Equals("Nome do Paciente"))
                this.PesquisarNomePaciente();
            else if (cbFormaPesquisa.SelectedItem.Equals("Nome do Tipo de Consulta"))
                this.PesquisarNomeTipoConsulta();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultarMarcacaoConsulta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.conMarcarConsulta = null;
        }

        private void cbFormaPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.MostrarBotao();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbFormaPesquisa.SelectedItem.Equals("Data de Consulta"))
                this.PesquisarDataConsulta();
            else if (cbFormaPesquisa.SelectedItem.Equals("Hora da Consulta"))
                this.PesquisarHoraConsulta();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtPesquisa.Clear();
            this.CarregarDados();
        }
    }
}
