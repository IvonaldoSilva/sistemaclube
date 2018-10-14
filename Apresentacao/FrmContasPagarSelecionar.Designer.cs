namespace Apresentacao
{
    partial class FrmContasPagarSelecionar
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
            System.Windows.Forms.Button btnPagar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContasPagarSelecionar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Selecionar = new System.Windows.Forms.Button();
            this.dgvContasPagar = new System.Windows.Forms.DataGridView();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtpesquisa = new System.Windows.Forms.TextBox();
            this.LabelPesquisa = new System.Windows.Forms.Label();
            this.btnfechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.situacao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataPagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcontaspagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoatipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codpessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valordocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataemissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datavencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnPagar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContasPagar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPagar
            // 
            btnPagar.AutoEllipsis = true;
            btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPagar.Image = ((System.Drawing.Image)(resources.GetObject("btnPagar.Image")));
            btnPagar.Location = new System.Drawing.Point(446, 382);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new System.Drawing.Size(75, 81);
            btnPagar.TabIndex = 3;
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += new System.EventHandler(this.btnpagar_Click);
            // 
            // Selecionar
            // 
            this.Selecionar.Enabled = false;
            this.Selecionar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selecionar.Location = new System.Drawing.Point(622, 10);
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.Size = new System.Drawing.Size(93, 27);
            this.Selecionar.TabIndex = 8;
            this.Selecionar.Text = "&Selecionar";
            this.Selecionar.UseVisualStyleBackColor = true;
            // 
            // dgvContasPagar
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvContasPagar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContasPagar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContasPagar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.situacao,
            this.dataPagamento,
            this.idcontaspagar,
            this.pessoatipo,
            this.codpessoa,
            this.nome,
            this.tipodocumento,
            this.documento,
            this.valordocumento,
            this.dataemissao,
            this.datavencimento,
            this.historico});
            this.dgvContasPagar.Location = new System.Drawing.Point(8, 50);
            this.dgvContasPagar.MultiSelect = false;
            this.dgvContasPagar.Name = "dgvContasPagar";
            this.dgvContasPagar.ReadOnly = true;
            this.dgvContasPagar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContasPagar.Size = new System.Drawing.Size(760, 326);
            this.dgvContasPagar.TabIndex = 7;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Location = new System.Drawing.Point(525, 10);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(91, 27);
            this.btnPesquisa.TabIndex = 1;
            this.btnPesquisa.Text = "&Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtpesquisa
            // 
            this.txtpesquisa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpesquisa.Location = new System.Drawing.Point(161, 11);
            this.txtpesquisa.Name = "txtpesquisa";
            this.txtpesquisa.Size = new System.Drawing.Size(358, 26);
            this.txtpesquisa.TabIndex = 0;
            // 
            // LabelPesquisa
            // 
            this.LabelPesquisa.AutoSize = true;
            this.LabelPesquisa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPesquisa.Location = new System.Drawing.Point(18, 15);
            this.LabelPesquisa.Name = "LabelPesquisa";
            this.LabelPesquisa.Size = new System.Drawing.Size(137, 20);
            this.LabelPesquisa.TabIndex = 18;
            this.LabelPesquisa.Text = "Pesquisar por  Nome";
            // 
            // btnfechar
            // 
            this.btnfechar.Image = ((System.Drawing.Image)(resources.GetObject("btnfechar.Image")));
            this.btnfechar.Location = new System.Drawing.Point(691, 382);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(75, 81);
            this.btnfechar.TabIndex = 6;
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(610, 382);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 81);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(527, 382);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 81);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // BtnInserir
            // 
            this.BtnInserir.Image = ((System.Drawing.Image)(resources.GetObject("BtnInserir.Image")));
            this.BtnInserir.Location = new System.Drawing.Point(365, 382);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(75, 81);
            this.BtnInserir.TabIndex = 2;
            this.BtnInserir.UseVisualStyleBackColor = true;
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // situacao
            // 
            this.situacao.DataPropertyName = "situacao";
            dataGridViewCellStyle2.NullValue = false;
            this.situacao.DefaultCellStyle = dataGridViewCellStyle2;
            this.situacao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.situacao.HeaderText = "A Pagar";
            this.situacao.Name = "situacao";
            this.situacao.ReadOnly = true;
            this.situacao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.situacao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.situacao.Width = 40;
            // 
            // dataPagamento
            // 
            this.dataPagamento.DataPropertyName = "dataPagamento";
            this.dataPagamento.HeaderText = "Data Pagamento";
            this.dataPagamento.Name = "dataPagamento";
            this.dataPagamento.ReadOnly = true;
            // 
            // idcontaspagar
            // 
            this.idcontaspagar.DataPropertyName = "idcontaspagar";
            this.idcontaspagar.HeaderText = "Codigo";
            this.idcontaspagar.Name = "idcontaspagar";
            this.idcontaspagar.ReadOnly = true;
            this.idcontaspagar.Width = 50;
            // 
            // pessoatipo
            // 
            this.pessoatipo.DataPropertyName = "pessoatipo";
            this.pessoatipo.HeaderText = "Fisica/Juridica";
            this.pessoatipo.Name = "pessoatipo";
            this.pessoatipo.ReadOnly = true;
            // 
            // codpessoa
            // 
            this.codpessoa.DataPropertyName = "codpessoa";
            this.codpessoa.HeaderText = "Cod.Cliente";
            this.codpessoa.Name = "codpessoa";
            this.codpessoa.ReadOnly = true;
            this.codpessoa.Width = 70;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 230;
            // 
            // tipodocumento
            // 
            this.tipodocumento.DataPropertyName = "tipodocumento";
            this.tipodocumento.HeaderText = "Tipo de Doc.";
            this.tipodocumento.Name = "tipodocumento";
            this.tipodocumento.ReadOnly = true;
            // 
            // documento
            // 
            this.documento.DataPropertyName = "documento";
            this.documento.HeaderText = "Nr. Documento";
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            // 
            // valordocumento
            // 
            this.valordocumento.DataPropertyName = "valordocumento";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.valordocumento.DefaultCellStyle = dataGridViewCellStyle3;
            this.valordocumento.HeaderText = "Vl. Documento";
            this.valordocumento.Name = "valordocumento";
            this.valordocumento.ReadOnly = true;
            // 
            // dataemissao
            // 
            this.dataemissao.DataPropertyName = "dataemissao";
            this.dataemissao.HeaderText = "Dt. Emissao";
            this.dataemissao.Name = "dataemissao";
            this.dataemissao.ReadOnly = true;
            // 
            // datavencimento
            // 
            this.datavencimento.DataPropertyName = "datavencimento";
            this.datavencimento.HeaderText = "Dt. Vencimento";
            this.datavencimento.Name = "datavencimento";
            this.datavencimento.ReadOnly = true;
            // 
            // historico
            // 
            this.historico.DataPropertyName = "historico";
            this.historico.HeaderText = "Hist. Complementar";
            this.historico.Name = "historico";
            this.historico.ReadOnly = true;
            this.historico.Width = 300;
            // 
            // FrmContasPagarSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 473);
            this.ControlBox = false;
            this.Controls.Add(btnPagar);
            this.Controls.Add(this.Selecionar);
            this.Controls.Add(this.dgvContasPagar);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.BtnInserir);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.txtpesquisa);
            this.Controls.Add(this.LabelPesquisa);
            this.Name = "FrmContasPagarSelecionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Contas a Pagar ";
            this.Load += new System.EventHandler(this.FrmContasPagarSelecionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContasPagar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Selecionar;
        private System.Windows.Forms.DataGridView dgvContasPagar;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.TextBox txtpesquisa;
        private System.Windows.Forms.Label LabelPesquisa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcontaspagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn pessoatipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn codpessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn valordocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataemissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn historico;
    }
}