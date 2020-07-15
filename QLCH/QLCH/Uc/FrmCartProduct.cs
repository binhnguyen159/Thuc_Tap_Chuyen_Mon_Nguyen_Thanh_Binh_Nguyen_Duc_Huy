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
        private fFRMLOAD ldd;
        public class tranferPrice
        {
            static public double totalPrice;
            static public int signal;
        }
        private tranferDataGG data;
        public FrmCartProduct(fFRMLOAD lddd, tranferDataGG dt)
        {
            InitializeComponent();
            ldd = lddd;
            data = dt;
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            db.delete_CTcart(Convert.ToInt32(lbMaCTGio.Text));
            ldd();
            this.Close();
        }


        private void btnUp_Click(object sender, EventArgs e)
        {
            lbNumber.Text = (Convert.ToInt32(lbNumber.Text) + 1).ToString();
            sanPham sp = db.sanPhams.Where(s => s.maSP == idProduct).FirstOrDefault();
            if (Convert.ToInt32(lbNumber.Text) < sp.soLuong)
            {
                db.update_SoLuongGio(Convert.ToInt32(lbMaCTGio.Text), Convert.ToInt32(lbNumber.Text), Convert.ToDouble(lbPrice.Text));

                
                db.update_soluong(idProduct, sp.soLuong + Convert.ToInt32(lbNumber.Text));


                ldd();
            }

            //////db.update_SoLuongGio(Convert.ToInt32(lbMaCTGio.Text), Convert.ToInt32(lbNumber.Text));
            //UCCart uC = new UCCart();
            //uC.Show();

        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lbNumber.Text) > 0)
            {
                lbNumber.Text = (Convert.ToInt32(lbNumber.Text) - 1).ToString();

                db.update_SoLuongGio(Convert.ToInt32(lbMaCTGio.Text), Convert.ToInt32(lbNumber.Text), Convert.ToDouble(lbPrice.Text));
                sanPham sp = db.sanPhams.Where(s => s.maSP == idProduct).FirstOrDefault();
                db.update_soluong(idProduct, sp.soLuong + Convert.ToInt32(lbNumber.Text));
                ldd();

                ////db.update_SoLuongGio(Convert.ToInt32(lbMaCTGio.Text), Convert.ToInt32(lbNumber.Text));
                //UCCart uC = new UCCart();
                //uC.Show();

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
                lbPrice.Text = (price * Convert.ToInt32(lbNumber.Text)).ToString();
            }

        }
        double price;
        String idProduct;
        private void FrmCartProduct_Load(object sender, EventArgs e)
        {


            try
            {
                idProduct = data.ProductId;
                lbMaCTGio.Text = data.IDCartDetail1.ToString();
                lbProductName.Text = data.ProductName;
                lbPriceDefault.Text = data.ProductDefaultPrice.ToString();
                lbNumber.Text = data.ProductQuantity.ToString();
                lbProductName.Text = data.ProductName;
                pictureBox1.Image = data.ProductImg;
                lbPrice.Text = (Convert.ToDouble(lbPriceDefault.Text) * Convert.ToInt32(lbNumber.Text)).ToString();
                price = Convert.ToDouble(lbPriceDefault.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


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
