using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using Negocios;
using ObjetoTransferencia;

namespace Apresentacao
{
    public partial class Frmlogin : Form
    {
        public string strPerfilAcesso;
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnlogar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnome.Text))
            {
                MessageBox.Show("Favor inserir o nome de Usuario");
                txtnome.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtsenha.Text))
            {
                MessageBox.Show("Favor preencher a Senha");
                txtsenha.Focus();
                return;
            }

            var retorno = new UsuarioNegocio().Autenticar(txtnome.Text, txtsenha.Text);
            if (retorno.Key)
            {
                strPerfilAcesso = retorno.Value;
                Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
