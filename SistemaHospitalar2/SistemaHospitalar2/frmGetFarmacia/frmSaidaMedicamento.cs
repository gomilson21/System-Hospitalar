using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHospitalar2.frmGetFarmacia
{
    public partial class frmSaidaMedicamento : Form
    {
        public frmSaidaMedicamento()
        {
            InitializeComponent();
        }
        Crudes medicamento = new Crudes();

        private void frmSaidaMedicamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_HospitalDataSet.Medicamento' table. You can move, or remove it, as needed.
            this.medicamentoTableAdapter.Fill(this.db_HospitalDataSet.Medicamento);
            string qtd_stoque = medicamentoDataGridView.CurrentRow.Cells[3].Value.ToString();
            string qtd_minima = medicamentoDataGridView.CurrentRow.Cells[7].Value.ToString();
            if (Convert.ToInt32(qtd_stoque) < Convert.ToInt32(qtd_minima))
                medicamentoDataGridView.RowsDefaultCellStyle.BackColor = Color.Red;
        }

        private void btnEfectuarSaida_Click(object sender, EventArgs e)
        {
            string qtd_stoque = medicamentoDataGridView.CurrentRow.Cells[3].Value.ToString();
            string qtd_minima = medicamentoDataGridView.CurrentRow.Cells[7].Value.ToString();
            if (txtQuantidadeSaida.Text == string.Empty)
            {
                MessageBox.Show("É campo obrigatório que preeencher este campo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (Convert.ToInt32(qtd_stoque) - Convert.ToInt32(txtQuantidadeSaida.Text) < Convert.ToInt32(qtd_minima))
            {
                MessageBox.Show("O valor da Quantidade em estoque não pode ser menor que a Quantidade Mínima", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                medicamento.saidaMedicamento(txtNomeComercial.Text, txtNomeGenerico.Text, Convert.ToInt32(txtQuantidadeSaida.Text));
                if (medicamento.resp.Equals("OK"))
                {
                    MessageBox.Show("Sucesso na saida do Medicamento");
                    this.medicamentoTableAdapter.Fill(this.db_HospitalDataSet.Medicamento);
                }
                else
                    MessageBox.Show(medicamento.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSaidaMedicamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.getMedicamento = null;
        }

        private void txtQuantidadeSaida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = true;
        }
    }
}
