namespace Apresentacao
{
    partial class RelatorioDependente
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tbldependenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClubeDataSet2 = new Apresentacao.ClubeDataSet2();
            this.tblPessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClubeDataSet = new Apresentacao.ClubeDataSet();
            this.PanelPesquisa = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tblPessoaTableAdapter = new Apresentacao.ClubeDataSetTableAdapters.tblPessoaTableAdapter();
            this.tbldependenteTableAdapter = new Apresentacao.ClubeDataSet2TableAdapters.tbldependenteTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.tbldependenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClubeDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClubeDataSet)).BeginInit();
            this.PanelPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbldependenteBindingSource
            // 
            this.tbldependenteBindingSource.DataMember = "tbldependente";
            this.tbldependenteBindingSource.DataSource = this.ClubeDataSet2;
            // 
            // ClubeDataSet2
            // 
            this.ClubeDataSet2.DataSetName = "ClubeDataSet2";
            this.ClubeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPessoaBindingSource
            // 
            this.tblPessoaBindingSource.DataMember = "tblPessoa";
            this.tblPessoaBindingSource.DataSource = this.ClubeDataSet;
            // 
            // ClubeDataSet
            // 
            this.ClubeDataSet.DataSetName = "ClubeDataSet";
            this.ClubeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PanelPesquisa
            // 
            this.PanelPesquisa.Controls.Add(this.button1);
            this.PanelPesquisa.Controls.Add(this.txtMatricula);
            this.PanelPesquisa.Controls.Add(this.label1);
            this.PanelPesquisa.Location = new System.Drawing.Point(13, 13);
            this.PanelPesquisa.Name = "PanelPesquisa";
            this.PanelPesquisa.Size = new System.Drawing.Size(897, 83);
            this.PanelPesquisa.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Gerar Relatorio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(127, 29);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(106, 20);
            this.txtMatricula.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o codigo socio";
            // 
            // tblPessoaTableAdapter
            // 
            this.tblPessoaTableAdapter.ClearBeforeFill = true;
            // 
            // tbldependenteTableAdapter
            // 
            this.tbldependenteTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbldependenteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Apresentacao.ReportDepedente.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 113);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(900, 616);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // RelatorioDependente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 741);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.PanelPesquisa);
            this.Name = "RelatorioDependente";
            this.Text = "Relatoiro de Dependente por Socio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmRelatorioDep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbldependenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClubeDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClubeDataSet)).EndInit();
            this.PanelPesquisa.ResumeLayout(false);
            this.PanelPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelPesquisa;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource tbldependenteBindingSource;
        private ClubeDataSet2 ClubeDataSet2;
        private ClubeDataSet2TableAdapters.tbldependenteTableAdapter tbldependenteTableAdapter;
        private System.Windows.Forms.BindingSource tblPessoaBindingSource;
        private ClubeDataSet ClubeDataSet;
        private ClubeDataSetTableAdapters.tblPessoaTableAdapter tblPessoaTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}