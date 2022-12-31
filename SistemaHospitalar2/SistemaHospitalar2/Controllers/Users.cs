using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaHospitalar2.Core;
using SistemaHospitalar2.Models;
using System.Data;

namespace SistemaHospitalar2.Controllers
{
    public class Users
    {
        private MUsers obj;

        public Users()
        {
            this.obj = new MUsers();
        }

        public async void create(string login, string password, string confirmPassword,
            string stateUser, int employeeId)
        {
            this.obj.Id = 0;
            this.obj.Login = login;
            this.obj.Password = Password.encryptPassword(password);
            this.obj.UserState = stateUser;
            this.obj.EmployeeId = employeeId;

            if (await this.obj.save())
                Message.success("Novo usuário cadastrado com sucesso!");
            else if (Connection.Fail != null)
            {
                Message.exception(Connection.Fail.Message);
                Connection.Fail = null;
            }
            else
                Message.error("Erro ao cadastrar um novo usuário!");        
        }

        public async void update(int id, string login, string password, string confirmPassword,
            string stateUser, int employeeId)
        {
            this.obj.Id = id;
            if (!await this.obj.findById(this.obj.Id))
            {
                Message.warning("Não existe usuário com esse id!");
            }
            else
            {
                if (await this.obj.save())
                    Message.success("Dados do usuário actaulizados com sucesso!");
                else if (Connection.Fail != null)
                {
                    Message.exception(Connection.Fail.Message);
                    Connection.Fail = null;
                }
                else
                    Message.error("Erro ao actualizados os dados do usuario!");
            }
        }

        public async void delete(int id)
        {
            this.obj.Id = id;
            if (!await this.obj.findById(this.obj.Id))
            {
                Message.warning("Não existe usuário com esse " + this.obj.Id + " !");
            }
            else
            {
                if (await this.obj.delete())
                     Message.error("Dados do usuários deletados com sucesso!");
                else if (Connection.Fail != null)
                {
                    Message.exception(Connection.Fail.Message);
                    Connection.Fail = null;
                }
                else
                   Message.error("Erro ao deletar os dados do usuário!");
            }
        }

        public async Task<DataTable> list()
        {
           return await this.obj.listUsers();      
        }
    }
}
