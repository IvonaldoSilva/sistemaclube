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
    public class DependenteNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();
        
        public string Inserir(Dependente dependente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@IDpessoa",dependente.IDpessoa);
                acessoDadosSqlServer.AdicionarParamentros("@nome", dependente.nome);
                acessoDadosSqlServer.AdicionarParamentros("@datanasc", dependente.datanasc);
                acessoDadosSqlServer.AdicionarParamentros("@graudep", dependente.graudep);
                acessoDadosSqlServer.AdicionarParamentros("@estadocivil", dependente.estadocivil);

                string IDdependente = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspDependenteInserir").ToString();
                return IDdependente;
            }
            catch (Exception exeception)
            {
                return exeception.Message;
            }

        }
        public string Alterar(Dependente dependente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@IdDep", dependente.IdDep);
                acessoDadosSqlServer.AdicionarParamentros("@IDpessoa",dependente.IDpessoa);
                acessoDadosSqlServer.AdicionarParamentros("@nome", dependente.nome);
                acessoDadosSqlServer.AdicionarParamentros("@datanasc", dependente.datanasc);
                acessoDadosSqlServer.AdicionarParamentros("@graudep", dependente.graudep);
                acessoDadosSqlServer.AdicionarParamentros("@estadocivil",dependente.estadocivil);
                
                string IdDep = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspDependenteAlterar").ToString();
                return IdDep;


            }
            catch (Exception exeception)
            {
                return exeception.Message;
            }
        }

        public string Excluir(Dependente dependente)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@IdDep", dependente.IdDep);
                string IdDep = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspDependenteExcluir").ToString();
                return IdDep;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

       public DependenteColecao consultarporcodigo(int codsocio)
        {
            try
            {
                DependenteColecao dependenteColecao = new DependenteColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@IDpessoa", codsocio);

                DataTable datatableDep = acessoDadosSqlServer.ExecutaConsulta(CommandType.StoredProcedure, "uspDependenteConsultarCodSocio");
                foreach (DataRow linhaDataRow in datatableDep.Rows)
                {
                    //criando dependente  vazio
                    Dependente dependente = new Dependente();
                    dependente.IdDep = Convert.ToInt32(linhaDataRow["IdDep"]);
                    dependente.IDpessoa = Convert.ToInt32(linhaDataRow["IDpessoa"]);
                    dependente.nome = Convert.ToString(linhaDataRow["nome"]);
                    dependente.datanasc = Convert.ToDateTime(linhaDataRow["datanasc"]);
                    dependente.graudep = Convert.ToString(linhaDataRow["graudep"]);
                    dependente.estadocivil = Convert.ToString(linhaDataRow["estadocivil"]);

                    dependenteColecao.Add(dependente);


                }
                return dependenteColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("nao foi possivel consultar os dependente desta matricula . detalhe  " + ex.Message);

            }
        }


    }
}
