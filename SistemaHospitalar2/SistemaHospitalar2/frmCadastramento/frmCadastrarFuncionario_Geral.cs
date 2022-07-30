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
    public partial class frmCadastrarFuncionarioGeral : Form
    {
        public frmCadastrarFuncionarioGeral()
        {
            InitializeComponent();
        }
        Crudes funcionarios = new Crudes();
        Dados.Listar dados = new Dados.Listar();
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");
        private string operacao = "inserir";
        private string codigo;

        public void ListarFuncao()
        {
            cbCodFuncao.DataSource = dados.ComboBoxListarFuncao();
            cbCodFuncao.DisplayMember = "nome_funcao";
            cbCodFuncao.ValueMember = "codFuncao";
        }

        public void CarregarDados()
        {
            funcionarioGeralDataGridView.DataSource = dados.ListarFuncionario();
        }

        public void BuscarCodigo()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codFuncionario, nome_funcionario, dataNascimento_funcionario, sexo_funcionario, BI_funcionario, email_funcionario, telefone_funcionario, endereco_funcionario, numeroCarteira_funcionario, dataAdmissao_funcionario, nome_funcao FROM Funcionarios INNER JOIN Funcao ON (Funcionarios.codFuncao = Funcao.codFuncao) WHERE codFuncionario = " + Convert.ToInt32(txtBuscarCodigo.Text), Sqlcon);
            Adpter.Fill(dados);
            funcionarioGeralDataGridView.DataSource = dados;
        }

        public void BuscarNome()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT codFuncionario, nome_funcionario, dataNascimento_funcionario, sexo_funcionario, BI_funcionario, email_funcionario, telefone_funcionario, endereco_funcionario, numeroCarteira_funcionario, dataAdmissao_funcionario, nome_funcao FROM Funcionarios INNER JOIN Funcao ON (Funcionarios.codFuncao = Funcao.codFuncao) WHERE nome_funcionario LIKE '%" + txtBuscarNome.Text + "%'", Sqlcon);
            Adapter.Fill(dados);
            funcionarioGeralDataGridView.DataSource = dados;
        }

        public void DesabilitarBotao()
        {
            this.btnNovo.Enabled = true;
            this.btnExcluir.Enabled = true;
            this.btnSalvar.Enabled = false;
            this.btnEditar.Enabled = true;

            //  Habilitar textBox
            nomeTextBox.ReadOnly = true;
            bITextBox.ReadOnly = true;
            emailTextBox.ReadOnly = true;
            numero_carteiraTextBox.ReadOnly = true;
            telefoneTextBox.ReadOnly = true;
            enderecoTextBox.ReadOnly = true;
        }

        public void HabilitarBotao()
        {
            this.btnNovo.Enabled = false;
            this.btnExcluir.Enabled = false;
            this.btnSalvar.Enabled = true;
            this.btnEditar.Enabled = false;

            //  Habilitar textBox
            nomeTextBox.ReadOnly = false;
            bITextBox.ReadOnly = false;
            emailTextBox.ReadOnly = false;
            numero_carteiraTextBox.ReadOnly = false;
            telefoneTextBox.ReadOnly = false;
            enderecoTextBox.ReadOnly = false;   
        }

        private void frmCadastrarAdministrativo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_HospitalDataSet.Funcao' table. You can move, or remove it, as needed.
            this.ListarFuncao();
            cbSexo.SelectedItem = "M";
            // Carregarr dados do Funcionário no DataGridView
            this.CarregarDados();
            this.DesabilitarBotao();
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            codFuncionarioTextBox.Clear();
            nomeTextBox.Clear();
            emailTextBox.Clear();
            numero_carteiraTextBox.Clear();
            telefoneTextBox.Clear();
            enderecoTextBox.Clear();
            bITextBox.Clear();

            nomeTextBox.Focus();
            this.HabilitarBotao();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(funcionarioGeralDataGridView.SelectedRows.Count > 0)
            {
                operacao = "editar";
                codigo = funcionarioGeralDataGridView.CurrentRow.Cells[0].Value.ToString();
                nomeTextBox.Text = funcionarioGeralDataGridView.CurrentRow.Cells[1].Value.ToString();
                data_nascimentoDateTimePicker.Text = funcionarioGeralDataGridView.CurrentRow.Cells[2].Value.ToString();
                cbSexo.Text = funcionarioGeralDataGridView.CurrentRow.Cells[3].Value.ToString();
                bITextBox.Text = funcionarioGeralDataGridView.CurrentRow.Cells[4].Value.ToString();
                emailTextBox.Text = funcionarioGeralDataGridView.CurrentRow.Cells[5].Value.ToString();
                telefoneTextBox.Text = funcionarioGeralDataGridView.CurrentRow.Cells[6].Value.ToString();
                enderecoTextBox.Text = funcionarioGeralDataGridView.CurrentRow.Cells[7].Value.ToString();
                numero_carteiraTextBox.Text = funcionarioGeralDataGridView.CurrentRow.Cells[8].Value.ToString();
                data_admissaoDateTimePicker.Text = funcionarioGeralDataGridView.CurrentRow.Cells[9].Value.ToString();
                cbCodFuncao.Text = funcionarioGeralDataGridView.CurrentRow.Cells[10].Value.ToString();
                this.HabilitarBotao();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para poderes editar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(funcionarioGeralDataGridView.SelectedRows.Count > 0)
            {
                if(MessageBox.Show("Tem certeza que deseja eliminar este dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    codigo = funcionarioGeralDataGridView.CurrentRow.Cells[0].Value.ToString();
                    Sqlcon.Open();
                    DataTable tabela = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Usuario WHERE codFuncionario = '" + Convert.ToInt32(codigo) + "'", Sqlcon);
                    adapter.Fill(tabela);
                    adapter.Dispose();
                    Sqlcon.Close();

                    if (tabela.Rows.Count > 0)
                    {
                        MessageBox.Show("Este Funcionário não pode ser eliminado porque possui ligação com um Usuário!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        funcionarios.eliminarFuncionario(Convert.ToInt32(codigo));
                        if (funcionarios.resp.Equals("OK"))
                        {
                            MessageBox.Show("Dados do funcionario eliminado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.CarregarDados();
                        }
                        else
                            MessageBox.Show(funcionarios.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para poderes eliminar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Data de Nascimento
            if (data_nascimentoDateTimePicker.Value.Year > 2004 || data_nascimentoDateTimePicker.Value.Year < 1982)
            {
                MessageBox.Show("Data de Nascimento inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(data_nascimentoDateTimePicker, "Data de Nascimento inválida!");
                data_nascimentoDateTimePicker.Focus();
            }
            // Número do BI
            else if (bITextBox.TextLength != 14)
            {
                MessageBox.Show("Número do BI inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(bITextBox, "Número do BI inválido!");
                bITextBox.Focus();
            }
            // Endereço de Email
            else if (!emailTextBox.Text.EndsWith("@gmail.com") && !emailTextBox.Text.EndsWith("@hotmail.com"))
            {
                MessageBox.Show("Endereço de Email inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(emailTextBox, "Número do BI inválido!");
                emailTextBox.Focus();
            }
            // Número do Telefone
            else if (telefoneTextBox.TextLength != 9 || !telefoneTextBox.Text.StartsWith("9"))
            {
                MessageBox.Show("Número de telefone inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(telefoneTextBox, "Número de telefone inválido!");
                telefoneTextBox.Focus();
            }
            // Data de Admissão
            else if (data_admissaoDateTimePicker.Value != DateTime.Now)
            {
                MessageBox.Show("Data de Admissão inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(data_admissaoDateTimePicker, "Data de Admissão inválida!");
                data_admissaoDateTimePicker.Focus();
            }
            else
            {
                SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");
                Sqlcon.Open();
                //  Verificando Existência do Número do BI do Funcionario
                DataTable dados = new DataTable();
                SqlDataAdapter Adpter = new SqlDataAdapter("SELECT * FROM Funcionarios WHERE BI_funcionario = @BI ", Sqlcon);
                Adpter.SelectCommand.Parameters.AddWithValue("@BI", bITextBox.Text.ToUpper());
                Adpter.Fill(dados);
                Adpter.Dispose();
                //  Verificando Existência do Endereço de Email do Funcionario
                DataTable dados1 = new DataTable();
                SqlDataAdapter Adpter1 = new SqlDataAdapter("SELECT * FROM Funcionarios WHERE email_funcionario = @email ", Sqlcon);
                Adpter1.SelectCommand.Parameters.AddWithValue("@email", emailTextBox.Text.ToLower());
                Adpter1.Fill(dados1);
                Adpter1.Dispose();
                //  Verificando Existência do Númrero da Carteira do Funcionario
                DataTable dados2 = new DataTable();
                SqlDataAdapter Adpter2 = new SqlDataAdapter("SELECT * FROM Funcionarios WHERE numeroCarteira_funcionario = @numero_carteira ", Sqlcon);
                Adpter2.SelectCommand.Parameters.AddWithValue("@numero_carteira", numero_carteiraTextBox.Text);
                Adpter2.Fill(dados2);
                Adpter2.Dispose();
                //  Verificando Existência do Númrero de Telefone do Funcionario
                DataTable dados3 = new DataTable();
                SqlDataAdapter Adpter3 = new SqlDataAdapter("SELECT * FROM Funcionarios WHERE telefone_funcionario = @telefone ", Sqlcon);
                Adpter3.SelectCommand.Parameters.AddWithValue("@telefone", Convert.ToInt32(telefoneTextBox.Text));
                Adpter3.Fill(dados3);
                Adpter3.Dispose();

                Sqlcon.Close();
                if (operacao.Equals("inserir"))
                {
                    if (dados.Rows.Count != 0)
                    {
                        MessageBox.Show("Este Número de BI já existe na base de dados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        errorProvider1.SetError(bITextBox, "Este Número de BI já existe na base de dados!");
                        bITextBox.Focus();
                    }
                    else if (dados1.Rows.Count != 0)
                    {
                        MessageBox.Show("Este Endereço de Email já existe na base de dados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        errorProvider1.SetError(emailTextBox, "Este Endereço de Email já existe na base de dados!");
                        emailTextBox.Focus();
                    }
                    else if (dados2.Rows.Count != 0)
                    {
                        MessageBox.Show("Este Número da Carteira já existe na base de dados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        errorProvider1.SetError(numero_carteiraTextBox, "Este Número da Carteira já existe na base de dados!");
                        numero_carteiraTextBox.Focus();
                    }
                    else if (dados3.Rows.Count != 0)
                    {
                        MessageBox.Show("Este Número de Telefone já existe na base de dados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        errorProvider1.SetError(telefoneTextBox, "Este Número de Telefone já existe na base de dados!");
                        telefoneTextBox.Focus();
                    }
                    else
                    {
                        funcionarios.inserirFuncionario(nomeTextBox.Text, Convert.ToDateTime(data_nascimentoDateTimePicker.Text), Convert.ToString(cbSexo.SelectedItem), bITextBox.Text.ToUpper(), emailTextBox.Text.ToLower(),
                         Convert.ToInt32(telefoneTextBox.Text), enderecoTextBox.Text, numero_carteiraTextBox.Text, Convert.ToDateTime(data_admissaoDateTimePicker.Text), Convert.ToInt32(cbCodFuncao.SelectedValue));
                        if (funcionarios.resp.Equals("OK"))
                        {
                            MessageBox.Show("Novo funcionario adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.CarregarDados();
                        }
                        else
                            MessageBox.Show(funcionarios.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DesabilitarBotao();
                    }
                }
                else
                {
                    funcionarios.editarFuncionario(Convert.ToInt32(codigo), nomeTextBox.Text, Convert.ToDateTime(data_nascimentoDateTimePicker.Text), Convert.ToString(cbSexo.SelectedItem), bITextBox.Text.ToUpper(), emailTextBox.Text.ToLower(),
                         Convert.ToInt32(telefoneTextBox.Text), enderecoTextBox.Text, numero_carteiraTextBox.Text, Convert.ToDateTime(data_admissaoDateTimePicker.Text), Convert.ToInt32(cbCodFuncao.SelectedValue));
                    if (funcionarios.resp.Equals("OK"))
                    {
                        MessageBox.Show("Dados do Funcionario actualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarDados();
                        operacao = "inserir";
                    }
                    else
                        MessageBox.Show(funcionarios.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DesabilitarBotao();
                }
            }          
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastrarFuncionario_Geral_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.cadGeral = null;
        }

        private void telefoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void txtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNome();
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
            this.ListarFuncao();
        }

        private void funcionarioGeralDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codFuncionarioTextBox.Text = funcionarioGeralDataGridView.CurrentRow.Cells[0].Value.ToString();
            nomeTextBox.Text = funcionarioGeralDataGridView.CurrentRow.Cells[1].Value.ToString();
            data_nascimentoDateTimePicker.Text = funcionarioGeralDataGridView.CurrentRow.Cells[2].Value.ToString();
            cbSexo.Text = funcionarioGeralDataGridView.CurrentRow.Cells[3].Value.ToString();
            bITextBox.Text = funcionarioGeralDataGridView.CurrentRow.Cells[4].Value.ToString();
            emailTextBox.Text = funcionarioGeralDataGridView.CurrentRow.Cells[5].Value.ToString();
            telefoneTextBox.Text = funcionarioGeralDataGridView.CurrentRow.Cells[6].Value.ToString();
            enderecoTextBox.Text = funcionarioGeralDataGridView.CurrentRow.Cells[7].Value.ToString();
            numero_carteiraTextBox.Text = funcionarioGeralDataGridView.CurrentRow.Cells[8].Value.ToString();
            data_admissaoDateTimePicker.Text = funcionarioGeralDataGridView.CurrentRow.Cells[9].Value.ToString();
            cbCodFuncao.Text = funcionarioGeralDataGridView.CurrentRow.Cells[10].Value.ToString();
        }
    }
}
