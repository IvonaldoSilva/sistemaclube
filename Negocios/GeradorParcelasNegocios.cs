using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

using ObjetoTransferencia;
using AcessoBancoDados;

namespace Negocios
{
    public class GeradorParcelasNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        public void GravarContrato(Contrato objContrato, List<ItensParcelas> arrParcelas)
        {
            if (arrParcelas == null || arrParcelas.Count == 0)
                return;

            //Gravar na tabela tblcontrato, via procedure e recuperar o codigo gravado
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParamentros("@IDpessoa", objContrato.IDpessoa);
            acessoDadosSqlServer.AdicionarParamentros("@data", objContrato.data);
            acessoDadosSqlServer.AdicionarParamentros("@valor", objContrato.valor);

            //PRocedure de INserçaõ
            string idContrato = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspContratoInserir").ToString();

            foreach (ItensParcelas item in arrParcelas)
            {
                //Gravar na tabela de contas a receber as parcelas do contrato.
                //com o codigo da tabela de contrato (campo idcontrato)
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@IDpessoa", item.IDpessoas);
                acessoDadosSqlServer.AdicionarParamentros("@dataemissao", DateTime.Now);
                acessoDadosSqlServer.AdicionarParamentros("@datavencimento", item.vencimento);
                acessoDadosSqlServer.AdicionarParamentros("@valorpago", item.valormensalidade);
                acessoDadosSqlServer.AdicionarParamentros("@situacao", 1);
                acessoDadosSqlServer.AdicionarParamentros("@idcontrato", idContrato);
                acessoDadosSqlServer.AdicionarParamentros("@parcela", item.numeroparcelas);

                string idContaReceber = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspContasReceberInserir").ToString();
            }
        }
    }
}
