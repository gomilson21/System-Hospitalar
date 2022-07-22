using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaHospitalar2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public int tentativa = 3;

        // Método Logar
        public void Logar()
        {
            string estado_usuario = "Activo";
            string funcao_usuario = "Administrativo";
            SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");
            Sqlcon.Open();

            try
            {
                DataTable dados = new DataTable();
                SqlDataAdapter Adpter = new SqlDataAdapter("SELECT * FROM Usuario WHERE login_usuario = @login AND senha_usuario = @senha AND estado_usuario = @estado_usuario", Sqlcon);
                Adpter.SelectCommand.Parameters.AddWithValue("@login", txtLogin.Text);
                Adpter.SelectCommand.Parameters.AddWithValue("@senha", txtSenha.Text);
                Adpter.SelectCommand.Parameters.AddWithValue("@estado_usuario", estado_usuario);
                Adpter.Fill(dados);
                Adpter.Dispose();

                //Verificando o login
                if (tentativa != 0)
                {
                    if (dados.Rows.Count == 0)
                    {
                        if(estado_usuario != "Activo")
                            MessageBox.Show("A conta deste Usuário está Inactiva! Consulte o Administrador.", "Conta Inactiva", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                        {
                            MessageBox.Show("Login errado", "Erro ao Logar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tentativa -= 1;
                            lblTentativa.Text = "Tentativa restante " + tentativa;

                            if (tentativa == 0)
                                btnEntar.Enabled = false;
                        }
                    }
                    else
                    {
                        DataTable dados1 = new DataTable();
                        SqlDataAdapter Adpter1 = new SqlDataAdapter("SELECT login_usuario, nome_funcao FROM Usuario INNER JOIN Funcionarios ON (Usuario.codFuncionario = Funcionarios.codFuncionario) INNER JOIN Funcao ON (Funcionarios.codFuncao = Funcao.codFuncao) WHERE login_usuario = @login AND nome_funcao = @funcao", Sqlcon);
                        Adpter1.SelectCommand.Parameters.AddWithValue("@login", txtLogin.Text);
                        Adpter1.SelectCommand.Parameters.AddWithValue("@funcao", funcao_usuario);
                        Adpter1.Fill(dados1);
                        Adpter1.Dispose();

                        if (dados1.Rows.Count == 0)
                        {
                            funcao_usuario = "Catalogador";
                            if (Referencias_Formularios.dash == null)
                                Referencias_Formularios.dash = new frmDashboard();

                            this.Hide();
                            Referencias_Formularios.dash.cadastarToolStripMenuItem.Visible = false;
                            Referencias_Formularios.dash.Show();
                            Referencias_Formularios.dash.Focus();
                            Referencias_Formularios.dash.toolStripStatusLabel1.Text = "Nome do Usuário: " + txtLogin.Text;
                            Referencias_Formularios.dash.toolStripStatusLabel2.Text = "Funcão do Usuário: " + funcao_usuario;
                        }
                        else
                        {
                            if (Referencias_Formularios.dash == null)
                                Referencias_Formularios.dash = new frmDashboard();

                            this.Hide();
                            Referencias_Formularios.dash.cadastarToolStripMenuItem.Visible = true;
                            Referencias_Formularios.dash.Show();
                            Referencias_Formularios.dash.Focus();
                            Referencias_Formularios.dash.toolStripStatusLabel1.Text = "Nome do Usuário: " + txtLogin.Text;
                            Referencias_Formularios.dash.toolStripStatusLabel2.Text = "Funcão do Usuário: " + funcao_usuario;
                        }
                    }
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro + "Erro ao aceder ao banco de dados", "            Erro no Banco de Dados", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open)
                    Sqlcon.Close();
            }
            
        }

        // Método Mostrar Senha
        public void MostrarOcultar_Senha()
        {
            if (txtSenha.UseSystemPasswordChar == true)
            {
                txtSenha.UseSystemPasswordChar = false;
                btnMostrar.Hide();
                btnOcultar.Show();
                txtSenha.Focus();
            }   
            else
            {
                txtSenha.UseSystemPasswordChar = true;
                btnMostrar.Show();
                btnOcultar.Hide();
                txtSenha.Focus();
            }
        }

        //Eventos
        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblTentativa.Text = "Tentativas restantes 3";
            txtSenha.UseSystemPasswordChar = true;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarOcultar_Senha();
        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            this.MostrarOcultar_Senha();
        }

        private void btnEntar_Click(object sender, EventArgs e)
        {
            if(txtLogin.Text == String.Empty)
            {
                MessageBox.Show("O campo usuário é obrigatório!", "Hospital EG Esperança", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLogin.Text = String.Empty;
                txtLogin.Focus();
            }
            else if(txtSenha.Text == String.Empty)
            {
                MessageBox.Show("O campo senha é obrigatório!", "Hospital EG Esperança", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Text = String.Empty;
                txtSenha.Focus();
            }
            else
            {
                Logar(); 
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (txtLogin.Text == String.Empty)
                {
                    MessageBox.Show("O campo usuário é obrigatório!", "Hospital EG Esperança", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLogin.Text = String.Empty;
                    txtLogin.Focus();
                }
                else if (txtSenha.Text == String.Empty)
                {
                    MessageBox.Show("O campo senha é obrigatório!", "Hospital EG Esperança", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSenha.Focus();
                }
                else
                {
                    Logar();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.recuperarSenha == null)
                Referencias_Formularios.recuperarSenha = new frmRecuperarSenha();

            Referencias_Formularios.recuperarSenha.Show();
            Referencias_Formularios.recuperarSenha.Focus();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.login = null;
        }
    }
}
