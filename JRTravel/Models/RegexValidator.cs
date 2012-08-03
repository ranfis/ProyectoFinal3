using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace JRTravel.Models
{
    public static class RegexValidator
    {
        public static Dictionary<String, Regex> validar;

        public static void iniciar()
        {
            validar = new Dictionary<string, Regex>();
            validar.Add("texto", new Regex("^[A-Za-z áéíóú]*$"));
            validar.Add("ciudad", new Regex("^[A-Za-z() áéíóú,]*$"));
            validar.Add("fecha", new Regex("^[0-9]{2}+/+[0-9]{2}+/+[0-9]{4}+$"));
            validar.Add("numero", new Regex("^[0-9]*$"));
            validar.Add("decimal", new Regex("^[0-9.]*$"));
            validar.Add("cedula", new Regex("^[[0-9]{3}-[0-9]{7}-[0-9]{1}]*$"));
            validar.Add("email", new Regex("^[A-Za-z0-9._-]+@[A-Za-z]+.com$"));

            
        }

        public static bool validarCon(String txt,String patron){
            Regex r = new Regex(patron);
            return r.IsMatch(txt);
        }
    }
}