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

namespace SistemaHospitalar2
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }
        //  Botão Dropdown 1
        private bool mostrar;
        
        public void Mostrar()
        {
            mostrar = false;
            btnConsulta.Show();
            btnCirugia.Show();
            // Location
            if (mostrar2)
            {
                btnTriagem.Location = new Point(4, 252);
                btnPrognostico.Location = new Point(4, 313);
                btnSolExame.Location = new Point(4, 374);
                btnReceita.Location = new Point(4, 440);
            }
            else
            {
                // Mudando o Location dos Botões Ocultos
                btnPaciente.Location = new Point(22, 313);
                btnInternado.Location = new Point(22, 374);
                btnAlta.Location = new Point(22, 435);
                btnObito.Location = new Point(22, 496);
                //  Location Normal
                btnTriagem.Location = new Point(4, 252);
                btnPrognostico.Location = new Point(4, 557);
                btnSolExame.Location = new Point(4, 618);
                btnReceita.Location = new Point(4, 684);
            }
        }
        
        public void Ocultar()
        {
            mostrar = true;
            btnConsulta.Hide();
            btnCirugia.Hide();
            if (mostrar2)
            {
                //  Location Normal
                btnTriagem.Location = new Point(4, 130);
                btnPrognostico.Location = new Point(4, 191);
                btnSolExame.Location = new Point(4, 252);
                btnReceita.Location = new Point(4, 318);
            }
            else
            {
                //  Location dos Botões Ocultos
                btnPaciente.Location = new Point(22, 191);
                btnInternado.Location = new Point(22, 252);
                btnAlta.Location = new Point(22, 313);
                btnObito.Location = new Point(22, 374);
                //  Location
                btnTriagem.Location = new Point(4, 130);
                btnPrognostico.Location = new Point(4, 435);
                btnSolExame.Location = new Point(4, 496);
                btnReceita.Location = new Point(4, 562);
            }
        }
        //  Botão Dropdown 2
        private bool mostrar2;

        public void Mostrar2()
        {
            mostrar2 = false;
            btnPaciente.Show();
            btnInternado.Show();
            btnAlta.Show();
            btnObito.Show();
            // Location
            if(mostrar)
            {
                //  Location dos Botões que se tornaram visíveis
                btnPaciente.Location = new Point(22, 191);
                btnInternado.Location = new Point(22, 252);
                btnAlta.Location = new Point(22, 313);
                btnObito.Location = new Point(22, 374);
                //  Location Normal
                btnTriagem.Location = new Point(4, 130);
                btnPrognostico.Location = new Point(4, 435);
                btnSolExame.Location = new Point(4, 496);
                btnReceita.Location = new Point(4, 562);
            }
            else
            {
                //  Location dos Botões que se tornaram visíveis
                btnPaciente.Location = new Point(22, 313);
                btnInternado.Location = new Point(22, 374);
                btnAlta.Location = new Point(22, 435);
                btnObito.Location = new Point(22, 496);
                //  Location Normal
                btnTriagem.Location = new Point(4, 252);
                btnPrognostico.Location = new Point(4, 557);
                btnSolExame.Location = new Point(4, 618);
                btnReceita.Location = new Point(4, 684);
            }
        }

        public void Ocultar2()
        {
            mostrar2 = true;
            btnPaciente.Hide();
            btnInternado.Hide();
            btnAlta.Hide();
            btnObito.Hide();
            //  Location
            if (mostrar)
            {
                btnTriagem.Location = new Point(4, 130);
                btnPrognostico.Location = new Point(4, 191);
                btnSolExame.Location = new Point(4, 252);
                btnReceita.Location = new Point(4, 318);
            }
            else
            {
                btnPrognostico.Location = new Point(4, 313); //Alterei
                btnSolExame.Location = new Point(4, 374);
                btnReceita.Location = new Point(4, 440);
            }          
        }
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");
        
        public void TotalMedico()
        {
            Sqlcon.Open();
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT COUNT(*) FROM Medico", Sqlcon);
            Adpter.Fill(dados);
            Adpter.Dispose();
            Sqlcon.Close();
            lblTotalMedico.Text = dados.Rows.Count.ToString();
        }

        public void TotalEstagiario()
        {
            Sqlcon.Open();
            DataTable dados1 = new DataTable();
            SqlDataAdapter Adpter1 = new SqlDataAdapter("SELECT COUNT(*) FROM Estagiario", Sqlcon);
            Adpter1.Fill(dados1);
            Adpter1.Dispose();
            Sqlcon.Close();
            lblTotalEstagiario.Text = dados1.Rows.Count.ToString();
        }
        
        public void TotalPacienteInternado()
        {
            Sqlcon.Open();
            DataTable dados2 = new DataTable();
            SqlDataAdapter Adpter2 = new SqlDataAdapter("SELECT COUNT(*) FROM Paciente_Internado", Sqlcon);
            Adpter2.Fill(dados2);
            Adpter2.Dispose();
            lblTotalPacInternado.Text = dados2.Rows.Count.ToString();
            Sqlcon.Close();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            this.Ocultar();
            this.Ocultar2();
            this.TotalMedico();
            this.TotalEstagiario();
            this.TotalPacienteInternado();
        }

        // Menu
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.sobre == null)
                Referencias_Formularios.sobre = new frmSobre();

            Referencias_Formularios.sobre.Show();
            Referencias_Formularios.sobre.Focus();
            Referencias_Formularios.sobre.Refresh();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja sair do sistema?", "            Hospital EG Esperança", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
                Application.Exit();
        }

        private void logooffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Referencias_Formularios.login == null)
                Referencias_Formularios.login = new frmLogin();
            
            Referencias_Formularios.login.Show();
            Referencias_Formularios.login.Focus();
            Referencias_Formularios.login.Refresh();

            Referencias_Formularios.login.txtLogin.Clear();
            Referencias_Formularios.login.txtSenha.Clear();
            Referencias_Formularios.login.txtLogin.Focus();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "Data: " + DateTime.Now.ToShortDateString();
            toolStripStatusLabel4.Text = "Hora: " + DateTime.Now.ToShortTimeString();
        }

        // Chamando formulários de cadastramento
        //  Área para Funcionários
        private void geralToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.cadGeral == null)
                Referencias_Formularios.cadGeral = new frmCadastrarFuncionarioGeral();

            Referencias_Formularios.cadGeral.Show();
            Referencias_Formularios.cadGeral.Focus();
            Referencias_Formularios.cadGeral.Refresh();
        }

        private void médicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Referencias_Formularios.cadMedico == null)
                Referencias_Formularios.cadMedico = new frmCadastrarMedico();

            Referencias_Formularios.cadMedico.Show();
            Referencias_Formularios.cadMedico.Focus();
            Referencias_Formularios.cadMedico.Refresh();
        }

        private void estagiáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.cadEstagiario == null)
                Referencias_Formularios.cadEstagiario = new frmCadastrarEstagiario();

            Referencias_Formularios.cadEstagiario.Show();
            Referencias_Formularios.cadEstagiario.Focus();
            Referencias_Formularios.cadEstagiario.Refresh();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.cadUsuario == null)
                Referencias_Formularios.cadUsuario = new frmCadastrarUsuario();

            Referencias_Formularios.cadUsuario.Show();
            Referencias_Formularios.cadUsuario.Focus();
            Referencias_Formularios.cadUsuario.Refresh();
        }

        // Área para Pacientes
        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.cadPaciente == null)
                Referencias_Formularios.cadPaciente = new frmCadastramento.frmCadastrarPaciente();

            Referencias_Formularios.cadPaciente.Show();
            Referencias_Formularios.cadPaciente.Focus();
        }

        private void examesToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.cadExame == null)
                Referencias_Formularios.cadExame = new frmCadastrarExame();

            Referencias_Formularios.cadExame.Show();
            Referencias_Formularios.cadExame.Focus();
            Referencias_Formularios.cadExame.Refresh();
        }

        private void marcarCirugiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.cadMarcacaoCirugia == null)
                Referencias_Formularios.cadMarcacaoCirugia = new frmCadastramento.frmCadastrarMarcacaoCirugia();

            Referencias_Formularios.cadMarcacaoCirugia.Show();
            Referencias_Formularios.cadMarcacaoCirugia.Focus();
            Referencias_Formularios.cadMarcacaoCirugia.Refresh();
        }

        private void marcarConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.cadMarcacaoConsulta == null)
                Referencias_Formularios.cadMarcacaoConsulta = new frmCadastramento.frmCadastrarMarcacaoConsulta();

            Referencias_Formularios.cadMarcacaoConsulta.Show();
            Referencias_Formularios.cadMarcacaoConsulta.Focus();
            Referencias_Formularios.cadMarcacaoConsulta.Refresh();
        }

        private void pacienteInternadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.cadPacInternado == null)
                Referencias_Formularios.cadPacInternado = new frmCadastrarPacienteInternado();

            Referencias_Formularios.cadPacInternado.Show();
            Referencias_Formularios.cadPacInternado.Focus();
            Referencias_Formularios.cadPacInternado.Refresh();
        }

        private void altaParaPacienteInternadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.cadAltaPaciente == null)
                Referencias_Formularios.cadAltaPaciente = new frmCadastramento.frmCadastrarAlta_PacienteInternado();

            Referencias_Formularios.cadAltaPaciente.Show();
            Referencias_Formularios.cadAltaPaciente.Focus();
            Referencias_Formularios.cadAltaPaciente.Refresh();
        }

        private void morteDoPacienteInternadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.cadMortePaciente == null)
                Referencias_Formularios.cadMortePaciente = new frmCadastramento.frmCadastrarMorte_Paciente();

            Referencias_Formularios.cadMortePaciente.Show();
            Referencias_Formularios.cadMortePaciente.Focus();
            Referencias_Formularios.cadMortePaciente.Refresh();
        }

        private void quartoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.cadQuarto == null)
                Referencias_Formularios.cadQuarto = new frmCadastramento.frmCadastrarQuarto();

            Referencias_Formularios.cadQuarto.Show();
            Referencias_Formularios.cadQuarto.Focus();
            Referencias_Formularios.cadQuarto.Refresh();
        }

        private void tratamentosToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.cadTratamento == null)
                Referencias_Formularios.cadTratamento = new frmCadastrarTratamento();

            Referencias_Formularios.cadTratamento.Show();
            Referencias_Formularios.cadTratamento.Focus();
            Referencias_Formularios.cadTratamento.Refresh();
        }
        //  Área para Farmácia
        private void fornecedoresToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.cadFornecedor == null)
                Referencias_Formularios.cadFornecedor = new frmCadastrarFornecedor();

            Referencias_Formularios.cadFornecedor.Show();
            Referencias_Formularios.cadFornecedor.Focus();
            Referencias_Formularios.cadFornecedor.Refresh();
        }

        private void materiaisDescataveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.cadMatDescartavel == null)
                Referencias_Formularios.cadMatDescartavel = new frmCadastrarMaterialDescartavel();

            Referencias_Formularios.cadMatDescartavel.Show();
            Referencias_Formularios.cadMatDescartavel.Focus();
            Referencias_Formularios.cadMatDescartavel.Refresh();
        }

        private void medicamentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.cadMedicamento == null)
                Referencias_Formularios.cadMedicamento = new frmCadastrarMedicamento();

            Referencias_Formularios.cadMedicamento.Show();
            Referencias_Formularios.cadMedicamento.Focus();
            Referencias_Formularios.cadMedicamento.Refresh();
        }

        // Outros
        private void alaHospitalarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.cadAla_Hospitalar == null)
                Referencias_Formularios.cadAla_Hospitalar = new frmCadastrarAla_Hospitalar();

            Referencias_Formularios.cadAla_Hospitalar.Show();
            Referencias_Formularios.cadAla_Hospitalar.Focus();
            Referencias_Formularios.cadAla_Hospitalar.Refresh();
        }

        private void escolaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.cadEscola == null)
                Referencias_Formularios.cadEscola = new frmCadastrarEscola();

            Referencias_Formularios.cadEscola.Show();
            Referencias_Formularios.cadEscola.Focus();
            Referencias_Formularios.cadEscola.Refresh();
        }

        private void especialidadeDoMédicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.cadEspMedico == null)
                Referencias_Formularios.cadEspMedico = new frmCadastramento.frmCadastrarEspecialidadeMedico();

            Referencias_Formularios.cadEspMedico.Show();
            Referencias_Formularios.cadEspMedico.Focus();
            Referencias_Formularios.cadEspMedico.Refresh();
        }

        private void tipoDeCirugiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.cadTipoCirugia == null)
                Referencias_Formularios.cadTipoCirugia = new frmCadastramento.frmCadastrarTipo_Cirugia();

            Referencias_Formularios.cadTipoCirugia.Show();
            Referencias_Formularios.cadTipoCirugia.Focus();
            Referencias_Formularios.cadTipoCirugia.Refresh();
        }

        private void tipoDeConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.cadTipoConsulta == null)
                Referencias_Formularios.cadTipoConsulta = new frmCadastramento.frmCadastrarTipo_Consulta();

            Referencias_Formularios.cadTipoConsulta.Show();
            Referencias_Formularios.cadTipoConsulta.Focus();
            Referencias_Formularios.cadTipoConsulta.Refresh();
        }

        //Chamada dos Formulários de Consulta
        //  Área para Funcionários
        private void geralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.conFunGeral == null)
                Referencias_Formularios.conFunGeral = new frmConsulta.frmConsultarFuncionario_Geral();

            Referencias_Formularios.conFunGeral.Show();
            Referencias_Formularios.conFunGeral.Focus();
            Referencias_Formularios.conFunGeral.Refresh();
        }

        private void médicosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.conMedico == null)
                Referencias_Formularios.conMedico = new frmConsulta.frmConsultarMedico();

            Referencias_Formularios.conMedico.Show();
            Referencias_Formularios.conMedico.Focus();
            Referencias_Formularios.conMedico.Refresh();
        }

        private void estagiáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.conEstagiario == null)
                Referencias_Formularios.conEstagiario = new frmConsulta.frmConsultarEstagiario();

            Referencias_Formularios.conEstagiario.Show();
            Referencias_Formularios.conEstagiario.Focus();
            Referencias_Formularios.conEstagiario.Refresh();
        }

        private void usuáriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.conUsuario == null)
                Referencias_Formularios.conUsuario = new frmConsulta.frmConsultarUsuario();

            Referencias_Formularios.conUsuario.Show();
            Referencias_Formularios.conUsuario.Focus();
            Referencias_Formularios.conUsuario.Refresh();
        }
        //  Área para Pacientes
        private void pacienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.conPaciente == null)
                Referencias_Formularios.conPaciente = new frmConsulta.frmConsultarPaciente();

            Referencias_Formularios.conPaciente.Show();
            Referencias_Formularios.conPaciente.Focus();
        }

        private void examesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.conExame == null)
                Referencias_Formularios.conExame = new frmConsulta.frmConsultarExame();

            Referencias_Formularios.conExame.Show();
            Referencias_Formularios.conExame.Focus();
            Referencias_Formularios.conExame.Refresh();
        }

        private void tratamentosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.conTratamento == null)
                Referencias_Formularios.conTratamento = new frmConsulta.frmConsultarTratamento();

            Referencias_Formularios.conTratamento.Show();
            Referencias_Formularios.conTratamento.Focus();
            Referencias_Formularios.conTratamento.Refresh();
        }

        private void marcarCirugiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.conMarcarCirugia == null)
                Referencias_Formularios.conMarcarCirugia = new frmConsulta.frmConsultarMarcacaoCirugia();

            Referencias_Formularios.conMarcarCirugia.Show();
            Referencias_Formularios.conMarcarCirugia.Focus();
            Referencias_Formularios.conMarcarCirugia.Refresh();
        }

        private void marcarConsultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.conMarcarConsulta == null)
                Referencias_Formularios.conMarcarConsulta = new frmConsulta.frmConsultarMarcacaoConsulta();

            Referencias_Formularios.conMarcarConsulta.Show();
            Referencias_Formularios.conMarcarConsulta.Focus();
            Referencias_Formularios.conMarcarConsulta.Refresh();
        }

        private void pacienteInternadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.conPacienteInternado == null)
                Referencias_Formularios.conPacienteInternado = new frmConsulta.frmConsultarPacienteInternado();

            Referencias_Formularios.conPacienteInternado.Show();
            Referencias_Formularios.conPacienteInternado.Focus();
            Referencias_Formularios.conPacienteInternado.Refresh();
        }

        private void alltaParaPacienteInternadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.conAltaPaciente == null)
                Referencias_Formularios.conAltaPaciente = new frmConsulta.frmConsultarAlta_PacienteInternado();

            Referencias_Formularios.conAltaPaciente.Show();
            Referencias_Formularios.conAltaPaciente.Focus();
            Referencias_Formularios.conAltaPaciente.Refresh();
        }

        private void morteDoPacienteInternadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.conMortePaciente == null)
                Referencias_Formularios.conMortePaciente = new frmConsulta.frmConsultarMorte_PacienteInternado();

            Referencias_Formularios.conMortePaciente.Show();
            Referencias_Formularios.conMortePaciente.Focus();
            Referencias_Formularios.conMortePaciente.Refresh();
        }

        private void quartoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.conQuarto == null)
                Referencias_Formularios.conQuarto = new frmConsulta.frmConsultarQuarto();

            Referencias_Formularios.conQuarto.Show();
            Referencias_Formularios.conQuarto.Focus();
            Referencias_Formularios.conQuarto.Refresh();
        }
        
        //  Área para Farmácia
        private void fornedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.conFornecedor == null)
                Referencias_Formularios.conFornecedor = new frmConsulta.frmConsultarFornecedor();

            Referencias_Formularios.conFornecedor.Show();
            Referencias_Formularios.conFornecedor.Focus();
            Referencias_Formularios.conFornecedor.Refresh();
        }

        private void materiasDescartaveisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.conMatDescartavel == null)
                Referencias_Formularios.conMatDescartavel = new frmConsulta.frmConsultarMatDescartavel();

            Referencias_Formularios.conMatDescartavel.Show();
            Referencias_Formularios.conMatDescartavel.Focus();
            Referencias_Formularios.conMatDescartavel.Refresh();
        }

        private void medicamentosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.conMedicamento == null)
                Referencias_Formularios.conMedicamento = new frmConsulta.frmConsultarMedicamento();

            Referencias_Formularios.conMedicamento.Show();
            Referencias_Formularios.conMedicamento.Focus();
            Referencias_Formularios.conMedicamento.Refresh();
        }

        //  Outros
        private void alaHospitalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.conAlaHospitalar == null)
                Referencias_Formularios.conAlaHospitalar = new frmConsulta.frmConsultarAlaHospitalar();

            Referencias_Formularios.conAlaHospitalar.Show();
            Referencias_Formularios.conAlaHospitalar.Focus();
            Referencias_Formularios.conAlaHospitalar.Refresh();
        }

        private void escolaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.conEscola == null)
                Referencias_Formularios.conEscola = new frmConsulta.frmConsultarEscola();

            Referencias_Formularios.conEscola.Show();
            Referencias_Formularios.conEscola.Focus();
            Referencias_Formularios.conEscola.Refresh();
        }

        private void especialidadeDoMédicoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.conEspMedico == null)
                Referencias_Formularios.conEspMedico = new frmConsulta.frmConsultarEspecialidadeMedico();

            Referencias_Formularios.conEspMedico.Show();
            Referencias_Formularios.conEspMedico.Focus();
            Referencias_Formularios.conEspMedico.Refresh();
        }

        private void tipoDeCirugiaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.conTipoCirugia == null)
                Referencias_Formularios.conTipoCirugia = new frmConsulta.frmConsultarTipoCirugia();

            Referencias_Formularios.conTipoCirugia.Show();
            Referencias_Formularios.conTipoCirugia.Focus();
            Referencias_Formularios.conTipoCirugia.Refresh();
        }

        private void tipoDeConsultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.conTipoConsulta == null)
                Referencias_Formularios.conTipoConsulta = new frmConsulta.frmConsultarTipoConsulta();

            Referencias_Formularios.conTipoConsulta.Show();
            Referencias_Formularios.conTipoConsulta.Focus();
            Referencias_Formularios.conTipoConsulta.Refresh();
        }

        //  GetFarmácia
        private void saidaDeMatrialDescartavelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.getMatDescartavel == null)
                Referencias_Formularios.getMatDescartavel = new frmGetFarmacia.frmSaidaMatDescartavel();

            Referencias_Formularios.getMatDescartavel.Show();
            Referencias_Formularios.getMatDescartavel.Focus();
            Referencias_Formularios.getMatDescartavel.Refresh();
        }

        private void saidaDeMedicamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.getMedicamento == null)
                Referencias_Formularios.getMedicamento = new frmGetFarmacia.frmSaidaMedicamento();

            Referencias_Formularios.getMedicamento.Show();
            Referencias_Formularios.getMedicamento.Focus();
            Referencias_Formularios.getMedicamento.Refresh();
        }

        // Relatórios        
        private void btnReceita_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.relReceituario == null)
                Referencias_Formularios.relReceituario = new frmRelatorio.frmRelatorio_Receituario();

            Referencias_Formularios.relReceituario.Show();
            Referencias_Formularios.relReceituario.Focus();
            Referencias_Formularios.relReceituario.Refresh();
        }

        private void btnSolExame_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.relSolicitacaoExame == null)
                Referencias_Formularios.relSolicitacaoExame = new frmRelatorio.frmRelatorio_SolicitacaoExame();

            Referencias_Formularios.relSolicitacaoExame.Show();
            Referencias_Formularios.relSolicitacaoExame.Focus();
            Referencias_Formularios.relSolicitacaoExame.Refresh();
        }

        private void btnPrognostico_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.relPrognostico == null)
                Referencias_Formularios.relPrognostico = new frmRelatorio.frmRelatorio_Prognostico();

            Referencias_Formularios.relPrognostico.Show();
            Referencias_Formularios.relPrognostico.Focus();
            Referencias_Formularios.relPrognostico.Refresh();
        }

        // Botão Dropdown 1
        private void btnMarcacao_Click(object sender, EventArgs e)
        {
            if (mostrar)
                this.Mostrar();
            else
                this.Ocultar();
        }
        
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.cadMarcacaoConsulta == null)
                Referencias_Formularios.cadMarcacaoConsulta = new frmCadastramento.frmCadastrarMarcacaoConsulta();

            Referencias_Formularios.cadMarcacaoConsulta.Show();
            Referencias_Formularios.cadMarcacaoConsulta.Focus();
            Referencias_Formularios.cadMarcacaoConsulta.Refresh();
        }

        private void btnCirugia_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.cadMarcacaoCirugia == null)
                Referencias_Formularios.cadMarcacaoCirugia = new frmCadastramento.frmCadastrarMarcacaoCirugia();

            Referencias_Formularios.cadMarcacaoCirugia.Show();
            Referencias_Formularios.cadMarcacaoCirugia.Focus();
            Referencias_Formularios.cadMarcacaoCirugia.Refresh();
        }

        // Botão Dropdown 2
        private void btnTriagem_Click(object sender, EventArgs e)
        {
            if (mostrar2)
                this.Mostrar2();
            else
                this.Ocultar2();
        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.cadPaciente == null)
                Referencias_Formularios.cadPaciente = new frmCadastramento.frmCadastrarPaciente();

            Referencias_Formularios.cadPaciente.Show();
            Referencias_Formularios.cadPaciente.Focus();
            Referencias_Formularios.cadPaciente.Refresh();
        }

        private void btnInternado_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.cadPacInternado == null)
                Referencias_Formularios.cadPacInternado = new frmCadastrarPacienteInternado();

            Referencias_Formularios.cadPacInternado.Show();
            Referencias_Formularios.cadPacInternado.Focus();
            Referencias_Formularios.cadPacInternado.Refresh();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.cadAltaPaciente == null)
                Referencias_Formularios.cadAltaPaciente = new frmCadastramento.frmCadastrarAlta_PacienteInternado();

            Referencias_Formularios.cadAltaPaciente.Show();
            Referencias_Formularios.cadAltaPaciente.Focus();
            Referencias_Formularios.cadAltaPaciente.Refresh();
        }

        private void btnObito_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.cadMortePaciente == null)
                Referencias_Formularios.cadMortePaciente = new frmCadastramento.frmCadastrarMorte_Paciente();

            Referencias_Formularios.cadMortePaciente.Show();
            Referencias_Formularios.cadMortePaciente.Focus();
            Referencias_Formularios.cadMortePaciente.Refresh();
        }

        private void btnRefresch_Click(object sender, EventArgs e)
        {
            this.TotalMedico();
            this.TotalPacienteInternado();
            this.TotalEstagiario();
        }
    }
}
