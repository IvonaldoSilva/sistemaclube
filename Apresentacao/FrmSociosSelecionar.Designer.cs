namespace Apresentacao
{
    partial class FrmSociosSelecionar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSociosSelecionar));
            this.LabelPesquisa = new System.Windows.Forms.Label();
            this.textBoxPequisa = new System.Windows.Forms.TextBox();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.dataGridViewPrincipal = new System.Windows.Forms.DataGridView();
            this.ColColdigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coldatanasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAdmissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnfechar = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.Selecionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelPesquisa
            // 
            this.LabelPesquisa.AutoSize = true;
            this.LabelPesquisa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPesquisa.Location = new System.Drawing.Point(13, 13);
            this.LabelPesquisa.Name = "LabelPesquisa";
            this.LabelPesquisa.Size = new System.Drawing.Size(104, 20);
            this.LabelPesquisa.TabIndex = 8;
            this.LabelPesquisa.Text = "Nome do Socio";
            // 
            // textBoxPequisa
            // 
            this.textBoxPequisa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPequisa.Location = new System.Drawing.Point(122, 9);
            this.textBoxPequisa.Name = "textBoxPequisa";
            this.textBoxPequisa.Size = new System.Drawing.Size(392, 26);
            this.textBoxPequisa.TabIndex = 0;
            this.textBoxPequisa.TextChanged += new System.EventHandler(this.textBoxPequisa_TextChanged);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Location = new System.Drawing.Point(520, 8);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(91, 27);
            this.btnPesquisa.TabIndex = 1;
            this.btnPesquisa.Text = "&Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // dataGridViewPrincipal
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewPrincipal.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColColdigo,
            this.colNome,
            this.ColCpf,
            this.Coldatanasc,
            this.email,
            this.ColRg,
            this.telefone,
            this.ColSexo,
            this.ColEndereco,
            this.ColNumero,
            this.ColBairro,
            this.ColCidade,
            this.ColCep,
            this.ColEstado,
            this.ColAdmissao});
            this.dataGridViewPrincipal.Location = new System.Drawing.Point(3, 48);
            this.dataGridViewPrincipal.MultiSelect = false;
            this.dataGridViewPrincipal.Name = "dataGridViewPrincipal";
            this.dataGridViewPrincipal.ReadOnly = true;
            this.dataGridViewPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPrincipal.Size = new System.Drawing.Size(760, 326);
            this.dataGridViewPrincipal.TabIndex = 3;
            this.dataGridViewPrincipal.RowsDefaultCellStyleChanged += new System.EventHandler(this.dataGridViewPrincipal_RowsDefaultCellStyleChanged);
            this.dataGridViewPrincipal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrincipal_CellContentClick);
            this.dataGridViewPrincipal.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrincipal_CellContentDoubleClick);
            this.dataGridViewPrincipal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrincipal_CellDoubleClick);
            this.dataGridViewPrincipal.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridViewPrincipal_RowStateChanged);
            // 
            // ColColdigo
            // 
            this.ColColdigo.DataPropertyName = "IDpessoa";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "#,##,0";
            this.ColColdigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColColdigo.HeaderText = "Código";
            this.ColColdigo.Name = "ColColdigo";
            this.ColColdigo.ReadOnly = true;
            this.ColColdigo.Width = 65;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "Nome";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colNome.DefaultCellStyle = dataGridViewCellStyle3;
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 200;
            // 
            // ColCpf
            // 
            this.ColCpf.DataPropertyName = "cpf";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "###-###-###-##";
            this.ColCpf.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColCpf.HeaderText = "C.P.F";
            this.ColCpf.Name = "ColCpf";
            this.ColCpf.ReadOnly = true;
            // 
            // Coldatanasc
            // 
            this.Coldatanasc.DataPropertyName = "datanasc";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Format = "dd/MM/yyyy";
            this.Coldatanasc.DefaultCellStyle = dataGridViewCellStyle5;
            this.Coldatanasc.HeaderText = "Dt.  Nascimento";
            this.Coldatanasc.Name = "Coldatanasc";
            this.Coldatanasc.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.email.DefaultCellStyle = dataGridViewCellStyle6;
            this.email.HeaderText = "E - mail";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 180;
            // 
            // ColRg
            // 
            this.ColRg.DataPropertyName = "rg";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColRg.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColRg.HeaderText = "R.G";
            this.ColRg.Name = "ColRg";
            this.ColRg.ReadOnly = true;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.telefone.DefaultCellStyle = dataGridViewCellStyle8;
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            // 
            // ColSexo
            // 
            this.ColSexo.DataPropertyName = "sexo";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColSexo.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColSexo.HeaderText = "Sexo";
            this.ColSexo.Name = "ColSexo";
            this.ColSexo.ReadOnly = true;
            // 
            // ColEndereco
            // 
            this.ColEndereco.DataPropertyName = "endereco";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColEndereco.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColEndereco.HeaderText = "Endereço";
            this.ColEndereco.Name = "ColEndereco";
            this.ColEndereco.ReadOnly = true;
            this.ColEndereco.Width = 200;
            // 
            // ColNumero
            // 
            this.ColNumero.DataPropertyName = "numero";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColNumero.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColNumero.HeaderText = "Numero";
            this.ColNumero.Name = "ColNumero";
            this.ColNumero.ReadOnly = true;
            this.ColNumero.Width = 65;
            // 
            // ColBairro
            // 
            this.ColBairro.DataPropertyName = "bairro";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColBairro.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColBairro.HeaderText = "Bairro";
            this.ColBairro.Name = "ColBairro";
            this.ColBairro.ReadOnly = true;
            this.ColBairro.Width = 150;
            // 
            // ColCidade
            // 
            this.ColCidade.DataPropertyName = "cidade";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColCidade.DefaultCellStyle = dataGridViewCellStyle13;
            this.ColCidade.HeaderText = "Cidade";
            this.ColCidade.Name = "ColCidade";
            this.ColCidade.ReadOnly = true;
            this.ColCidade.Width = 150;
            // 
            // ColCep
            // 
            this.ColCep.DataPropertyName = "cep";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColCep.DefaultCellStyle = dataGridViewCellStyle14;
            this.ColCep.HeaderText = "C.E.P";
            this.ColCep.Name = "ColCep";
            this.ColCep.ReadOnly = true;
            // 
            // ColEstado
            // 
            this.ColEstado.DataPropertyName = "estado";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColEstado.DefaultCellStyle = dataGridViewCellStyle15;
            this.ColEstado.HeaderText = "Estado";
            this.ColEstado.Name = "ColEstado";
            this.ColEstado.ReadOnly = true;
            // 
            // ColAdmissao
            // 
            this.ColAdmissao.DataPropertyName = "admissao";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.Format = "dd/MM/yyyy";
            this.ColAdmissao.DefaultCellStyle = dataGridViewCellStyle16;
            this.ColAdmissao.HeaderText = "Admissão";
            this.ColAdmissao.Name = "ColAdmissao";
            this.ColAdmissao.ReadOnly = true;
            // 
            // btnfechar
            // 
            this.btnfechar.Image = ((System.Drawing.Image)(resources.GetObject("btnfechar.Image")));
            this.btnfechar.Location = new System.Drawing.Point(682, 380);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(75, 81);
            this.btnfechar.TabIndex = 8;
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("BtnConsultar.Image")));
            this.BtnConsultar.Location = new System.Drawing.Point(601, 380);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(75, 81);
            this.BtnConsultar.TabIndex = 7;
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(518, 380);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 81);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(435, 380);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 81);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // BtnInserir
            // 
            this.BtnInserir.Image = ((System.Drawing.Image)(resources.GetObject("BtnInserir.Image")));
            this.BtnInserir.Location = new System.Drawing.Point(352, 380);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(75, 81);
            this.BtnInserir.TabIndex = 4;
            this.BtnInserir.UseVisualStyleBackColor = true;
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // Selecionar
            // 
            this.Selecionar.Enabled = false;
            this.Selecionar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selecionar.Location = new System.Drawing.Point(617, 8);
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.Size = new System.Drawing.Size(93, 27);
            this.Selecionar.TabIndex = 2;
            this.Selecionar.Text = "&Selecionar";
            this.Selecionar.UseVisualStyleBackColor = true;
            this.Selecionar.Click += new System.EventHandler(this.Selecionar_Click);
            // 
            // FrmSociosSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 473);
            this.ControlBox = false;
            this.Controls.Add(this.Selecionar);
            this.Controls.Add(this.dataGridViewPrincipal);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.BtnInserir);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.textBoxPequisa);
            this.Controls.Add(this.LabelPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSociosSelecionar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Socios";
            this.Load += new System.EventHandler(this.FrmSociosSelecionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPesquisa;
        private System.Windows.Forms.TextBox textBoxPequisa;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.DataGridView dataGridViewPrincipal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColColdigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coldatanasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRg;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEndereco;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAdmissao;
        private System.Windows.Forms.Button Selecionar;
    }
}