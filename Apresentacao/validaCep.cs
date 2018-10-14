using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao
{
    class validaCep
    {
        public  bool ValidaCep(string cep)
        {
            if (cep.Length == 8)
            {
                cep = cep.Substring(0, 5) + "-" + cep.Substring(5, 3);
                //txt.Text = cep;
            }
            return System.Text.RegularExpressions.Regex.IsMatch(cep, ("[0-9]{5}-[0-9]{3}"));
        }
 
        //Método que valida o Email
        public static bool ValidaEmail(string email)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(email, ("(?<user>[^@]+)@(?<host>.+)"));
        }
 
 
    }
 
}

