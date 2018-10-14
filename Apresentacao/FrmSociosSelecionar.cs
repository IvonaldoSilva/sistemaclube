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
    public partial class FrmSociosSelecionar : Form
    {
        public  Socios SocioSelecionado  { get; set; }
        public string CodeSelect;
        public string Code;
        private string txtCodSocio;
        public FrmSociosSelecionar()
        {
            InitializeComponent();
            //nao gerar linhas automaticas
            dataGridViewPrincipal.AutoGenerateColumns = false;
        }

        private void FrmSociosSelecionar_Load(object sender, EventArgs e)
        {
            Util.ToolTipButton(btnAlterar, "Alterar");
            Util.ToolTipButton(btnExcluir, "Excluir");
            Util.ToolTipButton(BtnInserir, "Adicionar Socio");
            Util.ToolTipButton(btnfechar, "Sair");
            Util.ToolTipButton(BtnConsultar, "Apenas consulta Visual");
        }

        private void dataGridViewPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            Selecionar.Enabled = true;
            atualizarGrid();
            
        }

        private DataTable GetSocios(string Code)
        {
            throw new NotImplementedException();
        }

        private DataTable GetSocioCodigo(string Code)
        {
            throw new NotImplementedException();
        }

        private void atualizarGrid()
        {
            FornecedorNegocios sociosNegocios = new FornecedorNegocios();
            SociosColecao sociosColecao = new SociosColecao();
            sociosColecao = sociosNegocios.ConsultarPorNome(textBoxPequisa.Text);
            dataGridViewPrincipal.DataSource = null;
            dataGridViewPrincipal.DataSource = sociosColecao;
            dataGridViewPrincipal.Update();
            dataGridViewPrincipal.Refresh();
            
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxPequisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewPrincipal_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }

        private void dataGridViewPrincipal_RowsDefaultCellStyleChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //verifica se tem alguma linha selecionada
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show(" Nenhum  Pessoa Selicionada");
                return;
            }
            //pergunta se relmente quer excluir
            DialogResult resultado = MessageBox.Show("tem certeza que quer excluir  ?", "Perqunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            //pegar socios selecionado na grid
            Socios sociosSelecionados = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Socios);
            //instaciar a regra de negocios
            FornecedorNegocios socioNegocio = new FornecedorNegocios();
            // charmar o metodo excluir
            string retono = socioNegocio.Excluir(sociosSelecionados);
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

        private void BtnInserir_Click(object sender, EventArgs e)
        {
            FrmSocioCadastrar frmSocioCadastrar = new FrmSocioCadastrar(AcaoNaTela.Inserir, null);
            DialogResult dialogResult = frmSocioCadastrar.ShowDialog();

            if (dialogResult == DialogResult.Yes)
            {
                atualizarGrid();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //verifica se tem alguma linha selecionada
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show(" Nenhum  Pessoa Selecionada");
                return;
            }
            //pegar socios selecionado na grid
            Socios sociosSelecionados = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Socios);

            //instancia o formulario
            FrmSocioCadastrar frmSocioCadastrar = new FrmSocioCadastrar(AcaoNaTela.Alterar, sociosSelecionados);
            
            DialogResult dialogResult = frmSocioCadastrar.ShowDialog();
            if (dialogResult == DialogResult.Yes)
            {
                atualizarGrid();
            }


        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            //verifica se tem alguma linha selecionada
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show(" Nenhum  Pessoa Selicionada");
                return;
            }
            //pegar socios selecionado na grid
            Socios sociosSelecionados = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Socios);
            FrmSocioCadastrar frmSocioCadastrar = new FrmSocioCadastrar(AcaoNaTela.Consultar, sociosSelecionados);
            frmSocioCadastrar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Para cadastrar os Dependente precisa selicionar o Socio titular");
                return;
            }
            FrmDependenteCadastrar frmdependente = new FrmDependenteCadastrar(AcaoNaTela.Inserir,null);
            frmdependente.ShowDialog();
        }

        private void dataGridViewPrincipal_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridViewPrincipal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //string resultado = dataGridViewPrincipal.Rows[Convert.ToInt32(e.RowIndex)].Cells[0].Value.ToString();
            //DialogResult = DialogResult.OK;
            //Close();
        }

        private void Selecionar_Click(object sender, EventArgs e)
        {
            if(dataGridViewPrincipal.SelectedRows.Count==0)
            {
                MessageBox.Show("Nenhuma linha Selecionada");
                return;
            }
            
            SocioSelecionado = dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Socios;
            DialogResult = System.Windows.Forms.DialogResult.OK;


        }
    }

}
    

