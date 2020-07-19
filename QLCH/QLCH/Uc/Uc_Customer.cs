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
using System.Text.RegularExpressions;

namespace QLCH.Uc
{
    public partial class Uc_Customer : UserControl
    {
        public Uc_Customer()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        int function = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            function = 1;
            gunaPanel1.Visible = true;
            btnUp.Visible = false;
            btnFind.Visible = false;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            function = 2;
            gunaPanel1.Visible = true;
            btnAdd.Visible = false;
            btnUp.Visible = false;
            btnFind.Visible = false;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            function = 3;
            gunaPanel1.Visible = true;
            btnAdd.Visible = false;
            btnFind.Visible = false;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            function = 4;
            txtID.Enabled = true;
            gunaPanel1.Visible = true;
            btnUp.Visible = false;
            btnAdd.Visible = false;
        }

        private void Uc_Customer_Load(object sender, EventArgs e)
        {
            rdbMale.Checked = true;
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
                txtID.Text = dgvCustomers.Rows[row].Cells[0].Value.ToString();
                txtID.Text = dgvCustomers.Rows[row].Cells[0].Value.ToString();
                txtName.Text = dgvCustomers.Rows[row].Cells[1].Value.ToString();
                if (dgvCustomers.Rows[row].Cells[2].Value.ToString().Equals("Male"))
                    rdbMale.Checked = true;
                else
                    rdbFemale.Checked = true;
                dtpBirthday.Value = (DateTime)dgvCustomers.Rows[row].Cells[3].Value;
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Uc_Customer_Load(sender, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gunaPanel1.Visible = false;
            txtID.Enabled = false;
            btnAdd.Visible = true;
            btnUp.Visible = true;
            btnFind.Visible = true;

            Uc_Customer_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch (function)
            {
                case 1:
                    {
                        string gt = "";
                        if (rdbMale.Checked)
                            gt = "Male";
                        else
                            gt = "Female";

                        if (txtAddress.Text == "" || txtEmail.Text == "" || txtName.Text == "" || txtPhone.Text == "")
                        {
                            MessageBox.Show("Please fill all information");
                        }
                        else
                        {
                            var kh = from u in db.khachHangs select u;
                            if (kh.Count() == 0)
                            {
                                db.KH_Ins("KH000001", txtName.Text, gt, dtpBirthday.Value, txtEmail.Text, txtAddress.Text, txtPhone.Text);
                            }
                            else
                            {
                                int ma = 0;
                                string id = "";

                                khachHang kkkh = db.khachHangs.OrderByDescending(s => s.maKH).FirstOrDefault();

                                ma = Convert.ToInt32(kkkh.maKH.ToString().Trim().Substring(2)) + 1;
                                if (ma / 10 >= 100000)
                                    id = "KH" + ma;
                                else if (ma / 10 >= 1000 && ma / 10 < 10000)
                                    id = "KH0" + ma;
                                else if (ma / 10 >= 100 && ma / 10 < 1000)
                                    id = "KH00" + ma;
                                else if (ma / 10 >= 10 && ma / 10 < 100)
                                    id = "KH000" + ma;
                                else if (ma / 10 >= 1 && ma / 10 < 10)
                                    id = "KH0000" + ma;
                                else if (ma / 10 < 1)
                                    id = "KH00000" + ma;
                                db.KH_Ins(id, txtName.Text, gt, dtpBirthday.Value, txtEmail.Text, txtAddress.Text, txtPhone.Text);

                            }
                            Uc_Customer_Load(sender, e);


                        }
                    }
                    break;
                case 2:
                    {
                        db.KH_Del(txtID.Text);
                        Uc_Customer_Load(sender, e);
                    }
                    break;
                case 3:
                    {
                        string gt = "";
                        if (rdbMale.Checked)
                            gt = "Male";
                        else
                            gt = "Female";
                        khachHang kh = db.khachHangs.Where(s => s.maKH.Equals(txtID.Text)).FirstOrDefault();
                        if (kh == null)
                            return;
                        else
                        {
                            db.KH_Up(txtID.Text, txtName.Text, gt, dtpBirthday.Value, txtEmail.Text, txtAddress.Text, txtPhone.Text);
                            Uc_Customer_Load(sender, e);
                        }
                    }
                    break;
                case 4:
                    {
                        string gt = "";
                        if (rdbMale.Checked)
                            gt = "Male";
                        else
                            gt = "Female";
                        if (chbName.Checked == true && chbSex.Checked == true && chbBirthday.Checked == true)
                        {
                            var kh = from u in db.khachHangs
                                     where u.tenKH == txtName.Text
                                     && u.gioiTinh == gt && u.ngSinh == dtpBirthday.Value
                                     select u;
                            dgvCustomers.DataSource = kh;
                        }
                        else if (chbName.Checked == true && chbSex.Checked == true)
                        {
                            var kh = from u in db.khachHangs
                                     where u.tenKH == txtName.Text && u.gioiTinh == gt
                                     select u;
                            dgvCustomers.DataSource = kh;
                        }
                        else if (chbName.Checked == true && chbBirthday.Checked == true)
                        {
                            var kh = from u in db.khachHangs
                                     where u.tenKH == txtName.Text && u.ngSinh == dtpBirthday.Value
                                     select u;
                            dgvCustomers.DataSource = kh;
                        }
                        else if (chbSex.Checked == true && chbBirthday.Checked == true)
                        {
                            var kh = from u in db.khachHangs
                                     where u.gioiTinh == gt && u.ngSinh == dtpBirthday.Value
                                     select u;
                            dgvCustomers.DataSource = kh;
                        }
                        else if (chbName.Checked == true)
                        {
                            var kh = from u in db.khachHangs
                                     where u.tenKH == txtName.Text
                                     select u;
                            dgvCustomers.DataSource = kh;
                        }
                        else if (chbSex.Checked == true)
                        {
                            var kh = from u in db.khachHangs
                                     where u.gioiTinh == gt
                                     select u;
                            dgvCustomers.DataSource = kh;
                        }
                        else if (chbBirthday.Checked == true)
                        {
                            var kh = from u in db.khachHangs
                                     where u.ngSinh == dtpBirthday.Value
                                     select u;
                            dgvCustomers.DataSource = kh;
                        }
                        else
                        {
                            var kh = from u in db.khachHangs
                                     where u.maKH == txtID.Text
                                     select u;
                            dgvCustomers.DataSource = kh;
                        }
                    }
                    break;
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
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!isEmail(txtEmail.Text))
            {
                MessageBox.Show("Email incorrect", "Error");
                txtEmail.Focus();
            }
        }
    }
}
