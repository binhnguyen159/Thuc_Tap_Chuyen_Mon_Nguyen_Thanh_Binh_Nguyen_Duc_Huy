namespace QLCH.Uc.WareHouse
{
    partial class Frm_Import_report
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
            this.bill_Import_info = new QLCH.bill_Import_info();
            this.billImportinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bill_Import_infoTableAdapter = new QLCH.bill_Import_infoTableAdapters.bill_Import_infoTableAdapter();
            this.bill_Import_infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.bill_Import_info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billImportinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_Import_infoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bill_Import_infoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLCH.Uc.WareHouse.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(791, 535);
            this.reportViewer1.TabIndex = 0;
            // 
            // bill_Import_info
            // 
            this.bill_Import_info.DataSetName = "bill_Import_info";
            this.bill_Import_info.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billImportinfoBindingSource
            // 
            this.billImportinfoBindingSource.DataMember = "bill_Import_info";
            this.billImportinfoBindingSource.DataSource = this.bill_Import_info;
            // 
            // bill_Import_infoTableAdapter
            // 
            this.bill_Import_infoTableAdapter.ClearBeforeFill = true;
            // 
            // bill_Import_infoBindingSource
            // 
            this.bill_Import_infoBindingSource.DataMember = "bill_Import_info";
            this.bill_Import_infoBindingSource.DataSource = this.bill_Import_info;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(746, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 28);
            this.gunaControlBox1.TabIndex = 2;
            // 
            // Frm_Import_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 535);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Import_report";
            this.Text = "Frm_Import_report";
            this.Load += new System.EventHandler(this.Frm_Import_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bill_Import_info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billImportinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_Import_infoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource billImportinfoBindingSource;
        private bill_Import_info bill_Import_info;
        private bill_Import_infoTableAdapters.bill_Import_infoTableAdapter bill_Import_infoTableAdapter;
        private System.Windows.Forms.BindingSource bill_Import_infoBindingSource;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
    }
}