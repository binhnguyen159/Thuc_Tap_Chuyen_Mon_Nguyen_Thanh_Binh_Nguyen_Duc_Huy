using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using Bunifu.Framework.UI;

namespace QLCH.Uc
{
    public partial class Uc_Customer : UserControl
    {
        public Uc_Customer()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();

        private void btnGetPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if(open.ShowDialog() == DialogResult.OK)
            {
                open.Filter = "Pictures files (*.jpg,*jpeg,*.jpe,*.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
                //ptbAvatar.Image = new Bitmap(open.FileName);
                //ptbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            MemoryStream stream = new MemoryStream();
            //ptbAvatar.Image.Save(stream, ImageFormat.Jpeg);

            string gt = "";
            if (rdbMale.Checked)
                gt = "Nam";
            else
                gt = "Nữ";

            if (txtAddress.Text == "" || txtEmail.Text == "" || txtName.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Please fill all information");
            }
            else
            {
                int ma = 1;
                string id = "";
                var kh = from u in db.khachHangs select u;
                if (kh.Count() == 0)
                {
                    id = "KH" + ma;
                    db.KH_Ins(id, txtName.Text, gt, dtpBirthday.Value, txtEmail.Text, txtAddress.Text, txtPhone.Text);
                }
                else if (kh.Count() > 0)
                {
                    
                    kh.OrderByDescending(s=>s.maKH).FirstOrDefault();
                    var kh2 = db.khachHangs.OrderByDescending(s=>s.maKH).FirstOrDefault();
                    ma = Convert.ToInt32(kh2.maKH.ToString().Substring(2)) + 1;
                    id = "KH" + ma;
                    db.KH_Ins(id, txtName.Text, gt, dtpBirthday.Value, txtEmail.Text, txtAddress.Text, txtPhone.Text);
                }
                Uc_Customer_Load(sender, e);
            }
                
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            db.KH_Del(lbID.Text);
            Uc_Customer_Load(sender, e);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            string gt = "";
            if (rdbMale.Checked)
                gt = "Nam";
            else
                gt = "Nữ";
            khachHang kh = db.khachHangs.Where(s => s.maKH.Equals(lbID.Text)).FirstOrDefault();
            if (kh == null)
                return;
            else
            {
                db.KH_Up(lbID.Text, txtName.Text, gt, dtpBirthday.Value, txtEmail.Text, txtAddress.Text, txtPhone.Text);
                Uc_Customer_Load(sender, e);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
        }

        private void Uc_Customer_Load(object sender, EventArgs e)
        {
            rdbMale.Checked = true;
            var kh = from u in db.khachHangs select u;
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.DataSource = db.KH_Sel();
        }
        int row = 0;
        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row < 0)
                return;
            else
            {
                lbID.Text = dgvCustomers.Rows[row].Cells[0].Value.ToString();
                txtName.Text = dgvCustomers.Rows[row].Cells[1].Value.ToString();
                if (dgvCustomers.Rows[row].Cells[2].Value.ToString().Equals("Nam"))
                    rdbMale.Checked = true;
                else
                    rdbFemale.Checked = true;
                dtpBirthday.Value = (DateTime) dgvCustomers.Rows[row].Cells[3].Value;
                txtEmail.Text = dgvCustomers.Rows[row].Cells[4].Value.ToString();
                txtPhone.Text = dgvCustomers.Rows[row].Cells[5].Value.ToString();
                txtAddress.Text = dgvCustomers.Rows[row].Cells[6].Value.ToString();
            }

        }

        private void txtPhone_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
