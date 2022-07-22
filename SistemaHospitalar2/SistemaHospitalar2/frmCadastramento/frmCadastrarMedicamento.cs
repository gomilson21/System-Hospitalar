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
    public partial class frmCadastrarMedicamento : Form
    {
        public frmCadastrarMedicamento()
        {
            InitializeComponent();
        }
        Crudes medicamento = new Crudes();
        Dados.Listar dados = new Dados.Listar();
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");
        private string operacao = "inserir";
        private string codigo;

        public void CarregarDados()
        {
            medicamentoDataGridView.DataSource = dados.ListarMedicamento();
        }

        private void ColorCell()
        {
            
        }

        public void BuscarCodigo()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codMedicamento, nomeGenerico_medicamento, nomeComercial_medicamento, quantidadeInicial_medicamento, quantidadeEntrada_medicamento, dataValidade_medicamento, quantidadeActual_medicamento, quantidadeMinima_medicamento, quantidadeMaxima_medicamento, nome_fornecedor FROM Medicamento INNER JOIN Fornecedor ON (Medicamento.codFornecedor = Fornecedor.codFornecedor) WHERE codMedicamento = " + Convert.ToInt32(txtBuscarCodigo.Text), Sqlcon);
            Adpter.Fill(dados);
            medicamentoDataGridView.DataSource = dados;
        }

        public void BuscarNome()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT codMedicamento, nomeGenerico_medicamento, nomeComercial_medicamento, quantidadeInicial_medicamento, quantidadeEntrada_medicamento, dataValidade_medicamento, quantidadeActual_medicamento, quantidadeMinima_medicamento, quantidadeMaxima_medicamento, nome_fornecedor FROM Medicamento INNER JOIN Fornecedor ON (Medicamento.codFornecedor = Fornecedor.codFornecedor) WHERE nomeComercial_medicamento LIKE '%" + txtBuscarNome.Text + "%'", Sqlcon);
            Adapter.Fill(dados);
            medicamentoDataGridView.DataSource = dados;
        }

        public void DesabilitarBotao()
        {
            btnNovo.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = true;

            // Habilitando textBox
            nome_comercialTextBox.ReadOnly = true;
            nome_genericoTextBox.ReadOnly = true;
            descricaoTextBox.ReadOnly = true;
            quantidade_inicialTextBox.ReadOnly = true;
            quantidade_entradaTextBox.ReadOnly = true;
            quantidade_minimaTextBox.ReadOnly = true;
            quantidade_maximaTextBox.ReadOnly = true;
        }

        public void HabilitarBotao()
        {
            this.btnNovo.Enabled = false;
            this.btnExcluir.Enabled = false;
            this.btnSalvar.Enabled = true;
            this.btnEditar.Enabled = false;

            // Habilitando textBox
            nome_comercialTextBox.ReadOnly = false;
            nome_genericoTextBox.ReadOnly = false;       
            descricaoTextBox.ReadOnly = false;
            quantidade_inicialTextBox.ReadOnly = false;
            quantidade_entradaTextBox.ReadOnly = false;
            quantidade_minimaTextBox.ReadOnly = false;
            quantidade_maximaTextBox.ReadOnly = false;
        }

        private void frmCadastrarMedicamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_HospitalDataSet.Fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.db_HospitalDataSet.Fornecedor);
            // Carregar dados do Medicamento no DataGridView
            this.CarregarDados();
            this.DesabilitarBotao();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            codMedicamentoTextBox.Clear();
            nome_genericoTextBox.Clear();
            nome_comercialTextBox.Clear();
            quantidade_inicialTextBox.Clear();
            quantidade_entradaTextBox.Clear();
            quantidade_minimaTextBox.Clear();
            quantidade_maximaTextBox.Clear();
            quantidade_actualTextBox.Clear();
            descricaoTextBox.Clear();

            nome_genericoTextBox.Focus();
            this.HabilitarBotao();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(medicamentoDataGridView.SelectedRows.Count > 0)
            {
                operacao = "editar";
                codigo = medicamentoDataGridView.CurrentRow.Cells[0].Value.ToString();
                nome_genericoTextBox.Text = medicamentoDataGridView.CurrentRow.Cells[1].Value.ToString();
                nome_comercialTextBox.Text = medicamentoDataGridView.CurrentRow.Cells[2].Value.ToString();
                quantidade_inicialTextBox.Text = medicamentoDataGridView.CurrentRow.Cells[3].Value.ToString();
                quantidade_entradaTextBox.Text = medicamentoDataGridView.CurrentRow.Cells[4].Value.ToString();
                data_validadeDateTimePicker.Text = medicamentoDataGridView.CurrentRow.Cells[5].Value.ToString();
                cbCodFornecedor.Text = medicamentoDataGridView.CurrentRow.Cells[6].Value.ToString();
                descricaoTextBox.Text = medicamentoDataGridView.CurrentRow.Cells[7].Value.ToString();
                quantidade_minimaTextBox.Text = medicamentoDataGridView.CurrentRow.Cells[9].Value.ToString();
                quantidade_maximaTextBox.Text = medicamentoDataGridView.CurrentRow.Cells[10].Value.ToString();
                this.HabilitarBotao();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para poderes editar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(medicamentoDataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja eliminar este dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    medicamento.eliminarMedicamento(Convert.ToInt32(codMedicamentoTextBox.Text));
                    if (medicamento.resp == "OK")
                    {
                        MessageBox.Show("Dados do medicamento eliminado com sucesso!", "Hospital EG Esperança", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarDados();
                    }
                    else
                        MessageBox.Show(medicamento.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                   
            }
            else
            {
                MessageBox.Show("Selecione uma linha para poderes eliminado!", "Hospital EG Esperança", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (operacao == "inserir")
            {
                if (data_validadeDateTimePicker.Value.Year < 2022)
                    errorProvider1.SetError(data_validadeDateTimePicker, "Data de validade do Medicamento inválida!");
                else if (Convert.ToInt32(quantidade_minimaTextBox.Text) >= Convert.ToInt32(quantidade_maximaTextBox.Text))
                    errorProvider1.SetError(quantidade_minimaTextBox, "Valor da Quantidade Mínima inválido!");
                else
                {
                    medicamento.inserirMedicamento(nome_comercialTextBox.Text, nome_genericoTextBox.Text, Convert.ToInt32(quantidade_entradaTextBox.Text), Convert.ToDateTime(data_validadeDateTimePicker.Text), Convert.ToInt32(quantidade_minimaTextBox.Text),
                        Convert.ToInt32(quantidade_maximaTextBox.Text), Convert.ToInt32(quantidade_inicialTextBox.Text), descricaoTextBox.Text, Convert.ToInt32(cbCodFornecedor.SelectedValue));
                    if (medicamento.resp == "OK")
                    {
                        MessageBox.Show("Novo medicamento adicionado com sucesso!", "Hospital EG Esperança", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarDados();
                        this.DesabilitarBotao();
                    }
                    else
                        MessageBox.Show(medicamento.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (data_validadeDateTimePicker.Value.Year < 2022)
                    errorProvider1.SetError(data_validadeDateTimePicker, "Data de validade do Material Descartável invalida!");
                else if (Convert.ToInt32(quantidade_minimaTextBox.Text) >= Convert.ToInt32(quantidade_maximaTextBox.Text))
                    errorProvider1.SetError(quantidade_minimaTextBox, "Valor da Quantidade Mínima inválido!");
                else
                {
                    medicamento.editarMedicamento(Convert.ToInt32(codigo), nome_comercialTextBox.Text, nome_genericoTextBox.Text, Convert.ToInt32(quantidade_entradaTextBox.Text), Convert.ToDateTime(data_validadeDateTimePicker.Text),
                        Convert.ToInt32(quantidade_minimaTextBox.Text), Convert.ToInt32(quantidade_maximaTextBox.Text), Convert.ToInt32(quantidade_inicialTextBox.Text), descricaoTextBox.Text, Convert.ToInt32(cbCodFornecedor.SelectedValue));
                    if (medicamento.resp == "OK")
                    {
                        MessageBox.Show("Dados do medicamento actualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarDados();
                        this.DesabilitarBotao();
                        operacao = "inserir";
                    }  
                    else
                        MessageBox.Show(medicamento.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastrarMedicamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.cadMedicamento = null;
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
            this.fornecedorTableAdapter.Fill(this.db_HospitalDataSet.Fornecedor);
        }

        private void txtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNome();
        }

        private void medicamentoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codMedicamentoTextBox.Text = medicamentoDataGridView.CurrentRow.Cells[0].Value.ToString();
            nome_genericoTextBox.Text = medicamentoDataGridView.CurrentRow.Cells[1].Value.ToString();
            nome_comercialTextBox.Text = medicamentoDataGridView.CurrentRow.Cells[2].Value.ToString();
            quantidade_inicialTextBox.Text = medicamentoDataGridView.CurrentRow.Cells[3].Value.ToString();
            quantidade_entradaTextBox.Text = medicamentoDataGridView.CurrentRow.Cells[4].Value.ToString();
            data_validadeDateTimePicker.Text = medicamentoDataGridView.CurrentRow.Cells[5].Value.ToString();
            cbCodFornecedor.Text = medicamentoDataGridView.CurrentRow.Cells[6].Value.ToString();
            descricaoTextBox.Text = medicamentoDataGridView.CurrentRow.Cells[7].Value.ToString();
            quantidade_minimaTextBox.Text = medicamentoDataGridView.CurrentRow.Cells[9].Value.ToString();
            quantidade_maximaTextBox.Text = medicamentoDataGridView.CurrentRow.Cells[10].Value.ToString();
        }
    }
}
