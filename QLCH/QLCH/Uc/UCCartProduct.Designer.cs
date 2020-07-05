namespace QLCH.Uc
{
    partial class UCCartProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCartProduct));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPriceDefault = new System.Windows.Forms.Label();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.btnUp = new Guna.UI.WinForms.GunaButton();
            this.lbNumber = new System.Windows.Forms.Label();
            this.btnDown = new Guna.UI.WinForms.GunaButton();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbPriceDefault);
            this.panel1.Controls.Add(this.gunaImageButton1);
            this.panel1.Controls.Add(this.gunaElipsePanel1);
            this.panel1.Controls.Add(this.lbPrice);
            this.panel1.Controls.Add(this.lbProductName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(126, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 107);
            this.panel1.TabIndex = 1;
            // 
            // lbPriceDefault
            // 
            this.lbPriceDefault.AutoSize = true;
            this.lbPriceDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriceDefault.Location = new System.Drawing.Point(174, 83);
            this.lbPriceDefault.Name = "lbPriceDefault";
            this.lbPriceDefault.Size = new System.Drawing.Size(28, 13);
            this.lbPriceDefault.TabIndex = 4;
            this.lbPriceDefault.Text = "101";
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.Image")));
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaImageButton1.Location = new System.Drawing.Point(374, 37);
            this.gunaImageButton1.Name = "gunaImageButton1";
            this.gunaImageButton1.OnHoverImage = null;
            this.gunaImageButton1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.gunaImageButton1.Size = new System.Drawing.Size(37, 32);
            this.gunaImageButton1.TabIndex = 3;
            this.gunaImageButton1.Click += new System.EventHandler(this.gunaImageButton1_Click);
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.btnUp);
            this.gunaElipsePanel1.Controls.Add(this.lbNumber);
            this.gunaElipsePanel1.Controls.Add(this.btnDown);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(142, 37);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 7;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(107, 32);
            this.gunaElipsePanel1.TabIndex = 2;
            // 
            // btnUp
            // 
            this.btnUp.AnimationHoverSpeed = 0.07F;
            this.btnUp.AnimationSpeed = 0.03F;
            this.btnUp.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(205)))), ((int)(((byte)(162)))));
            this.btnUp.BorderColor = System.Drawing.Color.Black;
            this.btnUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUp.FocusedColor = System.Drawing.Color.Empty;
            this.btnUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUp.Location = new System.Drawing.Point(70, 0);
            this.btnUp.Name = "btnUp";
            this.btnUp.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(221)))), ((int)(((byte)(193)))));
            this.btnUp.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUp.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUp.OnHoverImage = null;
            this.btnUp.OnPressedColor = System.Drawing.Color.Black;
            this.btnUp.Radius = 7;
            this.btnUp.Size = new System.Drawing.Size(37, 32);
            this.btnUp.TabIndex = 7;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // lbNumber
            // 
            this.lbNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbNumber.Location = new System.Drawing.Point(35, 0);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(35, 32);
            this.lbNumber.TabIndex = 5;
            this.lbNumber.Text = "1";
            this.lbNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbNumber.TextChanged += new System.EventHandler(this.lbNumber_TextChanged);
            // 
            // btnDown
            // 
            this.btnDown.AnimationHoverSpeed = 0.07F;
            this.btnDown.AnimationSpeed = 0.03F;
            this.btnDown.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(205)))), ((int)(((byte)(162)))));
            this.btnDown.BorderColor = System.Drawing.Color.Black;
            this.btnDown.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDown.FocusedColor = System.Drawing.Color.Empty;
            this.btnDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDown.ForeColor = System.Drawing.Color.White;
            this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
            this.btnDown.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDown.Location = new System.Drawing.Point(0, 0);
            this.btnDown.Name = "btnDown";
            this.btnDown.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(221)))), ((int)(((byte)(193)))));
            this.btnDown.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDown.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDown.OnHoverImage = null;
            this.btnDown.OnPressedColor = System.Drawing.Color.Black;
            this.btnDown.Radius = 7;
            this.btnDown.Size = new System.Drawing.Size(35, 32);
            this.btnDown.TabIndex = 6;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(302, 45);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(28, 13);
            this.lbPrice.TabIndex = 1;
            this.lbPrice.Text = "100";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductName.Location = new System.Drawing.Point(6, 45);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(41, 13);
            this.lbProductName.TabIndex = 0;
            this.lbProductName.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UCCartProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCCartProduct";
            this.Size = new System.Drawing.Size(553, 107);
            this.Load += new System.EventHandler(this.UCCartProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gunaElipsePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaButton btnUp;
        private Guna.UI.WinForms.GunaButton btnDown;
        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbProductName;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private System.Windows.Forms.Label lbPriceDefault;
    }
}
