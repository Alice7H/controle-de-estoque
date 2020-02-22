namespace GUI
{
    partial class frmRelatorioVenda
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
            this.VendaClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VendaClienteTableAdapter = new GUI.db_controledeestoqueDataSetTableAdapters.VendaClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.db_controledeestoqueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendaClienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetVendaCliente";
            reportDataSource1.Value = this.VendaClienteBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.repRelatorioVenda.rdlc";
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
            // VendaClienteBindingSource
            // 
            this.VendaClienteBindingSource.DataMember = "VendaCliente";
            this.VendaClienteBindingSource.DataSource = this.db_controledeestoqueDataSet;
            // 
            // VendaClienteTableAdapter
            // 
            this.VendaClienteTableAdapter.ClearBeforeFill = true;
            // 
            // frmRelatorioVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRelatorioVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Venda";
            this.Load += new System.EventHandler(this.frmRelatorioVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_controledeestoqueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendaClienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource VendaClienteBindingSource;
        private db_controledeestoqueDataSet db_controledeestoqueDataSet;
        private db_controledeestoqueDataSetTableAdapters.VendaClienteTableAdapter VendaClienteTableAdapter;
    }
}