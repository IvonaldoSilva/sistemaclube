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
    public class UsuarioNegocio
    {
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public string Inserir(Usuario usuario)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@nome", usuario.nome);
                acessoDadosSqlServer.AdicionarParamentros("@senha", usuario.senha);
                acessoDadosSqlServer.AdicionarParamentros("@perfil", usuario.perfil);

                string IdUsuario = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspUsuarioInserir").ToString();
                return IdUsuario;
            } 
            catch (Exception exeception)
            {
                return exeception.Message;
            }
        }

        public string Excluir(Usuario usuario)
        {
            try
            {
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@IdUsuario", usuario.IdUsuario);
                string IdUsuario = acessoDadosSqlServer.ExecutaManipulacao(CommandType.StoredProcedure, "uspUsuarioExcluir").ToString();
                return IdUsuario;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }
        public UsuarioColecao ConsultarPorNome(string nome)
        {
            try
            {
                UsuarioColecao usuarioColecao = new UsuarioColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@nome",nome);
                DataTable dataTableUsuario = acessoDadosSqlServer.ExecutaConsulta(CommandType.StoredProcedure, "uspUsuarioConsultarNome");
                foreach(DataRow linha in dataTableUsuario.Rows)
                {
                    Usuario usuario = new Usuario();
                    usuario.IdUsuario = Convert.ToInt32(linha["IdUsuario"]);
                    usuario.nome = Convert.ToString(linha["nome"]);
                    usuario.senha = Convert.ToString(linha["senha"]);
                    usuario.perfil = Convert.ToString(linha["perfil"]);
                    usuarioColecao.Add(usuario);
                }
                return usuarioColecao;

            }
            catch(Exception ex)
            {
                throw new Exception("nao foi possivel consultar o usuario por nome" + ex.Message);
            }
        }

        //Será retornado se autenticou, e também o nome do perfil de acesso
        public KeyValuePair<bool, string> Autenticar(string nome, string senha)
        {
            try
            {
                UsuarioColecao usuarioColecao = new UsuarioColecao();
                acessoDadosSqlServer.LimparParametros();
                acessoDadosSqlServer.AdicionarParamentros("@nome", nome);
                acessoDadosSqlServer.AdicionarParamentros("@senha", senha);
                DataTable dataTableUsuario = acessoDadosSqlServer.ExecutaConsulta(CommandType.StoredProcedure, "uspUsuarioAutenticar");
                foreach (DataRow linha in dataTableUsuario.Rows)
                {
                       
                    int IdUsuario;
                    if (int.TryParse(linha["IdUsuario"].ToString(), out IdUsuario) && IdUsuario > 0)
                    {
                        string perfil = linha["perfil"].ToString();
                        return new KeyValuePair<bool, string>(true, perfil);
                    }
                    else
                        return new KeyValuePair<bool, string>(false, string.Empty);
                }
                return new KeyValuePair<bool, string>(false, string.Empty);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível realizar a autenticação." + ex.Message);
            }
        }


    }
 }

