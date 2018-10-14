using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apresentacao
{
     public class ValidaCampos
    {
         if(string.IsNullOrEmpty(txtnome.Text))
            {
                MessageBox.Show("Por favor, preencha o campo nome!");
                txtnome.Focus();
                return;
            }
    else if(string.IsNullOrEmpty(txtrg.tes))
    }
}
