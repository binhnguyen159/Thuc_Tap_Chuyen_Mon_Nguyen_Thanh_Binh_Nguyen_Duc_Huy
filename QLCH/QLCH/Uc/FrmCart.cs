using DevExpress.XtraExport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH.Uc
{
    public partial class FrmCart : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public FrmCart()
        {
            InitializeComponent();
        }

        private void FrmCart_Load(object sender, EventArgs e)
        {
           
            panelProductList.Controls.Clear();
            foreach (var a in db.select_detailCart(1))
            {
                tranferDataGG data = new tranferDataGG(a.masp, a.tenSP, Convert.ToDouble(a.gia), Convert.ToInt32(a.soLuong), convertImg(a.masp), a.maCTG);


                FrmCartProduct cartProduct = new FrmCartProduct(loadData_whenUpdateQuantity, data);
                cartProduct.Dock = DockStyle.Top;
                cartProduct.TopLevel = false;
                panelProductList.Controls.Add(cartProduct);
                cartProduct.Show();


            }
            loadData_whenUpdateQuantity();


        }


        private Image convertImg(String masp)
        {
            sanPham sp = db.sanPhams.Where(s => s.maSP == masp).FirstOrDefault();

            if (sp.anh == null)
            {
                return null;
            }
            else
            {
                MemoryStream img = new MemoryStream(sp.anh.ToArray());
                Image image = Image.FromStream(img);
                return image;
            }

        }
        private void loadData_whenUpdateQuantity()
        {

            double totalmoney = 0;
            //nho chuyen bien
            //CTGio gio = db.CTGios.Where(s => s.magio ==1).FirstOrDefault();
            foreach (var a in db.selectTotalPrice())
            {
                totalmoney += Convert.ToDouble(a.a);
            }
            lbTotalPrice.Text = totalmoney.ToString();

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            foreach(var a in db.CTGios)
            {
                db.cthdx_insert("hdx"+a.maCTG, a.masp, Convert.ToDouble(a.donGia), Convert.ToInt32(a.soluong), Convert.ToDouble(a.thanhTien));
            }
        }
    }

}
