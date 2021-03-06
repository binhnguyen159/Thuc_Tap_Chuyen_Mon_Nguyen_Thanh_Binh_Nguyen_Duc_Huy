﻿namespace QLCH.Uc
{
    partial class Uc_Bill_Buy
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uc_Bill_Buy));
            this.dgvBillBuy = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTo = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtpFrom = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btnShow = new Guna.UI.WinForms.GunaButton();
            this.lbNote = new System.Windows.Forms.Label();
            this.rtxtNote = new System.Windows.Forms.RichTextBox();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.btnPrintBill = new Guna.UI.WinForms.GunaButton();
            this.btnMail = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillBuy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBillBuy
            // 
            this.dgvBillBuy.AllowUserToAddRows = false;
            this.dgvBillBuy.AllowUserToDeleteRows = false;
            this.dgvBillBuy.AllowUserToResizeColumns = false;
            this.dgvBillBuy.AllowUserToResizeRows = false;

            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvBillBuy.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBillBuy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBillBuy.BackgroundColor = System.Drawing.Color.White;
            this.dgvBillBuy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBillBuy.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBillBuy.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBillBuy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;



            this.dgvBillBuy.ColumnHeadersHeight = 21;
            this.dgvBillBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBillBuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});

            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBillBuy.DefaultCellStyle = dataGridViewCellStyle3;

            this.dgvBillBuy.EnableHeadersVisualStyles = false;
            this.dgvBillBuy.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvBillBuy.Location = new System.Drawing.Point(13, 110);
            this.dgvBillBuy.Name = "dgvBillBuy";
            this.dgvBillBuy.ReadOnly = true;
            this.dgvBillBuy.RowHeadersVisible = false;
            this.dgvBillBuy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBillBuy.Size = new System.Drawing.Size(932, 394);
            this.dgvBillBuy.TabIndex = 10;
            this.dgvBillBuy.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Dark;
            this.dgvBillBuy.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvBillBuy.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBillBuy.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBillBuy.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBillBuy.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBillBuy.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBillBuy.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvBillBuy.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvBillBuy.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvBillBuy.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBillBuy.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBillBuy.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBillBuy.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvBillBuy.ThemeStyle.ReadOnly = true;
            this.dgvBillBuy.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvBillBuy.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBillBuy.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBillBuy.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBillBuy.ThemeStyle.RowsStyle.Height = 22;
            this.dgvBillBuy.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvBillBuy.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvBillBuy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillBuy_CellClick);
            this.dgvBillBuy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBillBuy_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maHDN";
            this.Column1.HeaderText = "Bill ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ngayNhap";
            this.Column2.HeaderText = "Invoice date";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tongTien";
            this.Column3.HeaderText = "Total money";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "trangThai";
            this.Column4.HeaderText = "Status";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Detail";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column5.Text = "Select";
            this.Column5.UseColumnTextForButtonValue = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Cancel";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Text = "Select";
            this.Column6.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(544, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "From:";
            // 
            // dtpTo
            // 
            this.dtpTo.BaseColor = System.Drawing.Color.White;
            this.dtpTo.BorderColor = System.Drawing.Color.Silver;
            this.dtpTo.CustomFormat = null;
            this.dtpTo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpTo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpTo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.ForeColor = System.Drawing.Color.Black;
            this.dtpTo.Location = new System.Drawing.Point(573, 13);
            this.dtpTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpTo.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpTo.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpTo.OnPressedColor = System.Drawing.Color.Black;
            this.dtpTo.Size = new System.Drawing.Size(223, 30);
            this.dtpTo.TabIndex = 7;
            this.dtpTo.Text = "Saturday, July 4, 2020";
            this.dtpTo.Value = new System.DateTime(2020, 7, 4, 16, 11, 27, 376);
            // 
            // dtpFrom
            // 
            this.dtpFrom.BaseColor = System.Drawing.Color.White;
            this.dtpFrom.BorderColor = System.Drawing.Color.Silver;
            this.dtpFrom.CustomFormat = null;
            this.dtpFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFrom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFrom.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.ForeColor = System.Drawing.Color.Black;
            this.dtpFrom.Location = new System.Drawing.Point(156, 13);
            this.dtpFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFrom.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFrom.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFrom.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFrom.Size = new System.Drawing.Size(223, 30);
            this.dtpFrom.TabIndex = 6;
            this.dtpFrom.Text = "Saturday, July 4, 2020";
            this.dtpFrom.Value = new System.DateTime(2020, 7, 4, 16, 11, 25, 992);
            // 
            // btnShow
            // 
            this.btnShow.AnimationHoverSpeed = 0.07F;
            this.btnShow.AnimationSpeed = 0.03F;
            this.btnShow.BackColor = System.Drawing.Color.Transparent;
            this.btnShow.BaseColor = System.Drawing.Color.White;
            this.btnShow.BorderColor = System.Drawing.Color.Black;
            this.btnShow.BorderSize = 2;
            this.btnShow.FocusedColor = System.Drawing.Color.Empty;
            this.btnShow.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.Black;
            this.btnShow.Image = ((System.Drawing.Image)(resources.GetObject("btnShow.Image")));
            this.btnShow.ImageSize = new System.Drawing.Size(20, 20);
            this.btnShow.Location = new System.Drawing.Point(429, 36);
            this.btnShow.Name = "btnShow";
            this.btnShow.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.btnShow.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnShow.OnHoverForeColor = System.Drawing.Color.White;
            this.btnShow.OnHoverImage = null;
            this.btnShow.OnPressedColor = System.Drawing.Color.Black;
            this.btnShow.Radius = 8;
            this.btnShow.Size = new System.Drawing.Size(82, 42);
            this.btnShow.TabIndex = 11;
            this.btnShow.Text = "Show";
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Location = new System.Drawing.Point(10, 521);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(36, 15);
            this.lbNote.TabIndex = 15;
            this.lbNote.Text = "Note:";
            // 
            // rtxtNote
            // 
            this.rtxtNote.Location = new System.Drawing.Point(54, 518);
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(791, 125);
            this.rtxtNote.TabIndex = 14;
            this.rtxtNote.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.White;
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.BorderSize = 2;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::QLCH.Properties.Resources.icons8_save_100;
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(863, 513);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = global::QLCH.Properties.Resources.icons8_save_100ư;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 8;
            this.btnSave.Size = new System.Drawing.Size(82, 42);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.AnimationHoverSpeed = 0.07F;
            this.btnPrintBill.AnimationSpeed = 0.03F;
            this.btnPrintBill.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintBill.BaseColor = System.Drawing.Color.White;
            this.btnPrintBill.BorderColor = System.Drawing.Color.Black;
            this.btnPrintBill.BorderSize = 2;
            this.btnPrintBill.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrintBill.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBill.ForeColor = System.Drawing.Color.Black;
            this.btnPrintBill.Image = global::QLCH.Properties.Resources.icons8_print_100;
            this.btnPrintBill.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPrintBill.Location = new System.Drawing.Point(858, 608);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.btnPrintBill.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrintBill.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPrintBill.OnHoverImage = global::QLCH.Properties.Resources.icons8_print_100__1_;
            this.btnPrintBill.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrintBill.Radius = 8;
            this.btnPrintBill.Size = new System.Drawing.Size(94, 42);
            this.btnPrintBill.TabIndex = 16;
            this.btnPrintBill.Text = "Print Bill";
            this.btnPrintBill.Visible = false;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // btnMail
            // 
            this.btnMail.AnimationHoverSpeed = 0.07F;
            this.btnMail.AnimationSpeed = 0.03F;
            this.btnMail.BackColor = System.Drawing.Color.Transparent;
            this.btnMail.BaseColor = System.Drawing.Color.White;
            this.btnMail.BorderColor = System.Drawing.Color.Black;
            this.btnMail.BorderSize = 2;
            this.btnMail.FocusedColor = System.Drawing.Color.Empty;
            this.btnMail.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMail.ForeColor = System.Drawing.Color.Black;
            this.btnMail.Image = global::QLCH.Properties.Resources.icons8_new_post_100;
            this.btnMail.ImageSize = new System.Drawing.Size(20, 20);
            this.btnMail.Location = new System.Drawing.Point(863, 561);
            this.btnMail.Name = "btnMail";
            this.btnMail.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.btnMail.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMail.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMail.OnHoverImage = global::QLCH.Properties.Resources.icons8_new_post_100__1_;
            this.btnMail.OnPressedColor = System.Drawing.Color.Black;
            this.btnMail.Radius = 8;
            this.btnMail.Size = new System.Drawing.Size(82, 42);
            this.btnMail.TabIndex = 17;
            this.btnMail.Text = "Mail";
            this.btnMail.Visible = false;
            this.btnMail.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // Uc_Bill_Buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMail);
            this.Controls.Add(this.btnPrintBill);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.rtxtNote);
            this.Controls.Add(this.dgvBillBuy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnShow);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Uc_Bill_Buy";
            this.Size = new System.Drawing.Size(965, 656);
            this.Load += new System.EventHandler(this.Uc_Bill_Buy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillBuy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView dgvBillBuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDateTimePicker dtpTo;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFrom;
        private Guna.UI.WinForms.GunaButton btnShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.RichTextBox rtxtNote;
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaButton btnPrintBill;
        private Guna.UI.WinForms.GunaButton btnMail;
    }
}
