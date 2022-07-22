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
    public partial class frmCadastrarAla_Hospitalar : Form
    {
        public frmCadastrarAla_Hospitalar()
        {
            InitializeComponent();
        }

        SqlConnection Sqlcon = new SqlConnection(@"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True");
        Crudes alaHospitalar = new Crudes();
    
        private string operacao = "inserir";
        private string codigo;

        public void BuscarCodigo()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adpter = new SqlDataAdapter("SELECT * FROM  Ala_Hospitalar WHERE codAla = " + Convert.ToInt32(txtBuscarCodigo.Text), Sqlcon);
            Adpter.Fill(dados);
            alaHospitalarDataGridView.DataSource = dados;
        }

        public void BuscarNome()
        {
            DataTable dados = new DataTable();
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT * FROM Ala_Hospitalar WHERE nome_ala LIKE '%" + txtBuscarNome.Text + "%'", Sqlcon);
            Adapter.Fill(dados);
            alaHospitalarDataGridView.DataSource = dados;
        }

        public void DesabilitarBotao()
        {
            this.btnNovo.Enabled = true;
            this.btnExcluir.Enabled = true;
            this.btnSalvar.Enabled = false;
            this.btnEditar.Enabled = true;
        }

        public void HabilitarBotao()
        {
            this.btnNovo.Enabled = false;
            this.btnExcluir.Enabled = false;
            this.btnSalvar.Enabled = true;
            this.btnEditar.Enabled = false;

            //habilitar textBox
            nomeTextBox.ReadOnly = false;
            descricaoTextBox.ReadOnly = false;
        }

        private void frmCadastrarAla_Hospitalar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_HospitalDataSet.Ala_Hospitalar' table. You can move, or remove it, as needed.
            this.ala_HospitalarTableAdapter.Fill(this.db_HospitalDataSet.Ala_Hospitalar);
            this.DesabilitarBotao();
        }

        
        private void btnNovo_Click(object sender, EventArgs e)
        {
            codAlaTextBox.Clear();
            nomeTextBox.Clear();
            descricaoTextBox.Clear();

            nomeTextBox.Focus();
            this.HabilitarBotao();
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(alaHospitalarDataGridView.SelectedRows.Count > 0)
            {
                operacao = "editar";
                codigo = alaHospitalarDataGridView.CurrentRow.Cells[0].Value.ToString();
                nomeTextBox.Text = alaHospitalarDataGridView.CurrentRow.Cells[1].Value.ToString();
                descricaoTextBox.Text = alaHospitalarDataGridView.CurrentRow.Cells[2].Value.ToString();
                this.HabilitarBotao();
            }
            else
            {
                MessageBox.Show("Selecione uma linha para poderes editar!", "Hospital EG Espença",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(alaHospitalarDataGridView.SelectedRows.Count > 0)
            {
                if(MessageBox.Show("Tem certeza que deseja eliminar este dados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //  Verificar Ligação Com QUarto
                    Sqlcon.Open();
                    DataTable tabela = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Quarto WHERE codAla = '" + Convert.ToInt32(codigo) + "'", Sqlcon);
                    adapter.Fill(tabela);
                    adapter.Dispose();
                    Sqlcon.Close();

                    if (tabela.Rows.Count > 0)
                        MessageBox.Show("Este Ala Hospitlar não pode ser eliminado porque possui ligação com algum Quarto cadastrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        alaHospitalar.eliminarAla_Hospitalar(Convert.ToInt32(codAlaTextBox.Text));
                        if (alaHospitalar.resp == "OK")
                        {
                            MessageBox.Show("Dados da Ala Hospitalar eliminados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ala_HospitalarTableAdapter.Fill(this.db_HospitalDataSet.Ala_Hospitalar);
                        }
                        else
                            MessageBox.Show(alaHospitalar.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione uma linha para poderes eliminar!", "Hospital EG Hospital",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (operacao == "inserir")
            {
                alaHospitalar.inserirAla_Hospitalar(nomeTextBox.Text, descricaoTextBox.Text);
                if (alaHospitalar.resp == "OK")
                {
                    MessageBox.Show("Nova Ala Hospitalar adicionada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ala_HospitalarTableAdapter.Fill(this.db_HospitalDataSet.Ala_Hospitalar);
                    this.DesabilitarBotao();
                }
                else
                    MessageBox.Show(alaHospitalar.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                alaHospitalar.editarAla_Hospitalar(Convert.ToInt32(codAlaTextBox.Text), nomeTextBox.Text, descricaoTextBox.Text);
                if (alaHospitalar.resp == "OK")
                {
                    MessageBox.Show("Dados da Ala Hospitalar actualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ala_HospitalarTableAdapter.Fill(this.db_HospitalDataSet.Ala_Hospitalar);
                    this.DesabilitarBotao();
                }
                else
                    MessageBox.Show(alaHospitalar.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            operacao = "inserir";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastrarAla_Hospitalar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.cadAla_Hospitalar = null;
        }

        private void txtBuscarCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = true;
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
            this.ala_HospitalarTableAdapter.Fill(this.db_HospitalDataSet.Ala_Hospitalar);
        }

        private void txtBuscarNome_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNome();
        }

        private void alaHospitalarDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codAlaTextBox.Text = alaHospitalarDataGridView.CurrentRow.Cells[0].Value.ToString();
            nomeTextBox.Text = alaHospitalarDataGridView.CurrentRow.Cells[1].Value.ToString();
            descricaoTextBox.Text = alaHospitalarDataGridView.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
