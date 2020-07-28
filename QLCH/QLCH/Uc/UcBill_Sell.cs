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
using System.Text.RegularExpressions;

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
            btnMail.Visible = false;
            btnPrintBill.Visible = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = db.hdx_select();
        }
        string hd = "";
  
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnPrintBill.Visible = true;
                btnMail.Visible = true;
                //int i = dataGridView1.CurrentRow.Index;
                hoadDonXuat hdx = db.hoadDonXuats.Where(s => s.maHDX == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()).FirstOrDefault();
                //tranferId.id = hdx.maHDX;
                //hd = hdx.maHDX;
                khachHang kh = db.khachHangs.Where(s => s.maKH == hdx.maKH).FirstOrDefault();


                txtCusName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCusPhone.Text = kh.sdt.ToString();
                txtCusAddress.Text = kh.diaChi.ToString();
                txtCusEmail.Text = kh.email.ToString();

                txtBillid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtBillDate.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtBillStatus.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

                txtStaffName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

                txtBillPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                
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

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            Frm_Mail mail = new Frm_Mail();
            mail.ShowDialog();
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
        private void txtCusEmail_Leave(object sender, EventArgs e)
        {
            if (!isEmail(txtCusEmail.Text))
            {
                MessageBox.Show("Email incorrect", "Error");
                txtCusEmail.Focus();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                hoadDonXuat hdx = db.hoadDonXuats.Where(s => s.maHDX == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()).FirstOrDefault();
                tranferId.id = hdx.maHDX;
                if (dataGridView1.Columns[e.ColumnIndex].Name == "detail")
                {
                    
                    Frm_Detail_Bill frm_Detail_Bill = new Frm_Detail_Bill();
                    frm_Detail_Bill.ShowDialog();
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "delete")
                {
                    //chiTietHDX ct = db.chiTietHDXes.Where(s => s.maHDX == hd).FirstOrDefault();
                    DialogResult result = MessageBox.Show("Are you sure ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        
                        db.update_status_hoadon(hdx.maHDX, "Cancel");
                        db.update_tongtienHD(hdx.maHDX,0);
                        foreach (var a in db.chiTietHDXes.Where(s => s.maHDX == hdx.maHDX))
                        {
                            sanPham sp = db.sanPhams.Where(s => s.maSP == a.maSP).FirstOrDefault();
                            db.update_soluong(a.maSP, sp.soLuong + a.soLuong);
                            db.update_chitiet(a.maHDX, 0, 0);
                        }
                        UcBill_Sell_Load(sender, e);
                        
                    }
                }
            }
        }
    }
}
