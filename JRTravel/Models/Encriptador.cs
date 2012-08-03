using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace JRTravel.Models
{
    public static class Encriptador
    {
        public static string generarMD5(string texto)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();

            byte[] stream = null;

            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(texto));

            string ret = "";
            for (int i = 0; i < stream.Length; i++)
                ret += stream[i].ToString("x2").ToLower();
            return ret;
        }

        public static string generarCodigo(string texto,int x=8)
        {
            String codigo = texto + DateTime.Now.Millisecond.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Hour.ToString();
            String ret=generarMD5(generarMD5(texto).Substring(0, x)).Substring(0,8);
            return ret;
        }
    }
}