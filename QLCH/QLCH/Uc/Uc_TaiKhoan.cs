using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Net;
using Guna.UI.WinForms;

namespace QLCH.Uc
{
    public partial class Uc_TaiKhoan : UserControl
    {
        public Uc_TaiKhoan()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        int choose = 0;
        string pass = "";

        void SetPass()
        {
            Random r = new Random();
            int[] a = new int[5];
            for(int i = 0; i < 5; i++)
            {
                a[i] = r.Next(0, 9);
                pass += a[i];
            }
        }

        private string MaHoaMD5(string text)
        {
            MD5 mh = MD5.Create();
            byte[] input = System.Text.Encoding.ASCII.GetBytes(text);

            byte[] hash = mh.ComputeHash(input);

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x"));
            }
            return sb.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Uc_TaiKhoan_Load(sender, e);
            txtTenDN.Enabled = false;
            btnCreate.Enabled = true;
            btnDrop.Enabled = true;
            btnSetPass.Enabled = true;
            pnlChange.Enabled = false;
        }

        private void Uc_TaiKhoan_Load(object sender, EventArgs e)
        {
            //cbbMaNV.DropDownStyle = ComboBoxStyle.DropDown;
            //var manv = from u in db.nhanViens
            //           select u.maNV;
            //cbbMaNV.DataSource = manv;

            dgvTaiKhoan.AutoGenerateColumns = false;
            dgvTaiKhoan.DataSource = db.ACC_Sel();
        }
        int i = 0;
        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            if (i >= 0)
            {

                txtMaNV.Text = dgvTaiKhoan.Rows[i].Cells[0].Value.ToString();
                if (dgvTaiKhoan.Rows[i].Cells[3].Value == null)
                    txtTenDN.Text = "";
                else
                {
                    txtTenDN.Text = dgvTaiKhoan.Rows[i].Cells[3].Value.ToString();
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            GunaButton button = sender as GunaButton;
            if (button.Text.Equals("Tạo tài khoản"))
            {
                
                choose = 1;
                btnDrop.Enabled = false;
                btnSetPass.Enabled = false;
                txtTenDN.Enabled = true;
            }
            else if (button.Text.Equals("Xóa tài khoản"))
            {
                choose = 2;
                btnCreate.Enabled = false;
                btnSetPass.Enabled = false;
            }
                
            else if (button.Text.Equals("Cấp mật khẩu"))
            {
                choose = 3;
                btnDrop.Enabled = false;
                btnCreate.Enabled = false;
            }
            else if (button.Text.Equals("Tìm kiếm"))
            {
                choose = 4;
                btnDrop.Enabled = false;
                btnCreate.Enabled = false;
                btnDrop.Enabled = false;
                btnSetPass.Enabled = false;
                txtTenDN.Enabled = true;
            }

            pnlChange.Enabled = true;
        }

        void SendMail(string tenNV, string email)
        {
            string bodyemail = "Xin Chào " + tenNV + " Chúng Tôi Đã Nhận Được Yêu Cầu Cần Hổ Trợ Của Bạn: \n\n"
                                    + "\tChúng Tôi Sẽ cấp mật khẩu cho bạn\n"
                                    + "\t\t=> Mật khẩu Của Bạn Là: " + pass
                                    + "\nBạn có thể đổi mật khẩu trong phần đăng nhập của phần mềm";

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

                MessageBox.Show("Đã gửi mật khẩu về Email của nhân viên " + tenNV, "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            pass = "";
            SetPass();
            nhanVien nv = db.nhanViens.Where(s => s.maNV.Equals(txtMaNV.Text)).FirstOrDefault();
            nhanVien nv2 = db.nhanViens.Where(s => s.tendn.Equals(txtTenDN.Text)).FirstOrDefault();
            switch (choose)
            {
                case 1:
                    {
                        if (txtTenDN.Text.Equals(null))
                            MessageBox.Show("Chưa điền tên đăng nhập");
                        else
                        {
                            if (nv2 == null)
                            {
                                SendMail(nv.tenNV, nv.email);
                                db.ACC_Add(txtMaNV.Text, txtTenDN.Text, MaHoaMD5(pass));
                                Uc_TaiKhoan_Load(sender, e);
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        db.ACC_Del(txtMaNV.Text);
                        Uc_TaiKhoan_Load(sender, e);
                        break;
                    }
                case 3:
                    {
                        SendMail(nv.tenNV, nv.email);
                        db.ACC_Up(txtMaNV.Text, MaHoaMD5(pass));
                        Uc_TaiKhoan_Load(sender, e);
                        break;
                    }
                case 4:
                    {
                        if (rdbMaNV.Checked == true)
                        {
                            dgvTaiKhoan.DataSource = db.ACC_FindID(txtMaNV.Text);
                        }

                        else if (rdbTenDN.Checked == true)
                            dgvTaiKhoan.DataSource = db.ACC_FindTenDN(txtTenDN.Text);
                        break;
                    }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
