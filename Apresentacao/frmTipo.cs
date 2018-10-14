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
    public partial class frmTipo : Form
    {
        public frmTipo()
        {
            InitializeComponent();
            dgvtipo.AutoGenerateColumns = false;
            
         }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtdescricao.Text))
            {
                MessageBox.Show("Por favor preencher a Descricao");
                txtdescricao.Focus();
                return;
            }
            Tipo tipo = new Tipo();
            tipo.descricao = txtdescricao.Text.ToUpper();
            TipoNegocio tipoNegocio = new TipoNegocio();
            string retorno = tipoNegocio.Inserir(tipo);
            try
            {

                int idtipo = Convert.ToInt32(retorno);
                MessageBox.Show("Categoria inserito Sucesso Codigo : " + idtipo.ToString());
                //this.DialogResult = DialogResult.Yes;
                atualizarGrid();
                LimparCampos();
            
            }
            catch
            {
                MessageBox.Show("nao foi possivel inserir detalhe:" + retorno, "atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.No;
            }

        }
       
    

        private void btnsair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmTipo_Load(object sender, EventArgs e)
        {
            Util.ToolTipButton(btnsalvar, "Salvar");
            Util.ToolTipButton(btnsair, "Sair");
            Util.ToolTipButton(btnexcluir, "Excluir");
            Util.ToolTipButton(btnpesquisar, "Pesquisar");


        }

        

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (dgvtipo.SelectedRows.Count == 0)
            {
                MessageBox.Show("nenhuma categoria selecionado");
                return;

            }
            DialogResult resultado = MessageBox.Show("tem certeza que quer excluir  ?", "Perqunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            Tipo tipoSelecionado = (dgvtipo.SelectedRows[0].DataBoundItem as Tipo);
            TipoNegocio tipoNegocio = new TipoNegocio();
            string retorno = tipoNegocio.Excluir(tipoSelecionado);
            try
            {
                int idtipo = Convert.ToInt32(retorno);
                dgvtipo.Refresh();
                MessageBox.Show("Registro excluido com Sucesso!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                atualizarGrid();
               
            }
            catch
            {
                MessageBox.Show("Nao foi possivel excluir Usuario detalhe :" + retorno, "atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void dgvtipo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        

        private void btnpesquisar_Click_1(object sender, EventArgs e)
        {
            atualizarGrid();
            
        }

        private void atualizarGrid()
        {
            TipoNegocio tipoNegocios = new TipoNegocio();
            TipoColecao tipoColecao = new TipoColecao();
            tipoColecao = tipoNegocios.ConsultarDescricao(txtdescricao.Text);
            dgvtipo.DataSource = null;
            dgvtipo.DataSource = tipoColecao;
            dgvtipo.Update();
            dgvtipo.Refresh();
        }

        private void dgvtipo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //frmCadastrarPatrimonio patrimonio = new frmCadastrarPatrimonio();
            //patrimonio = dgvtipo.CurrentRow.Cells[0].Value.ToString();
        }
        private void LimparCampos()
        {
            txtdescricao.Clear();
        }

    }
}

