using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHospitalar2.Core
{
    class Password
    {
        public static string encryptPassword(string password)
        {
            UTF8Encoding encoder = new UTF8Encoding();
            SHA256Managed sha256hash = new SHA256Managed();
            byte[] hashDataBytes = sha256hash.ComputeHash(encoder.GetBytes(password));
            return byteArrayToString(hashDataBytes);
        }

        public static string byteArrayToString(byte[] inputArray)
        {
            StringBuilder output = new StringBuilder("");
            for (int i = 0; i < inputArray.Length; i++)
            {
                output.Append(inputArray[i].ToString("X2"));
            }
            return output.ToString();
        }
    }
}
