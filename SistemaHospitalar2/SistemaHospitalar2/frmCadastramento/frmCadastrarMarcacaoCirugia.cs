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
    public partial class frmCadastrarMarcacaoCirugia : Form
    {
        public frmCadastrarMarcacaoCirugia()
        {
            InitializeComponent();
        }

        Crudes cirugia = new Crudes();
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

        private void ListarPacienteInternado()
        {
            cbCodPacInternado.DataSource = dados.ComboBoxListarPacienteInternado();
            cbCodPacInternado.DisplayMember = "nome_PacienteInternado";
            cbCodPacInternado.ValueMember = "codPacienteInternado";
        }

        private void ListarTipoCirugia()
        {
            cbCodTipoCirugia.DataSource = dados.ComboBoxListarTipoCirugia();
            cbCodTipoCirugia.DisplayMember = "nome_cirugia";
            cbCodTipoCirugia.ValueMember = "codTipoCirugia";
        }

        public void CarregarDados()
        {
            marcacaoCirugiaDataGridView.DataSource = dados.ListarMarcacaoCirugia();
        }

        public void BuscarCodigo()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codCirugia, nome_paciente, nome_TipoCirugia, nome_medico, data_cirugia, hora_cirugia, descricao_cirugia FROM Marcacao_Cirugia INNER JOIN Paciente_Internado ON (Marcacao_Cirugia.codPacienteInternado = Paciente_Internado.codPacienteInternado) INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Tipo_Cirugia ON (Marcacao_Cirugia.codTipoCirugia = Tipo_Cirugia.codTipoCirugia) INNER JOIN Medico ON (Marcacao_Cirugia.codMedico = Medico.codMedico) WHERE codCirugia = " + Convert.ToInt32(txtBuscarCodigo.Text), Sqlcon);
            Adpter.Fill(dados);
            marcacaoCirugiaDataGridView.DataSource = dados;
        }

        public void BuscarNome()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT codCirugia, nome_paciente, nome_TipoCirugia, nome_medico, data_cirugia, hora_cirugia, descricao_cirugia FROM Marcacao_Cirugia INNER JOIN Paciente_Internado ON (Marcacao_Cirugia.codPacienteInternado = Paciente_Internado.codPacienteInternado) INNER JOIN Paciente ON (Paciente_Internado.codPaciente = Paciente.codPaciente) INNER JOIN Tipo_Cirugia ON (Marcacao_Cirugia.codTipoCirugia = Tipo_Cirugia.codTipoCirugia) INNER JOIN Medico ON (Marcacao_Cirugia.codMedico = Medico.codMedico) WHERE nome_paciente LIKE '%" + txtBuscarNome.Text + "%'", Sqlcon);
            Adapter.Fill(dados);
            marcacaoCirugiaDataGridView.DataSource = dados;
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

        private void frmCadastrarMarcacaoCirugia_Load(object sender, EventArgs e)
        {
            // Listar os Dados Paciente Internado no ComboBox
            this.ListarPacienteInternado();
            // Listar os Dados Paciente Internado no ComboBox
            this.ListarMedico();
            // Listar os Dados Tipo de Cirugia no ComboBox
            this.ListarTipoCirugia();
            // Carregar dados da Marcação da Cirugia do DataGridView
            this.CarregarDados();
            this.DesabilitarBotao();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            codCirugiaTextBox.Clear();
            descricaoTextBox.Clear();

            this.HabilitarBotao();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (marcacaoCirugiaDataGridView.SelectedRows.Count > 0)
            {
                operacao = "editar";
                codigo = marcacaoCirugiaDataGridView.CurrentRow.Cells[0].Value.ToString();
                cbCodPacInternado.Text = marcacaoCirugiaDataGridView.CurrentRow.Cells[1].Value.ToString();
                cbCodTipoCirugia.Text = marcacaoCirugiaDataGridView.CurrentRow.Cells[2].Value.ToString();
                cbCodMedico.Text = marcacaoCirugiaDataGridView.CurrentRow.Cells[3].Value.ToString();
                data_cirugiaDateTimePicker.Text = marcacaoCirugiaDataGridView.CurrentRow.Cells[4].Value.ToString();
                dtpHoraConsulta.Text = marcacaoCirugiaDataGridView.CurrentRow.Cells[5].Value.ToString();
                descricaoTextBox.Text = marcacaoCirugiaDataGridView.CurrentRow.Cells[6].Value.ToString();
                this.HabilitarBotao();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para poderes editar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(marcacaoCirugiaDataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja eliminar este dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    codigo = marcacaoCirugiaDataGridView.CurrentRow.Cells[0].Value.ToString();
                    cirugia.eliminarMarcacaoCirugia(Convert.ToInt32(codigo));
                    if (cirugia.resp == "OK")
                    {
                        MessageBox.Show("Dados da Marcação de Cirugia eliminados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarDados();
                    }
                    else
                        MessageBox.Show(cirugia.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para poderes eliminar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (data_cirugiaDateTimePicker.Value.Year != 2022)
            {
                MessageBox.Show("Data da Consulta inválida!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(data_cirugiaDateTimePicker, "Data da Consulta inválida!");
                data_cirugiaDateTimePicker.Focus();
            }
            else
            {
                if (operacao == "inserir")
                {
                    cirugia.inserirMarcacaoCirugia(Convert.ToInt32(cbCodPacInternado.SelectedValue), Convert.ToInt32(cbCodTipoCirugia.SelectedValue),
                   Convert.ToInt32(cbCodMedico.SelectedValue), Convert.ToDateTime(data_cirugiaDateTimePicker.Text), dtpHoraConsulta.Text, descricaoTextBox.Text);
                    if (cirugia.resp.Equals("OK"))
                    {
                        MessageBox.Show("Nova Marcação de Cirugia adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarDados();
                    }
                    else
                        MessageBox.Show(cirugia.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DesabilitarBotao();
                }
                else if (operacao.Equals("editar"))
                {
                    cirugia.editarMarcacaoCirugia(Convert.ToInt32(codigo), Convert.ToInt32(cbCodPacInternado.SelectedValue), Convert.ToInt32(cbCodTipoCirugia.SelectedValue),
                        Convert.ToInt32(cbCodMedico.SelectedValue), Convert.ToDateTime(data_cirugiaDateTimePicker.Text), dtpHoraConsulta.Text, descricaoTextBox.Text);
                    if (cirugia.resp.Equals("OK"))
                    {
                        MessageBox.Show("Dados da Marcação de Cirugia actualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarDados();
                        operacao = "inserir";
                    }
                    else
                        MessageBox.Show(cirugia.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DesabilitarBotao();
                }
            }
        }
        

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastrarMarcacaoCirugia_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.cadMarcacaoCirugia = null;
        }

        private void txtBuscarCodigo_TextChanged(object sender, EventArgs e)
        {
            //this.BuscarCodigo();
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
            this.ListarMedico();
            this.ListarPacienteInternado();
            this.ListarTipoCirugia();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            if (Referencias_Formularios.relMarcacaoCirugia == null)
                Referencias_Formularios.relMarcacaoCirugia = new frmRelatorio.frmRelatorio_MarcacaoCirugia();

            codCirugiaTextBox.Text = marcacaoCirugiaDataGridView.CurrentRow.Cells[0].Value.ToString(); ;
            Referencias_Formularios.relMarcacaoCirugia.codCirugia = Convert.ToInt32(codCirugiaTextBox.Text);

            Referencias_Formularios.relMarcacaoCirugia.Show();
            Referencias_Formularios.relMarcacaoCirugia.Focus();
        }

        private void marcacaoCirugiaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codCirugiaTextBox.Text = marcacaoCirugiaDataGridView.CurrentRow.Cells[0].Value.ToString();
            cbCodPacInternado.Text = marcacaoCirugiaDataGridView.CurrentRow.Cells[1].Value.ToString();
            cbCodTipoCirugia.Text = marcacaoCirugiaDataGridView.CurrentRow.Cells[2].Value.ToString();
            cbCodMedico.Text = marcacaoCirugiaDataGridView.CurrentRow.Cells[3].Value.ToString();
            data_cirugiaDateTimePicker.Text = marcacaoCirugiaDataGridView.CurrentRow.Cells[4].Value.ToString();
            dtpHoraConsulta.Text = marcacaoCirugiaDataGridView.CurrentRow.Cells[5].Value.ToString();
            descricaoTextBox.Text = marcacaoCirugiaDataGridView.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
