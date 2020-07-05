namespace QLCH.Uc
{
    partial class frmAssign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssign));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lbID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pnlContent = new Guna.UI.WinForms.GunaPanel();
            this.btnAssign = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnAccount = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.ptbClose);
            this.pnlTitle.Controls.Add(this.lbID);
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(965, 35);
            this.pnlTitle.TabIndex = 0;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(465, 9);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(13, 13);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân viên:";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 10;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.pnlTitle;
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 9;
            this.gunaElipse2.TargetControl = this.btnAccount;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.Radius = 9;
            this.gunaElipse3.TargetControl = this.btnAssign;
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlContent.Location = new System.Drawing.Point(0, 87);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(965, 569);
            this.pnlContent.TabIndex = 2;
            // 
            // btnAssign
            // 
            this.btnAssign.AnimationHoverSpeed = 0.07F;
            this.btnAssign.AnimationSpeed = 0.03F;
            this.btnAssign.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(165)))), ((int)(((byte)(178)))));
            this.btnAssign.BorderColor = System.Drawing.Color.Black;
            this.btnAssign.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAssign.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAssign.CheckedForeColor = System.Drawing.Color.White;
            this.btnAssign.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAssign.CheckedImage")));
            this.btnAssign.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAssign.FocusedColor = System.Drawing.Color.Empty;
            this.btnAssign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.ForeColor = System.Drawing.Color.White;
            this.btnAssign.Image = ((System.Drawing.Image)(resources.GetObject("btnAssign.Image")));
            this.btnAssign.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAssign.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAssign.Location = new System.Drawing.Point(545, 41);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAssign.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAssign.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAssign.OnHoverImage = null;
            this.btnAssign.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAssign.OnPressedColor = System.Drawing.Color.Black;
            this.btnAssign.Size = new System.Drawing.Size(120, 40);
            this.btnAssign.TabIndex = 1;
            this.btnAssign.Text = "Phân công";
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.AnimationHoverSpeed = 0.07F;
            this.btnAccount.AnimationSpeed = 0.03F;
            this.btnAccount.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(165)))), ((int)(((byte)(178)))));
            this.btnAccount.BorderColor = System.Drawing.Color.Black;
            this.btnAccount.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAccount.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAccount.CheckedForeColor = System.Drawing.Color.White;
            this.btnAccount.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnAccount.CheckedImage")));
            this.btnAccount.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAccount.FocusedColor = System.Drawing.Color.Empty;
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAccount.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAccount.Location = new System.Drawing.Point(278, 41);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAccount.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAccount.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAccount.OnHoverImage = null;
            this.btnAccount.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAccount.OnPressedColor = System.Drawing.Color.Black;
            this.btnAccount.Size = new System.Drawing.Size(127, 40);
            this.btnAccount.TabIndex = 1;
            this.btnAccount.Text = "Cấp mật khẩu";
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // ptbClose
            // 
            this.ptbClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbClose.Image = global::QLCH.Properties.Resources.icons8_delete_40;
            this.ptbClose.Location = new System.Drawing.Point(930, 0);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(35, 35);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbClose.TabIndex = 1;
            this.ptbClose.TabStop = false;
            this.ptbClose.Click += new System.EventHandler(this.ptbClose_Click);
            // 
            // frmAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(965, 656);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAssign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAssign";
            this.Load += new System.EventHandler(this.frmAssign_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbClose;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private System.Windows.Forms.Label lbID;
        private Guna.UI.WinForms.GunaAdvenceButton btnAssign;
        private Guna.UI.WinForms.GunaAdvenceButton btnAccount;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private Guna.UI.WinForms.GunaPanel pnlContent;
    }
}