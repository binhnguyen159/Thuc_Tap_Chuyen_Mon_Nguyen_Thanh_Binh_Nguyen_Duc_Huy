using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using DevExpress.Utils.Extensions;
using System.IO;

namespace QLCH.Uc
{
    public partial class UCCart : UserControl
    {
        public class tranferData
        {
            static public String productId;
            static public String productName;
         
            static public double productDefaultPrice;
            static public String productUnit;
            static public int productQuantity;
            static public Image productImg;
            static public int IDCartDetail;
        }
        public UCCart()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void UCCart_Load(object sender, EventArgs e)
        {
            // foreach(var h in db.s)

            foreach (var a in db.select_detailCart(1))
            {

                tranferData.productId = a.masp;
                tranferData.productName = a.tenSP;
                
                tranferData.productDefaultPrice = Convert.ToDouble(a.gia);
                tranferData.productQuantity = Convert.ToInt32(a.soLuong);
                tranferData.productImg = convertImg(a.masp);
                tranferData.IDCartDetail = a.maCTG;


                FrmCartProduct cartProduct = new FrmCartProduct();
                cartProduct.Dock = DockStyle.Top;
                cartProduct.TopLevel = false;
                panelProductList.Controls.Add(cartProduct);
                cartProduct.Show();





                //load anh len
                //
                //Load database cart
            }
        }
        private Image convertImg(String masp)
        {
            sanPham sp = db.sanPhams.Where(s => s.maSP == masp).FirstOrDefault();
            MemoryStream img = new MemoryStream(sp.anh.ToArray());
            Image image = Image.FromStream(img);
            if (sp == null)
            {
                return null;
            }
            else
            {
                return image;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelProductList.Controls.Clear();
        }
    }
}
