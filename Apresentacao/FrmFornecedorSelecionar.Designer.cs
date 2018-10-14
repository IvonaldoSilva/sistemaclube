namespace Apresentacao
{
    partial class FrmFornecedorSelecionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFornecedorSelecionar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnfechar = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.dataGridViewFornecedor = new System.Windows.Forms.DataGridView();
            this.ColColdigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coldatanasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColRg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnfechar
            // 
            this.btnfechar.Image = ((System.Drawing.Image)(resources.GetObject("btnfechar.Image")));
            this.btnfechar.Location = new System.Drawing.Point(676, 384);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(75, 81);
            this.btnfechar.TabIndex = 12;
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Location = new System.Drawing.Point(456, 23);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(94, 26);
            this.BtnConsultar.TabIndex = 11;
            this.BtnConsultar.Text = "CONSULTAR";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(594, 384);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 81);
            this.btnExcluir.TabIndex = 10;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(512, 384);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 81);
            this.btnAlterar.TabIndex = 9;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // BtnInserir
            // 
            this.BtnInserir.Image = ((System.Drawing.Image)(resources.GetObject("BtnInserir.Image")));
            this.BtnInserir.Location = new System.Drawing.Point(430, 384);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(75, 81);
            this.BtnInserir.TabIndex = 8;
            this.BtnInserir.UseVisualStyleBackColor = true;
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // dataGridViewFornecedor
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewFornecedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFornecedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColColdigo,
            this.colNome,
            this.ColCpf,
            this.Coldatanasc,
            this.email,
            this.ColRg,
            this.telefone});
            this.dataGridViewFornecedor.Location = new System.Drawing.Point(12, 69);
            this.dataGridViewFornecedor.MultiSelect = false;
            this.dataGridViewFornecedor.Name = "dataGridViewFornecedor";
            this.dataGridViewFornecedor.ReadOnly = true;
            this.dataGridViewFornecedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFornecedor.Size = new System.Drawing.Size(739, 309);
            this.dataGridViewFornecedor.TabIndex = 13;
            this.dataGridViewFornecedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFornecedor_CellContentClick);
            // 
            // ColColdigo
            // 
            this.ColColdigo.DataPropertyName = "IdFornecedor";
            dataGridViewCellStyle2.Format = "#,##,0";
            this.ColColdigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColColdigo.HeaderText = "CODIGO";
            this.ColColdigo.Name = "ColColdigo";
            this.ColColdigo.ReadOnly = true;
            this.ColColdigo.Width = 65;
            // 
            // colNome
            // 
            this.colNome.DataPropertyName = "nome";
            this.colNome.HeaderText = "RAZAO SOCIAL";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 250;
            // 
            // ColCpf
            // 
            this.ColCpf.DataPropertyName = "cnpj";
            dataGridViewCellStyle3.Format = "###-###-###-##";
            this.ColCpf.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColCpf.HeaderText = "C.N.P.J";
            this.ColCpf.Name = "ColCpf";
            this.ColCpf.ReadOnly = true;
            this.ColCpf.Width = 150;
            // 
            // Coldatanasc
            // 
            this.Coldatanasc.DataPropertyName = "endereco";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            this.Coldatanasc.DefaultCellStyle = dataGridViewCellStyle4;
            this.Coldatanasc.HeaderText = "ENDEREÇO";
            this.Coldatanasc.Name = "Coldatanasc";
            this.Coldatanasc.ReadOnly = true;
            this.Coldatanasc.Width = 200;
            // 
            // email
            // 
            this.email.DataPropertyName = "numero";
            this.email.HeaderText = "NUMERO";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 50;
            // 
            // ColRg
            // 
            this.ColRg.DataPropertyName = "cidade";
            this.ColRg.HeaderText = "CIDADE";
            this.ColRg.Name = "ColRg";
            this.ColRg.ReadOnly = true;
            this.ColRg.Width = 150;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            this.telefone.HeaderText = "TELEFONE";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            this.telefone.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Digite um Fornecedor";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(183, 23);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(267, 26);
            this.txtnome.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(556, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 26);
            this.button1.TabIndex = 16;
            this.button1.Text = "SELECIONAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmFornecedorSelecionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 469);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewFornecedor);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.BtnInserir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFornecedorSelecionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SELECIONAR FORNECEDOR";
            this.Load += new System.EventHandler(this.FrmFornecedorSelecionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.DataGridView dataGridViewFornecedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColColdigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coldatanasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRg;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
    }
}