using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaHospitalar2
{
    class Conexao
    {
        static private string conexao = @"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True";
        private SqlConnection link = new SqlConnection(conexao);

        public SqlConnection AbrirConexao()
        {
            if (link.State == ConnectionState.Closed)
                link.Open();
            return link;
        }

        public SqlConnection FecharConexao()
        {
            if (link.State != ConnectionState.Closed)
                link.Close();
            return link;
        }
    }
}
