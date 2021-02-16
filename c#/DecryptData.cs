using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

using System.Web;

namespace WebApplication1.Models
{
    public static class DecryptData
    {
       
        public static string Decrypt(string encodedStr, string key)
        {
            AesCryptoServiceProvider aesCryptoProvider = new AesCryptoServiceProvider();

            byte[] byteBuff;

            try
            {
                aesCryptoProvider.Key = Encoding.UTF8.GetBytes(key);


                string[] textParts = encodedStr.Split(':');
                byte[] iv = FromHexString(textParts[0]);
                aesCryptoProvider.IV = iv;
                byteBuff = FromHexString(textParts[1]);

                string plaintext = Encoding.UTF8.GetString(aesCryptoProvider.CreateDecryptor().TransformFinalBlock(byteBuff, 0, byteBuff.Length));

                return plaintext;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }

        public static string ToHexString(byte[] str)
        {
            var sb = new StringBuilder();

            var bytes = str;
            foreach (var t in bytes)
            {
                sb.Append(t.ToString("X2"));
            }

            return sb.ToString();
        }

        public static byte[] FromHexString(string hexString)
        {
            var bytes = new byte[hexString.Length / 2];
            for (var i = 0; i < bytes.Length; i++)
            {
                bytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            }

            return bytes;
        }
    }
}