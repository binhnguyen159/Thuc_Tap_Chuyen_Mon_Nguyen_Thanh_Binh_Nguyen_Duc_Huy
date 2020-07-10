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
         
            static public int productQuantity;
            static public Image productImg;
            static public int IDCartDetail;
        }
        public UCCart()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();

        double totalPrice = 0;
        double tong = 0;

        private void loadData_whenUpdateQuantity()
        {
            double totalmoney = 0;
            //nho chuyen bien
            //CTGio gio = db.CTGios.Where(s => s.magio ==1).FirstOrDefault();
            foreach (var a in db.CTGios)
            {
                totalmoney += Convert.ToDouble(a.thanhTien);
            }
            lbTotalPrice.Text = totalmoney.ToString();
        }

        private void UCCart_Load(object sender, EventArgs e)
        {
            //foreach (var h in db.sanPhams)

            foreach (var a in db.select_detailCart(1))
            {

                tranferData.productId = a.masp;
                tranferData.productName = a.tenSP;

                tranferData.productDefaultPrice = Convert.ToDouble(a.gia);
                tranferData.productQuantity = Convert.ToInt32(a.soLuong);
                tranferData.productImg = convertImg(a.masp);
                tranferData.IDCartDetail = a.maCTG;


                //FrmCartProduct cartProduct = new FrmCartProduct(loadData_whenUpdateQuantity);
                //cartProduct.Dock = DockStyle.Top;
                //cartProduct.TopLevel = false;
                //panelProductList.Controls.Add(cartProduct);
                //cartProduct.Show();




                tong = FrmCartProduct.tranferPrice.totalPrice;
                totalPrice += tong;


            }
            double demTien = 0;
            foreach (var b in db.CTGios)
            {
               demTien +=Convert.ToDouble( b.thanhTien.ToString());

            }
            lbTest.Text = demTien.ToString();
            lbTotalPrice.Text = totalPrice.ToString();
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

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            foreach (var h in db.CTGios)
            {
                //db.insert
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    CTGio a = db.CTGios.Where(s => s.maCTG == 2).FirstOrDefault();
            //    //foreach (var a in db.select_detailCart(1))
            //    //{
            //    sanPham sp = db.sanPhams.Where(s => s.maSP == a.masp).FirstOrDefault();
            //    tranferData.productId = a.masp;
            //    tranferData.productName = sp.tenSP;

            //    tranferData.productDefaultPrice = Convert.ToDouble(a.donGia);
            //    tranferData.productQuantity = Convert.ToInt32(a.soluong);
            //    tranferData.productImg = convertImg(a.masp);
            //    tranferData.IDCartDetail = a.maCTG;


            //FrmCartProduct cartProduct = new FrmCartProduct(loadData_whenUpdateQuantity);
            //cartProduct.Dock = DockStyle.Top;
            //cartProduct.TopLevel = false;
            //panelProductList.Controls.Add(cartProduct);
            //cartProduct.Show();

            //    tong = FrmCartProduct.tranferPrice.totalPrice;
            //    totalPrice += tong;

            //    //}


            //    lbTotalPrice.Text = totalPrice.ToString();
        }
    }
}
