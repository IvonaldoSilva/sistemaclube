using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using AcessoBancoDados;
using ObjetoTransferencia;


namespace Negocios
{
    public class CaixaNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        public string Inserir(Caixa caixa)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@movcaixa", caixa.movcaixa);
                acessoDadosSqlServer.AdicionarParamentros("@dataentrada", caixa.dataentrada);
                acessoDadosSqlServer.AdicionarParamentros("@tiponumerario", caixa.tiponumerario);
                acessoDadosSqlServer.AdicionarParamentros("@tipopessoa", caixa.tipopessoa);
                acessoDadosSqlServer.AdicionarParamentros("@idpessoa", caixa.idpessoa);
                acessoDadosSqlServer.AdicionarParamentros("@nomepessoa", caixa.nomepessoa);
                acessoDadosSqlServer.AdicionarParamentros("@dataemissao", caixa.dataemissao);
                acessoDadosSqlServer.AdicionarParamentros("@valor", caixa.valor);
                acessoDadosSqlServer.AdicionarParamentros("@tipodocumento", caixa.tipodocumento);
                string idcaixa = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspCaixaInserir").ToString();
                return idcaixa;
            }
            catch (Exception exeception)
            {
                return exeception.Message;
            }

        }
        public string Excluir(Caixa caixa)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@idcaixa", caixa.idcaixa);
                string idcaixa = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspCaixaExcluir").ToString();
                return idcaixa;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Alterar(Caixa caixa)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@idcaixa", caixa.idcaixa);
                acessoDadosSqlServer.AdicionarParamentros("@movcaixa", caixa.movcaixa);
                acessoDadosSqlServer.AdicionarParamentros("@dataentrada", caixa.dataentrada);
                acessoDadosSqlServer.AdicionarParamentros("@tiponumerario", caixa.tiponumerario);
                acessoDadosSqlServer.AdicionarParamentros("@tipopessoa", caixa.tipopessoa);
                acessoDadosSqlServer.AdicionarParamentros("@idpessoa", caixa.idpessoa);
                acessoDadosSqlServer.AdicionarParamentros("@nomepessoa", caixa.nomepessoa);
                acessoDadosSqlServer.AdicionarParamentros("@dataemissao", caixa.dataemissao);
                acessoDadosSqlServer.AdicionarParamentros("@valor", caixa.valor);
                acessoDadosSqlServer.AdicionarParamentros("@tipodocumento", caixa.tipodocumento);
                string idcaixa = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspCaixaAlterar").ToString();
                return idcaixa;
            }
            catch (Exception exeception)
            {
                return exeception.Message;
            }
        }
        public CaixaColecao ConsultarPorData(DateTime? data)
        {
            CaixaColecao arrCaixa = new CaixaColecao();
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParamentros("@dataentrada", data);

            DataTable datatableContas = acessoDadosSqlServer.ExecutaConsulta(CommandType.StoredProcedure, "uspCaixaConsultarData");
            foreach (DataRow linhaDataRow in datatableContas.Rows)
            {
                //criando dependente  vazio
                Caixa objCaixa = new Caixa();
                objCaixa.idcaixa = Convert.ToInt32(linhaDataRow["idcaixa"]);
                objCaixa.movcaixa = Convert.ToBoolean(linhaDataRow["movcaixa"]);
                objCaixa.dataentrada = Convert.ToDateTime(linhaDataRow["dataentrada"]);
                objCaixa.tiponumerario = linhaDataRow["tiponumerario"].ToString();
                objCaixa.tipopessoa = linhaDataRow["tipopessoa"].ToString();
                objCaixa.entradaSaida = objCaixa.movcaixa ? "ENTRADA" : "SAÍDA";

                objCaixa.idpessoa = Convert.ToInt32(linhaDataRow["idpessoa"]);
                objCaixa.nomepessoa = linhaDataRow["nomepessoa"].ToString();
                objCaixa.dataemissao = Convert.ToDateTime(linhaDataRow["dataemissao"]);
                objCaixa.valor = Convert.ToDecimal(linhaDataRow["valor"]);
                objCaixa.tipodocumento = linhaDataRow["tipodocumento"].ToString();
                arrCaixa.Add(objCaixa);

            }
            return arrCaixa;
        }
    }
}
