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
    public partial class frmCadastrarMedico : Form
    {
        public frmCadastrarMedico()
        {
            InitializeComponent();
        }
        Crudes medico = new Crudes();
        Dados.Listar dados = new Dados.Listar();
        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");
        private string operacao = "inserir";
        private string codigo;
        public string qtd_linha;
        public void CarregarDados()
        {
            medicoDataGridView.DataSource = dados.ListarMedico();
            label4.Text = "" + medicoDataGridView.RowCount;
        }

        // Função Buscar Medico pelo código
        public void BuscarCodigo()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT codMedico, nome_medico, dataNascimento_medico, sexo_medico, BI_medico, telefone_medico, endereco_medico, email_medico, numeroCarteira_medico, dataAdmissao_medico, nome_especialidade FROM Medico INNER JOIN Especialidade_Medico ON (Medico.codEspecialidade = Especialidade_Medico.codEspecialidade) WHERE codMedico =" + Convert.ToInt32(txtBuscarCodigo.Text), Sqlcon);
            Adpter.Fill(dados);
            medicoDataGridView.DataSource = dados;
        }
        // Função Buscar Medico pelo nome
        public void BuscarNome()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT codMedico, nome_medico, dataNascimento_medico, sexo_medico, BI_medico, telefone_medico, endereco_medico, email_medico, numeroCarteira_medico, dataAdmissao_medico, nome_especialidade FROM Medico INNER JOIN Especialidade_Medico ON (Medico.codEspecialidade = Especialidade_Medico.codEspecialidade) WHERE nome_medico LIKE '" + txtBuscarNome.Text + "%'", Sqlcon);
            Adapter.Fill(dados);
            medicoDataGridView.DataSource = dados;
        }
       
        public void DesabilitarBotao()
        {
            this.btnNovo.Enabled = true;
            this.btnExcluir.Enabled = true;
            this.btnSalvar.Enabled = false;
            this.btnEditar.Enabled = true;

            // Habilitar textox
            nomeTextBox.ReadOnly = true;
            emailTextBox.ReadOnly = true;
            numero_carteiraTextBox.ReadOnly = true;
            telefoneTextBox.ReadOnly = true;
            enderecoTextBox.ReadOnly = true;
            bITextBox.ReadOnly = true;
        }

        public void HabilitarBotao()
        {
            this.btnNovo.Enabled = false;
            this.btnExcluir.Enabled = false;
            this.btnSalvar.Enabled = true;
            this.btnEditar.Enabled = false;

            // Habilitar textox
            nomeTextBox.ReadOnly = false; 
            emailTextBox.ReadOnly = false;
            numero_carteiraTextBox.ReadOnly = false;
            telefoneTextBox.ReadOnly = false; 
            enderecoTextBox.ReadOnly = false; 
            bITextBox.ReadOnly = false;
        }

        private void frmCadastrarMedico_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_HospitalDataSet.Especialidade_Medico' table. You can move, or remove it, as needed.
            this.especialidade_MedicoTableAdapter.Fill(this.db_HospitalDataSet.Especialidade_Medico);
            // Carregar dados do Médico no DataGridView
            this.CarregarDados();
            this.DesabilitarBotao();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            codMedicoTextBox.Clear();
            nomeTextBox.Clear();
            emailTextBox.Clear();
            numero_carteiraTextBox.Clear();
            telefoneTextBox.Clear();
            enderecoTextBox.Clear();
            bITextBox.Clear();

            nomeTextBox.Focus();
            this.HabilitarBotao();     
        }

        // Condição para Validação de Entrada na Base de Dados
        public void Validando(bool condicao = false)
        {        
                condicao = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(medicoDataGridView.SelectedRows.Count > 0)
            {
                operacao = "editar";
                codigo = medicoDataGridView.CurrentRow.Cells[0].Value.ToString();
                nomeTextBox.Text = medicoDataGridView.CurrentRow.Cells[1].Value.ToString();
                data_nascimentoDateTimePicker.Text = medicoDataGridView.CurrentRow.Cells[2].Value.ToString();
                cbSexo.Text = medicoDataGridView.CurrentRow.Cells[3].Value.ToString();
                bITextBox.Text = medicoDataGridView.CurrentRow.Cells[4].Value.ToString();
                telefoneTextBox.Text = medicoDataGridView.CurrentRow.Cells[5].Value.ToString();
                emailTextBox.Text = medicoDataGridView.CurrentRow.Cells[6].Value.ToString();
                enderecoTextBox.Text = medicoDataGridView.CurrentRow.Cells[7].Value.ToString();
                numero_carteiraTextBox.Text = medicoDataGridView.CurrentRow.Cells[8].Value.ToString();
                data_admissaoDateTimePicker.Text = medicoDataGridView.CurrentRow.Cells[9].Value.ToString();
                cbEspecialidade.Text = medicoDataGridView.CurrentRow.Cells[10].Value.ToString();
                this.HabilitarBotao();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para poderes editar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
}

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (medicoDataGridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja eliminar este dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    codigo = medicoDataGridView.CurrentRow.Cells[0].Value.ToString();
                    medico.eliminarMedico(Convert.ToInt32(codigo));
                    if (medico.resp == "OK")
                    {
                        MessageBox.Show("Dados do Médico eliminados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarDados();
                    }
                    else
                        MessageBox.Show(medico.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }      
            }
            else
            {
                MessageBox.Show("Selecione uma linha para poderes eliminar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Data de Nascimento
            if (data_nascimentoDateTimePicker.Value.Year > 2001 || data_nascimentoDateTimePicker.Value.Year < 1981)
            {
                MessageBox.Show("Data de nascimento inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(data_nascimentoDateTimePicker, "Data de nascimento inválida!");
                data_nascimentoDateTimePicker.Focus();
            }             
            // Número do BI
            else if (bITextBox.TextLength != 14)
            {
                MessageBox.Show("Número do BI inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(bITextBox, "Número do BI inválido");
                bITextBox.Focus();
            }           
            // Número do Telefone
            else if (telefoneTextBox.TextLength != 9)
            {
                MessageBox.Show("Número de telefone inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(telefoneTextBox, "Número de telefone inválido!");
                telefoneTextBox.Focus();
            }          
            // Data de Admissão
            else if (data_admissaoDateTimePicker.Value.Year != 2022)
            {
                MessageBox.Show("Data de Admissão inválida!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(data_admissaoDateTimePicker, "Data de Admissão inválida!");
                telefoneTextBox.Focus();
            }  
            else
            {
                SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");
                Sqlcon.Open();
                //  Verificando Existência do Número do BI do Funcionario
                DataTable dados = new DataTable();
                SqlDataAdapter Adpter = new SqlDataAdapter("SELECT * FROM Medico WHERE BI_medico = @BI ", Sqlcon);
                Adpter.SelectCommand.Parameters.AddWithValue("@BI", bITextBox.Text);
                Adpter.Fill(dados);
                Adpter.Dispose();
                //  Verificando Existência do Endereço de Email do Funcionario
                DataTable dados1 = new DataTable();
                SqlDataAdapter Adpter1 = new SqlDataAdapter("SELECT * FROM Medico WHERE email_medico = @email ", Sqlcon);
                Adpter1.SelectCommand.Parameters.AddWithValue("@email", emailTextBox.Text);
                Adpter1.Fill(dados1);
                Adpter1.Dispose();
                //  Verificando Existência do Númrero da Carteira do Funcionario
                DataTable dados2 = new DataTable();
                SqlDataAdapter Adpter2 = new SqlDataAdapter("SELECT * FROM Medico WHERE numeroCarteira_medico = @numero_carteira ", Sqlcon);
                Adpter2.SelectCommand.Parameters.AddWithValue("@numero_carteira", numero_carteiraTextBox.Text);
                Adpter2.Fill(dados2);
                Adpter2.Dispose();
                //  Verificando Existência do Númrero de Telefone do Funcionario
                DataTable dados3 = new DataTable();
                SqlDataAdapter Adpter3 = new SqlDataAdapter("SELECT * FROM Medico WHERE telefone_medico = @telefone ", Sqlcon);
                Adpter3.SelectCommand.Parameters.AddWithValue("@telefone", Convert.ToInt32(telefoneTextBox.Text));
                Adpter3.Fill(dados3);
                Adpter3.Dispose();

                Sqlcon.Close();
                if (operacao.Equals("inserir"))
                {
                    if (dados.Rows.Count != 0)
                    {
                        MessageBox.Show("Este Número de BI já existe na base de dados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        errorProvider1.SetError(bITextBox, "Este Número de BI já existe na base de dados!");
                        bITextBox.Focus();
                    }
                    else if (dados1.Rows.Count != 0)
                    {
                        MessageBox.Show("Este Endereço de Email já existe na base de dados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        errorProvider1.SetError(emailTextBox, "Este Endereço de Email já existe na base de dados!");
                        emailTextBox.Focus();
                    }
                    else if (dados2.Rows.Count != 0)
                    {
                        MessageBox.Show("Este Número da Carteira já existe na base de dados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        errorProvider1.SetError(numero_carteiraTextBox, "Este Número da Carteira já existe na base de dados!");
                        numero_carteiraTextBox.Focus();
                    }
                    else if (dados3.Rows.Count != 0)
                    {
                        MessageBox.Show("Este Número de Telefone já existe na base de dados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        errorProvider1.SetError(telefoneTextBox, "Este Número de Telefone já existe na base de dados!");
                        telefoneTextBox.Focus();
                    }
                    else
                    {
                        medico.inserirMedico(nomeTextBox.Text, Convert.ToDateTime(data_nascimentoDateTimePicker.Text), Convert.ToString(cbSexo.SelectedItem), bITextBox.Text, Convert.ToInt32(telefoneTextBox.Text),
                           enderecoTextBox.Text, emailTextBox.Text, numero_carteiraTextBox.Text, Convert.ToDateTime(data_admissaoDateTimePicker.Text), Convert.ToInt32(cbEspecialidade.SelectedValue));
                        if (medico.resp.Equals("OK"))
                        {
                            MessageBox.Show("Novo medico adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.CarregarDados();
                        }

                        else
                            MessageBox.Show(medico.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DesabilitarBotao();
                    }
                }
                else
                {
                    medico.editarMedico(Convert.ToInt32(codigo), nomeTextBox.Text, Convert.ToDateTime(data_nascimentoDateTimePicker.Text), Convert.ToString(cbSexo.SelectedItem), bITextBox.Text,
                       Convert.ToInt32(telefoneTextBox.Text), enderecoTextBox.Text, emailTextBox.Text, numero_carteiraTextBox.Text, Convert.ToDateTime(data_admissaoDateTimePicker.Text), Convert.ToInt32(cbEspecialidade.SelectedValue));
                    if (medico.resp.Equals("OK"))
                    {
                        MessageBox.Show("Dados do medico actualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.CarregarDados();
                        operacao = "inserir";
                    }
                    else
                        MessageBox.Show(medico.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DesabilitarBotao();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastrarMedico_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.cadMedico = null;
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
            this.especialidade_MedicoTableAdapter.Fill(this.db_HospitalDataSet.Especialidade_Medico);
        }

        private void medicoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codMedicoTextBox.Text = medicoDataGridView.CurrentRow.Cells[0].Value.ToString();
            nomeTextBox.Text = medicoDataGridView.CurrentRow.Cells[1].Value.ToString();
            data_nascimentoDateTimePicker.Text = medicoDataGridView.CurrentRow.Cells[2].Value.ToString();
            cbSexo.Text = medicoDataGridView.CurrentRow.Cells[3].Value.ToString();
            bITextBox.Text = medicoDataGridView.CurrentRow.Cells[4].Value.ToString();
            telefoneTextBox.Text = medicoDataGridView.CurrentRow.Cells[5].Value.ToString();
            emailTextBox.Text = medicoDataGridView.CurrentRow.Cells[6].Value.ToString();
            enderecoTextBox.Text = medicoDataGridView.CurrentRow.Cells[7].Value.ToString();
            numero_carteiraTextBox.Text = medicoDataGridView.CurrentRow.Cells[8].Value.ToString();
            data_admissaoDateTimePicker.Text = medicoDataGridView.CurrentRow.Cells[9].Value.ToString();
            cbEspecialidade.Text = medicoDataGridView.CurrentRow.Cells[10].Value.ToString();
        }
    }
}
