namespace Task1
{
    partial class FormReportMem
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
            this.memberTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymDbDataSet = new Task1.GymDbDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.memberTblTableAdapter = new Task1.GymDbDataSetTableAdapters.MemberTblTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.memberTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // memberTblBindingSource
            // 
            this.memberTblBindingSource.DataMember = "MemberTbl";
            this.memberTblBindingSource.DataSource = this.gymDbDataSetBindingSource;
            // 
            // gymDbDataSetBindingSource
            // 
            this.gymDbDataSetBindingSource.DataSource = this.gymDbDataSet;
            this.gymDbDataSetBindingSource.Position = 0;
            // 
            // gymDbDataSet
            // 
            this.gymDbDataSet.DataSetName = "GymDbDataSet";
            this.gymDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.memberTblBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Task1.Reports.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // memberTblTableAdapter
            // 
            this.memberTblTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportMem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReportMem";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет по клиентам";
            this.Load += new System.EventHandler(this.FormReportMem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.memberTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymDbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private GymDbDataSet gymDbDataSet;
        private System.Windows.Forms.BindingSource gymDbDataSetBindingSource;
        private System.Windows.Forms.BindingSource memberTblBindingSource;
        private GymDbDataSetTableAdapters.MemberTblTableAdapter memberTblTableAdapter;
        private System.Windows.Forms.BindingSource PaymentTblBindingSource;
        private GymDbDataSetTableAdapters.PaymentTblTableAdapter paymentTblTableAdapter;
    }
}