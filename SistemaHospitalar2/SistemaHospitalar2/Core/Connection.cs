using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaHospitalar2.Core
{
    abstract class Connection
    {
        static private string stringConnect = @"Data Source=.\SQLExpress;Initial Catalog=db_Hospital;Integrated Security=True";

        private static SqlConnection connect = null;

        public static Exception Fail { get; set; }
        
        protected Connection() {    }

        public static async Task<SqlConnection> getInstance()
        {
            if (Connection.connect == null)
            {
                try
                {
                    Connection.connect = new SqlConnection(Connection.stringConnect);
                    await Connection.connect.OpenAsync();
                    return Connection.connect;
                }
                catch (Exception ex)
                {
                    Connection.Fail = ex;
                }
            }

            return Connection.connect;
        }
    }
}
