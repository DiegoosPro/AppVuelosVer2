namespace AppVuelos
{
    partial class FrmRepClientes
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
            this.bddvuelosDataSet2 = new AppVuelos.bddvuelosDataSet2();
            this.TAB_CLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TAB_CLIENTESTableAdapter = new AppVuelos.bddvuelosDataSet2TableAdapters.TAB_CLIENTESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bddvuelosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAB_CLIENTESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TAB_CLIENTESBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppVuelos.RepClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(61, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(445, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // bddvuelosDataSet2
            // 
            this.bddvuelosDataSet2.DataSetName = "bddvuelosDataSet2";
            this.bddvuelosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TAB_CLIENTESBindingSource
            // 
            this.TAB_CLIENTESBindingSource.DataMember = "TAB_CLIENTES";
            this.TAB_CLIENTESBindingSource.DataSource = this.bddvuelosDataSet2;
            // 
            // TAB_CLIENTESTableAdapter
            // 
            this.TAB_CLIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRepClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 316);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRepClientes";
            this.Text = "FrmRepClientes";
            this.Load += new System.EventHandler(this.FrmRepClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bddvuelosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAB_CLIENTESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TAB_CLIENTESBindingSource;
        private bddvuelosDataSet2 bddvuelosDataSet2;
        private bddvuelosDataSet2TableAdapters.TAB_CLIENTESTableAdapter TAB_CLIENTESTableAdapter;

    }
}