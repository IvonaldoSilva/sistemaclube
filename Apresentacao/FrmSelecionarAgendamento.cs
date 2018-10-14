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
    public partial class FrmSelecionarAgendamento : Form
    {
        public Agendamento AgendamentoSelecionado { get; set; }
        public string CodeSelect;
        public string Code;
        private string txtCodigo;
        public FrmSelecionarAgendamento()
        {
            InitializeComponent();
            DgvAgenda.AutoGenerateColumns = false;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //verifica se tem alguma linha selecionada
            if (DgvAgenda.SelectedRows.Count == 0)
            {
                MessageBox.Show(" Nenhum  Compromisso  Selecionada");
                return;
            }
            //pegar pessoa selecionado na grid
            Agendamento agendamentoSelecionados = (DgvAgenda.SelectedRows[0].DataBoundItem as Agendamento);

            if (agendamentoSelecionados.situacao==false)
            {
                MessageBox.Show("Não é possível alterar um agendamento já pago!");
                return;
            }
            
            FrmAgendamento cadastrarAgenda = new FrmAgendamento(AcaoNaTela.Alterar, agendamentoSelecionados);
            DialogResult dialogResult = cadastrarAgenda.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                atualizarGrid();
            }
        }

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            FrmAgendamento frmAgendamento = new FrmAgendamento(AcaoNaTela.Inserir, null);
            DialogResult dialogResult = frmAgendamento.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
                atualizarGrid();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // verifica se tem alguma linha selecionada
            if (DgvAgenda.SelectedRows.Count == 0)
            {
                MessageBox.Show(" Nenhum  Agendamento Selecionado");
                return;
            }
            //pergunta se relmente quer excluir
            DialogResult resultado = MessageBox.Show("tem certeza que quer excluir  ?", "Perqunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            //pegar socios selecionado na grid
            Agendamento agendamentoSelecionados = (DgvAgenda.SelectedRows[0].DataBoundItem as Agendamento);

            if (agendamentoSelecionados.situacao==false)
            {
                MessageBox.Show("Não é possível excluir um agendamento já pago!");
                return;
            }
            //instaciar a regra de negocios
            AgendamentoNegocios agendamentoNegocio = new AgendamentoNegocios();
            // charmar o metodo excluir
            string retono = agendamentoNegocio.Excluir(agendamentoSelecionados);
            //verficar se excluir com sucesso
            // se o retono for um numero e porque deu certo, se nao e um mensagem de erro.
            try
            {
                int idagendamento = Convert.ToInt32(retono);
                MessageBox.Show("Registro excluido com Sucesso!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                atualizarGrid();
            }
            catch
            {
                MessageBox.Show("nao foi possivel excluir detalhe:" + retono, "atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void atualizarGrid()
        {
            AgendamentoNegocios agendamentoNegocios = new AgendamentoNegocios();
            AgendamentoColecao agendamentoColecao = new AgendamentoColecao();
            agendamentoColecao = agendamentoNegocios.ConsultarPorNome(txtnome.Text);
                        
            DgvAgenda.AutoGenerateColumns = false;
            DgvAgenda.ReadOnly = true;
            DgvAgenda.DataSource = null;
            DgvAgenda.DataSource = agendamentoColecao;
            DgvAgenda.Update();
            DgvAgenda.Refresh();

        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void FrmSelecionarAgendamento_Load(object sender, EventArgs e)
        {
            Util.ToolTipButton(btnAlterar, "Alterar");
            Util.ToolTipButton(btnExcluir, "Excluir");
            Util.ToolTipButton(BtnInserir, "Adicionar Fornecedor");
            Util.ToolTipButton(btnfechar, "Sair");
        }

        private void btnPesquisa_Click_1(object sender, EventArgs e)
        {
            atualizarGrid();
        }
    }
}
