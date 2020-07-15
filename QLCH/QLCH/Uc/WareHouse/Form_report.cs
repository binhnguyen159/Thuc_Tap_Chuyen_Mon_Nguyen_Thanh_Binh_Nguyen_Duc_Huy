using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH.Uc.WareHouse
{
    public partial class Form_report : Form
    {
        public Form_report()
        {
            InitializeComponent();
        }

        private void Form_report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'billOfCus.bill_info' table. You can move, or remove it, as needed.
            this.bill_infoTableAdapter.Fill(this.billOfCus.bill_info,UcBill_Sell.tranferId.id);

            this.reportViewer1.RefreshReport();
          
        }
    }
}
