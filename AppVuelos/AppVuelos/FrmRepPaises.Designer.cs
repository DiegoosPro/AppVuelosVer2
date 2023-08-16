namespace AppVuelos
{
    partial class FrmRepPaises
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
            this.TAB_PAISESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TAB_PAISESTableAdapter = new AppVuelos.bddvuelosDataSet2TableAdapters.TAB_PAISESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bddvuelosDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAB_PAISESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.TAB_PAISESBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AppVuelos.RepPaises.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(699, 401);
            this.reportViewer1.TabIndex = 0;
            // 
            // bddvuelosDataSet2
            // 
            this.bddvuelosDataSet2.DataSetName = "bddvuelosDataSet2";
            this.bddvuelosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TAB_PAISESBindingSource
            // 
            this.TAB_PAISESBindingSource.DataMember = "TAB_PAISES";
            this.TAB_PAISESBindingSource.DataSource = this.bddvuelosDataSet2;
            // 
            // TAB_PAISESTableAdapter
            // 
            this.TAB_PAISESTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRepPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 456);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRepPaises";
            this.Text = "FrmRepPaises";
            this.Load += new System.EventHandler(this.FrmRepPaises_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bddvuelosDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TAB_PAISESBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TAB_PAISESBindingSource;
        private bddvuelosDataSet2 bddvuelosDataSet2;
        private bddvuelosDataSet2TableAdapters.TAB_PAISESTableAdapter TAB_PAISESTableAdapter;
    }
}