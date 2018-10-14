namespace Apresentacao
{
    partial class FrmContaReceber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContaReceber));
            this.label1 = new System.Windows.Forms.Label();
            this.MatSocio = new System.Windows.Forms.TextBox();
            this.nomesocio = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.GroupBox();
            this.rdbaberto = new System.Windows.Forms.RadioButton();
            this.rdbpago = new System.Windows.Forms.RadioButton();
            this.BtnPagar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvContasReceberMensalidade = new System.Windows.Forms.DataGridView();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.idReceber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valormensalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datavencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datapagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContasReceberMensalidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula:";
            // 
            // MatSocio
            // 
            this.MatSocio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.MatSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatSocio.Location = new System.Drawing.Point(132, 28);
            this.MatSocio.Name = "MatSocio";
            this.MatSocio.Size = new System.Drawing.Size(87, 26);
            this.MatSocio.TabIndex = 4;
            this.MatSocio.TextChanged += new System.EventHandler(this.MatSocio_TextChanged);
            this.MatSocio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatSocio_KeyPress);
            this.MatSocio.Leave += new System.EventHandler(this.MatSocio_Leave);
            this.MatSocio.Validating += new System.ComponentModel.CancelEventHandler(this.MatSocio_Validating);
            this.MatSocio.Validated += new System.EventHandler(this.MatSocio_Validated);
            // 
            // nomesocio
            // 
            this.nomesocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomesocio.Location = new System.Drawing.Point(225, 28);
            this.nomesocio.Name = "nomesocio";
            this.nomesocio.ReadOnly = true;
            this.nomesocio.Size = new System.Drawing.Size(411, 26);
            this.nomesocio.TabIndex = 5;
            // 
            // Status
            // 
            this.Status.Controls.Add(this.rdbaberto);
            this.Status.Controls.Add(this.rdbpago);
            this.Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.Location = new System.Drawing.Point(61, 73);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(215, 70);
            this.Status.TabIndex = 9;
            this.Status.TabStop = false;
            this.Status.Text = "Situação";
            this.Status.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdbaberto
            // 
            this.rdbaberto.AutoSize = true;
            this.rdbaberto.Checked = true;
            this.rdbaberto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbaberto.Location = new System.Drawing.Point(17, 25);
            this.rdbaberto.Name = "rdbaberto";
            this.rdbaberto.Size = new System.Drawing.Size(75, 24);
            this.rdbaberto.TabIndex = 1;
            this.rdbaberto.TabStop = true;
            this.rdbaberto.Text = "Aberto";
            this.rdbaberto.UseVisualStyleBackColor = true;
            this.rdbaberto.CheckedChanged += new System.EventHandler(this.rdbaberto_CheckedChanged);
            // 
            // rdbpago
            // 
            this.rdbpago.AutoSize = true;
            this.rdbpago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbpago.Location = new System.Drawing.Point(112, 25);
            this.rdbpago.Name = "rdbpago";
            this.rdbpago.Size = new System.Drawing.Size(64, 24);
            this.rdbpago.TabIndex = 0;
            this.rdbpago.Text = "Pago";
            this.rdbpago.UseVisualStyleBackColor = true;
            this.rdbpago.CheckedChanged += new System.EventHandler(this.rdbpago_CheckedChanged);
            // 
            // BtnPagar
            // 
            this.BtnPagar.Image = ((System.Drawing.Image)(resources.GetObject("BtnPagar.Image")));
            this.BtnPagar.Location = new System.Drawing.Point(480, 66);
            this.BtnPagar.Name = "BtnPagar";
            this.BtnPagar.Size = new System.Drawing.Size(75, 77);
            this.BtnPagar.TabIndex = 13;
            this.BtnPagar.UseVisualStyleBackColor = true;
            this.BtnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(642, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "+";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.lblAdicionar);
            // 
            // dgvContasReceberMensalidade
            // 
            this.dgvContasReceberMensalidade.AllowUserToAddRows = false;
            this.dgvContasReceberMensalidade.AllowUserToDeleteRows = false;
            this.dgvContasReceberMensalidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContasReceberMensalidade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReceber,
            this.situacao,
            this.emissao,
            this.valormensalidade,
            this.datavencimento,
            this.datapagamento});
            this.dgvContasReceberMensalidade.Location = new System.Drawing.Point(12, 161);
            this.dgvContasReceberMensalidade.Name = "dgvContasReceberMensalidade";
            this.dgvContasReceberMensalidade.Size = new System.Drawing.Size(663, 336);
            this.dgvContasReceberMensalidade.TabIndex = 17;
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Image = global::Apresentacao.Properties.Resources.consultar;
            this.btnpesquisar.Location = new System.Drawing.Point(399, 66);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(75, 77);
            this.btnpesquisar.TabIndex = 12;
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpequisar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Apresentacao.Properties.Resources.Cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(561, 66);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 77);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // idReceber
            // 
            this.idReceber.DataPropertyName = "idreceber";
            this.idReceber.HeaderText = "Cod.Receber";
            this.idReceber.Name = "idReceber";
            // 
            // situacao
            // 
            this.situacao.DataPropertyName = "parcela";
            this.situacao.HeaderText = "Parcela";
            this.situacao.Name = "situacao";
            this.situacao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // emissao
            // 
            this.emissao.DataPropertyName = "dataemissao";
            this.emissao.HeaderText = "Emissao";
            this.emissao.Name = "emissao";
            // 
            // valormensalidade
            // 
            this.valormensalidade.DataPropertyName = "valorpago";
            this.valormensalidade.HeaderText = "Vl Mensalidade";
            this.valormensalidade.Name = "valormensalidade";
            // 
            // datavencimento
            // 
            this.datavencimento.DataPropertyName = "datavencimento";
            this.datavencimento.HeaderText = "Dt. Vencimento";
            this.datavencimento.Name = "datavencimento";
            // 
            // datapagamento
            // 
            this.datapagamento.DataPropertyName = "datapagamento";
            this.datapagamento.HeaderText = "Data Pagamento";
            this.datapagamento.Name = "datapagamento";
            // 
            // FrmContaReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 509);
            this.ControlBox = false;
            this.Controls.Add(this.dgvContasReceberMensalidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnPagar);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.nomesocio);
            this.Controls.Add(this.MatSocio);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmContaReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Recebimento de Mensalidades";
            this.Load += new System.EventHandler(this.FrmContaReceber_Load);
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContasReceberMensalidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MatSocio;
        private System.Windows.Forms.TextBox nomesocio;
        private System.Windows.Forms.GroupBox Status;
        private System.Windows.Forms.RadioButton rdbaberto;
        private System.Windows.Forms.RadioButton rdbpago;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.Button BtnPagar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvContasReceberMensalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReceber;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn emissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn valormensalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn datavencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn datapagamento;
    }
}