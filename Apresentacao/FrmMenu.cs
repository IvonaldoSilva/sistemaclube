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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuSocios_Click(object sender, EventArgs e)
        {
            FrmSociosSelecionar frmSociosSelecionar = new FrmSociosSelecionar();
            // frmSociosSelecionar.MdiParent = this;
            frmSociosSelecionar.ShowDialog();
            frmSociosSelecionar.Dispose();


        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmParametro frmparametro = new FrmParametro();
            frmparametro.ShowDialog();
            frmparametro.Dispose();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaUsuario consultarUsuario = new FrmConsultaUsuario();
            // consultarUsuario.MdiParent = this;
            consultarUsuario.ShowDialog();
            consultarUsuario.Dispose();
        }

        private void dependentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSelecionarDependente frmselecionardependente = new FrmSelecionarDependente();
            frmselecionardependente.ShowDialog();
            frmselecionardependente.Dispose();
        }

        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var menu = sender.ToString().Replace("&", "");
            FrmRelatorio rel = new FrmRelatorio(menu);
            rel.ShowDialog();
        }

        private void dependenteToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContaReceber frmcontaReceber = new FrmContaReceber();
            frmcontaReceber.ShowDialog();
            frmcontaReceber.Dispose();
        }

        private void patrimonioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPatrimonioSelecionar patrimonio = new frmPatrimonioSelecionar();
            patrimonio.ShowDialog();
            patrimonio.Dispose();
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContasPagarSelecionar frmContasPagar = new FrmContasPagarSelecionar();
            frmContasPagar.ShowDialog();
            frmContasPagar.Dispose();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFornecedorSelecionar fornecedorSelecionar = new FrmFornecedorSelecionar();
            fornecedorSelecionar.ShowDialog();
            fornecedorSelecionar.Dispose();

        }

        private void movimentoDeCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSelecionarMovCaixa frmMovCaixa = new FrmSelecionarMovCaixa();
            frmMovCaixa.ShowDialog();
            frmMovCaixa.Dispose();
        }

        private void gerarMensalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeradorParcelas geradorParcelas = new GeradorParcelas();
            geradorParcelas.ShowDialog();
            geradorParcelas.Dispose();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.50;
            Frmlogin login = new Frmlogin();
            login.ShowDialog();
            var perfil = login.strPerfilAcesso;
            this.Opacity = 1;

            if (string.IsNullOrEmpty(perfil))
                perfil = "CAIXA";

            //Percorrendo todos os menus para encontrar possíveis restrições e aplicá-las, removendo o menu
            menuprincipal.Items.OfType<ToolStripItem>().ToList().ForEach(item =>
            {
                var itens = ObterTodosFilhosMenu(item);
                itens.ToList().ForEach(menu =>
                {
                    switch (perfil)
                    {
                        case "GERENCIAL":
                            {
                                if (!arrMenusGerencial.Contains(menu.Text))
                                {
                                    menuprincipal.Items.Remove(menu);
                                }
                            }
                            break;
                        case "CAIXA":
                            {
                                if (!arrMenusCaixa.Contains(menu.Text))
                                {
                                    menuprincipal.Items.Remove(menu);
                                }
                            }
                            break;
                    }
                });
            });
        }
        private ToolStripItem[] ObterTodosFilhosMenu(ToolStripItem item)
        {
            List<ToolStripItem> Items = new List<ToolStripItem> { item };
            if (item is ToolStripMenuItem)
                foreach (ToolStripItem i in ((ToolStripMenuItem)item).DropDownItems)
                    Items.AddRange(ObterTodosFilhosMenu(i));
            else if (item is ToolStripSplitButton)
                foreach (ToolStripItem i in ((ToolStripSplitButton)item).DropDownItems)
                    Items.AddRange(ObterTodosFilhosMenu(i));
            else if (item is ToolStripDropDownButton)
                foreach (ToolStripItem i in ((ToolStripDropDownButton)item).DropDownItems)
                    Items.AddRange(ObterTodosFilhosMenu(i));
            return Items.ToArray();
        }
        string[] arrMenusCaixa = { "&Arquivo",
                                    "&Reconectar",
                                    "&Sair",
                                    "&Cadastro",
                                    "&Sócios",
                                    "&Patrimônio",
                                    "&Dependentes",
                                    "&Fornecedor",
                                    "&Agendamento",
                                    "&Financeiro",
                                    "&Contas a Pagar",
                                    "&Contas a Receber",
                                    "&Movimento de Caixa",
                                    "&Gerar Mensalidades",
                                    "&Relatorio",
                                    "&Contas à Pagar",
                                    "&Contas à Receber",
                                    "&Movimento Caixa",
                                    
                                    };
        string[] arrMenusGerencial = { "&Arquivo",
                                        "&Reconectar",
                                        "&Sair",
                                        "&Cadastro",
                                        "&Sócios",
                                        "&Patrimônio",
                                        "&Dependentes",
                                        "&Fornecedor",
                                        "&Agendamento",
                                        "&Financeiro",
                                        "&Contas a Pagar",
                                        "&Contas a Receber",
                                        "&Movimento de Caixa",
                                        "&Gerar Mensalidades",
                                        //"&Configuração",
                                        //"&Parâmetros",
                                        //"&Usuário",
                                        "&Relatorio",
                                        "&Socios",
                                        "&Contas à Pagar",
                                        "&Contas à Receber",
                                        "&Patrimonio",
                                        "&Movimento Caixa",
                                        "&Agendamento",
                                    };

        private void contasAReceberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var menu = sender.ToString().Replace("&", "");
            FrmRelatorio rel = new FrmRelatorio(menu);
            rel.ShowDialog();
        }

        private void contasAPagarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var menu = sender.ToString().Replace("&", "");
            FrmRelatorio rel = new FrmRelatorio(menu);
            rel.ShowDialog();
        }

        private void patrimonioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var menu = sender.ToString().Replace("&", "");
            FrmRelatorio rel = new FrmRelatorio(menu);
            rel.ShowDialog();
        }

        private void movimentoDeCaixaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var menu = sender.ToString().Replace("&", "");
            FrmRelatorio rel = new FrmRelatorio(menu);
            rel.ShowDialog();
        }

        private void agendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSelecionarAgendamento frmAgendamento = new FrmSelecionarAgendamento();
            frmAgendamento.ShowDialog();
            frmAgendamento.Dispose();

        }

        private void agendamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var menu = sender.ToString().Replace("&", "");
            FrmRelatorio rel = new FrmRelatorio(menu);
            rel.ShowDialog();
        }

        private void reconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
