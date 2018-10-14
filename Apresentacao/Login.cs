using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;


using Negocios;
using ObjetoTransferencia;


namespace Apresentacao
{
    class Login
    {
                private string _login;

                public string Login1
                {
                    get { return _login; }
                    set { _login = value; }
                }
                private string _senha;

                public string Senha
                {
                    get { return _senha; }
                    set { _senha = value; }
                }

                private string _nomeUsuario;

                public string NomeUsuario
                {
                    get { return _nomeUsuario; }
                    set { _nomeUsuario = value; }
                }

                private string msg;

                public string Msg
                {
                    get { return msg; }
                    set { msg = value; }
                }
      public DataTable valida()
                {
                    Login login = new Login();
                    DataTable dtUsuario = new DataTable();
                  
                    
                    login.limpaLixoCommandText = "seleciona_usuario";
                    login.limpaLixo.CommandType = CommandType.StoredProcedure;
                    login.dtusuario.Parameters.AddWithValue("@nome", this._usuario);
                    login.commandParameters.AddWithValue("@senha", this._senha);
                    dtUsuario = login.ExecutaComando();

                    return dtUsuario;

                }

                public bool limpaLixo(string login)
                {
                    string[] nomes;
                    nomes = new string[4];

                    nomes = login.Split(' ');

                    if (nomes.Contains("select"))
                    {
                        return true;
                    }
                    else if (nomes.Contains("drop"))
                    {
                        return true;
                    }
                    else if (nomes.Contains("update"))
                    {
                        return true;
                    }
                    else if (nomes.Contains("admin"))
                    {
                        return true;
                    }
                    else if (nomes.Contains(";"))
                    {
                        return true;
                    }
                    else if (nomes.Contains("--"))
                    {
                        return true;
                    }
                    else if (nomes.Contains("'"))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }




               internal DataTable valida(string valida)
                {
                    throw new NotImplementedException();
                }
    }
}
