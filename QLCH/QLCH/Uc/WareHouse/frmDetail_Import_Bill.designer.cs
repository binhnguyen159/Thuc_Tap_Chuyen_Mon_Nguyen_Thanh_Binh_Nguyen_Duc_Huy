namespace QLCH.Uc.WareHouse
{
    partial class frmDetail_Import_Bill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetail_Import_Bill));
            this.dgvCTPN = new Guna.UI.WinForms.GunaDataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbExit = new Guna.UI.WinForms.GunaPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbBillID = new System.Windows.Forms.Label();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSL = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtGia = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.btnThanhToan = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCTPN
            // 
            this.dgvCTPN.AllowUserToAddRows = false;
            this.dgvCTPN.AllowUserToDeleteRows = false;
            this.dgvCTPN.AllowUserToResizeColumns = false;
            this.dgvCTPN.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvCTPN.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCTPN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTPN.BackgroundColor = System.Drawing.Color.White;
            this.dgvCTPN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCTPN.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCTPN.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTPN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCTPN.ColumnHeadersHeight = 21;
            this.dgvCTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCTPN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column6,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCTPN.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCTPN.EnableHeadersVisualStyles = false;
            this.dgvCTPN.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvCTPN.Location = new System.Drawing.Point(0, 199);
            this.dgvCTPN.Name = "dgvCTPN";
            this.dgvCTPN.ReadOnly = true;
            this.dgvCTPN.RowHeadersVisible = false;
            this.dgvCTPN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTPN.Size = new System.Drawing.Size(933, 272);
            this.dgvCTPN.TabIndex = 1;
            this.dgvCTPN.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Dark;
            this.dgvCTPN.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dgvCTPN.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCTPN.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCTPN.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCTPN.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCTPN.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCTPN.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dgvCTPN.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dgvCTPN.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCTPN.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCTPN.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCTPN.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCTPN.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvCTPN.ThemeStyle.ReadOnly = true;
            this.dgvCTPN.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dgvCTPN.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCTPN.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCTPN.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCTPN.ThemeStyle.RowsStyle.Height = 22;
            this.dgvCTPN.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dgvCTPN.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCTPN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTPN_CellClick);
            this.dgvCTPN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTPN_CellContentClick);
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "masp";
            this.Column4.HeaderText = "ID product";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tenSP";
            this.Column1.HeaderText = "Product";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "donGia";
            this.Column5.HeaderText = "Price";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "soLuong";
            this.Column2.HeaderText = "Amount";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "thanhTien";
            this.Column6.HeaderText = "Total price";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Delete";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column3.Text = "Choose";
            this.Column3.UseColumnTextForButtonValue = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ptbExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbBillID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 62);
            this.panel1.TabIndex = 2;
            // 
            // ptbExit
            // 
            this.ptbExit.BaseColor = System.Drawing.Color.White;
            this.ptbExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbExit.Image = global::QLCH.Properties.Resources.icons8_delete_40;
            this.ptbExit.Location = new System.Drawing.Point(898, 0);
            this.ptbExit.Name = "ptbExit";
            this.ptbExit.Size = new System.Drawing.Size(35, 62);
            this.ptbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbExit.TabIndex = 1;
            this.ptbExit.TabStop = false;
            this.ptbExit.Click += new System.EventHandler(this.ptbExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill import ID:";
            // 
            // lbBillID
            // 
            this.lbBillID.AutoSize = true;
            this.lbBillID.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBillID.Location = new System.Drawing.Point(516, 19);
            this.lbBillID.Name = "lbBillID";
            this.lbBillID.Size = new System.Drawing.Size(118, 31);
            this.lbBillID.TabIndex = 0;
            this.lbBillID.Text = "Mã phiếu";
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.panel1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(704, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount:";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.HintForeColor = System.Drawing.Color.Empty;
            this.txtName.HintText = "";
            this.txtName.isPassword = false;
            this.txtName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtName.LineThickness = 3;
            this.txtName.Location = new System.Drawing.Point(41, 101);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(237, 29);
            this.txtName.TabIndex = 5;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSL
            // 
            this.txtSL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSL.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSL.HintForeColor = System.Drawing.Color.Empty;
            this.txtSL.HintText = "";
            this.txtSL.isPassword = false;
            this.txtSL.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSL.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSL.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSL.LineThickness = 3;
            this.txtSL.Location = new System.Drawing.Point(391, 101);
            this.txtSL.Margin = new System.Windows.Forms.Padding(4);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(123, 29);
            this.txtSL.TabIndex = 5;
            this.txtSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtGia
            // 
            this.txtGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGia.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGia.HintForeColor = System.Drawing.Color.Empty;
            this.txtGia.HintText = "";
            this.txtGia.isPassword = false;
            this.txtGia.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtGia.LineIdleColor = System.Drawing.Color.Gray;
            this.txtGia.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtGia.LineThickness = 3;
            this.txtGia.Location = new System.Drawing.Point(707, 101);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(159, 29);
            this.txtGia.TabIndex = 5;
            this.txtGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor = System.Drawing.Color.White;
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.BorderSize = 2;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Image = global::QLCH.Properties.Resources.icons8_update_100;
            this.btnUpdate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdate.Location = new System.Drawing.Point(399, 149);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = global::QLCH.Properties.Resources.icons8_update_10011;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 7;
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(758, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total :";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Location = new System.Drawing.Point(804, 505);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(38, 15);
            this.lbTongTien.TabIndex = 9;
            this.lbTongTien.Text = "label6";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.AnimationHoverSpeed = 0.07F;
            this.btnThanhToan.AnimationSpeed = 0.03F;
            this.btnThanhToan.BackColor = System.Drawing.Color.Transparent;
            this.btnThanhToan.BaseColor = System.Drawing.Color.White;
            this.btnThanhToan.BorderColor = System.Drawing.Color.Black;
            this.btnThanhToan.BorderSize = 2;
            this.btnThanhToan.FocusedColor = System.Drawing.Color.Empty;
            this.btnThanhToan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.Black;
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThanhToan.Location = new System.Drawing.Point(424, 531);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThanhToan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThanhToan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThanhToan.OnHoverImage = null;
            this.btnThanhToan.OnPressedColor = System.Drawing.Color.Black;
            this.btnThanhToan.Radius = 7;
            this.btnThanhToan.Size = new System.Drawing.Size(75, 30);
            this.btnThanhToan.TabIndex = 7;
            this.btnThanhToan.Text = "Pay";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // frmDetail_Import_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(933, 582);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCTPN);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDetail_Import_Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetail_Import_Bill";
            this.Load += new System.EventHandler(this.frmDetail_Import_Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaDataGridView dgvCTPN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbBillID;
        private Guna.UI.WinForms.GunaPictureBox ptbExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSL;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtGia;
        private Guna.UI.WinForms.GunaButton btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbTongTien;
        private Guna.UI.WinForms.GunaButton btnThanhToan;
    }
}