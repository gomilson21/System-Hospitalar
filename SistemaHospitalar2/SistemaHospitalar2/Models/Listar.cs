using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaHospitalar2.Dados
{
    class Listar
    {
        private Conexao conect = new Conexao();
        private SqlCommand cmd = new SqlCommand();
        private SqlDataReader dr;

        // Listas de dados 
        //  Área dos Funcionarios
        //  Funcionário
        public DataTable ListarFuncionario()
        {
            DataTable tabela = new DataTable();
            cmd.Connection = conect.AbrirConexao();
            cmd.CommandText = "sp_ListarFuncionario";
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            tabela.Load(dr);
            dr.Close();
            conect.FecharConexao();
            return tabela;
        }
        //  Médico
        public DataTable ListarMedico()
        {
            DataTable tabela = new DataTable();
            cmd.Connection = conect.AbrirConexao();
            cmd.CommandText = "sp_ListarMedico";
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            tabela.Load(dr);
            dr.Close();
            conect.FecharConexao();
            return tabela;
        }
        //  Estagiario
        public DataTable ListarEstagiario()
        {
            DataTable tabela = new DataTable();
            cmd.Connection = conect.AbrirConexao();
            cmd.CommandText = "sp_ListarEstagiario";
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            tabela.Load(dr);
            dr.Close();
            conect.FecharConexao();
            return tabela;
        }

        //  Área para Pacientes
        //  Paciente
        public DataTable ListarPaciente()
        {
            DataTable tabela = new DataTable();
            cmd.Connection = conect.AbrirConexao();
            cmd.CommandText = "sp_ListarPaciente";
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            tabela.Load(dr);
            dr.Close();
            conect.FecharConexao();
            return tabela;
        }
        //  Marcação de Cirugia
        public DataTable ListarMarcacaoCirugia()
        {
            DataTable tabela = new DataTable();
            cmd.Connection = conect.AbrirConexao();
            cmd.CommandText = "sp_ListarMarcacaoCirugia";
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            tabela.Load(dr);
            dr.Close();
            conect.FecharConexao();
            return tabela;
        }
        //  Marcação de Consulta
        public DataTable ListarMarcacaoConsulta()
        {
            DataTable tabela = new DataTable();
            cmd.Connection = conect.AbrirConexao();
            cmd.CommandText = "sp_ListarMarcacaoConsulta";
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            tabela.Load(dr);
            dr.Close();
            conect.FecharConexao();
            return tabela;
        }
        //  Paciente Internado
        public DataTable ListarQuarto()
        {
            DataTable tabela = new DataTable();
            cmd.Connection = conect.AbrirConexao();
            cmd.CommandText = "sp_ListarQuarto";
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            tabela.Load(dr);
            dr.Close();
            conect.FecharConexao();
            return tabela;
        }
        //  Paciente Internado
        public DataTable ListarPacienteInternado()
        {
            DataTable tabela = new DataTable();
            cmd.Connection = conect.AbrirConexao();
            cmd.CommandText = "sp_ListarPacienteInternado";
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            tabela.Load(dr);
            dr.Close();
            conect.FecharConexao();
            return tabela;
        }
        //  Alta do Paciente Internado
        public DataTable ListarAltaPacienteInternado()
        {
            DataTable tabela = new DataTable();
            cmd.Connection = conect.AbrirConexao();
            cmd.CommandText = "sp_ListarAltaPacienteInternado";
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            tabela.Load(dr);
            dr.Close();
            conect.FecharConexao();
            return tabela;
        }
        //  Morte do Paciente Internado
        public DataTable ListarMortePaciente()
        {
            DataTable tabela = new DataTable();
            cmd.Connection = conect.AbrirConexao();
            cmd.CommandText = "sp_ListarMortePaciente";
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            tabela.Load(dr);
            dr.Close();
            conect.FecharConexao();
            return tabela;
        }
        //  Área da Farmácia
        //  Material Descartável
        public DataTable ListarMaterialDescartavel()
        {
            DataTable tabela = new DataTable();
            cmd.Connection = conect.AbrirConexao();
            cmd.CommandText = "sp_ListarMaterialDescartavel";
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            tabela.Load(dr);
            dr.Close();
            conect.FecharConexao();
            return tabela;
        }
        //  Medicamento
        public DataTable ListarMedicamento()
        {
            DataTable tabela = new DataTable();
            cmd.Connection = conect.AbrirConexao();
            cmd.CommandText = "sp_ListarMedicamento";
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            tabela.Load(dr);
            dr.Close();
            conect.FecharConexao();
            return tabela;
        }
        //  Exame
        public DataTable ListarExame()
        {
            DataTable tabela = new DataTable();
            cmd.Connection = conect.AbrirConexao();
            cmd.CommandText = "sp_ListarExame";
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            tabela.Load(dr);
            dr.Close();
            conect.FecharConexao();
            return tabela;
        }

        //  Listagem Para ComboBox
        //  Funcionarios
        public DataTable ComboBoxListarFuncionario()
        {
            DataTable tabela = new DataTable();
            cmd.Connection = conect.AbrirConexao();
            cmd.CommandText = "sp_ComboBoxListarFuncionario";
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            tabela.Load(dr);
            dr.Close();
            conect.FecharConexao();
            return tabela;
        }
        //  Funcionário para Cadastrar Usuário
        public DataTable ComboBoxListarFuncionario_Usuario()
        {
            DataTable tabela = new DataTable();
            cmd.Connection = conect.AbrirConexao();
            cmd.CommandText = "sp_ComboBoxListarFuncionario_Usuario";
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            tabela.Load(dr);
            dr.Close();
            conect.FecharConexao();
            return tabela;
        }
        //  Médico
        public DataTable ComboBoxListarMedico()
        {
            DataTable tabela = new DataTable();
            cmd.Connection = conect.AbrirConexao();
            cmd.CommandText = "sp_ComboBoxListarMedico";
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            tabela.Load(dr);
            dr.Close();
            conect.FecharConexao();
            return tabela;
        }
        //  Função
        public DataTable ComboBoxListarFuncao()
        {
            DataTable tabela = new DataTable();
            cmd.Connection = conect.AbrirConexao();
            cmd.CommandText = "sp_ComboBoxListarFuncao";
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            tabela.Load(dr);
            dr.Close();
            conect.FecharConexao();
            return tabela;
        }
        //  Paciente
        public DataTable ComboBoxListarPaciente()
        {
            DataTable tabela = new DataTable();
            cmd.Connection = conect.AbrirConexao();
            cmd.CommandText = "sp_ComboBoxListarPaciente";
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            tabela.Load(dr);
            dr.Close();
            conect.FecharConexao();
            return tabela;
        }
        //  Tipo de Consulta
        public DataTable ComboBoxListarTipoConsulta()
        {
            DataTable tabela = new DataTable();
            cmd.Connection = conect.AbrirConexao();
            cmd.CommandText = "sp_ComboBoxListarTipoConsulta";
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            tabela.Load(dr);
            dr.Close();
            conect.FecharConexao();
            return tabela;
        }
        //  Tipo de Consulta
        public DataTable ComboBoxListarTipoCirugia()
        {
            DataTable tabela = new DataTable();
            cmd.Connection = conect.AbrirConexao();
            cmd.CommandText = "sp_ComboBoxListarTipoCirugia";
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            tabela.Load(dr);
            dr.Close();
            conect.FecharConexao();
            return tabela;
        }
        //  Paciente Internad
        public DataTable ComboBoxListarPacienteInternado()
        {
            DataTable tabela = new DataTable();
            cmd.Connection = conect.AbrirConexao();
            cmd.CommandText = "sp_ComboBoxListarPacienteInternado";
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            tabela.Load(dr);
            dr.Close();
            conect.FecharConexao();
            return tabela;
        }
        //  Tratamento
        public DataTable ComboBoxListarTratamento()
        {
            DataTable tabela = new DataTable();
            cmd.Connection = conect.AbrirConexao();
            cmd.CommandText = "sp_ComboBoxListarTratamento";
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            tabela.Load(dr);
            dr.Close();
            conect.FecharConexao();
            return tabela;
        }
        //  Quarto
        public DataTable ComboBoxListarQuarto()
        {
            DataTable tabela = new DataTable();
            cmd.Connection = conect.AbrirConexao();
            cmd.CommandText = "sp_ComboBoxListarQuarto";
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            tabela.Load(dr);
            dr.Close();
            conect.FecharConexao();
            return tabela;
        }
        //  Ala Hospitalar
        public DataTable ComboBoxListarAlaHospitalar()
        {
            DataTable tabela = new DataTable();
            cmd.Connection = conect.AbrirConexao();
            cmd.CommandText = "sp_ComboBoxListarAlaHospitalar";
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            tabela.Load(dr);
            dr.Close();
            conect.FecharConexao();
            return tabela;
        }

        // Percentagem do Hospital
        public DataTable PercentagemMedico()
        {
            DataTable tabela = new DataTable();
            cmd.Connection = conect.AbrirConexao();
            cmd.CommandText = "sp_PercentagemMedico";
            cmd.CommandType = CommandType.StoredProcedure;
            dr = cmd.ExecuteReader();
            tabela.Load(dr);
            dr.Close();
            conect.FecharConexao();
            return tabela;
        }
    }
}
