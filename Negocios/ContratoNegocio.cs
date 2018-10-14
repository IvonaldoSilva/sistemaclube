using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using ObjetoTransferencia;
using AcessoBancoDados;

namespace Negocios
{
    public class ContratoNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        public string Inserir(Contrato contrato)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@idcontrato", contrato.idcontrato);
                acessoDadosSqlServer.AdicionarParamentros("@IDpessoa", contrato.IDpessoa);
                acessoDadosSqlServer.AdicionarParamentros("@data", contrato.data);
                acessoDadosSqlServer.AdicionarParamentros("@valor", contrato.valor);
                string idcontrato = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspContratoInserir").ToString();
                return idcontrato;

            }
            catch (Exception exeception)
            {
                return exeception.Message;
            }
        }

    }
}
