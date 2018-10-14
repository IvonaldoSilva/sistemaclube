namespace Apresentacao
{
    partial class FrmConsultaUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.dataGridViewUsuario = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(12, 16);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(118, 20);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "Nome  do Usuario";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(136, 13);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(237, 26);
            this.txtnome.TabIndex = 1;
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisar.Location = new System.Drawing.Point(391, 11);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(89, 28);
            this.btnpesquisar.TabIndex = 2;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // dataGridViewUsuario
            // 
            this.dataGridViewUsuario.AllowUserToOrderColumns = true;
            this.dataGridViewUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUsuario,
            this.nome,
            this.senha,
            this.perfil});
            this.dataGridViewUsuario.Location = new System.Drawing.Point(29, 57);
            this.dataGridViewUsuario.MultiSelect = false;
            this.dataGridViewUsuario.Name = "dataGridViewUsuario";
            this.dataGridViewUsuario.ReadOnly = true;
            this.dataGridViewUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsuario.Size = new System.Drawing.Size(451, 207);
            this.dataGridViewUsuario.TabIndex = 3;
            this.dataGridViewUsuario.RowsDefaultCellStyleChanged += new System.EventHandler(this.dataGridViewUsuario_RowsDefaultCellStyleChanged);
            this.dataGridViewUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsuario_CellContentClick);
            this.dataGridViewUsuario.RowDefaultCellStyleChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridViewUsuario_RowDefaultCellStyleChanged);
            this.dataGridViewUsuario.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridViewUsuario_RowStateChanged);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(409, 270);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 75);
            this.btnSair.TabIndex = 6;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(327, 271);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 75);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // btncadastrar
            // 
            this.btncadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btncadastrar.Image")));
            this.btncadastrar.Location = new System.Drawing.Point(246, 271);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(75, 75);
            this.btncadastrar.TabIndex = 4;
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // IdUsuario
            // 
            this.IdUsuario.DataPropertyName = "IdUsuario";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.IdUsuario.DefaultCellStyle = dataGridViewCellStyle1;
            this.IdUsuario.HeaderText = "Cod.";
            this.IdUsuario.Name = "IdUsuario";
            this.IdUsuario.ReadOnly = true;
            this.IdUsuario.Width = 50;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Usuario";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // senha
            // 
            this.senha.DataPropertyName = "senha";
            this.senha.HeaderText = "Senha";
            this.senha.Name = "senha";
            this.senha.ReadOnly = true;
            // 
            // perfil
            // 
            this.perfil.DataPropertyName = "perfil";
            this.perfil.HeaderText = "Perfil de User";
            this.perfil.Name = "perfil";
            this.perfil.ReadOnly = true;
            // 
            // FrmConsultaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 358);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.dataGridViewUsuario);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblnome);
            this.Name = "FrmConsultaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Usuario do Sistema";
            this.Load += new System.EventHandler(this.FrmConsultaUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.DataGridView dataGridViewUsuario;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfil;
    }
}