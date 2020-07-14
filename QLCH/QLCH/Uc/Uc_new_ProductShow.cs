using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCH.Uc;
using System.IO;
using QLCH.Uc.WareHouse;

namespace QLCH
{
    public partial class Uc_new_ProductShow : UserControl
    {
        public Uc_new_ProductShow()
        {
            InitializeComponent();
        }
        public class GetIdBill
        {
            public static string id = "";
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        private void Uc_new_ProductShow_Load(object sender, EventArgs e)
        {
            GetIdBill.id = "";
            fpnlProduct.Controls.Clear();
            foreach (sanPham item in db.sanPhams)
            {
                if (item.anh == null)
                {
                    Uc_new_showProduct uc_Product = new Uc_new_showProduct (item.maSP, item.tenSP, null, Convert.ToInt32(item.soLuong));
                    fpnlProduct.Controls.Add(uc_Product);
                }
                else if (item.anh != null)
                {
                    MemoryStream stream = new MemoryStream(item.anh.ToArray());
                    Uc_new_showProduct uc_Product = new Uc_new_showProduct(item.maSP, item.tenSP, Image.FromStream(stream), Convert.ToInt32(item.soLuong));
                    fpnlProduct.Controls.Add(uc_Product);
                }

            }
        }
    }
}
