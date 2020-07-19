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
    public partial class Frm_Import_report : Form
    {
        public Frm_Import_report()
        {
            InitializeComponent();
        }

        private void Frm_Import_report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bill_Import_info.bill_Import_info' table. You can move, or remove it, as needed.
            this.bill_Import_infoTableAdapter.Fill(this.bill_Import_info._bill_Import_info,Uc_Bill_Buy.GetData.idBill);

            this.reportViewer1.RefreshReport();

        }
    }
}
