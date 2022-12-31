using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaHospitalar2.Core
{
    abstract class Model : Connection
    {
        protected SqlCommand cmd = null;
        protected SqlDataReader reader;
        protected DataTable table;

        public Model()
        {
            this.cmd = new SqlCommand();
            this.table = new DataTable();
        }
    }
}
