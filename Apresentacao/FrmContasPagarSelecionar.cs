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
    public partial class FrmContasPagarSelecionar : Form
    {
        public FrmContasPagarSelecionar()
        {
            InitializeComponent();
            dgvContasPagar.AutoGenerateColumns = false;
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            FrmContasPagar frmContasPagar = new FrmContasPagar(AcaoNaTela.Inserir, null);
            DialogResult dialogResult = frmContasPagar.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
                atualizarGrid();
            }
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            atualizarGrid();
            
        }

        private void atualizarGrid()
        {
                   
                ContasPagarNegocio contasPagarNegocio = new ContasPagarNegocio();
                ContasPagarColecao contasPagarColecao = new ContasPagarColecao();
                contasPagarColecao = contasPagarNegocio.ConsultarNome(txtpesquisa.Text);

                dgvContasPagar.DataSource = null;
                dgvContasPagar.DataSource = contasPagarColecao;
                dgvContasPagar.Update();
                dgvContasPagar.Refresh();
            }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //verifica se tem alguma linha selecionada
            if (dgvContasPagar.SelectedRows.Count == 0)
            {
                MessageBox.Show(" Nenhum  Pessoa Selecionada");
                return;
            }
            //pegar socios selecionado na grid
            ContasPagar contasSelecionados = (dgvContasPagar.SelectedRows[0].DataBoundItem as ContasPagar);

            if (!contasSelecionados.situacao)
            {
                MessageBox.Show("Não é possível alterar uma conta já paga!");
                return;
            }

            //instancia o formulario
            FrmContasPagar frmContasPagar = new FrmContasPagar(AcaoNaTela.Alterar, contasSelecionados);

            DialogResult dialogResult = frmContasPagar.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                atualizarGrid();
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //verifica se tem alguma linha selecionada
            if (dgvContasPagar.SelectedRows.Count == 0)
            {
                MessageBox.Show(" Nenhum  Contas a Pagar Selecionado ");
                return;
            }
            //pergunta se relmente quer excluir
            DialogResult resultado = MessageBox.Show("tem certeza que quer excluir  ?", "Perqunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            //pegar FORNECEDORES selecionado na grid
            ContasPagar contasSelecionados = (dgvContasPagar.SelectedRows[0].DataBoundItem as ContasPagar);

            if (!contasSelecionados.situacao)
            {
                MessageBox.Show("Não é possível excluir uma conta já paga!");
                return;
            }
            //instaciar a regra de negocios
            ContasPagarNegocio contasPagarNegocio = new ContasPagarNegocio();
            // charmar o metodo excluir
            string retono = contasPagarNegocio.Excluir(contasSelecionados);
            //verficar se excluir com sucesso
            // se o retono for um numero e porque deu certo, se nao e um mensagem de erro.
            try
            {
                int idcontaspagar = Convert.ToInt32(retono);
                MessageBox.Show("Registro excluido com Sucesso!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                atualizarGrid();
                //LimparCampo();
            }
            catch
            {
                MessageBox.Show("nao foi possivel excluir detalhe:" + retono, "atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnpagar_Click(object sender, EventArgs e)
        {
            //verifica se tem alguma linha selecionada
            if (dgvContasPagar.SelectedRows.Count == 0)
            {
                MessageBox.Show(" Nenhuma Conta ou Pessoa Selecionada");
                return;
            }
            
            //pegar socios selecionado na grid
            ContasPagar contasSelecionados = (dgvContasPagar.SelectedRows[0].DataBoundItem as ContasPagar);
            if(contasSelecionados.situacao==false)
            {
                MessageBox.Show("Conta Selecionada ja Esta pago, Selecionar outra conta !!!");
                return;
            }
            //instancia o formulario
            FrmContasPagar frmContasPagar = new FrmContasPagar(AcaoNaTela.Consultar, contasSelecionados);

            DialogResult dialogResult = frmContasPagar.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                atualizarGrid();
            }
        }

        private void FrmContasPagarSelecionar_Load(object sender, EventArgs e)
        {
            Util.ToolTipButton(btnAlterar, "Alterar");
            Util.ToolTipButton(btnExcluir, "Excluir");
            Util.ToolTipButton(BtnInserir, "Adicionar");
            Util.ToolTipButton(btnfechar,"Sair");
            
            
            
            
        }
    }

    }

