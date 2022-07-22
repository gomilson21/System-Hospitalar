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
    public partial class frmCadastrarPacienteInternado : Form
    {
        public frmCadastrarPacienteInternado()
        {
            InitializeComponent();
        }
        Crudes pacInternado = new Crudes();
        Dados.Listar dados = new Dados.Listar();
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");
        private string operacao = "inserir";
        private string codigo;

        private void ListarPaciente()
        {
            cbCodPaciente.DataSource = dados.ListarPaciente();
            cbCodPaciente.DisplayMember = "nome_paciente";
            cbCodPaciente.ValueMember = "codPaciente";
        }

        private void ListarQuarto()
        {
            cbCodQuarto.DataSource = dados.ComboBoxListarQuarto();
            cbCodQuarto.DisplayMember = "nome_quarto";
            cbCodQuarto.ValueMember = "codQuarto";
        }

        private void ListarTratamento()
        {
            cbCodTratamento.DataSource = dados.ComboBoxListarTratamento();
            cbCodTratamento.DisplayMember = "nome_tratamento";
            cbCodTratamento.ValueMember = "codTratamento";
        }

        private void ListarMedico()
        {
            cbCodMedico.DataSource = dados.ComboBoxListarMedico();
            cbCodMedico.DisplayMember = "nome_medico";
            cbCodMedico.ValueMember = "codMedico";
        }

        private void CarregarDados()
        {
            pacienteInternadoDataGridView.DataSource = dados.ListarPacienteInternado();
        }

        public void BuscarCodigo()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codPacienteInternado, nome_Paciente, nome_quarto, numeroCama_PacienteInternado, estadoCama_PacienteInternado, nome_tratamento, nome_medico, EstadoClinico_PacienteInternado, data_internacao, hora_internacao, descricao_PacienteInternado FROM Paciente_Internado INNER JOIN Paciente ON (Paciente.codPaciente = Paciente_Internado.codPaciente) INNER JOIN Quarto ON (Paciente_Internado.codQuarto = Quarto.codQuarto) INNER JOIN Tratamento ON (Paciente_Internado.codTratamento = Tratamento.codTratamento) INNER JOIN Medico ON (Paciente_Internado.codMedico = Medico.codMedico) WHERE codPacienteInternado = " + Convert.ToInt32(txtBuscarCodigo.Text), Sqlcon);
            Adpter.Fill(dados);
            pacienteInternadoDataGridView.DataSource = dados;
        }

        public void BuscarNome()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT codPacienteInternado, nome_Paciente, nome_quarto, numeroCama_PacienteInternado, estadoCama_PacienteInternado, nome_tratamento, nome_medico, EstadoClinico_PacienteInternado, data_internacao, hora_internacao, descricao_PacienteInternado FROM Paciente_Internado INNER JOIN Paciente ON (Paciente.codPaciente = Paciente_Internado.codPaciente) INNER JOIN Quarto ON (Paciente_Internado.codQuarto = Quarto.codQuarto) INNER JOIN Tratamento ON (Paciente_Internado.codTratamento = Tratamento.codTratamento) INNER JOIN Medico ON (Paciente_Internado.codMedico = Medico.codMedico) WHERE nome_paciente LIKE '%" + txtBuscarNome.Text + "%'", Sqlcon);
            Adapter.Fill(dados);
            pacienteInternadoDataGridView.DataSource = dados;
        }

        public void DesabilitarBotao()
        {
            this.btnNovo.Enabled = true;
            this.btnEditar.Enabled = true;
            this.btnExcluir.Enabled = true;
            this.btnSalvar.Enabled = false;

            estado_clinicoTextBox.ReadOnly = true;
            descricaoTextBox.ReadOnly = true;
        }

        public void HabilitarBotao()
        {
            this.btnNovo.Enabled = false;
            this.btnExcluir.Enabled = false;
            this.btnSalvar.Enabled = true;
            this.btnEditar.Enabled = false;

            estado_clinicoTextBox.ReadOnly = false;
            descricaoTextBox.ReadOnly = false;
        }
        
        private void frmCadastrarPaciente_Load(object sender, EventArgs e)
        {
            // Carregar dados do Paciente no ComboBox
            this.ListarPaciente();
            // Carregar dados do Quarto no ComboBox
            this.ListarQuarto();
            // Carregar dados do Tratamento no ComboBox
            this.ListarTratamento();
            // Carregar dados do Médico no ComboBox
            this.ListarMedico();
            //  Carregar dados do Paciente Internado no DataGridView
            this.CarregarDados();
            this.DesabilitarBotao();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            codPacienteInternadoTextBox.Clear();
            estado_clinicoTextBox.Clear();
            descricaoTextBox.Clear();

            cbCodPaciente.Focus();
            this.HabilitarBotao();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(pacienteInternadoDataGridView.SelectedRows.Count > 0)
            {
                operacao = "editar";
                codigo = pacienteInternadoDataGridView.CurrentRow.Cells[0].Value.ToString();
                cbCodPaciente.Text = pacienteInternadoDataGridView.CurrentRow.Cells[1].Value.ToString();
                cbCodQuarto.Text = pacienteInternadoDataGridView.CurrentRow.Cells[2].Value.ToString();
                cbNumeroCama.Text = pacienteInternadoDataGridView.CurrentRow.Cells[3].Value.ToString();
                cbEstadoCama.Text = pacienteInternadoDataGridView.CurrentRow.Cells[4].Value.ToString();
                cbCodTratamento.Text = pacienteInternadoDataGridView.CurrentRow.Cells[5].Value.ToString();
                cbCodMedico.Text = pacienteInternadoDataGridView.CurrentRow.Cells[6].Value.ToString();
                estado_clinicoTextBox.Text = pacienteInternadoDataGridView.CurrentRow.Cells[7].Value.ToString();
                data_internacaoDateTimePicker.Text = pacienteInternadoDataGridView.CurrentRow.Cells[8].Value.ToString();
                dtpHoraInternacao.Text = pacienteInternadoDataGridView.CurrentRow.Cells[9].Value.ToString();
                descricaoTextBox.Text = pacienteInternadoDataGridView.CurrentRow.Cells[10].Value.ToString();
                this.HabilitarBotao();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para poderes editar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (pacienteInternadoDataGridView.SelectedRows.Count > 0)
            {
                if(MessageBox.Show("Tem certeza que deseja eliminar este dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    codigo = pacienteInternadoDataGridView.CurrentRow.Cells[0].Value.ToString();
                    pacInternado.eliminarPacienteInternado(Convert.ToInt32(codigo));
                    if (pacInternado.resp.Equals("OK"))
                    {
                        MessageBox.Show("Dados do Paciente Internado eliminados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarDados();
                    }
                    else
                        MessageBox.Show(pacInternado.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }  
            }
            else
            {
                MessageBox.Show("Selecione uma linha para poderes eliminar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Data de Internação do Paciente Internado
            if (data_internacaoDateTimePicker.Value.Year != 2022)
            {
                MessageBox.Show("Data de Internação inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(data_internacaoDateTimePicker, "Data de Internação inválida!");
                data_internacaoDateTimePicker.Focus();
            }
            else
            {
                if (operacao.Equals("inserir"))
                {
                    pacInternado.inserirPacienteInternado(Convert.ToInt32(cbCodPaciente.SelectedValue), Convert.ToInt32(cbCodQuarto.SelectedValue), Convert.ToInt32(cbNumeroCama.SelectedItem), Convert.ToString(cbEstadoCama.SelectedItem),
                        Convert.ToInt32(cbCodTratamento.SelectedValue), Convert.ToInt32(cbCodMedico.SelectedValue), estado_clinicoTextBox.Text, Convert.ToDateTime(data_internacaoDateTimePicker.Text), dtpHoraInternacao.Text, descricaoTextBox.Text);
                    if (pacInternado.resp.Equals("OK"))
                    {
                        MessageBox.Show("Novo Paciente Internado adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarDados();
                        this.DesabilitarBotao();
                    }
                    else
                        MessageBox.Show(pacInternado.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DesabilitarBotao();
                }
                else
                {
                    pacInternado.editarPacienteInternado(Convert.ToInt32(codigo), Convert.ToInt32(cbCodPaciente.SelectedValue), Convert.ToInt32(cbCodQuarto.SelectedValue), Convert.ToInt32(cbNumeroCama.SelectedItem), Convert.ToString(cbEstadoCama.SelectedItem),
                        Convert.ToInt32(cbCodTratamento.SelectedValue), Convert.ToInt32(cbCodMedico.SelectedValue), estado_clinicoTextBox.Text, Convert.ToDateTime(data_internacaoDateTimePicker.Text), dtpHoraInternacao.Text, descricaoTextBox.Text);
                    if (pacInternado.resp.Equals("OK"))
                    {
                        MessageBox.Show("Dados do Paciente Internado actualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarDados();
                        operacao = "inserir";
                    }
                    else
                        MessageBox.Show(pacInternado.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DesabilitarBotao();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void telefoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void frmCadastrarPaciente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.cadPacInternado = null;
        }

        private void txtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNome();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (txtBuscarCodigo.Text == string.Empty)
                MessageBox.Show("Insira um código!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                this.BuscarCodigo();
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            txtBuscarCodigo.Clear();
            txtBuscarNome.Clear();
            this.CarregarDados();
            this.ListarPaciente();
            this.ListarQuarto();
            this.ListarTratamento();
            this.ListarMedico();
        }

        private void btnPrognostico_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.relPrognostico == null)
                Referencias_Formularios.relPrognostico = new frmRelatorio.frmRelatorio_Prognostico();

            Referencias_Formularios.relPrognostico.Show();
            Referencias_Formularios.relPrognostico.Focus();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.cadAltaPaciente == null)
                Referencias_Formularios.cadAltaPaciente = new frmCadastramento.frmCadastrarAlta_PacienteInternado();

            Referencias_Formularios.cadAltaPaciente.codPacInternado = pacienteInternadoDataGridView.CurrentRow.Cells[0].Value.ToString();
            Referencias_Formularios.cadAltaPaciente.Show();
            Referencias_Formularios.cadAltaPaciente.operacao = "transferir";
            Referencias_Formularios.cadAltaPaciente.cbCodPacInternado.Enabled = false;
            Referencias_Formularios.cadAltaPaciente.HabilitarBotao();
            Referencias_Formularios.cadAltaPaciente.Focus();
            Referencias_Formularios.cadAltaPaciente.Refresh();
        }

        private void btnObito_Click(object sender, EventArgs e)
        {
            if (pacienteInternadoDataGridView.SelectedRows.Count > 0)
            {
                if (Referencias_Formularios.cadMortePaciente == null)
                    Referencias_Formularios.cadMortePaciente = new frmCadastramento.frmCadastrarMorte_Paciente();

                Referencias_Formularios.cadMortePaciente.codPaciente = Convert.ToInt32(cbCodPaciente.SelectedValue);
                Referencias_Formularios.cadMortePaciente.Show();
                Referencias_Formularios.cadMortePaciente.operacao = "transferir";
                Referencias_Formularios.cadMortePaciente.cbCodPacInternado.Enabled = false;
                Referencias_Formularios.cadMortePaciente.HabilitarBotao();
                Referencias_Formularios.cadMortePaciente.Focus();
            }
            else
                MessageBox.Show("Selecione uma linha para poderes realizar esta Transferência!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSolExame_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.relSolicitacaoExame == null)
                Referencias_Formularios.relSolicitacaoExame = new frmRelatorio.frmRelatorio_SolicitacaoExame();

            codPacienteInternadoTextBox.Text = pacienteInternadoDataGridView.CurrentRow.Cells[0].Value.ToString(); ;
            Referencias_Formularios.relSolicitacaoExame.codPacInternado = Convert.ToInt32(codPacienteInternadoTextBox.Text);
            Referencias_Formularios.relSolicitacaoExame.operacao = "Paciente Internado";

            Referencias_Formularios.relSolicitacaoExame.Show();
            Referencias_Formularios.relSolicitacaoExame.Focus();
        }

        private void pacienteInternadoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codPacienteInternadoTextBox.Text = pacienteInternadoDataGridView.CurrentRow.Cells[0].Value.ToString();
            cbCodPaciente.Text = pacienteInternadoDataGridView.CurrentRow.Cells[1].Value.ToString();
            cbCodQuarto.Text = pacienteInternadoDataGridView.CurrentRow.Cells[2].Value.ToString();
            cbNumeroCama.Text = pacienteInternadoDataGridView.CurrentRow.Cells[3].Value.ToString();
            cbEstadoCama.Text = pacienteInternadoDataGridView.CurrentRow.Cells[4].Value.ToString();
            cbCodTratamento.Text = pacienteInternadoDataGridView.CurrentRow.Cells[5].Value.ToString();
            cbCodMedico.Text = pacienteInternadoDataGridView.CurrentRow.Cells[6].Value.ToString();
            estado_clinicoTextBox.Text = pacienteInternadoDataGridView.CurrentRow.Cells[7].Value.ToString();
            data_internacaoDateTimePicker.Text = pacienteInternadoDataGridView.CurrentRow.Cells[8].Value.ToString();
            dtpHoraInternacao.Text = pacienteInternadoDataGridView.CurrentRow.Cells[9].Value.ToString();
            descricaoTextBox.Text = pacienteInternadoDataGridView.CurrentRow.Cells[10].Value.ToString();
        }
    }
}
