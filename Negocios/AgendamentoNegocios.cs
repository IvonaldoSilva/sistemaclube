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
    public class AgendamentoNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        public string Inserir(Agendamento agendamento)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();

                acessoDadosSqlServer.AdicionarParamentros("@data", agendamento.data);
                acessoDadosSqlServer.AdicionarParamentros("@horainicio", agendamento.horainicio);
                acessoDadosSqlServer.AdicionarParamentros("@horafinal", agendamento.horafinal);
                acessoDadosSqlServer.AdicionarParamentros("@IDpessoa", agendamento.IDpessoa);
                acessoDadosSqlServer.AdicionarParamentros("@nome", agendamento.nome);
                acessoDadosSqlServer.AdicionarParamentros("@local", agendamento.local);
                acessoDadosSqlServer.AdicionarParamentros("@valor", agendamento.valor);
                acessoDadosSqlServer.AdicionarParamentros("@situacao", agendamento.situacao);
                string idagendamento = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspAgendamentoInserir").ToString();

                if (!string.IsNullOrEmpty(idagendamento) && agendamento.situacao)
                {
                    agendamento.idagendamento = int.Parse(idagendamento);
                    InserirContasReceber(agendamento);
                }
                return idagendamento;
            }
            catch (Exception exeception)
            {
                return exeception.Message;
            }
        }

        public string Alterar(Agendamento agendamento)
        {
            try
            {
                RemoverContasReceber(agendamento.idagendamento);

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@idagendamento", agendamento.idagendamento);
                acessoDadosSqlServer.AdicionarParamentros("@data", agendamento.data.Date);
                acessoDadosSqlServer.AdicionarParamentros("@horainicio", agendamento.horainicio);
                acessoDadosSqlServer.AdicionarParamentros("@horafinal", agendamento.horafinal);
                acessoDadosSqlServer.AdicionarParamentros("@IDpessoa", agendamento.IDpessoa);
                acessoDadosSqlServer.AdicionarParamentros("@nome", agendamento.nome);
                acessoDadosSqlServer.AdicionarParamentros("@local", agendamento.local);
                acessoDadosSqlServer.AdicionarParamentros("@valor", agendamento.valor);
                acessoDadosSqlServer.AdicionarParamentros("@situacao", agendamento.situacao);
                string idagendamento = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspAgendamentoAlterar").ToString();

                InserirContasReceber(agendamento);

                return idagendamento;
            }
            catch (Exception exeception)
            {
                return exeception.Message;
            }
        }
        public string Excluir(Agendamento agendamento)
        {
            try
            {
                RemoverContasReceber(agendamento.idagendamento);

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@idagendamento", agendamento.idagendamento);
                string idagendamento = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspAgendamentoExcluir").ToString();
                return idagendamento;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }
        public AgendamentoColecao ConsultarPorData(DateTime data)
        {
            try
            {
                AgendamentoColecao agendamentoColecao = new AgendamentoColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@data", data);
                DataTable dataTableAgendamento = acessoDadosSqlServer.ExecutaConsulta(CommandType.StoredProcedure, "uspAgendaConsultarData");
                foreach (DataRow linha in dataTableAgendamento.Rows)
                {
                    Agendamento agendamento = new Agendamento();
                    agendamento.idagendamento = Convert.ToInt32(linha["idagendamento"]);
                    agendamento.data = Convert.ToDateTime(linha["data"]);
                    agendamento.IDpessoa = Convert.ToInt32(linha["IDpessoa"]);
                    agendamento.nome = Convert.ToString(linha["nome"]);
                    agendamento.local = Convert.ToString(linha["local"]);
                    agendamento.valor = Convert.ToDecimal(linha["valor"]);
                    agendamento.situacao = Convert.ToBoolean(linha["situacao"]);
                    agendamento.horafinal = linha["horafinal"].ToString().Substring(0, 5);
                    agendamento.horainicio = linha["horainicio"].ToString().Substring(0, 5);
                    agendamentoColecao.Add(agendamento);
                }
                return agendamentoColecao;

            }
            catch (Exception ex)
            {
                throw new Exception("nao foi possivel consultar o usuario por nome" + ex.Message);
            }
        }

        public AgendamentoColecao ConsultarPorNome(string nome)
        {
            try
            {
                AgendamentoColecao agendamentoColecao = new AgendamentoColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@nome", nome);
                DataTable dataTableAgendamento = acessoDadosSqlServer.ExecutaConsulta(CommandType.StoredProcedure, "uspAgendamentoPorNome");
                foreach (DataRow linha in dataTableAgendamento.Rows)
                {
                    Agendamento agendamento = new Agendamento();
                    agendamento.idagendamento = Convert.ToInt32(linha["idagendamento"]);
                    agendamento.data = Convert.ToDateTime(linha["data"]);
                    agendamento.IDpessoa = Convert.ToInt32(linha["IDpessoa"]);
                    agendamento.nome = Convert.ToString(linha["nome"]);
                    agendamento.local = Convert.ToString(linha["local"]);
                    agendamento.valor = Convert.ToDecimal(linha["valor"]);
                    agendamento.situacao = Convert.ToBoolean(linha["situacao"]);
                    agendamento.horafinal = linha["horafinal"].ToString().Substring(0, 5);
                    agendamento.horainicio = linha["horainicio"].ToString().Substring(0, 5);
                    agendamentoColecao.Add(agendamento);
                }
                return agendamentoColecao;

            }
            catch (Exception ex)
            {
                throw new Exception("nao foi possivel consultar o usuario por nome" + ex.Message);
            }
        }
        public void InserirContasReceber(Agendamento agendamento)
        {
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParamentros("@IDpessoa", agendamento.IDpessoa);
            acessoDadosSqlServer.AdicionarParamentros("@dataemissao", DateTime.Now);
            acessoDadosSqlServer.AdicionarParamentros("@datavencimento", DateTime.Now.AddDays(30));
            acessoDadosSqlServer.AdicionarParamentros("@valorpago", agendamento.valor);
            acessoDadosSqlServer.AdicionarParamentros("@situacao", 1);
            acessoDadosSqlServer.AdicionarParamentros("@parcela", 0);
            acessoDadosSqlServer.AdicionarParamentros("@idAgendamento", agendamento.idagendamento);

            string idContaReceber = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspContasReceberInserir").ToString();
        }
        public void RemoverContasReceber(int idAgendamento)
        {
            //Deletar receber, caso haja
            string Sql = $"DELETE FROM TBLCONTASRECEBER WHERE IDAGENDAMENTO = {idAgendamento};";
            acessoDadosSqlServer.ExecutaManipulacao(CommandType.Text, Sql);
        }



        public void BaixarAgendamento(int codigo)
        {
            acessoDadosSqlServer.ExecutaManipulacao(CommandType.Text, $"UPDATE tblAgendamento set situacao = 0 where idAgendamento = {codigo};");
        }
    }
}
