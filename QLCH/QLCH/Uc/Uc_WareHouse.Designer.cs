namespace QLCH.Uc
{
    partial class Uc_WareHouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uc_WareHouse));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.cbbTypeFind = new Guna.UI.WinForms.GunaComboBox();
            this.txtData = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pnlSave = new Guna.UI.WinForms.GunaPanel();
            this.fpnlProduct = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaButton6 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton5 = new Guna.UI.WinForms.GunaButton();
            this.btnFind = new Guna.UI.WinForms.GunaButton();
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.btnDe = new Guna.UI.WinForms.GunaButton();
            this.btnUp = new Guna.UI.WinForms.GunaButton();
            this.gunaElipsePanel2.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.pnlSave.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this.btnFind;
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel2.Controls.Add(this.btnAdd);
            this.gunaElipsePanel2.Controls.Add(this.btnDe);
            this.gunaElipsePanel2.Controls.Add(this.btnUp);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(731, 3);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Size = new System.Drawing.Size(231, 650);
            this.gunaElipsePanel2.TabIndex = 0;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.cbbTypeFind);
            this.gunaGroupBox1.Controls.Add(this.btnFind);
            this.gunaGroupBox1.Controls.Add(this.txtData);
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(165)))), ((int)(((byte)(178)))));
            this.gunaGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(730, 144);
            this.gunaGroupBox1.TabIndex = 2;
            this.gunaGroupBox1.Text = "Tìm kiếm";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // cbbTypeFind
            // 
            this.cbbTypeFind.BackColor = System.Drawing.Color.Transparent;
            this.cbbTypeFind.BaseColor = System.Drawing.Color.White;
            this.cbbTypeFind.BorderColor = System.Drawing.Color.Silver;
            this.cbbTypeFind.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTypeFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTypeFind.FocusedColor = System.Drawing.Color.Empty;
            this.cbbTypeFind.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTypeFind.ForeColor = System.Drawing.Color.Black;
            this.cbbTypeFind.FormattingEnabled = true;
            this.cbbTypeFind.Items.AddRange(new object[] {
            "Mã sản phẩm",
            "Tên sản phẩm"});
            this.cbbTypeFind.Location = new System.Drawing.Point(258, 37);
            this.cbbTypeFind.Name = "cbbTypeFind";
            this.cbbTypeFind.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbTypeFind.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbTypeFind.Size = new System.Drawing.Size(216, 23);
            this.cbbTypeFind.TabIndex = 5;
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.Color.White;
            this.txtData.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtData.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtData.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.LineColor = System.Drawing.Color.Gainsboro;
            this.txtData.Location = new System.Drawing.Point(238, 72);
            this.txtData.Name = "txtData";
            this.txtData.PasswordChar = '\0';
            this.txtData.Size = new System.Drawing.Size(242, 26);
            this.txtData.TabIndex = 3;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 7;
            this.gunaElipse2.TargetControl = this.gunaGroupBox1;
            // 
            // pnlSave
            // 
            this.pnlSave.BackColor = System.Drawing.Color.White;
            this.pnlSave.Controls.Add(this.gunaButton6);
            this.pnlSave.Controls.Add(this.gunaButton5);
            this.pnlSave.Location = new System.Drawing.Point(731, 436);
            this.pnlSave.Name = "pnlSave";
            this.pnlSave.Size = new System.Drawing.Size(231, 200);
            this.pnlSave.TabIndex = 10;
            // 
            // fpnlProduct
            // 
            this.fpnlProduct.AutoScroll = true;
            this.fpnlProduct.BackColor = System.Drawing.Color.White;
            this.fpnlProduct.Location = new System.Drawing.Point(3, 144);
            this.fpnlProduct.Name = "fpnlProduct";
            this.fpnlProduct.Size = new System.Drawing.Size(730, 509);
            this.fpnlProduct.TabIndex = 11;
            // 
            // gunaButton6
            // 
            this.gunaButton6.AnimationHoverSpeed = 0.07F;
            this.gunaButton6.AnimationSpeed = 0.03F;
            this.gunaButton6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            this.gunaButton6.BorderColor = System.Drawing.Color.Black;
            this.gunaButton6.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton6.ForeColor = System.Drawing.Color.White;
            this.gunaButton6.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton6.Image")));
            this.gunaButton6.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton6.Location = new System.Drawing.Point(63, 121);
            this.gunaButton6.Name = "gunaButton6";
            this.gunaButton6.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton6.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton6.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton6.OnHoverImage = null;
            this.gunaButton6.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton6.Size = new System.Drawing.Size(95, 41);
            this.gunaButton6.TabIndex = 11;
            this.gunaButton6.Text = "Cancel";
            // 
            // gunaButton5
            // 
            this.gunaButton5.AnimationHoverSpeed = 0.07F;
            this.gunaButton5.AnimationSpeed = 0.03F;
            this.gunaButton5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            this.gunaButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaButton5.ForeColor = System.Drawing.Color.White;
            this.gunaButton5.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton5.Image")));
            this.gunaButton5.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton5.Location = new System.Drawing.Point(63, 37);
            this.gunaButton5.Name = "gunaButton5";
            this.gunaButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton5.OnHoverImage = null;
            this.gunaButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton5.Size = new System.Drawing.Size(95, 41);
            this.gunaButton5.TabIndex = 10;
            this.gunaButton5.Text = "Save";
            // 
            // btnFind
            // 
            this.btnFind.AnimationHoverSpeed = 0.07F;
            this.btnFind.AnimationSpeed = 0.03F;
            this.btnFind.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            this.btnFind.BorderColor = System.Drawing.Color.Black;
            this.btnFind.FocusedColor = System.Drawing.Color.Empty;
            this.btnFind.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFind.Location = new System.Drawing.Point(496, 62);
            this.btnFind.Name = "btnFind";
            this.btnFind.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnFind.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFind.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFind.OnHoverImage = null;
            this.btnFind.OnPressedColor = System.Drawing.Color.Black;
            this.btnFind.Size = new System.Drawing.Size(85, 41);
            this.btnFind.TabIndex = 4;
            this.btnFind.Text = "Find";
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.Location = new System.Drawing.Point(63, 103);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Size = new System.Drawing.Size(95, 41);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            // 
            // btnDe
            // 
            this.btnDe.AnimationHoverSpeed = 0.07F;
            this.btnDe.AnimationSpeed = 0.03F;
            this.btnDe.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            this.btnDe.BorderColor = System.Drawing.Color.Black;
            this.btnDe.FocusedColor = System.Drawing.Color.Empty;
            this.btnDe.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDe.ForeColor = System.Drawing.Color.White;
            this.btnDe.Image = ((System.Drawing.Image)(resources.GetObject("btnDe.Image")));
            this.btnDe.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDe.Location = new System.Drawing.Point(63, 187);
            this.btnDe.Name = "btnDe";
            this.btnDe.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnDe.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDe.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDe.OnHoverImage = null;
            this.btnDe.OnPressedColor = System.Drawing.Color.Black;
            this.btnDe.Size = new System.Drawing.Size(95, 41);
            this.btnDe.TabIndex = 6;
            this.btnDe.Text = "Delete";
            // 
            // btnUp
            // 
            this.btnUp.AnimationHoverSpeed = 0.07F;
            this.btnUp.AnimationSpeed = 0.03F;
            this.btnUp.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(200)))), ((int)(((byte)(178)))));
            this.btnUp.BorderColor = System.Drawing.Color.Black;
            this.btnUp.FocusedColor = System.Drawing.Color.Empty;
            this.btnUp.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUp.ForeColor = System.Drawing.Color.White;
            this.btnUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUp.Image")));
            this.btnUp.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUp.Location = new System.Drawing.Point(63, 281);
            this.btnUp.Name = "btnUp";
            this.btnUp.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUp.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUp.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUp.OnHoverImage = null;
            this.btnUp.OnPressedColor = System.Drawing.Color.Black;
            this.btnUp.Size = new System.Drawing.Size(95, 41);
            this.btnUp.TabIndex = 5;
            this.btnUp.Text = "Update";
            // 
            // Uc_WareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fpnlProduct);
            this.Controls.Add(this.pnlSave);
            this.Controls.Add(this.gunaGroupBox1);
            this.Controls.Add(this.gunaElipsePanel2);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Uc_WareHouse";
            this.Size = new System.Drawing.Size(965, 656);
            this.Load += new System.EventHandler(this.Uc_WareHouse_Load);
            this.gunaElipsePanel2.ResumeLayout(false);
            this.gunaGroupBox1.ResumeLayout(false);
            this.pnlSave.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaComboBox cbbTypeFind;
        private Guna.UI.WinForms.GunaButton btnFind;
        private Guna.UI.WinForms.GunaLineTextBox txtData;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaButton btnAdd;
        private Guna.UI.WinForms.GunaButton btnDe;
        private Guna.UI.WinForms.GunaButton btnUp;
        private Guna.UI.WinForms.GunaPanel pnlSave;
        private Guna.UI.WinForms.GunaButton gunaButton6;
        private Guna.UI.WinForms.GunaButton gunaButton5;
        private System.Windows.Forms.FlowLayoutPanel fpnlProduct;
    }
}
