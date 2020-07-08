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
        public class tranferPrice
        {
            static public double totalPrice;
            static public int signal;
        }
        public FrmCartProduct()
        {
            InitializeComponent();

        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            db.delete_CTcart(Convert.ToInt32(lbMaCTGio.Text));
            this.Close();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            lbNumber.Text = (Convert.ToInt32(lbNumber.Text) + 1).ToString();
            db.update_SoLuongGio(Convert.ToInt32(lbMaCTGio.Text), Convert.ToInt32(lbNumber.Text));
            UCCart uC = new UCCart();
            uC.Show();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lbNumber.Text) > 0)
            {
                lbNumber.Text = (Convert.ToInt32(lbNumber.Text) - 1).ToString();
                db.update_SoLuongGio(Convert.ToInt32(lbMaCTGio.Text), Convert.ToInt32(lbNumber.Text));
                UCCart uC = new UCCart();
                uC.Show();
            }
        }

        private void lbNumber_TextChanged(object sender, EventArgs e)
        {
            if (lbNumber.Text.Trim() == "" || lbNumber.Text.Trim() == null)
            {
                lbNumber.Text = "0";
            }
            else if (lbNumber.Text.Trim() != "" || lbNumber.Text.Trim() != null)
            {
                lbPrice.Text =(price * Convert.ToInt32(lbNumber.Text)).ToString("N0")+"VNĐ";
                tranferPrice.totalPrice = Convert.ToDouble(price * Convert.ToInt32(lbNumber.Text));
            }

        }
        double price;
        private void FrmCartProduct_Load(object sender, EventArgs e)
        {
            lbMaCTGio.Text = UCCart.tranferData.IDCartDetail.ToString();
            lbProductName.Text = UCCart.tranferData.productName;
            lbPriceDefault.Text = UCCart.tranferData.productDefaultPrice.ToString();
            lbNumber.Text = UCCart.tranferData.productQuantity.ToString();
            lbProductName.Text = UCCart.tranferData.productName;
            pictureBox1.Image = UCCart.tranferData.productImg;
            lbPrice.Text = (Convert.ToDouble(lbPriceDefault.Text) * Convert.ToInt32(lbNumber.Text)).ToString("N0") + "VNĐ";
            price = Convert.ToDouble(lbPriceDefault.Text);


            tranferPrice.totalPrice = Convert.ToDouble(price * Convert.ToInt32(lbNumber.Text));

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
