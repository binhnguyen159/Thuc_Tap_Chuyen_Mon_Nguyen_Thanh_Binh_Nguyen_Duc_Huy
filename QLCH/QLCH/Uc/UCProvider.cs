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
    public partial class UCProvider : UserControl
    {
        public UCProvider()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        int choose;
        int ma;
        int dem = 0;
        private void UCProvider_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = db.nhaCungCaps;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            choose = 1;
            nhaCungCap nhaCungCap = new nhaCungCap();
            if (nhaCungCap == null)
            {
                ma = 1;
            }
            else
            {
                foreach (var a in db.nhaCungCaps)
                {
                    dem++;
                }
                ma = dem + 1;
                lbMa.Text = ma.ToString();
                dem = 0;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            choose = 2;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (choose == 1)
            {

                if (txtProviderName.Text == "" || txtEmail.Text == "" || txtAddress.Text == "" || txtPhoneNumber.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên sản phẩm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProviderName.Focus();
                }
                else
                {
                    //db.addProvider("ncc" + lbMa.Text, txtProviderName.Text, txtEmail.Text, txtAddress.Text, txtPhoneNumber.Text);
                    UCProvider_Load(sender, e);
                }
            }
            if (choose == 2)
            {
                if (txtProviderName.Text == "" || txtEmail.Text == "" || txtAddress.Text == "" || txtPhoneNumber.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên sản phẩm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProviderName.Focus();
                }
                else
                {
                    //db.updateProvider(lbMa.Text, txtProviderName.Text, txtEmail.Text, txtAddress.Text, txtPhoneNumber.Text);
                    UCProvider_Load(sender, e);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            lbMa.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtProviderName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtPhoneNumber.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            btnAdd.Enabled = false;
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
