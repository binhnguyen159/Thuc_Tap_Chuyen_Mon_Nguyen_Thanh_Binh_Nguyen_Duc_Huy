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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Uc_SanPham sanPham = new Uc_SanPham();
            panel1.Controls.Add(sanPham);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
