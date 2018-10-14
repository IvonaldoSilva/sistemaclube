using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class DadosRelatorioRecibo
    {
        public string cli_nome { get; set; }
        public decimal rec_valorpago { get; set; }
        public string strValorExtenso { get; set; }
        public int qtdeParcelas { get; set; }
        public string strDetalheRecibo { get; set; }
    }
}
