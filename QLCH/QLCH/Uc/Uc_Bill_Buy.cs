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
        

        private void Uc_Bill_Buy_Load(object sender, EventArgs e)
        {
            DateTime from = DateTime.Now, to = DateTime.Now;
            dtpFrom.Value = from;
            dtpTo.Value = to;
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
            if (e.RowIndex >= 0)
            {
                if (dgvBillBuy.Columns[e.ColumnIndex].Name.Equals("Column5"))
                {
                    frmDetail_Import_Bill frmDetail_Import_Bill = new frmDetail_Import_Bill();
                    Uc_SanPham.GetData.idBill = idSp;
                    frmDetail_Import_Bill.ShowDialog();
                    Uc_SanPham.GetData.idBill = "";
                    Uc_Bill_Buy_Load(sender, e);
                }
                    
            }
        }
        string idSp = "";
        private void dgvBillBuy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idSp = dgvBillBuy.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
    }
}
