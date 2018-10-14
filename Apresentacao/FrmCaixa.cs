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

    public partial class FrmCaixa : Form
    {
        Socios socio;
        Fornecedor fornecedor;
        AcaoNaTela acaoNaTelaSelecionada;
        public FrmCaixa(AcaoNaTela acaoNaTela, Caixa caixa)
        {
            InitializeComponent();
            this.acaoNaTelaSelecionada = acaoNaTela;
            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Movimento de Caixa";

            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar o Movimento de Caixa";
                txtidcaixa.Text = caixa.idcaixa.ToString();
                if (caixa.movcaixa == true)
                {
                    rdbentrada.Checked = true;

                }
                else if (caixa.movcaixa == false)
                {
                    rdbSaida.Checked = true;
                }
                dtpdata.Text = caixa.dataentrada.ToString();
                cmbnumerario.Text = caixa.tiponumerario;
                if(caixa.tipopessoa == "P.Fisica")
                {
                    rdbfisica.Checked = true;
                }
                else if(caixa.tipopessoa == "P.Juridica")
                {
                    rdbjuridica.Checked = true;
                }
                codSocio.Text = caixa.idpessoa.ToString();
                nomeSocio.Text = caixa.nomepessoa;
                mktdatemissao.Text = caixa.dataemissao.ToString();
                txtvalor.Text = caixa.valor.ToString();
                cmbtipodocumento.Text = caixa.tipodocumento;
                
        }

                   



            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbAdicionar_Click(object sender, EventArgs e)
        {
            if (rdbfisica.Checked == true)
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
            else if (rdbjuridica.Checked == true)
            {
                FrmFornecedorSelecionar FornecedorSelecionar = new FrmFornecedorSelecionar();
                DialogResult resultado1 = FornecedorSelecionar.ShowDialog();
                if (resultado1 == System.Windows.Forms.DialogResult.OK)
                {
                    codSocio.Text = FornecedorSelecionar.FornecedorSelecionado.idFornecedor.ToString();
                    nomeSocio.Text = FornecedorSelecionar.FornecedorSelecionado.nome;
                    fornecedor = FornecedorSelecionar.FornecedorSelecionado;
                    return;
                }

            }
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbnumerario.Text))
            {
                MessageBox.Show("Por favor, preencha o tipo de numerario!!");
                cmbnumerario.Focus();
                return;
            }
            if (string.IsNullOrEmpty(codSocio.Text))
            {
                MessageBox.Show("Por favor, preencha o campo Codigo ou clica no botão + ao lado !");
                codSocio.Focus();
                return;
            }
            if (string.IsNullOrEmpty(mktdatemissao.Text))
            {
                MessageBox.Show("Por favor, preencha a data emissao!");
                mktdatemissao.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtvalor.Text))
            {
                MessageBox.Show("Por favor, preencha o campo valor!");
                txtvalor.Focus();
                return;
            }
            if (string.IsNullOrEmpty(mktdatemissao.Text))
            {
                MessageBox.Show("Por favor, preencha o campo Data emissao!");
                mktdatemissao.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cmbtipodocumento.Text))
            {
                MessageBox.Show("Por favor, preencha o campo tipo de documento!");
                cmbtipodocumento.Focus();
                return;
            }
            if (acaoNaTelaSelecionada == AcaoNaTela.Inserir)
            {
                Caixa caixa = new Caixa();
                if (rdbentrada.Checked == true)
                    caixa.movcaixa = true;
                else
                    caixa.movcaixa = false;
                caixa.dataentrada = Convert.ToDateTime(dtpdata.Value);
                caixa.tiponumerario = Convert.ToString(cmbnumerario.Text);
                if (rdbfisica.Checked == true)
                    caixa.tipopessoa = "P.Fisica";
                else
                    caixa.tipopessoa = "P.Juridica";
                caixa.idpessoa = Convert.ToInt32(codSocio.Text);
                caixa.nomepessoa = Convert.ToString(nomeSocio.Text);
                caixa.dataemissao = Convert.ToDateTime(mktdatemissao.Text);
                caixa.valor = Convert.ToDecimal(txtvalor.Text);
                caixa.tipodocumento = Convert.ToString(cmbtipodocumento.Text);
                CaixaNegocio caixaNegocio = new CaixaNegocio();
                string retorno = caixaNegocio.Inserir(caixa);
                try
                {
                    int idcaixa = Convert.ToInt32(retorno);
                    MessageBox.Show("Mov. de caixa inserido com Sucesso  !!! : " + idcaixa.ToString());
                    this.DialogResult = DialogResult.Yes;
                    return;
                }
                //de errado devolve mensagem de erro.
                catch
                {
                    MessageBox.Show("nao foi possivel inserir detalhe:" + retorno, "Atencao !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }
            else if (acaoNaTelaSelecionada == AcaoNaTela.Alterar)
            {
                Caixa caixa = new Caixa();
                caixa.idcaixa= Convert.ToInt32(txtidcaixa.Text);
                if (rdbentrada.Checked == true)
                    caixa.movcaixa = true;
                else
                    caixa.movcaixa = false;
                caixa.dataentrada = Convert.ToDateTime(dtpdata.Value);
                caixa.tiponumerario = Convert.ToString(cmbnumerario.Text);
                if (rdbfisica.Checked == true)
                    caixa.tipopessoa = "P.Fisica";
                else
                    caixa.tipopessoa = "P.Juridica";
                caixa.idpessoa = Convert.ToInt32(codSocio.Text);
                caixa.nomepessoa = Convert.ToString(nomeSocio.Text);
                caixa.dataemissao = Convert.ToDateTime(mktdatemissao.Text);
                caixa.valor = Convert.ToDecimal(txtvalor.Text);
                caixa.tipodocumento = Convert.ToString(cmbtipodocumento.Text);
                CaixaNegocio caixaNegocio = new CaixaNegocio();
                string retorno = caixaNegocio.Alterar(caixa);
                try
                {
                    int idcaixa = Convert.ToInt32(retorno);
                    MessageBox.Show("Mov. de caixa Alterado com Sucesso  !!! : " + idcaixa.ToString());
                    this.DialogResult = DialogResult.Yes;
                    return;
                }
                //de errado devolve mensagem de erro.
                catch
                {
                    MessageBox.Show("nao foi possivel inserir detalhe:" + retorno, "Atencao !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }

            }

            
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
            
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rdbfisica.Checked == true)
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
            else if(rdbfisica.Checked==false)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (string.IsNullOrEmpty(codSocio.Text))
                        return;

                    FornecedorNegocio objSocio = new FornecedorNegocio();
                    FornecedorColecao objRetorno = objSocio.ConsultarPorCodigo(Convert.ToInt32(codSocio.Text));

                    codSocio.Text = "";
                    nomeSocio.Text = "";
                    if (objRetorno != null && objRetorno.Count > 0)
                    {
                        codSocio.Text = objRetorno.FirstOrDefault().idFornecedor.ToString();
                        nomeSocio.Text = objRetorno.FirstOrDefault().nome;
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

        private void codSocio_Leave(object sender, EventArgs e)
        {
          
        }

        private void FrmCaixa_Load(object sender, EventArgs e)
        {
            Util.ToolTipButton(btnsalvar, "Salvar");
            Util.ToolTipButton(BtnCancelar, "Sair");
        }

        private void txtvalor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void mktdatemissao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        
        private void mktdatemissao_Leave(object sender, EventArgs e)
        {
           
        }

        private void mktdatemissao_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                MessageBox.Show("Data inválida");
                mktdatemissao.Focus();
                return;
            }
        }
    }
}
