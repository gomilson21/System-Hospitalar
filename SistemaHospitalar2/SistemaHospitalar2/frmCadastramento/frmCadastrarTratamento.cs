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
    public partial class frmCadastrarTratamento : Form
    {
        public frmCadastrarTratamento()
        {
            InitializeComponent();
        }

        Crudes tratamento = new Crudes();
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");
        private string operacao = "inserir";
        private string codigo;

        public void BuscarCodigo()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT * FROM Tratamento WHERE codTratamento = " + Convert.ToInt32(txtBuscarCodigo.Text), Sqlcon);
            Adpter.Fill(dados);
            tratamentoDataGridView.DataSource = dados;
        }

        public void BuscarNome()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT * FROM Tratamento WHERE nome_tratamento LIKE '%" + txtBuscarNome.Text + "%'", Sqlcon);
            Adapter.Fill(dados);
            tratamentoDataGridView.DataSource = dados;
        }

        public void DesabilitarBotao()
        {
            this.btnNovo.Enabled = true;
            this.btnExcluir.Enabled = true;
            this.btnSalvar.Enabled = false;
            this.btnEditar.Enabled = true;

            nomeTextBox.ReadOnly = true;
            descricaoTextBox.ReadOnly = true;
        }

        public void HabilitarBotao()
        {
            this.btnNovo.Enabled = false;
            this.btnExcluir.Enabled = false;
            this.btnSalvar.Enabled = true;
            this.btnEditar.Enabled = false;

            nomeTextBox.ReadOnly = false;
            descricaoTextBox.ReadOnly = false;
        }

        private void frmCadastrarTratamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_HospitalDataSet.Tratamento' table. You can move, or remove it, as needed.
            this.tratamentoTableAdapter.Fill(this.db_HospitalDataSet.Tratamento);

            this.DesabilitarBotao();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            codTratamentoTextBox.Clear();
            nomeTextBox.Clear();
            descricaoTextBox.Clear();

            nomeTextBox.Focus();
            this.HabilitarBotao();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(tratamentoDataGridView.SelectedRows.Count > 0)
            {
                operacao = "editar";
                codigo = tratamentoDataGridView.CurrentRow.Cells[0].Value.ToString();
                nomeTextBox.Text = tratamentoDataGridView.CurrentRow.Cells[1].Value.ToString();
                descricaoTextBox.Text = tratamentoDataGridView.CurrentRow.Cells[2].Value.ToString();

                this.HabilitarBotao();
            }
            else
            {
                MessageBox.Show("Seleciona uma linha para poder alterar os dados do tratamento!", "Hospital EG Esperança",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(tratamentoDataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tens certeza que desejas eliminar esses daddos!", "Hospital EG Esperança",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //  Verificar Ligação Com Paciente Internado
                    Sqlcon.Open();
                    DataTable tabela = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Paciente_Internado WHERE codTratamento = '" + Convert.ToInt32(codigo) + "'", Sqlcon);
                    adapter.Fill(tabela);
                    adapter.Dispose();
                    Sqlcon.Close();

                    if (tabela.Rows.Count > 0)
                        MessageBox.Show("Este Tratamento não pode ser eliminado porque possui ligação com algum Paciente Internado cadastrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        tratamento.eliminarTratamento(Convert.ToInt32(codTratamentoTextBox.Text));
                        if (tratamento.resp.Equals("OK"))
                        {
                            MessageBox.Show("Dados do Tratamento eliminados com sucessso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.tratamentoTableAdapter.Fill(this.db_HospitalDataSet.Tratamento);
                        }
                        else
                            MessageBox.Show(tratamento.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleciona uma linha para poder eliminar os dados do tratamento!", "Hospital EG Esperança",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(operacao.Equals("inserir"))
            {
                tratamento.inserirTratamento(nomeTextBox.Text, descricaoTextBox.Text);
                if(tratamento.resp.Equals("OK"))
                {
                    MessageBox.Show("Novo tratamento Adicionado com sucesso!", "Confirmação",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tratamentoTableAdapter.Fill(this.db_HospitalDataSet.Tratamento);
                    
                }
                else
                    MessageBox.Show(tratamento.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DesabilitarBotao();
            }
            else
            {
                tratamento.editTratamento(Convert.ToInt32(codTratamentoTextBox.Text), nomeTextBox.Text, descricaoTextBox.Text);
                if(tratamento.resp.Equals("OK"))
                {
                    MessageBox.Show("Os dados do tratamento foi alterado com sucesso!", "Hospital EG Espença",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tratamentoTableAdapter.Fill(this.db_HospitalDataSet.Tratamento);
                    operacao = "inserir";
                }
                else
                    MessageBox.Show(tratamento.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DesabilitarBotao();
            }
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 
        private void frmCadastrarTratamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.cadTratamento = null;
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
            this.tratamentoTableAdapter.Fill(this.db_HospitalDataSet.Tratamento);

        }

        private void txtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNome();
        }

        private void tratamentoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codTratamentoTextBox.Text = tratamentoDataGridView.CurrentRow.Cells[0].Value.ToString();
            nomeTextBox.Text = tratamentoDataGridView.CurrentRow.Cells[1].Value.ToString();
            descricaoTextBox.Text = tratamentoDataGridView.CurrentRow.Cells[2].Value.ToString();
        }
    }
}