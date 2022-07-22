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
    public partial class frmCadastrarPaciente : Form
    {
        public frmCadastrarPaciente()
        {
            InitializeComponent();
        }
        Crudes paciente = new Crudes();
        Dados.Listar dados = new Dados.Listar();
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");
        private string operacao = "inserir";
        private string codigo;

        private void CarregarDados()
        {
            pacienteDataGridView.DataSource = dados.ListarPaciente();
        }

        public void BuscarCodigo()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT * FROM Paciente WHERE codPaciente = " + Convert.ToInt32(txtBuscarCodigo.Text), Sqlcon);
            Adpter.Fill(dados);
            pacienteDataGridView.DataSource = dados;
        }

        public void BuscarNome()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT * FROM Paciente WHERE nome_paciente LIKE '%" + txtBuscarNome.Text + "%'", Sqlcon);
            Adapter.Fill(dados);
            pacienteDataGridView.DataSource = dados;
        }

        public void DesabilitarBotao()
        {
            btnNovo.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = true;

            nome_pacienteTextBox.ReadOnly = true;
            bI_pacienteTextBox.ReadOnly = true;
            telefone_pacienteTextBox.ReadOnly = true;
            endereco_pacienteTextBox.ReadOnly = true;
        }

        public void HabilitarBotao()
        {
            btnNovo.Enabled = false;
            btnExcluir.Enabled = false;
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;

            nome_pacienteTextBox.ReadOnly = false;
            bI_pacienteTextBox.ReadOnly = false;
            telefone_pacienteTextBox.ReadOnly = false;
            endereco_pacienteTextBox.ReadOnly = false;
        }

        private void frmCadastrarPaciente_Load(object sender, EventArgs e)
        {
            this.CarregarDados();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            nome_pacienteTextBox.Clear();
            bI_pacienteTextBox.Clear();
            telefone_pacienteTextBox.Clear();
            endereco_pacienteTextBox.Clear();

            nome_pacienteTextBox.Focus();
            this.HabilitarBotao();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            operacao = "editar";
            codigo = pacienteDataGridView.CurrentRow.Cells[0].Value.ToString();
            nome_pacienteTextBox.Text = pacienteDataGridView.CurrentRow.Cells[1].Value.ToString();
            dataNascimento_pacienteDateTimePicker.Text = pacienteDataGridView.CurrentRow.Cells[2].Value.ToString();
            cbSexo.Text = pacienteDataGridView.CurrentRow.Cells[3].Value.ToString();
            bI_pacienteTextBox.Text = pacienteDataGridView.CurrentRow.Cells[4].Value.ToString();
            telefone_pacienteTextBox.Text = pacienteDataGridView.CurrentRow.Cells[5].Value.ToString();
            endereco_pacienteTextBox.Text = pacienteDataGridView.CurrentRow.Cells[6].Value.ToString();
            this.HabilitarBotao();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            codigo = pacienteDataGridView.CurrentRow.Cells[0].Value.ToString();

            //  Verificar Ligação Com Paciente Internado
            Sqlcon.Open();
            DataTable tabela = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Paciente_Internado WHERE codPaciente = '" + Convert.ToInt32(codigo) + "'", Sqlcon);
            adapter.Fill(tabela);
            adapter.Dispose();
            Sqlcon.Close();

            //  Verificar Ligação Com Marcação de Consulta
            Sqlcon.Open();
            DataTable tabela1 = new DataTable();
            SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT * FROM Marcacao_Consulta WHERE codPaciente = '" + Convert.ToInt32(codigo) + "'", Sqlcon);
            adapter1.Fill(tabela1);
            adapter1.Dispose();
            Sqlcon.Close();

            if (tabela.Rows.Count > 0)
                MessageBox.Show("Este Paciente não pode ser eliminado porque possui ligação com algum Paciente Internado cadastrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (tabela1.Rows.Count > 0)
                MessageBox.Show("Este Paciente não pode ser eliminado porque possui ligação com algum Consulta Marcada cadastrada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                paciente.eliminarPaciente(Convert.ToInt32(codigo));
                if (paciente.resp.Equals("OK"))
                {
                    MessageBox.Show("Dados do Paciente eliminados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CarregarDados();
                }
                else
                    MessageBox.Show(paciente.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (bI_pacienteTextBox.TextLength != 14)
            {
                MessageBox.Show("Quantidade de caracteres do BI inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(bI_pacienteTextBox, "Quantidade de caracteres do BI inválido!");
                bI_pacienteTextBox.Focus();
            }
            else if(telefone_pacienteTextBox.TextLength != 9)
            {
                MessageBox.Show("Números do Telefone inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(telefone_pacienteTextBox, "Números do Telefone inválido!");
                telefone_pacienteTextBox.Focus();
            }
            else
            {
                if (operacao.Equals("inserir"))
                {
                    paciente.inserirPaciente(nome_pacienteTextBox.Text, Convert.ToDateTime(dataNascimento_pacienteDateTimePicker.Text), Convert.ToString(cbSexo.SelectedItem),
                        bI_pacienteTextBox.Text, Convert.ToInt32(telefone_pacienteTextBox.Text), endereco_pacienteTextBox.Text);
                    if (paciente.resp.Equals("OK"))
                    {
                        MessageBox.Show("Nova Paciente adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarDados();
                    }
                    else
                        MessageBox.Show(paciente.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DesabilitarBotao();
                }
                else
                {
                    paciente.editarPaciente(Convert.ToInt32(codigo), nome_pacienteTextBox.Text, Convert.ToDateTime(dataNascimento_pacienteDateTimePicker.Text), Convert.ToString(cbSexo.SelectedItem),
                        bI_pacienteTextBox.Text, Convert.ToInt32(telefone_pacienteTextBox.Text), endereco_pacienteTextBox.Text);
                    if (paciente.resp.Equals("OK"))
                    {
                        MessageBox.Show("Dados do Paciente actualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarDados();
                        operacao = "inserir";
                    }
                    else
                        MessageBox.Show(paciente.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DesabilitarBotao();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastrarPaciente_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.cadPaciente = null;
        }

        private void marcacaoConsultaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codPacienteTextBox.Text = pacienteDataGridView.CurrentRow.Cells[0].Value.ToString();
            nome_pacienteTextBox.Text = pacienteDataGridView.CurrentRow.Cells[1].Value.ToString();
            dataNascimento_pacienteDateTimePicker.Text = pacienteDataGridView.CurrentRow.Cells[2].Value.ToString();
            cbSexo.Text = pacienteDataGridView.CurrentRow.Cells[3].Value.ToString();
            bI_pacienteTextBox.Text = pacienteDataGridView.CurrentRow.Cells[4].Value.ToString();
            telefone_pacienteTextBox.Text = pacienteDataGridView.CurrentRow.Cells[5].Value.ToString();
            endereco_pacienteTextBox.Text = pacienteDataGridView.CurrentRow.Cells[6].Value.ToString();
        }

        private void txtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNome();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarCodigo();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtBuscarCodigo.Clear();
            txtBuscarNome.Clear();
            this.CarregarDados();
        }
    }
}
