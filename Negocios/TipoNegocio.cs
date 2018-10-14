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
    public class TipoNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();


        public string Inserir(Tipo tipo)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@descricao", tipo.descricao);

                string idtipo = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspTipoInserir").ToString();
                return idtipo;
            }
            catch (Exception exeception)
            {
                return exeception.Message;
            }
        }

        public string Excluir(Tipo tipo)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@idtipo", tipo.Idtipo);
                string idtipo = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspTipoExcluir").ToString();
                return idtipo;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }


        }
        public TipoColecao ConsultarDescricao(string descricao)
        {
            try
            {
                //criar uma nova colecao de socios (aqui ela esta vazia)
                TipoColecao tipoColecao = new TipoColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@descricao", descricao);
                DataTable dataTableTipo = acessoDadosSqlServer.ExecutaConsulta(CommandType.StoredProcedure, "uspTipoDescricao");

                //pecorrer o datatable e transformar em colecao de socios
                //cada linha do datatable é um socio
                foreach (DataRow linha in dataTableTipo.Rows)
                {
                    //criar um cliente vazio, colocar os dados na linha dele, adicionar na colecao
                    Tipo tipo = new Tipo();
                    tipo.Idtipo = Convert.ToInt32(linha["idtipo"]);
                    tipo.descricao = Convert.ToString(linha["descricao"]);

                    tipoColecao.Add(tipo);


                }
                return tipoColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("nao foi possivel consultar Descricao por nome detalhe  " + ex.Message);
            }
        }
        public Tipo CarregarTipo(int id)
        {
            try
            {
                DataTable dataTableTipo = acessoDadosSqlServer.ExecutaConsulta(CommandType.Text, $"SELECT * FROM TBLTIPO WHERE IDTIPO = {id}");
                Tipo tipo = new Tipo();
                foreach (DataRow linha in dataTableTipo.Rows)
                {
                    tipo.Idtipo = Convert.ToInt32(linha["idtipo"]);
                    tipo.descricao = Convert.ToString(linha["descricao"]);
                }
                return tipo;
            }
            catch
            {
                return null;
            }
        }
        public string ConsultaID(Tipo tipo)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("idtipo", tipo.Idtipo);
                acessoDadosSqlServer.AdicionarParamentros("descricao", tipo.descricao);
                string idtipo = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspListaTipo").ToString();
                return idtipo;
            }
            catch (Exception exeception)
            {
                return exeception.Message;
            }
        }



    }

}

