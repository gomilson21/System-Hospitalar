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
    public partial class frmSaidaMatDescartavel : Form
    {
        public frmSaidaMatDescartavel()
        {
            InitializeComponent();
        }
        Crudes material = new Crudes();

        private void frmSaidaMatDescartavel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_HospitalDataSet.Material_Descartavel' table. You can move, or remove it, as needed.
            this.material_DescartavelTableAdapter.Fill(this.db_HospitalDataSet.Material_Descartavel);
            string qtd_stoque = materialDescartavelDataGridView.CurrentRow.Cells[2].Value.ToString();
            string qtd_minima = materialDescartavelDataGridView.CurrentRow.Cells[6].Value.ToString();
            if (Convert.ToInt32(qtd_stoque) < Convert.ToInt32(qtd_minima))
                materialDescartavelDataGridView.RowsDefaultCellStyle.BackColor = Color.Red;
        }

        private void btnEfectuarSaida_Click(object sender, EventArgs e)
        {
            string qtd_stoque = materialDescartavelDataGridView.CurrentRow.Cells[2].Value.ToString();
            string qtd_minima = materialDescartavelDataGridView.CurrentRow.Cells[6].Value.ToString();
            if (Convert.ToInt32(qtd_stoque) - Convert.ToInt32(txtQuantidadeSaida.Text) < Convert.ToInt32(qtd_minima))
            {
                MessageBox.Show("O valor da Quantidade em estoque não pode ser menor que a Quantidade Mínima", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                material.saidaMatDescartavel(txtNomeMaterial.Text, Convert.ToInt32(txtQuantidadeSaida.Text));
                if (material.resp == "OK")
                {
                    MessageBox.Show("Sucesso na saida do material descartável!");
                    this.material_DescartavelTableAdapter.Fill(this.db_HospitalDataSet.Material_Descartavel);
                }
                else
                    MessageBox.Show(material.resp, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSaidaMatDescartavel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.getMatDescartavel = null;
        }

        private void txtQuantidadeSaida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
                e.Handled = true;
        }
    }
}
