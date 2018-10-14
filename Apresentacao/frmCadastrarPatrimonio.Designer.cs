namespace Apresentacao
{
    partial class frmCadastrarPatrimonio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarPatrimonio));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcodigopatrimonio = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.cmbtipo = new System.Windows.Forms.ComboBox();
            this.tipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpAquisicao = new System.Windows.Forms.DateTimePicker();
            this.lblAdicionarTipo = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.quantidade = new System.Windows.Forms.TextBox();
            this.cmbSituacao = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).BeginInit();
            this.panelBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dt.  Aquisição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria";
            // 
            // txtcodigopatrimonio
            // 
            this.txtcodigopatrimonio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigopatrimonio.Location = new System.Drawing.Point(129, 12);
            this.txtcodigopatrimonio.Name = "txtcodigopatrimonio";
            this.txtcodigopatrimonio.ReadOnly = true;
            this.txtcodigopatrimonio.Size = new System.Drawing.Size(76, 26);
            this.txtcodigopatrimonio.TabIndex = 0;
            this.txtcodigopatrimonio.TabStop = false;
            // 
            // txtdescricao
            // 
            this.txtdescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescricao.Location = new System.Drawing.Point(129, 118);
            this.txtdescricao.MaxLength = 150;
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.ReadOnly = true;
            this.txtdescricao.Size = new System.Drawing.Size(421, 26);
            this.txtdescricao.TabIndex = 5;
            this.txtdescricao.TextChanged += new System.EventHandler(this.txtdescricao_TextChanged);
            // 
            // cmbtipo
            // 
            this.cmbtipo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.tipoBindingSource, "Idtipo", true));
            this.cmbtipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipo.Enabled = false;
            this.cmbtipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtipo.FormattingEnabled = true;
            this.cmbtipo.Location = new System.Drawing.Point(129, 45);
            this.cmbtipo.Name = "cmbtipo";
            this.cmbtipo.Size = new System.Drawing.Size(345, 28);
            this.cmbtipo.TabIndex = 1;
            
            this.cmbtipo.Click += new System.EventHandler(this.cmbtipo_Click);
            this.cmbtipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbtipo_KeyPress_1);
            this.cmbtipo.Leave += new System.EventHandler(this.cmbtipo_Leave);
            // 
            // tipoBindingSource
            // 
            this.tipoBindingSource.DataSource = typeof(ObjetoTransferencia.Tipo);
            // 
            // dtpAquisicao
            // 
            this.dtpAquisicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAquisicao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAquisicao.Location = new System.Drawing.Point(129, 155);
            this.dtpAquisicao.Name = "dtpAquisicao";
            this.dtpAquisicao.Size = new System.Drawing.Size(131, 26);
            this.dtpAquisicao.TabIndex = 6;
            // 
            // lblAdicionarTipo
            // 
            this.lblAdicionarTipo.AutoSize = true;
            this.lblAdicionarTipo.Enabled = false;
            this.lblAdicionarTipo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionarTipo.Location = new System.Drawing.Point(491, 50);
            this.lblAdicionarTipo.Name = "lblAdicionarTipo";
            this.lblAdicionarTipo.Size = new System.Drawing.Size(19, 23);
            this.lblAdicionarTipo.TabIndex = 3;
            this.lblAdicionarTipo.Text = "+";
            this.lblAdicionarTipo.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(19, 12);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 82);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click_1);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(100, 14);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 82);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Click += new System.EventHandler(this.Salvar_Click_1);
            // 
            // panelBotoes
            // 
            this.panelBotoes.Controls.Add(this.btnSair);
            this.panelBotoes.Controls.Add(this.btnAdicionar);
            this.panelBotoes.Controls.Add(this.btnSalvar);
            this.panelBotoes.Location = new System.Drawing.Point(12, 245);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(543, 110);
            this.panelBotoes.TabIndex = 13;
            this.panelBotoes.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(181, 14);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 82);
            this.btnSair.TabIndex = 0;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Quantidade";
            // 
            // quantidade
            // 
            this.quantidade.Enabled = false;
            this.quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidade.Location = new System.Drawing.Point(129, 78);
            this.quantidade.MaxLength = 5;
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            this.quantidade.Size = new System.Drawing.Size(76, 26);
            this.quantidade.TabIndex = 4;
            this.quantidade.TextChanged += new System.EventHandler(this.quantidade_TextChanged);
            this.quantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantidade_KeyPress);
            // 
            // cmbSituacao
            // 
            this.cmbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSituacao.Enabled = false;
            this.cmbSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSituacao.FormattingEnabled = true;
            this.cmbSituacao.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cmbSituacao.Location = new System.Drawing.Point(129, 198);
            this.cmbSituacao.Name = "cmbSituacao";
            this.cmbSituacao.Size = new System.Drawing.Size(170, 28);
            this.cmbSituacao.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Situação";
            // 
            // frmCadastrarPatrimonio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 356);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSituacao);
            this.Controls.Add(this.quantidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panelBotoes);
            this.Controls.Add(this.lblAdicionarTipo);
            this.Controls.Add(this.dtpAquisicao);
            this.Controls.Add(this.cmbtipo);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.txtcodigopatrimonio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmCadastrarPatrimonio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Cadastramento  de Patrimonio";
            this.Load += new System.EventHandler(this.frmCadastrarPatrimonio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).EndInit();
            this.panelBotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcodigopatrimonio;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.ComboBox cmbtipo;
        private System.Windows.Forms.DateTimePicker dtpAquisicao;
        private System.Windows.Forms.Label lblAdicionarTipo;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox quantidade;
        private System.Windows.Forms.ComboBox cmbSituacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource tipoBindingSource;
    }
}