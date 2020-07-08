namespace QLCH.Uc
{
    partial class Uc_DanhMuc
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
            this.components = new System.ComponentModel.Container();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlTaiKhoan = new Guna.UI.WinForms.GunaPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlKhachhang = new Guna.UI.WinForms.GunaPanel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlNhanVien = new Guna.UI.WinForms.GunaPanel();
            this.tctDanhMuc = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pnlNCC = new Guna.UI.WinForms.GunaPanel();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tctDanhMuc.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 7;
            this.gunaElipse1.TargetControl = this;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pnlTaiKhoan);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(957, 628);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tài khoản";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnlTaiKhoan
            // 
            this.pnlTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTaiKhoan.Location = new System.Drawing.Point(3, 3);
            this.pnlTaiKhoan.Name = "pnlTaiKhoan";
            this.pnlTaiKhoan.Size = new System.Drawing.Size(951, 622);
            this.pnlTaiKhoan.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pnlKhachhang);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(957, 628);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Khách hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pnlKhachhang
            // 
            this.pnlKhachhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlKhachhang.Location = new System.Drawing.Point(3, 3);
            this.pnlKhachhang.Name = "pnlKhachhang";
            this.pnlKhachhang.Size = new System.Drawing.Size(951, 622);
            this.pnlKhachhang.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlNhanVien);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(957, 628);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nhân viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlNhanVien
            // 
            this.pnlNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlNhanVien.Location = new System.Drawing.Point(3, 3);
            this.pnlNhanVien.Name = "pnlNhanVien";
            this.pnlNhanVien.Size = new System.Drawing.Size(951, 622);
            this.pnlNhanVien.TabIndex = 0;
            // 
            // tctDanhMuc
            // 
            this.tctDanhMuc.Controls.Add(this.tabPage1);
            this.tctDanhMuc.Controls.Add(this.tabPage2);
            this.tctDanhMuc.Controls.Add(this.tabPage3);
            this.tctDanhMuc.Controls.Add(this.tabPage4);
            this.tctDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tctDanhMuc.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.tctDanhMuc.Name = "tctDanhMuc";
            this.tctDanhMuc.SelectedIndex = 0;
            this.tctDanhMuc.Size = new System.Drawing.Size(965, 656);
            this.tctDanhMuc.TabIndex = 1;
            this.tctDanhMuc.SelectedIndexChanged += new System.EventHandler(this.tctDanhMuc_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pnlNCC);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(957, 628);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Nhà cung cấp";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pnlNCC
            // 
            this.pnlNCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNCC.Location = new System.Drawing.Point(3, 3);
            this.pnlNCC.Name = "pnlNCC";
            this.pnlNCC.Size = new System.Drawing.Size(951, 622);
            this.pnlNCC.TabIndex = 0;
            // 
            // Uc_DanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tctDanhMuc);
            this.Name = "Uc_DanhMuc";
            this.Size = new System.Drawing.Size(965, 656);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tctDanhMuc.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.TabPage tabPage3;
        private Guna.UI.WinForms.GunaPanel pnlTaiKhoan;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI.WinForms.GunaPanel pnlKhachhang;
        private System.Windows.Forms.TabPage tabPage1;
        private Guna.UI.WinForms.GunaPanel pnlNhanVien;
        private System.Windows.Forms.TabControl tctDanhMuc;
        private System.Windows.Forms.TabPage tabPage4;
        private Guna.UI.WinForms.GunaPanel pnlNCC;
    }
}
