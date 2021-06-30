using System;
using System.Security.Cryptography;
using System.Text;

namespace Team27_BookshopWeb.Models
{
    public static class StringExtentions
    {
        public static string Md5(this string inputString)
        {
            MD5 md5 = MD5.Create();
            byte[] input = Encoding.Default.GetBytes(inputString);
            byte[] output = md5.ComputeHash(input);
            return BitConverter.ToString(output).Replace("-", "");
        }
    }
}
