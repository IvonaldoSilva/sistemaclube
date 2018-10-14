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
    public class ContasReceberNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string inserir(ContasReceber contasReceber)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@IDpessoa", contasReceber.IDpessoa);
                acessoDadosSqlServer.AdicionarParamentros("@dataemissao", contasReceber.dataemissao);
                acessoDadosSqlServer.AdicionarParamentros("@datapagamento", contasReceber.datapagamento);
                acessoDadosSqlServer.AdicionarParamentros("@datavencimento", contasReceber.datavencimento);
                acessoDadosSqlServer.AdicionarParamentros("@valorpago", contasReceber.valorpago);
                acessoDadosSqlServer.AdicionarParamentros("@situacao",contasReceber.situacao);
                acessoDadosSqlServer.AdicionarParamentros("@idcontrato", contasReceber.idcontrato);
                acessoDadosSqlServer.AdicionarParamentros("@parcela", contasReceber.parcela);

                string idreceber = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspContasReceberInserir").ToString();
                return idreceber;
            }
            catch (Exception exeception)
            {
                return exeception.Message;
            }

        }

        public ContasReceberColecao ConsultarPorId(int id, bool situacao, DateTime? dataPesquisa = null)
        {
            try
            {
                ContasReceberColecao arrReceber = new ContasReceberColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@IDpessoa", id);
                acessoDadosSqlServer.AdicionarParamentros("@situacao", situacao ? 1 : 0);

                if (dataPesquisa != null && dataPesquisa != DateTime.MinValue)
                {
                    acessoDadosSqlServer.AdicionarParamentros("@datapagamento", dataPesquisa);
                }

                DataTable datatableContas = acessoDadosSqlServer.ExecutaConsulta(CommandType.StoredProcedure, "uspContasReceberConsultarIdSocio");
                foreach (DataRow linhaDataRow in datatableContas.Rows)
                {
                    //criando dependente  vazio
                    ContasReceber objReceber = new ContasReceber();
                    objReceber.idreceber = Convert.ToInt32(linhaDataRow["idreceber"]);
                    objReceber.IDpessoa = Convert.ToInt32(linhaDataRow["IDpessoa"]);
                    objReceber.dataemissao = Convert.ToDateTime(linhaDataRow["dataemissao"]);
                    objReceber.parcela = Convert.ToInt32(linhaDataRow["parcela"]);
                    objReceber.nomePessoa = linhaDataRow["Nome"].ToString();

                    DateTime pagamento;
                    DateTime.TryParse(linhaDataRow["datapagamento"].ToString(), out pagamento);

                    if (pagamento != DateTime.MinValue)
                        objReceber.datapagamento = pagamento;

                    objReceber.datavencimento = Convert.ToDateTime(linhaDataRow["datavencimento"]);
                    objReceber.valorpago = Convert.ToDecimal(linhaDataRow["valorpago"]);
                    objReceber.situacao = Convert.ToBoolean(linhaDataRow["situacao"]);

                    int codigoAgendamento = 0;
                    if (int.TryParse(linhaDataRow["idAgendamento"].ToString(), out codigoAgendamento) && codigoAgendamento > 0)
                    {
                        objReceber.idAgendamento = codigoAgendamento;
                    }

                    int idContrato;

                    int.TryParse(linhaDataRow["idcontrato"].ToString(), out idContrato);

                    objReceber.idcontrato = idContrato;

                    arrReceber.Add(objReceber);

                }
                return arrReceber;
            }
            catch (Exception ex)
            {
                throw new Exception("nao foi possivel consultar Contas a Pagar Deste Cliente . detalhe  " + ex.Message);

            }
        }

        public void BaixarReceber(int qtdeParcelas, DateTime dtPagamento, int idSocio, string formaPagamento)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParamentros("@IDpessoa", idSocio);
            acessoDadosSqlServer.AdicionarParamentros("@qtdeParcelas", qtdeParcelas);
            acessoDadosSqlServer.AdicionarParamentros("@dtPagamento", dtPagamento);
            acessoDadosSqlServer.AdicionarParamentros("@strFormaPagamento", formaPagamento);
            string idRetorno = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspContasReceberBaixa")?.ToString();

            int codigoRetorno;
            int.TryParse(idRetorno, out codigoRetorno);
            if (codigoRetorno <= 0)
                throw new Exception("Código retornado da baixa foi menor ou igual a zero");
        }
    }
}
