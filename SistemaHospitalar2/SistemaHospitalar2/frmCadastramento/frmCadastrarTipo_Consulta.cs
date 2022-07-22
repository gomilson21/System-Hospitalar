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
    public partial class frmCadastrarTipo_Consulta : Form
    {
        public frmCadastrarTipo_Consulta()
        {
            InitializeComponent();
        }
        Crudes tipoConsulta = new Crudes();
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");
        private string operacao = "inserir";
        private string codigo;

        public void BuscarCodigo()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT * FROM Tipo_Consulta WHERE codTipoConsulta = " + Convert.ToInt32(txtBuscarCodigo.Text), Sqlcon);
            Adpter.Fill(dados);
            tipoConsultaDataGridView.DataSource = dados;
        }

        public void BuscarNome()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT * FROM Tipo_Consulta WHERE nome_TipoConsulta LIKE '%" + txtBuscarNome.Text + "%'", Sqlcon);
            Adapter.Fill(dados);
            tipoConsultaDataGridView.DataSource = dados;
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

            nomeTextBox.ReadOnly = false;
            descricaoTextBox.ReadOnly = false;
        }

        private void frmCadastrarTipo_Consulta_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_HospitalDataSet1.Tipo_Consulta' table. You can move, or remove it, as needed.
            this.tipo_ConsultaTableAdapter.Fill(this.db_HospitalDataSet.Tipo_Consulta);
            // TODO: This line of code loads data into the 'db_HospitalDataSet.Tipo_Consulta' table. You can move, or remove it, as needed.
            this.tipo_ConsultaTableAdapter.Fill(this.db_HospitalDataSet.Tipo_Consulta);
            this.DesabilitarBotao();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            codTipoConsultaTextBox.Clear();
            nomeTextBox.Clear();
            descricaoTextBox.Clear();

            nomeTextBox.Focus();
            this.HabilitarBotao();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(tipoConsultaDataGridView.SelectedRows.Count > 0)
            {
                operacao = "editar";
                codigo = tipoConsultaDataGridView.CurrentRow.Cells[0].Value.ToString();
                nomeTextBox.Text = tipoConsultaDataGridView.CurrentRow.Cells[1].Value.ToString();
                descricaoTextBox.Text = tipoConsultaDataGridView.CurrentRow.Cells[2].Value.ToString();
                this.HabilitarBotao();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para poderes editar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tipoConsultaDataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja eliminar este dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //  Verificar Ligação Com Marcação de Cirugia
                    Sqlcon.Open();
                    DataTable tabela = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Marcacao_Consulta WHERE codTipoConsulta = '" + Convert.ToInt32(codigo) + "'", Sqlcon);
                    adapter.Fill(tabela);
                    adapter.Dispose();
                    Sqlcon.Close();

                    if (tabela.Rows.Count > 0)
                        MessageBox.Show("Este Tipo de Consulta não pode ser eliminado porque possui ligação com algum Consulta Marcada cadastrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        tipoConsulta.eliminarTipoConsulta(Convert.ToInt32(codTipoConsultaTextBox.Text));
                        if (tipoConsulta.resp.Equals("OK"))
                        {
                            MessageBox.Show("Dados do Tipo de Consulta eliminados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.tipo_ConsultaTableAdapter.Fill(this.db_HospitalDataSet.Tipo_Consulta);
                        }
                        else
                            MessageBox.Show(tipoConsulta.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para poderes editar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(operacao.Equals("inserir"))
            {
                tipoConsulta.inserirTipoConsulta(nomeTextBox.Text, descricaoTextBox.Text);
                if (tipoConsulta.resp.Equals("OK"))
                {
                    MessageBox.Show("Novo Tipo de Consulta adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tipo_ConsultaTableAdapter.Fill(this.db_HospitalDataSet.Tipo_Consulta);
                }
                else
                    MessageBox.Show(tipoConsulta.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DesabilitarBotao();
            }
            else
            {
                tipoConsulta.editarTipoConsulta(Convert.ToInt32(codTipoConsultaTextBox.Text), nomeTextBox.Text, descricaoTextBox.Text);
                if (tipoConsulta.resp.Equals("OK"))
                {
                    MessageBox.Show("Dados do Tipo de Consulta actualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.tipo_ConsultaTableAdapter.Fill(this.db_HospitalDataSet.Tipo_Consulta);
                    operacao = "inserir";
                }
                else
                    MessageBox.Show(tipoConsulta.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DesabilitarBotao();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastrarTipo_Consulta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.cadTipoConsulta = null;
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
            this.tipo_ConsultaTableAdapter.Fill(this.db_HospitalDataSet.Tipo_Consulta);
        }

        private void txtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNome();
        }

        private void tipoConsultaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codTipoConsultaTextBox.Text = tipoConsultaDataGridView.CurrentRow.Cells[0].Value.ToString();
            nomeTextBox.Text = tipoConsultaDataGridView.CurrentRow.Cells[1].Value.ToString();
            descricaoTextBox.Text = tipoConsultaDataGridView.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
