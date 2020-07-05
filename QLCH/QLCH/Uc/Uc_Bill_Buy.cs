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
    public partial class Uc_Bill_Buy : UserControl
    {
        public Uc_Bill_Buy()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void btnShow_Click(object sender, EventArgs e)
        {
            Uc_Bill_Buy_Load(sender, e);
        }

        private void Uc_Bill_Buy_Load(object sender, EventArgs e)
        {
            DateTime from, to;
            from = dtpFrom.Value;
            to = dtpTo.Value;
            var locHD = db.hoadDonNhaps.Where(s => s.ngayNhap >= from && s.ngayNhap <= to);
            dgvBillBuy.DataSource = locHD;
        }
    }
}
