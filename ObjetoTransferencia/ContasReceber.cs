using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetoTransferencia
{
    public class ContasReceber
    {
        public int idreceber { get; set; }
        public int IDpessoa { get; set; }
        public DateTime dataemissao { get; set; }
        public DateTime? datapagamento { get; set; }
        public DateTime datavencimento{ get; set; }
        public decimal valorpago{ get; set; }
        public Boolean situacao { get; set; }
        public int idcontrato  { get; set; }
        public string formaPagamento { get; set; }
        public int parcela { get; set; }
        public int idAgendamento { get; set; }

        //Obtendo essa informação para utilizar no relatório
        public string nomePessoa { get; set; }
    }
}
