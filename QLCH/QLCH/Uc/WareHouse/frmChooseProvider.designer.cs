namespace QLCH.Uc.WareHouse
{
    partial class frmChooseProvider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChooseProvider));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.ptbExit = new Guna.UI.WinForms.GunaPictureBox();
            this.btnChoose = new Guna.UI.WinForms.GunaButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.cbbNCC = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(207, 7);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(197, 27);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Chọn nhà cung cấp";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ptbExit);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 40);
            this.panel1.TabIndex = 2;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(80, 68);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(84, 15);
            this.gunaLabel2.TabIndex = 0;
            this.gunaLabel2.Text = "Nhà cung cấp:";
            // 
            // ptbExit
            // 
            this.ptbExit.BaseColor = System.Drawing.Color.White;
            this.ptbExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbExit.Image = global::QLCH.Properties.Resources.icons8_delete_40;
            this.ptbExit.Location = new System.Drawing.Point(573, 0);
            this.ptbExit.Name = "ptbExit";
            this.ptbExit.Size = new System.Drawing.Size(35, 40);
            this.ptbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbExit.TabIndex = 1;
            this.ptbExit.TabStop = false;
            this.ptbExit.Click += new System.EventHandler(this.ptbExit_Click);
            // 
            // btnChoose
            // 
            this.btnChoose.AnimationHoverSpeed = 0.07F;
            this.btnChoose.AnimationSpeed = 0.03F;
            this.btnChoose.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnChoose.BorderColor = System.Drawing.Color.Black;
            this.btnChoose.FocusedColor = System.Drawing.Color.Empty;
            this.btnChoose.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoose.ForeColor = System.Drawing.Color.White;
            this.btnChoose.Image = ((System.Drawing.Image)(resources.GetObject("btnChoose.Image")));
            this.btnChoose.ImageSize = new System.Drawing.Size(20, 20);
            this.btnChoose.Location = new System.Drawing.Point(274, 99);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnChoose.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChoose.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChoose.OnHoverImage = null;
            this.btnChoose.OnPressedColor = System.Drawing.Color.Black;
            this.btnChoose.Size = new System.Drawing.Size(95, 42);
            this.btnChoose.TabIndex = 3;
            this.btnChoose.Text = "Choose";
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this.btnChoose;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 7;
            this.gunaElipse2.TargetControl = this;
            // 
            // cbbNCC
            // 
            this.cbbNCC.FormattingEnabled = true;
            this.cbbNCC.Location = new System.Drawing.Point(181, 65);
            this.cbbNCC.Name = "cbbNCC";
            this.cbbNCC.Size = new System.Drawing.Size(342, 23);
            this.cbbNCC.TabIndex = 4;
            // 
            // frmChooseProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 161);
            this.Controls.Add(this.cbbNCC);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChooseProvider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmChooseProvider";
            this.Load += new System.EventHandler(this.frmChooseProvider_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaPictureBox ptbExit;
        private Guna.UI.WinForms.GunaButton btnChoose;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private System.Windows.Forms.ComboBox cbbNCC;
    }
}