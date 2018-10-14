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
    public partial class FrmSelecionarMovCaixa : Form
    {
        public FrmSelecionarMovCaixa()
        {
            InitializeComponent();
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void atualizarGrid()
        {
            CaixaNegocio caixaNegocios = new CaixaNegocio();
            CaixaColecao caixaColecao = new CaixaColecao();


            DateTime dtSelecionada;
            if (!DateTime.TryParse(dtpData.Text, out dtSelecionada) || dtSelecionada == DateTime.MinValue)
            {
                MessageBox.Show("Data selecionada inválida!!");
                return;
            }

            try
            {
                caixaColecao = caixaNegocios.ConsultarPorData(dtSelecionada);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar consulta, por favor tente mais tarde. " + ex.Message);
                return;
            }
            DgvCaixa.AutoGenerateColumns = false;
            DgvCaixa.ReadOnly = true;
            DgvCaixa.DataSource = null;
            DgvCaixa.DataSource = caixaColecao;
            DgvCaixa.Update();
            DgvCaixa.Refresh();

        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            FrmCaixa frmCaixa = new FrmCaixa(AcaoNaTela.Inserir,null);
            DialogResult dialogResult = frmCaixa.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
                atualizarGrid();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //verifica se tem alguma linha selecionada
            if (DgvCaixa.SelectedRows.Count == 0)
            {
                MessageBox.Show(" Nenhum  Mov. Selecionado");
                return;
            }
            //pergunta se relmente quer excluir
            DialogResult resultado = MessageBox.Show("tem certeza que quer excluir  ?", "Perqunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            //pegar socios selecionado na grid
            Caixa caixaSelecionados = (DgvCaixa.SelectedRows[0].DataBoundItem as Caixa);
            //instaciar a regra de negocios
            CaixaNegocio caixaNegocio = new CaixaNegocio();
            // charmar o metodo excluir
            string retono = caixaNegocio.Excluir(caixaSelecionados);
            //verficar se excluir com sucesso
            // se o retono for um numero e porque deu certo, se nao e um mensagem de erro.
            try
            {
                int IDpessoa = Convert.ToInt32(retono);
                MessageBox.Show("Registro excluido com Sucesso!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                atualizarGrid();
            }
            catch
            {
                MessageBox.Show("nao foi possivel excluir detalhe:" + retono, "atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //verifica se tem alguma linha selecionada
            if (DgvCaixa.SelectedRows.Count == 0)
            {
                MessageBox.Show(" Nenhum  Movimento de Caixa  Selecionada");
                return;
            }
            //pegar pessoa selecionado na grid
            Caixa caixaSelecionados = (DgvCaixa.SelectedRows[0].DataBoundItem as Caixa);
                        
            FrmCaixa caixaAlterar = new FrmCaixa (AcaoNaTela.Alterar ,caixaSelecionados);
            DialogResult dialogResult = caixaAlterar.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                atualizarGrid();
            }
        }
    }
}
