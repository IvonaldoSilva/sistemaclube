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

namespace Apresentacao
{
    public partial class FrmRelatorio : Form
    {
        private readonly string _nomeRelatorio;
        private bool informarData;
        public FrmRelatorio(string nomeRelatorio)
        {
            InitializeComponent();
            gbData.Visible = false;
            _nomeRelatorio = nomeRelatorio;
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            dynamic arrDados = null;
            switch (_nomeRelatorio)
            {
                case "Socios":
                    {
                        FornecedorNegocios objNegocio = new FornecedorNegocios();
                        arrDados = objNegocio.ConsultarPorNome("");
                    }
                    break;
                case "Agendamento":
                    {
                        AgendamentoNegocios objNegocio = new AgendamentoNegocios();
                        arrDados = objNegocio.ConsultarPorData(dtData.Value);
                    }
                    break;
                case "Contas à Pagar":
                    {
                        ContasPagarNegocio objNegocio = new ContasPagarNegocio();
                        arrDados = objNegocio.ConsultarNome("", informarData ? dtData.Value : DateTime.MinValue);
                    }
                    break;
                case "Contas à Receber":
                    {
                        ContasReceberNegocio objNegocio = new ContasReceberNegocio();
                        arrDados = objNegocio.ConsultarPorId(0, rdAberto.Checked, informarData ? dtData.Value : DateTime.MinValue);
                    }
                    break;
                case "Patrimonio":
                    {
                        PatrimonioNegocio objNegocio = new PatrimonioNegocio();
                        arrDados = objNegocio.ConsultarPorNome("");
                    }
                    break;
                case "Dependente":
                    {

                    }
                    break;
                case "Movimento Caixa":
                    {
                        CaixaNegocio objNegocio = new CaixaNegocio();
                        arrDados = objNegocio.ConsultarPorData(dtData.Value);
                    }
                    break;
            }
            if (arrDados == null || arrDados.Count == 0)
            {
                MessageBox.Show("Não existem dados para o filtro informado!");
                return;
            }

            FrmViewer viewer = new FrmViewer(_nomeRelatorio, arrDados);
            viewer.ShowDialog();
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            switch (_nomeRelatorio)
            {
                case "Socios":
                    {
                        lbTitulo.Text = "RELATÓRIO DE SÓCIOS";
                    }
                    break;
                case "Contas à Pagar":
                    {
                        lbTitulo.Text = "RELATÓRIO DE CONTAS A PAGAR";
                        gbStatusContas.Visible = true;
                        rdAberto.Checked = true;
                        gbData.Visible = false;
                    }
                    break;
                case "Contas à Receber":
                    {
                        lbTitulo.Text = "RELATÓRIO DE CONTAS A RECEBER";
                        gbStatusContas.Visible = true;
                        rdAberto.Checked = true;
                        gbData.Visible = false;
                    }
                    break;
                case "Patrimonio":
                    {
                        lbTitulo.Text = "RELATÓRIO DE PATRIMÔNIO";
                    }
                    break;
                case "Movimento Caixa":
                    {
                        lbTitulo.Text = "RELATÓRIO DE MOVIMENTO DE CAIXA";
                        gbData.Visible = true;
                        gbStatusContas.Visible = false;
                    }
                    break;
                case "Agendamento":
                    {
                        lbTitulo.Text = "RELATÓRIO DE AGENDAMENTOS";
                        gbData.Visible = true;
                        gbStatusContas.Visible = false;
                    }
                    break;
            }
        }

        private void rdAberto_CheckedChanged(object sender, EventArgs e)
        {
            informarData = false;
            gbData.Visible = false;
        }

        private void rdBaixado_CheckedChanged(object sender, EventArgs e)
        {
            switch (_nomeRelatorio)
            {
                case "Socios":
                    {

                    }
                    break;
                case "Contas à Pagar":
                case "Contas à Receber":
                    {
                        gbData.Visible = true;
                        dtData.Value = DateTime.Now;
                        informarData = true;
                    }
                    break;
                case "Patrimonio":
                    {

                    }
                    break;
                case "Dependente":
                    {

                    }
                    break;
                case "MovimentoCaixa":
                    {

                    }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
