namespace Apresentacao
{
    partial class FrmCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaixa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GBMovCaixa = new System.Windows.Forms.GroupBox();
            this.rdbSaida = new System.Windows.Forms.RadioButton();
            this.rdbentrada = new System.Windows.Forms.RadioButton();
            this.txtidcaixa = new System.Windows.Forms.TextBox();
            this.dtpdata = new System.Windows.Forms.DateTimePicker();
            this.cmbnumerario = new System.Windows.Forms.ComboBox();
            this.codSocio = new System.Windows.Forms.TextBox();
            this.nomeSocio = new System.Windows.Forms.TextBox();
            this.mktdatemissao = new System.Windows.Forms.MaskedTextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.cmbtipodocumento = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.gbtipopessoa = new System.Windows.Forms.GroupBox();
            this.rdbjuridica = new System.Windows.Forms.RadioButton();
            this.rdbfisica = new System.Windows.Forms.RadioButton();
            this.lbAdicionar = new System.Windows.Forms.Label();
            this.GBMovCaixa.SuspendLayout();
            this.gbtipopessoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dt Entrada/Saida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo Numerario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Codigo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fornecedor/Socio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data Emissao ";
            // 
            // GBMovCaixa
            // 
            this.GBMovCaixa.Controls.Add(this.rdbSaida);
            this.GBMovCaixa.Controls.Add(this.rdbentrada);
            this.GBMovCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBMovCaixa.Location = new System.Drawing.Point(389, 12);
            this.GBMovCaixa.Name = "GBMovCaixa";
            this.GBMovCaixa.Size = new System.Drawing.Size(240, 73);
            this.GBMovCaixa.TabIndex = 6;
            this.GBMovCaixa.TabStop = false;
            this.GBMovCaixa.Text = "Tipo de Entrada";
            // 
            // rdbSaida
            // 
            this.rdbSaida.AutoSize = true;
            this.rdbSaida.Checked = true;
            this.rdbSaida.Location = new System.Drawing.Point(157, 25);
            this.rdbSaida.Name = "rdbSaida";
            this.rdbSaida.Size = new System.Drawing.Size(68, 24);
            this.rdbSaida.TabIndex = 1;
            this.rdbSaida.TabStop = true;
            this.rdbSaida.Text = "Saída";
            this.rdbSaida.UseVisualStyleBackColor = true;
            // 
            // rdbentrada
            // 
            this.rdbentrada.AutoSize = true;
            this.rdbentrada.Location = new System.Drawing.Point(26, 25);
            this.rdbentrada.Name = "rdbentrada";
            this.rdbentrada.Size = new System.Drawing.Size(84, 24);
            this.rdbentrada.TabIndex = 0;
            this.rdbentrada.Text = "Entrada";
            this.rdbentrada.UseVisualStyleBackColor = true;
            // 
            // txtidcaixa
            // 
            this.txtidcaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidcaixa.Location = new System.Drawing.Point(61, 37);
            this.txtidcaixa.Name = "txtidcaixa";
            this.txtidcaixa.ReadOnly = true;
            this.txtidcaixa.Size = new System.Drawing.Size(78, 26);
            this.txtidcaixa.TabIndex = 7;
            // 
            // dtpdata
            // 
            this.dtpdata.Enabled = false;
            this.dtpdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdata.Location = new System.Drawing.Point(61, 91);
            this.dtpdata.Name = "dtpdata";
            this.dtpdata.Size = new System.Drawing.Size(109, 26);
            this.dtpdata.TabIndex = 0;
            // 
            // cmbnumerario
            // 
            this.cmbnumerario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbnumerario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbnumerario.FormattingEnabled = true;
            this.cmbnumerario.Items.AddRange(new object[] {
            "DINHEIRO",
            " CHEQUE",
            ""});
            this.cmbnumerario.Location = new System.Drawing.Point(190, 91);
            this.cmbnumerario.Name = "cmbnumerario";
            this.cmbnumerario.Size = new System.Drawing.Size(131, 28);
            this.cmbnumerario.TabIndex = 1;
            // 
            // codSocio
            // 
            this.codSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codSocio.Location = new System.Drawing.Point(61, 235);
            this.codSocio.Name = "codSocio";
            this.codSocio.Size = new System.Drawing.Size(69, 26);
            this.codSocio.TabIndex = 2;
            this.codSocio.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            this.codSocio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            this.codSocio.Leave += new System.EventHandler(this.codSocio_Leave);
            // 
            // nomeSocio
            // 
            this.nomeSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeSocio.Location = new System.Drawing.Point(136, 235);
            this.nomeSocio.Name = "nomeSocio";
            this.nomeSocio.ReadOnly = true;
            this.nomeSocio.Size = new System.Drawing.Size(450, 26);
            this.nomeSocio.TabIndex = 3;
            // 
            // mktdatemissao
            // 
            this.mktdatemissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mktdatemissao.Location = new System.Drawing.Point(61, 293);
            this.mktdatemissao.Mask = "00/00/0000";
            this.mktdatemissao.Name = "mktdatemissao";
            this.mktdatemissao.Size = new System.Drawing.Size(109, 26);
            this.mktdatemissao.TabIndex = 5;
            this.mktdatemissao.ValidatingType = typeof(System.DateTime);
            this.mktdatemissao.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mktdatemissao_MaskInputRejected);
            this.mktdatemissao.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.mktdatemissao_TypeValidationCompleted);
            this.mktdatemissao.Leave += new System.EventHandler(this.mktdatemissao_Leave);
            // 
            // txtvalor
            // 
            this.txtvalor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor.Location = new System.Drawing.Point(190, 293);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(131, 26);
            this.txtvalor.TabIndex = 6;
            this.txtvalor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalor_KeyPress);
            // 
            // cmbtipodocumento
            // 
            this.cmbtipodocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipodocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtipodocumento.FormattingEnabled = true;
            this.cmbtipodocumento.Items.AddRange(new object[] {
            "BOLETO",
            "VALES",
            "NOTA FISCAL"});
            this.cmbtipodocumento.Location = new System.Drawing.Point(339, 293);
            this.cmbtipodocumento.Name = "cmbtipodocumento";
            this.cmbtipodocumento.Size = new System.Drawing.Size(163, 28);
            this.cmbtipodocumento.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(193, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Valor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(335, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "tipo Documento";
            // 
            // btnsalvar
            // 
            this.btnsalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnsalvar.Image")));
            this.btnsalvar.Location = new System.Drawing.Point(21, 344);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 74);
            this.btnsalvar.TabIndex = 11;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.Location = new System.Drawing.Point(102, 344);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(75, 74);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click_1);
            // 
            // gbtipopessoa
            // 
            this.gbtipopessoa.Controls.Add(this.rdbjuridica);
            this.gbtipopessoa.Controls.Add(this.rdbfisica);
            this.gbtipopessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtipopessoa.Location = new System.Drawing.Point(20, 135);
            this.gbtipopessoa.Name = "gbtipopessoa";
            this.gbtipopessoa.Size = new System.Drawing.Size(301, 60);
            this.gbtipopessoa.TabIndex = 7;
            this.gbtipopessoa.TabStop = false;
            this.gbtipopessoa.Text = "Tipo Pessoa";
            // 
            // rdbjuridica
            // 
            this.rdbjuridica.AutoSize = true;
            this.rdbjuridica.Location = new System.Drawing.Point(177, 25);
            this.rdbjuridica.Name = "rdbjuridica";
            this.rdbjuridica.Size = new System.Drawing.Size(81, 24);
            this.rdbjuridica.TabIndex = 1;
            this.rdbjuridica.Text = "Juridica";
            this.rdbjuridica.UseVisualStyleBackColor = true;
            // 
            // rdbfisica
            // 
            this.rdbfisica.AutoSize = true;
            this.rdbfisica.Location = new System.Drawing.Point(41, 25);
            this.rdbfisica.Name = "rdbfisica";
            this.rdbfisica.Size = new System.Drawing.Size(68, 24);
            this.rdbfisica.TabIndex = 0;
            this.rdbfisica.Text = "Fisica";
            this.rdbfisica.UseVisualStyleBackColor = true;
            // 
            // lbAdicionar
            // 
            this.lbAdicionar.AutoSize = true;
            this.lbAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdicionar.Location = new System.Drawing.Point(592, 237);
            this.lbAdicionar.Name = "lbAdicionar";
            this.lbAdicionar.Size = new System.Drawing.Size(22, 24);
            this.lbAdicionar.TabIndex = 4;
            this.lbAdicionar.Text = "+";
            this.lbAdicionar.Click += new System.EventHandler(this.lbAdicionar_Click);
            // 
            // FrmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 439);
            this.ControlBox = false;
            this.Controls.Add(this.lbAdicionar);
            this.Controls.Add(this.gbtipopessoa);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbtipodocumento);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.mktdatemissao);
            this.Controls.Add(this.nomeSocio);
            this.Controls.Add(this.codSocio);
            this.Controls.Add(this.cmbnumerario);
            this.Controls.Add(this.dtpdata);
            this.Controls.Add(this.txtidcaixa);
            this.Controls.Add(this.GBMovCaixa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimento de Caixa";
            this.Load += new System.EventHandler(this.FrmCaixa_Load);
            this.GBMovCaixa.ResumeLayout(false);
            this.GBMovCaixa.PerformLayout();
            this.gbtipopessoa.ResumeLayout(false);
            this.gbtipopessoa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox GBMovCaixa;
        private System.Windows.Forms.RadioButton rdbSaida;
        private System.Windows.Forms.RadioButton rdbentrada;
        private System.Windows.Forms.TextBox txtidcaixa;
        private System.Windows.Forms.DateTimePicker dtpdata;
        private System.Windows.Forms.ComboBox cmbnumerario;
        private System.Windows.Forms.TextBox codSocio;
        private System.Windows.Forms.TextBox nomeSocio;
        private System.Windows.Forms.MaskedTextBox mktdatemissao;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.ComboBox cmbtipodocumento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.GroupBox gbtipopessoa;
        private System.Windows.Forms.RadioButton rdbjuridica;
        private System.Windows.Forms.RadioButton rdbfisica;
        private System.Windows.Forms.Label lbAdicionar;
    }
}