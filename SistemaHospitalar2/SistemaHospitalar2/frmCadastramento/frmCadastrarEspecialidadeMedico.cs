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
    public partial class frmCadastrarEspecialidadeMedico : Form
    {
        public frmCadastrarEspecialidadeMedico()
        {
            InitializeComponent();
        }

        Crudes espMedico = new Crudes();
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");
        private string operacao = "inserir";
        private string codigo;

        public void BuscarCodigo()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT * FROM Especialidade WHERE codEspecialidade = " + Convert.ToInt32(txtBuscarCodigo.Text), Sqlcon);
            Adpter.Fill(dados);
            espMedicoDataGridView.DataSource = dados;
        }

        public void BuscarNome()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT * FROM Especialidade_Medico WHERE nome LIKE '%" + txtBuscarNome.Text + "%'", Sqlcon);
            Adapter.Fill(dados);
            espMedicoDataGridView.DataSource = dados;
        }

        public void DesabilitarBotao()
        {
            btnNovo.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = true;
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

        private void frmCadastrarEspecialidadeMedico_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_HospitalDataSet.Especialidade_Medico' table. You can move, or remove it, as needed.
            this.especialidade_MedicoTableAdapter.Fill(this.db_HospitalDataSet.Especialidade_Medico);
            this.DesabilitarBotao();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            codEspecialidadeTextBox.Clear();
            nomeTextBox.Clear();
            descricaoTextBox.Clear();

            nomeTextBox.Focus();
            this.HabilitarBotao();
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (espMedicoDataGridView.SelectedRows.Count > 0)
            {
                operacao = "editar";
                codigo = espMedicoDataGridView.CurrentRow.Cells[0].Value.ToString();
                nomeTextBox.Text = espMedicoDataGridView.CurrentRow.Cells[1].Value.ToString();
                descricaoTextBox.Text = espMedicoDataGridView.CurrentRow.Cells[2].Value.ToString();
                this.HabilitarBotao();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para poderes editar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (espMedicoDataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja eliminar este dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //  Verificar Ligação Com Médico
                    Sqlcon.Open();
                    DataTable tabela = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Medico WHERE codEspecialidade = '" + Convert.ToInt32(codigo) + "'", Sqlcon);
                    adapter.Fill(tabela);
                    adapter.Dispose();
                    Sqlcon.Close();

                    if (tabela.Rows.Count > 0)
                        MessageBox.Show("Este Especialidade não pode ser eliminado porque possui ligação com algum Médico cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        espMedico.eliminarEspecialidadeMedico(Convert.ToInt32(codEspecialidadeTextBox.Text));
                        if (espMedico.resp.Equals("OK"))
                        {

                        }
                        else
                            MessageBox.Show(espMedico.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show("Dados da Especialidade do Médico eliminados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.especialidade_MedicoTableAdapter.Fill(this.db_HospitalDataSet.Especialidade_Medico);
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
                espMedico.inserirEspecialidadeMedico(nomeTextBox.Text, descricaoTextBox.Text);
                if (espMedico.resp.Equals("OK"))
                {
                    MessageBox.Show("Nova Especialide do Médico adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.especialidade_MedicoTableAdapter.Fill(this.db_HospitalDataSet.Especialidade_Medico);
                    
                }
                else
                    MessageBox.Show(espMedico.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DesabilitarBotao();
            }
            else
            {
                espMedico.editarEspecialidadeMedico(Convert.ToInt32(codEspecialidadeTextBox.Text), nomeTextBox.Text, descricaoTextBox.Text);
                if (espMedico.resp.Equals("OK"))
                {
                    MessageBox.Show("Dados da Especialide do Médico actualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.especialidade_MedicoTableAdapter.Fill(this.db_HospitalDataSet.Especialidade_Medico);
                    operacao = "inserir";
                   
                }
                else
                    MessageBox.Show(espMedico.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DesabilitarBotao();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastrarEspecialidadeMedico_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.cadEspMedico = null;
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
            this.txtBuscarCodigo.Clear();
            this.txtBuscarNome.Clear();
            this.especialidade_MedicoTableAdapter.Fill(this.db_HospitalDataSet.Especialidade_Medico);
        }

        private void txtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNome();
        }
    }
}
