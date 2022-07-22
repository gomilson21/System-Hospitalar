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
    public partial class frmCadastrarMorte_Paciente : Form
    {
        public int codPaciente;
        public frmCadastrarMorte_Paciente()
        {
            InitializeComponent();
        }
        Crudes morte = new Crudes();
        Dados.Listar dados = new Dados.Listar();
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");
        public string operacao = "inserir";
        private string codigo;

        private void ListarPaciente()
        {
            cbCodPacInternado.DataSource = dados.ListarPaciente();
            cbCodPacInternado.DisplayMember = "nome_paciente";
            cbCodPacInternado.ValueMember = "codPaciente";
        }

        private void CarregarDados()
        {
            mortePacienteDataGridView.DataSource = dados.ListarMortePaciente();
        }

        public void BuscarCodigo()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codMorte, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, data_internacao, hora_internacao, data_morte, hora_morte, causa_morte, descricao_morte FROM Morte_Paciente INNER JOIN Paciente ON (Morte_Paciente.codPaciente = Paciente.codPaciente) INNER JOIN Paciente_Internado ON (Paciente.codPaciente = Paciente_Internado.codPaciente) INNER JOIN Quarto ON (Paciente_Internado.codQuarto = Quarto.codQuarto) INNER JOIN Tratamento ON (Paciente_Internado.codTratamento = Tratamento.codTratamento) WHERE codMorte = " + Convert.ToInt32(txtBuscarCodigo.Text), Sqlcon);
            Adpter.Fill(dados);
            mortePacienteDataGridView.DataSource = dados;
        }

        public void BuscarNome()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT codMorte, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, data_internacao, hora_internacao, data_morte, hora_morte, causa_morte, descricao_morte FROM Morte_Paciente INNER JOIN Paciente ON (Morte_Paciente.codPaciente = Paciente.codPaciente) INNER JOIN Paciente_Internado ON (Paciente.codPaciente = Paciente_Internado.codPaciente) INNER JOIN Quarto ON (Paciente_Internado.codQuarto = Quarto.codQuarto) INNER JOIN Tratamento ON (Paciente_Internado.codTratamento = Tratamento.codTratamento) WHERE nome_paciente LIKE '%" + txtBuscarNome.Text + "%'", Sqlcon);
            Adapter.Fill(dados);
            mortePacienteDataGridView.DataSource = dados;
        }

        public void DesabilitarBotao()
        {
            this.btnNovo.Enabled = true;
            this.btnEditar.Enabled = true;
            this.btnExcluir.Enabled = true;
            this.btnSalvar.Enabled = false;

            txtCausaMorte.ReadOnly = true;
            descricao_morteTextBox.ReadOnly = true;
        }

        public void HabilitarBotao()
        {
            this.btnNovo.Enabled = false;
            this.btnExcluir.Enabled = false;
            this.btnSalvar.Enabled = true;
            this.btnEditar.Enabled = false;

            txtCausaMorte.ReadOnly = false;
            descricao_morteTextBox.ReadOnly = false;
        }

        private void frmAlta_PacienteInternado_Load(object sender, EventArgs e)
        {
            // Listar dados do Paciente Internado no ComboBox
            this.ListarPaciente();
            // Carregar dados da Alta do Paciente Internado no DataGridView
            this.CarregarDados();
            this.DesabilitarBotao();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCodMorte.Clear();
            txtCausaMorte.Clear();
            descricao_morteTextBox.Clear();

            cbCodPacInternado.Enabled = true;
            cbCodPacInternado.Focus();
            this.HabilitarBotao();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (mortePacienteDataGridView.SelectedRows.Count > 0)
            {
                operacao = "editar";
                codigo = mortePacienteDataGridView.CurrentRow.Cells[0].Value.ToString();
                cbCodPacInternado.Text = mortePacienteDataGridView.CurrentRow.Cells[1].Value.ToString();
                data_morteDateTimePicker.Text = mortePacienteDataGridView.CurrentRow.Cells[7].Value.ToString();
                dtpHoraMorte.Text = mortePacienteDataGridView.CurrentRow.Cells[8].Value.ToString();
                descricao_morteTextBox.Text = mortePacienteDataGridView.CurrentRow.Cells[9].Value.ToString();
                this.HabilitarBotao();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para poderes editar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (mortePacienteDataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja eliminar este dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    codigo = mortePacienteDataGridView.CurrentRow.Cells[0].Value.ToString();
                    morte.eliminarMortePaciente(Convert.ToInt32(codigo));
                    if (morte.resp.Equals("OK"))
                    {
                        MessageBox.Show("Dados do Paciente Morto eliminados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarDados();
                    }
                    else
                        MessageBox.Show(morte.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Selecione uma linha para poderes eliminar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (data_morteDateTimePicker.Value.Year != 2022)
            {
                MessageBox.Show("Valor do ano da Morte do Paciente inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(data_morteDateTimePicker, "Valor do ano da Morte do Paciente inválido!");
                data_morteDateTimePicker.Focus();
            }
            else
            {
                if (operacao.Equals("inserir"))
                {
                    morte.inserirMortePaciente(Convert.ToInt32(cbCodPacInternado.SelectedValue), Convert.ToDateTime(data_morteDateTimePicker.Text), dtpHoraMorte.Text, txtCausaMorte.Text, descricao_morteTextBox.Text);
                    if (morte.resp.Equals("OK"))
                    {
                        MessageBox.Show("Nova Paciente Morto adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarDados();
                    }
                    else
                        MessageBox.Show(morte.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DesabilitarBotao();
                }
                else if (operacao.Equals("editar"))
                {
                    morte.editarMortePaciente(Convert.ToInt32(codigo), Convert.ToInt32(cbCodPacInternado.SelectedValue), Convert.ToDateTime(data_morteDateTimePicker.Text), dtpHoraMorte.Text, txtCausaMorte.Text, descricao_morteTextBox.Text);
                    if (morte.resp.Equals("OK"))
                    {
                        MessageBox.Show("Dados do Paciente Morte actualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarDados();
                        operacao = "inserir";
                    }
                    else
                        MessageBox.Show(morte.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DesabilitarBotao();
                }
                else if (operacao.Equals("transferir"))
                {
                    morte.transferirMortePaciente(codPaciente, Convert.ToDateTime(data_morteDateTimePicker.Text), dtpHoraMorte.Text, descricao_morteTextBox.Text);
                    if (morte.resp.Equals("OK"))
                    {
                        MessageBox.Show("Processo Transferência do Paciente Internado Morto efectuado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       // morte.eliminarPacienteInternado(codPaciente);
                        this.CarregarDados();
                        operacao = "inserir";
                    }
                    else
                        MessageBox.Show(morte.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DesabilitarBotao();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastrarMorte_PacienteInternado_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.cadMortePaciente = null;
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
            this.ListarPaciente();
        }

        private void txtBuscarNome_TextChanged_1(object sender, EventArgs e)
        {
            this.BuscarNome();
        }

        private void mortePacienteDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codMedicoTextBox.Text = mortePacienteDataGridView.CurrentRow.Cells[0].Value.ToString();
            cbCodPacInternado.Text = mortePacienteDataGridView.CurrentRow.Cells[1].Value.ToString();
            data_morteDateTimePicker.Text = mortePacienteDataGridView.CurrentRow.Cells[7].Value.ToString();
            dtpHoraMorte.Text = mortePacienteDataGridView.CurrentRow.Cells[8].Value.ToString();
            descricao_morteTextBox.Text = mortePacienteDataGridView.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.relObito == null)
                Referencias_Formularios.relObito = new frmRelatorio.frmRelatorio_Obito();

            txtCodMorte.Text = mortePacienteDataGridView.CurrentRow.Cells[0].Value.ToString(); ;
            Referencias_Formularios.relObito.codObito = Convert.ToInt32(txtCodMorte.Text);

            Referencias_Formularios.relObito.Show();
            Referencias_Formularios.relObito.Focus();
        }
    }
}
