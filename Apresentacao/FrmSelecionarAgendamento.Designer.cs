namespace Apresentacao
{
    partial class FrmSelecionarAgendamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelecionarAgendamento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvAgenda = new System.Windows.Forms.DataGridView();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.lbData = new System.Windows.Forms.Label();
            this.btnfechar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.BtnInserir = new System.Windows.Forms.Button();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.idagendamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horainicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horafinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDpessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvAgenda
            // 
            this.DgvAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idagendamento,
            this.situacao,
            this.data,
            this.local,
            this.horainicio,
            this.horafinal,
            this.IDpessoa,
            this.nome,
            this.valor});
            this.DgvAgenda.Location = new System.Drawing.Point(12, 67);
            this.DgvAgenda.Name = "DgvAgenda";
            this.DgvAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAgenda.Size = new System.Drawing.Size(782, 300);
            this.DgvAgenda.TabIndex = 25;
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Location = new System.Drawing.Point(622, 14);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(91, 27);
            this.btnPesquisa.TabIndex = 24;
            this.btnPesquisa.Text = "&Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click_1);
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Arial Narrow", 13F);
            this.lbData.Location = new System.Drawing.Point(41, 14);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(186, 22);
            this.lbData.TabIndex = 22;
            this.lbData.Text = "Digite o nome ou parte dele";
            // 
            // btnfechar
            // 
            this.btnfechar.Image = ((System.Drawing.Image)(resources.GetObject("btnfechar.Image")));
            this.btnfechar.Location = new System.Drawing.Point(719, 378);
            this.btnfechar.Name = "btnfechar";
            this.btnfechar.Size = new System.Drawing.Size(75, 81);
            this.btnfechar.TabIndex = 21;
            this.btnfechar.UseVisualStyleBackColor = true;
            this.btnfechar.Click += new System.EventHandler(this.btnfechar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(638, 378);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 81);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(555, 378);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 81);
            this.btnAlterar.TabIndex = 19;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // BtnInserir
            // 
            this.BtnInserir.Image = ((System.Drawing.Image)(resources.GetObject("BtnInserir.Image")));
            this.BtnInserir.Location = new System.Drawing.Point(472, 378);
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(75, 81);
            this.BtnInserir.TabIndex = 18;
            this.BtnInserir.UseVisualStyleBackColor = true;
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(233, 14);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(383, 26);
            this.txtnome.TabIndex = 26;
            // 
            // idagendamento
            // 
            this.idagendamento.DataPropertyName = "idagendamento";
            this.idagendamento.HeaderText = "Codigo";
            this.idagendamento.Name = "idagendamento";
            this.idagendamento.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idagendamento.Width = 50;
            // 
            // situacao
            // 
            this.situacao.DataPropertyName = "situacao";
            this.situacao.HeaderText = "Status";
            this.situacao.Name = "situacao";
            this.situacao.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.situacao.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.situacao.Width = 50;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            this.data.HeaderText = "Dia Da Locacao";
            this.data.Name = "data";
            // 
            // local
            // 
            this.local.DataPropertyName = "local";
            this.local.HeaderText = "Local Reservado";
            this.local.Name = "local";
            this.local.Width = 180;
            // 
            // horainicio
            // 
            this.horainicio.DataPropertyName = "horainicio";
            this.horainicio.HeaderText = "Hora Inicial";
            this.horainicio.Name = "horainicio";
            this.horainicio.Width = 80;
            // 
            // horafinal
            // 
            this.horafinal.DataPropertyName = "horafinal";
            this.horafinal.HeaderText = "Hora Termino";
            this.horafinal.Name = "horafinal";
            this.horafinal.Width = 80;
            // 
            // IDpessoa
            // 
            this.IDpessoa.DataPropertyName = "IDpessoa";
            this.IDpessoa.HeaderText = "Cod.Socio";
            this.IDpessoa.Name = "IDpessoa";
            this.IDpessoa.Width = 70;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.Width = 250;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "valor";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.valor.DefaultCellStyle = dataGridViewCellStyle1;
            this.valor.HeaderText = "Preço Alugado";
            this.valor.Name = "valor";
            this.valor.Width = 120;
            // 
            // FrmSelecionarAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 471);
            this.ControlBox = false;
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.DgvAgenda);
            this.Controls.Add(this.btnPesquisa);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.btnfechar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.BtnInserir);
            this.Name = "FrmSelecionarAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecinar Agendamentos ";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.FrmSelecionarAgendamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAgenda;
        private System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Button btnfechar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button BtnInserir;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.DataGridViewTextBoxColumn idagendamento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn local;
        private System.Windows.Forms.DataGridViewTextBoxColumn horainicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn horafinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDpessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
    }
}