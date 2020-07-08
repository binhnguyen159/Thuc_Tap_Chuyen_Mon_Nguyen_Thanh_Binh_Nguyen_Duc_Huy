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
    public partial class UCCartProduct : UserControl
    {
        public UCCartProduct()
        {
            InitializeComponent();
        }
       

        private void btnUp_Click(object sender, EventArgs e)
        {
            lbNumber.Text = (Convert.ToInt32(lbNumber.Text) + 1).ToString();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            lbNumber.Text = (Convert.ToInt32(lbNumber.Text) - 1).ToString();
        }

        private void lbNumber_TextChanged(object sender, EventArgs e)
        {
            lbPrice.Text = (Convert.ToDouble(lbPriceDefault.Text) * Convert.ToInt32(lbNumber.Text)).ToString();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            //code xoa this UC

            //this.Controls.
        }

        private void UCCartProduct_Load(object sender, EventArgs e)
        {
            lbPrice.Text = lbPriceDefault.Text;
            
        }
    }
}
