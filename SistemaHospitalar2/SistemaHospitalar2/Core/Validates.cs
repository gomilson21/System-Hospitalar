using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SistemaHospitalar2.Core
{
    public static class Validates
    {
        public static bool validateEmail(string email)
        {
            try
            {
                Regex regex = new Regex(@"\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}");

                return regex.IsMatch(email) ? true : false;
            }
            catch (Exception ex)
            {
                Connection.Fail = ex;
                return false;
            }
        }
    }
}
