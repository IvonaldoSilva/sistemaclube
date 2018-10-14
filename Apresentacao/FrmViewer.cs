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
    public partial class FrmViewer : Form
    {
        public object arrRelatorio { get; set; }
        public string nomeRelatorio;
        public FrmViewer(string nomeRelatorio, object arrDados = null)
        {
            InitializeComponent();
            if (arrDados != null)
                arrRelatorio = arrDados;
            this.nomeRelatorio = nomeRelatorio;
        }

        private void FrmViewer_Load(object sender, EventArgs e)
        {

            GerarRelatorio(nomeRelatorio);
            rptViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

            rptViewer.RefreshReport();

        }

        public void GerarRelatorio(string nomeRelatorio)
        {
            rptViewer.LocalReport.DataSources.Clear();
            switch (nomeRelatorio)
            {
                case "Socios":
                    {
                        rptViewer.LocalReport.DataSources.Add(
                            new Microsoft.Reporting.WinForms.ReportDataSource("dsSocios", (SociosColecao)arrRelatorio));

                        rptViewer.LocalReport.ReportPath = @".\Relatorios\relSocios.rdlc";
                    }
                    break;
                case "Contas à Pagar":
                    {
                        rptViewer.LocalReport.DataSources.Add(
                            new Microsoft.Reporting.WinForms.ReportDataSource("dsPagar", (ContasPagarColecao)arrRelatorio));

                        rptViewer.LocalReport.ReportPath = @".\Relatorios\relContasPagar.rdlc";
                    }
                    break;
                case "Contas à Receber":
                    {
                        rptViewer.LocalReport.DataSources.Add(
                            new Microsoft.Reporting.WinForms.ReportDataSource("dsReceber", (ContasReceberColecao)arrRelatorio));

                        rptViewer.LocalReport.ReportPath = @".\Relatorios\relContasReceber.rdlc";
                    }
                    break;
                case "Patrimonio":
                    {
                        rptViewer.LocalReport.DataSources.Add(
                            new Microsoft.Reporting.WinForms.ReportDataSource("dsPatrimonio", (PatrimonioColecao)arrRelatorio));

                        rptViewer.LocalReport.ReportPath = @".\Relatorios\relPatrimonio.rdlc";
                    }
                    break;
                case "Dependente":
                    {

                    }
                    break;
                case "Movimento Caixa":
                    {
                        rptViewer.LocalReport.DataSources.Add(
                           new Microsoft.Reporting.WinForms.ReportDataSource("dsCaixa", (CaixaColecao)arrRelatorio));

                        rptViewer.LocalReport.ReportPath = @".\Relatorios\relCaixa.rdlc";

                    }
                    break;
                case "Recibo":
                    {
                        rptViewer.LocalReport.DataSources.Add(
                           new Microsoft.Reporting.WinForms.ReportDataSource("dsReciboPagamento", (List<DadosRelatorioRecibo>)arrRelatorio));

                        rptViewer.LocalReport.ReportPath = @".\Relatorios\relReciboPagamento.rdlc";
                    }
                    break;
                case "Agendamento":
                    {
                        rptViewer.LocalReport.DataSources.Add(
                           new Microsoft.Reporting.WinForms.ReportDataSource("dsAgendamento", (AgendamentoColecao)arrRelatorio));

                        rptViewer.LocalReport.ReportPath = @".\Relatorios\relAgendamento.rdlc";
                    }
                    break;
                case "Contrato":
                    {

                        rptViewer.LocalReport.ReportPath = @".\Relatorios\relContrato.rdlc";

                        rptViewer.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("nomeSocio", (string)arrRelatorio));

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
