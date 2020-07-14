namespace QLCH.Uc
{
    partial class Uc_QLSP
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlGroupSP = new System.Windows.Forms.Panel();
            this.pnlHangSP = new System.Windows.Forms.Panel();
            this.tagpage3 = new System.Windows.Forms.TabPage();
            this.pnlProduct = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tagpage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tagpage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(965, 656);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlGroupSP);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(957, 628);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Group Product";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlHangSP);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(957, 628);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Brand Product";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlGroupSP
            // 
            this.pnlGroupSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGroupSP.Location = new System.Drawing.Point(3, 3);
            this.pnlGroupSP.Name = "pnlGroupSP";
            this.pnlGroupSP.Size = new System.Drawing.Size(951, 622);
            this.pnlGroupSP.TabIndex = 0;
            // 
            // pnlHangSP
            // 
            this.pnlHangSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHangSP.Location = new System.Drawing.Point(3, 3);
            this.pnlHangSP.Name = "pnlHangSP";
            this.pnlHangSP.Size = new System.Drawing.Size(951, 622);
            this.pnlHangSP.TabIndex = 0;
            // 
            // tagpage3
            // 
            this.tagpage3.Controls.Add(this.pnlProduct);
            this.tagpage3.Location = new System.Drawing.Point(4, 24);
            this.tagpage3.Name = "tagpage3";
            this.tagpage3.Padding = new System.Windows.Forms.Padding(3);
            this.tagpage3.Size = new System.Drawing.Size(957, 628);
            this.tagpage3.TabIndex = 2;
            this.tagpage3.Text = "Product";
            this.tagpage3.UseVisualStyleBackColor = true;
            // 
            // pnlProduct
            // 
            this.pnlProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProduct.Location = new System.Drawing.Point(3, 3);
            this.pnlProduct.Name = "pnlProduct";
            this.pnlProduct.Size = new System.Drawing.Size(951, 622);
            this.pnlProduct.TabIndex = 0;
            // 
            // Uc_QLSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Uc_QLSP";
            this.Size = new System.Drawing.Size(965, 656);
            this.Load += new System.EventHandler(this.Uc_QLSP_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tagpage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlGroupSP;
        private System.Windows.Forms.Panel pnlHangSP;
        private System.Windows.Forms.TabPage tagpage3;
        private System.Windows.Forms.Panel pnlProduct;
    }
}
