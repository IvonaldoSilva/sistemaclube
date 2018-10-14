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
    public partial class frmPatrimonioSelecionar : Form
    {
        public string CodeSelect;
        public string Code;
        private string txtCodigo;
        public frmPatrimonioSelecionar()
        {
            InitializeComponent();
            dgvPatrimonio.AutoGenerateColumns = false;

        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            frmCadastrarPatrimonio frmcadastrar = new frmCadastrarPatrimonio(AcaoNaTela.Inserir,null);
            frmcadastrar.ShowDialog();
            frmcadastrar.Dispose();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //verifica se tem alguma linha selecionada
            if (dgvPatrimonio.SelectedRows.Count == 0)
            {
                MessageBox.Show(" Nenhum  Registro Selecionado");
                return;
            }
            //pegar pessoa selecionado na grid
            Patrimonio patrimonioSelecionados = (dgvPatrimonio.SelectedRows[0].DataBoundItem as Patrimonio);
            frmCadastrarPatrimonio cadastrarPatrimonio = new frmCadastrarPatrimonio(AcaoNaTela.Alterar, patrimonioSelecionados);
            DialogResult dialogResult = cadastrarPatrimonio.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                atualizarGrid();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //verifica se tem alguma linha selecionada
            if (dgvPatrimonio.SelectedRows.Count == 0)
            {
                MessageBox.Show(" Nenhum  Patrimonio Selicionada");
                return;
            }
            //pergunta se relmente quer excluir
            DialogResult resultado = MessageBox.Show("tem certeza que quer excluir  ?", "Perqunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            //pegar FORNECEDORES selecionado na grid
            Patrimonio patrimonioSelecionados = (dgvPatrimonio.SelectedRows[0].DataBoundItem as Patrimonio);
            //instaciar a regra de negocios
            PatrimonioNegocio patrimonioNegocio = new PatrimonioNegocio();
            // charmar o metodo excluir
            string retono = patrimonioNegocio.Excluir(patrimonioSelecionados);
            //verficar se excluir com sucesso
            // se o retono for um numero e porque deu certo, se nao e um mensagem de erro.
            try
            {
                int idpatrimonio = Convert.ToInt32(retono);
                MessageBox.Show("Registro excluido com Sucesso!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                atualizarGrid();
                //LimparCampo();
            }
            catch
            {
                MessageBox.Show("nao foi possivel excluir detalhe:" + retono, "atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void atualizarGrid()
        {
            PatrimonioNegocio patrimonioNegocios = new PatrimonioNegocio();
            PatrimonioColecao patrimonioColecao = new PatrimonioColecao();
            patrimonioColecao = patrimonioNegocios.ConsultarPorNome(txtpesquisar.Text);
            dgvPatrimonio.DataSource = null;
            dgvPatrimonio.DataSource = patrimonioColecao;
            dgvPatrimonio.Update();
            dgvPatrimonio.Refresh();
        }

        private void frmPatrimonioSelecionar_Load(object sender, EventArgs e)
        {
            Util.ToolTipButton(BtnInserir, "Adicionar um novo Patrimonio.");
            Util.ToolTipButton(btnAlterar, "Alterar");
            Util.ToolTipButton(btnExcluir, "Excluir");
            Util.ToolTipButton(btnfechar, "Sair");
        }
    }
}