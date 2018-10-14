namespace Apresentacao
{
    partial class FrmSelecionarDependente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelecionarDependente));
            this.label1 = new System.Windows.Forms.Label();
            this.codSocio = new System.Windows.Forms.TextBox();
            this.dataGridViewDep = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnpesquisardep = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomeSocio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricula do Titular";
            // 
            // codSocio
            // 
            this.codSocio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codSocio.Location = new System.Drawing.Point(140, 4);
            this.codSocio.Name = "codSocio";
            this.codSocio.Size = new System.Drawing.Size(72, 26);
            this.codSocio.TabIndex = 1;
            this.codSocio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MatriculaTxt_KeyPress);
            // 
            // dataGridViewDep
            // 
            this.dataGridViewDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewDep.Location = new System.Drawing.Point(16, 51);
            this.dataGridViewDep.MultiSelect = false;
            this.dataGridViewDep.Name = "dataGridViewDep";
            this.dataGridViewDep.ReadOnly = true;
            this.dataGridViewDep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDep.Size = new System.Drawing.Size(645, 213);
            this.dataGridViewDep.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdDep";
            this.Column1.HeaderText = "Cod Dep.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "IDpessoa";
            this.Column2.HeaderText = "Matr. Titular";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 50;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "nome";
            this.Column3.HeaderText = "Nome";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "datanasc";
            this.Column4.HeaderText = "Data Nasc";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "graudep";
            this.Column5.HeaderText = "Grau Dep.";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "estadocivil";
            this.Column6.HeaderText = "Estado Civil";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btnpesquisardep
            // 
            this.btnpesquisardep.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisardep.Location = new System.Drawing.Point(480, 4);
            this.btnpesquisardep.Name = "btnpesquisardep";
            this.btnpesquisardep.Size = new System.Drawing.Size(75, 26);
            this.btnpesquisardep.TabIndex = 3;
            this.btnpesquisardep.Text = "Pesquisar";
            this.btnpesquisardep.UseVisualStyleBackColor = true;
            this.btnpesquisardep.UseWaitCursor = true;
            this.btnpesquisardep.Click += new System.EventHandler(this.btnpesquisardep_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(586, 287);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 75);
            this.btnSair.TabIndex = 9;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(424, 288);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 75);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btncadastrar
            // 
            this.btncadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btncadastrar.Image")));
            this.btncadastrar.Location = new System.Drawing.Point(343, 288);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(75, 75);
            this.btncadastrar.TabIndex = 7;
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(505, 287);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 75);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(ObjetoTransferencia.Usuario);
            // 
            // nomeSocio
            // 
            this.nomeSocio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeSocio.Location = new System.Drawing.Point(218, 4);
            this.nomeSocio.Name = "nomeSocio";
            this.nomeSocio.ReadOnly = true;
            this.nomeSocio.Size = new System.Drawing.Size(256, 26);
            this.nomeSocio.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(561, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "+";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmSelecionarDependente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 385);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomeSocio);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.btnpesquisardep);
            this.Controls.Add(this.dataGridViewDep);
            this.Controls.Add(this.codSocio);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSelecionarDependente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Dependentes";
            this.Load += new System.EventHandler(this.FrmSelecionarDependente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codSocio;
        private System.Windows.Forms.DataGridView dataGridViewDep;
        private System.Windows.Forms.Button btnpesquisardep;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.TextBox nomeSocio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}