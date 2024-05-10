namespace Task1
{
    partial class FormReportPayments
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
            this.gymDbDataSet = new Task1.GymDbDataSet();
            this.paymentTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTblTableAdapter = new Task1.GymDbDataSetTableAdapters.PaymentTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gymDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.paymentTblBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Task1.Reports.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // gymDbDataSet
            // 
            this.gymDbDataSet.DataSetName = "GymDbDataSet";
            this.gymDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentTblBindingSource
            // 
            this.paymentTblBindingSource.DataMember = "PaymentTbl";
            this.paymentTblBindingSource.DataSource = this.gymDbDataSet;
            // 
            // paymentTblTableAdapter
            // 
            this.paymentTblTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportPayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReportPayments";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет по оплате";
            this.Load += new System.EventHandler(this.FormReportPayments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gymDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTblBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private GymDbDataSet gymDbDataSet;
        private System.Windows.Forms.BindingSource paymentTblBindingSource;
        private GymDbDataSetTableAdapters.PaymentTblTableAdapter paymentTblTableAdapter;
    }
}