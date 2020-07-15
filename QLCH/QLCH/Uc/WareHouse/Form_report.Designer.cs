namespace QLCH.Uc.WareHouse
{
    partial class Form_report
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
            this.billOfCus = new QLCH.BillOfCus();
            this.billinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bill_infoTableAdapter = new QLCH.BillOfCusTableAdapters.bill_infoTableAdapter();
            this.bill_infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.billOfCus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_infoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bill_infoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLCH.Uc.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(945, 520);
            this.reportViewer1.TabIndex = 0;
            // 
            // billOfCus
            // 
            this.billOfCus.DataSetName = "BillOfCus";
            this.billOfCus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billinfoBindingSource
            // 
            this.billinfoBindingSource.DataMember = "bill_info";
            this.billinfoBindingSource.DataSource = this.billOfCus;
            // 
            // bill_infoTableAdapter
            // 
            this.bill_infoTableAdapter.ClearBeforeFill = true;
            // 
            // bill_infoBindingSource
            // 
            this.bill_infoBindingSource.DataMember = "bill_info";
            this.bill_infoBindingSource.DataSource = this.billOfCus;
            // 
            // Form_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 520);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form_report";
            this.Text = "Form_report";
            this.Load += new System.EventHandler(this.Form_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billOfCus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_infoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource billinfoBindingSource;
        private BillOfCus billOfCus;
        private BillOfCusTableAdapters.bill_infoTableAdapter bill_infoTableAdapter;
        private System.Windows.Forms.BindingSource bill_infoBindingSource;
    }
}