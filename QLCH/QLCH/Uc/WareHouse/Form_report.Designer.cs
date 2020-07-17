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
            this.bill_infoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billOfCus = new QLCH.BillOfCus();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.billinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bill_infoTableAdapter = new QLCH.BillOfCusTableAdapters.bill_infoTableAdapter();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.bill_infoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billOfCus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billinfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bill_infoBindingSource
            // 
            this.bill_infoBindingSource.DataMember = "bill_info";
            this.bill_infoBindingSource.DataSource = this.billOfCus;
            // 
            // billOfCus
            // 
            this.billOfCus.DataSetName = "BillOfCus";
            this.billOfCus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.reportViewer1.Size = new System.Drawing.Size(1007, 706);
            this.reportViewer1.TabIndex = 0;
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
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(962, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 28);
            this.gunaControlBox1.TabIndex = 1;
            // 
            // Form_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 706);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_report";
            this.Text = "Form_report";
            this.Load += new System.EventHandler(this.Form_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bill_infoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billOfCus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billinfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource billinfoBindingSource;
        private BillOfCus billOfCus;
        private BillOfCusTableAdapters.bill_infoTableAdapter bill_infoTableAdapter;
        private System.Windows.Forms.BindingSource bill_infoBindingSource;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
    }
}