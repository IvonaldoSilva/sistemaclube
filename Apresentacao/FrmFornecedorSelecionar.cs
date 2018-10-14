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
    public partial class FrmFornecedorSelecionar : Form
    {
        public Fornecedor FornecedorSelecionado { get; set; }
        public string CodeSelect;
        public string Code;
        private string txtCodigo;
        public FrmFornecedorSelecionar()
        {
            InitializeComponent();
            dataGridViewFornecedor.AutoGenerateColumns = false;
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //verifica se tem alguma linha selecionada
            if (dataGridViewFornecedor.SelectedRows.Count == 0)
            {
                MessageBox.Show(" Nenhum  Fornecedor  Selicionada");
                return;
            }
            //pergunta se relmente quer excluir
            DialogResult resultado = MessageBox.Show("tem certeza que quer excluir  ?", "Perqunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            //pegar FORNECEDORES selecionado na grid
            Fornecedor fornecedorSelecionados = (dataGridViewFornecedor.SelectedRows[0].DataBoundItem as Fornecedor);
            //instaciar a regra de negocios
            FornecedorNegocio fornecedorNegocio = new FornecedorNegocio();
            // charmar o metodo excluir
            string retono = fornecedorNegocio.Excluir(fornecedorSelecionados);
            //verficar se excluir com sucesso
            // se o retono for um numero e porque deu certo, se nao e um mensagem de erro.
            try
            {
                int IdFornecedor = Convert.ToInt32(retono);
                MessageBox.Show("Registro excluido com Sucesso!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                atualizarGrid();
                //LimparCampo();
            }
            catch
            {
                MessageBox.Show("nao foi possivel excluir detalhe:" + retono, "atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void atualizarGrid()
        {
            FornecedorNegocio fornecedorNegocios = new FornecedorNegocio();
            FornecedorColecao fornecedorColecao = new FornecedorColecao();
            fornecedorColecao = fornecedorNegocios.ConsultarPorNome(txtnome.Text);
            dataGridViewFornecedor.DataSource = null;
            dataGridViewFornecedor.DataSource = fornecedorColecao;
            dataGridViewFornecedor.Update();
            dataGridViewFornecedor.Refresh();
        }

        private void dataGridViewFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LimparCampo()
        {
            txtnome.Clear();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //verifica se tem alguma linha selecionada
            if (dataGridViewFornecedor.SelectedRows.Count == 0)
            {
                MessageBox.Show(" Nenhum  Pessoa Selecionada");
                return;
            }
            //pegar pessoa selecionado na grid
            Fornecedor fornecedorSelecionados = (dataGridViewFornecedor.SelectedRows[0].DataBoundItem as Fornecedor);
            frmCadastrarFornecedor cadastrarFornecedor = new frmCadastrarFornecedor(AcaoNaTela.Alterar,fornecedorSelecionados);
            DialogResult dialogResult = cadastrarFornecedor.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                atualizarGrid();
            }
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            frmCadastrarFornecedor cadastrarFornecedor = new frmCadastrarFornecedor(AcaoNaTela.Inserir, null);
            DialogResult dialogResult = cadastrarFornecedor.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
                atualizarGrid();
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewFornecedor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma linha Selecionada");
                return;
            }

            FornecedorSelecionado = dataGridViewFornecedor.SelectedRows[0].DataBoundItem as Fornecedor;
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void FrmFornecedorSelecionar_Load(object sender, EventArgs e)
        {
            Util.ToolTipButton(btnAlterar, "Alterar");
            Util.ToolTipButton(btnExcluir, "Excluir");
            Util.ToolTipButton(BtnInserir, "Adicionar Fornecedor");
            Util.ToolTipButton(btnfechar, "Sair");
        }
    }
}
