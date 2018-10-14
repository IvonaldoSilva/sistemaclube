using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using ObjetoTransferencia;
using AcessoBancoDados;

namespace Negocios
{
    public class PatrimonioNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Patrimonio patrimonio)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@Idtipo", patrimonio.Idtipo);
                acessoDadosSqlServer.AdicionarParamentros("@quantidade", patrimonio.quantidade);
                acessoDadosSqlServer.AdicionarParamentros("@descricao", patrimonio.descricao);
                acessoDadosSqlServer.AdicionarParamentros("@dataaquisicao", patrimonio.dataaquisicao);
                acessoDadosSqlServer.AdicionarParamentros("@ativo", patrimonio.ativo);
                string IDpatrimonio = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspPatrimonioInserir").ToString();
                return IDpatrimonio;
            }
            catch (Exception exeception)
            {
                return exeception.Message;
            }
        }


        public string Alterar(Patrimonio patrimonio)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@IDpatrimonio", patrimonio.IDpatrimonio);
                //acessoDadosSqlServer.AdicionarParamentros("@descricao", patrimonio.TipoNome);
                acessoDadosSqlServer.AdicionarParamentros("@Idtipo", patrimonio.Idtipo);
                acessoDadosSqlServer.AdicionarParamentros("@quantidade", patrimonio.quantidade);
                acessoDadosSqlServer.AdicionarParamentros("@descricao", patrimonio.descricao);
                acessoDadosSqlServer.AdicionarParamentros("@dataaquisicao", patrimonio.dataaquisicao);
                acessoDadosSqlServer.AdicionarParamentros("@ativo", patrimonio.ativo);
                string IDpatrimonio = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspPatrimonioAlterar").ToString();
                return IDpatrimonio;
            }
            catch (Exception exeception)
            {
                return exeception.Message;
            }

        }

        public string Excluir(Patrimonio patrimonio)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@IDpatrimonio", patrimonio.IDpatrimonio);
                string IDpatrimonio = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspPatrimonioExcluir").ToString();
                return IDpatrimonio;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        

        public  TipoColecao CarregarCombobox(string descricao)
        {
            try
            {
                TipoColecao tipoColecao = new TipoColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@descricao", descricao);
                DataTable dataTablePatrimonio = acessoDadosSqlServer.ExecutaConsulta(CommandType.Text, "Select descricao,idtipo from tbltipo");
                foreach (DataRow linha in dataTablePatrimonio.Rows)
                {
                    Tipo tipo = new Tipo();
                    tipo.Idtipo = Convert.ToInt32(linha["Idtipo"]);
                    tipo.descricao = Convert.ToString(linha["descricao"]);
                    tipoColecao.Add(tipo);
                }
                return tipoColecao;
                    
            }
            catch (Exception ex)
            {
                throw new Exception(" Nao foi possivel consultar  " + ex.Message);
            }
           


        }



               
    

      public PatrimonioColecao ConsultarPorNome(string descricao)
            {
            try
            {
                //criar uma nova colecao de socios (aqui ela esta vazia)
                PatrimonioColecao patrimonioColecao = new PatrimonioColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@descricao", descricao);
                DataTable dataTablePatrimonio = acessoDadosSqlServer.ExecutaConsulta(CommandType.StoredProcedure, "uspPatrimonioConsultardescricao");

                //pecorrer o datatable e transformar em colecao 
                //cada linha do datatable é um socio
                foreach (DataRow linha in dataTablePatrimonio.Rows)
                {
                    //criar um cliente vazio, colocar os dados na linha dele, adicionar na colecao
                    Patrimonio patrimonio = new Patrimonio();
                    patrimonio.IDpatrimonio = Convert.ToInt32(linha["IDpatrimonio"]);
                    patrimonio.Idtipo = Convert.ToInt32(linha["Idtipo"]);
                    patrimonio.quantidade =Convert.ToString(linha["quantidade"]);
                    patrimonio.descricao = Convert.ToString(linha["descricao"]);
                    patrimonio.dataaquisicao = Convert.ToDateTime(linha["dataaquisicao"]);
                    patrimonio.ativo = Convert.ToString(linha["ativo"]);
                    patrimonio.TipoNome = linha["Tipo"].ToString();
                    
                    patrimonioColecao.Add(patrimonio);


                }
                return patrimonioColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("nao foi possivel consultar Patrimonio por descricao  detalhe  " + ex.Message);
            }
        }
    }
}



