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
    public partial class frmCadastrarFornecedor : Form
    {
        AcaoNaTela acaoNaTelaSelecionada;
        public frmCadastrarFornecedor(AcaoNaTela acaoNaTela, Fornecedor fornecedor)
        {
            InitializeComponent();
            this.acaoNaTelaSelecionada = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Fornecedor";
            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar Fornecedor";
                txtCodigo.Text = fornecedor.idFornecedor.ToString();
                txtnome.Text = fornecedor.nome;
                mtbCnpj.Text = fornecedor.cnpj;
                txtendereco.Text = fornecedor.endereco;
                txtnumero.Text = fornecedor.numero;
                txtcidade.Text = fornecedor.cidade;
                mtbtelefone.Text = fornecedor.telefone;
                
            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                this.Text = "Consultar Fornecedor";
                txtCodigo.Text = fornecedor.idFornecedor.ToString();
                txtnome.Text = fornecedor.nome;
                mtbCnpj.Text = fornecedor.cnpj;
                txtendereco.Text = fornecedor.endereco;
                txtnumero.Text = fornecedor.numero;
                txtcidade.Text = fornecedor.cidade;
                mtbtelefone.Text = fornecedor.telefone;

            }

        }

        private void frmCadastrarFornecedor_Load(object sender, EventArgs e)
        {

            Util.ToolTipButton(btnSalvar, "Salvar");
            Util.ToolTipButton(btnCancelar, "Sair");

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void maskedTextBox2_Leave(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtbCnpj_Leave(object sender, EventArgs e)
        {
            ValidaCnpj validaCnpj = new ValidaCnpj();
            if (!validaCnpj.validarCNPJ(mtbCnpj.Text.Trim()))
            {
                MessageBox.Show("Cnpj invalido!!!");
                
                return;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnome.Text))
            {
                MessageBox.Show("Por favor, preencha o campo Razao Social!!!");
                txtnome.Focus();
                return;
            }
            if (string.IsNullOrEmpty(mtbCnpj.Text))
            {
                MessageBox.Show("Por favor, preencha o campo CNPJ!!");
                mtbCnpj.Focus();
                return;
            }
            ValidaCnpj validarCnpj = new ValidaCnpj();
            if(!validarCnpj.validarCNPJ(mtbCnpj.Text.Trim()))
            {
                MessageBox.Show("CNPJ E INVALIDO!! FAVOR VERIFICAR");
                 return;
            }
            if (acaoNaTelaSelecionada == AcaoNaTela.Inserir)
            {
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.nome = txtnome.Text.ToUpper();
                fornecedor.cnpj = mtbCnpj.Text;
                fornecedor.endereco = txtendereco.Text.ToUpper();
                fornecedor.numero = txtnumero.Text;
                fornecedor.cidade = txtcidade.Text.ToUpper();
                fornecedor.telefone = mtbtelefone.Text;
                FornecedorNegocio fornecedorNegocio = new FornecedorNegocio();
                string retorno = fornecedorNegocio.Inserir(fornecedor);
                try
                {
                    int IdFornecedor = Convert.ToInt32(retorno);
                    MessageBox.Show("Fornecedor inserido com Sucesso Codigo : "+ IdFornecedor.ToString());
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("nao foi possivel inserir detalhe:" + retorno, "atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }
            else if (acaoNaTelaSelecionada == AcaoNaTela.Alterar)
            {
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.idFornecedor = Convert.ToInt32(txtCodigo.Text);
                fornecedor.nome = txtnome.Text.ToUpper();
                fornecedor.cnpj = mtbCnpj.Text;
                fornecedor.endereco = txtendereco.Text.ToUpper();
                fornecedor.numero = txtnumero.Text;
                fornecedor.cidade = txtcidade.Text.ToUpper();
                fornecedor.telefone = mtbtelefone.Text;
                FornecedorNegocio fornecedorNegocio = new FornecedorNegocio();
                string retorno = fornecedorNegocio.Alterar(fornecedor);
                try
                {
                    int IdFornecedor = Convert.ToInt32(retorno);
                    MessageBox.Show("Fornecedor   inserido com Sucesso Codigo : " + IdFornecedor.ToString());
                    this.DialogResult = DialogResult.Yes;
                    
                }
                catch
                {
                    MessageBox.Show("nao foi possivel inserir detalhe:" + retorno, "atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;

                }


            }
        }

        private void dataGridViewFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void atualizarGrid()
        {
          
        }

        private void Btnpesquisar_Click(object sender, EventArgs e)
        {
            atualizarGrid();

        }
        private void LimparCampo()
        {
            txtnome.Clear();
            mtbCnpj.Clear();
            txtendereco.Clear();
            txtnumero.Clear();
            txtcidade.Clear();
            mtbtelefone.Clear();
            txtnome.Focus();

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
           
        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //nao aceita letras
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            { e.Handled = true; }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
