using Negocios;
using ObjetoTransferencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmItensPagamento : Form
    {
        private int codigoSocio;
        private string nomeSocio;
        private ContasReceberColecao arrReceber;
        public FrmItensPagamento(int codigoSocioParametro, string nomeSocioParametro, ContasReceberColecao arrReceber)
        {
            InitializeComponent();
            codigoSocio = codigoSocioParametro;
            nomeSocio = nomeSocioParametro;
            this.arrReceber = arrReceber;

            if(arrReceber == null || !arrReceber.Any())
            {
                MessageBox.Show("Não existem contas a serem pagas, por favor, verifique!");
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Salvar?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            int qtdeParcelas = 0;
            if (!int.TryParse(txtQtdeParcelas.Text, out qtdeParcelas) || qtdeParcelas <= 0)
            {
                MessageBox.Show("Quantidade de parcelas inválidas, por favor, verifique!");
                return;
            }
            if (cboPagamento.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma forma de pagamento!!");
                return;
            }
            DateTime dataPagamento;
            if (!DateTime.TryParse(dtpPagamento.Text, out dataPagamento) || dataPagamento == DateTime.MinValue)
            {
                MessageBox.Show("Data de pagamento inválida!");
                return;
            }
            if (qtdeParcelas > arrReceber.Count)
            {
                MessageBox.Show($"Foram selecionadas {qtdeParcelas} parcelas, porém só existem {arrReceber.Count} a serem pagas!");
                return;
            }
            try
            {
                ContasReceberNegocio objNegocio = new ContasReceberNegocio();
                objNegocio.BaixarReceber(qtdeParcelas, dataPagamento, codigoSocio, cboPagamento.Text);

                //Baixar agendamentos
                foreach (var item in arrReceber)
                {
                    if (item.idAgendamento > 0)
                    {
                        new AgendamentoNegocios().BaixarAgendamento(item.idAgendamento);
                    }
                }

                MessageBox.Show("Baixa efetuada com sucesso!");

                if (MessageBox.Show("Deseja imprimir recibo?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    string detalheRecibo = string.Empty;
                    var pagas = arrReceber.OrderBy(r => r.datavencimento).Take(qtdeParcelas);
                    decimal valorPago = 0;
                    foreach (var item in pagas)
                    {
                        detalheRecibo += $"Parcela {item.parcela} com vencimento {item.datavencimento.ToString("dd/MM/yyyy")}{Environment.NewLine}";
                        valorPago += item.valorpago;
                    }
                    
                    DadosRelatorioRecibo objRecibo = new DadosRelatorioRecibo()
                    {
                        cli_nome  = nomeSocio,
                        qtdeParcelas = qtdeParcelas,
                        rec_valorpago = valorPago,
                        strDetalheRecibo = detalheRecibo
                    };
                    objRecibo.strValorExtenso = ValorExtenso.toExtenso(objRecibo.rec_valorpago);
                    List<DadosRelatorioRecibo> arr = new List<DadosRelatorioRecibo>() { objRecibo };

                    FrmViewer viewer = new FrmViewer("Recibo", arr);
                    viewer.ShowDialog();
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao efetuar baixa, por favor tente novamente. " + ex.Message);
            }
        }

        private void FrmItensPagamento_Load(object sender, EventArgs e)
        {
            Util.ToolTipButton(btnSalvar, "Salvar Pagamento");
            Util.ToolTipButton(btnCancelar, "Sair");
        }
    }
}
