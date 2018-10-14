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
    public partial class FrmSelecionarDependente : Form
    {
        Socios socio;
        public string CodeSelect;
        public string Code;
        private string txtCodSocio;
        public FrmSelecionarDependente()
        {
            InitializeComponent();
            dataGridViewDep.AutoGenerateColumns = false;
        }

        private void btnpesquisardep_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codSocio.Text))
            {
                MessageBox.Show("Por favor, preencha a matricula do titular!");
                codSocio.Focus();
                return;

            }
            
            atualizarGrid();

        }

        private void atualizarGrid()
        {
            try

            {

                int texto = Convert.ToInt32(codSocio.Text);
                string nome = Convert.ToString(nomeSocio.Text);

                DependenteNegocio dependenteNegocio = new DependenteNegocio();
                DependenteColecao dependenteColecao = new DependenteColecao();
                dependenteColecao = dependenteNegocio.consultarporcodigo(texto);
                

                dataGridViewDep.DataSource = null;
                dataGridViewDep.DataSource = dependenteColecao;
                dataGridViewDep.Update();
                dataGridViewDep.Refresh();
                return;
                

            }
            catch
            {

                dataGridViewDep.DataSource = null;
                MessageBox.Show("Socio nao cadastrado  ou nao possui  dependente cadastrado!!");
                return;
            }


        }



        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(codSocio.Text))
            {
                MessageBox.Show("Por favor, preencha codigo socio!");
                codSocio.Focus();
                return;
            }
            else
            {
                
                FrmDependenteCadastrar cadastrardependente = new FrmDependenteCadastrar(AcaoNaTela.Inserir,null);
                cadastrardependente.carregarCodigo = codSocio.Text;
                cadastrardependente.ShowDialog();
                

            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewDep.SelectedRows.Count == 0)
            {
                MessageBox.Show(" Nenhum  Pessoa Selicionada");
                return;
            }
            //pergunta se realmente quer excluir
            DialogResult resultado = MessageBox.Show("tem certeza que quer excluir  ?", "Perqunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            //pegar socios selecionado na grid
            Dependente dependenteSelecionados = (dataGridViewDep.SelectedRows[0].DataBoundItem as Dependente);
            //instaciar a regra de negocios
            DependenteNegocio dependenteNegocio = new DependenteNegocio();
            // charmar o metodo excluir
            string retono = dependenteNegocio.Excluir(dependenteSelecionados);
            //verficar se excluir com sucesso
            // se o retono for um numero e porque deu certo, se nao e um mensagem de erro.
            try
            {
                int IdDep = Convert.ToInt32(retono);
                MessageBox.Show("Registro excluido com Sucesso!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                atualizarGrid();
            }
            catch
            {
                MessageBox.Show("nao foi possivel excluir detalhe:" + retono, "atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //verifica se tem alguma linha selecionada
            if (dataGridViewDep.SelectedRows.Count == 0)
            {
                MessageBox.Show(" Nenhum  Pessoa Selecionada");
                return;
            }

            //pegar socios selecionado na grid
            Dependente dependenteSelecionado = (dataGridViewDep.SelectedRows[0].DataBoundItem as Dependente);
            //instancia o formulario
            FrmDependenteCadastrar frmdependente = new FrmDependenteCadastrar(AcaoNaTela.Alterar, dependenteSelecionado);
            DialogResult dialogResult = frmdependente.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                atualizarGrid();
            }
        }

        private void MatriculaTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrEmpty(codSocio.Text))
                    return;

                FornecedorNegocios objSocio = new FornecedorNegocios();
                SociosColecao objRetorno = objSocio.ConsultarPorID(Convert.ToInt32(codSocio.Text));

                codSocio.Text = "";
                nomeSocio.Text = "";
                if (objRetorno != null && objRetorno.Count > 0)
                {
                    codSocio.Text = objRetorno.FirstOrDefault().IDpessoa.ToString();
                    nomeSocio.Text = objRetorno.FirstOrDefault().Nome;
                }
            }

            else
            {
                //nao aceita letras
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
                { e.Handled = true; }
            }
        }

        private void FrmSelecionarDependente_Load(object sender, EventArgs e)
        {
            Util.ToolTipButton(btnAlterar, "Alterar");
            Util.ToolTipButton(btnExcluir, "Excluir");
            Util.ToolTipButton(btncadastrar, "Adicionar Fornecedor");
            Util.ToolTipButton(btnSair, "Sair");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FrmSociosSelecionar socioSelecionar = new FrmSociosSelecionar();
            DialogResult resultado = socioSelecionar.ShowDialog();
            if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                codSocio.Text = socioSelecionar.SocioSelecionado.IDpessoa.ToString();
                nomeSocio.Text = socioSelecionar.SocioSelecionado.Nome;
                socio = socioSelecionar.SocioSelecionado;
                return;
            }
        }
    }
}
