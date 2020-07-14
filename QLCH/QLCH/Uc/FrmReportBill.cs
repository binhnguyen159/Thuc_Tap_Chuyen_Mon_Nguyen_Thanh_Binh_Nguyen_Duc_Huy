using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH.Uc
{
    public partial class FrmReportBill : Form
    {
        public FrmReportBill()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void FrmReportBill_Load(object sender, EventArgs e)
        {

            
            this.reportViewer1.RefreshReport();
            //reportViewer = db.bill_info(UcBill_Sell.tranferId.id);
            
        }
    }
}
