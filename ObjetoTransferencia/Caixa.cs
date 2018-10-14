using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Caixa
    {
        public int idcaixa { get; set; }
        public Boolean movcaixa { get; set; }
        public DateTime dataentrada { get; set;}
        public string tiponumerario { get; set; }
        public string tipopessoa { get; set; }
        public int idpessoa { get; set; }
        public string nomepessoa { get; set; }
        public DateTime dataemissao { get; set; }
        public decimal valor { get; set; }
        public string tipodocumento { get; set; }

        public string entradaSaida { get; set; }

    }
}
