using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

using AcessoBancoDados;
using ObjetoTransferencia;

namespace Negocios
{
    public class FornecedorNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        public string Inserir(Fornecedor fornecedor)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@Nome", fornecedor.nome);
                acessoDadosSqlServer.AdicionarParamentros("@cnpj", fornecedor.cnpj);
                acessoDadosSqlServer.AdicionarParamentros("@endereco", fornecedor.endereco);
                acessoDadosSqlServer.AdicionarParamentros("@numero", fornecedor.numero);
                acessoDadosSqlServer.AdicionarParamentros("@cidade", fornecedor.cidade);
                acessoDadosSqlServer.AdicionarParamentros("@telefone", fornecedor.telefone);
                string IdFornecedor = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspFornecedorInserir").ToString();
                return IdFornecedor;
            }
            catch (Exception exeception)
            {
                return exeception.Message;
            }
        }
        public string Excluir(Fornecedor fornecedor)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@IdFornecedor", fornecedor.idFornecedor);
                string IdFonecedor = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspExcluirFornecedor").ToString();
                return IdFonecedor;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
        public string Alterar(Fornecedor fornecedor)
        {
            try
            {

                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@IdFornecedor", fornecedor.idFornecedor);
                acessoDadosSqlServer.AdicionarParamentros("@Nome", fornecedor.nome);
                acessoDadosSqlServer.AdicionarParamentros("@cnpj", fornecedor.cnpj);
                acessoDadosSqlServer.AdicionarParamentros("@endereco", fornecedor.endereco);
                acessoDadosSqlServer.AdicionarParamentros("@numero", fornecedor.numero);
                acessoDadosSqlServer.AdicionarParamentros("@cidade", fornecedor.cidade);
                acessoDadosSqlServer.AdicionarParamentros("@telefone", fornecedor.telefone);
                string IdFornecedor = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspFornecedorAlterar").ToString();
                return IdFornecedor;

            }
            catch (Exception exeception)
            {
                return exeception.Message;
            }
        }
        public FornecedorColecao ConsultarPorNome(string nome)
        {
            try
            {
                //criar uma nova colecao de socios (aqui ela esta vazia)
                FornecedorColecao fornecedorColecao = new FornecedorColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@nome", nome);
                DataTable dataTablefornecedor = acessoDadosSqlServer.ExecutaConsulta(CommandType.StoredProcedure, "uspFornecedorConsultarNome");

                //pecorrer o datatable e transformar em colecao de socios
                //cada linha do datatable é um socio
                foreach (DataRow linha in dataTablefornecedor.Rows)
                {
                    //criar um cliente vazio, colocar os dados na linha dele, adicionar na colecao
                    Fornecedor fornecedor = new Fornecedor();
                    fornecedor.idFornecedor = Convert.ToInt32(linha["IdFornecedor"]);
                    fornecedor.nome = Convert.ToString(linha["nome"]);
                    fornecedor.cnpj = Convert.ToString(linha["cnpj"]);
                    fornecedor.endereco = Convert.ToString(linha["endereco"]);
                    fornecedor.numero = Convert.ToString(linha["numero"]);
                    fornecedor.cidade = Convert.ToString(linha["cidade"]);
                    fornecedor.telefone = Convert.ToString(linha["telefone"]);
                    

                    fornecedorColecao.Add(fornecedor);


                }
                return fornecedorColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("nao foi possivel consultar socio por nome detalhe  " + ex.Message);
            }
        }

        public FornecedorColecao ConsultarPorCodigo(int IdFornecedor)
        {
            try
            {
                FornecedorColecao fornecedorColecao = new FornecedorColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@IdFornecedor", IdFornecedor);

                DataTable dataTableFornecedor = acessoDadosSqlServer.ExecutaConsulta(CommandType.StoredProcedure, "uspFornecedorConsultarCodigo");
                foreach (DataRow linhaDataRow in dataTableFornecedor.Rows)
                {
                    //criar um cliente vazio, colocar os dados na linha dele, adicionar na colecao
                    Fornecedor fornecedor = new Fornecedor();
                   fornecedor.idFornecedor = Convert.ToInt32(linhaDataRow["IdFornecedor"]);
                    fornecedor.nome = Convert.ToString(linhaDataRow["nome"]);
                    fornecedor.cnpj = Convert.ToString(linhaDataRow["cnpj"]);
                    fornecedor.endereco= Convert.ToString(linhaDataRow["endereco"]);
                    fornecedor.numero = Convert.ToString(linhaDataRow["numero"]);
                    fornecedor.cidade = Convert.ToString(linhaDataRow["cidade"]);
                    fornecedor.telefone = Convert.ToString(linhaDataRow["endereco"]);
                    

                    fornecedorColecao.Add(fornecedor);

                }
                return fornecedorColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("nao foi possivel consultar os dependente desta matricula . detalhe  " + ex.Message);
            }
        }

    }
}