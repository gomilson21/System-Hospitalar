using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHospitalar2
{
    public partial class frmRelatorio_PrescricaoMedica : Form
    {
        public frmRelatorio_PrescricaoMedica()
        {
            InitializeComponent();
        }

        private void frmRelatorio_PrescricaoMedica_FormClosed(object sender, FormClosedEventArgs e)
        {
            Referencias_Formularios.relPrescricaoMedica = null;
        }

        private void frmRelatorio_PrescricaoMedica_Load(object sender, EventArgs e)
        {
             
        }
    }
}

namespace frmRelatorio
{
    class frmRelatorio_PrescricaoMedica
    {
    }
}