﻿namespace QLCH
{
    partial class frmFuction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuction));
            this.pnlTab = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
<<<<<<< HEAD
            this.btnProvider = new Guna.UI.WinForms.GunaAdvenceButton();
=======
>>>>>>> 46112605d9a90d3477e9a1c02785010c56ae5ceb
            this.btnBuy = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnSell = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnReport = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnBill = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnProducts = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnCustomer = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnEmployees = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnlLogo = new Guna.UI.WinForms.GunaPanel();
            this.ptbLogo = new Guna.UI.WinForms.GunaPictureBox();
            this.pnlTitle = new Guna.UI.WinForms.GunaPanel();
            this.ptbBack = new Guna.UI.WinForms.GunaPictureBox();
            this.ptbExit = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.pnlContent = new Guna.UI.WinForms.GunaPanel();
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl3 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.pnlTab.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTab
            // 
            this.pnlTab.Controls.Add(this.gunaPanel1);
            this.pnlTab.Controls.Add(this.pnlLogo);
            this.pnlTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTab.Location = new System.Drawing.Point(0, 0);
            this.pnlTab.Name = "pnlTab";
            this.pnlTab.Size = new System.Drawing.Size(264, 700);
            this.pnlTab.TabIndex = 0;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.White;
            this.gunaPanel1.Controls.Add(this.btnProvider);
            this.gunaPanel1.Controls.Add(this.btnBuy);
            this.gunaPanel1.Controls.Add(this.btnSell);
            this.gunaPanel1.Controls.Add(this.btnReport);
            this.gunaPanel1.Controls.Add(this.btnBill);
            this.gunaPanel1.Controls.Add(this.btnProducts);
            this.gunaPanel1.Controls.Add(this.btnCustomer);
            this.gunaPanel1.Controls.Add(this.btnEmployees);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 255);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(264, 445);
            this.gunaPanel1.TabIndex = 1;
            // 
<<<<<<< HEAD
            // btnProvider
            // 
            this.btnProvider.AnimationHoverSpeed = 0.07F;
            this.btnProvider.AnimationSpeed = 0.03F;
            this.btnProvider.BaseColor = System.Drawing.Color.DarkTurquoise;
            this.btnProvider.BorderColor = System.Drawing.Color.Black;
            this.btnProvider.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnProvider.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnProvider.CheckedForeColor = System.Drawing.Color.White;
            this.btnProvider.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnProvider.CheckedImage")));
            this.btnProvider.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnProvider.FocusedColor = System.Drawing.Color.Empty;
            this.btnProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProvider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(140)))));
            this.btnProvider.Image = ((System.Drawing.Image)(resources.GetObject("btnProvider.Image")));
            this.btnProvider.ImageSize = new System.Drawing.Size(20, 20);
            this.btnProvider.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnProvider.Location = new System.Drawing.Point(5, 391);
            this.btnProvider.Name = "btnProvider";
            this.btnProvider.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnProvider.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnProvider.OnHoverForeColor = System.Drawing.Color.White;
            this.btnProvider.OnHoverImage = null;
            this.btnProvider.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnProvider.OnPressedColor = System.Drawing.Color.Black;
            this.btnProvider.Size = new System.Drawing.Size(253, 49);
            this.btnProvider.TabIndex = 8;
            this.btnProvider.Text = "Provider";
            this.btnProvider.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnProvider.Click += new System.EventHandler(this.btnProvider_Click);
            // 
=======
>>>>>>> 46112605d9a90d3477e9a1c02785010c56ae5ceb
            // btnBuy
            // 
            this.btnBuy.AnimationHoverSpeed = 0.07F;
            this.btnBuy.AnimationSpeed = 0.03F;
            this.btnBuy.BaseColor = System.Drawing.Color.DarkTurquoise;
            this.btnBuy.BorderColor = System.Drawing.Color.Black;
            this.btnBuy.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBuy.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBuy.CheckedForeColor = System.Drawing.Color.White;
            this.btnBuy.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnBuy.CheckedImage")));
            this.btnBuy.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBuy.FocusedColor = System.Drawing.Color.Empty;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(140)))));
            this.btnBuy.Image = ((System.Drawing.Image)(resources.GetObject("btnBuy.Image")));
            this.btnBuy.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBuy.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBuy.Location = new System.Drawing.Point(22, 281);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnBuy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBuy.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBuy.OnHoverImage = null;
            this.btnBuy.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBuy.OnPressedColor = System.Drawing.Color.Black;
            this.btnBuy.Size = new System.Drawing.Size(236, 49);
            this.btnBuy.TabIndex = 5;
            this.btnBuy.Text = "Buy";
            this.btnBuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBuy.Visible = false;
            // 
            // btnSell
            // 
            this.btnSell.AnimationHoverSpeed = 0.07F;
            this.btnSell.AnimationSpeed = 0.03F;
            this.btnSell.BaseColor = System.Drawing.Color.DarkTurquoise;
            this.btnSell.BorderColor = System.Drawing.Color.Black;
            this.btnSell.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnSell.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnSell.CheckedForeColor = System.Drawing.Color.White;
            this.btnSell.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnSell.CheckedImage")));
            this.btnSell.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnSell.FocusedColor = System.Drawing.Color.Empty;
            this.btnSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(140)))));
            this.btnSell.Image = ((System.Drawing.Image)(resources.GetObject("btnSell.Image")));
            this.btnSell.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSell.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSell.Location = new System.Drawing.Point(22, 336);
            this.btnSell.Name = "btnSell";
            this.btnSell.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSell.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSell.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSell.OnHoverImage = null;
            this.btnSell.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnSell.OnPressedColor = System.Drawing.Color.Black;
            this.btnSell.Size = new System.Drawing.Size(236, 49);
            this.btnSell.TabIndex = 6;
            this.btnSell.Text = "Sell";
            this.btnSell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSell.Visible = false;
            // 
            // btnReport
            // 
            this.btnReport.AnimationHoverSpeed = 0.07F;
            this.btnReport.AnimationSpeed = 0.03F;
            this.btnReport.BaseColor = System.Drawing.Color.DarkTurquoise;
            this.btnReport.BorderColor = System.Drawing.Color.Black;
            this.btnReport.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnReport.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnReport.CheckedForeColor = System.Drawing.Color.White;
            this.btnReport.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnReport.CheckedImage")));
            this.btnReport.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnReport.FocusedColor = System.Drawing.Color.Empty;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(140)))));
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageSize = new System.Drawing.Size(20, 20);
            this.btnReport.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReport.Location = new System.Drawing.Point(5, 226);
            this.btnReport.Name = "btnReport";
            this.btnReport.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnReport.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReport.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReport.OnHoverImage = null;
            this.btnReport.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnReport.OnPressedColor = System.Drawing.Color.Black;
            this.btnReport.Size = new System.Drawing.Size(253, 49);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "Report";
            this.btnReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBill
            // 
            this.btnBill.AnimationHoverSpeed = 0.07F;
            this.btnBill.AnimationSpeed = 0.03F;
            this.btnBill.BaseColor = System.Drawing.Color.DarkTurquoise;
            this.btnBill.BorderColor = System.Drawing.Color.Black;
            this.btnBill.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnBill.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnBill.CheckedForeColor = System.Drawing.Color.White;
            this.btnBill.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnBill.CheckedImage")));
            this.btnBill.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnBill.FocusedColor = System.Drawing.Color.Empty;
            this.btnBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(140)))));
            this.btnBill.Image = ((System.Drawing.Image)(resources.GetObject("btnBill.Image")));
            this.btnBill.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBill.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBill.Location = new System.Drawing.Point(5, 171);
            this.btnBill.Name = "btnBill";
            this.btnBill.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnBill.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBill.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBill.OnHoverImage = null;
            this.btnBill.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnBill.OnPressedColor = System.Drawing.Color.Black;
            this.btnBill.Size = new System.Drawing.Size(253, 49);
            this.btnBill.TabIndex = 4;
            this.btnBill.Text = "Bill";
            this.btnBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.AnimationHoverSpeed = 0.07F;
            this.btnProducts.AnimationSpeed = 0.03F;
            this.btnProducts.BaseColor = System.Drawing.Color.DarkTurquoise;
            this.btnProducts.BorderColor = System.Drawing.Color.Black;
            this.btnProducts.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnProducts.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnProducts.CheckedForeColor = System.Drawing.Color.White;
            this.btnProducts.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnProducts.CheckedImage")));
            this.btnProducts.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnProducts.FocusedColor = System.Drawing.Color.Empty;
            this.btnProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(140)))));
            this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
            this.btnProducts.ImageSize = new System.Drawing.Size(20, 20);
            this.btnProducts.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnProducts.Location = new System.Drawing.Point(5, 116);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnProducts.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnProducts.OnHoverForeColor = System.Drawing.Color.White;
            this.btnProducts.OnHoverImage = null;
            this.btnProducts.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnProducts.OnPressedColor = System.Drawing.Color.Black;
            this.btnProducts.Size = new System.Drawing.Size(253, 49);
            this.btnProducts.TabIndex = 3;
            this.btnProducts.Text = "Products";
            this.btnProducts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.AnimationHoverSpeed = 0.07F;
            this.btnCustomer.AnimationSpeed = 0.03F;
            this.btnCustomer.BaseColor = System.Drawing.Color.DarkTurquoise;
            this.btnCustomer.BorderColor = System.Drawing.Color.Black;
            this.btnCustomer.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnCustomer.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnCustomer.CheckedForeColor = System.Drawing.Color.White;
            this.btnCustomer.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnCustomer.CheckedImage")));
            this.btnCustomer.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnCustomer.FocusedColor = System.Drawing.Color.Empty;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(140)))));
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCustomer.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCustomer.Location = new System.Drawing.Point(5, 61);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCustomer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCustomer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCustomer.OnHoverImage = null;
            this.btnCustomer.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnCustomer.OnPressedColor = System.Drawing.Color.Black;
            this.btnCustomer.Size = new System.Drawing.Size(253, 49);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.AnimationHoverSpeed = 0.07F;
            this.btnEmployees.AnimationSpeed = 0.03F;
            this.btnEmployees.BaseColor = System.Drawing.Color.DarkTurquoise;
            this.btnEmployees.BorderColor = System.Drawing.Color.Black;
            this.btnEmployees.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnEmployees.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnEmployees.CheckedForeColor = System.Drawing.Color.White;
            this.btnEmployees.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnEmployees.CheckedImage")));
            this.btnEmployees.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnEmployees.FocusedColor = System.Drawing.Color.Empty;
            this.btnEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(140)))));
            this.btnEmployees.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployees.Image")));
            this.btnEmployees.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEmployees.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnEmployees.Location = new System.Drawing.Point(5, 6);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEmployees.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEmployees.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEmployees.OnHoverImage = null;
            this.btnEmployees.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnEmployees.OnPressedColor = System.Drawing.Color.Black;
            this.btnEmployees.Size = new System.Drawing.Size(253, 49);
            this.btnEmployees.TabIndex = 1;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEmployees.Click += new System.EventHandler(this.btnEngineer_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.ptbLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(264, 255);
            this.pnlLogo.TabIndex = 0;
            // 
            // ptbLogo
            // 
            this.ptbLogo.BaseColor = System.Drawing.Color.White;
            this.ptbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbLogo.Image = global::QLCH.Properties.Resources.logo1;
            this.ptbLogo.Location = new System.Drawing.Point(0, 0);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(264, 255);
            this.ptbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLogo.TabIndex = 0;
            this.ptbLogo.TabStop = false;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.White;
            this.pnlTitle.Controls.Add(this.ptbBack);
            this.pnlTitle.Controls.Add(this.ptbExit);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(264, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(965, 35);
            this.pnlTitle.TabIndex = 1;
            // 
            // ptbBack
            // 
            this.ptbBack.BaseColor = System.Drawing.Color.White;
            this.ptbBack.Image = global::QLCH.Properties.Resources.icons8_back_48;
            this.ptbBack.Location = new System.Drawing.Point(891, 0);
            this.ptbBack.Name = "ptbBack";
            this.ptbBack.Size = new System.Drawing.Size(35, 35);
            this.ptbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBack.TabIndex = 2;
            this.ptbBack.TabStop = false;
            this.ptbBack.Click += new System.EventHandler(this.ptbBack_Click);
            // 
            // ptbExit
            // 
            this.ptbExit.BaseColor = System.Drawing.Color.White;
            this.ptbExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbExit.Image = global::QLCH.Properties.Resources.icons8_delete_40;
            this.ptbExit.Location = new System.Drawing.Point(930, 0);
            this.ptbExit.Name = "ptbExit";
            this.ptbExit.Size = new System.Drawing.Size(35, 35);
            this.ptbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbExit.TabIndex = 0;
            this.ptbExit.TabStop = false;
            this.ptbExit.Click += new System.EventHandler(this.ptbExit_Click);
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.pnlTab;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(264, 35);
            this.pnlContent.Name = "pnlContent";
<<<<<<< HEAD
            this.pnlContent.Size = new System.Drawing.Size(965, 665);
=======
            this.pnlContent.Size = new System.Drawing.Size(965, 656);
>>>>>>> 46112605d9a90d3477e9a1c02785010c56ae5ceb
            this.pnlContent.TabIndex = 2;
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this.pnlContent;
            // 
            // gunaDragControl3
            // 
            this.gunaDragControl3.TargetControl = this.pnlTitle;
            // 
            // frmFuction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 700);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFuction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFuction";
            this.pnlTab.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pnlTab;
        private Guna.UI.WinForms.GunaPanel pnlTitle;
        private Guna.UI.WinForms.GunaPictureBox ptbBack;
        private Guna.UI.WinForms.GunaPictureBox ptbExit;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaPanel pnlContent;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl3;
        private Guna.UI.WinForms.GunaPanel pnlLogo;
        private Guna.UI.WinForms.GunaPictureBox ptbLogo;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaAdvenceButton btnEmployees;
        private Guna.UI.WinForms.GunaAdvenceButton btnBuy;
        private Guna.UI.WinForms.GunaAdvenceButton btnReport;
        private Guna.UI.WinForms.GunaAdvenceButton btnSell;
        private Guna.UI.WinForms.GunaAdvenceButton btnBill;
        private Guna.UI.WinForms.GunaAdvenceButton btnProducts;
        private Guna.UI.WinForms.GunaAdvenceButton btnCustomer;
        private Guna.UI.WinForms.GunaAdvenceButton btnProvider;
    }
}