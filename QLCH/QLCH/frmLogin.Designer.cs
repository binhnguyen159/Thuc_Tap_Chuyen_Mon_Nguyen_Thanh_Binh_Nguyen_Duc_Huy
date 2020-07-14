namespace QLCH
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pnlChangePass = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnChangePassword = new Guna.UI.WinForms.GunaButton();
            this.btnBackOtp = new Guna.UI.WinForms.GunaButton();
            this.btnBackLogin = new Guna.UI.WinForms.GunaButton();
            this.txtOTP = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNewPassword2nd = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNewPassword1st = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnlOTP = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.llbTime = new System.Windows.Forms.LinkLabel();
            this.btnBack = new Guna.UI.WinForms.GunaButton();
            this.btnOTP = new Guna.UI.WinForms.GunaButton();
            this.txtUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnlLogin = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.ptbExit = new Guna.UI.WinForms.GunaPictureBox();
            this.btLogin = new Guna.UI.WinForms.GunaButton();
            this.lbForgetPassword = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.txtAcount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.ptbBackground = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaDragControl2 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlChangePass.SuspendLayout();
            this.pnlOTP.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlChangePass
            // 
            this.pnlChangePass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlChangePass.BackgroundImage")));
            this.pnlChangePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlChangePass.Controls.Add(this.btnChangePassword);
            this.pnlChangePass.Controls.Add(this.btnBackOtp);
            this.pnlChangePass.Controls.Add(this.btnBackLogin);
            this.pnlChangePass.Controls.Add(this.txtOTP);
            this.pnlChangePass.Controls.Add(this.txtNewPassword2nd);
            this.pnlChangePass.Controls.Add(this.txtNewPassword1st);
            this.pnlChangePass.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlChangePass.GradientBottomRight = System.Drawing.Color.White;
            this.pnlChangePass.GradientTopLeft = System.Drawing.Color.White;
            this.pnlChangePass.GradientTopRight = System.Drawing.Color.White;
            this.pnlChangePass.Location = new System.Drawing.Point(1279, 0);
            this.pnlChangePass.Name = "pnlChangePass";
            this.pnlChangePass.Quality = 10;
            this.pnlChangePass.Size = new System.Drawing.Size(354, 509);
            this.pnlChangePass.TabIndex = 5;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.AnimationHoverSpeed = 0.07F;
            this.btnChangePassword.AnimationSpeed = 0.03F;
            this.btnChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePassword.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(165)))), ((int)(((byte)(178)))));
            this.btnChangePassword.BorderColor = System.Drawing.Color.Black;
            this.btnChangePassword.FocusedColor = System.Drawing.Color.Empty;
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Image = global::QLCH.Properties.Resources.icons8_male_user_24__1_;
            this.btnChangePassword.ImageSize = new System.Drawing.Size(20, 20);
            this.btnChangePassword.Location = new System.Drawing.Point(108, 358);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(85)))), ((int)(((byte)(120)))));
            this.btnChangePassword.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChangePassword.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChangePassword.OnHoverImage = null;
            this.btnChangePassword.OnPressedColor = System.Drawing.Color.Black;
            this.btnChangePassword.Radius = 15;
            this.btnChangePassword.Size = new System.Drawing.Size(145, 42);
            this.btnChangePassword.TabIndex = 3;
            this.btnChangePassword.Text = "Change password";
            this.btnChangePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnBackOtp
            // 
            this.btnBackOtp.AnimationHoverSpeed = 0.07F;
            this.btnBackOtp.AnimationSpeed = 0.03F;
            this.btnBackOtp.BackColor = System.Drawing.Color.Transparent;
            this.btnBackOtp.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(165)))), ((int)(((byte)(178)))));
            this.btnBackOtp.BorderColor = System.Drawing.Color.Black;
            this.btnBackOtp.FocusedColor = System.Drawing.Color.Empty;
            this.btnBackOtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackOtp.ForeColor = System.Drawing.Color.White;
            this.btnBackOtp.Image = global::QLCH.Properties.Resources.icons8_male_user_24__1_;
            this.btnBackOtp.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBackOtp.Location = new System.Drawing.Point(30, 420);
            this.btnBackOtp.Name = "btnBackOtp";
            this.btnBackOtp.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(85)))), ((int)(((byte)(120)))));
            this.btnBackOtp.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBackOtp.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBackOtp.OnHoverImage = null;
            this.btnBackOtp.OnPressedColor = System.Drawing.Color.Black;
            this.btnBackOtp.Radius = 15;
            this.btnBackOtp.Size = new System.Drawing.Size(116, 42);
            this.btnBackOtp.TabIndex = 3;
            this.btnBackOtp.Text = "Back to OTP";
            this.btnBackOtp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnBackOtp.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // btnBackLogin
            // 
            this.btnBackLogin.AnimationHoverSpeed = 0.07F;
            this.btnBackLogin.AnimationSpeed = 0.03F;
            this.btnBackLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnBackLogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(165)))), ((int)(((byte)(178)))));
            this.btnBackLogin.BorderColor = System.Drawing.Color.Black;
            this.btnBackLogin.FocusedColor = System.Drawing.Color.Empty;
            this.btnBackLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackLogin.ForeColor = System.Drawing.Color.White;
            this.btnBackLogin.Image = global::QLCH.Properties.Resources.icons8_male_user_24__1_;
            this.btnBackLogin.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBackLogin.Location = new System.Drawing.Point(209, 420);
            this.btnBackLogin.Name = "btnBackLogin";
            this.btnBackLogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(85)))), ((int)(((byte)(120)))));
            this.btnBackLogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBackLogin.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBackLogin.OnHoverImage = null;
            this.btnBackLogin.OnPressedColor = System.Drawing.Color.Black;
            this.btnBackLogin.Radius = 15;
            this.btnBackLogin.Size = new System.Drawing.Size(116, 42);
            this.btnBackLogin.TabIndex = 3;
            this.btnBackLogin.Text = "Back to login";
            this.btnBackLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnBackLogin.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtOTP
            // 
            this.txtOTP.BackColor = System.Drawing.Color.White;
            this.txtOTP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(160)))), ((int)(((byte)(173)))));
            this.txtOTP.HintForeColor = System.Drawing.Color.Empty;
            this.txtOTP.HintText = "OTP Code";
            this.txtOTP.isPassword = false;
            this.txtOTP.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(165)))), ((int)(((byte)(178)))));
            this.txtOTP.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(219)))));
            this.txtOTP.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(165)))), ((int)(((byte)(178)))));
            this.txtOTP.LineThickness = 4;
            this.txtOTP.Location = new System.Drawing.Point(30, 115);
            this.txtOTP.Margin = new System.Windows.Forms.Padding(4);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(308, 33);
            this.txtOTP.TabIndex = 1;
            this.txtOTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtOTP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOTP_KeyPress);
            // 
            // txtNewPassword2nd
            // 
            this.txtNewPassword2nd.BackColor = System.Drawing.Color.White;
            this.txtNewPassword2nd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword2nd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword2nd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(160)))), ((int)(((byte)(173)))));
            this.txtNewPassword2nd.HintForeColor = System.Drawing.Color.Empty;
            this.txtNewPassword2nd.HintText = "New password 2nd";
            this.txtNewPassword2nd.isPassword = true;
            this.txtNewPassword2nd.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(165)))), ((int)(((byte)(178)))));
            this.txtNewPassword2nd.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(219)))));
            this.txtNewPassword2nd.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(165)))), ((int)(((byte)(178)))));
            this.txtNewPassword2nd.LineThickness = 4;
            this.txtNewPassword2nd.Location = new System.Drawing.Point(30, 241);
            this.txtNewPassword2nd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewPassword2nd.Name = "txtNewPassword2nd";
            this.txtNewPassword2nd.Size = new System.Drawing.Size(308, 39);
            this.txtNewPassword2nd.TabIndex = 2;
            this.txtNewPassword2nd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNewPassword2nd.OnValueChanged += new System.EventHandler(this.txtNewPassword1st_OnValueChanged);
            // 
            // txtNewPassword1st
            // 
            this.txtNewPassword1st.BackColor = System.Drawing.Color.White;
            this.txtNewPassword1st.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword1st.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword1st.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(160)))), ((int)(((byte)(173)))));
            this.txtNewPassword1st.HintForeColor = System.Drawing.Color.Empty;
            this.txtNewPassword1st.HintText = "New password 1st";
            this.txtNewPassword1st.isPassword = true;
            this.txtNewPassword1st.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(165)))), ((int)(((byte)(178)))));
            this.txtNewPassword1st.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(219)))));
            this.txtNewPassword1st.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(165)))), ((int)(((byte)(178)))));
            this.txtNewPassword1st.LineThickness = 4;
            this.txtNewPassword1st.Location = new System.Drawing.Point(30, 177);
            this.txtNewPassword1st.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewPassword1st.Name = "txtNewPassword1st";
            this.txtNewPassword1st.Size = new System.Drawing.Size(308, 39);
            this.txtNewPassword1st.TabIndex = 2;
            this.txtNewPassword1st.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNewPassword1st.OnValueChanged += new System.EventHandler(this.txtNewPassword1st_OnValueChanged);
            // 
            // pnlOTP
            // 
            this.pnlOTP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlOTP.BackgroundImage")));
            this.pnlOTP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlOTP.Controls.Add(this.llbTime);
            this.pnlOTP.Controls.Add(this.btnBack);
            this.pnlOTP.Controls.Add(this.btnOTP);
            this.pnlOTP.Controls.Add(this.txtUsername);
            this.pnlOTP.Controls.Add(this.txtEmail);
            this.pnlOTP.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlOTP.GradientBottomRight = System.Drawing.Color.White;
            this.pnlOTP.GradientTopLeft = System.Drawing.Color.White;
            this.pnlOTP.GradientTopRight = System.Drawing.Color.White;
            this.pnlOTP.Location = new System.Drawing.Point(929, 0);
            this.pnlOTP.Name = "pnlOTP";
            this.pnlOTP.Quality = 10;
            this.pnlOTP.Size = new System.Drawing.Size(354, 509);
            this.pnlOTP.TabIndex = 5;
            // 
            // llbTime
            // 
            this.llbTime.AutoSize = true;
            this.llbTime.Enabled = false;
            this.llbTime.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(165)))), ((int)(((byte)(178)))));
            this.llbTime.Location = new System.Drawing.Point(224, 466);
            this.llbTime.Name = "llbTime";
            this.llbTime.Size = new System.Drawing.Size(92, 13);
            this.llbTime.TabIndex = 6;
            this.llbTime.TabStop = true;
            this.llbTime.Text = "Change password";
            this.llbTime.Click += new System.EventHandler(this.llbTime_Click);
            // 
            // btnBack
            // 
            this.btnBack.AnimationHoverSpeed = 0.07F;
            this.btnBack.AnimationSpeed = 0.03F;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(165)))), ((int)(((byte)(178)))));
            this.btnBack.BorderColor = System.Drawing.Color.Black;
            this.btnBack.FocusedColor = System.Drawing.Color.Empty;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = global::QLCH.Properties.Resources.icons8_male_user_24__1_;
            this.btnBack.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBack.Location = new System.Drawing.Point(215, 358);
            this.btnBack.Name = "btnBack";
            this.btnBack.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(85)))), ((int)(((byte)(120)))));
            this.btnBack.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBack.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBack.OnHoverImage = null;
            this.btnBack.OnPressedColor = System.Drawing.Color.Black;
            this.btnBack.Radius = 15;
            this.btnBack.Size = new System.Drawing.Size(116, 42);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnOTP
            // 
            this.btnOTP.AnimationHoverSpeed = 0.07F;
            this.btnOTP.AnimationSpeed = 0.03F;
            this.btnOTP.BackColor = System.Drawing.Color.Transparent;
            this.btnOTP.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(165)))), ((int)(((byte)(178)))));
            this.btnOTP.BorderColor = System.Drawing.Color.Black;
            this.btnOTP.FocusedColor = System.Drawing.Color.Empty;
            this.btnOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOTP.ForeColor = System.Drawing.Color.White;
            this.btnOTP.Image = global::QLCH.Properties.Resources.icons8_male_user_24__1_;
            this.btnOTP.ImageSize = new System.Drawing.Size(20, 20);
            this.btnOTP.Location = new System.Drawing.Point(41, 358);
            this.btnOTP.Name = "btnOTP";
            this.btnOTP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(85)))), ((int)(((byte)(120)))));
            this.btnOTP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnOTP.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOTP.OnHoverImage = null;
            this.btnOTP.OnPressedColor = System.Drawing.Color.Black;
            this.btnOTP.Radius = 15;
            this.btnOTP.Size = new System.Drawing.Size(127, 42);
            this.btnOTP.TabIndex = 3;
            this.btnOTP.Text = "Send OTP";
            this.btnOTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOTP.Click += new System.EventHandler(this.btnOTP_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(160)))), ((int)(((byte)(173)))));
            this.txtUsername.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsername.HintText = "User name";
            this.txtUsername.isPassword = false;
            this.txtUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(165)))), ((int)(((byte)(178)))));
            this.txtUsername.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(219)))));
            this.txtUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(165)))), ((int)(((byte)(178)))));
            this.txtUsername.LineThickness = 4;
            this.txtUsername.Location = new System.Drawing.Point(23, 178);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(308, 33);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(160)))), ((int)(((byte)(173)))));
            this.txtEmail.HintForeColor = System.Drawing.Color.Empty;
            this.txtEmail.HintText = "Email";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(165)))), ((int)(((byte)(178)))));
            this.txtEmail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(219)))));
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(165)))), ((int)(((byte)(178)))));
            this.txtEmail.LineThickness = 4;
            this.txtEmail.Location = new System.Drawing.Point(23, 240);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(308, 39);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLogin.BackgroundImage")));
            this.pnlLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogin.Controls.Add(this.ptbExit);
            this.pnlLogin.Controls.Add(this.btLogin);
            this.pnlLogin.Controls.Add(this.lbForgetPassword);
            this.pnlLogin.Controls.Add(this.gunaPictureBox1);
            this.pnlLogin.Controls.Add(this.txtAcount);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLogin.GradientBottomLeft = System.Drawing.Color.White;
            this.pnlLogin.GradientBottomRight = System.Drawing.Color.White;
            this.pnlLogin.GradientTopLeft = System.Drawing.Color.White;
            this.pnlLogin.GradientTopRight = System.Drawing.Color.White;
            this.pnlLogin.Location = new System.Drawing.Point(575, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Quality = 10;
            this.pnlLogin.Size = new System.Drawing.Size(355, 509);
            this.pnlLogin.TabIndex = 2;
            this.pnlLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogin_Paint);
            // 
            // ptbExit
            // 
            this.ptbExit.BackColor = System.Drawing.Color.Transparent;
            this.ptbExit.BaseColor = System.Drawing.Color.White;
            this.ptbExit.Image = global::QLCH.Properties.Resources.icons8_delete_40;
            this.ptbExit.Location = new System.Drawing.Point(320, 0);
            this.ptbExit.Name = "ptbExit";
            this.ptbExit.Size = new System.Drawing.Size(35, 35);
            this.ptbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbExit.TabIndex = 5;
            this.ptbExit.TabStop = false;
            this.ptbExit.Click += new System.EventHandler(this.ptbExit_Click);
            // 
            // btLogin
            // 
            this.btLogin.AnimationHoverSpeed = 0.07F;
            this.btLogin.AnimationSpeed = 0.03F;
            this.btLogin.BackColor = System.Drawing.Color.Transparent;
            this.btLogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(165)))), ((int)(((byte)(178)))));
            this.btLogin.BorderColor = System.Drawing.Color.Black;
            this.btLogin.FocusedColor = System.Drawing.Color.Empty;
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.Color.White;
            this.btLogin.Image = global::QLCH.Properties.Resources.icons8_male_user_24__1_;
            this.btLogin.ImageSize = new System.Drawing.Size(20, 20);
            this.btLogin.Location = new System.Drawing.Point(109, 358);
            this.btLogin.Name = "btLogin";
            this.btLogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(85)))), ((int)(((byte)(120)))));
            this.btLogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btLogin.OnHoverForeColor = System.Drawing.Color.White;
            this.btLogin.OnHoverImage = null;
            this.btLogin.OnPressedColor = System.Drawing.Color.Black;
            this.btLogin.Radius = 15;
            this.btLogin.Size = new System.Drawing.Size(157, 42);
            this.btLogin.TabIndex = 3;
            this.btLogin.Text = "Login";
            this.btLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // lbForgetPassword
            // 
            this.lbForgetPassword.AutoSize = true;
            this.lbForgetPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbForgetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForgetPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(56)))), ((int)(((byte)(106)))));
            this.lbForgetPassword.Location = new System.Drawing.Point(176, 437);
            this.lbForgetPassword.Name = "lbForgetPassword";
            this.lbForgetPassword.Size = new System.Drawing.Size(172, 25);
            this.lbForgetPassword.TabIndex = 4;
            this.lbForgetPassword.Text = "Forget password";
            this.lbForgetPassword.Click += new System.EventHandler(this.lbForgetPassword_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::QLCH.Properties.Resources.login2;
            this.gunaPictureBox1.Location = new System.Drawing.Point(44, 68);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(268, 112);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 1;
            this.gunaPictureBox1.TabStop = false;
            // 
            // txtAcount
            // 
            this.txtAcount.BackColor = System.Drawing.Color.White;
            this.txtAcount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(160)))), ((int)(((byte)(173)))));
            this.txtAcount.HintForeColor = System.Drawing.Color.Empty;
            this.txtAcount.HintText = "User name";
            this.txtAcount.isPassword = false;
            this.txtAcount.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(165)))), ((int)(((byte)(178)))));
            this.txtAcount.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(219)))));
            this.txtAcount.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(165)))), ((int)(((byte)(178)))));
            this.txtAcount.LineThickness = 4;
            this.txtAcount.Location = new System.Drawing.Point(25, 223);
            this.txtAcount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAcount.Name = "txtAcount";
            this.txtAcount.Size = new System.Drawing.Size(308, 33);
            this.txtAcount.TabIndex = 1;
            this.txtAcount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(160)))), ((int)(((byte)(173)))));
            this.txtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtPassword.HintText = "Password";
            this.txtPassword.isPassword = true;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(165)))), ((int)(((byte)(178)))));
            this.txtPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(214)))), ((int)(((byte)(219)))));
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(165)))), ((int)(((byte)(178)))));
            this.txtPassword.LineThickness = 4;
            this.txtPassword.Location = new System.Drawing.Point(25, 285);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(308, 39);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.OnValueChanged += new System.EventHandler(this.txtNewPassword1st_OnValueChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.White;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.ptbBackground);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(575, 509);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // ptbBackground
            // 
            this.ptbBackground.BaseColor = System.Drawing.Color.White;
            this.ptbBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbBackground.Image = global::QLCH.Properties.Resources.back4;
            this.ptbBackground.Location = new System.Drawing.Point(0, 0);
            this.ptbBackground.Name = "ptbBackground";
            this.ptbBackground.Size = new System.Drawing.Size(575, 509);
            this.ptbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBackground.TabIndex = 0;
            this.ptbBackground.TabStop = false;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this.ptbBackground;
            // 
            // gunaDragControl2
            // 
            this.gunaDragControl2.TargetControl = this.pnlLogin;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 509);
            this.Controls.Add(this.pnlChangePass);
            this.Controls.Add(this.pnlOTP);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlChangePass.ResumeLayout(false);
            this.pnlOTP.ResumeLayout(false);
            this.pnlOTP.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtAcount;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlLogin;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbForgetPassword;
        private Guna.UI.WinForms.GunaButton btLogin;
        private Guna.UI.WinForms.GunaPictureBox ptbBackground;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlOTP;
        private Guna.UI.WinForms.GunaButton btnOTP;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlChangePass;
        private Guna.UI.WinForms.GunaButton btnChangePassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtOTP;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNewPassword1st;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNewPassword2nd;
        private Guna.UI.WinForms.GunaButton btnBack;
        private Guna.UI.WinForms.GunaButton btnBackOtp;
        private Guna.UI.WinForms.GunaPictureBox ptbExit;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsername;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel llbTime;
        private Guna.UI.WinForms.GunaButton btnBackLogin;
    }
}

