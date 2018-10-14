namespace Apresentacao
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.barraStatusprincipal = new System.Windows.Forms.StatusStrip();
            this.labelVersao = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuprincipal = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSocios = new System.Windows.Forms.ToolStripMenuItem();
            this.patrimonioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dependentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financeiroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAPagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAReceberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentoDeCaixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarMensalidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAPagarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contasAReceberToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.patrimonioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentoDeCaixaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agendamentoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraStatusprincipal.SuspendLayout();
            this.menuprincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // barraStatusprincipal
            // 
            this.barraStatusprincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelVersao});
            this.barraStatusprincipal.Location = new System.Drawing.Point(0, 411);
            this.barraStatusprincipal.Name = "barraStatusprincipal";
            this.barraStatusprincipal.Size = new System.Drawing.Size(755, 22);
            this.barraStatusprincipal.TabIndex = 1;
            this.barraStatusprincipal.Text = "statusStrip1";
            // 
            // labelVersao
            // 
            this.labelVersao.Name = "labelVersao";
            this.labelVersao.Size = new System.Drawing.Size(50, 17);
            this.labelVersao.Text = "Versao 1";
            // 
            // menuprincipal
            // 
            this.menuprincipal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuprincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.financeiroToolStripMenuItem,
            this.configuracaoToolStripMenuItem,
            this.relatorioToolStripMenuItem});
            this.menuprincipal.Location = new System.Drawing.Point(0, 0);
            this.menuprincipal.Name = "menuprincipal";
            this.menuprincipal.Size = new System.Drawing.Size(755, 29);
            this.menuprincipal.TabIndex = 3;
            this.menuprincipal.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.MenuSair,
            this.reconectarToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            this.arquivoToolStripMenuItem.Click += new System.EventHandler(this.arquivoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(154, 6);
            // 
            // MenuSair
            // 
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(157, 26);
            this.MenuSair.Text = "&Sair";
            this.MenuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSocios,
            this.patrimonioToolStripMenuItem,
            this.dependentesToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.agendamentoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.cadastroToolStripMenuItem.Text = "&Cadastro";
            // 
            // MenuSocios
            // 
            this.MenuSocios.Name = "MenuSocios";
            this.MenuSocios.Size = new System.Drawing.Size(178, 26);
            this.MenuSocios.Text = "&Sócios";
            this.MenuSocios.Click += new System.EventHandler(this.MenuSocios_Click);
            // 
            // patrimonioToolStripMenuItem
            // 
            this.patrimonioToolStripMenuItem.Name = "patrimonioToolStripMenuItem";
            this.patrimonioToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.patrimonioToolStripMenuItem.Text = "&Patrimônio";
            this.patrimonioToolStripMenuItem.Click += new System.EventHandler(this.patrimonioToolStripMenuItem_Click);
            // 
            // dependentesToolStripMenuItem
            // 
            this.dependentesToolStripMenuItem.Name = "dependentesToolStripMenuItem";
            this.dependentesToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.dependentesToolStripMenuItem.Text = "&Dependentes";
            this.dependentesToolStripMenuItem.Click += new System.EventHandler(this.dependentesToolStripMenuItem_Click);
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.fornecedorToolStripMenuItem.Text = "&Fornecedor";
            this.fornecedorToolStripMenuItem.Click += new System.EventHandler(this.fornecedorToolStripMenuItem_Click);
            // 
            // agendamentoToolStripMenuItem
            // 
            this.agendamentoToolStripMenuItem.Name = "agendamentoToolStripMenuItem";
            this.agendamentoToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.agendamentoToolStripMenuItem.Text = "&Agendamento";
            this.agendamentoToolStripMenuItem.Click += new System.EventHandler(this.agendamentoToolStripMenuItem_Click);
            // 
            // financeiroToolStripMenuItem
            // 
            this.financeiroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contasAPagarToolStripMenuItem,
            this.contasAReceberToolStripMenuItem,
            this.movimentoDeCaixaToolStripMenuItem,
            this.gerarMensalidadesToolStripMenuItem});
            this.financeiroToolStripMenuItem.Name = "financeiroToolStripMenuItem";
            this.financeiroToolStripMenuItem.Size = new System.Drawing.Size(94, 25);
            this.financeiroToolStripMenuItem.Text = "&Financeiro";
            // 
            // contasAPagarToolStripMenuItem
            // 
            this.contasAPagarToolStripMenuItem.Name = "contasAPagarToolStripMenuItem";
            this.contasAPagarToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.contasAPagarToolStripMenuItem.Text = "&Contas a Pagar";
            this.contasAPagarToolStripMenuItem.Click += new System.EventHandler(this.contasAPagarToolStripMenuItem_Click);
            // 
            // contasAReceberToolStripMenuItem
            // 
            this.contasAReceberToolStripMenuItem.Name = "contasAReceberToolStripMenuItem";
            this.contasAReceberToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.contasAReceberToolStripMenuItem.Text = "&Contas a Receber";
            this.contasAReceberToolStripMenuItem.Click += new System.EventHandler(this.contasAReceberToolStripMenuItem_Click);
            // 
            // movimentoDeCaixaToolStripMenuItem
            // 
            this.movimentoDeCaixaToolStripMenuItem.Name = "movimentoDeCaixaToolStripMenuItem";
            this.movimentoDeCaixaToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.movimentoDeCaixaToolStripMenuItem.Text = "&Movimento de Caixa";
            this.movimentoDeCaixaToolStripMenuItem.Click += new System.EventHandler(this.movimentoDeCaixaToolStripMenuItem_Click);
            // 
            // gerarMensalidadesToolStripMenuItem
            // 
            this.gerarMensalidadesToolStripMenuItem.Name = "gerarMensalidadesToolStripMenuItem";
            this.gerarMensalidadesToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.gerarMensalidadesToolStripMenuItem.Text = "&Gerar Mensalidades";
            this.gerarMensalidadesToolStripMenuItem.Click += new System.EventHandler(this.gerarMensalidadesToolStripMenuItem_Click);
            // 
            // configuracaoToolStripMenuItem
            // 
            this.configuracaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.configuracaoToolStripMenuItem.Name = "configuracaoToolStripMenuItem";
            this.configuracaoToolStripMenuItem.Size = new System.Drawing.Size(115, 25);
            this.configuracaoToolStripMenuItem.Text = "&Configuração";
            // 
            // pToolStripMenuItem
            // 
            this.pToolStripMenuItem.Name = "pToolStripMenuItem";
            this.pToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.pToolStripMenuItem.Text = "&Parâmetros";
            this.pToolStripMenuItem.Click += new System.EventHandler(this.pToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.usuarioToolStripMenuItem.Text = "&Usuário";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // relatorioToolStripMenuItem
            // 
            this.relatorioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sociosToolStripMenuItem,
            this.contasAPagarToolStripMenuItem1,
            this.contasAReceberToolStripMenuItem1,
            this.patrimonioToolStripMenuItem1,
            this.movimentoDeCaixaToolStripMenuItem1,
            this.agendamentoToolStripMenuItem1});
            this.relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            this.relatorioToolStripMenuItem.Size = new System.Drawing.Size(85, 25);
            this.relatorioToolStripMenuItem.Text = "&Relatorio";
            // 
            // sociosToolStripMenuItem
            // 
            this.sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            this.sociosToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.sociosToolStripMenuItem.Text = "&Socios";
            this.sociosToolStripMenuItem.Click += new System.EventHandler(this.sociosToolStripMenuItem_Click);
            // 
            // contasAPagarToolStripMenuItem1
            // 
            this.contasAPagarToolStripMenuItem1.Name = "contasAPagarToolStripMenuItem1";
            this.contasAPagarToolStripMenuItem1.Size = new System.Drawing.Size(201, 26);
            this.contasAPagarToolStripMenuItem1.Text = "&Contas à Pagar";
            this.contasAPagarToolStripMenuItem1.Click += new System.EventHandler(this.contasAPagarToolStripMenuItem1_Click);
            // 
            // contasAReceberToolStripMenuItem1
            // 
            this.contasAReceberToolStripMenuItem1.Name = "contasAReceberToolStripMenuItem1";
            this.contasAReceberToolStripMenuItem1.Size = new System.Drawing.Size(201, 26);
            this.contasAReceberToolStripMenuItem1.Text = "&Contas à Receber";
            this.contasAReceberToolStripMenuItem1.Click += new System.EventHandler(this.contasAReceberToolStripMenuItem1_Click);
            // 
            // patrimonioToolStripMenuItem1
            // 
            this.patrimonioToolStripMenuItem1.Name = "patrimonioToolStripMenuItem1";
            this.patrimonioToolStripMenuItem1.Size = new System.Drawing.Size(201, 26);
            this.patrimonioToolStripMenuItem1.Text = "&Patrimonio";
            this.patrimonioToolStripMenuItem1.Click += new System.EventHandler(this.patrimonioToolStripMenuItem1_Click);
            // 
            // movimentoDeCaixaToolStripMenuItem1
            // 
            this.movimentoDeCaixaToolStripMenuItem1.Name = "movimentoDeCaixaToolStripMenuItem1";
            this.movimentoDeCaixaToolStripMenuItem1.Size = new System.Drawing.Size(201, 26);
            this.movimentoDeCaixaToolStripMenuItem1.Text = "&Movimento Caixa";
            this.movimentoDeCaixaToolStripMenuItem1.Click += new System.EventHandler(this.movimentoDeCaixaToolStripMenuItem1_Click);
            // 
            // agendamentoToolStripMenuItem1
            // 
            this.agendamentoToolStripMenuItem1.Name = "agendamentoToolStripMenuItem1";
            this.agendamentoToolStripMenuItem1.Size = new System.Drawing.Size(201, 26);
            this.agendamentoToolStripMenuItem1.Text = "&Agendamento";
            this.agendamentoToolStripMenuItem1.Click += new System.EventHandler(this.agendamentoToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(755, 382);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // reconectarToolStripMenuItem
            // 
            this.reconectarToolStripMenuItem.Name = "reconectarToolStripMenuItem";
            this.reconectarToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.reconectarToolStripMenuItem.Text = "&Reconectar";
            this.reconectarToolStripMenuItem.Click += new System.EventHandler(this.reconectarToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 433);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.barraStatusprincipal);
            this.Controls.Add(this.menuprincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuprincipal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMenu";
            this.Text = "Sistema de Gerenciamento de Clube";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.barraStatusprincipal.ResumeLayout(false);
            this.barraStatusprincipal.PerformLayout();
            this.menuprincipal.ResumeLayout(false);
            this.menuprincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip barraStatusprincipal;
        private System.Windows.Forms.ToolStripStatusLabel labelVersao;
        private System.Windows.Forms.MenuStrip menuprincipal;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuSocios;
        private System.Windows.Forms.ToolStripMenuItem patrimonioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financeiroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAPagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAReceberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contasAPagarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contasAReceberToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem patrimonioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dependentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentoDeCaixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentoDeCaixaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gerarMensalidadesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem agendamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendamentoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reconectarToolStripMenuItem;
    }
}