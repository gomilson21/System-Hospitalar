using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SistemaHospitalar2.Core;

namespace SistemaHospitalar2.Models
{
    class MUsers : Model
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string UserState { get; set; }

        public int EmployeeId { get; set; }

        // extra
        public string NomeFuncao { get; set; }
        public string NomeFuncionario { get; set; }

        public MUsers() { }

        public async Task<bool> findById(int id)
        {
            try
            {
                this.cmd.Connection = await Connection.getInstance();
                this.cmd.CommandType = CommandType.Text;
                this.cmd.CommandText = "select * from [Usuario] where [codUsuario] = @userId";
                this.cmd.Parameters.AddWithValue("@userId", this.Id);
                this.reader = await this.cmd.ExecuteReaderAsync();

                if (this.reader.HasRows)
                {
                    this.reader.Read();

                    this.Login = (string)this.reader["login_usuario"];
                    this.Password = (string)this.reader["senha_usuario"];
                    this.UserState = (string)this.reader["estado_usuario"];
                    this.EmployeeId = (int)this.reader["codFuncionario"];

                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                Connection.Fail = ex;
                return false;
            }
            finally
            {
                cmd.Parameters.Clear();
                this.reader.Close();
            }
        }

        public async Task<bool> findByEmail(int id)
        {
            try
            {
                if (await cmd.ExecuteNonQueryAsync() == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                Connection.Fail = ex;
                return false;
            }
            finally
            {
                cmd.Parameters.Clear();
            }
        }

        public async Task<bool> findAll()
        {
            try
            {
                cmd.Connection = await Connection.getInstance();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from [Usuario]";

                return (await this.cmd.ExecuteNonQueryAsync() == 1) ? true : false;
            }
            catch (Exception ex)
            {
                Connection.Fail = ex;
                return false;
            }
            finally
            {
                cmd.Parameters.Clear();
            }
        }

        public async Task<bool> save()
        {
            if (this.Id == 0)
            {
                cmd.Connection = await Connection.getInstance();
                try
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into [Usuario] ([login_usuario], [senha_usuario], [estado_usuario]," +
                        " [codFuncionario]) values (@login, @password, @userState, @employeeId)";
                    cmd.Parameters.AddWithValue("@login", this.Login);
                    cmd.Parameters.AddWithValue("@password", this.Password);
                    cmd.Parameters.AddWithValue("@userState", this.UserState);
                    cmd.Parameters.AddWithValue("@employeeId", this.EmployeeId);

                    return (await this.cmd.ExecuteNonQueryAsync() == 1) ? true : false;
                }
                catch (Exception ex)
                {
                    Connection.Fail = ex;
                    return false;
                }
                finally
                {
                    cmd.Parameters.Clear();
                }
            }
            else
            {
                try
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE [Usuario] SET [login_usuario] = @login, [senha_usuario] = @password," +
                        " [estado_usuario] = @userState,[codFuncionario] = @employeeId WHERE [codUsuario] = @userId";
                    cmd.Parameters.AddWithValue("@login", this.Login);
                    cmd.Parameters.AddWithValue("@password", this.Password);
                    cmd.Parameters.AddWithValue("@userState", this.UserState);
                    cmd.Parameters.AddWithValue("@employeeId", this.EmployeeId);
                    cmd.Parameters.AddWithValue("@userId", this.Id);

                    return (await this.cmd.ExecuteNonQueryAsync() == 1) ? true : false;
                }
                catch (Exception ex)
                {
                    Connection.Fail = ex;
                    return false;
                }
                finally
                {
                    cmd.Parameters.Clear();
                }
            }
        }

        public async Task<bool> delete()
        {
            try
            {
                this.cmd.CommandType = CommandType.Text;
                this.cmd.CommandText = "delete from [Usuario] where [codUsuario] = @userId";
                this.cmd.Parameters.AddWithValue("@userId", this.Id);

                return (await this.cmd.ExecuteNonQueryAsync() == 1) ? true : false;
            }
            catch (Exception ex)
            {
                Connection.Fail = ex;
                return false;
            }
            finally
            {
                this.cmd.Parameters.Clear();
            }
        }

        public async Task<bool> login()
        {
            try
            {
                this.cmd.Connection = await Connection.getInstance();
                this.cmd.CommandType = CommandType.Text;
                this.cmd.CommandText = "SELECT [login_usuario], [senha_usuario], [estado_usuario], [nome_funcionario]," +
                    " [nome_funcao] FROM [Usuario] INNER JOIN [Funcionarios] ON (Usuario.codFuncionario =" +
                    " Funcionarios.codFuncionario) INNER JOIN [Funcao] ON (Funcionarios.codFuncao =" +
                    " Funcao.codFuncao) WHERE [login_usuario] = @login AND [senha_usuario] = @password";
                this.cmd.Parameters.AddWithValue("@login", this.Login);
                this.cmd.Parameters.AddWithValue("@password", this.Password);
                this.reader = await this.cmd.ExecuteReaderAsync(); 

                if (this.reader.HasRows)
                {
                    await this.reader.ReadAsync();
                    
                    this.UserState = (string)this.reader["estado_usuario"];
                    this.NomeFuncao = (string)reader["nome_funcao"];
                    this.NomeFuncionario = (string)this.reader["nome_funcao"];

                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                Connection.Fail = ex;
                return false;
            }
            finally
            {
                this.cmd.Parameters.Clear();
                this.reader.Close();
            }
        }

        public async Task<DataTable> listUsers()
        {
            this.cmd.Connection = await Connection.getInstance();
            this.cmd.CommandType = CommandType.Text;
            this.cmd.CommandText = "SELECT codUsuario, login_usuario, senha_usuario, estado_usuario, "+
                " nome_funcionario, nome_funcao FROM Usuario INNER JOIN Funcionarios ON (Usuario.codFuncionario "+
                "= Funcionarios.codFuncionario) INNER JOIN Funcao ON (Funcionarios.codFuncao = Funcao.codFuncao)";
            this.reader = await  this.cmd.ExecuteReaderAsync();
            this.table.Load(this.reader);
            this.reader.Close();
            return this.table;
        }
    }
}
