using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using SistemaHospitalar2.Controllers;

namespace SistemaHospitalar2
{
    public partial class frmLogin : Form
    {
        public Users obj;
        private Login lg; 

        public frmLogin()
        {
            InitializeComponent();

            this.obj = new Users();
            this.lg = new Login();
        }
        public int tentativa = 3;

        // Método Logar
        public void Logar()
        {
            this.lg.Logar(this.txtLogin.Text, this.txtSenha.Text);
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
            if(txtLogin.Text == string.Empty)
            {
                MessageBox.Show("O campo usuário é obrigatório!", "Hospital EG Esperança", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLogin.Focus();
            }
            else if(txtSenha.Text == string.Empty)
            {
                MessageBox.Show("O campo senha é obrigatório!", "Hospital EG Esperança", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
