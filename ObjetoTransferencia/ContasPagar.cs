using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class ContasPagar
    {
        public int idcontaspagar { get; set; }
        public string pessoatipo { get; set; }
        public int codpessoa { get; set; }
        public string nome { get; set; }
        public string tipodocumento { get; set; }
        public string documento { get; set; }
        public Decimal valordocumento { get; set; }
        public DateTime dataemissao { get; set; }
        public DateTime datavencimento { get; set; }
        public DateTime dataPagamento { get; set; }
        public string historico { get; set; }
        public Boolean situacao { get; set; }
    }
}
