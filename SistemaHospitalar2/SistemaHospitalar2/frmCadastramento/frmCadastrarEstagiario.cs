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
    public partial class frmCadastrarEstagiario : Form
    {
        public frmCadastrarEstagiario()
        {
            InitializeComponent();
        }
        Crudes estagiario = new Crudes();
        Dados.Listar dados = new Dados.Listar();
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");
        private string operacao = "inserir";
        private string codigo;


        private string dateNow = DateTime.Now.ToShortDateString();

        public void CarregarDados()
        {
            estagiarioDataGridView.DataSource = dados.ListarEstagiario();
        }

        public void BuscarCodigo()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codEstagiario, nome_estagiario, dataNascimento_estagiario, sexo_estagiario, BI_estagiario, telefone_estagiario, endereco_estagiario, email_estagiario, licencaEstagio_estagiario, dataAdmissao_estagiario, nome_escola FROM Estagiario INNER JOIN Escola ON (Estagiario.codEscola = Escola.codEscola) WHERE codEstagiario = " + Convert.ToInt32(txtBuscarCodigo.Text), Sqlcon);
            Adpter.Fill(dados);
            estagiarioDataGridView.DataSource = dados;
        }

        public void BuscarNome()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT codEstagiario, nome_estagiario, dataNascimento_estagiario, sexo_estagiario, BI_estagiario, telefone_estagiario, endereco_estagiario, email_estagiario, licencaEstagio_estagiario, dataAdmissao_estagiario, nome_escola FROM Estagiario INNER JOIN Escola (Estagiario.codEscola = Escola.codEscola) WHERE nome_estagiario LIKE '%" + txtBuscarNome.Text +"%'", Sqlcon);
            Adapter.Fill(dados);
            estagiarioDataGridView.DataSource = dados;
        }

        public void DesabilitarBotao()
        {
            this.btnNovo.Enabled = true;
            this.btnExcluir.Enabled = true;
            this.btnSalvar.Enabled = false;
            this.btnEditar.Enabled = true;
            // Habilitar textBox e ComBox
            nomeTextBox.ReadOnly = true;
            emailTextBox.ReadOnly = true;
            telefoneTextBox.ReadOnly = true;
            enderecoTextBox.ReadOnly = true;
            bITextBox.ReadOnly = true;
            licenca_estagioTextBox.ReadOnly = true;
        }

        public void HabilitarBotao()
        {
            this.btnNovo.Enabled = false;
            this.btnExcluir.Enabled = false;
            this.btnSalvar.Enabled = true;
            this.btnEditar.Enabled = false;
            // Habilitar textBox e ComBox
            nomeTextBox.ReadOnly = false;
            emailTextBox.ReadOnly = false;
            telefoneTextBox.ReadOnly = false;
            enderecoTextBox.ReadOnly = false;
            bITextBox.ReadOnly = false;
            licenca_estagioTextBox.ReadOnly = false;
        }

        private void frmCadastarEstagiario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_HospitalDataSet.Escola' table. You can move, or remove it, as needed.
            this.escolaTableAdapter.Fill(this.db_HospitalDataSet.Escola);
            // Carregar dados do Estagiario no DataGridView
            this.CarregarDados();
            this.DesabilitarBotao();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            codEstagiarioTextBox.Clear();
            nomeTextBox.Clear();
            emailTextBox.Clear();
            telefoneTextBox.Clear();
            enderecoTextBox.Clear();
            bITextBox.Clear();
            licenca_estagioTextBox.Clear();

            nomeTextBox.Focus();
            this.HabilitarBotao();  
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(estagiarioDataGridView.SelectedRows.Count > 0)
            {
                operacao = "editar";
                codigo = estagiarioDataGridView.CurrentRow.Cells[0].Value.ToString();
                nomeTextBox.Text = estagiarioDataGridView.CurrentRow.Cells[1].Value.ToString();
                data_nascimentoDateTimePicker.Text = estagiarioDataGridView.CurrentRow.Cells[2].Value.ToString();
                cbSexo.Text = estagiarioDataGridView.CurrentRow.Cells[3].Value.ToString();
                bITextBox.Text = estagiarioDataGridView.CurrentRow.Cells[4].Value.ToString();
                telefoneTextBox.Text = estagiarioDataGridView.CurrentRow.Cells[5].Value.ToString();
                enderecoTextBox.Text = estagiarioDataGridView.CurrentRow.Cells[6].Value.ToString();
                emailTextBox.Text = estagiarioDataGridView.CurrentRow.Cells[7].Value.ToString();
                licenca_estagioTextBox.Text = estagiarioDataGridView.CurrentRow.Cells[8].Value.ToString();
                data_admissaoDateTimePicker.Text = estagiarioDataGridView.CurrentRow.Cells[9].Value.ToString();
                cbEscola.Text = estagiarioDataGridView.CurrentRow.Cells[10].Value.ToString();
                this.HabilitarBotao();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para poderes editar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(estagiarioDataGridView.SelectedRows.Count > 0)
            {
                if(MessageBox.Show("Tem certeza que deseja eliminar este dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    codigo = estagiarioDataGridView.CurrentRow.Cells[0].Value.ToString();
                    estagiario.eliminarEstagiario(Convert.ToInt32(codigo));
                    if (estagiario.resp.Equals("OK"))
                    {
                        MessageBox.Show("Dados do estagiario eliminados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarDados();
                    }
                    else
                        MessageBox.Show(estagiario.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (data_nascimentoDateTimePicker.Value.Year > 2008 || data_nascimentoDateTimePicker.Value.Year < 1990)
            {
                MessageBox.Show("Data de nascimento inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(data_nascimentoDateTimePicker, "Data de nascimento inválida!");
                data_nascimentoDateTimePicker.Focus();
            }
            //  Número do BI
            else if (bITextBox.TextLength != 14)
            {
                MessageBox.Show("Número do BI inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(bITextBox, "Número do BI inválido!");
                bITextBox.Focus();
            }
            //  Endereço de Email
            else if (!emailTextBox.Text.EndsWith("@gmail.com") && !emailTextBox.Text.EndsWith("@hotmail.com"))
            {
                MessageBox.Show("Endereço de Email inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(emailTextBox, "Endereço de Email inválido!");
                emailTextBox.Focus();
            }
            //  Número de Telefone
            else if (telefoneTextBox.TextLength != 9 || !telefoneTextBox.Text.StartsWith("9"))
            {
                MessageBox.Show("Número de telefone inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(telefoneTextBox, "Número de telefone inválido!");
                telefoneTextBox.Focus();
            }
            // Data de Admissão
            else if (data_admissaoDateTimePicker.Value != Convert.ToDateTime(dateNow))
            {
                MessageBox.Show("Data de Admissão inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(data_admissaoDateTimePicker, "Data de Admissão inválida!");
                data_admissaoDateTimePicker.Focus();
            }
            else
            {
                SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");
                Sqlcon.Open();
                //  Verificando Existência do Número do BI do Estagiário
                DataTable dados = new DataTable();
                SqlDataAdapter Adpter = new SqlDataAdapter("SELECT * FROM Estagiario WHERE BI_estagiario = @BI AND codEstagiario != @codigo", Sqlcon);
                Adpter.SelectCommand.Parameters.AddWithValue("@codigo", Convert.ToInt32(codEstagiarioTextBox.Text));
                Adpter.SelectCommand.Parameters.AddWithValue("@BI", bITextBox.Text.ToUpper());
                Adpter.Fill(dados);
                Adpter.Dispose();
                //  Verificando Existência do Endereço de Email do Estagiário
                DataTable dados1 = new DataTable();
                SqlDataAdapter Adpter1 = new SqlDataAdapter("SELECT * FROM Estagiario WHERE email_estagiario = @email AND codEstagiario != @codigo", Sqlcon);
                Adpter1.SelectCommand.Parameters.AddWithValue("@codigo", Convert.ToInt32(codEstagiarioTextBox.Text));
                Adpter1.SelectCommand.Parameters.AddWithValue("@email", emailTextBox.Text.ToLower());
                Adpter1.Fill(dados1);
                Adpter1.Dispose();
                //  Verificando Existência da Licença de Estágio do Estagiário
                DataTable dados2 = new DataTable();
                SqlDataAdapter Adpter2 = new SqlDataAdapter("SELECT * FROM Estagiario WHERE licencaEstagio_estagiario = @licenca_estagio AND codEstagiario != @codigo", Sqlcon);
                Adpter2.SelectCommand.Parameters.AddWithValue("@codigo", Convert.ToInt32(codEstagiarioTextBox.Text));
                Adpter2.SelectCommand.Parameters.AddWithValue("@licenca_estagio", licenca_estagioTextBox.Text);
                Adpter2.Fill(dados2);
                Adpter2.Dispose();
                //  Verificando Existência do Númrero de Telefone do Funcionario
                DataTable dados3 = new DataTable();
                SqlDataAdapter Adpter3 = new SqlDataAdapter("SELECT * FROM Estagiario WHERE telefone_estagiario = @telefone AND codEstagiario != @codigo", Sqlcon);
                Adpter3.SelectCommand.Parameters.AddWithValue("@codigo", Convert.ToInt32(codEstagiarioTextBox.Text));
                Adpter3.SelectCommand.Parameters.AddWithValue("@telefone", Convert.ToInt32(telefoneTextBox.Text));
                Adpter3.Fill(dados3);
                Adpter3.Dispose();

                Sqlcon.Close();

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
                    MessageBox.Show("Esta Licença de Estágio já existe na base de dados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    errorProvider1.SetError(licenca_estagioTextBox, "Esta Licença de Estágio já existe na base de dados!");
                    licenca_estagioTextBox.Focus();
                }
                else if (dados3.Rows.Count != 0)
                {
                    MessageBox.Show("Este Número de Telefone já existe na base de dados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    errorProvider1.SetError(telefoneTextBox, "Este Número de Telefone já existe na base de dados!");
                    telefoneTextBox.Focus();
                }
                else
                {
                    if (operacao.Equals("inserir"))
                    {
                        estagiario.inserirEstagiario(nomeTextBox.Text, Convert.ToDateTime(data_nascimentoDateTimePicker.Text), Convert.ToString(cbSexo.SelectedItem), bITextBox.Text.ToUpper(), Convert.ToInt32(telefoneTextBox.Text),
                        enderecoTextBox.Text, emailTextBox.Text.ToLower(), licenca_estagioTextBox.Text, Convert.ToDateTime(data_admissaoDateTimePicker.Text), Convert.ToInt32(cbEscola.SelectedValue));
                        if (estagiario.resp.Equals("OK"))
                        {
                            MessageBox.Show("Novo estagiario adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.CarregarDados();
                        }
                        else
                            MessageBox.Show(estagiario.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DesabilitarBotao();
                    }
                    else if (operacao.Equals("editar"))
                    {

                        estagiario.editarEstagiario(Convert.ToInt32(codigo), nomeTextBox.Text, Convert.ToDateTime(data_nascimentoDateTimePicker.Text), Convert.ToString(cbSexo.SelectedItem), bITextBox.Text.ToUpper(),
                            Convert.ToInt32(telefoneTextBox.Text), enderecoTextBox.Text, emailTextBox.Text.ToLower(), licenca_estagioTextBox.Text, Convert.ToDateTime(data_admissaoDateTimePicker.Text), Convert.ToInt32(cbEscola.SelectedValue));
                        if (estagiario.resp.Equals("OK"))
                        {
                            MessageBox.Show("Dados do Estagiario actualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            operacao = "inserir";
                            this.CarregarDados();
                        }
                        else
                            MessageBox.Show(estagiario.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        this.DesabilitarBotao();
                    }
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastrarEstagiario_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.cadEstagiario = null;
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
            this.escolaTableAdapter.Fill(this.db_HospitalDataSet.Escola);
        }

        private void estagiarioDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codEstagiarioTextBox.Text = estagiarioDataGridView.CurrentRow.Cells[0].Value.ToString();
            nomeTextBox.Text = estagiarioDataGridView.CurrentRow.Cells[1].Value.ToString();
            data_nascimentoDateTimePicker.Text = estagiarioDataGridView.CurrentRow.Cells[2].Value.ToString();
            cbSexo.Text = estagiarioDataGridView.CurrentRow.Cells[3].Value.ToString();
            bITextBox.Text = estagiarioDataGridView.CurrentRow.Cells[4].Value.ToString();
            telefoneTextBox.Text = estagiarioDataGridView.CurrentRow.Cells[5].Value.ToString();
            enderecoTextBox.Text = estagiarioDataGridView.CurrentRow.Cells[6].Value.ToString();
            emailTextBox.Text = estagiarioDataGridView.CurrentRow.Cells[7].Value.ToString();
            licenca_estagioTextBox.Text = estagiarioDataGridView.CurrentRow.Cells[8].Value.ToString();
            data_admissaoDateTimePicker.Text = estagiarioDataGridView.CurrentRow.Cells[9].Value.ToString();
            cbEscola.Text = estagiarioDataGridView.CurrentRow.Cells[10].Value.ToString();
        }
    }
}
