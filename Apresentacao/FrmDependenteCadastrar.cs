using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

using ObjetoTransferencia;
using Negocios;


namespace Apresentacao
{
    public partial class FrmDependenteCadastrar : Form
    {
        Socios socio;
        AcaoNaTela acaoNaTelaSelecionada;
        public FrmDependenteCadastrar(AcaoNaTela acaoNaTela, Dependente dependente)
        {
            InitializeComponent();
            this.acaoNaTelaSelecionada = acaoNaTela;
            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                this.Text = "Inserir Dependente";

            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                this.Text = " Alterar Dependente ";
                txtCodSocio.Enabled = false;
                pnldados.Enabled = true;
                btnsalvar.Enabled = true;
                btnAdicionar.Enabled = false;
                label2.Enabled = false;
                txtCodigo.Text = dependente.IdDep.ToString();
                txtCodSocio.Text = dependente.IDpessoa.ToString();
                txtnomedep.Text = dependente.nome;
                dTPnascdep.Value = dependente.datanasc;
                cmbgraudep.Text = dependente.graudep;
                cmbcivildep.Text = dependente.estadocivil;
            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                this.Text = "Consultar Dependente ";
                txtCodigo.Text = dependente.IdDep.ToString();
                txtCodSocio.Text = dependente.IDpessoa.ToString();
                txtnomedep.Text = dependente.nome;
                dTPnascdep.Value = dependente.datanasc;
                cmbgraudep.Text = dependente.graudep;
                cmbcivildep.Text = dependente.estadocivil;

            }

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            txtnomedep.Focus();

            pnldados.Enabled = true;
            btnsalvar.Enabled = true;
            btnAdicionar.Enabled = false;


        }



        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string carregarCodigo {get;set;}
        
        private void Frmdependente_Load(object sender, EventArgs e)
        {
            Util.ToolTipButton(btnsalvar, "Salvar");
            Util.ToolTipButton(btnAdicionar, "Adicionar Dependente");
            Util.ToolTipButton(BtnCancelar, "Sairo");

                
        }

        

        private void pnldados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            FrmSociosSelecionar selecionar = new FrmSociosSelecionar();
            DialogResult resultado = selecionar.ShowDialog();
            if(resultado==System.Windows.Forms.DialogResult.OK)
            {
                txtCodSocio.Text = selecionar.SocioSelecionado.IDpessoa.ToString();
                socio = selecionar.SocioSelecionado;


            }
                       
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtnomedep.Text))
            {
                MessageBox.Show("Por Favor Preencher o Nome Dependente");
                txtnomedep.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cmbgraudep.Text))
            {
                MessageBox.Show("Por Favor Preencher o Grau Dependente");
                cmbgraudep.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cmbcivildep.Text))
            {
                MessageBox.Show("Por Favor Preencher o estado civil Dependente");
                cmbcivildep.Focus();
                return;
            }
            if (acaoNaTelaSelecionada == AcaoNaTela.Inserir)
            {
                Dependente dependente = new Dependente();
                dependente.IDpessoa = Convert.ToInt32(txtCodSocio.Text);
                dependente.nome = txtnomedep.Text.ToUpper();
                dependente.datanasc = dTPnascdep.Value;
                dependente.graudep = cmbgraudep.Text;
                dependente.estadocivil = cmbcivildep.Text;
                DependenteNegocio dependenteNegocio = new DependenteNegocio();
                string retorno = dependenteNegocio.Inserir(dependente);
                try
                {
                    int IdDep = Convert.ToInt32(retorno);
                    MessageBox.Show("Dependente Inserido com Sucesso Codigo : " + IdDep.ToString());
                    this.DialogResult = DialogResult.Yes;
                    btnAdicionar.Enabled = true;

                }
                catch
                {
                    MessageBox.Show("Codigo do Socio nao cadastrado!!! favor verificar se o socio existe!!! : ", "atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                    return;
                }

            }
            else if (acaoNaTelaSelecionada == AcaoNaTela.Alterar)
            {
                
                Dependente dependente = new Dependente();
                dependente.IdDep = Convert.ToInt32(txtCodigo.Text);
                dependente.IDpessoa = Convert.ToInt32(txtCodSocio.Text);
                dependente.nome = txtnomedep.Text.ToUpper();
                dependente.datanasc = dTPnascdep.Value;
                dependente.graudep = cmbgraudep.Text;
                dependente.estadocivil = cmbcivildep.Text.ToUpper();
                DependenteNegocio dependenteNegocios = new DependenteNegocio();
                string retorno = dependenteNegocios.Alterar(dependente);

                //tentar converter para inteiro
                //se der certo devolve o codigo do socio
                //de errado devolve mensagem de erro.
                try
                {
                    int IdDep = Convert.ToInt32(retorno);
                    MessageBox.Show("Dependente Alterado com Sucesso Codigo : " + IdDep.ToString());
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    MessageBox.Show("nao foi possivel Alterar detalhe:" + retorno, "atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }
            }
        }

        private void pnlbotoes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCodSocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //nao aceita letras
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            { e.Handled = true; }
        }

        private void txtCodSocio_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}


        

  