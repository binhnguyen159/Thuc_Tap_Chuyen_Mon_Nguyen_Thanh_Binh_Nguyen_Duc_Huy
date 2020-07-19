using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QLCH.Uc
{
    public partial class Uc_Employees : UserControl
    {
        public Uc_Employees()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        string gt = "";
        int function = 0;
        
        public class GetMaNV
        {
            public static string manv = "0";
        }


        private void Uc_Employees_Load(object sender, EventArgs e)
        {
            rdbMale.Checked = true;
            dgvEmployees.AutoGenerateColumns = false;
            dgvEmployees.DataSource = db.NV_Sel();
            txtName.Focus();
            txtName.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            dtpNVL.Value = DateTime.Now;
        }

        int i = 0;
        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            if (i < 0)
                return;
            else
            {
                txtID.Text = dgvEmployees.Rows[i].Cells[0].Value.ToString();
                txtName.Text = dgvEmployees.Rows[i].Cells[1].Value.ToString();
                if (dgvEmployees.Rows[i].Cells[2].Value.ToString() == "Nam")
                    rdbMale.Checked = true;
                else
                    rdbFemale.Checked = true;
                dtpBirthday.Value = (DateTime)dgvEmployees.Rows[i].Cells[3].Value;
                dtpNVL.Value = (DateTime)dgvEmployees.Rows[i].Cells[4].Value;
                txtEmail.Text = dgvEmployees.Rows[i].Cells[5].Value.ToString();
                txtPhone.Text = dgvEmployees.Rows[i].Cells[6].Value.ToString();
                txtAddress.Text = dgvEmployees.Rows[i].Cells[7].Value.ToString();
            }
            
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            function = 1;
            btnDel.Visible = false;
            btnUp.Visible = false;
            btnFind.Visible = false;
            gunaPanel1.Visible = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            function = 2;
            btnAdd.Visible = false;
            btnUp.Visible = false;
            btnFind.Visible = false;
            gunaPanel1.Visible = true;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            function = 3;
            btnAdd.Visible = false;
            btnDel.Visible = false;
            btnFind.Visible = false;
            gunaPanel1.Visible = true;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            function = 4;
            btnDel.Visible = false;
            btnUp.Visible = false;
            btnAdd.Visible = false;
            gunaPanel1.Visible = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            gunaPanel1.Visible = false;
            btnAdd.Visible = true;
            btnDel.Visible = true;
            btnUp.Visible = true;
            btnFind.Visible = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch (function)
            {
                case 1:
                    {
                        if (txtAddress.Text == "" || txtEmail.Text == "" || txtName.Text == "" || txtPhone.Text == "")
                            MessageBox.Show("PLease fill all information");
                        else
                        {
                            gt = "";
                            if (rdbMale.Checked == true)
                                gt = "Male";
                            else
                                gt = "Female";
                            
                            var nv = from u in db.nhanViens select u;

                            if (nv.Count() == 0)
                            {
                                db.NV_Ins("NV000001", txtName.Text, gt, dtpBirthday.Value, dtpNVL.Value, txtEmail.Text, txtAddress.Text, txtPhone.Text);
                            }
                            else
                            {
                                int ma = 1;
                                string id = "";

                                nhanVien kkkh = db.nhanViens.OrderByDescending(s => s.maNV).FirstOrDefault();

                                ma = Convert.ToInt32(kkkh.maNV.ToString().Trim().Substring(2)) + 1;
                                if (ma / 10 >= 100000)
                                    id = "NV" + ma;
                                else if (ma / 10 >= 1000 && ma / 10 < 10000)
                                    id = "NV0" + ma;
                                else if (ma / 10 >= 100 && ma / 10 < 1000)
                                    id = "NV00" + ma;
                                else if (ma / 10 >= 10 && ma / 10 < 100)
                                    id = "NV000" + ma;
                                else if (ma / 10 >= 1 && ma / 10 < 10)
                                    id = "NV0000" + ma;
                                else if (ma / 10 < 1)
                                    id = "NV00000" + ma;
                                db.NV_Ins(id, txtName.Text, gt, dtpBirthday.Value, dtpNVL.Value, txtEmail.Text, txtAddress.Text, txtPhone.Text);

                            }
                            Uc_Employees_Load(sender, e);
                        }
                        break;
                    }
                case 2:
                    {
                        db.NV_Del(txtID.Text);
                        Uc_Employees_Load(sender, e);
                        break;
                    }
                case 3:
                    {
                        nhanVien nv = db.nhanViens.Where(s => s.maNV == txtID.Text).FirstOrDefault();
                        if (nv == null)
                            return;
                        else
                        {
                            if (rdbMale.Checked == true)
                                gt = "Male";
                            else
                                gt = "Female";
                            db.NV_Up(txtID.Text, txtName.Text, gt, dtpBirthday.Value, dtpNVL.Value, txtEmail.Text, txtAddress.Text, txtPhone.Text);
                            Uc_Employees_Load(sender, e);
                        }
                        break;
                    }
                case 4:
                    {
                        string gt = "";
                        if (chbName.Checked == true && chbNS.Checked == true && chbNVL.Checked == true && chbSex.Checked == true)
                        {

                            if (rdbMale.Checked == true)
                                gt = "Male";
                            else
                                gt = "Female";
                            var nv = from u in db.nhanViens
                                     where u.tenNV == txtName.Text && u.ngSinh == dtpBirthday.Value
                                        && u.ngVaoLam == dtpNVL.Value && u.gioiTinh == gt
                                     select u;
                            dgvEmployees.DataSource = nv;
                        }
                        else if (chbName.Checked == true && chbNS.Checked == true && chbNVL.Checked == true)
                        {
                            if (rdbMale.Checked == true)
                                gt = "Male";
                            else
                                gt = "Female";
                            var nv = from u in db.nhanViens
                                     where u.tenNV == txtName.Text && u.ngSinh == dtpBirthday.Value
                                        && u.ngVaoLam == dtpNVL.Value
                                     select u;
                            dgvEmployees.DataSource = nv;
                        }
                        else if (chbName.Checked == true && chbNS.Checked == true && chbSex.Checked == true)
                        {
                            if (rdbMale.Checked)
                                gt = "Male";
                            else
                                gt = "Female";
                            var nv = from u in db.nhanViens
                                     where u.tenNV == txtName.Text && u.ngSinh == dtpBirthday.Value
                                        && u.gioiTinh == gt
                                     select u;
                            dgvEmployees.DataSource = nv;
                        }
                        else if (chbName.Checked == true && chbNVL.Checked == true && chbSex.Checked == true)
                        {
                            if (rdbMale.Checked)
                                gt = "Male";
                            else
                                gt = "Female";
                            var nv = from u in db.nhanViens
                                     where u.tenNV == txtName.Text
                                        && u.ngVaoLam == dtpNVL.Value && u.gioiTinh == gt
                                     select u;
                            dgvEmployees.DataSource = nv;
                        }
                        else if (chbNS.Checked == true && chbNVL.Checked == true && chbSex.Checked == true)
                        {
                            if (rdbMale.Checked == true)
                                gt = "Male";
                            else
                                gt = "Female";
                            var nv = from u in db.nhanViens
                                     where u.ngSinh == dtpBirthday.Value
                                        && u.ngVaoLam == dtpNVL.Value && u.gioiTinh == gt
                                     select u;
                            dgvEmployees.DataSource = nv;
                        }
                        else if (chbName.Checked == true && chbNS.Checked == true)
                        {
                            if (rdbMale.Checked == true)
                                gt = "Male";
                            else
                                gt = "Female";
                            var nv = from u in db.nhanViens
                                     where u.tenNV == txtName.Text && u.ngSinh == dtpBirthday.Value
                                     select u;
                            dgvEmployees.DataSource = nv;
                        }
                        else if (chbName.Checked == true && chbNVL.Checked == true)
                        {
                            if (rdbMale.Checked == true)
                                gt = "Male";
                            else
                                gt = "Female";
                            var nv = from u in db.nhanViens
                                     where u.tenNV == txtName.Text && u.ngVaoLam == dtpNVL.Value
                                     select u;
                            dgvEmployees.DataSource = nv;
                        }
                        else if (chbName.Checked == true && chbSex.Checked == true)
                        {
                            if (rdbMale.Checked == true)
                                gt = "Male";
                            else
                                gt = "Female";
                            var nv = from u in db.nhanViens
                                     where u.tenNV == txtName.Text && u.gioiTinh == gt
                                     select u;
                            dgvEmployees.DataSource = nv;
                        }
                        else if (chbNS.Checked == true && chbNVL.Checked == true)
                        {
                            if (rdbMale.Checked == true)
                                gt = "Male";
                            else
                                gt = "Female";
                            var nv = from u in db.nhanViens
                                     where u.ngSinh == dtpBirthday.Value
                                        && u.ngVaoLam == dtpNVL.Value
                                     select u;
                            dgvEmployees.DataSource = nv;
                        }
                        else if (chbNS.Checked == true && chbSex.Checked == true)
                        {
                            if (rdbMale.Checked == true)
                                gt = "Male";
                            else
                                gt = "Female";
                            var nv = from u in db.nhanViens
                                     where u.ngSinh == dtpBirthday.Value && u.gioiTinh == gt
                                     select u;
                            dgvEmployees.DataSource = nv;
                        }
                        else if (chbNVL.Checked == true && chbSex.Checked == true)
                        {
                            if (rdbMale.Checked == true)
                                gt = "Male";
                            else
                                gt = "Female";
                            var nv = from u in db.nhanViens
                                     where u.ngVaoLam == dtpNVL.Value && u.gioiTinh == gt
                                     select u;
                            dgvEmployees.DataSource = nv;
                        }
                        else if (chbName.Checked == true)
                        {
                            if (rdbMale.Checked == true)
                                gt = "Male";
                            else
                                gt = "Female";
                            var nv = from u in db.nhanViens
                                     where u.tenNV == txtName.Text
                                     select u;
                            dgvEmployees.DataSource = nv;
                        }
                        else if (chbNS.Checked == true)
                        {
                            if (rdbMale.Checked == true)
                                gt = "Male";
                            else
                                gt = "Female";
                            var nv = from u in db.nhanViens
                                     where u.ngSinh == dtpBirthday.Value
                                     select u;
                            dgvEmployees.DataSource = nv;
                        }
                        if (chbNVL.Checked == true)
                        {
                            if (rdbMale.Checked == true)
                                gt = "Male";
                            else
                                gt = "Female";
                            var nv = from u in db.nhanViens
                                     where u.ngVaoLam == dtpNVL.Value
                                     select u;
                            dgvEmployees.DataSource = nv;
                        }
                        if (chbSex.Checked == true)
                        {
                            if (rdbMale.Checked == true)
                                gt = "Male";
                            else
                                gt = "Female";
                            var nv = from u in db.nhanViens
                                     where u.gioiTinh == gt
                                     select u;
                            dgvEmployees.DataSource = nv;
                        }
                        break;
                    }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Uc_Employees_Load(sender, e);
            gunaPanel1.Visible = false;
        }

        private void bunifuMaterialTextbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
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
