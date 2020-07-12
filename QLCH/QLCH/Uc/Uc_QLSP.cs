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
    public partial class Uc_QLSP : UserControl
    {
        public Uc_QLSP()
        {
            InitializeComponent();
        }

        private void Uc_QLSP_Load(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    {
                        pnlGroupSP.Controls.Clear();
                        Uc_NSP nsp = new Uc_NSP();
                        pnlGroupSP.Controls.Add(nsp);

                        break;
                    }
                case 1:
                    {
                        pnlHangSP.Controls.Clear();
                        Uc_HangSP hangSP = new Uc_HangSP();
                        pnlHangSP.Controls.Add(hangSP);
                        break;

                    }
                case 2:
                    {
                        pnlProduct.Controls.Clear();
                        Uc_SanPham sanPham = new Uc_SanPham();
                        pnlProduct.Controls.Add(sanPham);
                        break;
                    }
            }
        }
    }
}
