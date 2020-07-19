using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH.Uc
{
    public partial class Frm_Mail : Form
    {
        public Frm_Mail()
        {
            InitializeComponent();
        }

        private void btnAtt_Click(object sender, EventArgs e)
        {
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (var filename in openFileDialog1.FileNames)
                {
                    //Thêm các file đã chọn vào listBox1
                    listBox1.Items.Add(filename.ToString());
                }
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (txtFrom.Text == "" || txtPass.Text == "" || txtTo.Text == "" || txtSubject.Text == "" || txtMessage.Text == "")
            {
                MessageBox.Show(" Please fill all information:", "Warning");
            }
            else
            {
                try
                {
                    SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                    mailclient.EnableSsl = true;
                    mailclient.Credentials = new NetworkCredential(txtFrom.Text, txtPass.Text);

                    MailMessage message = new MailMessage(txtFrom.Text, txtTo.Text);
                    message.Subject = txtSubject.Text;
                    message.Body = txtMessage.Text;
                    //Kiểm tra nếu có file trong listBox1
                    if (listBox1.Items.Count > 0)
                    {
                        foreach (var filename in listBox1.Items)
                        {
                            //Kiểm tra file có tồn tại trong ổ đĩa không
                            if (File.Exists(filename.ToString()))
                            {
                                //Thêm file đính kèm vào tin nhắn
                                message.Attachments.Add(new Attachment(filename.ToString()));
                            }
                        }
                    }
                    mailclient.Send(message);
                    MessageBox.Show("Mail sent", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception)
                {
                    MessageBox.Show( "Can't send email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (!isEmail(txtFrom.Text))
            {
                MessageBox.Show("Email incorrect", "Error");
                txtFrom.Focus();
            }
        }

        private void txtTo_Leave(object sender, EventArgs e)
        {
            if (!isEmail(txtFrom.Text))
            {
                MessageBox.Show("Email incorrect", "Error");
                txtFrom.Focus();
            }
        }
    }
}
