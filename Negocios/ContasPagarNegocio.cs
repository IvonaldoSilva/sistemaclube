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
    public class ContasPagarNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        //private readonly object dependente;

        public string Inserir(ContasPagar contasPagar)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@pessoatipo", contasPagar.pessoatipo);
                acessoDadosSqlServer.AdicionarParamentros("@codpessoa", contasPagar.codpessoa);
                acessoDadosSqlServer.AdicionarParamentros("@nome", contasPagar.nome);
                acessoDadosSqlServer.AdicionarParamentros("@tipodocumento", contasPagar.tipodocumento);
                acessoDadosSqlServer.AdicionarParamentros("@documento", contasPagar.documento);
                acessoDadosSqlServer.AdicionarParamentros("@valordocumento", contasPagar.valordocumento);
                acessoDadosSqlServer.AdicionarParamentros("@dataemissao", contasPagar.dataemissao);
                acessoDadosSqlServer.AdicionarParamentros("@datavencimento", contasPagar.datavencimento);
                acessoDadosSqlServer.AdicionarParamentros("@historico", contasPagar.historico);
                acessoDadosSqlServer.AdicionarParamentros("@situacao", contasPagar.situacao);
                string idcontaspagar = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspContasPagarInserir").ToString();
                return idcontaspagar;

            }
            catch (Exception exeception)
            {
                return exeception.Message;
            }
        }

        public string Alterar(ContasPagar contasPagar)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@idcontaspagar", contasPagar.idcontaspagar);
                acessoDadosSqlServer.AdicionarParamentros("@pessoatipo", contasPagar.pessoatipo);
                acessoDadosSqlServer.AdicionarParamentros("@codpessoa", contasPagar.codpessoa);
                acessoDadosSqlServer.AdicionarParamentros("@nome", contasPagar.nome);
                acessoDadosSqlServer.AdicionarParamentros("@tipodocumento", contasPagar.tipodocumento);
                acessoDadosSqlServer.AdicionarParamentros("@documento", contasPagar.documento);
                acessoDadosSqlServer.AdicionarParamentros("@valordocumento", contasPagar.valordocumento);
                acessoDadosSqlServer.AdicionarParamentros("@dataemissao", contasPagar.dataemissao);
                acessoDadosSqlServer.AdicionarParamentros("@datavencimento", contasPagar.datavencimento);
                acessoDadosSqlServer.AdicionarParamentros("@historico", contasPagar.historico);
                acessoDadosSqlServer.AdicionarParamentros("@situacao", contasPagar.situacao);
                acessoDadosSqlServer.AdicionarParamentros("@dataPagamento", contasPagar?.dataPagamento);
                string idcontaspagar = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspContasPagarAlterar").ToString();
                return idcontaspagar;

            }
            catch (Exception exeception)
            {
                return exeception.Message;
            }

        }
        public string Excluir(ContasPagar contasPagar)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@idcontaspagar", contasPagar.idcontaspagar);
                string IDpessoa = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspContasPagarExcluir").ToString();
                return IDpessoa;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public ContasPagarColecao ConsultarNome(string nome, DateTime? dataPesquisa = null)
        {
            try
            {
                ContasPagarColecao contasPagarColecao = new ContasPagarColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@nome", nome);

                if (dataPesquisa != null && dataPesquisa != DateTime.MinValue)
                {
                    acessoDadosSqlServer.AdicionarParamentros("@dataPagamento", dataPesquisa.Value.Date);
                }

                DataTable datatableContas = acessoDadosSqlServer.ExecutaConsulta(CommandType.StoredProcedure, "uspContasPagarConsultarNome");
                foreach (DataRow linhaDataRow in datatableContas.Rows)
                {
                    //criando dependente  vazio
                    ContasPagar contasPagar = new ContasPagar();
                    contasPagar.idcontaspagar = Convert.ToInt32(linhaDataRow["idcontaspagar"]);
                    contasPagar.pessoatipo = Convert.ToString(linhaDataRow["pessoatipo"]);
                    contasPagar.codpessoa = Convert.ToInt32(linhaDataRow["codpessoa"]);
                    contasPagar.nome = Convert.ToString(linhaDataRow["nome"]);
                    contasPagar.tipodocumento = Convert.ToString(linhaDataRow["tipodocumento"]);
                    contasPagar.documento = Convert.ToString(linhaDataRow["documento"]);
                    contasPagar.valordocumento = Convert.ToDecimal(linhaDataRow["valordocumento"]);
                    contasPagar.dataemissao = Convert.ToDateTime(linhaDataRow["dataemissao"]);
                    contasPagar.datavencimento = Convert.ToDateTime(linhaDataRow["datavencimento"]);
                    contasPagar.historico = Convert.ToString(linhaDataRow["historico"]);
                    contasPagar.situacao = Convert.ToBoolean(linhaDataRow["situacao"]);

                    DateTime dataPagamento;
                    if (DateTime.TryParse(linhaDataRow["dataPagamento"].ToString(), out dataPagamento))
                    {
                        contasPagar.dataPagamento = dataPagamento;
                    }

                    contasPagarColecao.Add(contasPagar);

                }
                return contasPagarColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("nao foi possivel consultar Contas a Pagar Deste Cliente . detalhe  " + ex.Message);

            }
        }
    }
}
