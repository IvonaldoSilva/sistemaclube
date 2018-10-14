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

    public partial class frmCadastrarPatrimonio : Form
    {
        TipoColecao tipoColecao = new TipoColecao();
        AcaoNaTela acaoNaTelaSelecionada;
        public frmCadastrarPatrimonio(AcaoNaTela acaoNaTela, Patrimonio patrimonio)
        {
            InitializeComponent();

            CarregarCombo();

            this.acaoNaTelaSelecionada = acaoNaTela;
            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Patrinonio";
            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar Patrimonio";
                txtcodigopatrimonio.Text = patrimonio.IDpatrimonio.ToString();
                
                quantidade.Text = patrimonio.quantidade;
                txtdescricao.Text = patrimonio.descricao;
                dtpAquisicao.Value = patrimonio.dataaquisicao;
                cmbSituacao.Text = patrimonio.ativo;

                if (patrimonio.Idtipo > 0)
                {
                    var retorno = new TipoNegocio().CarregarTipo(patrimonio.Idtipo);
                    if (retorno != null)
                    {
                        cmbtipo.Text = retorno.descricao;

                    }
                }
            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                this.Text = "Consultar Patrimonio";
                txtcodigopatrimonio.Text = patrimonio.IDpatrimonio.ToString();
                cmbtipo.Text = patrimonio.Idtipo.ToString();
                quantidade.Text = patrimonio.quantidade;
                txtdescricao.Text = patrimonio.descricao;
                dtpAquisicao.Value = patrimonio.dataaquisicao;
                cmbSituacao.Text = patrimonio.ativo;

                if (patrimonio.Idtipo > 0)
                {
                    var retorno = new TipoNegocio().CarregarTipo(patrimonio.Idtipo);
                    if (retorno != null)
                    {
                        cmbtipo.Text = retorno.descricao;

                    }
                }

                
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            frmTipo tipo = new frmTipo();
            tipo.ShowDialog();
            tipo.Dispose();
            CarregarCombo();
        }

        

        private void frmCadastrarPatrimonio_Load(object sender, EventArgs e)
        {

            Util.ToolTipButton(btnAdicionar, "Adicionar novo patrimonio");
            Util.ToolTipButton(btnSair, "Sair");
            Util.ToolTipButton(btnSalvar, "salvar");


        }




        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            txtdescricao.ReadOnly = false;
            quantidade.ReadOnly = false;
            quantidade.Enabled = true;
            panelBotoes.Enabled = true;
            btnSalvar.Enabled = true;
            btnAdicionar.Enabled = false;
            cmbtipo.Enabled = true;
            lblAdicionarTipo.Enabled = true;
            cmbSituacao.Enabled = true;
            cmbtipo.Focus();
            
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(quantidade.Text))
            {
                MessageBox.Show("Por Favor Preencher a quantidade ");
                quantidade.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtdescricao.Text))
            {
                MessageBox.Show("Por Favor Preencher a Descricao do objeto");
                txtdescricao.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cmbtipo.Text))
            {
                MessageBox.Show("Por Favor Selecione uma Opção na Caixa Selecao");
                cmbtipo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cmbSituacao.Text))
            {
                MessageBox.Show("Por Favor Selecione uma das Opção na Caixa Selecao");
                cmbSituacao.Focus();
                return;
            }
            if (acaoNaTelaSelecionada == AcaoNaTela.Inserir)
            {
                             
                Patrimonio patrimonio = new Patrimonio();
                MessageBox.Show("Idipo que está tentando salvar: " + cmbtipo.Text);
                patrimonio.Idtipo = Convert.ToInt32(cmbtipo.Text);// cmbtipo.DisplayMember(cmbtipo.SelectedIndex).Selected
                patrimonio.quantidade = quantidade.Text;
                patrimonio.descricao = txtdescricao.Text.ToUpper();
                patrimonio.dataaquisicao = dtpAquisicao.Value;
                patrimonio.ativo = cmbSituacao.Text.ToUpper();
                PatrimonioNegocio patrimonioNegocio = new PatrimonioNegocio();
                string retorno = patrimonioNegocio.Inserir(patrimonio);

                try
                {
                    int IDpatrimonio = Convert.ToInt32(retorno);
                    MessageBox.Show("Patrimonio  inserido com Sucesso Codigo : " + IDpatrimonio.ToString());
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Tipo nao cadastrado!!! favor verificar se o Tipo  existe!!! : ", "atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                    return;
                }
            
            }
            else if (acaoNaTelaSelecionada==AcaoNaTela.Alterar)
            {
               
                Patrimonio patrimonio = new Patrimonio();
                patrimonio.IDpatrimonio = Convert.ToInt32(txtcodigopatrimonio.Text);
                	        
                patrimonio.Idtipo = Convert.ToInt32(cmbtipo.Text); 
                patrimonio.quantidade = quantidade.Text;
                patrimonio.descricao = txtdescricao.Text.ToUpper();
                patrimonio.dataaquisicao = dtpAquisicao.Value;
                patrimonio.ativo = cmbSituacao.Text.ToUpper();

                PatrimonioNegocio patrimonioNegocio = new PatrimonioNegocio();
                string retorno = patrimonioNegocio.Alterar(patrimonio);

                try
                {
                    int IDpatrimonio = Convert.ToInt32(retorno);
                    MessageBox.Show("Patrimonio  Alterado com Sucesso Codigo : " + IDpatrimonio.ToString());
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("nao foi possivel Alterar  detalhe:" + retorno, "atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }
                    
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void quantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            //nao aceita letras
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            { e.Handled = true; }
        }

        private void cmbtipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void cmbtipo_Click(object sender, EventArgs e)
        {
            
        }
        private void CarregarCombo()
        {
            PatrimonioNegocio patrimonioNegocio = new PatrimonioNegocio();
            List<Tipo> tipo = patrimonioNegocio.CarregarCombobox("descricao");
            cmbtipo.DataSource = null;
            cmbtipo.Items.Clear();
            this.cmbtipo.DataSource = tipo;
            this.cmbtipo.ValueMember = Convert.ToString("Idtipo");
            this.cmbtipo.DisplayMember = Convert.ToString("descricao");

            cmbtipo.SelectedIndex = -1;
        }

        private void cmbtipo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            

        }

        private void txtdescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescricaoTipo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbtipo_Leave(object sender, EventArgs e)
        {
                                   
        }

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            txtdescricao.ReadOnly = false;
            quantidade.ReadOnly = false;
            quantidade.Enabled = true;
            panelBotoes.Enabled = true;
            btnSalvar.Enabled = true;
            btnAdicionar.Enabled = false;
            cmbtipo.Enabled = true;
            lblAdicionarTipo.Enabled = true;
            cmbSituacao.Enabled = true;
            cmbtipo.Focus();

        }

        private void Salvar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(quantidade.Text))
            {
                MessageBox.Show("Por Favor Preencher a quantidade ");
                quantidade.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtdescricao.Text))
            {
                MessageBox.Show("Por Favor Preencher a Descricao do objeto");
                txtdescricao.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cmbtipo.Text))
            {
                MessageBox.Show("Por Favor Selecione uma Opção na Caixa Selecao");
                cmbtipo.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cmbSituacao.Text))
            {
                MessageBox.Show("Por Favor Selecione uma das Opção na Caixa Selecao");
                cmbSituacao.Focus();
                return;
            }
            if(string.IsNullOrWhiteSpace(quantidade.Text))
            {
                MessageBox.Show("Nao e possivel cadastrar a quantidade informada");
                quantidade.Focus();
                return;

            }
            if (acaoNaTelaSelecionada == AcaoNaTela.Inserir)
            {

                Patrimonio patrimonio = new Patrimonio();
                patrimonio.Idtipo = Convert.ToInt32(cmbtipo.SelectedValue);
                patrimonio.quantidade = quantidade.Text;
                patrimonio.descricao = txtdescricao.Text.ToUpper();
                patrimonio.dataaquisicao = dtpAquisicao.Value;
                patrimonio.ativo = cmbSituacao.Text.ToUpper();
                PatrimonioNegocio patrimonioNegocio = new PatrimonioNegocio();
                string retorno = patrimonioNegocio.Inserir(patrimonio);

                try
                {
                    int IDpatrimonio = Convert.ToInt32(retorno);
                    MessageBox.Show("Patrimonio  inserido com Sucesso Codigo : " + IDpatrimonio.ToString());
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("Tipo nao cadastrado!!! favor verificar se o Tipo  existe!!! : ", "atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                    return;
                }

            }
            else if (acaoNaTelaSelecionada == AcaoNaTela.Alterar)
            {

                Patrimonio patrimonio = new Patrimonio();
                patrimonio.IDpatrimonio = Convert.ToInt32(txtcodigopatrimonio.Text);

                patrimonio.Idtipo = Convert.ToInt32(cmbtipo.SelectedValue);
                patrimonio.quantidade = quantidade.Text;
                patrimonio.descricao = txtdescricao.Text.ToUpper();
                patrimonio.dataaquisicao = dtpAquisicao.Value;
                patrimonio.ativo = cmbSituacao.Text.ToUpper();

                PatrimonioNegocio patrimonioNegocio = new PatrimonioNegocio();
                string retorno = patrimonioNegocio.Alterar(patrimonio);

                try
                {
                    int IDpatrimonio = Convert.ToInt32(retorno);
                    MessageBox.Show("Patrimonio  Alterado com Sucesso Codigo : " + IDpatrimonio.ToString());
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("nao foi possivel Alterar  detalhe:" + retorno, "atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }

        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
