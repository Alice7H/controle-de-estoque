namespace GUI
{
    partial class frmRelatorioCompra
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.db_controledeestoqueDataSet = new GUI.db_controledeestoqueDataSet();
            this.CompraFornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CompraFornecedorTableAdapter = new GUI.db_controledeestoqueDataSetTableAdapters.CompraFornecedorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.db_controledeestoqueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompraFornecedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetCompraFornecedor";
            reportDataSource1.Value = this.CompraFornecedorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.repRelatorioCompra.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(784, 561);
            this.reportViewer1.TabIndex = 0;
            // 
            // db_controledeestoqueDataSet
            // 
            this.db_controledeestoqueDataSet.DataSetName = "db_controledeestoqueDataSet";
            this.db_controledeestoqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CompraFornecedorBindingSource
            // 
            this.CompraFornecedorBindingSource.DataMember = "CompraFornecedor";
            this.CompraFornecedorBindingSource.DataSource = this.db_controledeestoqueDataSet;
            // 
            // CompraFornecedorTableAdapter
            // 
            this.CompraFornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelatorioCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Compra";
            this.Load += new System.EventHandler(this.frmRelatorioCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_controledeestoqueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompraFornecedorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CompraFornecedorBindingSource;
        private db_controledeestoqueDataSet db_controledeestoqueDataSet;
        private db_controledeestoqueDataSetTableAdapters.CompraFornecedorTableAdapter CompraFornecedorTableAdapter;
    }
}