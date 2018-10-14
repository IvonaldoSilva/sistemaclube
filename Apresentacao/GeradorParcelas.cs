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

using Negocios;
using ObjetoTransferencia;

namespace Apresentacao
{
    public partial class GeradorParcelas : Form
    {
        SqlDataAdapter sda;
        DataTable dt;
        Socios socio;

        public List<ItensParcelas> listaParcelas { get; set; }

        public object IDpessoa { get; private set; }
        public GeradorParcelas()
        {
            InitializeComponent();
        }

        private void GeradorParcelas_Load(object sender, EventArgs e)
        {
            //Parametros parametros = new Parametros();
            ParametrosNegocio parametrosNegocio = new ParametrosNegocio();
            ParametrosColecao objRetorno = parametrosNegocio.carregarValorParamentro();

            if (objRetorno != null && objRetorno.Count > 0)
            {
                valorContrato.Text = objRetorno.FirstOrDefault().valormensalidade.ToString("#,##0.00");
            }
            else
                valorContrato.Text = "0,00";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btngerar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codSocio.Text))
            {
                MessageBox.Show("Por favor, preencha o Selecionar o Socio!");
                codSocio.Focus();
                return;
            }
            if (string.IsNullOrEmpty(nomeSocio.Text))
            {
                MessageBox.Show("Socio nao existe!!!  favor fazer nova pesquisa !");
                codSocio.Focus();
                return;
            }
            if (string.IsNullOrEmpty(valorContrato.Text))
            {
                MessageBox.Show("Por favor, Digite o valor do Contrato em Vigor!");
                valorContrato.Focus();
                return;
            }


            int qtidadeparcelas = 12;
            DateTime datavencimento = txtDataEmissao.Value;
            decimal contrato = Convert.ToDecimal(valorContrato.Text);

            int contador = 0;
            listaParcelas = new List<ItensParcelas>();
            for (int i = 0; i < qtidadeparcelas; i++)
            {
                contador++;

                var parcela = new ItensParcelas();
                parcela.IDpessoas = Convert.ToInt32(codSocio.Text);
                parcela.nome = Convert.ToString(nomeSocio.Text);
                parcela.valormensalidade = contrato / qtidadeparcelas;
                parcela.numeroparcelas = contador;

                parcela.vencimento = datavencimento.AddMonths(contador);
                listaParcelas.Add(parcela);
            }
            DgVparcelas.AutoGenerateColumns = false;
            DgVparcelas.DataSource = null;
            DgVparcelas.DataSource = listaParcelas;
            MessageBox.Show(" Parcelas  foi   Geradas com Sucesso !!! para efetivar favor clicar em Salvar");

        }


        private void Label4_Click(object sender, EventArgs e)
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

        private void valorContrato_TextChanged(object sender, EventArgs e)
        {

        }


        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codSocio.Text))
            {
                MessageBox.Show("Por Favor Preencher  Socio!!! ");
                codSocio.Focus();
                return;
            }
            try
            {
                if (listaParcelas == null || listaParcelas.Count == 0)
                {
                    MessageBox.Show("Não existem parcelas selecionadas!");
                    return;
                }

                if (MessageBox.Show("Deseja Salvar?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                Contrato objContrato = new Contrato();
                objContrato.data = Convert.ToDateTime(txtDataEmissao.Text);
                objContrato.idcontrato = 0;
                objContrato.IDpessoa = Convert.ToInt32(codSocio.Text);
                objContrato.valor = Convert.ToDecimal(valorContrato.Text);
                GeradorParcelasNegocios objGera = new GeradorParcelasNegocios();
                objGera.GravarContrato(objContrato, listaParcelas);

                FrmViewer viewer = new FrmViewer("Contrato", nomeSocio.Text);
                viewer.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar a mensalidade  . detalhe  " + ex.Message);
            }
        }

        private void GeradorParcelas_Click(object sender, EventArgs e)
        {

        }

        private void codSocio_Leave(object sender, EventArgs e)
        {


        }

        private void codSocio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}