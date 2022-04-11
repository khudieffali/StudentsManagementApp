using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace StudentsForm
{
    public static class Utilities
    {
        public static bool IsEmpty(string[] arr)
        {
            foreach (string s in arr)
            {
                if (string.IsNullOrWhiteSpace(s))
                {
                    return false;
                }
            }
            return true;    
        }
        public static string Hashed(this string pas)
        {
            byte[] newByte= new UTF8Encoding().GetBytes(pas);
            var HashMe = new SHA256Managed().ComputeHash(newByte);
            string password=new UTF8Encoding().GetString(HashMe);
            return password;
        }
        
    }
}
