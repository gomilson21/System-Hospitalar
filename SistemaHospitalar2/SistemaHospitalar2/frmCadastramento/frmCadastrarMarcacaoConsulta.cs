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
using CrystalDecisions;

namespace SistemaHospitalar2.frmCadastramento
{
    public partial class frmCadastrarMarcacaoConsulta : Form
    {
        public frmCadastrarMarcacaoConsulta()
        {
            InitializeComponent();
        }
        Crudes marcacao = new Crudes();
        Dados.Listar dados = new Dados.Listar();
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");
        private string operacao = "inserir";
        private string codigo;

        private void ListarMedico()
        {
            cbCodMedico.DataSource = dados.ComboBoxListarMedico();
            cbCodMedico.DisplayMember = "nome_medico";
            cbCodMedico.ValueMember = "codMedico";
        }

        private void ListarTipoConsulta()
        {
            cbCodTipoConsulta.DataSource = dados.ComboBoxListarTipoConsulta();
            cbCodTipoConsulta.DisplayMember = "nome_TipoConsulta";
            cbCodTipoConsulta.ValueMember = "codTipoConsulta";
        }

        private void ListarPaciente()
        {
            cbCodPaciente.DataSource = dados.ComboBoxListarPaciente();
            cbCodPaciente.DisplayMember = "nome_paciente";
            cbCodPaciente.ValueMember = "codPaciente";
        }

        private void CarregarDados()
        {
            marcacaoConsultaDataGridView.DataSource = dados.ListarMarcacaoConsulta();
        }

        public void BuscarCodigo()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codMarcacao, nome_doente, nome_TipoConsulta, nome_medico, data_consulta, data_consulta, descricao_consulta FROM Marcacao_Consulta INNER JOIN Tipo_Consulta ON (Marcacao_Consulta.codTipoConsulta = Tipo_Consulta.codTipoConsulta) INNER JOIN Medico ON (Marcacao_Consulta.codMedico = Medico.codMedico) WHERE codMarcacao = " + Convert.ToInt32(txtBuscarCodigo.Text), Sqlcon);
            Adpter.Fill(dados);
            marcacaoConsultaDataGridView.DataSource = dados;
        }

        public void BuscarNome()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT codMarcacao, nome_doente, nome_TipoConsulta, nome_medico, data_consulta, data_consulta, descricao_consulta FROM Marcacao_Consulta INNER JOIN Tipo_Consulta ON (Marcacao_Consulta.codTipoConsulta = Tipo_Consulta.codTipoConsulta) INNER JOIN Medico ON (Marcacao_Consulta.codMedico = Medico.codMedico) WHERE nome_doente LIKE '%" + txtBuscarNome.Text + "%'", Sqlcon);
            Adapter.Fill(dados);
            marcacaoConsultaDataGridView.DataSource = dados;
        }

        public void DesabilitarBotao()
        {
            btnNovo.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = true;

            descricaoTextBox.ReadOnly = true;
        }

        public void HabilitarBotao()
        {
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;

            descricaoTextBox.ReadOnly = false;
        }

        private void frmCadastrarMarcacaoConsulta_Load(object sender, EventArgs e)
        {
            // Listar Médico
            this.ListarMedico();
            // Listar Paciente no ComboBox
            this.ListarPaciente();
            // Listar Tipo de Consulta no ComboBox
            this.ListarTipoConsulta();
            // Carregar dados da Marcação da Consulta do DataGridView
            this.CarregarDados();
            this.DesabilitarBotao();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            codMarcacaoTextBox.Clear();
            descricaoTextBox.Clear();

            cbCodPaciente.Focus();
            this.HabilitarBotao();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (marcacaoConsultaDataGridView.SelectedRows.Count > 0)
            {
                operacao = "editar";
                codigo = marcacaoConsultaDataGridView.CurrentRow.Cells[0].Value.ToString();
                cbCodPaciente.Text = marcacaoConsultaDataGridView.CurrentRow.Cells[1].Value.ToString();
                cbCodTipoConsulta.Text = marcacaoConsultaDataGridView.CurrentRow.Cells[2].Value.ToString();
                cbCodMedico.Text = marcacaoConsultaDataGridView.CurrentRow.Cells[3].Value.ToString();
                dataDateTimePicker.Text = marcacaoConsultaDataGridView.CurrentRow.Cells[4].Value.ToString();
                dtpHoraConsulta.Text = marcacaoConsultaDataGridView.CurrentRow.Cells[5].Value.ToString();
                descricaoTextBox.Text = marcacaoConsultaDataGridView.CurrentRow.Cells[6].Value.ToString();
                this.HabilitarBotao();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para poderes eliminar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(marcacaoConsultaDataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja eliminar este dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    codigo = marcacaoConsultaDataGridView.CurrentRow.Cells[0].Value.ToString();
                    marcacao.eliminarMarcacaoConsulta(Convert.ToInt32(codigo));
                    if (marcacao.resp.Equals("OK"))
                    {
                        MessageBox.Show("Dados da Marcação de Consulta eliminados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarDados();
                    }
                    else
                        MessageBox.Show(marcacao.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para poderes eliminar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dataDateTimePicker.Value.Year != 2022)
            {
                MessageBox.Show("Data da Consulta inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(dataDateTimePicker, "Data da Consulta inválida!");
                dataDateTimePicker.Focus();
            }
            else
            {
                if (operacao.Equals("inserir"))
                {
                    marcacao.inserirMarcacaoConsulta(Convert.ToInt32(cbCodPaciente.SelectedValue), Convert.ToInt32(cbCodTipoConsulta.SelectedValue),
                        Convert.ToInt32(cbCodMedico.SelectedValue), Convert.ToDateTime(dataDateTimePicker.Text), dtpHoraConsulta.Text, descricaoTextBox.Text);
                    if (marcacao.resp.Equals("OK"))
                    {
                        MessageBox.Show("Nova Consulta Marcada adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarDados();
                    }
                    else
                        MessageBox.Show(marcacao.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DesabilitarBotao();
                }
                else
                {
                    marcacao.editarMarcacaoConsulta(Convert.ToInt32(codigo), Convert.ToInt32(cbCodPaciente.SelectedValue), Convert.ToInt32(cbCodTipoConsulta.SelectedValue),
                        Convert.ToInt32(cbCodMedico.SelectedValue), Convert.ToDateTime(dataDateTimePicker.Text), dtpHoraConsulta.Text, descricaoTextBox.Text);
                    if (marcacao.resp.Equals("OK"))
                    {
                        MessageBox.Show("Dados Consulta Marcada actualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarDados();
                        operacao = "inserir";
                    }
                    else
                        MessageBox.Show(marcacao.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DesabilitarBotao();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastrarMarcacaoConsulta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.cadMarcacaoConsulta = null;
        }

        //  Botão para Relatórios
        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.relMarcacaoConsulta == null)
                Referencias_Formularios.relMarcacaoConsulta = new frmRelatorio.frmRelatorio_MarcacaoConsulta();
        
            codMarcacaoTextBox.Text = marcacaoConsultaDataGridView.CurrentRow.Cells[0].Value.ToString(); ;
            Referencias_Formularios.relMarcacaoConsulta.codMarcacao = Convert.ToInt32(codMarcacaoTextBox.Text);

            Referencias_Formularios.relMarcacaoConsulta.Show();
            Referencias_Formularios.relMarcacaoConsulta.Focus();
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
            this.ListarMedico();
            this.ListarTipoConsulta();
            this.ListarPaciente();
        }

        private void txtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNome();
        }

        private void txtBuscarCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void marcacaoConsultaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codMarcacaoTextBox.Text = marcacaoConsultaDataGridView.CurrentRow.Cells[0].Value.ToString();
            cbCodPaciente.Text = marcacaoConsultaDataGridView.CurrentRow.Cells[1].Value.ToString();
            cbCodTipoConsulta.Text = marcacaoConsultaDataGridView.CurrentRow.Cells[2].Value.ToString();
            cbCodMedico.Text = marcacaoConsultaDataGridView.CurrentRow.Cells[3].Value.ToString();
            dataDateTimePicker.Text = marcacaoConsultaDataGridView.CurrentRow.Cells[4].Value.ToString();
            dtpHoraConsulta.Text = marcacaoConsultaDataGridView.CurrentRow.Cells[5].Value.ToString();
            descricaoTextBox.Text = marcacaoConsultaDataGridView.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
