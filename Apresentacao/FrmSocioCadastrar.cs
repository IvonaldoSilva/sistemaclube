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
    public partial class FrmSocioCadastrar : Form
    {
        //construtor
        Socios socios;
        AcaoNaTela acaoNaTelaSelecionada;
        public FrmSocioCadastrar(AcaoNaTela acaoNaTela, Socios socios)
        {

            InitializeComponent();
            this.acaoNaTelaSelecionada = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Socios";
                
            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar Socios";
                txtCodigo.Text = socios.IDpessoa.ToString();
                txtnome.Text = socios.Nome;
                dTPnascimento.Value = socios.datanasc;
                txtcpf.Text = socios.cpf;
                txtrg.Text = socios.rg;
                cmbsexo.Text = socios.sexo;
                txtendereco.Text = socios.endereco;
                txtnumero.Text = socios.numero;
                txtbairro.Text = socios.bairro;
                txtcidade.Text = socios.cidade;
                txtcep.Text = socios.cep;
                cmbestado.Text = socios.estado;
                dtpadmissao.Value = socios.admissao;
                txtemail.Text = socios.email;
                mtbtelefone.Text = socios.telefone;


            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                this.Text = "Consultar Socios";
                txtCodigo.Text = socios.IDpessoa.ToString();
                txtnome.Text = socios.Nome;
                dTPnascimento.Value = socios.datanasc;
                txtcpf.Text = socios.cpf;
                txtrg.Text = socios.rg;
                cmbsexo.Text = socios.sexo;
                txtendereco.Text = socios.endereco;
                txtnumero.Text = socios.numero;
                txtbairro.Text = socios.bairro;
                txtcidade.Text = socios.cidade;
                txtcep.Text = socios.cep;
                cmbestado.Text = socios.estado;
                dtpadmissao.Value = socios.admissao;
                txtemail.Text = socios.email;
                mtbtelefone.Text = socios.telefone;

                //desabelidatar os campos da tela
                pnldados.Enabled = false;
                pnlbotoes.TabStop = true;
                btnSalvar.Visible = false;
               

            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
        if (string.IsNullOrEmpty(txtnome.Text))
            {
                MessageBox.Show("Por favor, preencha o campo nome!");
                txtnome.Focus();
                return;
            }
         else if (string.IsNullOrEmpty(txtrg.Text))
            {
                MessageBox.Show("Por favor, preencha o campo RG!");
                txtrg.Focus();
                return;
            }
         else if (string.IsNullOrEmpty(txtendereco.Text))
            {
                MessageBox.Show("Por favor, preencha o campo Endereco!");
                txtendereco.Focus();
                return;
            }
        else if (string.IsNullOrEmpty(txtcidade.Text))
            {
                MessageBox.Show("Por favor, preencha o campo Cidade!");
                txtcidade.Focus();
                return;
            }
        else if (string.IsNullOrEmpty(cmbsexo.Text))
            {
                MessageBox.Show("Por favor, preencha o campo Sexo!");
                cmbsexo.Focus();
                return;
            }
        else if (string.IsNullOrEmpty(txtbairro.Text))
            {
                MessageBox.Show("Por favor, preencha o campo bairro!");
                txtbairro.Focus();
                return;
            }
        else if (string.IsNullOrEmpty(txtcep.Text))
            {
                MessageBox.Show("Por favor, preencha o campo Cep!");
                txtcep.Focus();
                return;
            }
        else if (string.IsNullOrEmpty(txtemail.Text))
            {
                MessageBox.Show("Por favor, preencha o campo Email!");
                txtemail.Focus();
                return;
            }
            ValidarCpfs validarCpfs = new ValidarCpfs();
            if (!validarCpfs.ValidaCPF(txtcpf.Text.Trim()))
            {
                MessageBox.Show("Cpf invalido!!!");
                return;
            }
             validaCep cep = new validaCep();
             if (!cep.ValidaCep(txtcep.Text.Trim()))
             {
                 MessageBox.Show("Cep é Invalido!!!!");
                 return;
             }
            //verificar se é insercao ou alteracao
            if (acaoNaTelaSelecionada == AcaoNaTela.Inserir)
            {

                Socios socios = new Socios();
                socios.Nome = txtnome.Text.ToUpper();
                socios.datanasc = dTPnascimento.Value;
                socios.cpf = txtcpf.Text;
                socios.rg = txtrg.Text.ToUpper();
                socios.sexo = cmbsexo.Text.ToUpper();
                socios.endereco = txtendereco.Text.ToUpper();
                socios.numero = txtnumero.Text;
                socios.bairro = txtbairro.Text.ToUpper();
                socios.cidade = txtcidade.Text.ToUpper();
                socios.cep = txtcep.Text;
                socios.estado = cmbestado.Text.ToUpper();
                socios.admissao = dtpadmissao.Value;
                socios.email = txtemail.Text;
                socios.telefone = mtbtelefone.Text;
                FornecedorNegocios sociosNegocios = new FornecedorNegocios();
                string retorno = sociosNegocios.Inserir(socios);

                //tentar converter para inteiro
                //se der certo devolve o codigo do socio
                //de errado devolve mensagem de erro.
                try
                {
                    int IDpessoa = Convert.ToInt32(retorno);
                    MessageBox.Show("Socio inserido com Sucesso Codigo : " + IDpessoa.ToString());
                    this.DialogResult = DialogResult.Yes;
                    return;
                }
                catch
                {
                    MessageBox.Show("nao foi possivel inserir detalhe:" + retorno, "atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
                
            }
            else if (acaoNaTelaSelecionada == AcaoNaTela.Alterar)
            {
                Socios socios = new Socios();
                socios.IDpessoa = Convert.ToInt32(txtCodigo.Text);
                socios.Nome = txtnome.Text.ToUpper();
                socios.datanasc = dTPnascimento.Value;
                socios.cpf = txtcpf.Text;
                socios.rg = txtrg.Text.ToUpper();
                socios.sexo = cmbsexo.Text.ToUpper();
                socios.endereco = txtendereco.Text.ToUpper();
                socios.numero = txtnumero.Text;
                socios.bairro = txtbairro.Text.ToUpper();
                socios.cidade = txtcidade.Text.ToUpper();
                socios.cep = txtcep.Text;
                socios.estado = cmbestado.Text.ToUpper();
                socios.admissao = dtpadmissao.Value;
                socios.email = txtemail.Text;
                socios.telefone = mtbtelefone.Text;
                FornecedorNegocios sociosNegocios = new FornecedorNegocios();
                string retorno = sociosNegocios.Alterar(socios);

                //tentar converter para inteiro
                //se der certo devolve o codigo do socio
                //de errado devolve mensagem de erro.
                try
                {
                    int IDpessoa = Convert.ToInt32(retorno);
                    MessageBox.Show("Socio Alterado com Sucesso Codigo : " + IDpessoa.ToString());
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("nao foi possivel Alterar detalhe:" + retorno, "atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }




        }

        private void txtcpf_Leave(object sender, EventArgs e)
        {
            ValidarCpfs validarCpfs = new ValidarCpfs();
            if (!validarCpfs.ValidaCPF(txtcpf.Text.Trim()))
            {
                MessageBox.Show("Cpf invalido!!!");
                return;
            }

        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            ValidarEmail validarEmail = new ValidarEmail();
            if (!validarEmail.Validaremail(txtemail.Text.Trim()))
            {
                MessageBox.Show("Email Invalido!!!");

                return;
            }
        }

        private void txtcep_Leave(object sender, EventArgs e)
        {
            validaCep cep = new validaCep();
            if(!cep.ValidaCep(txtcep.Text.Trim()))
            {
                MessageBox.Show("Cep é Invalido!!!!");
                return;
            }
        }

        private void txtrg_KeyPress(object sender, KeyPressEventArgs e)
        {
            //nao aceita letras
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            { e.Handled = true; }
        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //nao aceita letras
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            { e.Handled = true; }
        }

        private void txtcep_KeyPress(object sender, KeyPressEventArgs e)
        {
            //nao aceita letras
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            { e.Handled = true; }
        }

        private void BtnGerarParcelas_Click(object sender, EventArgs e)
        {

        }

        private void FrmSocioCadastrar_Load(object sender, EventArgs e)
        {
            Util.ToolTipButton(btnSalvar, "Salvar");
            Util.ToolTipButton(btnCancelar, "Sair");


        }
    }


}

