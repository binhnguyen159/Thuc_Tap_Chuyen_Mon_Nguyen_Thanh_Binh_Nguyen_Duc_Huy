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
    public partial class frmChooseProvider : Form
    {
        public frmChooseProvider()
        {
            InitializeComponent();
        }

        public class GetData
        {
            public static string idNCC = "";
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        private void frmChooseProvider_Load(object sender, EventArgs e)
        {
            GetData.idNCC = "";
            cbbNCC.ValueMember = "maNCC";
            cbbNCC.DisplayMember = "tenNCC";
            cbbNCC.DataSource = db.nhaCungCaps;
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            GetData.idNCC = "";
            Uc_SanPham.GetData.idBill = "";
            this.Close();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            GetData.idNCC = cbbNCC.SelectedValue.ToString();
            this.Close();
        }
        
    }
}
