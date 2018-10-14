using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using ObjetoTransferencia;
using Negocios;

namespace Apresentacao
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusuario.Text))
            {
                MessageBox.Show("Por favor preencher o Usuario");
                txtusuario.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtsenha.Text))
            {
                MessageBox.Show("Por favor inserir a senha");
                txtsenha.Focus();
                return;
            }
            if (cboPerfil.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, selecione um perfil");
                cboPerfil.Focus();
                return;
            }
            Usuario usuario= new Usuario();
            usuario.nome=txtusuario.Text.ToUpper();
            usuario.senha=txtsenha.Text.ToUpper();
            usuario.perfil = cboPerfil.Text;
            UsuarioNegocio usuarionegocio=new UsuarioNegocio();
            string retorno= usuarionegocio.Inserir(usuario);
             try
                {
                    int IdUsuario = Convert.ToInt32(retorno);
                    MessageBox.Show("Usuario inserido com Sucesso Codigo : " + IdUsuario.ToString());
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("nao foi possivel inserir detalhe:" + retorno, "atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }


              }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            Util.ToolTipButton(btnSalvar, "Salvar");
            Util.ToolTipButton(btnCancelar, "Sair");
        }
    }
    }
