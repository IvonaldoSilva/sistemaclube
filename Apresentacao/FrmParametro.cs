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
    public partial class FrmParametro : Form
    {
        public FrmParametro()
        {
            InitializeComponent();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtvalor.Text))
            {
                MessageBox.Show("Por favor preencher o valor da mensalidade");
                txtvalor.Focus();
                return;
            }
            
            Parametros parametros = new Parametros();
            parametros.valormensalidade = Convert.ToDecimal(txtvalor.Text);
           
            parametros.datacadastrado = dtpDataCadastro.Value;
            ParametrosNegocio parametrosNegocio = new ParametrosNegocio();
            string retorno = parametrosNegocio.Inserir(parametros);
            try
            {
                int idparametro = Convert.ToInt32(retorno);
                MessageBox.Show("Parametro  inserido com Sucesso  Codigo : " + idparametro.ToString());
                this.DialogResult = DialogResult.Yes;
            }
            catch
            {
                MessageBox.Show("nao foi possivel inserir detalhe:" + retorno, "atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.No;
            }
        }

        private void FrmParametro_Load(object sender, EventArgs e)
        {
            Util.ToolTipButton(btnSalvar, "Salvar");
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
    }
}
