namespace Apresentacao
{
    partial class frmPatrimonioSelecionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatrimonioSelecionar));
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtpesquisar = new System.Windows.Forms.TextBox();
            this.dgvPatrimonio = new System.Windows.Forms.DataGridView();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.btnfechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.IDpatrimonio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dataaquisicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CmbSituacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatrimonio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesquisar.Location = new System.Drawing.Point(2, 36);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(124, 20);
            this.lblPesquisar.TabIndex = 0;
            this.lblPesquisar.Text = "Nome do Objeto";
            // 
            // txtpesquisar
            // 
            this.txtpesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpesquisar.Location = new System.Drawing.Point(132, 33);
            this.txtpesquisar.Name = "txtpesquisar";
            this.txtpesquisar.Size = new System.Drawing.Size(326, 26);
            this.txtpesquisar.TabIndex = 1;
            // 
            // dgvPatrimonio
            // 
            this.dgvPatrimonio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatrimonio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDpatrimonio,
            this.Quantidade,
            this.Descricao,
            this.Dataaquisicao,
            this.CmbSituacao,
            this.idtipo});
            this.dgvPatrimonio.Location = new System.Drawing.Point(6, 78);
            this.dgvPatrimonio.Name = "dgvPatrimonio";
            this.dgvPatrimonio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatrimonio.Size = new System.Drawing.Size(886, 207);
            this.dgvPatrimonio.TabIndex = 2;
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisar.Location = new System.Drawing.Point(465, 33);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(103, 26);
            this.btnpesquisar.TabIndex = 3;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // btnfechar
            // 
            this.btnfechar.Image = ((System.Drawing.Image)(resources.GetObject("btnfechar.Image")));
            this.btnfechar.Location = new System.Drawing.Point(817, 291);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(75, 81);
            this.btnfechar.TabIndex = 16;
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(736, 291);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 81);
            this.btnExcluir.TabIndex = 15;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(653, 291);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 81);
            this.btnAlterar.TabIndex = 14;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // BtnInserir
            // 
            this.BtnInserir.Image = ((System.Drawing.Image)(resources.GetObject("BtnInserir.Image")));
            this.BtnInserir.Location = new System.Drawing.Point(570, 291);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(75, 81);
            this.BtnInserir.TabIndex = 13;
            this.BtnInserir.UseVisualStyleBackColor = true;
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // IDpatrimonio
            // 
            this.IDpatrimonio.DataPropertyName = "IDpatrimonio";
            this.IDpatrimonio.HeaderText = "Codigo";
            this.IDpatrimonio.Name = "IDpatrimonio";
            this.IDpatrimonio.Width = 50;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "quantidade";
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Width = 80;
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "descricao";
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 300;
            // 
            // Dataaquisicao
            // 
            this.Dataaquisicao.DataPropertyName = "dataaquisicao";
            this.Dataaquisicao.HeaderText = "Dt. Aquisicao";
            this.Dataaquisicao.Name = "Dataaquisicao";
            this.Dataaquisicao.Width = 80;
            // 
            // CmbSituacao
            // 
            this.CmbSituacao.DataPropertyName = "ativo";
            this.CmbSituacao.HeaderText = "Situação";
            this.CmbSituacao.Name = "CmbSituacao";
            this.CmbSituacao.Width = 80;
            // 
            // idtipo
            // 
            this.idtipo.DataPropertyName = "TipoNome";
            this.idtipo.HeaderText = "Tipo";
            this.idtipo.Name = "idtipo";
            this.idtipo.Width = 250;
            // 
            // frmPatrimonioSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 381);
            this.ControlBox = false;
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.BtnInserir);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.dgvPatrimonio);
            this.Controls.Add(this.txtpesquisar);
            this.Controls.Add(this.lblPesquisar);
            this.Name = "frmPatrimonioSelecionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Patrimonio";
            this.Load += new System.EventHandler(this.frmPatrimonioSelecionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatrimonio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txtpesquisar;
        private System.Windows.Forms.DataGridView dgvPatrimonio;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDpatrimonio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dataaquisicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn CmbSituacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipo;
    }
}