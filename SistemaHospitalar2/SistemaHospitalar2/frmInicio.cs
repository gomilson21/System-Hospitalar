using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaHospitalar2.Support;

namespace SistemaHospitalar2
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
            }
            else
            {
                timer1.Enabled = false;

                if (InstanceForm.login == null)
                    InstanceForm.login = new frmLogin();

                InstanceForm.entrar.Hide();
                InstanceForm.login.Show();
                InstanceForm.login.Focus();
            }         
        }
    }
}
