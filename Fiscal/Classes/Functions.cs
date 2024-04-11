using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Fiscal.Classes
{
    public class Functions
    {
        public static string RemoveCaracteres(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return texto;

            texto = Regex.Replace(texto, @"[^0-9]", "");

            return texto;
        }
    }
}
