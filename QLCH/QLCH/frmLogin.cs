using QLCH.Uc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH
{
    public delegate void fFRMLOAD();
    public delegate void load_Data();
    public delegate void Exit();
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            
        }
        string OTP = "";
        int counter = 0;
        public class GetID
        {
            public static string id = "";
        }
        DataClasses1DataContext dt = new DataClasses1DataContext();
        private string MaHoaMD5(string text)
        {
            MD5 mh = MD5.Create();
            byte[] input = System.Text.Encoding.ASCII.GetBytes(text);

            byte[] hash = mh.ComputeHash(input);

            StringBuilder sb = new StringBuilder();

            for(int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x"));
            }
            return sb.ToString();
        }

        private void GetOTP()
        {
            Random random = new Random();
            int[] otp = new int[5];
            for (int i = 0; i < 5; i++)
            {
                otp[i] = random.Next(0, 9);
                OTP += otp[i];
            }
        }

        private void txtNewPassword1st_OnValueChanged(object sender, EventArgs e)
        {
            txtPassword.isPassword = true;
            txtNewPassword1st.isPassword = true;
            txtNewPassword2nd.isPassword = true;
        }

        private void lbForgetPassword_Click(object sender, EventArgs e)
        {
            pnlOTP.Location = new Point(575, 0);
            pnlLogin.Visible = false;
            pnlChangePass.Visible = false;
            pnlOTP.Visible = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(575, 0);
            pnlLogin.Visible = true;
            pnlOTP.Visible = false;
            pnlChangePass.Visible = false;
            counter = 1;
            OTP = "";
        }


        private void gunaButton1_Click(object sender, EventArgs e)
        {
            pnlOTP.Location = new Point(575, 0);
            pnlLogin.Visible = false;
            pnlOTP.Visible = true;
            pnlChangePass.Visible = false;
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            nhanVien nv = dt.nhanViens.Where(s =>   s.passWords.Equals(MaHoaMD5(txtPassword.Text))
                                                    && s.tendn.Equals(txtAcount.Text))
                                                    .FirstOrDefault();
            if (nv != null)
            {
                GetID.id = nv.maNV;
                //frmFuction fuction = new frmFuction();
                FrmSale fuction = new FrmSale();
                this.Hide();
                fuction.ShowDialog();
            }
            else
                MessageBox.Show("Username or password is wrong");
        }

        private void txtOTP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        void SendMail(string tenNV, string email)
        {
            string bodyemail = "Xin Chào " + tenNV + " Chúng Tôi Đã Nhận Được Yêu Cầu Cần Hổ Trợ Của Bạn: \n\n"
                                    + "\tChúng Tôi Sẽ Hướng Dẫn Bạn Cách Đổi Mật Khẩu\n"
                                    + "Bước 1: Tại Phần Đổi Mật Khẩu, Bạn Nhập Tên Tài Khoản Của Bạn\n"
                                    + "Bước 2: Tiếp Theo Bạn Cần Nhập Mã Xác Minh \n"
                                    + "\t\t=> Mã Xác Minh Của Bạn Là: " + OTP
                                    + "\nBước 3: Nhập Mật Khẩu Mới Của Bạn, Xong Bạn Click Vào Đổi Mật Khẩu";

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("gearharis@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Gear Haris - The best choice for gamer";
                mail.Body = bodyemail;
                SmtpClient smptClient = new SmtpClient();
                smptClient.Host = "smtp.gmail.com";
                NetworkCredential credential = new NetworkCredential();
                credential.UserName = "gearharis@gmail.com";
                credential.Password = "haris0071";
                smptClient.Credentials = credential;
                smptClient.Port = 587;
                smptClient.EnableSsl = true;
                smptClient.Send(mail);


                MessageBox.Show("Đã gửi mã xác minh về Email Mời Kiểm Tra Để Đổi Mật Khẩu", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOTP_Click(object sender, EventArgs e)
        {
            OTP = "";
            nhanVien nv = dt.nhanViens.Where(s => s.tendn.Equals(txtUsername.Text)
                                            && s.email.Equals(txtEmail.Text))
                                        .FirstOrDefault();
            if (nv != null)
            {
                GetOTP();
                //string bodyemail = "Xin Chào " + nv.tenNV + " Chúng Tôi Đã Nhận Được Yêu Cầu Cần Hổ Trợ Của Bạn: \n\n"
                //                    + "\tChúng Tôi Sẽ Hướng Dẫn Bạn Cách Đổi Mật Khẩu\n"
                //                    + "Bước 1: Tại Phần Đổi Mật Khẩu, Bạn Nhập Tên Tài Khoản Của Bạn\n"
                //                    + "Bước 2: Tiếp Theo Bạn Cần Nhập Mã Xác Minh \n"
                //                    + "\t\t=> Mã Xác Minh Của Bạn Là: " + OTP
                //                    + "\nBước 3: Nhập Mật Khẩu Mới Của Bạn, Xong Bạn Click Vào Đổi Mật Khẩu";

                //try
                //{
                //    MailMessage mail = new MailMessage();
                //    mail.From = new MailAddress("gearharis@gmail.com");
                //    mail.To.Add(nv.email);
                //    mail.Subject = "Gear Haris - The best choice for gamer";
                //    mail.Body = OTP;
                //    SmtpClient smptClient = new SmtpClient();
                //    smptClient.Host = "smtp.gmail.com";
                //    NetworkCredential credential = new NetworkCredential();
                //    credential.UserName = "gearharis@gmail.com";
                //    credential.Password = "haris0071";
                //    smptClient.Credentials = credential;
                //    smptClient.Port = 587;
                //    smptClient.EnableSsl = true;
                //    smptClient.Send(mail);


                //    MessageBox.Show("Đã gửi mã xác minh về Email Mời Kiểm Tra Để Đổi Mật Khẩu", "Thông báo", MessageBoxButtons.OK);
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
                SendMail(nv.tenNV, nv.email);
                counter = 60;
                timer1.Start();
                llbTime.Enabled = true;
            }
            else
            {
                MessageBox.Show("Email or Account wrong !! \n\t Try Again");
                txtEmail.Focus();
            }


            
            //GetOTP();
            //MessageBox.Show(OTP);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            //label1.Text = "Change password >> " + counter.ToString() + "s";
            llbTime.Text = "Change password >> " + counter.ToString() + "s";
            if (counter == 0)
            {
                GetOTP();
                llbTime.Text = "Change password";
                timer1.Stop();
                llbTime.Enabled = false;
            }
        }

        private void llbTime_Click(object sender, EventArgs e)
        {
            pnlChangePass.Location = new Point(575, 0);
            pnlLogin.Visible = false;
            pnlOTP.Visible = false;
            pnlChangePass.Visible = true;
          
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtOTP.Text != OTP)
                MessageBox.Show("OTP code is not correctly");
            else if (txtNewPassword1st.Text != txtNewPassword2nd.Text)
                MessageBox.Show("Password is not same", "Notification", MessageBoxButtons.OK);
            else
            {
                MessageBox.Show("Change password correctly");
            }
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogin_Click(sender, e);

            }
        }
    }
}