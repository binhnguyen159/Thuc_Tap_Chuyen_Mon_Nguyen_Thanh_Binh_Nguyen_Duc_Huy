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
    public partial class UCCart : UserControl
    {
        public UCCart()
        {
            InitializeComponent();
        }

        private void UCCart_Load(object sender, EventArgs e)
        {
            for(int i = 0; i <= 10; i++)
            {
                UCCartProduct uCCartProduct = new UCCartProduct();
                uCCartProduct.Dock = DockStyle.Top;
                panelProductList.Controls.Add(uCCartProduct);
                uCCartProduct.Show();
            }
           //Load database cart
        }
    }
}
