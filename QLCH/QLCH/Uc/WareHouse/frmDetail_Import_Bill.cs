using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH.Uc.WareHouse
{
    public partial class frmDetail_Import_Bill : Form
    {
        private fFRMLOAD2 frm;
        public frmDetail_Import_Bill()
        {
            InitializeComponent();
            
        }
        public frmDetail_Import_Bill(fFRMLOAD2 frmm)
        {
            InitializeComponent();
            this.frm = frmm;
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void frmDetail_Import_Bill_Load(object sender, EventArgs e)
        {
            if (Uc_Bill_Buy.GetData.trThai == "Unpaid")
            {
                txtGia.Enabled = true;
                txtName.Enabled = true;
                txtSL.Enabled = true;
                btnUpdate.Enabled = true;
                btnThanhToan.Enabled = true;
            }
            else
            {
                txtGia.Enabled = false;
                txtName.Enabled = false;
                txtSL.Enabled = false;
                btnUpdate.Enabled = false;
                btnThanhToan.Enabled = false;
            }
            lbBillID.Text = Uc_SanPham.GetData.idBill;
            dgvCTPN.AutoGenerateColumns = false;
            dgvCTPN.DataSource = db.CTHDN_Sel(lbBillID.Text);
            dgvCTPN.Columns[2].DefaultCellStyle.Format = "N0";
            dgvCTPN.Columns[4].DefaultCellStyle.Format = "N0";
            double sum = 0;
            foreach(var item in db.chiTietHDNs.Where(s => s.maHDN == lbBillID.Text))
            {
                sum += item.thanhTien.Value;
            }
            lbTongTien.Text = sum.ToString("N0") + " $";
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //int i = 0;
        string idSP = "";
        private void dgvCTPN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCTPN.Columns[e.ColumnIndex].Name == "Column3")
            {
                var hdn = db.hoadDonNhaps.Where(s => s.maHDN == lbBillID.Text && s.trangThai == "Unpaid");
                if (hdn == null)
                {
                    db.CTHDN_Del(lbBillID.Text, idSP);
                    frmDetail_Import_Bill_Load(sender, e);
                }
                else
                    MessageBox.Show("Can not delete this bill because it was paid or cancel");
                

                //frm(Uc_WareHouse.GetData.from, Uc_WareHouse.GetData.to);
            }
            

        }

        private void dgvCTPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idSP = dgvCTPN.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = dgvCTPN.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSL.Text = dgvCTPN.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtGia.Text = dgvCTPN.Rows[e.RowIndex].Cells[2].Value.ToString();
                sanPham sp = db.sanPhams.Where(s => s.maSP.Equals(idSP)).FirstOrDefault();
                
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtGia.Text == "" || txtName.Text == "" || txtSL.Text == "")
                MessageBox.Show("Please fill all");
            db.CTHDN_Up(lbBillID.Text, idSP, Convert.ToDouble(txtGia.Text), Convert.ToInt32(txtSL.Text));
            frmDetail_Import_Bill_Load(sender, e);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Uc_SanPham.GetData.idBill = "";
            db.HDN_Up(lbBillID.Text, "Paid");
            var cthdn = from u in db.chiTietHDNs.Where(s => s.maHDN == lbBillID.Text)
                      select u;
            foreach(var item in cthdn)
            {
                var sp = db.sanPhams.Where(s => s.maSP == item.maSP).FirstOrDefault();
                int sl =(int) sp.soLuong;
                db.update_soluong(item.maSP, sl + item.soLuong);
            }
        }
    }
}
