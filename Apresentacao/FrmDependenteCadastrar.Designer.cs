namespace Apresentacao
{
    partial class FrmDependenteCadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDependenteCadastrar));
            this.pnldados = new System.Windows.Forms.Panel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodSocio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbcivildep = new System.Windows.Forms.ComboBox();
            this.cmbgraudep = new System.Windows.Forms.ComboBox();
            this.dTPnascdep = new System.Windows.Forms.DateTimePicker();
            this.txtnomedep = new System.Windows.Forms.TextBox();
            this.lblestadocivil = new System.Windows.Forms.Label();
            this.lblgraudep = new System.Windows.Forms.Label();
            this.lbldatanasc = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.pnlbotoes = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.pnldados.SuspendLayout();
            this.pnlbotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnldados
            // 
            this.pnldados.Controls.Add(this.txtCodigo);
            this.pnldados.Controls.Add(this.label2);
            this.pnldados.Controls.Add(this.lblCodigo);
            this.pnldados.Controls.Add(this.txtCodSocio);
            this.pnldados.Controls.Add(this.label1);
            this.pnldados.Controls.Add(this.cmbcivildep);
            this.pnldados.Controls.Add(this.cmbgraudep);
            this.pnldados.Controls.Add(this.dTPnascdep);
            this.pnldados.Controls.Add(this.txtnomedep);
            this.pnldados.Controls.Add(this.lblestadocivil);
            this.pnldados.Controls.Add(this.lblgraudep);
            this.pnldados.Controls.Add(this.lbldatanasc);
            this.pnldados.Controls.Add(this.lblnome);
            this.pnldados.Enabled = false;
            this.pnldados.Location = new System.Drawing.Point(13, 13);
            this.pnldados.Name = "pnldados";
            this.pnldados.Size = new System.Drawing.Size(560, 349);
            this.pnldados.TabIndex = 0;
            this.pnldados.Paint += new System.Windows.Forms.PaintEventHandler(this.pnldados_Paint);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(106, 15);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(69, 26);
            this.txtCodigo.TabIndex = 28;
            this.txtCodigo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "+";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(14, 15);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(80, 20);
            this.lblCodigo.TabIndex = 5;
            this.lblCodigo.Text = "Cod. Dep.";
            // 
            // txtCodSocio
            // 
            this.txtCodSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodSocio.Location = new System.Drawing.Point(106, 56);
            this.txtCodSocio.Name = "txtCodSocio";
            this.txtCodSocio.Size = new System.Drawing.Size(69, 26);
            this.txtCodSocio.TabIndex = 0;
            this.txtCodSocio.TabStop = false;
            this.txtCodSocio.TextChanged += new System.EventHandler(this.txtCodSocio_TextChanged);
            this.txtCodSocio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodSocio_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cod. Socio";
            // 
            // cmbcivildep
            // 
            this.cmbcivildep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcivildep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcivildep.FormattingEnabled = true;
            this.cmbcivildep.Items.AddRange(new object[] {
            "SOLTEIRO",
            "CASADO",
            "VIUVO(A)",
            ""});
            this.cmbcivildep.Location = new System.Drawing.Point(134, 293);
            this.cmbcivildep.Name = "cmbcivildep";
            this.cmbcivildep.Size = new System.Drawing.Size(152, 28);
            this.cmbcivildep.TabIndex = 4;
            this.cmbcivildep.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cmbgraudep
            // 
            this.cmbgraudep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbgraudep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgraudep.FormattingEnabled = true;
            this.cmbgraudep.Items.AddRange(new object[] {
            "PAI",
            "MÃE",
            "FILHO(A)",
            "ESPOSA",
            "MARIDO"});
            this.cmbgraudep.Location = new System.Drawing.Point(165, 235);
            this.cmbgraudep.Name = "cmbgraudep";
            this.cmbgraudep.Size = new System.Drawing.Size(165, 28);
            this.cmbgraudep.TabIndex = 3;
            this.cmbgraudep.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dTPnascdep
            // 
            this.dTPnascdep.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dTPnascdep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPnascdep.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPnascdep.Location = new System.Drawing.Point(153, 173);
            this.dTPnascdep.Name = "dTPnascdep";
            this.dTPnascdep.Size = new System.Drawing.Size(133, 26);
            this.dTPnascdep.TabIndex = 2;
            this.dTPnascdep.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtnomedep
            // 
            this.txtnomedep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomedep.Location = new System.Drawing.Point(80, 115);
            this.txtnomedep.Name = "txtnomedep";
            this.txtnomedep.Size = new System.Drawing.Size(277, 26);
            this.txtnomedep.TabIndex = 1;
            this.txtnomedep.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblestadocivil
            // 
            this.lblestadocivil.AutoSize = true;
            this.lblestadocivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestadocivil.Location = new System.Drawing.Point(14, 296);
            this.lblestadocivil.Name = "lblestadocivil";
            this.lblestadocivil.Size = new System.Drawing.Size(91, 20);
            this.lblestadocivil.TabIndex = 10;
            this.lblestadocivil.Text = "Estado Civil";
            // 
            // lblgraudep
            // 
            this.lblgraudep.AutoSize = true;
            this.lblgraudep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgraudep.Location = new System.Drawing.Point(14, 238);
            this.lblgraudep.Name = "lblgraudep";
            this.lblgraudep.Size = new System.Drawing.Size(135, 20);
            this.lblgraudep.TabIndex = 9;
            this.lblgraudep.Text = "Grau dependente";
            // 
            // lbldatanasc
            // 
            this.lbldatanasc.AutoSize = true;
            this.lbldatanasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldatanasc.Location = new System.Drawing.Point(14, 178);
            this.lbldatanasc.Name = "lbldatanasc";
            this.lbldatanasc.Size = new System.Drawing.Size(116, 20);
            this.lbldatanasc.TabIndex = 8;
            this.lbldatanasc.Text = "Dt. nascimento";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.Location = new System.Drawing.Point(14, 118);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(51, 20);
            this.lblnome.TabIndex = 7;
            this.lblnome.Text = "Nome";
            // 
            // pnlbotoes
            // 
            this.pnlbotoes.Controls.Add(this.BtnCancelar);
            this.pnlbotoes.Controls.Add(this.btnsalvar);
            this.pnlbotoes.Controls.Add(this.btnAdicionar);
            this.pnlbotoes.Location = new System.Drawing.Point(13, 369);
            this.pnlbotoes.Name = "pnlbotoes";
            this.pnlbotoes.Size = new System.Drawing.Size(560, 107);
            this.pnlbotoes.TabIndex = 1;
            this.pnlbotoes.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlbotoes_Paint);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.Location = new System.Drawing.Point(192, 22);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(87, 73);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Enabled = false;
            this.btnsalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnsalvar.Image")));
            this.btnsalvar.Location = new System.Drawing.Point(105, 22);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(87, 73);
            this.btnsalvar.TabIndex = 1;
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.Location = new System.Drawing.Point(18, 22);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(87, 73);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmDependenteCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 493);
            this.ControlBox = false;
            this.Controls.Add(this.pnlbotoes);
            this.Controls.Add(this.pnldados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmDependenteCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Dependente";
            this.Load += new System.EventHandler(this.Frmdependente_Load);
            this.pnldados.ResumeLayout(false);
            this.pnldados.PerformLayout();
            this.pnlbotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnldados;
        private System.Windows.Forms.Label lblestadocivil;
        private System.Windows.Forms.Label lblgraudep;
        private System.Windows.Forms.Label lbldatanasc;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Panel pnlbotoes;
        private System.Windows.Forms.ComboBox cmbcivildep;
        private System.Windows.Forms.ComboBox cmbgraudep;
        private System.Windows.Forms.DateTimePicker dTPnascdep;
        private System.Windows.Forms.TextBox txtnomedep;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.TextBox txtCodSocio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnAdicionar;
    }
}