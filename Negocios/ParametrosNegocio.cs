using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AcessoBancoDados;
using ObjetoTransferencia;
using System.Data;

namespace Negocios
{
    public class ParametrosNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        public string Inserir(Parametros parametros)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("valormensalidade", parametros.valormensalidade);
                acessoDadosSqlServer.AdicionarParamentros("datacadastro", parametros.datacadastrado);

                string idparametro = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspParametrosInserir").ToString();
                return idparametro;
            }
            catch (Exception exeception)
            {
                return exeception.Message;
            }

        }

        public ParametrosColecao carregarValorParamentro()
        {
            try
            {

                ParametrosColecao parametrosColecao = new ParametrosColecao();
                acessoDadosSqlServer.LimparParametros();
                //acessoDadosSqlServer.AdicionarParamentros("@valormensalidade", valormensalidade);
                DataTable dataTableParametro = acessoDadosSqlServer.ExecutaConsulta(CommandType.Text, "select top 1 * from tblParametros order by datacadastrado desc");
                foreach (DataRow linha in dataTableParametro.Rows)
                {
                    Parametros parametros = new Parametros();
                    parametros.idparametro = Convert.ToInt32(linha["idparametro"]);
                    parametros.valormensalidade = Convert.ToDecimal(linha["valormensalidade"]);
                    parametros.datacadastrado = Convert.ToDateTime(linha["datacadastrado"]);
                    parametrosColecao.Add(parametros);
                }

                return parametrosColecao;
            }

            catch (Exception ex)
            {
                throw new Exception("nao foi possivel carregar a mensalidade  . detalhe  " + ex.Message);

            }
        }


    }
}

