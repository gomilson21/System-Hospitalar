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

namespace SistemaHospitalar2.frmCadastramento
{
    public partial class frmCadastrarQuarto : Form
    {
        public frmCadastrarQuarto()
        {
            InitializeComponent();
        }
        Crudes quarto = new Crudes();
        Dados.Listar dados = new Dados.Listar();
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");
        private string operacao = "inserir";
        private string codigo;

        private void ListarAlaHospitalar()
        {
            cbCodAla.DataSource = dados.ComboBoxListarAlaHospitalar();
            cbCodAla.DisplayMember = "nome_ala";
            cbCodAla.ValueMember = "codAla";
        }

        private void CarregarDados()
        {
            quartoDataGridView.DataSource = dados.ListarQuarto();
        }

        public void BuscarCodigo()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codQuarto, nome_quarto, quantidadeCamas_quarto FROM Quarto INNER JOIN Ala_Hospitalar ON (Quarto.codAla = Ala_Hospitalar.codAla) WHERE codQuarto = " + Convert.ToInt32(txtBuscarCodigo.Text), Sqlcon);
            Adpter.Fill(dados);
            quartoDataGridView.DataSource = dados;
        }

        public void BuscarNome()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT codQuarto, nome_quarto, quantidadeCamas_quarto FROM Quarto INNER JOIN Ala_Hospitalar ON (Quarto.codAla = Ala_Hospitalar.codAla) WHERE nome_quarto LIKE '%" + txtBuscarNome.Text + "%'", Sqlcon);
            Adapter.Fill(dados);
            quartoDataGridView.DataSource = dados;
        }

        public void DesabilitarBotao()
        {
            this.btnNovo.Enabled = true;
            this.btnExcluir.Enabled = true;
            this.btnSalvar.Enabled = false;
            this.btnEditar.Enabled = true;
            //  Habilitar textBox
            nomeTextBox.ReadOnly = true;
            quantidade_camasTextBox.ReadOnly = true;
        }

        public void HabilitarBotao()
        {
            this.btnNovo.Enabled = false;
            this.btnExcluir.Enabled = false;
            this.btnSalvar.Enabled = true;
            this.btnEditar.Enabled = false;

            //  Habilitar textBox
            nomeTextBox.ReadOnly = false;
            quantidade_camasTextBox.ReadOnly = false;
        }

        private void frmCadastrarQuarto_Load(object sender, EventArgs e)
        {
            // Lista dados da Ala Hospitalar no ComboBox
            this.ListarAlaHospitalar();
            // Carregar dados do Quarto no DataGridView
            this.CarregarDados();
            this.DesabilitarBotao();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            codQuartoTextBox.Clear();
            nomeTextBox.Clear();
            quantidade_camasTextBox.Clear();

            nomeTextBox.Focus();
            this.HabilitarBotao();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(quartoDataGridView.SelectedRows.Count > 0)
            {
                operacao = "editar";
                codigo = quartoDataGridView.CurrentRow.Cells[0].Value.ToString();
                nomeTextBox.Text = quartoDataGridView.CurrentRow.Cells[1].Value.ToString();
                quantidade_camasTextBox.Text = quartoDataGridView.CurrentRow.Cells[2].Value.ToString();
                cbCodAla.Text = quartoDataGridView.CurrentRow.Cells[3].Value.ToString();
                this.HabilitarBotao();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para poderes editar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(quartoDataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja eliminar este dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    codigo = quartoDataGridView.CurrentRow.Cells[0].Value.ToString();
                    quarto.eliminarQuarto(Convert.ToInt32(codigo));
                    if (quarto.resp == "OK")
                    {
                        MessageBox.Show("Dados do quarto eliminados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarDados();
                    }
                    else
                        MessageBox.Show(quarto.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }       
            }
            else
            {
                MessageBox.Show("Seleceione uma linha para poderes eliminar!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(operacao == "inserir")
            {
                quarto.inserirQuarto(nomeTextBox.Text, Convert.ToInt32(quantidade_camasTextBox.Text), Convert.ToInt32(cbCodAla.SelectedValue));
                if (quarto.resp == "OK")
                {
                    MessageBox.Show("Novo quarto adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CarregarDados();
                }
                else
                    MessageBox.Show(quarto.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DesabilitarBotao();
            }
            else
            {
                quarto.editarQuarto(Convert.ToInt32(codigo), nomeTextBox.Text, Convert.ToInt32(quantidade_camasTextBox.Text), Convert.ToInt32(cbCodAla.SelectedValue));
                if (quarto.resp == "OK")
                {
                    MessageBox.Show("Dados do quarto actualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CarregarDados();
                    operacao = "inserir";
                }
                else
                    MessageBox.Show(quarto.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DesabilitarBotao();
            }
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastrarQuarto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.cadQuarto = null;
        }

        private void txtBuscarCodigo_KeyPress(object sender, KeyPressEventArgs e)
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
            this.CarregarDados();
            this.ListarAlaHospitalar();
        }

        private void txtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNome();
        }

        private void quartoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codQuartoTextBox.Text = quartoDataGridView.CurrentRow.Cells[0].Value.ToString();
            nomeTextBox.Text = quartoDataGridView.CurrentRow.Cells[1].Value.ToString();
            quantidade_camasTextBox.Text = quartoDataGridView.CurrentRow.Cells[2].Value.ToString();
            cbCodAla.Text = quartoDataGridView.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
