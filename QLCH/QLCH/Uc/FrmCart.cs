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
            foreach (var a in db.select_detailCart(UCShowProduct.tranferIDBill.cartID))
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
            lbBeforeDisscount.Text = totalmoney.ToString();
            totalmoney = totalmoney * (1 - Convert.ToInt32(numericUpDown1.Value)*0.01);
            lbTotalPrice.Text = totalmoney.ToString();

        }
        int stt = 0;
        string id = "";

        private void gunaButton1_Click(object sender, EventArgs e)
        {

            var hd = from u in db.hoadDonXuats select u;
            if (hd.Count() == 0)
            {

                db.hdx_insert("hdx000001", frmLogin.GetID.id, UCShowProduct.tranferIDBill.CusId, Convert.ToDouble(lbTotalPrice.Text), "Priced", DateTime.Now,Convert.ToInt32(numericUpDown1.Value));


                foreach (var a in db.CTGios)
                {
                    db.cthdx_insert("hdx000001", a.masp, Convert.ToDouble(a.donGia), Convert.ToInt32(a.soluong), Convert.ToDouble(a.thanhTien));
                }

            }
            else
            {
                hoadDonXuat ssp = db.hoadDonXuats.OrderByDescending(s => s.maHDX).FirstOrDefault();
                stt = Convert.ToInt32(ssp.maHDX.ToString().Trim().Substring(3)) + 1;
                if (stt / 10 >= 100000)
                    id = "hdx" + stt;
                else if (stt / 10 >= 1000 && stt / 10 < 10000)
                    id = "hdx0" + stt;
                else if (stt / 10 >= 100 && stt / 10 < 1000)
                    id = "hdx00" + stt;
                else if (stt / 10 >= 10 && stt / 10 < 100)
                    id = "hdx000" + stt;
                else if (stt / 10 >= 1 && stt / 10 < 10)
                    id = "hdx0000" + stt;
                else if (stt / 10 < 1)
                    id = "hdx00000" + stt;

                db.hdx_insert(id, frmLogin.GetID.id, UCShowProduct.tranferIDBill.CusId, Convert.ToDouble(lbTotalPrice.Text), "Priced", DateTime.Now, Convert.ToInt32(numericUpDown1.Value));


                foreach (var a in db.CTGios)
                {
                    db.cthdx_insert(id, a.masp, Convert.ToDouble(a.donGia), Convert.ToInt32(a.soluong), Convert.ToDouble(a.thanhTien));
                }


            }
            db.delete_cart(UCShowProduct.tranferIDBill.cartID);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this cart?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                db.delete_cart(UCShowProduct.tranferIDBill.cartID);
                //db.update_status_hoadon(UCShowProduct.tranferIDBill.maHDX, "Cancel");
                this.Close();
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            loadData_whenUpdateQuantity();
        }
    }

}
