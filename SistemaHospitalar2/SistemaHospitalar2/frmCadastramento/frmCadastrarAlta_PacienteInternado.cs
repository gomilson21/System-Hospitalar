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
    public partial class frmCadastrarAlta_PacienteInternado : Form
    {
        public string codPacInternado;
        public frmCadastrarAlta_PacienteInternado()
        {
            InitializeComponent();
        }
        Crudes alta = new Crudes();
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
            altaPacienteDataGridView.DataSource = dados.ListarAltaPacienteInternado();
        }

        public void BuscarCodigo()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codAlta, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, data_internacao, hora_internacao, data_alta, hora_alta, data_regresso, dias_repouso, descricao_alta FROM Alta_Paciente_Internado INNER JOIN Paciente_Internado ON (Alta_Paciente_Internado.codPacienteInternado = Paciente_Internado.codPacienteInternado) INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Quarto ON (Quarto.codQuarto = Paciente_Internado.codQuarto) INNER JOIN Tratamento ON (Tratamento.codTratamento = Paciente_Internado.codTratamento) WHERE codAlta = " + Convert.ToInt32(txtBuscarCodigo.Text), Sqlcon);
            Adpter.Fill(dados);
            altaPacienteDataGridView.DataSource = dados;
        }

        public void BuscarNome()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT codAlta, nome_paciente, nome_quarto, numeroCama_PacienteInternado, nome_tratamento, data_internacao, hora_internacao, data_alta, hora_alta, data_regresso, dias_repouso, descricao_alta FROM Alta_Paciente_Internado INNER JOIN Paciente_Internado ON (Alta_Paciente_Internado.codPacienteInternado = Paciente_Internado.codPacienteInternado) INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Quarto ON (Quarto.codQuarto = Paciente_Internado.codQuarto) INNER JOIN Tratamento ON (Tratamento.codTratamento = Paciente_Internado.codTratamento) WHERE nome_paciente LIKE '%" + txtBuscarNome.Text + "%'", Sqlcon);
            Adapter.Fill(dados);
            altaPacienteDataGridView.DataSource = dados;
        }

        public void DesabilitarBotao()
        {
            this.btnNovo.Enabled = true;
            this.btnEditar.Enabled = true;
            this.btnExcluir.Enabled = true;
            this.btnSalvar.Enabled = false;

            diasRepouso.ReadOnly = true;
            descricao_altaTextBox.ReadOnly = true;
        }

        public void HabilitarBotao()
        {
            this.btnNovo.Enabled = false;
            this.btnExcluir.Enabled = false;
            this.btnSalvar.Enabled = true;
            this.btnEditar.Enabled = false;

            diasRepouso.ReadOnly = false;
            descricao_altaTextBox.ReadOnly = false;
        }

        private void frmCadastrarAlta_PacienteInternado_Load(object sender, EventArgs e)
        {
            // Listar dados do Paciente Internado no ComboBox
            this.ListarPaciente();
            // Carregar dados da Alta do Paciente Internado no DataGridView
            this.CarregarDados();
            this.DesabilitarBotao();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            codAltaTextBox.Clear();
            descricao_altaTextBox.Clear();

            cbCodPacInternado.Enabled = true;
            cbCodPacInternado.Focus();
            this.HabilitarBotao();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (altaPacienteDataGridView.SelectedRows.Count > 0)
            {
                operacao = "editar";
                codigo = altaPacienteDataGridView.CurrentRow.Cells[0].Value.ToString();
                cbCodPacInternado.Text = altaPacienteDataGridView.CurrentRow.Cells[1].Value.ToString();
                data_altaDateTimePicker.Text = altaPacienteDataGridView.CurrentRow.Cells[7].Value.ToString();
                dtpHoraConsulta.Text = altaPacienteDataGridView.CurrentRow.Cells[8].Value.ToString();
                dtpDataRegresso.Text = altaPacienteDataGridView.CurrentRow.Cells[9].Value.ToString();
                diasRepouso.Text = altaPacienteDataGridView.CurrentRow.Cells[10].Value.ToString();
                descricao_altaTextBox.Text = altaPacienteDataGridView.CurrentRow.Cells[11].Value.ToString();
                this.HabilitarBotao();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para poderes editar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (altaPacienteDataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja eliminar este dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    codigo = altaPacienteDataGridView.CurrentRow.Cells[0].Value.ToString();
                    alta.eliminarAltaPaciente(Convert.ToInt32(codigo));
                    if (alta.resp == "OK")
                    {
                        MessageBox.Show("Dados da Alta do Paciente Internado eliminados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarDados();
                    }
                    else
                        MessageBox.Show(alta.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para poderes eliminar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (data_altaDateTimePicker.Value.Year != 2022)
            {
                MessageBox.Show("O ano da Data da Alta está invalido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(data_altaDateTimePicker, "O ano da Data da Alta está invalido!");
                data_altaDateTimePicker.Focus();
            }
            else if (dtpDataRegresso.Value.Year != 2022)
            {
                MessageBox.Show("O ano da Data de Regresso ao Hospital está invalido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(dtpDataRegresso, "O ano da Data de Regresso ao Hospital está invalido!");
                dtpDataRegresso.Focus();
            }
            else if (dtpDataRegresso.Value.Month < data_altaDateTimePicker.Value.Month)
            {
                MessageBox.Show("O Mês da Data de Regresso ao Hospital não \n pode ser menor que o Mês da Alta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(dtpDataRegresso, "O ano da Data de Regresso ao Hospital está invalido!");
                dtpDataRegresso.Focus();
            }
            else
            {
                if (operacao.Equals("inserir"))
                {
                    alta.inserirAltaPaciente(Convert.ToInt32(cbCodPacInternado.SelectedValue), Convert.ToDateTime(data_altaDateTimePicker.Text), dtpHoraConsulta.Text, Convert.ToDateTime(dtpDataRegresso.Text), Convert.ToInt32(diasRepouso.Value), descricao_altaTextBox.Text);
                    if (alta.resp.Equals("OK"))
                    {
                        MessageBox.Show("Nova Alta do Paciente Internado adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DesabilitarBotao();
                    }
                    else
                        MessageBox.Show(alta.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DesabilitarBotao();
                }
                else if (operacao.Equals("editar"))
                {
                    alta.editarAltaPaciente(Convert.ToInt32(codigo), Convert.ToInt32(cbCodPacInternado.SelectedValue), Convert.ToDateTime(data_altaDateTimePicker.Text), dtpHoraConsulta.Text, Convert.ToDateTime(dtpDataRegresso.Text), Convert.ToInt32(diasRepouso.Value), descricao_altaTextBox.Text);
                    if (alta.resp.Equals("OK"))
                    {
                        MessageBox.Show("Dados da Alta do Paciente Internado actualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarDados();
                        operacao = "inserir";
                    }
                    else
                        MessageBox.Show(alta.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DesabilitarBotao();
                }
                else if (operacao.Equals("transferir"))
                {
                    alta.transferirAltaPaciente(Convert.ToInt32(codPacInternado), Convert.ToDateTime(data_altaDateTimePicker.Text), dtpHoraConsulta.Text, descricao_altaTextBox.Text);
                    if (alta.resp.Equals("OK"))
                    {
                        MessageBox.Show("Processo da Alta do Paciente Internado efectuado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        alta.eliminarPacienteInternado(Convert.ToInt32(codPacInternado));
                        this.CarregarDados();
                        operacao = "inserir";
                    }
                    else
                        MessageBox.Show(alta.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DesabilitarBotao();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastrarAlta_PacienteInternado_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.cadAltaPaciente = null;
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

        private void altaPacienteDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codAltaTextBox.Text = altaPacienteDataGridView.CurrentRow.Cells[0].Value.ToString();
            cbCodPacInternado.Text = altaPacienteDataGridView.CurrentRow.Cells[1].Value.ToString();
            data_altaDateTimePicker.Text = altaPacienteDataGridView.CurrentRow.Cells[7].Value.ToString();
            dtpHoraConsulta.Text = altaPacienteDataGridView.CurrentRow.Cells[8].Value.ToString();
            dtpDataRegresso.Text = altaPacienteDataGridView.CurrentRow.Cells[9].Value.ToString();
            diasRepouso.Text = altaPacienteDataGridView.CurrentRow.Cells[10].Value.ToString();
            descricao_altaTextBox.Text = altaPacienteDataGridView.CurrentRow.Cells[11].Value.ToString();
        }

        private void btnRelAlta_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.relAlta == null)
                Referencias_Formularios.relAlta = new frmRelatorio.frmRelatorio_AltaHospitalar();

            codAltaTextBox.Text = altaPacienteDataGridView.CurrentRow.Cells[0].Value.ToString(); ;
            Referencias_Formularios.relAlta.codAlta = Convert.ToInt32(codAltaTextBox.Text);

            Referencias_Formularios.relAlta.Show();
            Referencias_Formularios.relAlta.Focus();
        }

        private void btnJustificativo_Click(object sender, EventArgs e)
        {
             if (Referencias_Formularios.relJustificativo == null)
                Referencias_Formularios.relJustificativo = new frmRelatorio.frmRelatorio_Justificativo();

            codAltaTextBox.Text = altaPacienteDataGridView.CurrentRow.Cells[0].Value.ToString(); ;
            Referencias_Formularios.relJustificativo.codAlta = Convert.ToInt32(codAltaTextBox.Text);
            Referencias_Formularios.relJustificativo.operacao = "Alta Hospitalar";

            Referencias_Formularios.relJustificativo.Show();
            Referencias_Formularios.relJustificativo.Focus();
        }
    }
}
