namespace QLCH.Uc
{
    partial class FrmCartProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCartProduct));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMaCTGio = new System.Windows.Forms.Label();
            this.lbPriceDefault = new System.Windows.Forms.Label();
            this.gunaImageButton1 = new Guna.UI.WinForms.GunaImageButton();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.btnUp = new Guna.UI.WinForms.GunaButton();
            this.lbNumber = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.lbMaCTGio);
            this.panel1.Controls.Add(this.lbPriceDefault);
            this.panel1.Controls.Add(this.gunaImageButton1);
            this.panel1.Controls.Add(this.gunaElipsePanel1);
            this.panel1.Controls.Add(this.lbPrice);
            this.panel1.Controls.Add(this.lbProductName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(153, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 112);
            this.panel1.TabIndex = 3;
            // 
            // lbMaCTGio
            // 
            this.lbMaCTGio.AutoSize = true;
            this.lbMaCTGio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaCTGio.Location = new System.Drawing.Point(246, 81);
            this.lbMaCTGio.Name = "lbMaCTGio";
            this.lbMaCTGio.Size = new System.Drawing.Size(14, 13);
            this.lbMaCTGio.TabIndex = 5;
            this.lbMaCTGio.Text = "1";
            // 
            // lbPriceDefault
            // 
            this.lbPriceDefault.AutoSize = true;
            this.lbPriceDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriceDefault.Location = new System.Drawing.Point(264, 9);
            this.lbPriceDefault.Name = "lbPriceDefault";
            this.lbPriceDefault.Size = new System.Drawing.Size(28, 13);
            this.lbPriceDefault.TabIndex = 4;
            this.lbPriceDefault.Text = "101";
            this.lbPriceDefault.Visible = false;
            // 
            // gunaImageButton1
            // 
            this.gunaImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaImageButton1.Image")));
            this.gunaImageButton1.ImageSize = new System.Drawing.Size(25, 25);
            this.gunaImageButton1.Location = new System.Drawing.Point(496, 37);
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
            this.gunaElipsePanel1.Location = new System.Drawing.Point(205, 37);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 7;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(132, 32);
            this.gunaElipsePanel1.TabIndex = 2;
            // 
            // btnUp
            // 
            this.btnUp.AnimationHoverSpeed = 0.07F;
            this.btnUp.AnimationSpeed = 0.03F;
            this.btnUp.BackColor = System.Drawing.Color.Transparent;
            this.btnUp.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(205)))), ((int)(((byte)(162)))));
            this.btnUp.BorderColor = System.Drawing.Color.Black;
            this.btnUp.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUp.FocusedColor = System.Drawing.Color.Empty;
            this.btnUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUp.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUp.Location = new System.Drawing.Point(95, 0);
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
            this.lbNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbNumber.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumber.Location = new System.Drawing.Point(35, 0);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(60, 23);
            this.lbNumber.TabIndex = 6;
            this.lbNumber.Text = "1";
            this.lbNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lbNumber.TextChanged += new System.EventHandler(this.lbNumber_TextChanged);
            this.lbNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnDown
            // 
            this.btnDown.AnimationHoverSpeed = 0.07F;
            this.btnDown.AnimationSpeed = 0.03F;
            this.btnDown.BackColor = System.Drawing.Color.Transparent;
            this.btnDown.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(205)))), ((int)(((byte)(162)))));
            this.btnDown.BorderColor = System.Drawing.Color.Black;
            this.btnDown.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDown.FocusedColor = System.Drawing.Color.Empty;
            this.btnDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDown.ForeColor = System.Drawing.Color.White;
            this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
            this.btnDown.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(372, 47);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(118, 13);
            this.lbPrice.TabIndex = 1;
            this.lbPrice.Text = "100";
            this.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProductName.Location = new System.Drawing.Point(30, 47);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(41, 13);
            this.lbProductName.TabIndex = 0;
            this.lbProductName.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(20, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCartProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(719, 112);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCartProduct";
            this.Text = "FrmCartProduct";
            this.Load += new System.EventHandler(this.FrmCartProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbPriceDefault;
        private Guna.UI.WinForms.GunaImageButton gunaImageButton1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaButton btnUp;
        private Guna.UI.WinForms.GunaButton btnDown;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbMaCTGio;
        private System.Windows.Forms.TextBox lbNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}