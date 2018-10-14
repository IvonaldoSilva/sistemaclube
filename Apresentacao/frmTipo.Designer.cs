namespace Apresentacao
{
    partial class frmTipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTipo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.dgvtipo = new System.Windows.Forms.DataGridView();
            this.idtipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnpesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtipo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adicionar nova Categoria ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Enabled = false;
            this.txtcodigo.Location = new System.Drawing.Point(102, 42);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(57, 20);
            this.txtcodigo.TabIndex = 3;
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(102, 68);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(244, 20);
            this.txtdescricao.TabIndex = 4;
            // 
            // btnexcluir
            // 
            this.btnexcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnexcluir.Image")));
            this.btnexcluir.Location = new System.Drawing.Point(190, 118);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 81);
            this.btnexcluir.TabIndex = 7;
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnsair
            // 
            this.btnsair.Image = ((System.Drawing.Image)(resources.GetObject("btnsair.Image")));
            this.btnsair.Location = new System.Drawing.Point(271, 118);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 81);
            this.btnsair.TabIndex = 8;
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnsalvar.Image")));
            this.btnsalvar.Location = new System.Drawing.Point(109, 118);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 81);
            this.btnsalvar.TabIndex = 5;
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // dgvtipo
            // 
            this.dgvtipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtipo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtipo,
            this.descricao});
            this.dgvtipo.Location = new System.Drawing.Point(5, 205);
            this.dgvtipo.MultiSelect = false;
            this.dgvtipo.Name = "dgvtipo";
            this.dgvtipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtipo.Size = new System.Drawing.Size(355, 204);
            this.dgvtipo.TabIndex = 9;
            this.dgvtipo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtipo_CellContentClick);
            this.dgvtipo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvtipo_CellDoubleClick);
            // 
            // idtipo
            // 
            this.idtipo.DataPropertyName = "idtipo";
            this.idtipo.HeaderText = "Codigo";
            this.idtipo.Name = "idtipo";
            this.idtipo.ReadOnly = true;
            this.idtipo.Width = 50;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "descricao";
            this.descricao.HeaderText = "Descricao";
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 230;
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnpesquisar.Image")));
            this.btnpesquisar.Location = new System.Drawing.Point(28, 118);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(75, 81);
            this.btnpesquisar.TabIndex = 10;
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click_1);
            // 
            // frmTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 421);
            this.ControlBox = false;
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.dgvtipo);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastramento de Tipo de Bens";
            this.Load += new System.EventHandler(this.frmTipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.DataGridView dgvtipo;
        private System.Windows.Forms.Button btnpesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricao;
    }
}