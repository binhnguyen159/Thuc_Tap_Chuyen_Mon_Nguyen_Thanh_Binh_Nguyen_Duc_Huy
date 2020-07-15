using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCH.Uc.WareHouse;

namespace QLCH.Uc
{
    public partial class UcBill_Sell : UserControl
    {
        public class tranferId
        {
            static public String id;
        }
        public UcBill_Sell()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void UcBill_Sell_Load(object sender, EventArgs e)
        {
            btnPrintBill.Visible = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = db.hdx_select();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnPrintBill.Visible = true;
            int i = dataGridView1.CurrentRow.Index;
            hoadDonXuat hdx = db.hoadDonXuats.Where(s => s.maHDX == dataGridView1.Rows[i].Cells[0].Value.ToString()).FirstOrDefault();
            tranferId.id = hdx.maHDX;
            khachHang kh = db.khachHangs.Where(s => s.maKH == hdx.maKH).FirstOrDefault();

            txtCusName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtCusPhone.Text = kh.sdt.ToString();
            txtCusAddress.Text = kh.diaChi.ToString();
            txtCusEmail.Text = kh.email.ToString();

            txtBillid.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtBillDate.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtBillStatus.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();

            txtStaffName.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();

            txtBillPrice.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            if (dataGridView1.Columns[e.ColumnIndex].Name == "detail")
            {
                Frm_Detail_Bill frm_Detail_Bill = new Frm_Detail_Bill();
                frm_Detail_Bill.ShowDialog();
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "delete")
            {
                DialogResult result = MessageBox.Show("Are you sure ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    db.update_status_hoadon(hdx.maHDX, "Cancel");
                    UcBill_Sell_Load(sender, e);

                }
            }
        }

        private void txtSearch_OnValueChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.bill_search(txtSearch.Text);

        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            UcBill_Sell_Load(sender, e);
        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            
            Form_report frmReportBill = new Form_report();
            frmReportBill.Show();
        }
    }
}
