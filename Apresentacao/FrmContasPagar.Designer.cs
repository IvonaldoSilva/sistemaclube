namespace Apresentacao
{
    partial class FrmContasPagar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContasPagar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtvalordocumento = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tipopessoa = new System.Windows.Forms.GroupBox();
            this.RdbFonecedor = new System.Windows.Forms.RadioButton();
            this.RdbSocio = new System.Windows.Forms.RadioButton();
            this.lblAdicionar = new System.Windows.Forms.Label();
            this.cmbTipodocumento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txthistorico = new System.Windows.Forms.TextBox();
            this.txtdocumento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.GBSituacao = new System.Windows.Forms.GroupBox();
            this.rdbpago = new System.Windows.Forms.RadioButton();
            this.rdbapagar = new System.Windows.Forms.RadioButton();
            this.dtpVencimento = new System.Windows.Forms.DateTimePicker();
            this.dtpEmissao = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtidcontaspagar = new System.Windows.Forms.TextBox();
            this.paneldados = new System.Windows.Forms.Panel();
            this.dtpPagamento = new System.Windows.Forms.DateTimePicker();
            this.lbDataPagamento = new System.Windows.Forms.Label();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Tipopessoa.SuspendLayout();
            this.GBSituacao.SuspendLayout();
            this.paneldados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fornecedor/Socio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Emissao";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vl. Documento";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(16, 117);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(87, 26);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtvalordocumento
            // 
            this.txtvalordocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalordocumento.Location = new System.Drawing.Point(312, 169);
            this.txtvalordocumento.MaxLength = 11;
            this.txtvalordocumento.Name = "txtvalordocumento";
            this.txtvalordocumento.Size = new System.Drawing.Size(142, 26);
            this.txtvalordocumento.TabIndex = 4;
            this.txtvalordocumento.TextChanged += new System.EventHandler(this.txtvalordocumento_TextChanged);
            this.txtvalordocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalordocumento_KeyPress);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(8, 425);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 74);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(89, 425);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 74);
            this.btnSair.TabIndex = 11;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(109, 117);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(452, 26);
            this.txtNome.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Codigo";
            // 
            // Tipopessoa
            // 
            this.Tipopessoa.Controls.Add(this.RdbFonecedor);
            this.Tipopessoa.Controls.Add(this.RdbSocio);
            this.Tipopessoa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipopessoa.Location = new System.Drawing.Point(252, 12);
            this.Tipopessoa.Name = "Tipopessoa";
            this.Tipopessoa.Size = new System.Drawing.Size(309, 62);
            this.Tipopessoa.TabIndex = 0;
            this.Tipopessoa.TabStop = false;
            this.Tipopessoa.Text = "Selecione  o  Tipo";
            // 
            // RdbFonecedor
            // 
            this.RdbFonecedor.AutoSize = true;
            this.RdbFonecedor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbFonecedor.Location = new System.Drawing.Point(153, 23);
            this.RdbFonecedor.Name = "RdbFonecedor";
            this.RdbFonecedor.Size = new System.Drawing.Size(97, 24);
            this.RdbFonecedor.TabIndex = 1;
            this.RdbFonecedor.TabStop = true;
            this.RdbFonecedor.Text = "Fornecedor";
            this.RdbFonecedor.UseVisualStyleBackColor = true;
            // 
            // RdbSocio
            // 
            this.RdbSocio.AutoSize = true;
            this.RdbSocio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbSocio.Location = new System.Drawing.Point(12, 23);
            this.RdbSocio.Name = "RdbSocio";
            this.RdbSocio.Size = new System.Drawing.Size(62, 24);
            this.RdbSocio.TabIndex = 0;
            this.RdbSocio.TabStop = true;
            this.RdbSocio.Text = "Socio";
            this.RdbSocio.UseVisualStyleBackColor = true;
            // 
            // lblAdicionar
            // 
            this.lblAdicionar.AutoSize = true;
            this.lblAdicionar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionar.Location = new System.Drawing.Point(568, 117);
            this.lblAdicionar.Name = "lblAdicionar";
            this.lblAdicionar.Size = new System.Drawing.Size(19, 23);
            this.lblAdicionar.TabIndex = 15;
            this.lblAdicionar.Text = "+";
            this.lblAdicionar.Click += new System.EventHandler(this.lblAdicionar_Click_1);
            // 
            // cmbTipodocumento
            // 
            this.cmbTipodocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipodocumento.FormattingEnabled = true;
            this.cmbTipodocumento.Items.AddRange(new object[] {
            "BOLETO",
            "NOTA FISCAL",
            "DUPLICATA",
            "VALES",
            "OUTROS"});
            this.cmbTipodocumento.Location = new System.Drawing.Point(16, 167);
            this.cmbTipodocumento.Name = "cmbTipodocumento";
            this.cmbTipodocumento.Size = new System.Drawing.Size(142, 28);
            this.cmbTipodocumento.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tipo Documento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Data Vencimento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Informações Complemetares";
            // 
            // txthistorico
            // 
            this.txthistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthistorico.Location = new System.Drawing.Point(12, 296);
            this.txthistorico.MaxLength = 200;
            this.txthistorico.Name = "txthistorico";
            this.txthistorico.Size = new System.Drawing.Size(549, 26);
            this.txthistorico.TabIndex = 7;
            // 
            // txtdocumento
            // 
            this.txtdocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdocumento.Location = new System.Drawing.Point(164, 169);
            this.txtdocumento.MaxLength = 11;
            this.txtdocumento.Name = "txtdocumento";
            this.txtdocumento.Size = new System.Drawing.Size(142, 26);
            this.txtdocumento.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(165, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "Documento";
            // 
            // GBSituacao
            // 
            this.GBSituacao.Controls.Add(this.rdbpago);
            this.GBSituacao.Controls.Add(this.rdbapagar);
            this.GBSituacao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBSituacao.Location = new System.Drawing.Point(8, 351);
            this.GBSituacao.Name = "GBSituacao";
            this.GBSituacao.Size = new System.Drawing.Size(264, 61);
            this.GBSituacao.TabIndex = 2;
            this.GBSituacao.TabStop = false;
            this.GBSituacao.Text = "Status";
            // 
            // rdbpago
            // 
            this.rdbpago.AutoSize = true;
            this.rdbpago.Enabled = false;
            this.rdbpago.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbpago.Location = new System.Drawing.Point(153, 23);
            this.rdbpago.Name = "rdbpago";
            this.rdbpago.Size = new System.Drawing.Size(59, 24);
            this.rdbpago.TabIndex = 1;
            this.rdbpago.TabStop = true;
            this.rdbpago.Text = "Pago";
            this.rdbpago.UseVisualStyleBackColor = true;
            this.rdbpago.Click += new System.EventHandler(this.rdbpago_Click);
            // 
            // rdbapagar
            // 
            this.rdbapagar.AutoSize = true;
            this.rdbapagar.Checked = true;
            this.rdbapagar.Enabled = false;
            this.rdbapagar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbapagar.Location = new System.Drawing.Point(12, 23);
            this.rdbapagar.Name = "rdbapagar";
            this.rdbapagar.Size = new System.Drawing.Size(75, 24);
            this.rdbapagar.TabIndex = 0;
            this.rdbapagar.TabStop = true;
            this.rdbapagar.Text = "À Pagar";
            this.rdbapagar.UseVisualStyleBackColor = true;
            this.rdbapagar.CheckedChanged += new System.EventHandler(this.rdbapagar_CheckedChanged);
            // 
            // dtpVencimento
            // 
            this.dtpVencimento.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVencimento.Location = new System.Drawing.Point(16, 234);
            this.dtpVencimento.Name = "dtpVencimento";
            this.dtpVencimento.Size = new System.Drawing.Size(127, 26);
            this.dtpVencimento.TabIndex = 25;
            // 
            // dtpEmissao
            // 
            this.dtpEmissao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEmissao.Location = new System.Drawing.Point(164, 232);
            this.dtpEmissao.Name = "dtpEmissao";
            this.dtpEmissao.Size = new System.Drawing.Size(127, 26);
            this.dtpEmissao.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Cod.Contas";
            // 
            // txtidcontaspagar
            // 
            this.txtidcontaspagar.Enabled = false;
            this.txtidcontaspagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidcontaspagar.Location = new System.Drawing.Point(24, 44);
            this.txtidcontaspagar.Name = "txtidcontaspagar";
            this.txtidcontaspagar.Size = new System.Drawing.Size(87, 26);
            this.txtidcontaspagar.TabIndex = 27;
            // 
            // paneldados
            // 
            this.paneldados.Controls.Add(this.dtpPagamento);
            this.paneldados.Controls.Add(this.lbDataPagamento);
            this.paneldados.Location = new System.Drawing.Point(4, 0);
            this.paneldados.Name = "paneldados";
            this.paneldados.Size = new System.Drawing.Size(630, 345);
            this.paneldados.TabIndex = 29;
            // 
            // dtpPagamento
            // 
            this.dtpPagamento.Enabled = false;
            this.dtpPagamento.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPagamento.Location = new System.Drawing.Point(304, 232);
            this.dtpPagamento.Name = "dtpPagamento";
            this.dtpPagamento.Size = new System.Drawing.Size(127, 26);
            this.dtpPagamento.TabIndex = 28;
            // 
            // lbDataPagamento
            // 
            this.lbDataPagamento.AutoSize = true;
            this.lbDataPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataPagamento.Location = new System.Drawing.Point(300, 209);
            this.lbDataPagamento.Name = "lbDataPagamento";
            this.lbDataPagamento.Size = new System.Drawing.Size(130, 20);
            this.lbDataPagamento.TabIndex = 27;
            this.lbDataPagamento.Text = "Data Pagamento";
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataSource = typeof(ObjetoTransferencia.Fornecedor);
            // 
            // FrmContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 502);
            this.ControlBox = false;
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtidcontaspagar);
            this.Controls.Add(this.dtpEmissao);
            this.Controls.Add(this.dtpVencimento);
            this.Controls.Add(this.GBSituacao);
            this.Controls.Add(this.txtdocumento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txthistorico);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTipodocumento);
            this.Controls.Add(this.lblAdicionar);
            this.Controls.Add(this.Tipopessoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtvalordocumento);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paneldados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmContasPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a pagar";
            this.Load += new System.EventHandler(this.FrmContasPagar_Load);
            this.Tipopessoa.ResumeLayout(false);
            this.Tipopessoa.PerformLayout();
            this.GBSituacao.ResumeLayout(false);
            this.GBSituacao.PerformLayout();
            this.paneldados.ResumeLayout(false);
            this.paneldados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtvalordocumento;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox Tipopessoa;
        private System.Windows.Forms.RadioButton RdbFonecedor;
        private System.Windows.Forms.RadioButton RdbSocio;
        private System.Windows.Forms.Label lblAdicionar;
        private System.Windows.Forms.ComboBox cmbTipodocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txthistorico;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private System.Windows.Forms.TextBox txtdocumento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox GBSituacao;
        private System.Windows.Forms.RadioButton rdbpago;
        private System.Windows.Forms.RadioButton rdbapagar;
        private System.Windows.Forms.DateTimePicker dtpVencimento;
        private System.Windows.Forms.DateTimePicker dtpEmissao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtidcontaspagar;
        private System.Windows.Forms.Panel paneldados;
        private System.Windows.Forms.DateTimePicker dtpPagamento;
        private System.Windows.Forms.Label lbDataPagamento;
    }
}