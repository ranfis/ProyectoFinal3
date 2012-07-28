using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;

namespace TravelAgency
{
    public static class Validador
    {
        public static Dictionary<String, Regex> validar;

        public static void iniciar()
        {
            validar = new Dictionary<string, Regex>();
            validar.Add("texto", new Regex("^[A-Z a-z()í]*$"));
            validar.Add("numero", new Regex("^[0-9]*$"));
            validar.Add("decimal", new Regex("^[0-9.]*$"));
            validar.Add("cedula", new Regex("^[[0-9]{3}-[0-9]{7}-[0-9]{1}]*$"));
        }
    }
}