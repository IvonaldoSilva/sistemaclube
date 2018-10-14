using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Agendamento
    {
        public int idagendamento { get; set; }
        public DateTime data { get; set; }
        public string horainicio { get; set; }
        public string horafinal { get; set; }
        public int IDpessoa { get; set; }
        public string nome { get; set; }
        public string local { get; set; }
        public decimal valor { get; set; }
        public Boolean situacao { get; set; }
    }
}
