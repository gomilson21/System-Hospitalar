using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHospitalar2
{
    public class Referencias_Formularios
    {
        public static frmInicio entar{ get; set; }
        public static frmLogin login { get; set; }
        public static frmDashboard dash { get; set; }
        public static frmRecuperarSenha recuperarSenha { get; set; }
        public static frmSobre sobre { get; set; }

        // Formulário de Cadastramento
        // Área para Funcionarios
        public static frmCadastrarFuncionarioGeral cadGeral { get; set; }
        public static frmCadastrarMedico cadMedico { get; set; }
        public static frmCadastrarEstagiario cadEstagiario { get; set; }
        public static frmCadastrarUsuario cadUsuario { get; set; }
        //  Área para Farmácia
        public static frmCadastrarFornecedor cadFornecedor { get; set; }
        public static frmCadastrarMaterialDescartavel cadMatDescartavel { get; set; }
        public static frmCadastrarMedicamento cadMedicamento { get; set; }
        //  Área para Paciente
        public static frmCadastrarExame cadExame { get; set; }
        public static frmCadastramento.frmCadastrarTipo_Consulta cadTipoConsulta { get; set; }
        public static frmCadastramento.frmCadastrarTipo_Cirugia cadTipoCirugia { get; set; }
        public static frmCadastramento.frmCadastrarMarcacaoCirugia cadMarcacaoCirugia { get; set; }
        public static frmCadastramento.frmCadastrarMarcacaoConsulta cadMarcacaoConsulta { get; set; }
        public static frmCadastramento.frmCadastrarPaciente cadPaciente { get; set; }
        public static frmCadastrarPacienteInternado cadPacInternado { get; set; }
        public static frmCadastramento.frmCadastrarAlta_PacienteInternado cadAltaPaciente { get; set; }
        public static frmCadastramento.frmCadastrarMorte_Paciente cadMortePaciente { get; set; }
        public static frmCadastrarTratamento cadTratamento { get; set; }
        // Outros
        public static frmCadastrarAla_Hospitalar cadAla_Hospitalar{ get; set; }
        public static frmCadastrarEscola cadEscola{ get; set; }
        public static frmCadastramento.frmCadastrarEspecialidadeMedico cadEspMedico { get; set; }
        public static frmCadastramento.frmCadastrarQuarto cadQuarto { get; set; }

        // Formulários de Consulta
        //  Área para Funcionários
        public static frmConsulta.frmConsultarFuncionario_Geral conFunGeral { get; set; }
        public static frmConsulta.frmConsultarMedico conMedico { get; set; }
        public static frmConsulta.frmConsultarEstagiario conEstagiario { get; set; }
        public static frmConsulta.frmConsultarUsuario conUsuario { get; set; }

        // Área para Pacientes
        public static frmConsulta.frmConsultarPaciente conPaciente { get; set; }
        public static frmConsulta.frmConsultarExame conExame { get; set; }
        public static frmConsulta.frmConsultarTratamento conTratamento { get; set; }
        public static frmConsulta.frmConsultarMarcacaoCirugia conMarcarCirugia { get; set; }
        public static frmConsulta.frmConsultarMarcacaoConsulta conMarcarConsulta { get; set; }
        public static frmConsulta.frmConsultarPacienteInternado conPacienteInternado { get; set; }
        public static frmConsulta.frmConsultarAlta_PacienteInternado conAltaPaciente { get; set; }
        public static frmConsulta.frmConsultarMorte_PacienteInternado conMortePaciente { get; set; }
        public static frmConsulta.frmConsultarQuarto conQuarto { get; set; }

        // Área para Farmácia
        public static frmConsulta.frmConsultarFornecedor conFornecedor { get; set; }
        public static frmConsulta.frmConsultarMatDescartavel conMatDescartavel { get; set; }
        public static frmConsulta.frmConsultarMedicamento conMedicamento { get; set; }

        // Outros
        public static frmConsulta.frmConsultarEscola conEscola { get; set; }
        public static frmConsulta.frmConsultarEspecialidadeMedico conEspMedico { get; set; }
        public static frmConsulta.frmConsultarAlaHospitalar conAlaHospitalar { get; set; }
        public static frmConsulta.frmConsultarTipoCirugia conTipoCirugia { get; set; }
        public static frmConsulta.frmConsultarTipoConsulta conTipoConsulta { get; set; }

        //Formulários de GetFarmácia
        public static frmGetFarmacia.frmSaidaMatDescartavel getMatDescartavel { get; set; }
        public static frmGetFarmacia.frmSaidaMedicamento getMedicamento { get; set; }

        //Formulários de Relatórios
        public static frmRelatorio_PrescricaoMedica relPrescricaoMedica { get; set; }
        public static frmRelatorio.frmRelatorio_MarcacaoCirugia relMarcacaoCirugia { get; set; }
        public static frmRelatorio.frmRelatorio_MarcacaoConsulta relMarcacaoConsulta { get; set; }
        public static frmRelatorio.frmRelatorio_Receituario relReceituario { get; set; }
        public static frmRelatorio.frmRelatorio_SolicitacaoExame relSolicitacaoExame { get; set; }
        public static frmRelatorio.frmRelatorio_Prognostico relPrognostico { get; set; }
        public static frmRelatorio.frmRelatorio_AltaHospitalar relAlta { get; set; }
        public static frmRelatorio.frmRelatorio_Obito relObito { get; set; }
        public static frmRelatorio.frmRelatorio_Justificativo relJustificativo { get; set; }
    }
}
