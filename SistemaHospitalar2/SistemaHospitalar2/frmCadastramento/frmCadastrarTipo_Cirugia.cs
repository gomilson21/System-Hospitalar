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
    public partial class frmCadastrarTipo_Cirugia : Form
    {
        public frmCadastrarTipo_Cirugia()
        {
            InitializeComponent();
        }
        Crudes tipoCirugia = new Crudes();
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");
        private string operacao = "inserir";
        private string codigo;

        public void BuscarCodigo()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT * FROM Tipo_Cirugia WHERE codTipo_Cirugia = " + Convert.ToInt32(txtBuscarCodigo.Text), Sqlcon);
            Adpter.Fill(dados);
            tipoCirugiaDataGridView.DataSource = dados;
        }

        public void BuscarNome()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT * FROM Tipo_Cirugia WHERE nome_cirugia LIKE '%" + txtBuscarNome.Text + "%'", Sqlcon);
            Adapter.Fill(dados);
            tipoCirugiaDataGridView.DataSource = dados;
        }

        public void DesabilitarBotao()
        {
            btnNovo.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = true;

            nome_cirugiaTextBox.ReadOnly = true;
            descricaoTextBox.ReadOnly = true;
        }

        public void HabilitarBotao()
        {
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;

            nome_cirugiaTextBox.ReadOnly = false;
            descricaoTextBox.ReadOnly = false;
        }

        private void frmCadastrarTipo_Cirugia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_HospitalDataSet.Tipo_Cirugia' table. You can move, or remove it, as needed.
            this.tipo_CirugiaTableAdapter.Fill(this.db_HospitalDataSet.Tipo_Cirugia);
            this.DesabilitarBotao();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            codTipo_CirugiaTextBox.Clear();
            nome_cirugiaTextBox.Clear();
            descricaoTextBox.Clear();

            nome_cirugiaTextBox.Focus();
            this.HabilitarBotao();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(tipoCirugiaDataGridView.SelectedRows.Count > 0)
            {
                operacao = "editar";
                codigo = tipoCirugiaDataGridView.CurrentRow.Cells[0].Value.ToString();
                nome_cirugiaTextBox.Text = tipoCirugiaDataGridView.CurrentRow.Cells[1].Value.ToString();
                descricaoTextBox.Text = tipoCirugiaDataGridView.CurrentRow.Cells[2].Value.ToString();
                this.HabilitarBotao();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para poderes editar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tipoCirugiaDataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja eliminar este dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //  Verificar Ligação Com Marcação de Cirugia
                    Sqlcon.Open();
                    DataTable tabela = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Marcacao_Cirugia WHERE codTipoCirugia = '" + Convert.ToInt32(codigo) + "'", Sqlcon);
                    adapter.Fill(tabela);
                    adapter.Dispose();
                    Sqlcon.Close();

                    if (tabela.Rows.Count > 0)
                        MessageBox.Show("Este Tipo de Cirugia não pode ser eliminado porque possui ligação com algum Cirugia Marcada cadastrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        tipoCirugia.eliminarTipoCirugia(Convert.ToInt32(codTipo_CirugiaTextBox.Text));
                        if (tipoCirugia.resp.Equals("OK"))
                        {
                            MessageBox.Show("Dados do Tipo de Cirugia eliminados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.tipo_CirugiaTableAdapter.Fill(this.db_HospitalDataSet.Tipo_Cirugia);
                        }
                        else
                            MessageBox.Show(tipoCirugia.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if(operacao.Equals("inserir"))
            {
                tipoCirugia.inserirTipoCirugia(nome_cirugiaTextBox.Text, descricaoTextBox.Text);
                if (tipoCirugia.resp.Equals("OK"))
                {
                    MessageBox.Show("Novo Tipo de Cirugia adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tipo_CirugiaTableAdapter.Fill(this.db_HospitalDataSet.Tipo_Cirugia);
                }
                else
                    MessageBox.Show(tipoCirugia.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DesabilitarBotao();
            }
            else
            {
                tipoCirugia.editarTipoCirugia(Convert.ToInt32(codTipo_CirugiaTextBox.Text), nome_cirugiaTextBox.Text, descricaoTextBox.Text);
                if (tipoCirugia.resp.Equals("OK"))
                {
                    MessageBox.Show("Dados do Tipo de Cirugia actualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tipo_CirugiaTableAdapter.Fill(this.db_HospitalDataSet.Tipo_Cirugia);
                    operacao = "inserir";
                }
                else
                    MessageBox.Show(tipoCirugia.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DesabilitarBotao();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastrarTipo_Cirugia_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.cadTipoCirugia = null;
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
            this.tipo_CirugiaTableAdapter.Fill(this.db_HospitalDataSet.Tipo_Cirugia);
        }

        private void txtBuscarCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void tipoCirugiaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codTipo_CirugiaTextBox.Text = tipoCirugiaDataGridView.CurrentRow.Cells[0].Value.ToString();
            nome_cirugiaTextBox.Text = tipoCirugiaDataGridView.CurrentRow.Cells[1].Value.ToString();
            descricaoTextBox.Text = tipoCirugiaDataGridView.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
