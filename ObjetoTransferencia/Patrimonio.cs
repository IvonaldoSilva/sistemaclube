using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class Patrimonio
    {
        
        public int IDpatrimonio { get; set; }
        public int Idtipo { get; set; }
        public string quantidade { get; set; }
        public string descricao { get; set; }
        public DateTime dataaquisicao { get; set; }
        public string ativo { get; set; }

        public string TipoNome { get; set; }

    }
}
