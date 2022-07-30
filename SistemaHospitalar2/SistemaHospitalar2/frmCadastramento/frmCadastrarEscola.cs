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
    public partial class frmCadastrarEscola : Form
    {
        public frmCadastrarEscola()
        {
            InitializeComponent();
        }
        Crudes escola = new Crudes();
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");
        private string operacao = "inserir";
        private string codigo;

        public void BuscarCodigo()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT * FROM Escola WHERE codEscola = " + Convert.ToInt32(txtBuscarCodigo.Text), Sqlcon);
            Adpter.Fill(dados);
            escolaDataGridView.DataSource = dados;
        }

        public void BuscarNome()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT * FROM Escola WHERE nome LIKE '%" + txtBuscarNome.Text + "%'", Sqlcon);
            Adapter.Fill(dados);
            escolaDataGridView.DataSource = dados;
        }

        public void DesabilitarBotao()
        {
            btnNovo.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = true;

            // Habilitar textBox
            nomeTextBox.ReadOnly = true;
            nIFTextBox.ReadOnly = true;
            telefone_escolaTextBox.ReadOnly = true;
            enderecoTextBox.ReadOnly = true;
        }

        public void HabilitarBotao()
        {
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;

            // Habilitar textBox
            nomeTextBox.ReadOnly = false;
            nIFTextBox.ReadOnly = false;
            telefone_escolaTextBox.ReadOnly = false;
            enderecoTextBox.ReadOnly = false;
        }

        private void frmCadastrarEsola_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_HospitalDataSet1.Escola' table. You can move, or remove it, as needed.
            this.escolaTableAdapter.Fill(this.db_HospitalDataSet.Escola);
            this.DesabilitarBotao();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            codEscolaTextBox.Clear();
            nomeTextBox.Clear();
            nIFTextBox.Clear();
            telefone_escolaTextBox.Clear();
            enderecoTextBox.Clear();

            nomeTextBox.Focus();
            this.HabilitarBotao();         
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(escolaDataGridView.SelectedRows.Count > 0)
            {
                operacao = "editar";
                codigo = escolaDataGridView.CurrentRow.Cells[0].Value.ToString();
                nomeTextBox.Text = escolaDataGridView.CurrentRow.Cells[1].Value.ToString();
                nIFTextBox.Text = escolaDataGridView.CurrentRow.Cells[2].Value.ToString();
                telefone_escolaTextBox.Text = escolaDataGridView.CurrentRow.Cells[3].Value.ToString();
                enderecoTextBox.Text = escolaDataGridView.CurrentRow.Cells[4].Value.ToString();
                this.HabilitarBotao();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para poderes editar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(escolaDataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja eliminar este dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //  Verificar Ligação Com Estagiario
                    Sqlcon.Open();
                    DataTable tabela = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Estagiario WHERE codEscola = '" + Convert.ToInt32(codigo) + "'", Sqlcon);
                    adapter.Fill(tabela);
                    adapter.Dispose();
                    Sqlcon.Close();

                    if (tabela.Rows.Count > 0)
                        MessageBox.Show("Este Escola não pode ser eliminado porque possui ligação com algum Estagiario cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        escola.eliminarEscola(Convert.ToInt32(codEscolaTextBox.Text));
                        if (escola.resp == "OK")
                        {
                            MessageBox.Show("Dados da escola eliminados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.escolaTableAdapter.Fill(this.db_HospitalDataSet.Escola);
                        }
                        else
                            MessageBox.Show(escola.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // Número do Telefone da Escola
            if (telefone_escolaTextBox.TextLength != 9 || !telefone_escolaTextBox.Text.StartsWith("9"))
            {
                MessageBox.Show("Número do Telefone inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(telefone_escolaTextBox, "Número do Telefone inválido!");
                telefone_escolaTextBox.Focus();
            }
            else
            {
                SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");
                Sqlcon.Open();
                //  Verificando Existência do NIF da Escola
                DataTable dados = new DataTable();
                SqlDataAdapter Adpter = new SqlDataAdapter("SELECT * FROM Escola WHERE NIF_escola = @NIF ", Sqlcon);
                Adpter.SelectCommand.Parameters.AddWithValue("@NIF", nIFTextBox.Text);
                Adpter.Fill(dados);
                Adpter.Dispose();
                //  Verificando Existência do Númrero de Telefone da Escola
                DataTable dados1 = new DataTable();
                SqlDataAdapter Adpter1 = new SqlDataAdapter("SELECT * FROM Escola WHERE telefone_escola = @telefone ", Sqlcon);
                Adpter1.SelectCommand.Parameters.AddWithValue("@telefone", Convert.ToInt32(telefone_escolaTextBox.Text));
                Adpter1.Fill(dados1);
                Adpter1.Dispose();

                Sqlcon.Close();
                if (operacao.Equals("inserir"))
                {
                    if (dados.Rows.Count != 0)
                    {
                        MessageBox.Show("Este NIF já existe na base de dados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        errorProvider1.SetError(nIFTextBox, "Este NIF já existe na base de dados!");
                        nIFTextBox.Focus();
                    }
                    else if (dados.Rows.Count != 0)
                    {
                        MessageBox.Show("Este Número do Telefone já existe na base de dados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        errorProvider1.SetError(telefone_escolaTextBox, "Este NIF já existe na base de dados!");
                        telefone_escolaTextBox.Focus();
                    }
                    else
                    {
                        escola.inserirEscola(nomeTextBox.Text, nIFTextBox.Text, Convert.ToInt32(telefone_escolaTextBox.Text), enderecoTextBox.Text);
                        if (escola.resp.Equals("OK"))
                        {
                            MessageBox.Show("Nova escola adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.escolaTableAdapter.Fill(this.db_HospitalDataSet.Escola);
                        }
                        else
                            MessageBox.Show(escola.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DesabilitarBotao();
                    }
                }
                else
                {
                    escola.editarEscola(Convert.ToInt32(codEscolaTextBox.Text), nomeTextBox.Text, nIFTextBox.Text, Convert.ToInt32(telefone_escolaTextBox.Text), enderecoTextBox.Text);
                    if (escola.resp.Equals("OK"))
                    {
                        MessageBox.Show("Dados da escola actualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.escolaTableAdapter.Fill(this.db_HospitalDataSet.Escola);
                        operacao = "inserir";
                    }
                    else
                        MessageBox.Show(escola.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DesabilitarBotao();
                }
            }
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastrarEscola_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.cadEscola = null;
        }

        private void telefoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void txtBuscarCodigo_TextChanged(object sender, EventArgs e)
        {
            this.BuscarCodigo();
        }

        private void txtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNome();
        }

        private void telefone_escolaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

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
            this.escolaTableAdapter.Fill(this.db_HospitalDataSet.Escola);
        }
    }
}
