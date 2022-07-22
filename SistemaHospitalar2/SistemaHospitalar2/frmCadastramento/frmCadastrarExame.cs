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
    public partial class frmCadastrarExame : Form
    {
        public frmCadastrarExame()
        {
            InitializeComponent();
        }
        Crudes exame = new Crudes();
        Dados.Listar exame1 = new Dados.Listar();
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");
        private string operacao = "inserir";
        private string codigo;

        public void CarregarDados()
        {
            exameDataGridView.DataSource = exame1.ListarExame();
        }

        public void BuscarCodigo()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codExame, nome_exame, descricao_exame, nome_tipoExame FROM Exame INNER JOIN Tipo_Exame ON (Exame.codTipoExame = Tipo_Exame.codTipoExame) WHERE codExame = " + Convert.ToInt32(txtBuscarCodigo.Text), Sqlcon);
            Adpter.Fill(dados);
            exameDataGridView.DataSource = dados;
        }

        public void BuscarNome()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT codExame, nome_exame, descricao_exame, nome_tipoExame FROM Exame INNER JOIN Tipo_Exame ON (Exame.codTipoExame = Tipo_Exame.codTipoExame) WHERE nome_exame LIKE '%" + txtBuscarNome.Text + "%'", Sqlcon);
            Adapter.Fill(dados);
            exameDataGridView.DataSource = dados;
        }

        public void DesabilitarBotao()
        {
            btnNovo.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = true;

            nomeTextBox.ReadOnly = true;
            descricaoTextBox.ReadOnly = true;
        }

        public void HabilitarBotao()
        {
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;

            // Habilitar textBox
            nomeTextBox.ReadOnly = false; 
            descricaoTextBox.ReadOnly = false;
        }

        private void frmCadastarExame_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_HospitalDataSet.Tipo_Exame' table. You can move, or remove it, as needed.
            this.tipo_ExameTableAdapter.Fill(this.db_HospitalDataSet.Tipo_Exame);
            // TODO: This line of code loads data into the 'db_HospitalDataSet.Exame' table. You can move, or remove it, as needed.
            this.CarregarDados();
            this.DesabilitarBotao();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            codExameTextBox.Clear();
            nomeTextBox.Clear();
            descricaoTextBox.Clear();

            nomeTextBox.Focus();
            this.HabilitarBotao();     
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(exameDataGridView.SelectedRows.Count > 0)
            {
                operacao = "editar";
                codigo = exameDataGridView.CurrentRow.Cells[0].Value.ToString();
                nomeTextBox.Text = exameDataGridView.CurrentRow.Cells[1].Value.ToString();
                codTipoExameComboBox.Text = exameDataGridView.CurrentRow.Cells[2].Value.ToString();
                descricaoTextBox.Text = exameDataGridView.CurrentRow.Cells[3].Value.ToString();    
                this.HabilitarBotao();
            }
            else
            {
                MessageBox.Show("Seleciona uma linha para poderes editar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(exameDataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja eliminar este dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    exame.eliminarExame(Convert.ToInt32(codExameTextBox.Text));
                    if (exame.resp == "OK")
                    {
                        MessageBox.Show("Dados do exame eliminados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarDados();
                    }
                    else
                        MessageBox.Show(exame.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleciona uma linha para poderes eliminar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(operacao == "inserir")
            {
                exame.inserirExame(nomeTextBox.Text, descricaoTextBox.Text, Convert.ToInt32(codTipoExameComboBox.SelectedValue));
                if (exame.resp == "OK")
                {
                    MessageBox.Show("Novo exame cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CarregarDados();
                    this.DesabilitarBotao();
                }
                else
                    MessageBox.Show(exame.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                exame.editarExame(Convert.ToInt32(codigo), nomeTextBox.Text, descricaoTextBox.Text, Convert.ToInt32(codTipoExameComboBox.SelectedValue));
                if (exame.resp == "OK")
                {
                    MessageBox.Show("Dados do Exame actualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CarregarDados();
                    this.DesabilitarBotao();
                }
                else
                    MessageBox.Show(exame.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            operacao = "inserir";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastrarExame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.cadExame = null;
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
        }

        private void exameDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codExameTextBox.Text = exameDataGridView.CurrentRow.Cells[0].Value.ToString();
            nomeTextBox.Text = exameDataGridView.CurrentRow.Cells[1].Value.ToString();
            codTipoExameComboBox.Text = exameDataGridView.CurrentRow.Cells[2].Value.ToString();
            descricaoTextBox.Text = exameDataGridView.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
