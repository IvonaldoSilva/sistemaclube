using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Contrato
    {
        public int idcontrato { get; set; }
        public int IDpessoa { get; set; }
        public string nome { get; set; }
        public DateTime data { get; set; }
        public decimal valor { get; set; }
    }
}
