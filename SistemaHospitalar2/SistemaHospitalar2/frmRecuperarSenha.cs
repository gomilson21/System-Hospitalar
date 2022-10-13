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
    public partial class frmRecuperarSenha : Form
    {
        public frmRecuperarSenha()
        {
            InitializeComponent();
        }
        public bool confirmar = false;
        Crudes recuperar = new Crudes();

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            recuperar.RecuperarSenha(txtLogin.Text, txtNovaSenha.Text, txtConfirmarSenha.Text);
            if (recuperar.resp == "OK")
            {
                if (txtNovaSenha.Text == txtConfirmarSenha.Text)
                {
                    MessageBox.Show("A senha foi alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    confirmar = true;
                }                
                else
                    MessageBox.Show("É necessário que o valor do campo nova senha seja igual ao campo confirmar senha!",
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(recuperar.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
        }

        private void frmRecuperarSenha_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.recuperarSenha = null;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();

            if (confirmar)
            {
                Referencias_Formularios.login.lblTentativa.Text = "Tentativas restantes 3";
                Referencias_Formularios.login.txtLogin.Clear();
                Referencias_Formularios.login.txtSenha.Clear();
                Referencias_Formularios.login.tentativa = 3;
                Referencias_Formularios.login.btnEntar.Enabled = true;
            }
        }
    }
}
