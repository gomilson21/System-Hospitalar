using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHospitalar2.Core
{
    public static class Message
    {
        public static void success(string message, string title = " :: Sistema Hospitalar :: ")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void error(string message, string title = " :: Sistema Hospitalar :: ")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void warning(string message, string title = " :: Sistema Hospitalar :: ")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void exception(string message, string title = " :: Sistema Hospitalar :: ")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        public static void question(string message, string title = " :: Sistema Hospitalar :: ")
        {
            MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
