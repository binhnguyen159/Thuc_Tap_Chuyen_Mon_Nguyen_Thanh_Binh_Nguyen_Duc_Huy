using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private void btnGetPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            
            if (open.ShowDialog() == DialogResult.OK)
                open.Filter = "Pictures files (*.jpg,*jpeg,*.jpe,*.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            //ptbAvatar.Image = new Bitmap(open.FileName);
            //ptbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == "" || txtEmail.Text == "" || txtName.Text == "" || txtPhone.Text == "")
                MessageBox.Show("Bạn chưa điền hết thông tin");
            else
            {
                gt = "";
                if (rdbMale.Checked == true)
                    gt = "Nam";
                else
                    gt = "Nữ";
                int ma = 1;
                string id = "NV";
                var nv = from u in db.nhanViens select u;
                if(nv.Count() == 0)
                {
                    id = id + ma;
                    db.NV_Ins(id, txtName.Text, gt, dtpBirthday.Value, dtpNVL.Value, txtEmail.Text, txtAddress.Text, txtPhone.Text);
                }
                else if(nv.Count()>0)
                {
                    var nv2 = db.NV_Sel().OrderByDescending(s => s.maNV).FirstOrDefault();
                    ma = Convert.ToInt32(nv2.maNV.ToString().Trim().Substring(2)) + 1;
                    id = "NV" + ma;
                    db.NV_Ins(id, txtName.Text, gt, dtpBirthday.Value, dtpNVL.Value, txtEmail.Text, txtAddress.Text, txtPhone.Text);
                }
                Uc_Employees_Load(sender, e);  
            }
        }
        int i = 0;
        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            lbID.Text = dgvEmployees.Rows[i].Cells[0].Value.ToString();
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

        private void btnDel_Click(object sender, EventArgs e)
        {
            db.NV_Del(lbID.Text);
            Uc_Employees_Load(sender, e);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            
            nhanVien nv = db.nhanViens.Where(s => s.maNV == lbID.Text).FirstOrDefault();
            if (nv == null)
                return;
            else
            {
                if (rdbMale.Checked == true)
                    gt = "Nam";
                else
                    gt = "Nữ";
                db.NV_Up(lbID.Text, txtName.Text, gt, dtpBirthday.Value, dtpNVL.Value, txtEmail.Text, txtAddress.Text, txtPhone.Text);
                Uc_Employees_Load(sender, e);
            }
            
        }
    }
}
