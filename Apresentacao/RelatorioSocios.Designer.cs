namespace Apresentacao
{
    partial class RelatorioSocios
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
            this.tblPessoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClubeDataSet = new Apresentacao.ClubeDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblPessoaTableAdapter = new Apresentacao.ClubeDataSetTableAdapters.tblPessoaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblPessoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClubeDataSet)).BeginInit();
            this.SuspendLayout();
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetSocio";
            reportDataSource1.Value = this.tblPessoaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Apresentacao.ReportSocio.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(682, 456);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // tblPessoaTableAdapter
            // 
            this.tblPessoaTableAdapter.ClearBeforeFill = true;
            // 
            // RelatorioSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 456);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RelatorioSocios";
            this.Text = "Relatorios Socios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RelatorioSocios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblPessoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClubeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblPessoaBindingSource;
        private ClubeDataSet ClubeDataSet;
        private ClubeDataSetTableAdapters.tblPessoaTableAdapter tblPessoaTableAdapter;
    //}
}