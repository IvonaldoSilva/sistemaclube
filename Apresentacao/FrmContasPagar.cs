using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


using ObjetoTransferencia;
using Negocios;

namespace Apresentacao
{
    public partial class FrmContasPagar : Form
    {
        Socios socio;
        Fornecedor fornecedor;
        AcaoNaTela acaoNaTelaSelecionada;

        public FrmContasPagar(AcaoNaTela acaoNaTela, ContasPagar contasPagar)
        {
            InitializeComponent();
            this.acaoNaTelaSelecionada = acaoNaTela;

            dtpPagamento.Visible = false;
            lbDataPagamento.Visible = false;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Contas A Pagar";

            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar Contas A Pagar";
                txtidcontaspagar.Text = contasPagar.idcontaspagar.ToString();
                if (contasPagar.pessoatipo == "P.Fisica")
                {
                    RdbSocio.Checked = true;
                }
                else
                    RdbFonecedor.Checked = true;

                txtCodigo.Text = contasPagar.codpessoa.ToString();
                txtNome.Text = contasPagar.nome;
                cmbTipodocumento.Text = contasPagar.tipodocumento;
                txtdocumento.Text = contasPagar.documento;
                txtvalordocumento.Text = contasPagar.valordocumento.ToString();
                dtpEmissao.Value = contasPagar.dataemissao;
                dtpVencimento.Value = contasPagar.datavencimento;
                txthistorico.Text = contasPagar.historico;
                if (contasPagar.situacao == true)
                    rdbapagar.Checked = true;
                else
                    rdbpago.Checked = true;

                rdbapagar.Enabled = false;
                rdbpago.Enabled = false;




            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {

                this.Text = "Fazer o Pagamento Contas a Pagar";
                txtidcontaspagar.Text = contasPagar.idcontaspagar.ToString();
                rdbpago.Enabled = true;
                rdbapagar.Enabled = true;
                if (contasPagar.pessoatipo == "P.Fisica")
                {
                    RdbSocio.Checked = true;
                }
                else
                    RdbFonecedor.Checked = true;
                txtCodigo.Text = contasPagar.codpessoa.ToString();
                txtNome.Text = contasPagar.nome;
                cmbTipodocumento.Text = contasPagar.tipodocumento;
                txtdocumento.Text = contasPagar.documento;
                txtvalordocumento.Text = contasPagar.valordocumento.ToString();
                dtpEmissao.Value = contasPagar.dataemissao;
                dtpVencimento.Value = contasPagar.datavencimento;
                
                txthistorico.Text = contasPagar.historico;
                if (contasPagar.situacao == true)
                    rdbapagar.Checked = true;
                else
                    rdbpago.Checked = true;

                paneldados.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Por favor, preencha o campo Codigo, clicando  no botão + !");
                txtCodigo.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Por favor, Selecionar Uma Pessoa no botao  + para continuar  !");
                txtNome.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(cmbTipodocumento.Text))
            {
                MessageBox.Show("Por favor, Selecionar Tipo de documento !");
                txtNome.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtdocumento.Text))
            {
                MessageBox.Show("Por favor, digite o numero do Documento   !");
                txtdocumento.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtvalordocumento.Text))
            {
                MessageBox.Show("Por favor, Digite o valor do Documento  !");
                txtvalordocumento.Focus();
                return;
            }

            else if (string.IsNullOrEmpty(txthistorico.Text))
            {
                MessageBox.Show("Por favor, Colocar informacoes historico complementar !");
                txthistorico.Focus();
                return;
            }
            if (acaoNaTelaSelecionada == AcaoNaTela.Inserir)
            {
                ContasPagar contasPagar = new ContasPagar();
                if (RdbSocio.Checked == true)
                {
                    contasPagar.pessoatipo = "P.Fisica";
                }
                else if (RdbFonecedor.Checked == true)
                {
                    contasPagar.pessoatipo = "P.Juridica";
                }
                contasPagar.codpessoa = Convert.ToInt32(txtCodigo.Text);
                contasPagar.nome = txtNome.Text.ToUpper();
                contasPagar.tipodocumento = cmbTipodocumento.Text.ToUpper();
                contasPagar.documento = txtdocumento.Text.ToUpper();
                contasPagar.valordocumento = Convert.ToDecimal(txtvalordocumento.Text);
                contasPagar.datavencimento = dtpVencimento.Value;
                
                contasPagar.dataemissao = dtpEmissao.Value;
                contasPagar.historico = txthistorico.Text.ToUpper();
                if (rdbapagar.Checked == true)
                    contasPagar.situacao = true;
                else if (rdbpago.Checked == true)
                    contasPagar.situacao = false;
                
                ContasPagarNegocio contasPagarNegocio = new ContasPagarNegocio();
                string retorno = contasPagarNegocio.Inserir(contasPagar);

                //tentar converter para inteiro se der certo devolve o codigo 
                try
                {
                    int idcontaspagar = Convert.ToInt32(retorno);
                    MessageBox.Show("Contas a Pagar inserido Com Sucesso !!! : " + idcontaspagar.ToString());
                    this.DialogResult = DialogResult.Yes;
                    return;
                }
                //de errado devolve mensagem de erro.
                catch
                {
                    MessageBox.Show("nao foi possivel inserir detalhe:" + retorno, "atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }
            else if (acaoNaTelaSelecionada == AcaoNaTela.Alterar)
            {
                ContasPagar contasPagar = new ContasPagar();
                if (RdbSocio.Checked == true)
                {
                    contasPagar.pessoatipo = "P.Fisica";
                }
                else if (RdbFonecedor.Checked == true)
                {
                    contasPagar.pessoatipo = "P.Juridica";
                }
                contasPagar.idcontaspagar = Convert.ToInt32(txtidcontaspagar.Text);
                contasPagar.codpessoa = Convert.ToInt32(txtCodigo.Text);
                contasPagar.nome = txtNome.Text.ToUpper();
                contasPagar.tipodocumento = cmbTipodocumento.Text.ToUpper();
                contasPagar.documento = txtdocumento.Text.ToUpper();
                contasPagar.valordocumento = Convert.ToDecimal(txtvalordocumento.Text);
                contasPagar.datavencimento = dtpVencimento.Value;
                contasPagar.dataemissao = dtpEmissao.Value;
                contasPagar.historico = txthistorico.Text.ToUpper();
                if (rdbapagar.Checked == true)
                    contasPagar.situacao = true;
                else if (rdbpago.Checked == true)
                    contasPagar.situacao = false;

                ContasPagarNegocio contasPagarNegocio = new ContasPagarNegocio();
                string retorno = contasPagarNegocio.Alterar(contasPagar);

                //tentar converter para inteiro se der certo devolve o codigo 
                try
                {
                    int idcontaspagar = Convert.ToInt32(retorno);
                    MessageBox.Show("Contas a Pagar inserido Com Sucesso !!! : " + idcontaspagar.ToString());
                    this.DialogResult = DialogResult.Yes;
                    return;
                }
                //de errado devolve mensagem de erro.
                catch
                {
                    MessageBox.Show("nao foi possivel inserir detalhe:" + retorno, "atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }

            }
            else if (acaoNaTelaSelecionada == AcaoNaTela.Consultar)
            {
                ContasPagar contasPagar = new ContasPagar();
                if (RdbSocio.Checked == true)
                {
                    contasPagar.pessoatipo = "P.Fisica";
                }
                else if (RdbFonecedor.Checked == true)
                {
                    contasPagar.pessoatipo = "P.Juridica";
                }
                contasPagar.idcontaspagar = Convert.ToInt32(txtidcontaspagar.Text);
                contasPagar.codpessoa = Convert.ToInt32(txtCodigo.Text);
                contasPagar.nome = txtNome.Text.ToUpper();
                contasPagar.tipodocumento = cmbTipodocumento.Text.ToUpper();
                contasPagar.documento = txtdocumento.Text.ToUpper();
                contasPagar.valordocumento = Convert.ToDecimal(txtvalordocumento.Text);
                contasPagar.datavencimento = dtpVencimento.Value;
                contasPagar.dataPagamento = dtpPagamento.Value;
                contasPagar.dataemissao = dtpEmissao.Value;
                contasPagar.historico = txthistorico.Text.ToUpper();
                if (rdbapagar.Checked == true)
                {
                    MessageBox.Show("Favor alterar o titulo para pago!!");
                    return;

                }
                else if (rdbpago.Checked == true)
                {
                    contasPagar.situacao = false;
                    contasPagar.dataPagamento = dtpPagamento.Value;
                }
                else
                    contasPagar.situacao = false;

                

                ContasPagarNegocio contasPagarNegocio = new ContasPagarNegocio();
                string retorno = contasPagarNegocio.Alterar(contasPagar);

                //tentar converter para inteiro se der certo devolve o codigo 
                try
                {
                    int idcontaspagar = Convert.ToInt32(retorno);
                    MessageBox.Show("Contas Paga com Sucesso !!! : " + idcontaspagar.ToString());
                    this.DialogResult = DialogResult.Yes;
                    return;
                }
                //de errado devolve mensagem de erro.
                catch
                {
                    MessageBox.Show("nao foi possivel inserir detalhe:" + retorno, "atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }

            }
        }

        private void lblAdicionar_Click(object sender, EventArgs e)
        {
        }

        private void lblAdicionar_Click_1(object sender, EventArgs e)
        {
            if (RdbSocio.Checked == true)
            {
                FrmSociosSelecionar socioSelecionar = new FrmSociosSelecionar();
                DialogResult resultado = socioSelecionar.ShowDialog();
                if (resultado == System.Windows.Forms.DialogResult.OK)
                {
                    txtCodigo.Text = socioSelecionar.SocioSelecionado.IDpessoa.ToString();
                    txtNome.Text = socioSelecionar.SocioSelecionado.Nome;
                    socio = socioSelecionar.SocioSelecionado;
                    return;
                }
            }
            else if (RdbFonecedor.Checked == true)
            {
                FrmFornecedorSelecionar FornecedorSelecionar = new FrmFornecedorSelecionar();
                DialogResult resultado1 = FornecedorSelecionar.ShowDialog();
                if (resultado1 == System.Windows.Forms.DialogResult.OK)
                {
                    txtCodigo.Text = FornecedorSelecionar.FornecedorSelecionado.idFornecedor.ToString();
                    txtNome.Text = FornecedorSelecionar.FornecedorSelecionado.nome;
                    fornecedor = FornecedorSelecionar.FornecedorSelecionado;
                    return;
                }
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (RdbSocio.Checked == true)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (string.IsNullOrEmpty(txtCodigo.Text))
                        return;

                    FornecedorNegocios objSocio = new FornecedorNegocios();
                    SociosColecao objRetorno = objSocio.ConsultarPorID(Convert.ToInt32(txtCodigo.Text));

                    txtCodigo.Text = "";
                    txtNome.Text = "";
                    if (objRetorno != null && objRetorno.Count > 0)
                    {
                        txtCodigo.Text = objRetorno.FirstOrDefault().IDpessoa.ToString();
                        txtNome.Text = objRetorno.FirstOrDefault().Nome;
                    }
                }

                else
                {
                    //nao aceita letras
                    if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
                    { e.Handled = true; }
                }

            }
            else if (RdbSocio.Checked == false)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (string.IsNullOrEmpty(txtCodigo.Text))
                        return;

                    FornecedorNegocio objSocio = new FornecedorNegocio();
                    FornecedorColecao objRetorno = objSocio.ConsultarPorCodigo(Convert.ToInt32(txtCodigo.Text));

                    txtCodigo.Text = "";
                    txtNome.Text = "";
                    if (objRetorno != null && objRetorno.Count > 0)
                    {
                        txtCodigo.Text = objRetorno.FirstOrDefault().idFornecedor.ToString();
                        txtNome.Text = objRetorno.FirstOrDefault().nome;
                    }
                }
                else
                {
                    //nao aceita letras
                    if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
                    { e.Handled = true; }
                }

            }

        }

        private void txtvalordocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e virgula");
            }
            
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente uma virgula");
            }
            
        }

        private void FrmContasPagar_Load(object sender, EventArgs e)
        {
            Util.ToolTipButton(btnSalvar, "Salvar");
            Util.ToolTipButton(btnSair, "Sair");
        }

        private void rdbpago_Click(object sender, EventArgs e)
        {
            dtpPagamento.Visible = true;
            lbDataPagamento.Visible = true;
        }

        private void rdbapagar_CheckedChanged(object sender, EventArgs e)
        {
            dtpPagamento.Visible = false;
            lbDataPagamento.Visible = false;
        }

        private void txtvalordocumento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

