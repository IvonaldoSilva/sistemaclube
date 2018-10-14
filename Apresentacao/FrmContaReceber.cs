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
    public partial class FrmContaReceber : Form
    {
        Socios socio;
        ContasReceberColecao arrReceber;
        public FrmContaReceber()
        {
            InitializeComponent();
            arrReceber = new ContasReceberColecao();
            BtnPagar.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnpequisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MatSocio.Text))
            {
                MessageBox.Show("Por favor,Matricula do Socio !!!");
                MatSocio.Focus();
                return;
            }
            if (string.IsNullOrEmpty(nomesocio.Text))
            {
                MessageBox.Show("Por favor,clicar Enter ou Selecinar no '+' ao lado !!!");
                MatSocio.Focus();
                nomesocio.Clear();
                return;
            }
            int codigoSocio = 0;
            if (!Int32.TryParse(MatSocio.Text, out codigoSocio) || codigoSocio <= 0)
            {
                MessageBox.Show("Código de matrícula inválido, por favor, informá-lo corretamente");
                return;
            }
            //Se estiver checado, será atribuido o valor 1, onde buscará os em aberto, se não, os fechado
            bool situacao = rdbaberto.Checked;

            ContasReceberNegocio objNegocio = new ContasReceberNegocio();

            arrReceber = objNegocio.ConsultarPorId(codigoSocio, situacao);
            dgvContasReceberMensalidade.DataSource = null;
            dgvContasReceberMensalidade.DataSource = arrReceber;
            dgvContasReceberMensalidade.Update();
            dgvContasReceberMensalidade.Refresh();

            if (rdbaberto.Checked)
            {
                BtnPagar.Enabled = true;
            }
            else
            {
                BtnPagar.Enabled = false ;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MatSocio.Text))
            {
                MessageBox.Show("Por favor,Matricula do Socio !!!");
                MatSocio.Focus();
                return;
            }


            if (rdbaberto.Checked == true)
            {
                MessageBox.Show("ATENÇAO!!!! O titulo nao esta pago favor alterar o situacao para pago");
                return;
            }
            if (rdbpago.Checked == true)
            {

                try
                {
                    ParametrosColecao parametroColecao = new ParametrosColecao();
                    Parametros parametros = new Parametros();
                    DataTable datatable = new DataTable();

                    return;

                }
                catch (Exception exeception)
                {
                    MessageBox.Show("nao foi posssivel fazer o pagamento" + exeception);
                }

            }

        }
        private void FrmContaReceber_Load(object sender, EventArgs e)
        {
            Util.ToolTipButton(btnpesquisar, "Pesquisar Contas a Receber");
            Util.ToolTipButton(BtnPagar, "Fazer Pagamento");
            Util.ToolTipButton(btnCancelar, "Sair");

            dgvContasReceberMensalidade.AutoGenerateColumns = false;
            dgvContasReceberMensalidade.ReadOnly = true;

        }

        private void MatSocio_Leave(object sender, EventArgs e)
        {

        }


        private void MatSocio_Validated(object sender, EventArgs e)
        {

        }

        private void MatSocio_Validating(object sender, CancelEventArgs e)
        {

        }

        private void maskedTextvalor_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {


        }
        private string ParametrosColecao(ParametrosColecao valorparamemtro)
        {

            return ParametrosNegocio();

        }

        private string ParametrosNegocio()
        {
            throw new NotImplementedException();
        }

        private void MatSocio_TextChanged(object sender, EventArgs e)
        {

        }

        private void Textvalor_Leave(object sender, EventArgs e)
        {


        }

        private void Textvalor_Click(object sender, EventArgs e)
        {

        }

        private void lblAdicionar(object sender, EventArgs e)
        {
            FrmSociosSelecionar selecionar = new FrmSociosSelecionar();
            DialogResult resultado = selecionar.ShowDialog();
            if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                MatSocio.Text = selecionar.SocioSelecionado.IDpessoa.ToString();
                nomesocio.Text = selecionar.SocioSelecionado.Nome;

                socio = selecionar.SocioSelecionado;
            }
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            int codigoSocio;
            if (!int.TryParse(MatSocio.Text, out codigoSocio) || codigoSocio <= 0)
            {
                MessageBox.Show("Por favor, verifique o código do sócio!!");
                return;
            }

            FrmItensPagamento pagamento = new FrmItensPagamento(codigoSocio, nomesocio.Text, arrReceber);
            pagamento.ShowDialog();
            pagamento.Dispose();
            btnpequisar_Click(null, null);
        }

        private void MatSocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrEmpty(MatSocio.Text))
                    return;

                FornecedorNegocios objSocio = new FornecedorNegocios();
                SociosColecao objRetorno = objSocio.ConsultarPorID(Convert.ToInt32(MatSocio.Text));

                MatSocio.Text = "";
                nomesocio.Text = "";
                if (objRetorno != null && objRetorno.Count > 0)
                {
                    MatSocio.Text = objRetorno.FirstOrDefault().IDpessoa.ToString();
                    nomesocio.Text = objRetorno.FirstOrDefault().Nome;

                    btnpesquisar.Focus();
                }
            }
            else 
                {
                //nao aceita letras
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
                { e.Handled = true; }
            }
            
        }

        private void rdbpago_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rdbaberto_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}

