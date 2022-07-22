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
    public partial class frmCadastrarFornecedor : Form
    {
        public frmCadastrarFornecedor()
        {
            InitializeComponent();
        }

        Crudes fornecedor = new Crudes();
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");
        private string operacao = "inserir";
        private string codigo;

        public void BuscarCodigo()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT * FROM Fornecedor WHERE codFornecedor = " + Convert.ToInt32(txtBuscarCodigo.Text), Sqlcon);
            Adpter.Fill(dados);
            fornecedorDataGridView.DataSource = dados;
        }

        public void BuscarNome()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT * FROM Fornecedor WHERE nome_fornecedor LIKE '%" + txtBuscarNome.Text + "%'", Sqlcon);
            Adapter.Fill(dados);
            fornecedorDataGridView.DataSource = dados;
        }

        public void DesabilitarBotao()
        {
            btnNovo.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = true;
            nomeTextBox.Focus();

            // Desabilitando textBox
            nomeTextBox.ReadOnly = true;
            nacionalidadeTextBox.ReadOnly = true;
            telefoneTextBox.ReadOnly = true;
            enderecoTextBox.ReadOnly = true;
            emailTextBox.ReadOnly = true;
        }

        public void HabilitarBotao()
        {
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;

            // habilitando textBox
            nomeTextBox.ReadOnly = false;
            nacionalidadeTextBox.ReadOnly = false;
            telefoneTextBox.ReadOnly = false;
            enderecoTextBox.ReadOnly = false;
            emailTextBox.ReadOnly = false;
        }

        private void frmCadastrarFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_HospitalDataSet.Fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.db_HospitalDataSet.Fornecedor);

            this.DesabilitarBotao();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            codFornecedorTextBox.Clear();
            nomeTextBox.Clear();
            nacionalidadeTextBox.Clear();
            telefoneTextBox.Clear();
            enderecoTextBox.Clear();
            emailTextBox.Clear();

            this.HabilitarBotao();
            nomeTextBox.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (fornecedorDataGridView.SelectedRows.Count > 0)
            {
                operacao = "editar";
                codigo = fornecedorDataGridView.CurrentRow.Cells[0].Value.ToString();
                nomeTextBox.Text = fornecedorDataGridView.CurrentRow.Cells[1].Value.ToString();
                telefoneTextBox.Text = fornecedorDataGridView.CurrentRow.Cells[2].Value.ToString();
                enderecoTextBox.Text = fornecedorDataGridView.CurrentRow.Cells[3].Value.ToString();
                nacionalidadeTextBox.Text = fornecedorDataGridView.CurrentRow.Cells[4].Value.ToString();
                emailTextBox.Text = fornecedorDataGridView.CurrentRow.Cells[5].Value.ToString();
                inicio_contratoDateTimePicker.Text = fornecedorDataGridView.CurrentRow.Cells[6].Value.ToString();
                fim_contratoDateTimePicker.Text = fornecedorDataGridView.CurrentRow.Cells[7].Value.ToString();

                this.HabilitarBotao();
            }
            else
            {
                MessageBox.Show("Seleciona uma linha para poder editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (fornecedorDataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja eliminar este dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //  Verificar Ligação Com Medicamento
                    Sqlcon.Open();
                    DataTable tabela = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Medicamento WHERE codFornecedor = '" + Convert.ToInt32(codigo) + "'", Sqlcon);
                    adapter.Fill(tabela);
                    adapter.Dispose();
                    Sqlcon.Close();

                    //  Verificar Ligação Com Material Descartável
                    Sqlcon.Open();
                    DataTable tabela1 = new DataTable();
                    SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT * FROM Material_Descartavel WHERE codFornecedor = '" + Convert.ToInt32(codigo) + "'", Sqlcon);
                    adapter1.Fill(tabela1);
                    adapter1.Dispose();
                    Sqlcon.Close();

                    if (tabela.Rows.Count > 0)
                        MessageBox.Show("Este Fornecedor não pode ser eliminado porque possui ligação com um Medicamento!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (tabela1.Rows.Count > 0)
                        MessageBox.Show("Este Fornecedor não pode ser eliminado porque possui ligação com um Material Descartavel!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        fornecedor.eliminarFornecedor(Convert.ToInt32(codFornecedorTextBox.Text));
                        if (fornecedor.resp == "OK")
                        {
                            MessageBox.Show("Fornecedor eliminado com sucesso!", "Hospital EG Esperança", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.fornecedorTableAdapter.Fill(this.db_HospitalDataSet.Fornecedor);
                        }
                        else
                            MessageBox.Show(fornecedor.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleciona uma linha para poder eliminar!", "Hospital EG Esperança", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (telefoneTextBox.TextLength != 9)
            {
                MessageBox.Show("Número de telefone inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(telefoneTextBox, "Número de telefone inválido!");
                telefoneTextBox.Focus();
            }
            else if (inicio_contratoDateTimePicker.Value.Year != 2022)
            {
                MessageBox.Show("Data de Início de Contrato inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(inicio_contratoDateTimePicker, "Data de início de Contrato inválida!");
                inicio_contratoDateTimePicker.Focus();
            }
            else if (fim_contratoDateTimePicker.Value.Year < inicio_contratoDateTimePicker.Value.Year)
            {
                MessageBox.Show("Data do Final de Contrato inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(fim_contratoDateTimePicker, "Data do Final de Contrato inválida!");
                fim_contratoDateTimePicker.Focus();
            }
            else
            {
                SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");
                Sqlcon.Open();
                //  Verificando Existência do Númrero do Telefone do Fornecedor
                DataTable dados = new DataTable();
                SqlDataAdapter Adpter = new SqlDataAdapter("SELECT * FROM Fornecedor WHERE telefone_fornecedor = @telefone ", Sqlcon);
                Adpter.SelectCommand.Parameters.AddWithValue("@telefone", Convert.ToInt32(telefoneTextBox.Text));
                Adpter.Fill(dados);
                Adpter.Dispose();
                //  Verificando Existência do Endereço de Email do Fornecedor
                DataTable dados1 = new DataTable();
                SqlDataAdapter Adpter1 = new SqlDataAdapter("SELECT * FROM Fornecedor WHERE email_fornecedor = @email ", Sqlcon);
                Adpter1.SelectCommand.Parameters.AddWithValue("@email", emailTextBox.Text);
                Adpter1.Fill(dados1);
                Adpter1.Dispose();

                Sqlcon.Close();
                if (operacao == "inserir")
                {
                    if (dados.Rows.Count != 0)
                    {
                        MessageBox.Show("Este Número do Telefone já existe na base de dados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        errorProvider1.SetError(telefoneTextBox, "Este Número do Telefone já existe na base de dados!");
                        telefoneTextBox.Focus();
                    }
                    else if (dados1.Rows.Count != 0)
                    {
                        MessageBox.Show("Este Endereço de Email já existe na base de dados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        errorProvider1.SetError(emailTextBox, "Este Endereço de Email já existe na base de dados!");
                        emailTextBox.Focus();
                    }
                    else
                    {
                        fornecedor.inserirFornecedor(nomeTextBox.Text, Convert.ToInt32(telefoneTextBox.Text), enderecoTextBox.Text,
                            nacionalidadeTextBox.Text, emailTextBox.Text, Convert.ToDateTime(inicio_contratoDateTimePicker.Text), Convert.ToDateTime(fim_contratoDateTimePicker.Text));
                        if (fornecedor.resp.Equals("OK"))
                        {
                            MessageBox.Show("Novo fornecedor Adicionado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.fornecedorTableAdapter.Fill(this.db_HospitalDataSet.Fornecedor);
                        }
                        else
                            MessageBox.Show(fornecedor.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DesabilitarBotao();
                    }
                }
                else if (operacao.Equals("editar"))
                {
                    fornecedor.editarFornecedor(Convert.ToInt32(codFornecedorTextBox.Text), nomeTextBox.Text, Convert.ToInt32(telefoneTextBox.Text),
                       enderecoTextBox.Text, nacionalidadeTextBox.Text, emailTextBox.Text, Convert.ToDateTime(inicio_contratoDateTimePicker.Text), Convert.ToDateTime(fim_contratoDateTimePicker.Text));
                    if (fornecedor.resp.Equals("OK"))
                    {
                        MessageBox.Show("Dados do fornecedor alterado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.fornecedorTableAdapter.Fill(this.db_HospitalDataSet.Fornecedor);
                        operacao = "inserir";
                    }
                    else
                        MessageBox.Show(fornecedor.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DesabilitarBotao();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastrarFornecedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.cadFornecedor = null;
        }

        private void telefoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = true;
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
            this.fornecedorTableAdapter.Fill(this.db_HospitalDataSet.Fornecedor);
        }

        private void txtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNome();
        }
    }
}
