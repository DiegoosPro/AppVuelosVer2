namespace AppVuelos
{
    partial class FrmRepClientesVuelos
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
            this.ClientesVuelosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientesVuelosTableAdapter = new AppVuelos.bddvuelosDataSet2TableAdapters.ClientesVuelosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bddvuelosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesVuelosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ClientesVuelosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppVuelos.RepClientesVuelos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // bddvuelosDataSet2
            // 
            this.bddvuelosDataSet2.DataSetName = "bddvuelosDataSet2";
            this.bddvuelosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ClientesVuelosBindingSource
            // 
            this.ClientesVuelosBindingSource.DataMember = "ClientesVuelos";
            this.ClientesVuelosBindingSource.DataSource = this.bddvuelosDataSet2;
            // 
            // ClientesVuelosTableAdapter
            // 
            this.ClientesVuelosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRepClientesVuelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 290);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRepClientesVuelos";
            this.Text = "FrmRepClientesVuelos";
            this.Load += new System.EventHandler(this.FrmRepClientesVuelos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bddvuelosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesVuelosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ClientesVuelosBindingSource;
        private bddvuelosDataSet2 bddvuelosDataSet2;
        private bddvuelosDataSet2TableAdapters.ClientesVuelosTableAdapter ClientesVuelosTableAdapter;
    }
}