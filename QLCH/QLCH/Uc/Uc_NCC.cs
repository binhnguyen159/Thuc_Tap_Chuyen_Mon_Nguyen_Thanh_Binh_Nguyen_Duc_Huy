using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace QLCH.Uc
{
    public partial class Uc_NCC : UserControl
    {
        public Uc_NCC()
        {
            InitializeComponent();
            pnlSave.Enabled = false;
            
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        int choose;
        int ma;
        string str;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GunaButton button = sender as GunaButton;
            if (button.Name.Equals("btnAdd"))
            {
                choose = 1;
                btnTimKiem.Enabled = false;
                btnAdd.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                gunaGroupBox1.Enabled = false;
                pnlSave.Enabled = true;
            }
            else if (button.Name.Equals("btnDelete"))
            {
                choose = 2;
                btnTimKiem.Enabled = false;
                txtID.Enabled = true;
                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = false;
                gunaGroupBox1.Enabled = false;
                pnlSave.Enabled = true;
            }
            else if (button.Name.Equals("btnUpdate"))
            {
                choose = 3;
                txtID.Enabled = true;
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;

                btnTimKiem.Enabled = false;
                btnUpdate.Enabled = true;
                gunaGroupBox1.Enabled = false;
                pnlSave.Enabled = true;
            }
            else if (button.Name.Equals("btnTimKiem"))
            {
                choose = 4;
                txtID.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnAdd.Enabled = false;
                pnlSave.Enabled = true;
                cbbType.Enabled = true;
            }
        }

        private void Uc_NCC_Load(object sender, EventArgs e)
        {
            dgvNCC.AutoGenerateColumns = false;
            dgvNCC.DataSource = db.NCC_Sel();

            
            //pnlSave.Enabled = false;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Uc_NCC_Load(sender, e);
            pnlSave.Enabled = false;
            txtID.Enabled = false;
            
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            gunaGroupBox1.Enabled = true;
            btnTimKiem.Enabled = true;
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNCC.CurrentRow.Index;
            txtID.Text = dgvNCC.Rows[i].Cells[0].Value.ToString();
            txtProviderName.Text = dgvNCC.Rows[i].Cells[1].Value.ToString();
            txtEmail.Text = dgvNCC.Rows[i].Cells[2].Value.ToString();
            txtAddress.Text = dgvNCC.Rows[i].Cells[3].Value.ToString();
            txtPhone.Text = dgvNCC.Rows[i].Cells[4].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (choose == 4)
            {
                if (cbbType.Text == "")
                    MessageBox.Show("Bạn chưa chọn hình thức tìm kiếm");
                else if (cbbType.SelectedIndex == 0)
                    dgvNCC.DataSource = db.NCC_FindiD(txtID.Text);
                else if (cbbType.SelectedIndex == 1)
                    dgvNCC.DataSource = db.NCC_FindName(txtProviderName.Text);
                else if (cbbType.SelectedIndex == 2)
                    dgvNCC.DataSource = db.NCC_FindAddress(txtAddress.Text);

            }
            else if (txtProviderName.Text == "" || txtEmail.Text == "" || txtAddress.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProviderName.Focus();
            }
            else
            {
                switch (choose)
                {
                    case 1:
                        {
                            nhaCungCap ncc3 = db.nhaCungCaps.Where(s => s.tenNCC.Equals(txtProviderName.Text)).FirstOrDefault();
                            if (ncc3 == null)
                            {
                                var ncc2 = from u in db.nhaCungCaps
                                           select u;
                                if (ncc2.Count() == 0)
                                {
                                    db.NCC_Ins("NCC1", txtProviderName.Text, txtEmail.Text, txtAddress.Text, txtPhone.Text);
                                }
                                else if (ncc2.Count() > 0)
                                {
                                    var ncc = db.nhaCungCaps.OrderByDescending(s => s.maNCC).FirstOrDefault();
                                    ma = Convert.ToInt32(ncc.maNCC.Substring(3)) + 1;
                                    str = "NCC" + ma;
                                    db.NCC_Ins(str, txtProviderName.Text, txtEmail.Text, txtAddress.Text, txtPhone.Text);
                                }
                            }
                            else
                                MessageBox.Show("Nhà cung cấp này đã có");
                            Uc_NCC_Load(sender, e);
                            break;
                        }
                    case 2:
                        {
                            db.NCC_Del(txtID.Text);
                            Uc_NCC_Load(sender, e);
                            break;
                        }
                    case 3:
                        {
                            db.NCC_Up(txtID.Text, txtProviderName.Text, txtEmail.Text, txtAddress.Text, txtPhone.Text);
                            Uc_NCC_Load(sender, e);
                            break;
                        }
                    
                }
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
