using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SalaryManagementSystem_Utility.Hash
{
    public static class ComputeHash
    {
        /// refrenced below : 
        /// https://www.c-sharpcorner.com/article/compute-sha256-hash-in-c-sharp/
        public static string ToSha256Hash(this string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public static bool VerifyHash(string input, string hash)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                
                // Create a StringComparer an compare the hashes.
                StringComparer comparer = StringComparer.OrdinalIgnoreCase;

                return comparer.Compare(input, hash) == 0;

            }
        }
    }
}
