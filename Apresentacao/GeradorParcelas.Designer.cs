namespace Apresentacao
{
    partial class GeradorParcelas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.codSocio = new System.Windows.Forms.TextBox();
            this.nomeSocio = new System.Windows.Forms.TextBox();
            this.valorContrato = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DgVparcelas = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btngerar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDataEmissao = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.AdicionarSocio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CodParcelas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgVparcelas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Codigo";
            // 
            // codSocio
            // 
            this.codSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codSocio.Location = new System.Drawing.Point(10, 98);
            this.codSocio.Name = "codSocio";
            this.codSocio.Size = new System.Drawing.Size(88, 26);
            this.codSocio.TabIndex = 30;
            this.codSocio.TabStop = false;
            this.codSocio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codSocio_KeyPress);
            // 
            // nomeSocio
            // 
            this.nomeSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeSocio.Location = new System.Drawing.Point(104, 98);
            this.nomeSocio.Name = "nomeSocio";
            this.nomeSocio.ReadOnly = true;
            this.nomeSocio.Size = new System.Drawing.Size(390, 26);
            this.nomeSocio.TabIndex = 31;
            this.nomeSocio.TabStop = false;
            // 
            // valorContrato
            // 
            this.valorContrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorContrato.Location = new System.Drawing.Point(10, 155);
            this.valorContrato.Name = "valorContrato";
            this.valorContrato.ReadOnly = true;
            this.valorContrato.Size = new System.Drawing.Size(171, 26);
            this.valorContrato.TabIndex = 32;
            this.valorContrato.TabStop = false;
            this.valorContrato.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.valorContrato.TextChanged += new System.EventHandler(this.valorContrato_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Vl do Contrato";
            // 
            // DgVparcelas
            // 
            this.DgVparcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgVparcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column5,
            this.Column1});
            this.DgVparcelas.Location = new System.Drawing.Point(8, 244);
            this.DgVparcelas.MultiSelect = false;
            this.DgVparcelas.Name = "DgVparcelas";
            this.DgVparcelas.ReadOnly = true;
            this.DgVparcelas.Size = new System.Drawing.Size(726, 324);
            this.DgVparcelas.TabIndex = 34;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "IDpessoas";
            this.Column2.HeaderText = "Cod.Socio";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "nome";
            this.Column3.HeaderText = "Nome";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 300;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "numeroparcelas";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Format = "0000";
            dataGridViewCellStyle4.NullValue = null;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column6.HeaderText = "Numero Parcela";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "valormensalidade";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column4.HeaderText = "Valor Parcela";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "vencimento";
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column5.HeaderText = "Data Vencimento";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "situacao";
            this.Column1.HeaderText = "Status";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 50;
            // 
            // btngerar
            // 
            this.btngerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngerar.Location = new System.Drawing.Point(10, 195);
            this.btngerar.Name = "btngerar";
            this.btngerar.Size = new System.Drawing.Size(132, 26);
            this.btngerar.TabIndex = 35;
            this.btngerar.Text = "Gerar";
            this.btngerar.UseVisualStyleBackColor = true;
            this.btngerar.Click += new System.EventHandler(this.btngerar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.Location = new System.Drawing.Point(148, 195);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(141, 26);
            this.BtnSalvar.TabIndex = 36;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(295, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 26);
            this.button1.TabIndex = 38;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDataEmissao
            // 
            this.txtDataEmissao.Enabled = false;
            this.txtDataEmissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataEmissao.Location = new System.Drawing.Point(187, 155);
            this.txtDataEmissao.Name = "txtDataEmissao";
            this.txtDataEmissao.Size = new System.Drawing.Size(125, 26);
            this.txtDataEmissao.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Dt. do Contrato";
            // 
            // AdicionarSocio
            // 
            this.AdicionarSocio.AutoSize = true;
            this.AdicionarSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdicionarSocio.Location = new System.Drawing.Point(500, 100);
            this.AdicionarSocio.Name = "AdicionarSocio";
            this.AdicionarSocio.Size = new System.Drawing.Size(21, 24);
            this.AdicionarSocio.TabIndex = 41;
            this.AdicionarSocio.Text = "+";
            this.AdicionarSocio.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Socio";
            // 
            // CodParcelas
            // 
            this.CodParcelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodParcelas.Location = new System.Drawing.Point(10, 32);
            this.CodParcelas.Name = "CodParcelas";
            this.CodParcelas.ReadOnly = true;
            this.CodParcelas.Size = new System.Drawing.Size(88, 26);
            this.CodParcelas.TabIndex = 44;
            this.CodParcelas.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Cod.";
            // 
            // GeradorParcelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 573);
            this.ControlBox = false;
            this.Controls.Add(this.CodParcelas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AdicionarSocio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDataEmissao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.btngerar);
            this.Controls.Add(this.DgVparcelas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valorContrato);
            this.Controls.Add(this.nomeSocio);
            this.Controls.Add(this.codSocio);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "GeradorParcelas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeradorParcelas";
            this.Load += new System.EventHandler(this.GeradorParcelas_Load);
            this.Click += new System.EventHandler(this.GeradorParcelas_Click);
            ((System.ComponentModel.ISupportInitialize)(this.DgVparcelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codSocio;
        private System.Windows.Forms.TextBox nomeSocio;
        private System.Windows.Forms.TextBox valorContrato;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgVparcelas;
        private System.Windows.Forms.Button btngerar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker txtDataEmissao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AdicionarSocio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CodParcelas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
    }
}