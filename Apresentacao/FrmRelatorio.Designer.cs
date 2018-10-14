namespace Apresentacao
{
    partial class FrmRelatorio
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
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.gbStatusContas = new System.Windows.Forms.GroupBox();
            this.rdBaixado = new System.Windows.Forms.RadioButton();
            this.rdAberto = new System.Windows.Forms.RadioButton();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.gbStatusContas.SuspendLayout();
            this.gbData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Location = new System.Drawing.Point(23, 151);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(108, 46);
            this.btnGerarRelatorio.TabIndex = 0;
            this.btnGerarRelatorio.Text = "GERAR";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.btnGerarRelatorio_Click);
            // 
            // gbStatusContas
            // 
            this.gbStatusContas.Controls.Add(this.rdBaixado);
            this.gbStatusContas.Controls.Add(this.rdAberto);
            this.gbStatusContas.Location = new System.Drawing.Point(21, 26);
            this.gbStatusContas.Name = "gbStatusContas";
            this.gbStatusContas.Size = new System.Drawing.Size(244, 46);
            this.gbStatusContas.TabIndex = 1;
            this.gbStatusContas.TabStop = false;
            this.gbStatusContas.Visible = false;
            // 
            // rdBaixado
            // 
            this.rdBaixado.AutoSize = true;
            this.rdBaixado.Location = new System.Drawing.Point(158, 19);
            this.rdBaixado.Name = "rdBaixado";
            this.rdBaixado.Size = new System.Drawing.Size(63, 17);
            this.rdBaixado.TabIndex = 1;
            this.rdBaixado.TabStop = true;
            this.rdBaixado.Text = "Baixado";
            this.rdBaixado.UseVisualStyleBackColor = true;
            this.rdBaixado.CheckedChanged += new System.EventHandler(this.rdBaixado_CheckedChanged);
            // 
            // rdAberto
            // 
            this.rdAberto.AutoSize = true;
            this.rdAberto.Location = new System.Drawing.Point(7, 20);
            this.rdAberto.Name = "rdAberto";
            this.rdAberto.Size = new System.Drawing.Size(74, 17);
            this.rdAberto.TabIndex = 0;
            this.rdAberto.TabStop = true;
            this.rdAberto.Text = "Em Aberto";
            this.rdAberto.UseVisualStyleBackColor = true;
            this.rdAberto.CheckedChanged += new System.EventHandler(this.rdAberto_CheckedChanged);
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.label1);
            this.gbData.Controls.Add(this.dtData);
            this.gbData.Location = new System.Drawing.Point(21, 79);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(244, 46);
            this.gbData.TabIndex = 2;
            this.gbData.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione uma data:";
            // 
            // dtData
            // 
            this.dtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(129, 14);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(109, 26);
            this.dtData.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "FECHAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(18, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(0, 13);
            this.lbTitulo.TabIndex = 4;
            // 
            // FrmRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 209);
            this.ControlBox = false;
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.gbStatusContas);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Name = "FrmRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Relatório";
            this.Load += new System.EventHandler(this.FrmRelatorio_Load);
            this.gbStatusContas.ResumeLayout(false);
            this.gbStatusContas.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.GroupBox gbStatusContas;
        private System.Windows.Forms.RadioButton rdBaixado;
        private System.Windows.Forms.RadioButton rdAberto;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbTitulo;
    }
}