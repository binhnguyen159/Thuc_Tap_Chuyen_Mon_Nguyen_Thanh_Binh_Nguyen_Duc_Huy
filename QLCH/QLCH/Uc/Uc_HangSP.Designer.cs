namespace QLCH.Uc
{
    partial class Uc_HangSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uc_HangSP));
            this.txtNameBrand = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtIDBrand = new Guna.UI.WinForms.GunaLineTextBox();
            this.dgvHangSP = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new Guna.UI.WinForms.GunaButton();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.btnFind = new Guna.UI.WinForms.GunaButton();
            this.btnUp = new Guna.UI.WinForms.GunaButton();
            this.btnDel = new Guna.UI.WinForms.GunaButton();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.rdbBrandName = new System.Windows.Forms.CheckBox();
            this.rdbBrandID = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangSP)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNameBrand
            // 
            this.txtNameBrand.BackColor = System.Drawing.Color.White;
            this.txtNameBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameBrand.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNameBrand.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameBrand.LineColor = System.Drawing.Color.Gainsboro;
            this.txtNameBrand.Location = new System.Drawing.Point(91, 89);
            this.txtNameBrand.Name = "txtNameBrand";
            this.txtNameBrand.PasswordChar = '\0';
            this.txtNameBrand.Size = new System.Drawing.Size(160, 26);
            this.txtNameBrand.TabIndex = 27;
            // 
            // txtIDBrand
            // 
            this.txtIDBrand.BackColor = System.Drawing.Color.White;
            this.txtIDBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDBrand.Enabled = false;
            this.txtIDBrand.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtIDBrand.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDBrand.LineColor = System.Drawing.Color.Gainsboro;
            this.txtIDBrand.Location = new System.Drawing.Point(91, 49);
            this.txtIDBrand.Name = "txtIDBrand";
            this.txtIDBrand.PasswordChar = '\0';
            this.txtIDBrand.Size = new System.Drawing.Size(160, 26);
            this.txtIDBrand.TabIndex = 26;
            // 
            // dgvHangSP
            // 
            this.dgvHangSP.AllowUserToAddRows = false;
            this.dgvHangSP.AllowUserToDeleteRows = false;
            this.dgvHangSP.AllowUserToResizeColumns = false;
            this.dgvHangSP.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dgvHangSP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHangSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHangSP.BackgroundColor = System.Drawing.Color.White;
            this.dgvHangSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHangSP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHangSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHangSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHangSP.ColumnHeadersHeight = 21;
            this.dgvHangSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHangSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHangSP.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHangSP.EnableHeadersVisualStyles = false;
            this.dgvHangSP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dgvHangSP.Location = new System.Drawing.Point(202, 267);
            this.dgvHangSP.Name = "dgvHangSP";
            this.dgvHangSP.ReadOnly = true;
            this.dgvHangSP.RowHeadersVisible = false;
            this.dgvHangSP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvHangSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHangSP.Size = new System.Drawing.Size(556, 361);
            this.dgvHangSP.TabIndex = 25;
            this.dgvHangSP.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Cyan;
            this.dgvHangSP.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dgvHangSP.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvHangSP.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvHangSP.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvHangSP.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvHangSP.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvHangSP.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.dgvHangSP.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            this.dgvHangSP.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvHangSP.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHangSP.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvHangSP.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHangSP.ThemeStyle.HeaderStyle.Height = 21;
            this.dgvHangSP.ThemeStyle.ReadOnly = true;
            this.dgvHangSP.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.dgvHangSP.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHangSP.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvHangSP.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvHangSP.ThemeStyle.RowsStyle.Height = 22;
            this.dgvHangSP.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            this.dgvHangSP.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvHangSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangSP_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maHang";
            this.Column1.HeaderText = "Mã hãng";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tenHang";
            this.Column2.HeaderText = "Tên hãng";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID:";
            // 
            // btnCancel
            // 
            this.btnCancel.AnimationHoverSpeed = 0.07F;
            this.btnCancel.AnimationSpeed = 0.03F;
            this.btnCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.Enabled = false;
            this.btnCancel.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancel.Location = new System.Drawing.Point(690, 171);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancel.OnHoverImage = null;
            this.btnCancel.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancel.Size = new System.Drawing.Size(96, 42);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.Enabled = false;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(539, 171);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Size = new System.Drawing.Size(82, 42);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFind
            // 
            this.btnFind.AnimationHoverSpeed = 0.07F;
            this.btnFind.AnimationSpeed = 0.03F;
            this.btnFind.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnFind.BorderColor = System.Drawing.Color.Black;
            this.btnFind.FocusedColor = System.Drawing.Color.Empty;
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFind.Location = new System.Drawing.Point(107, 148);
            this.btnFind.Name = "btnFind";
            this.btnFind.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnFind.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFind.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFind.OnHoverImage = null;
            this.btnFind.OnPressedColor = System.Drawing.Color.Black;
            this.btnFind.Size = new System.Drawing.Size(102, 42);
            this.btnFind.TabIndex = 22;
            this.btnFind.Text = "Finding";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnUp
            // 
            this.btnUp.AnimationHoverSpeed = 0.07F;
            this.btnUp.AnimationSpeed = 0.03F;
            this.btnUp.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnUp.BorderColor = System.Drawing.Color.Black;
            this.btnUp.FocusedColor = System.Drawing.Color.Empty;
            this.btnUp.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUp.Location = new System.Drawing.Point(781, 60);
            this.btnUp.Name = "btnUp";
            this.btnUp.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUp.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUp.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUp.OnHoverImage = null;
            this.btnUp.OnPressedColor = System.Drawing.Color.Black;
            this.btnUp.Size = new System.Drawing.Size(99, 42);
            this.btnUp.TabIndex = 21;
            this.btnUp.Text = "Update";
            this.btnUp.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.AnimationHoverSpeed = 0.07F;
            this.btnDel.AnimationSpeed = 0.03F;
            this.btnDel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnDel.BorderColor = System.Drawing.Color.Black;
            this.btnDel.FocusedColor = System.Drawing.Color.Empty;
            this.btnDel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDel.Location = new System.Drawing.Point(608, 60);
            this.btnDel.Name = "btnDel";
            this.btnDel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnDel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDel.OnHoverImage = null;
            this.btnDel.OnPressedColor = System.Drawing.Color.Black;
            this.btnDel.Size = new System.Drawing.Size(95, 42);
            this.btnDel.TabIndex = 20;
            this.btnDel.Text = "Delete";
            this.btnDel.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.Location = new System.Drawing.Point(446, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Size = new System.Drawing.Size(84, 42);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rdbBrandName
            // 
            this.rdbBrandName.AutoSize = true;
            this.rdbBrandName.Location = new System.Drawing.Point(270, 101);
            this.rdbBrandName.Name = "rdbBrandName";
            this.rdbBrandName.Size = new System.Drawing.Size(15, 14);
            this.rdbBrandName.TabIndex = 37;
            this.rdbBrandName.UseVisualStyleBackColor = true;
            this.rdbBrandName.CheckedChanged += new System.EventHandler(this.rdbBrandID_CheckedChanged_1);
            // 
            // rdbBrandID
            // 
            this.rdbBrandID.AutoSize = true;
            this.rdbBrandID.Location = new System.Drawing.Point(270, 61);
            this.rdbBrandID.Name = "rdbBrandID";
            this.rdbBrandID.Size = new System.Drawing.Size(15, 14);
            this.rdbBrandID.TabIndex = 36;
            this.rdbBrandID.UseVisualStyleBackColor = true;
            this.rdbBrandID.CheckedChanged += new System.EventHandler(this.rdbBrandID_CheckedChanged_1);
            // 
            // Uc_HangSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rdbBrandName);
            this.Controls.Add(this.rdbBrandID);
            this.Controls.Add(this.txtNameBrand);
            this.Controls.Add(this.txtIDBrand);
            this.Controls.Add(this.dgvHangSP);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Uc_HangSP";
            this.Size = new System.Drawing.Size(965, 656);
            this.Load += new System.EventHandler(this.Uc_HangSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLineTextBox txtNameBrand;
        private Guna.UI.WinForms.GunaLineTextBox txtIDBrand;
        private Guna.UI.WinForms.GunaDataGridView dgvHangSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private Guna.UI.WinForms.GunaButton btnCancel;
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaButton btnFind;
        private Guna.UI.WinForms.GunaButton btnUp;
        private Guna.UI.WinForms.GunaButton btnDel;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox rdbBrandName;
        private System.Windows.Forms.CheckBox rdbBrandID;
    }
}
