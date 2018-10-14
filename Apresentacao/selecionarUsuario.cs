using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocios;
using ObjetoTransferencia;

namespace Apresentacao
{
    public partial class FrmConsultaUsuario : Form
    {
        public FrmConsultaUsuario()
        {
            InitializeComponent();
            dataGridViewUsuario.AutoGenerateColumns = false;
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            atualizarGrid();
        }
        private void atualizarGrid()
        {
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            UsuarioColecao usuarioColecao  = new UsuarioColecao();
            usuarioColecao = usuarioNegocio.ConsultarPorNome(txtnome.Text);
            dataGridViewUsuario.DataSource = null;
            dataGridViewUsuario.DataSource = usuarioColecao;
            dataGridViewUsuario.Update();
            dataGridViewUsuario.Refresh();

        }

        private void dataGridViewUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewUsuario_RowDefaultCellStyleChanged(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void dataGridViewUsuario_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void dataGridViewUsuario_RowsDefaultCellStyleChanged(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            FrmUsuario frmusuario = new FrmUsuario();
            frmusuario.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
                            
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewUsuario.SelectedRows.Count ==0 )
            {
                MessageBox.Show("nenhum usuario selecionado");
                return;

            }
            DialogResult resultado = MessageBox.Show("tem certeza que quer excluir  ?", "Perqunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            Usuario usuarioSelecionado = (dataGridViewUsuario.SelectedRows[0].DataBoundItem as Usuario);
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            string retorno = usuarioNegocio.Excluir(usuarioSelecionado);
            try
            {
                int IdUsuario = Convert.ToInt32(retorno);
                MessageBox.Show("Registro excluido com Sucesso!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                atualizarGrid();
            }
            catch
            {
                MessageBox.Show("Nao foi possivel excluir Usuario detalhe :" + retorno, "atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmConsultaUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'clubeDataSet1.tblUsuario'. Você pode movê-la ou removê-la conforme necessário.
         
            Util.ToolTipButton(btncadastrar, "Adicionar Novo Usuario");
            Util.ToolTipButton(btnExcluir, "Exluir");
            Util.ToolTipButton(btnSair, "Sair");
        }
    }
}
