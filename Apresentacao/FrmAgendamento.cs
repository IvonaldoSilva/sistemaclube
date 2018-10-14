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
    public partial class FrmAgendamento : Form
    {
        Socios socio;
        AcaoNaTela acaoNaTelaSelecionada;
        public FrmAgendamento(AcaoNaTela acaoNaTela, Agendamento agendamento)
        {
            InitializeComponent();
            this.acaoNaTelaSelecionada = acaoNaTela;
            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir um Agendamento";

            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                this.Text = "Alterar Agendamento";
                txtCod.Text = agendamento.idagendamento.ToString();
                dtpdata.Value = agendamento.data;
                cmbinicio.Text = agendamento.horainicio;
                cmbfinal.Text = agendamento.horafinal;
                txtCodigo.Text = agendamento.IDpessoa.ToString();
                txtnome.Text = agendamento.nome;
                cmblocal.Text = agendamento.local;
                txtvalor.Text = agendamento.valor.ToString();
                if (agendamento.situacao == true)
                {
                    rdbapagar.Checked = true;
                }
                else if(agendamento.situacao==false)
                {
                    rdbpago.Checked = true;
                }
                rdbpago.Enabled = false;
                rdbapagar.Enabled = false;

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbinicio.Text))
            {
                MessageBox.Show("Por favor, hora inicial do Evento!");
                cmbinicio.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(cmbfinal.Text))
            {
                MessageBox.Show("Por favor, hora Final do Evento!");
                cmbfinal.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Por favor, Digite ou pesquise o Codigo do Socio!");
                txtCodigo.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(cmblocal.Text))
            {
                MessageBox.Show("Por favor, Local para Agendamento!");
                cmblocal.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtvalor.Text))
            {
                MessageBox.Show("Por favor, Valor do Aluguel!");
                txtvalor.Focus();
                return;
            }


            if (acaoNaTelaSelecionada == AcaoNaTela.Inserir)
            {

                Agendamento agendamento = new Agendamento();
                agendamento.data = dtpdata.Value;
                agendamento.horainicio = cmbinicio.Text;
                agendamento.horafinal = cmbfinal.Text;
                agendamento.IDpessoa = Convert.ToInt32(txtCodigo.Text);
                agendamento.nome = txtnome.Text.ToUpper();
                agendamento.local = cmblocal.Text.ToUpper();
                agendamento.valor = Convert.ToDecimal(txtvalor.Text);
                if (rdbapagar.Checked == true)
                    agendamento.situacao = true;
                else if (rdbpago.Checked == true)
                    agendamento.situacao = false;


                AgendamentoNegocios agendamentoNegocios = new AgendamentoNegocios();
                string retorno = agendamentoNegocios.Inserir(agendamento);

                //tentar converter para inteiro
                //se der certo devolve o codigo do socio
                //de errado devolve mensagem de erro.
                try
                {
                    int idagendamento = Convert.ToInt32(retorno);
                    MessageBox.Show(agendamento.local + "   Agendado com sucesso : " + idagendamento.ToString());
                    this.DialogResult = DialogResult.Yes;
                    return;
                }
                catch
                {
                    MessageBox.Show("nao foi possivel inserir detalhe:" + retorno, "atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                    return;
                }
            }
            else if (acaoNaTelaSelecionada == AcaoNaTela.Alterar)
            {
                Agendamento agendamento = new Agendamento();
                agendamento.idagendamento = Convert.ToInt32(txtCod.Text);
                agendamento.data = dtpdata.Value;
                agendamento.horainicio = cmbinicio.Text;
                agendamento.horafinal = cmbfinal.Text;
                agendamento.IDpessoa = Convert.ToInt32(txtCodigo.Text);
                agendamento.nome = txtnome.Text.ToUpper();
                agendamento.local = cmblocal.Text.ToUpper();
                agendamento.valor = Convert.ToDecimal(txtvalor.Text);
                if (agendamento.situacao == true)
                    rdbapagar.Checked =true;
                else if (agendamento.situacao==false)
                        rdbpago.Checked=true;

                AgendamentoNegocios agendamentoNegocios = new AgendamentoNegocios();
                string retorno = agendamentoNegocios.Alterar(agendamento);

                //tentar converter para inteiro
                //se der certo devolve o codigo do socio
                //de errado devolve mensagem de erro.
                try
                {
                    int idagendamento = Convert.ToInt32(retorno);
                    MessageBox.Show("Local >> " + agendamento.local + "  Alterado  com sucesso : " + idagendamento.ToString());
                    this.DialogResult = DialogResult.Yes;
                    return;
                }
                catch
                {
                    MessageBox.Show("nao foi possivel inserir detalhe:" + retorno, "atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                    return;
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAgendamento_Load(object sender, EventArgs e)
        {
            Util.ToolTipButton(btnSalvar, "Salvar");
            Util.ToolTipButton(btnCancelar, "Sair");
            rdbapagar.Enabled = false;
            rdbpago.Enabled = false;
        }

        private void lbAdicionar_Click(object sender, EventArgs e)
        {
            FrmSociosSelecionar socioSelecionar = new FrmSociosSelecionar();
            DialogResult resultado = socioSelecionar.ShowDialog();
            if (resultado == System.Windows.Forms.DialogResult.OK)
            {
                txtCodigo.Text = socioSelecionar.SocioSelecionado.IDpessoa.ToString();
                txtnome.Text = socioSelecionar.SocioSelecionado.Nome;
                socio = socioSelecionar.SocioSelecionado;
                return;

            }
        }

        private void dtpdata_ValueChanged(object sender, EventArgs e)
        {
            var dtpck = sender as DateTimePicker;

            if (dtpck.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Não é possível fazer um agendamento menor que hoje!");
                dtpck.Value = DateTime.Now;
                return;
            }

            AgendamentoNegocios objNegocio = new AgendamentoNegocios();
            var retorno = objNegocio.ConsultarPorData(dtpck.Value.Date);
            string mensagem = "Atenção! Existem agendamentos para a data selecionada! " + Environment.NewLine + Environment.NewLine;
            foreach (var item in retorno)
            {
                mensagem += $"Responsável: {item.nome}, Local: {item.local}, Data: {item.data.ToString("dd/MM/yyyy")}, Inicio: {item.horainicio}, Fim: {item.horafinal}. {Environment.NewLine}{Environment.NewLine}";
            }
            if (retorno.Any())
            {
                MessageBox.Show(mensagem, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtCodigo.Text))
                    return;

                FornecedorNegocios objSocio = new FornecedorNegocios();
                SociosColecao objRetorno = objSocio.ConsultarPorID(Convert.ToInt32(txtCodigo.Text));

                txtCodigo.Text = "";
                txtnome.Text = "";
                if (objRetorno != null && objRetorno.Count > 0)
                {
                    txtCodigo.Text = objRetorno.FirstOrDefault().IDpessoa.ToString();
                    txtnome.Text = objRetorno.FirstOrDefault().Nome;

                    txtCodigo.Focus();
                }
            }
            else
            {
                //nao aceita letras
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
                { e.Handled = true; }
            }
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
