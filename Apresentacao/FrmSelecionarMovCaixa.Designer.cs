namespace Apresentacao
{
    partial class FrmSelecionarMovCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelecionarMovCaixa));
            this.lbData = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.DgvCaixa = new System.Windows.Forms.DataGridView();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoNumerario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnfechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.BtnInserir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Arial Narrow", 13F);
            this.lbData.Location = new System.Drawing.Point(22, 16);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(100, 22);
            this.lbData.TabIndex = 14;
            this.lbData.Text = "Data Emissao";
            // 
            // dtpData
            // 
            this.dtpData.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(140, 16);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(136, 26);
            this.dtpData.TabIndex = 15;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Location = new System.Drawing.Point(291, 15);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(91, 27);
            this.btnPesquisa.TabIndex = 16;
            this.btnPesquisa.Text = "&Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // DgvCaixa
            // 
            this.DgvCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCaixa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipo,
            this.TipoNumerario,
            this.pessoa,
            this.valor,
            this.tipoDoc});
            this.DgvCaixa.Location = new System.Drawing.Point(12, 69);
            this.DgvCaixa.Name = "DgvCaixa";
            this.DgvCaixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCaixa.Size = new System.Drawing.Size(753, 300);
            this.DgvCaixa.TabIndex = 17;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "entradaSaida";
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            // 
            // TipoNumerario
            // 
            this.TipoNumerario.DataPropertyName = "tiponumerario";
            this.TipoNumerario.HeaderText = "TipoNumerario";
            this.TipoNumerario.Name = "TipoNumerario";
            // 
            // pessoa
            // 
            this.pessoa.DataPropertyName = "nomepessoa";
            this.pessoa.HeaderText = "NomePessoa";
            this.pessoa.Name = "pessoa";
            this.pessoa.Width = 250;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "valor";
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            // 
            // tipoDoc
            // 
            this.tipoDoc.DataPropertyName = "tipodocumento";
            this.tipoDoc.HeaderText = "Tipo Documento";
            this.tipoDoc.Name = "tipoDoc";
            // 
            // btnfechar
            // 
            this.btnfechar.Image = ((System.Drawing.Image)(resources.GetObject("btnfechar.Image")));
            this.btnfechar.Location = new System.Drawing.Point(693, 383);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(75, 81);
            this.btnfechar.TabIndex = 13;
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(612, 383);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 81);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(529, 383);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 81);
            this.btnAlterar.TabIndex = 10;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // BtnInserir
            // 
            this.BtnInserir.Image = ((System.Drawing.Image)(resources.GetObject("BtnInserir.Image")));
            this.BtnInserir.Location = new System.Drawing.Point(446, 383);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(75, 81);
            this.BtnInserir.TabIndex = 9;
            this.BtnInserir.UseVisualStyleBackColor = true;
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // FrmSelecionarMovCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 473);
            this.ControlBox = false;
            this.Controls.Add(this.DgvCaixa);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.BtnInserir);
            this.Name = "FrmSelecionarMovCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Mov. de Caixa";
            ((System.ComponentModel.ISupportInitialize)(this.DgvCaixa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.DataGridView DgvCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoNumerario;
        private System.Windows.Forms.DataGridViewTextBoxColumn pessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDoc;
    }
}