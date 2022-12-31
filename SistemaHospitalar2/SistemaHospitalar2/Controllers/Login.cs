using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaHospitalar2.Models;
using SistemaHospitalar2.Core;
using SistemaHospitalar2.Support;

namespace SistemaHospitalar2.Controllers
{
    class Login
    {
        public MUsers obj;

        public Login()
        {
            this.obj = new MUsers();
        }

        public async void Logar(string login, string password)
        {
            this.obj.Login = login;
            this.obj.Password = Password.encryptPassword(password);

            if (await this.obj.login())
            {
                if (this.obj.NomeFuncao == "Administrativo" && this.obj.UserState == "Activo")
                {
                    Message.success("Bem-Vindo " + this.obj.Login + " " + this.obj.NomeFuncao);

                    if (InstanceForm.dash == null)
                        InstanceForm.dash = new frmDashboard();

                    InstanceForm.login.Hide();
                    InstanceForm.dash.cadastarToolStripMenuItem.Visible = true;
                    InstanceForm.dash.Show();
                    InstanceForm.dash.Focus();
                    InstanceForm.dash.toolStripStatusLabel1.Text = "Nome do Usuário: " + this.obj.Login;
                    InstanceForm.dash.toolStripStatusLabel2.Text = "Funcão do Usuário: " + this.obj.NomeFuncao;
                }
                else if (this.obj.NomeFuncao == "Catalogador" && this.obj.UserState == "Activo")
                {
                    Message.success("Bem-Vindo " + this.obj.Login + " " + this.obj.NomeFuncao);

                    if (InstanceForm.dash == null)
                        InstanceForm.dash = new frmDashboard();

                    InstanceForm.login.Hide();
                    InstanceForm.dash.cadastarToolStripMenuItem.Visible = false;
                    InstanceForm.dash.Show();
                    InstanceForm.dash.Focus();
                    InstanceForm.dash.toolStripStatusLabel1.Text = "Nome do Usuário: " + this.obj.Login;
                    InstanceForm.dash.toolStripStatusLabel2.Text = "Funcão do Usuário: " + this.obj.NomeFuncao;
                }
            }    
            else if (Connection.Fail != null)
            {
                Message.exception(Connection.Fail.Message, "Erro ao aceder ao Base de Dados");
                Connection.Fail = null;
            }
            else
                Message.error("Nome do usuário ou senha incorrecto!");
        }

    }
}
