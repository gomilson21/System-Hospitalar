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
    public partial class frmCadastrarUsuario : Form
    {
        public frmCadastrarUsuario()
        {
            InitializeComponent();
        }

        Crudes usuario = new Crudes();
        Dados.Listar dados = new Dados.Listar();
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");

        private string operacao = "inserir";
        private string codigo;
        
        private void ListarFuncionarios()
        {
            cbCodFuncionarios.DataSource = dados.ComboBoxListarFuncionario_Usuario();
            cbCodFuncionarios.DisplayMember = "nome_funcionario";
            cbCodFuncionarios.ValueMember = "codFuncionario";
        }

        private void CarregarDados()
        {
            usuarioDataGridView.DataSource = dados.ListarUsuario();
        }

        public void BuscarCodigo()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codUsuario, login_usuario, senha_usuario, confirmar_senha, estado_usuario, nome_funcionario FROM Usuario INNER JOIN  Funcionarios ON (Usuario.codFuncionario = Funcionarios.codFuncionario) WHERE codUsuario = " + Convert.ToInt32(txtBuscarCodigo.Text), Sqlcon);
            Adpter.Fill(dados);
            usuarioDataGridView.DataSource = dados;
        }

        public void BuscarNome()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT codUsuario, login_usuario, senha_usuario, confirmar_senha, estado_usuario, nome_funcionario FROM Usuario INNER JOIN  Funcionarios ON (Usuario.codFuncionario = Funcionarios.codFuncionario) WHERE login_usuario LIKE '%" + txtBuscarNome.Text +"%'", Sqlcon);
            Adapter.Fill(dados);
            usuarioDataGridView.DataSource = dados;
        }

        public void DesabilitarBotao()
        {
            btnNovo.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = true;

            loginTextBox.ReadOnly = true;
            senhaTextBox.ReadOnly = true;
            confirmar_senhaTextBox.ReadOnly = true;
        }

        public void HabilitarBotao()
        {
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;

            loginTextBox.ReadOnly = false;
            senhaTextBox.ReadOnly = false;
            confirmar_senhaTextBox.ReadOnly = false;
        }

        private void frmCadastrarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_HospitalDataSet.Funcionarios' table. You can move, or remove it, as needed.
            this.ListarFuncionarios();
            // Carregar os dados do Usuário no DataGridView
            this.CarregarDados();
            this.DesabilitarBotao();
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            codUsuarioTextBox.Clear();
            loginTextBox.Clear();
            senhaTextBox.Clear();
            confirmar_senhaTextBox.Clear();
            txtBuscarCodigo.Clear();
            txtBuscarNome.Clear();

            loginTextBox.Focus();
            this.HabilitarBotao();
        }        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(usuarioDataGridView.SelectedRows.Count > 0)
            {
                operacao = "editar";
                codigo = usuarioDataGridView.CurrentRow.Cells[0].Value.ToString();
                loginTextBox.Text = usuarioDataGridView.CurrentRow.Cells[1].Value.ToString();
                senhaTextBox.Text = usuarioDataGridView.CurrentRow.Cells[2].Value.ToString();
                confirmar_senhaTextBox.Text = usuarioDataGridView.CurrentRow.Cells[3].Value.ToString();
                estado_usuarioComboBox.Text = usuarioDataGridView.CurrentRow.Cells[4].Value.ToString();
                cbCodFuncionarios.Text = usuarioDataGridView.CurrentRow.Cells[5].Value.ToString();
                this.HabilitarBotao();
            }
            else
            {
                MessageBox.Show("Seleciona uma linha para poder editar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(usuarioDataGridView.SelectedRows.Count > 0)
            {
                if(MessageBox.Show("Tem certeza que deseja excluir estes dados", "Hospital EG Esperança",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    codigo = usuarioDataGridView.CurrentRow.Cells[0].Value.ToString();
                    usuario.eliminarUsuario(Convert.ToInt32(codigo));
                    if (usuario.resp == "OK")
                    {
                        MessageBox.Show("Dados do usuário eliminados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarDados();
                    }
                    else
                        MessageBox.Show(usuario.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleciona uma linha para poder Eliminar!", "Hospital EG Esperança", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (senhaTextBox.TextLength < 8)
            {
                MessageBox.Show("É obrigatório que o campo de senha tenha 8 ou mais caracteres!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProvider1.SetError(senhaTextBox, "Quantidade de caracteres inválidos!");
                senhaTextBox.Focus();
            }
            else if (senhaTextBox.Text != confirmar_senhaTextBox.Text)
            {
                MessageBox.Show("É necessário que o valor do campo senha seje igual ao valor do campo confirmar senha!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(confirmar_senhaTextBox, "Insira senha correcta!");
                confirmar_senhaTextBox.Focus();
            }
            else
            {
                SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");
                Sqlcon.Open();
                //  Verificando Existência do Login do Usuário
                DataTable dados = new DataTable();
                SqlDataAdapter Adpter = new SqlDataAdapter("SELECT * FROM Usuario WHERE login_usuario = @login ", Sqlcon);
                Adpter.SelectCommand.Parameters.AddWithValue("@login", loginTextBox.Text);
                Adpter.Fill(dados);
                Adpter.Dispose();
                //  Verificando Existência do Login do Usuário
                DataTable dados1 = new DataTable();
                SqlDataAdapter Adpter1 = new SqlDataAdapter("SELECT * FROM Usuario WHERE codFuncionario = @codFuncionario ", Sqlcon);
                Adpter1.SelectCommand.Parameters.AddWithValue("@codFuncionario", Convert.ToInt32(cbCodFuncionarios.SelectedValue));
                Adpter1.Fill(dados1);
                Adpter1.Dispose();

                Sqlcon.Close();

                if (operacao == "inserir")
                {
                    if (dados.Rows.Count != 0)
                    {
                        MessageBox.Show("Este Login já existe na base de dados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        errorProvider1.SetError(loginTextBox, "Este Login já existe na base de dados!");
                        loginTextBox.Focus();
                    }
                    else if (dados1.Rows.Count != 0)
                    {
                        MessageBox.Show("Este Funcionário já possui uma conta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        errorProvider1.SetError(cbCodFuncionarios, "Este Funcionário já possui uma conta!");
                        cbCodFuncionarios.Focus();
                    }
                    else
                    {
                        usuario.inserirUsuario(loginTextBox.Text.Trim(), senhaTextBox.Text.Trim(), confirmar_senhaTextBox.Text, Convert.ToString(estado_usuarioComboBox.SelectedItem), Convert.ToInt32(cbCodFuncionarios.SelectedValue));
                        if (usuario.resp.Equals("OK"))
                        {
                            MessageBox.Show("Novo Usuário Adicionado!", "Hospital EG Esperança", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.CarregarDados();
                            this.DesabilitarBotao();
                        }
                        else
                            MessageBox.Show(usuario.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (operacao.Equals("editar"))
                {

                    if (dados.Rows.Count != 1)
                    {
                        MessageBox.Show("Este Login já existe na base de dados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        errorProvider1.SetError(loginTextBox, "Este Login já existe na base de dados!");
                        loginTextBox.Focus();
                    }
                    else if (dados1.Rows.Count != 1)
                    {
                        MessageBox.Show("Este Funcionário já possui uma conta!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        errorProvider1.SetError(cbCodFuncionarios, "Este Funcionário já possui uma conta!");
                        cbCodFuncionarios.Focus();
                    }
                    else
                    {
                        if (MessageBox.Show("Tem certeza que deseja continuar com as alterações feitas?", "Hospital EG Esperança",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            usuario.editarUsuario(Convert.ToInt32(codigo), loginTextBox.Text.Trim(), senhaTextBox.Text.Trim(),
                                confirmar_senhaTextBox.Text, Convert.ToString(estado_usuarioComboBox.SelectedItem), Convert.ToInt32(cbCodFuncionarios.SelectedValue));
                            if (usuario.resp.Equals("OK"))
                            {
                                MessageBox.Show("Dados do Usuário actualizados com sucesso!", "Hospital EG Esperança",
                                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.CarregarDados();
                                operacao = "inserir";
                            }
                            else
                                MessageBox.Show(usuario.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.DesabilitarBotao();
                        }
                    }
                }     
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastrarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.cadUsuario = null;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscarCodigo.Text == string.Empty)
                MessageBox.Show("Insira um código!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                this.BuscarCodigo();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtBuscarCodigo.Clear();
            txtBuscarNome.Clear();
            this.CarregarDados();
            this.ListarFuncionarios();
        }

        private void txtBuscarNome_TextChanged_1(object sender, EventArgs e)
        {
            this.BuscarNome();
        }

        private void txtBuscarCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void usuarioDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codUsuarioTextBox.Text = usuarioDataGridView.CurrentRow.Cells[0].Value.ToString();
            loginTextBox.Text = usuarioDataGridView.CurrentRow.Cells[1].Value.ToString();
            senhaTextBox.Text = usuarioDataGridView.CurrentRow.Cells[2].Value.ToString();
            confirmar_senhaTextBox.Text = usuarioDataGridView.CurrentRow.Cells[3].Value.ToString();
            estado_usuarioComboBox.Text = usuarioDataGridView.CurrentRow.Cells[4].Value.ToString();
            cbCodFuncionarios.Text = usuarioDataGridView.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
