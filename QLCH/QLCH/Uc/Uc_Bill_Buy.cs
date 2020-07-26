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
    public partial class Uc_Bill_Buy : UserControl
    {
        public Uc_Bill_Buy()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        
        public class GetData
        {
            public static string idBill = "";
            public static string trThai = "";
        }
        DateTime from = DateTime.Now, to = DateTime.Now;
        private void Uc_Bill_Buy_Load(object sender, EventArgs e)
        {
            nhanVien nv = db.nhanViens.Where(s => s.maNV.Equals(frmLogin.GetID.id) && s.maCV == "cv4").FirstOrDefault();
            if (nv == null)
            {
                btnSave.Visible = false;
                rtxtNote.Enabled = false;
            }
            else
            {
                rtxtNote.Enabled = true;
                btnSave.Visible = true;
            }
            
            //dtpFrom.Value = from;
            //dtpTo.Value = to;
            from = dtpFrom.Value;
            to = dtpTo.Value;
            //var locHD = db.hoadDonNhaps.Where(s => s.ngayNhap >= from && s.ngayNhap <= to);
            dgvBillBuy.AutoGenerateColumns = false;
            dgvBillBuy.DataSource = db.HDN_Sel_Date(from, to);
            dgvBillBuy.Columns[2].DefaultCellStyle.Format = "N0";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Uc_Bill_Buy_Load(sender, e);
        }

        private void dgvBillBuy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnPrintBill.Visible = true;
            btnMail.Visible = true;
            if (e.RowIndex >= 0)
            {
                GetData.idBill = dgvBillBuy.Rows[e.RowIndex].Cells[0].Value.ToString();
                GetData.trThai = dgvBillBuy.Rows[e.RowIndex].Cells[3].Value.ToString();
                if (dgvBillBuy.Columns[e.ColumnIndex].Name.Equals("Column5"))
                {
                    frmDetail_Import_Bill frmDetail_Import_Bill = new frmDetail_Import_Bill();
                    Uc_SanPham.GetData.idBill = idSp;
                    frmDetail_Import_Bill.ShowDialog();
                    Uc_SanPham.GetData.idBill = "";
                    Uc_Bill_Buy_Load(sender, e);
                }
                else if (dgvBillBuy.Columns[e.ColumnIndex].Name.Equals("Column6"))
                {
                    if (GetData.trThai == "Paid")
                    {
                        nhanVien nv = db.nhanViens.Where(s => s.maNV.Equals(frmLogin.GetID.id) && s.maCV == "cv4").FirstOrDefault();
                        if (nv == null)
                        {
                            //btnSave.Visible = false;
                            //MessageBox.Show("You do not have permission to cancel the bill was paid");
                            //MessageBox.Show("This bill cannot be cancel.\nBecause it was cancel already or was paid");
                            //rtxtNote.Visible = false;
                            //lbNote.Visible = false;
                            
                        }
                        else
                        {
                            //rtxtNote.Visible = true;
                            //lbNote.Visible = true;
                            //btnSave.Visible = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("This bill don't need to cancel");
                        //rtxtNote.Visible = true;
                        //lbNote.Visible = true;
                        //btnSave.Visible = true;
                    }
                }
            }
        }
        string idSp = "";
        private void dgvBillBuy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnPrintBill.Visible = true;
                btnMail.Visible = true;
                GetData.trThai = dgvBillBuy.Rows[e.RowIndex].Cells[3].Value.ToString();
                idSp = dgvBillBuy.Rows[e.RowIndex].Cells[0].Value.ToString();
                GetData.idBill = idSp;
                
                var hdn = db.hoadDonNhaps.Where(s => s.maHDN.Equals(idSp)).FirstOrDefault();
                //rtxtNote.Text = hdn.ghiChu;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            hoadDonNhap hdn = db.hoadDonNhaps.Where(s=>s.maHDN.Equals(idSp)&& Uc_Bill_Buy.GetData.trThai == "Paid").FirstOrDefault();
            if (hdn != null)
            {
                hdn.trangThai = "Cancel";
                //hdn.ghiChu = rtxtNote.Text;
                db.SubmitChanges();
                Uc_Bill_Buy_Load(sender, e);
                var cthdn = from u in db.chiTietHDNs.Where(s => s.maHDN == idSp)
                            select u;
                foreach (var item in cthdn)
                {
                    var sp = db.sanPhams.Where(s => s.maSP == item.maSP).FirstOrDefault();
                    int sl = (int)sp.soLuong;
                    db.update_soluong(item.maSP, sl - item.soLuong);
                }
                MessageBox.Show("Done");
            }
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            Frm_Import_report report = new Frm_Import_report();
            report.ShowDialog();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Frm_Mail mail = new Frm_Mail();
            mail.ShowDialog();
        }
    }
}
