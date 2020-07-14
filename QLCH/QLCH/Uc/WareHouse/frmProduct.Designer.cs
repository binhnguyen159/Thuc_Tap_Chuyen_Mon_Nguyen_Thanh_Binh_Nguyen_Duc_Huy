namespace QLCH.Uc.WareHouse
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.ptbAvatar = new System.Windows.Forms.PictureBox();
            this.btnSelect = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGia = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbBrand = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.txtTenSP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMaSP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxtParameter = new System.Windows.Forms.RichTextBox();
            this.ptbExit = new Guna.UI.WinForms.GunaPictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nmrAmount = new Guna.UI.WinForms.GunaNumeric();
            this.gunaElipsePanel1.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.gunaElipsePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 7;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.btnSave);
            this.gunaElipsePanel1.Controls.Add(this.gunaPanel1);
            this.gunaElipsePanel1.Controls.Add(this.gunaElipsePanel2);
            this.gunaElipsePanel1.Controls.Add(this.btnSelect);
            this.gunaElipsePanel1.Controls.Add(this.panel2);
            this.gunaElipsePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 7;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(637, 565);
            this.gunaElipsePanel1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(450, 476);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Size = new System.Drawing.Size(83, 42);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.ptbExit);
            this.gunaPanel1.Controls.Add(this.lbTitle);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(637, 69);
            this.gunaPanel1.TabIndex = 47;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(202, 18);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(82, 31);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "label1";
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel2.Controls.Add(this.ptbAvatar);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(365, 95);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Radius = 7;
            this.gunaElipsePanel2.Size = new System.Drawing.Size(250, 284);
            this.gunaElipsePanel2.TabIndex = 44;
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbAvatar.Image = ((System.Drawing.Image)(resources.GetObject("ptbAvatar.Image")));
            this.ptbAvatar.Location = new System.Drawing.Point(0, 0);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(250, 284);
            this.ptbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbAvatar.TabIndex = 4;
            this.ptbAvatar.TabStop = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Appearance.Options.UseFont = true;
            this.btnSelect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.ImageOptions.Image")));
            this.btnSelect.Location = new System.Drawing.Point(426, 418);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSelect.Size = new System.Drawing.Size(127, 42);
            this.btnSelect.TabIndex = 45;
            this.btnSelect.Text = "Select picture";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.nmrAmount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.rtxtParameter);
            this.panel2.Controls.Add(this.txtGia);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbbBrand);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbbType);
            this.panel2.Controls.Add(this.txtTenSP);
            this.panel2.Controls.Add(this.txtMaSP);
            this.panel2.Location = new System.Drawing.Point(18, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 442);
            this.panel2.TabIndex = 43;
            // 
            // txtGia
            // 
            this.txtGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtGia.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGia.HintForeColor = System.Drawing.Color.Empty;
            this.txtGia.HintText = "Price";
            this.txtGia.isPassword = false;
            this.txtGia.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtGia.LineIdleColor = System.Drawing.Color.Black;
            this.txtGia.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtGia.LineThickness = 2;
            this.txtGia.Location = new System.Drawing.Point(0, 78);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(317, 39);
            this.txtGia.TabIndex = 4;
            this.txtGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Brand:";
            // 
            // cbbBrand
            // 
            this.cbbBrand.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBrand.FormattingEnabled = true;
            this.cbbBrand.Location = new System.Drawing.Point(102, 397);
            this.cbbBrand.Name = "cbbBrand";
            this.cbbBrand.Size = new System.Drawing.Size(188, 23);
            this.cbbBrand.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product type:";
            // 
            // cbbType
            // 
            this.cbbType.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Location = new System.Drawing.Point(102, 361);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(188, 23);
            this.cbbType.TabIndex = 1;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTenSP.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenSP.HintForeColor = System.Drawing.Color.Empty;
            this.txtTenSP.HintText = "Product \'s name";
            this.txtTenSP.isPassword = false;
            this.txtTenSP.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTenSP.LineIdleColor = System.Drawing.Color.Black;
            this.txtTenSP.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTenSP.LineThickness = 2;
            this.txtTenSP.Location = new System.Drawing.Point(0, 39);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(317, 39);
            this.txtTenSP.TabIndex = 0;
            this.txtTenSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMaSP.Enabled = false;
            this.txtMaSP.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaSP.HintForeColor = System.Drawing.Color.Empty;
            this.txtMaSP.HintText = "ID";
            this.txtMaSP.isPassword = false;
            this.txtMaSP.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMaSP.LineIdleColor = System.Drawing.Color.Black;
            this.txtMaSP.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMaSP.LineThickness = 2;
            this.txtMaSP.Location = new System.Drawing.Point(0, 0);
            this.txtMaSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(317, 39);
            this.txtMaSP.TabIndex = 0;
            this.txtMaSP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 47;
            this.label4.Text = "Parameter:";
            // 
            // rtxtParameter
            // 
            this.rtxtParameter.Location = new System.Drawing.Point(3, 153);
            this.rtxtParameter.Name = "rtxtParameter";
            this.rtxtParameter.Size = new System.Drawing.Size(311, 150);
            this.rtxtParameter.TabIndex = 48;
            this.rtxtParameter.Text = "";
            // 
            // ptbExit
            // 
            this.ptbExit.BaseColor = System.Drawing.Color.White;
            this.ptbExit.Image = global::QLCH.Properties.Resources.icons8_delete_40;
            this.ptbExit.Location = new System.Drawing.Point(602, 0);
            this.ptbExit.Name = "ptbExit";
            this.ptbExit.Size = new System.Drawing.Size(35, 35);
            this.ptbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbExit.TabIndex = 1;
            this.ptbExit.TabStop = false;
            this.ptbExit.Click += new System.EventHandler(this.ptbExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Amount:";
            // 
            // nmrAmount
            // 
            this.nmrAmount.BaseColor = System.Drawing.Color.White;
            this.nmrAmount.BorderColor = System.Drawing.Color.Silver;
            this.nmrAmount.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.nmrAmount.ButtonForeColor = System.Drawing.Color.White;
            this.nmrAmount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nmrAmount.ForeColor = System.Drawing.Color.Black;
            this.nmrAmount.Location = new System.Drawing.Point(102, 317);
            this.nmrAmount.Maximum = ((long)(9999999));
            this.nmrAmount.Minimum = ((long)(0));
            this.nmrAmount.Name = "nmrAmount";
            this.nmrAmount.Size = new System.Drawing.Size(75, 30);
            this.nmrAmount.TabIndex = 49;
            this.nmrAmount.Value = ((long)(0));
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 565);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProduct";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaElipsePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private System.Windows.Forms.Label lbTitle;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private System.Windows.Forms.PictureBox ptbAvatar;
        private DevExpress.XtraEditors.SimpleButton btnSelect;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbType;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTenSP;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMaSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxtParameter;
        private Guna.UI.WinForms.GunaPictureBox ptbExit;
        private Guna.UI.WinForms.GunaNumeric nmrAmount;
        private System.Windows.Forms.Label label5;
    }
}