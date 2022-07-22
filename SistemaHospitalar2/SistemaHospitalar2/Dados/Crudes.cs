using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaHospitalar2
{
    class Crudes
    {
        private Conexao conect = new Conexao();
        private SqlCommand cmd = new SqlCommand();
        private SqlDataReader dr; 
        public string resp = "";

        //  Funcionários
        //               INSERIR
        public void inserirFuncionario(string nome, DateTime data_nascimento, string sexo, string BI, string email,
            int telefone, string endereco, string numero_carteira, DateTime data_admissao, int codFuncao)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_cadFuncionarios";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@data_nascimento", data_nascimento);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@BI", BI);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@numero_carteira", numero_carteira);
                cmd.Parameters.AddWithValue("@data_admissao", data_admissao);
                cmd.Parameters.AddWithValue("@codFuncao", codFuncao);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao adicionar um novo Funcionario";
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //          Editar 
        public void editarFuncionario(int codFuncionario, string nome, DateTime data_nascimento, string sexo, string BI, string email, 
            int telefone, string endereco, string numero_carteira, DateTime data_admissao, int codFuncao)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_editFuncionarios";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codFuncionario", codFuncionario);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@data_nascimento", data_nascimento);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@BI", BI);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@numero_carteira", numero_carteira);
                cmd.Parameters.AddWithValue("@data_admissao", data_admissao);
                cmd.Parameters.AddWithValue("@codFuncao", codFuncao);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao actualizar os dados do Funcionário";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }

        //          Eliminar
        public void eliminarFuncionario(int codFuncionario)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_delFuncionarios";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codFuncionario", codFuncionario);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar elimiar os dados do Funcionário";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }

        //  Médico
        //               INSERIR
        public void inserirMedico(string nome, DateTime data_nascimento, string sexo, string BI, int telefone,
            string endereco, string email, string numero_carteira, DateTime data_admissao, int codEspecialidade)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_cadMedico";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@data_nascimento", data_nascimento);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@BI", BI);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@numero_carteira", numero_carteira);
                cmd.Parameters.AddWithValue("@data_admissao", data_admissao);
                cmd.Parameters.AddWithValue("@codEspecialidade", codEspecialidade);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar adicionar um novo Médico!";
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //          Editar 
        public void editarMedico(int codMedico, string nome, DateTime data_nascimento, string sexo, string BI, int telefone,
            string endereco, string email, string numero_carteira, DateTime data_admissao, int codEspecialidade)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_editMedico";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codMedico", codMedico);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@data_nascimento", data_nascimento);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@BI", BI);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@numero_carteira", numero_carteira);
                cmd.Parameters.AddWithValue("@data_admissao", data_admissao);
                cmd.Parameters.AddWithValue("@codEspecialidade", codEspecialidade);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar actualizar os dados do Médico!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //          Eliminar
        public void eliminarMedico(int codMedico)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_delMedico";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codMedico", codMedico);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar eliminar os dados do Médico!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }

        //  Estagiario
        //               INSERIR
        public void inserirEstagiario(string nome, DateTime data_nascimento, string sexo, string BI, int telefone,
            string endereco, string email, string licenca_estagio, DateTime data_admissao, int codEscola)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_cadEstagiario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@data_nascimento", data_nascimento);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@BI", BI);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@licenca_estagio", licenca_estagio);
                cmd.Parameters.AddWithValue("@data_admissao", data_admissao);
                cmd.Parameters.AddWithValue("@codEscola", codEscola);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar adicionar um novo Estagiario!";
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //          Editar 
        public void editarEstagiario(int codEstagiario, string nome, DateTime data_nascimento, string sexo, string BI, int telefone, 
            string endereco, string email, string licenca_estagio, DateTime data_admissao, int codEscola)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_editEstagiario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codEstagiario", codEstagiario);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@data_nascimento", data_nascimento);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@BI", BI);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@licenca_estagio", licenca_estagio);
                cmd.Parameters.AddWithValue("@data_admissao", data_admissao);
                cmd.Parameters.AddWithValue("@codEscola", codEscola);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar actualizar os dados do Estagiario!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //          Eliminar
        public void eliminarEstagiario(int codEstagiario)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_delEstagiario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codEstagiario", codEstagiario);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar eliminar os dados do Estagiario!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }

        //  Usuario
        //               INSERIR
        public void inserirUsuario(string login, string senha, string confirmar_senha, string estado_usuario, int funcionario)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_cadUsuario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@confirmar_senha", confirmar_senha);
                cmd.Parameters.AddWithValue("@estado", estado_usuario);
                cmd.Parameters.AddWithValue("@codFuncionario", funcionario);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar adicionar um novo Usuário!";
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //          Editar Usuário
        public void editarUsuario(int codUsuario, string login, string senha, string confirmar_senha, string estado_usuario, int codFuncionario)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_editUsuario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codUsuario", codUsuario);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Parameters.AddWithValue("@confirmar_senha", confirmar_senha);
                cmd.Parameters.AddWithValue("@estado", estado_usuario);
                cmd.Parameters.AddWithValue("@codFuncionario", codFuncionario);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar actualizar os dados do Usuário!";
                cmd.Parameters.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
         }

        //          Eliminar usuário
        public void eliminarUsuario(int codUsuario)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_delUsuario";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codUsuario", codUsuario);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar eliminar os dados do Usuário!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }

        // Recuperar Senha do Usuário
        public void RecuperarSenha(string login, string novaSenha, string confirmarSenha)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_Recuperarsenha";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@novaSenha", novaSenha);
                cmd.Parameters.AddWithValue("@confirmarSenha", confirmarSenha);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar fazer a recuperação de senha do Usuário!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //  Área dos Pacientes
        //  Paciente
        //                  INSERIR
        public void inserirPaciente(string nome_paciente, DateTime dataNascimento,
            string sexo, string BI, int telefone, string endereco)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_cadPaciente";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome_paciente", nome_paciente);
                cmd.Parameters.AddWithValue("@dataNascimento", dataNascimento);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@BI", BI);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar adicionar uma novo Paciente!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //              EDITAR
        public void editarPaciente(int codPaciente, string nome_paciente, DateTime dataNascimento, 
            string sexo, string BI, int telefone, string endereco)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_editPaciente";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codPaciente", codPaciente);
                cmd.Parameters.AddWithValue("@nome_paciente", nome_paciente);
                cmd.Parameters.AddWithValue("@dataNascimento", dataNascimento);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@BI", BI);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar actualizar os dados do Paciente!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //              ELIMINAR
        public void eliminarPaciente(int codPaciente)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_delPaciente";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codPaciente", codPaciente);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar eliminar os dados do Paciente!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //  Paciente Internado
        //                  INSERIR
        public void inserirPacienteInternado(int codPaciente, int codQuarto, int numero_cama, string estado_cama, int codTratamento,
            int codMedico, string estado_clinico, DateTime data_internacao, string hora_internacao, string descricao)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_cadPacienteInternado";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codPaciente", codPaciente);
                cmd.Parameters.AddWithValue("@CodQuarto", codQuarto);
                cmd.Parameters.AddWithValue("@numero_cama", numero_cama);
                cmd.Parameters.AddWithValue("@estado_cama", estado_cama);
                cmd.Parameters.AddWithValue("@codTratamento", codTratamento);
                cmd.Parameters.AddWithValue("@codMedico", codMedico);
                cmd.Parameters.AddWithValue("@estado_clinico", estado_clinico);
                cmd.Parameters.AddWithValue("@data_internacao", data_internacao);
                cmd.Parameters.AddWithValue("@hora_internacao", hora_internacao);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar adicionar um novo Paciente Internado!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //              EDITAR
        public void editarPacienteInternado(int codPacienteInternado, int codPaciente, int codQuarto, int numero_cama, string estado_cama,
            int codTratamento, int codMedico, string estado_clinico, DateTime data_internacao, string hora_internacao, string descricao)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_editPacienteInternado";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codPacienteInternado", codPacienteInternado);
                cmd.Parameters.AddWithValue("@codPaciente", codPaciente);
                cmd.Parameters.AddWithValue("@CodQuarto", codQuarto);
                cmd.Parameters.AddWithValue("@numero_cama", numero_cama);
                cmd.Parameters.AddWithValue("@estado_cama", estado_cama);
                cmd.Parameters.AddWithValue("@codTratamento", codTratamento);
                cmd.Parameters.AddWithValue("@codMedico", codMedico);
                cmd.Parameters.AddWithValue("@estado_clinico", estado_clinico);
                cmd.Parameters.AddWithValue("@data_internacao", data_internacao);
                cmd.Parameters.AddWithValue("@hora_internacao", hora_internacao);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar actualizar os dados do Paciente Internado!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //              ELIMINAR
        public void eliminarPacienteInternado(int codPacienteInternado)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_delPacienteInternado";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codPacienteInternado", codPacienteInternado);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar eliminar os dados do Paciente Internado!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }

        //  Alta Paciente Internado
        //                  INSERIR
        public void inserirAltaPaciente(int codPaciente, DateTime data_alta, string hora_alta, DateTime data_regresso, int dias_repouso, string descricao_alta)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_cadAltaPaciente";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codPaciente", codPaciente);
                cmd.Parameters.AddWithValue("@data_alta", data_alta);
                cmd.Parameters.AddWithValue("@hora_alta", hora_alta);
                cmd.Parameters.AddWithValue("@data_regresso", data_regresso);
                cmd.Parameters.AddWithValue("@dias_repouso", dias_repouso);
                cmd.Parameters.AddWithValue("@descricao_alta", descricao_alta);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar adicionar um novo Paciente Internado!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //              EDITAR
        public void editarAltaPaciente(int codAlta, int codPaciente, DateTime data_alta, string hora_alta, DateTime data_regresso, int dias_repouso, string descricao_alta)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_editAltaPaciente";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codAlta", codAlta);
                cmd.Parameters.AddWithValue("@codPaciente", codPaciente);
                cmd.Parameters.AddWithValue("@data_alta", data_alta);
                cmd.Parameters.AddWithValue("@hora_alta", hora_alta);
                cmd.Parameters.AddWithValue("@data_regresso", data_regresso);
                cmd.Parameters.AddWithValue("@dias_repouso", dias_repouso);
                cmd.Parameters.AddWithValue("@descricao_alta", descricao_alta);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar actualizar os dados do Paciente Internado!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //              ELIMINAR
        public void eliminarAltaPaciente(int codAlta)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_delAltaPaciente";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codAlta", codAlta);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar eliminar os dados do Paciente Internado!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }

        //  Morte Paciente Internado
        //                  INSERIR
        public void inserirMortePaciente(int codPaciente, DateTime data_morte, string hora_morte, string causa_morte, string descricao_morte)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_cadMortePaciente";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codPaciente", codPaciente);
                cmd.Parameters.AddWithValue("@data_morte", data_morte);
                cmd.Parameters.AddWithValue("@hora_morte", hora_morte);
                cmd.Parameters.AddWithValue("@causa_morte", causa_morte);
                cmd.Parameters.AddWithValue("@descricao_morte", descricao_morte);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar adicionar um novo Paciente Internado!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //              EDITAR
        public void editarMortePaciente(int codMorte, int codPaciente, DateTime data_morte, string hora_morte, string causa_morte, string descricao_morte)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_editMortePaciente";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codMorte", codMorte);
                cmd.Parameters.AddWithValue("@codPaciente", codPaciente);
                cmd.Parameters.AddWithValue("@data_morte", data_morte);
                cmd.Parameters.AddWithValue("@hora_morte", hora_morte);
                cmd.Parameters.AddWithValue("@causa_morte", causa_morte);
                cmd.Parameters.AddWithValue("@descricao_morte", descricao_morte);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar actualizar os dados do Paciente Internado!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //              ELIMINAR
        public void eliminarMortePaciente(int codMorte)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_delMortePaciente";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codMorte", codMorte);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar eliminar os dados do Paciente Internado!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        // Transferência de Área dos Pacientes
        //  Alta do Paciente Internado
        public void transferirAltaPaciente(int codPaciente, DateTime data_alta, string hora_alta, string descricao_alta)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_TransferirAltaPaciente";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codPaciente", codPaciente);
                cmd.Parameters.AddWithValue("@data_alta", data_alta);
                cmd.Parameters.AddWithValue("@hora_alta", hora_alta);
                cmd.Parameters.AddWithValue("@descricao_alta", descricao_alta);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar efectuar o processo de Transferência do Paciente Internado!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //  Morte do Paciente Internado
        public void transferirMortePaciente(int codPaciente, DateTime data_morte, string hora_morte, string descricao_morte)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_TransferirMortePaciente";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codPaciente", codPaciente);
                cmd.Parameters.AddWithValue("@data_morte", data_morte);
                cmd.Parameters.AddWithValue("@hora_morte", hora_morte);
                cmd.Parameters.AddWithValue("@descricao_morte", descricao_morte);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar efectuar o processo de Transferência do Paciente Internado!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        // Tipo de Consulta
        //                  INSERIR
        public void inserirTipoConsulta(string nome, string descricao)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_cadTipoConsulta";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar adicionar um novo Tipo de Consulta!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //              EDITAR
        public void editarTipoConsulta(int codTipoConsulta, string nome, string descricao)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_editTipoConsulta";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codTipoConsulta", codTipoConsulta);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar actualizar os dados do Tipo de Consulta!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //              ELIMINAR
        public void eliminarTipoConsulta(int codTipoConsulta)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_delTipoConsulta";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codTipoConsulta", codTipoConsulta);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar eliminar os dados do Tipo de Consulta!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }

        // Tipo de Consulta
        //                  INSERIR
        public void inserirTipoCirugia(string nome_cirugia, string descricao)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_cadTipoCirugia";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome_TipoCirugia", nome_cirugia);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar adicionar um novo Tipo de Cirugia!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //              EDITAR
        public void editarTipoCirugia(int codTipoCirugia, string nome_cirugia, string descricao)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_editTipoCirugia";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codTipoCirugia", codTipoCirugia);
                cmd.Parameters.AddWithValue("@nome_TipoCirugia", nome_cirugia);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar actualizar os dados do Tipo de Cirugia!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //              ELIMINAR
        public void eliminarTipoCirugia(int codTipoCirugia)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_delTipoCirugia";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codTipoCirugia", codTipoCirugia);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar eliminar os dados do Tipo de Cirugia!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }

        //  Marcação de Consulta
        //                  INSERIR
        public void inserirMarcacaoConsulta(int codPaciente, int codTipoConsulta, int codMedico, 
            DateTime data, string hora, int dias_repouso, string descricao)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_cadMarcacaoConsulta";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codPaciente", codPaciente);
                cmd.Parameters.AddWithValue("@codTipoConsulta", codTipoConsulta);
                cmd.Parameters.AddWithValue("@codMedico", codMedico);
                cmd.Parameters.AddWithValue("@data", data);
                cmd.Parameters.AddWithValue("@hora", hora);
                cmd.Parameters.AddWithValue("@dias_repouso", dias_repouso);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar adicionar uma novo Marcação de Consulta!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //              EDITAR
        public void editarMarcacaoConsulta(int codMarcacao, int codPaciente, int codTipoConsulta, 
            int codMedico, DateTime data, string hora, int dias_repouso, string descricao)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_editMarcacaoConsulta";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codMarcacao", codMarcacao);
                cmd.Parameters.AddWithValue("@codPaciente", codPaciente);
                cmd.Parameters.AddWithValue("@codTipoConsulta", codTipoConsulta);
                cmd.Parameters.AddWithValue("@codMedico", codMedico);
                cmd.Parameters.AddWithValue("@data", data);
                cmd.Parameters.AddWithValue("@hora", hora);
                cmd.Parameters.AddWithValue("@dias_repouso", dias_repouso);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar actualizar os dados da Marcação de Consulta!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //              ELIMINAR
        public void eliminarMarcacaoConsulta(int codMarcacao)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_delMarcacaoConsulta";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codMarcacao", codMarcacao);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar eliminar os dados da Marcação de Consulta!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //  Marcação de Cirugia
        //                  INSERIR
        public void inserirMarcacaoCirugia(int codPacienteInternado, int codTipo_Cirugia, int codMedico,
            DateTime data_cirugia, string hora_cirugia, string descricao)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_cadMarcacaoCirugia";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codPacienteInternado", codPacienteInternado);
                cmd.Parameters.AddWithValue("@codTipoCirugia", codTipo_Cirugia);
                cmd.Parameters.AddWithValue("@codMedico", codMedico);
                cmd.Parameters.AddWithValue("@data_cirugia", data_cirugia);
                cmd.Parameters.AddWithValue("@hora_cirugia", hora_cirugia);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar adicionar uma nova Marcação de Cirugia!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //              EDITAR
        public void editarMarcacaoCirugia(int codCirugia, int codPacienteInternado, int codTipoCirugia,
            int codMedico, DateTime data_cirugia, string hora_cirugia, string descricao)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_editMarcacaoCirugia";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codCirugia", codCirugia);
                cmd.Parameters.AddWithValue("@codPacienteInternado", codPacienteInternado);
                cmd.Parameters.AddWithValue("@codTipoCirugia", codTipoCirugia);
                cmd.Parameters.AddWithValue("@CodMedico", codMedico);
                cmd.Parameters.AddWithValue("@data_cirugia", data_cirugia);
                cmd.Parameters.AddWithValue("@hora_cirugia", hora_cirugia);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar actualizar os dados da Marcação de Cirugia!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //              ELIMINAR
        public void eliminarMarcacaoCirugia(int codCirugia)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_delMarcacaoCirugia";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codCirugia", codCirugia);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar eliminar os dados da Marcação de Cirugia!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        // Área para Farmácia
        //      Fornecedor
        //                  Inserir
        public void inserirFornecedor(string nome, int telefone, string endereco, string nacionalidade, string email, DateTime inicio_contrato, DateTime fim_contrato)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_cadFornecedor";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@nacionalidade", nacionalidade);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@inicio_contrato", inicio_contrato);
                cmd.Parameters.AddWithValue("@fim_contrato", fim_contrato);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar adicionar um novo Fornecedor!";
                cmd.Parameters.Clear();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
            
        }
        //                  EDITAR
        public void editarFornecedor(int codFornecedor, string nome, int telefone, string endereco,
            string nacionalidade, string email, DateTime inicio_contrato, DateTime fim_contrato)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_editFornecedor";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codFornecedor", codFornecedor);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                cmd.Parameters.AddWithValue("@nacionalidade", nacionalidade);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@inicio_contrato", inicio_contrato);
                cmd.Parameters.AddWithValue("@fim_contrato", fim_contrato);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Não foi possível actualizar os dados do Fornecedor";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //                  ELIMINAR
        public void eliminarFornecedor(int codFornecedor)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_elFornecedor";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codFornecedor", codFornecedor);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar eliminar os dados do Fornecedor!";
                cmd.Parameters.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }

        //  Medicamento
        //              INSERIR
        public void inserirMedicamento(string nome_comercial, string nome_generico, int quantidade_entrada, DateTime data_validade,
            int quantidade_minima, int quantidade_maxima, int quantidade_inicial, string descricao, int codFornecedor)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_cadMedicamento";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome_comercial", nome_comercial);
                cmd.Parameters.AddWithValue("@nome_generico", nome_generico);
                cmd.Parameters.AddWithValue("@quantidade_inicial", quantidade_inicial);
                cmd.Parameters.AddWithValue("@quantidade_entrada", quantidade_entrada);
                cmd.Parameters.AddWithValue("@data_validade", data_validade);
                cmd.Parameters.AddWithValue("@quantidade_minima", quantidade_minima);
                cmd.Parameters.AddWithValue("@quantidade_maxima", quantidade_maxima);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                cmd.Parameters.AddWithValue("@codFornecedor", codFornecedor);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar adicionar um novo Medicamento!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //              EDITAR
        public void editarMedicamento(int codMedicamento, string nome_comercial, string nome_generico, int quantidade_entrada, DateTime data_validade,
           int quantidade_minima, int quantidade_maxima, int quantidade_inicial, string descricao, int codFornecedor)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_editMedicamento";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codMedicamento", codMedicamento);
                cmd.Parameters.AddWithValue("@nome_comercial", nome_comercial);
                cmd.Parameters.AddWithValue("@nome_generico", nome_generico);
                cmd.Parameters.AddWithValue("@quantidade_inicial", quantidade_inicial);
                cmd.Parameters.AddWithValue("@quantidade_entrada", quantidade_entrada);
                cmd.Parameters.AddWithValue("@data_validade", data_validade);
                cmd.Parameters.AddWithValue("@quantidade_minima", quantidade_minima);
                cmd.Parameters.AddWithValue("@quantidade_maxima", quantidade_maxima);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                cmd.Parameters.AddWithValue("@codFornecedor", codFornecedor);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar actualizar os dados do Medicamento!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //              ELIMINANAR
        public void eliminarMedicamento(int codMedicamento)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_delMedicamento";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codMedicamento", codMedicamento);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar eliminar os dados do Medicamento!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }

        // Procedimento para Saida de Medicamento
        public void saidaMedicamento(string nome_comercial, string nome_generico , int quantidade_inicial)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_saidaMedicamento";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome_comercial", nome_comercial);
                cmd.Parameters.AddWithValue("@nome_generico", nome_generico);
                cmd.Parameters.AddWithValue("@quantidade_inicial", quantidade_inicial);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar efectuar a saida do Medicamento!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }

        //  Material Descartável
        //              INSERIR
        public void inserirMatDescartavel(string nome, int quantidade_entrada, DateTime data_validade,
            int quantidade_minima, int quantidade_maxima, int quantidade_inicial, string descricao, int codFornecedor)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_cadMatDescartavel";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@quantidade_inicial", quantidade_inicial);
                cmd.Parameters.AddWithValue("@quantidade_entrada", quantidade_entrada);
                cmd.Parameters.AddWithValue("@data_validade", data_validade);
                cmd.Parameters.AddWithValue("@quantidade_minima", quantidade_minima);
                cmd.Parameters.AddWithValue("@quantidade_maxima", quantidade_maxima);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                cmd.Parameters.AddWithValue("@codFornecedor", codFornecedor);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar adicionar um novo Material Descartável!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //              EDITAR
        public void editarMatDescartavel(int codMatrial_descartavel, string nome, int quantidade_entrada, DateTime data_validade,
            int quantidade_minima, int quantidade_maxima, int quantidade_inicial, string descricao, int codFornecedor)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_editMatDescartavel";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codMaterialDescartavel", codMatrial_descartavel);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@quantidade_inicial", quantidade_inicial);
                cmd.Parameters.AddWithValue("@quantidade_entrada", quantidade_entrada);
                cmd.Parameters.AddWithValue("@data_validade", data_validade);
                cmd.Parameters.AddWithValue("@quantidade_minima", quantidade_minima);
                cmd.Parameters.AddWithValue("@quantidade_maxima", quantidade_maxima);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                cmd.Parameters.AddWithValue("@codFornecedor", codFornecedor);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar actualizar os dados do Material Descartável!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //              ELIMINANAR
        public void eliminarMatDescartavel(int codMaterial_descartavel)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_delMatDescartavel";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codMaterialDescartavel", codMaterial_descartavel);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar eliminar os dados do Material Descartável!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }

        // Procedimento para Saida de Material Descartável
        public void saidaMatDescartavel(string nome, int quantidade_inicial)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_saidaMatDescartavel";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@quantidade_inicial", quantidade_inicial);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar efectuar a saida do Material Descartável!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }

        //  Tratamento
        //                INSERIR
        public void inserirTratamento(string nome, string descricao)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_cadTratamento";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar adicionar um novo Tratamento!";
                cmd.Parameters.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //        EDITAR
        public void editTratamento(int codTratamento, string nome, string descricao)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_editTratamento";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codTratamento", codTratamento);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar actualizar os dados do Tratamento!";
                cmd.Parameters.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }             
        //              Eliminar
        public void eliminarTratamento(int codTratamento)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_elTratamento";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codTratamento", codTratamento);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar eliminar os dados do Tratamento!";
                cmd.Parameters.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }

        //   Ala Hospitalar
        //              INSERIR
        public void inserirAla_Hospitalar(string nome, string descricao)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_cadAla_Hospitalar";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar adicionar uma nova Sessão Hopitalar!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //              EDITAR
        public void editarAla_Hospitalar(int codAla, string nome, string descricao)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_editAla_Hospitalar";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codAla", codAla);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar actualizar os dados da Sessão Hospitalar!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //              ELIMINAR
        public void eliminarAla_Hospitalar(int codAla)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_delAla_Hospitalar";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codAla", codAla);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar eliminar os dados da Sessão Hospitalar!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }

        //   Exame
        //              INSERIR
        public void inserirExame(string nome, string descricao, int codTipoExame)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_cadExame";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                cmd.Parameters.AddWithValue("@codTipoExame", codTipoExame);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar adicionar um novo Exame!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //              EDITAR
        public void editarExame(int codExame, string nome, string descricao, int codTipoExame)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_editExame";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codExame", codExame);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                cmd.Parameters.AddWithValue("@codTipoExame", codTipoExame);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar actualizar os dados do Exame!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //              ELIMINAR
        public void eliminarExame(int codExame)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_delExame";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codExame", codExame);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar eliminar os dados do Exame!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }

        //   Escola
        //              INSERIR
        public void inserirEscola(string nome, string NIF, int telefone, string endereco)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_cadEscola";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@NIF", NIF);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar adicionar uma nova Escola!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //              EDITAR
        public void editarEscola(int codEscola, string nome, string NIF, int telefone, string endereco)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_editEscola";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codEscola", codEscola);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@NIF", NIF);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@endereco", endereco);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar actualizar os dados da Escola!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //              ELIMINAR
        public void eliminarEscola(int codEscola)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_delEscola";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codEscola", codEscola);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar eliminar os dados da Escola!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }

        //   Especialidade do Médico
        //              INSERIR
        public void inserirEspecialidadeMedico(string nome, string descricao)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_cadEspecialidadeMedico";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar adicionar uma nova Especialidade do Médico!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //              EDITAR
        public void editarEspecialidadeMedico(int codEspecialidade, string nome, string descricao)
            {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_editEspecialidadeMedico";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codEspecialidade", codEspecialidade);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar actualizar os dados da Especialidade do Médico!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //              ELIMINAR
        public void eliminarEspecialidadeMedico(int codEspecialidade)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_delEspecialidadeMedico";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codEspecialidade", codEspecialidade);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar eliminar os dados da Especialidade do Médico!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }

        //   QUARTO
        //              INSERIR
        public void inserirQuarto(string nome, int quantidade_camas, int codAla)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_cadQuarto";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@quantidade_camas", quantidade_camas);
                cmd.Parameters.AddWithValue("@codAla", codAla);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar adicionar um novo Quarto!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //              EDITAR
        public void editarQuarto(int codQuarto, string nome, int quantidade_camas, int codAla)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_editQuarto";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codQuarto", codQuarto);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@quantidade_camas", quantidade_camas);
                cmd.Parameters.AddWithValue("@codAla", codAla);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar actualizar os dados do Quarto!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }
        //              ELIMINAR
        public void eliminarQuarto(int codQuarto)
        {
            cmd.Connection = conect.AbrirConexao();
            try
            {
                cmd.CommandText = "sp_delQuarto";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codQuarto", codQuarto);
                resp = cmd.ExecuteNonQuery() == 1 ? "OK" : "Erro ao tentar eliminar os dados do Quarto!";
                cmd.Parameters.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            finally
            {
                cmd.Connection = conect.FecharConexao();
            }
        }

        // Listas de dados para os ComboBox
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
    }
}
