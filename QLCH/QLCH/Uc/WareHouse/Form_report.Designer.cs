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
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.bill_of_cus = new QLCH.bill_of_cus();
            this.billinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bill_infoTableAdapter = new QLCH.bill_of_cusTableAdapters.bill_infoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bill_of_cus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billinfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.billinfoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLCH.Uc.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(768, 706);
            this.reportViewer1.TabIndex = 0;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(723, 0);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 28);
            this.gunaControlBox1.TabIndex = 1;
            // 
            // bill_of_cus
            // 
            this.bill_of_cus.DataSetName = "bill_of_cus";
            this.bill_of_cus.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billinfoBindingSource
            // 
            this.billinfoBindingSource.DataMember = "bill_info";
            this.billinfoBindingSource.DataSource = this.bill_of_cus;
            // 
            // bill_infoTableAdapter
            // 
            this.bill_infoTableAdapter.ClearBeforeFill = true;
            // 
            // Form_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 706);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_report";
            this.Text = "Form_report";
            this.Load += new System.EventHandler(this.Form_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bill_of_cus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billinfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private System.Windows.Forms.BindingSource billinfoBindingSource;
        private bill_of_cus bill_of_cus;
        private bill_of_cusTableAdapters.bill_infoTableAdapter bill_infoTableAdapter;
    }
}