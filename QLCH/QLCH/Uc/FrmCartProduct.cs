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
    public partial class FrmCartProduct : Form
    {

        public FrmCartProduct()
        {
            InitializeComponent();

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            lbNumber.Text = (Convert.ToInt32(lbNumber.Text) + 1).ToString();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lbNumber.Text) > 0)
            {
                lbNumber.Text = (Convert.ToInt32(lbNumber.Text) - 1).ToString();
            }
        }

        private void lbNumber_TextChanged(object sender, EventArgs e)
        {
            if (lbNumber.Text != "")
            {
                lbPrice.Text = (Convert.ToDouble(lbPriceDefault.Text) * Convert.ToInt32(lbNumber.Text)).ToString("N0");
            }
            else
            {
                lbNumber.Text = "0";
            }
        }

        private void FrmCartProduct_Load(object sender, EventArgs e)
        {
            lbProductName.Text = UCCart.tranferData.productName;
            lbPriceDefault.Text = UCCart.tranferData.productDefaultPrice.ToString("N0")+ "VNĐ";
            lbPrice.Text = UCCart.tranferData.productPrice.ToString("N0") + "VNĐ";
            //UCCart.tranferData.productQuantity;
            lbProductName.Text = UCCart.tranferData.productName;
            pictureBox1.Image = UCCart.tranferData.productImg;
            lbPrice.Text = lbPriceDefault.Text;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
