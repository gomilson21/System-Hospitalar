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
    public partial class frmCadastrarMaterialDescartavel : Form
    {
        public frmCadastrarMaterialDescartavel()
        {
            InitializeComponent();
        }
        Crudes material = new Crudes();
        Dados.Listar dados = new Dados.Listar();
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");
        private string operacao = "inserir";
        private string codigo;

        public void CarregarDados()
        {
            matDescartavelDataGridView.DataSource = dados.ListarMaterialDescartavel();
        }

        public void BuscarCodigo()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codMaterialDescartavel nome_material, quantidadeInicial_material, quantidadeEntrada_material, dataValidade_material, quantidadeActual_material, quantidadeMinima_material, quantidadeMaxima_material, nome_fornecedor FROM Material_Descartavel INNER JOIN Fornecedor ON (Material_Descartavel.codFornecedor = Fornecedor.codFornecedor) WHERE codMaterialDescartavel = " + Convert.ToInt32(txtBuscarCodigo.Text), Sqlcon);
            Adpter.Fill(dados);
            matDescartavelDataGridView.DataSource = dados;
        }

        public void BuscarNome()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT codMaterialDescartavel nome_material, quantidadeInicial_material, quantidadeEntrada_material, dataValidade_material, quantidadeActual_material, quantidadeMinima_material, quantidadeMaxima_material, nome_fornecedor FROM Material_Descartavel INNER JOIN Fornecedor ON (Material_Descartavel.codFornecedor = Fornecedor.codFornecedor) WHERE nome_material LIKE '%" + txtBuscarNome.Text + "%'", Sqlcon);
            Adapter.Fill(dados);
            matDescartavelDataGridView.DataSource = dados;
        }

        public void DesabilitarBotao()
        {
            this.btnNovo.Enabled = true;
            this.btnExcluir.Enabled = true;
            this.btnSalvar.Enabled = false;
            this.btnEditar.Enabled = true;

            // Desabilitar textBox
            nomeTextBox.ReadOnly = true;
            quantidade_inicialTextBox.ReadOnly = true;
            quantidade_entradaTextBox.ReadOnly = true; 
            quantidade_minimaTextBox.ReadOnly = true;
            quantidade_maximaTextBox.ReadOnly = true;
            descricaoTextBox.ReadOnly = true;
        }

        public void HabilitarBotao()
        {
            this.btnNovo.Enabled = false;
            this.btnExcluir.Enabled = false;
            this.btnSalvar.Enabled = true;
            this.btnEditar.Enabled = false;

            // Habilitar textBox
            nomeTextBox.ReadOnly = false;
            quantidade_entradaTextBox.ReadOnly = false;
            quantidade_inicialTextBox.ReadOnly = false;
            quantidade_minimaTextBox.ReadOnly = false;
            quantidade_maximaTextBox.ReadOnly = false;
            descricaoTextBox.ReadOnly = false;
        }

        private void frmCadastrarMaterialDescartavel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_HospitalDataSet.Fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.db_HospitalDataSet.Fornecedor);
            // Carregar dados do Material Descartável no DataGridView
            this.CarregarDados();
            this.DesabilitarBotao();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            codMatrial_descartavelTextBox.Clear();
            nomeTextBox.Clear();
            quantidade_inicialTextBox.Clear();
            quantidade_entradaTextBox.Clear();
            quantidade_minimaTextBox.Clear();
            quantidade_maximaTextBox.Clear();
            quantidade_actualTextBox.Clear();
            descricaoTextBox.Clear();

            nomeTextBox.Focus();
            this.HabilitarBotao();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(matDescartavelDataGridView.SelectedRows.Count > 0)
            {
                operacao = "editar";
                codigo = matDescartavelDataGridView.CurrentRow.Cells[0].Value.ToString();
                nomeTextBox.Text = matDescartavelDataGridView.CurrentRow.Cells[1].Value.ToString();
                quantidade_inicialTextBox.Text = matDescartavelDataGridView.CurrentRow.Cells[2].Value.ToString();
                quantidade_entradaTextBox.Text = matDescartavelDataGridView.CurrentRow.Cells[3].Value.ToString();
                data_validadeDateTimePicker.Text = matDescartavelDataGridView.CurrentRow.Cells[4].Value.ToString();
                cbFornecedor.Text = matDescartavelDataGridView.CurrentRow.Cells[5].Value.ToString();
                descricaoTextBox.Text = matDescartavelDataGridView.CurrentRow.Cells[6].Value.ToString();
                quantidade_minimaTextBox.Text = matDescartavelDataGridView.CurrentRow.Cells[8].Value.ToString();
                quantidade_maximaTextBox.Text = matDescartavelDataGridView.CurrentRow.Cells[9].Value.ToString();
                this.HabilitarBotao();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para poderes editar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(matDescartavelDataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja eliminar este dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    codigo = matDescartavelDataGridView.CurrentRow.Cells[0].Value.ToString();
                    material.eliminarMatDescartavel(Convert.ToInt32(codigo));
                    if (material.resp == "OK")
                    {
                        MessageBox.Show("Dados do material descartável eliminado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarDados();
                    }
                    else
                        MessageBox.Show(material.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para poderes eliminar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (operacao == "inserir")
            {
                if (data_validadeDateTimePicker.Value.Year < 2022)
                {
                    MessageBox.Show("Data de validade do Material Descartável invalida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(data_validadeDateTimePicker, "Data de validade do Material Descartável invalida!");
                    data_validadeDateTimePicker.Focus();
                }
                else if (Convert.ToInt32(quantidade_minimaTextBox.Text) >= Convert.ToInt32(quantidade_maximaTextBox.Text))
                {
                    MessageBox.Show("Valor da Quantidade Mínima inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(quantidade_minimaTextBox, "Valor da Quantidade Mínima inválido!");
                    quantidade_minimaTextBox.Focus();
                }
                else
                {
                    material.inserirMatDescartavel(nomeTextBox.Text, Convert.ToInt32(quantidade_entradaTextBox.Text), Convert.ToDateTime(data_validadeDateTimePicker.Text), Convert.ToInt32(quantidade_inicialTextBox.Text),
                        Convert.ToInt32(quantidade_minimaTextBox.Text), Convert.ToInt32(quantidade_maximaTextBox.Text), descricaoTextBox.Text, Convert.ToInt32(cbFornecedor.SelectedValue));
                    if (material.resp == "OK")
                    {
                        MessageBox.Show("Novo Material Descartável adicionado com sucesso!", "Hospital EG Esperança", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarDados();
                    }
                    else
                        MessageBox.Show(material.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DesabilitarBotao();
                }
            }
            else
            {
                if (data_validadeDateTimePicker.Value.Year < 2022)
                {
                    MessageBox.Show("Data de validade do Material Descartável invalida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(data_validadeDateTimePicker, "Data de validade do Material Descartável invalida!");
                    data_validadeDateTimePicker.Focus();
                }
                else if (Convert.ToInt32(quantidade_minimaTextBox.Text) >= Convert.ToInt32(quantidade_maximaTextBox.Text))
                {
                    MessageBox.Show("Valor da Quantidade Mínima inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorProvider1.SetError(quantidade_minimaTextBox, "Valor da Quantidade Mínima inválido!");
                    quantidade_minimaTextBox.Focus();
                }
                {
                    material.editarMatDescartavel(Convert.ToInt32(codigo), nomeTextBox.Text, Convert.ToInt32(quantidade_entradaTextBox.Text), Convert.ToDateTime(data_validadeDateTimePicker.Text),
                        Convert.ToInt32(quantidade_inicialTextBox.Text), Convert.ToInt32(quantidade_minimaTextBox.Text), Convert.ToInt32(quantidade_maximaTextBox.Text), descricaoTextBox.Text, Convert.ToInt32(cbFornecedor.SelectedValue));
                    if (material.resp == "OK")
                    {
                        MessageBox.Show("Dados do material descartável actualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarDados();
                        operacao = "inserir";
                    }
                    else
                        MessageBox.Show(material.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DesabilitarBotao();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastrarMaterialDescartavel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.cadMatDescartavel = null;
        }

        private void txtBuscarCodigo_TextChanged(object sender, EventArgs e)
        {
            this.BuscarCodigo();
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
            txtBuscarNome.Clear();
            txtBuscarCodigo.Clear();
            this.CarregarDados();
            this.fornecedorTableAdapter.Fill(this.db_HospitalDataSet.Fornecedor);
        }

        private void matDescartavelDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codMatrial_descartavelTextBox.Text = matDescartavelDataGridView.CurrentRow.Cells[0].Value.ToString();
            nomeTextBox.Text = matDescartavelDataGridView.CurrentRow.Cells[1].Value.ToString();
            quantidade_inicialTextBox.Text = matDescartavelDataGridView.CurrentRow.Cells[2].Value.ToString();
            quantidade_entradaTextBox.Text = matDescartavelDataGridView.CurrentRow.Cells[3].Value.ToString();
            data_validadeDateTimePicker.Text = matDescartavelDataGridView.CurrentRow.Cells[4].Value.ToString();
            cbFornecedor.Text = matDescartavelDataGridView.CurrentRow.Cells[5].Value.ToString();
            descricaoTextBox.Text = matDescartavelDataGridView.CurrentRow.Cells[6].Value.ToString();
            quantidade_minimaTextBox.Text = matDescartavelDataGridView.CurrentRow.Cells[8].Value.ToString();
            quantidade_maximaTextBox.Text = matDescartavelDataGridView.CurrentRow.Cells[9].Value.ToString();
        }
    }
}
