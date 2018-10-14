using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using AcessoBancoDados.Properties;

namespace AcessoBancoDados
{
    public class AcessoDadosSqlServer
    {
        //criar conexao
        private SqlConnection CriarConexao()
        {
            return new SqlConnection(Settings.Default.stringConexao);

        }
        //parametro que vao para o banco
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;
        
        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }
        public void AdicionarParamentros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter (nomeParametro,valorParametro));

        }

        //persistencia  inserir alterar e excluir
        public Object ExecutaManipulacao(CommandType commandType,string nomeStoredProcedureouTextoSql)
        {
            try
            {
                //criar a conexao
                SqlConnection sqlConnection = CriarConexao();
                //abrir a conexao
                sqlConnection.Open();
                //criar um comando que vai levar informacao para o banco
                SqlCommand sqlcommand = sqlConnection.CreateCommand();
                //colocando as coisas dentro do comando(dentro da caixa que vai trafegar na conexao)
                sqlcommand.CommandType = commandType;
                sqlcommand.CommandText = nomeStoredProcedureouTextoSql;
                sqlcommand.CommandTimeout = 7200;//em segundos 7200  = 2 horas

                //add os paramentro no comando

                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlcommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                return sqlcommand.ExecuteScalar();

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message); 
            }
            
         }
    
        
        //consultar registro no banco
        public DataTable ExecutaConsulta(CommandType commandType,string nomeStoredProcedureouTextoSql)
        {
            try
            {
                //criar a conexao
                SqlConnection sqlConnection = CriarConexao();
                //abrir a conexao
                sqlConnection.Open();
                //criar um comando que vai levar informacao para o banco
                SqlCommand sqlcommand = sqlConnection.CreateCommand();
                //colocando as coisas dentro do comando(dentro da caixa que vai trafegar na conexao)
                sqlcommand.CommandType = commandType;
                sqlcommand.CommandText = nomeStoredProcedureouTextoSql;
                sqlcommand.CommandTimeout = 7200;//em segundos 7200  = 2 horas

                //add os paramentro no comando

                foreach (SqlParameter sqlParameter in sqlParameterCollection)
                {
                    sqlcommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                //criando adaptador
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlcommand);

                //Datatable vazio onde sera colocado os dadosque vem do banco
                DataTable dataTable = new DataTable();

                //mandar o comando ir ao banco buscar os dados para o adaptador preencher o DataTable
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

              
    }

}
