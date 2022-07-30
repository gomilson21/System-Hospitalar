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
    public partial class frmConsultarUsuario : Form
    {
        public frmConsultarUsuario()
        {
            InitializeComponent();
        }
        Dados.Listar dados = new Dados.Listar();
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");
        DataTable dados1;
        SqlDataAdapter Adapter;

        public void CarregarDados()
        {
            usuarioDataGridView.DataSource = dados.ListarUsuario();
        }
        //  Login do Usuario
        public void PesquisarLoginUsuario()
        {
            dados1 = new DataTable();
            Adapter = new SqlDataAdapter("SELECT codUsuario, login_usuario, senha_usuario, confirmar_senha, estado_usuario, nome_funcionario, nome_funcao FROM Usuario inner join Funcionarios ON (Usuario.codFuncionario = Funcionarios.codFuncionario) INNER JOIN Funcao ON (Funcionarios.codFuncao = Funcao.codFuncao) WHERE login_usuario LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adapter.Fill(dados1);
            usuarioDataGridView.DataSource = dados1;
        }
        //  Login do Usuario
        public void PesquisarNomeFuncionario()
        {
            dados1 = new DataTable();
            Adapter = new SqlDataAdapter("SELECT codUsuario, login_usuario, senha_usuario, confirmar_senha, estado_usuario, nome_funcionario, nome_funcao FROM Usuario inner join Funcionarios ON (Usuario.codFuncionario = Funcionarios.codFuncionario) INNER JOIN Funcao ON (Funcionarios.codFuncao = Funcao.codFuncao) WHERE nome_funcionario LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adapter.Fill(dados1);
            usuarioDataGridView.DataSource = dados1;
        }
        //  Login do Usuario
        public void PesquisarNomeFuncao()
        {
            dados1 = new DataTable();
            Adapter = new SqlDataAdapter("SELECT codUsuario, login_usuario, senha_usuario, confirmar_senha, estado_usuario, nome_funcionario, nome_funcao FROM Usuario inner join Funcionarios ON (Usuario.codFuncionario = Funcionarios.codFuncionario) INNER JOIN Funcao ON (Funcionarios.codFuncao = Funcao.codFuncao) WHERE nome_funcao LIKE '%" + txtPesquisa.Text + "%'", Sqlcon);
            Adapter.Fill(dados1);
            usuarioDataGridView.DataSource = dados1;
        }

        private void frmConsultarUsuario_Load(object sender, EventArgs e)
        {
            // Carregar os dados do Usuário no DataGridView
            this.CarregarDados();
            cbFormaPesquisa.SelectedItem = "Login do Usuário";
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (cbFormaPesquisa.SelectedItem.Equals("Login do Usuário"))
                this.PesquisarLoginUsuario();
            else if (cbFormaPesquisa.SelectedItem.Equals("Nome do Funcionário"))
                this.PesquisarNomeFuncionario();
            else if (cbFormaPesquisa.SelectedItem.Equals("Nome da Função"))
                this.PesquisarNomeFuncao();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConsultarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.conUsuario = null;
        }
    }
}
