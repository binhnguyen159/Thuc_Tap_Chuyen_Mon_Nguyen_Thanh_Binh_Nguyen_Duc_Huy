using DevExpress.XtraCharts;
using DevExpress.XtraGauges.Core.Model;
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
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void FormThongKe_Load(object sender, EventArgs e)
        {

            Decimal total = 0;
            foreach(var a in db.thongKeDoanhThu())
            {
                total += Convert.ToDecimal(a.tien);
            }
            lbTotal.Text = total.ToString("C0");

            chartControl1.DataSource = db.thongKeDoanhThu().ToList();
            chartControl1.SeriesDataMember = "thang";
            chartControl1.SeriesTemplate.ArgumentDataMember = "thang";
            chartControl1.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "tien" });
            chartControl1.SeriesTemplate.View = new StackedBarSeriesView();



        }
    }
}

