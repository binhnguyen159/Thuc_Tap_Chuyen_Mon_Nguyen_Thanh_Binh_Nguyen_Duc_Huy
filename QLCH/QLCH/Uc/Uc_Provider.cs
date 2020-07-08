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
    public partial class Uc_Provider : UserControl
    {
        public Uc_Provider()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        int choose;
        int ma;
        int dem = 0;
        private void UCProvider_Load(object sender, EventArgs e)
        {
            dgvNCC.AutoGenerateColumns = false;
            dgvNCC.DataSource = db.nhaCungCaps;

            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            gunaGroupBox1.Enabled = true;
            pnlSave.Enabled = false;
        }



        private void btnSave_Click1(object sender, EventArgs e)
        {

            
            //if (choose == 1)
            //{

            //}
            //if (choose == 2)
            //{
            //    if (txtProviderName.Text == "" || txtEmail.Text == "" || txtAddress.Text == "" || txtPhoneNumber.Text == "")
            //    {
            //        MessageBox.Show("Vui lòng nhập tên sản phẩm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        txtProviderName.Focus();
            //    }
            //    else
            //    {
            //        //db.updateProvider(lbMa.Text, txtProviderName.Text, txtEmail.Text, txtAddress.Text, txtPhoneNumber.Text);
            //        UCProvider_Load(sender, e);
            //    }
            //}
        }




        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UCProvider_Load(sender, e);
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNCC.CurrentRow.Index;
            txtID.Text = dgvNCC.Rows[i].Cells[0].Value.ToString();
            txtProviderName.Text = dgvNCC.Rows[i].Cells[1].Value.ToString();
            txtEmail.Text = dgvNCC.Rows[i].Cells[2].Value.ToString();
            txtAddress.Text = dgvNCC.Rows[i].Cells[3].Value.ToString();
            txtPhone.Text = dgvNCC.Rows[i].Cells[4].Value.ToString();
            btnAdd.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            GunaButton button = sender as GunaButton;
            if (button.Name.Equals("btnAdd"))
            {
                choose = 1;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                gunaGroupBox1.Enabled = false;
                pnlSave.Enabled = true;
            }
            else if (button.Name.Equals("btnDelete"))
            {
                choose = 2;
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                gunaGroupBox1.Enabled = false;
                pnlSave.Enabled = true;
            }
            else if (button.Name.Equals("btnUpdate"))
            {
                choose = 3;
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                gunaGroupBox1.Enabled = false;
                pnlSave.Enabled = true;
            }
            else if (button.Name.Equals("btnTimKiem"))
            {
                choose = 4;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnAdd.Enabled = false;
                pnlSave.Enabled = true;
                cbbType.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProviderName.Text == "" || txtEmail.Text == "" || txtAddress.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProviderName.Focus();
            }
            switch (choose)
            {
                case 1:
                    {

                        break;
                    }
            }
        }
    }
}
