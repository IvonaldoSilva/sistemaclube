namespace Apresentacao
{
    partial class FrmAgendamento
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
            this.GbSituacao = new System.Windows.Forms.GroupBox();
            this.rdbapagar = new System.Windows.Forms.RadioButton();
            this.rdbpago = new System.Windows.Forms.RadioButton();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbAdicionar = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmblocal = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cmbfinal = new System.Windows.Forms.ComboBox();
            this.cmbinicio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpdata = new System.Windows.Forms.DateTimePicker();
            this.panelbotoes = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.GbSituacao.SuspendLayout();
            this.panelbotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbSituacao
            // 
            this.GbSituacao.Controls.Add(this.rdbapagar);
            this.GbSituacao.Controls.Add(this.rdbpago);
            this.GbSituacao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbSituacao.Location = new System.Drawing.Point(356, 140);
            this.GbSituacao.Name = "GbSituacao";
            this.GbSituacao.Size = new System.Drawing.Size(367, 81);
            this.GbSituacao.TabIndex = 41;
            this.GbSituacao.TabStop = false;
            this.GbSituacao.Text = "Situação";
            // 
            // rdbapagar
            // 
            this.rdbapagar.AutoSize = true;
            this.rdbapagar.Checked = true;
            this.rdbapagar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbapagar.Location = new System.Drawing.Point(186, 32);
            this.rdbapagar.Name = "rdbapagar";
            this.rdbapagar.Size = new System.Drawing.Size(75, 24);
            this.rdbapagar.TabIndex = 1;
            this.rdbapagar.TabStop = true;
            this.rdbapagar.Text = "À Pagar";
            this.rdbapagar.UseVisualStyleBackColor = true;
            // 
            // rdbpago
            // 
            this.rdbpago.AutoSize = true;
            this.rdbpago.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbpago.Location = new System.Drawing.Point(6, 32);
            this.rdbpago.Name = "rdbpago";
            this.rdbpago.Size = new System.Drawing.Size(59, 24);
            this.rdbpago.TabIndex = 0;
            this.rdbpago.Text = "Pago";
            this.rdbpago.UseVisualStyleBackColor = true;
            // 
            // txtCod
            // 
            this.txtCod.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod.Location = new System.Drawing.Point(591, 16);
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(103, 26);
            this.txtCod.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(538, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "Cod  :";
            // 
            // lbAdicionar
            // 
            this.lbAdicionar.AutoSize = true;
            this.lbAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdicionar.Location = new System.Drawing.Point(510, 110);
            this.lbAdicionar.Name = "lbAdicionar";
            this.lbAdicionar.Size = new System.Drawing.Size(24, 25);
            this.lbAdicionar.TabIndex = 37;
            this.lbAdicionar.Text = "+";
            this.lbAdicionar.Click += new System.EventHandler(this.lbAdicionar_Click);
            // 
            // txtvalor
            // 
            this.txtvalor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor.Location = new System.Drawing.Point(109, 195);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(121, 26);
            this.txtvalor.TabIndex = 36;
            this.txtvalor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalor_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Valor :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Data  :";
            // 
            // cmblocal
            // 
            this.cmblocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmblocal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmblocal.FormattingEnabled = true;
            this.cmblocal.Items.AddRange(new object[] {
            "SALÃO DE EVENTOS",
            "SAUNA",
            "PISCINA"});
            this.cmblocal.Location = new System.Drawing.Point(109, 152);
            this.cmblocal.Name = "cmblocal";
            this.cmblocal.Size = new System.Drawing.Size(203, 28);
            this.cmblocal.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "Local :";
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(177, 108);
            this.txtnome.Name = "txtnome";
            this.txtnome.ReadOnly = true;
            this.txtnome.Size = new System.Drawing.Size(327, 26);
            this.txtnome.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "Cod.Socio :";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(109, 108);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(62, 26);
            this.txtCodigo.TabIndex = 29;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // cmbfinal
            // 
            this.cmbfinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfinal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbfinal.FormattingEnabled = true;
            this.cmbfinal.Items.AddRange(new object[] {
            "00:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.cmbfinal.Location = new System.Drawing.Point(326, 65);
            this.cmbfinal.Name = "cmbfinal";
            this.cmbfinal.Size = new System.Drawing.Size(111, 28);
            this.cmbfinal.TabIndex = 28;
            // 
            // cmbinicio
            // 
            this.cmbinicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbinicio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbinicio.FormattingEnabled = true;
            this.cmbinicio.Items.AddRange(new object[] {
            "00:00",
            "01:00",
            "02:00",
            "03:00",
            "04:00",
            "05:00",
            "06:00",
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00",
            "23:00"});
            this.cmbinicio.Location = new System.Drawing.Point(109, 65);
            this.cmbinicio.Name = "cmbinicio";
            this.cmbinicio.Size = new System.Drawing.Size(121, 28);
            this.cmbinicio.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Término :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Inicio :";
            // 
            // dtpdata
            // 
            this.dtpdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdata.Location = new System.Drawing.Point(109, 19);
            this.dtpdata.Name = "dtpdata";
            this.dtpdata.Size = new System.Drawing.Size(328, 26);
            this.dtpdata.TabIndex = 24;
            this.dtpdata.ValueChanged += new System.EventHandler(this.dtpdata_ValueChanged);
            // 
            // panelbotoes
            // 
            this.panelbotoes.Controls.Add(this.btnCancelar);
            this.panelbotoes.Controls.Add(this.btnSalvar);
            this.panelbotoes.Location = new System.Drawing.Point(3, 247);
            this.panelbotoes.Name = "panelbotoes";
            this.panelbotoes.Size = new System.Drawing.Size(720, 117);
            this.panelbotoes.TabIndex = 38;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Apresentacao.Properties.Resources.Cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(122, 18);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 87);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::Apresentacao.Properties.Resources.salvar;
            this.btnSalvar.Location = new System.Drawing.Point(41, 18);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 87);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 375);
            this.ControlBox = false;
            this.Controls.Add(this.GbSituacao);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbAdicionar);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmblocal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.cmbfinal);
            this.Controls.Add(this.cmbinicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpdata);
            this.Controls.Add(this.panelbotoes);
            this.Name = "FrmAgendamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgendamento";
            this.Load += new System.EventHandler(this.FrmAgendamento_Load);
            this.GbSituacao.ResumeLayout(false);
            this.GbSituacao.PerformLayout();
            this.panelbotoes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GbSituacao;
        private System.Windows.Forms.RadioButton rdbapagar;
        private System.Windows.Forms.RadioButton rdbpago;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbAdicionar;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmblocal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cmbfinal;
        private System.Windows.Forms.ComboBox cmbinicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpdata;
        private System.Windows.Forms.Panel panelbotoes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
    }
}