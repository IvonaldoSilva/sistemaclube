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
    public class FornecedorNegocios
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Socios socios)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@Nome", socios.Nome);
                acessoDadosSqlServer.AdicionarParamentros("@datanasc", socios.datanasc);
                acessoDadosSqlServer.AdicionarParamentros("@cpf", socios.cpf);
                acessoDadosSqlServer.AdicionarParamentros("@rg", socios.rg);
                acessoDadosSqlServer.AdicionarParamentros("@sexo", socios.sexo);
                acessoDadosSqlServer.AdicionarParamentros("@endereco", socios.endereco);
                acessoDadosSqlServer.AdicionarParamentros("@numero", socios.numero);
                acessoDadosSqlServer.AdicionarParamentros("@bairro", socios.bairro);
                acessoDadosSqlServer.AdicionarParamentros("@cidade", socios.cidade);
                acessoDadosSqlServer.AdicionarParamentros("@cep", socios.cep);
                acessoDadosSqlServer.AdicionarParamentros("@estado", socios.estado);
                acessoDadosSqlServer.AdicionarParamentros("@admissao", socios.admissao);
                acessoDadosSqlServer.AdicionarParamentros("@email", socios.email);
                acessoDadosSqlServer.AdicionarParamentros("@telefone", socios.telefone);

                string IDpessoa = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspPessoaInserir").ToString();
                return IDpessoa;
            }
            catch (Exception exeception)
            {
                return exeception.Message;
            }
        }

    public string Alterar(Socios socios)
    {
        try
        {
               
            acessoDadosSqlServer.LimparParametros();
            acessoDadosSqlServer.AdicionarParamentros("@IDpessoa", socios.IDpessoa);
            acessoDadosSqlServer.AdicionarParamentros("@Nome", socios.Nome);
            acessoDadosSqlServer.AdicionarParamentros("@datanasc", socios.datanasc);
            acessoDadosSqlServer.AdicionarParamentros("@cpf", socios.cpf);
            acessoDadosSqlServer.AdicionarParamentros("@rg", socios.rg);
            acessoDadosSqlServer.AdicionarParamentros("@sexo", socios.sexo);
            acessoDadosSqlServer.AdicionarParamentros("@endereco", socios.endereco);
            acessoDadosSqlServer.AdicionarParamentros("@numero", socios.numero);
            acessoDadosSqlServer.AdicionarParamentros("@bairro", socios.bairro);
            acessoDadosSqlServer.AdicionarParamentros("@cidade", socios.cidade);
            acessoDadosSqlServer.AdicionarParamentros("@cep", socios.cep);
            acessoDadosSqlServer.AdicionarParamentros("@estado", socios.estado);
            acessoDadosSqlServer.AdicionarParamentros("@admissao", socios.admissao);
            acessoDadosSqlServer.AdicionarParamentros("@email", socios.email);
            acessoDadosSqlServer.AdicionarParamentros("@telefone", socios.telefone);
            string IDpessoa = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspPessoaAlterar").ToString();
            return IDpessoa;


        }
        catch (Exception exeception)
        {
            return exeception.Message;
        }
    }
        public string Excluir(Socios socios)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@IDpessoa", socios.IDpessoa);
                string IDpessoa = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspPessoaExcluir").ToString();
                return IDpessoa;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public SociosColecao ConsultarPorNome(string nome)
        {
            try
            {
                //criar uma nova colecao de socios (aqui ela esta vazia)
                SociosColecao sociosColecao = new SociosColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@Nome", nome);
                DataTable dataTableSocios = acessoDadosSqlServer.ExecutaConsulta(CommandType.StoredProcedure, "uspPessoaConsultarNome");

                //pecorrer o datatable e transformar em colecao de socios
                //cada linha do datatable é um socio
                foreach (DataRow linha in dataTableSocios.Rows)
                {
                    //criar um cliente vazio, colocar os dados na linha dele, adicionar na colecao
                    Socios socios = new Socios();
                    socios.IDpessoa = Convert.ToInt32(linha["IDpessoa"]);
                    socios.Nome = Convert.ToString(linha["Nome"]);
                    socios.datanasc = Convert.ToDateTime(linha["datanasc"]);
                    socios.cpf = Convert.ToString(linha["cpf"]);
                    socios.rg = Convert.ToString(linha["rg"]);
                    socios.sexo = Convert.ToString(linha["sexo"]);
                    socios.endereco = Convert.ToString(linha["endereco"]);
                    socios.numero = Convert.ToString(linha["numero"]);
                    socios.bairro = Convert.ToString(linha["bairro"]);
                    socios.cidade = Convert.ToString(linha["cidade"]);
                    socios.cep = Convert.ToString(linha["cep"]);
                    socios.estado = Convert.ToString(linha["estado"]);
                    socios.admissao = Convert.ToDateTime(linha["admissao"]);
                    socios.email = Convert.ToString(linha["email"]);
                    socios.telefone = Convert.ToString(linha["telefone"]);

                    sociosColecao.Add(socios);


                }
                return sociosColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("nao foi possivel consultar socio por nome detalhe  " + ex.Message);
            }
        }

        public SociosColecao ConsultarPorID(int IDpessoa)
        {
            try
            {
                SociosColecao sociosColecao = new SociosColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@IDpessoa", IDpessoa);

                DataTable dataTableSocios = acessoDadosSqlServer.ExecutaConsulta(CommandType.StoredProcedure, "uspPessoaConsultarCodigo");
                foreach (DataRow linhaDataRow in dataTableSocios.Rows)
                {
                    //criar um cliente vazio, colocar os dados na linha dele, adicionar na colecao
                    Socios socios = new Socios();
                    socios.IDpessoa = Convert.ToInt32(linhaDataRow["IDpessoa"]);
                    socios.Nome = Convert.ToString(linhaDataRow["Nome"]);
                    socios.datanasc = Convert.ToDateTime(linhaDataRow["datanasc"]);
                    socios.cpf = Convert.ToString(linhaDataRow["cpf"]);
                    socios.rg = Convert.ToString(linhaDataRow["rg"]);
                    socios.sexo = Convert.ToString(linhaDataRow["sexo"]);
                    socios.endereco = Convert.ToString(linhaDataRow["endereco"]);
                    socios.numero = Convert.ToString(linhaDataRow["numero"]);
                    socios.bairro = Convert.ToString(linhaDataRow["bairro"]);
                    socios.cidade = Convert.ToString(linhaDataRow["cidade"]);
                    socios.cep = Convert.ToString(linhaDataRow["cep"]);
                    socios.estado = Convert.ToString(linhaDataRow["estado"]);
                    socios.admissao = Convert.ToDateTime(linhaDataRow["admissao"]);
                    socios.email = Convert.ToString(linhaDataRow["email"]);
                    socios.telefone = Convert.ToString(linhaDataRow["telefone"]);

                    sociosColecao.Add(socios);

                }
                return sociosColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("nao foi possivel consultar os dependente desta matricula . detalhe  " + ex.Message);
            }

        }


       
    }


}
