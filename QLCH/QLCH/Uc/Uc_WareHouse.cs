using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCH.Uc.WareHouse;
using System.IO;

namespace QLCH.Uc
{
    public partial class Uc_WareHouse : UserControl
    {
        public Uc_WareHouse()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();

        private void Uc_WareHouse_Load(object sender, EventArgs e)
        {
            fpnlProduct.Controls.Clear();
            
                foreach (sanPham item in db.sanPhams)
                {
                    MemoryStream stream = new MemoryStream(item.anh.ToArray());

                    Uc_ProductShow uc_Product = new Uc_ProductShow(item.maSP, item.tenSP, Image.FromStream(stream), Convert.ToInt32(item.soLuong));

                    fpnlProduct.Controls.Add(uc_Product);

                }
        }

        private void cbbTypeFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (cbbTypeFind.Text == "Hãng sản phẩm")
            {
                var sp = from u in db.select_SP()
                         where u.tenHang.ToUpper().Contains(txtData.Text.ToUpper())
                         select u;
                fpnlProduct.Controls.Clear();
                foreach (var item in sp/*db.select_SP().Where(s => s.tenHang.Equals(txtData.Text))*/)
                {
                    MemoryStream stream = new MemoryStream(item.anh.ToArray());

                    Uc_ProductShow uc_Product = new Uc_ProductShow(item.maSP, item.tenSP, Image.FromStream(stream), Convert.ToInt32(item.soLuong));

                    fpnlProduct.Controls.Add(uc_Product);

                }
            }
            else if (cbbTypeFind.Text == "Nhóm sản phẩm")
            {
                fpnlProduct.Controls.Clear();
                var sp = from u in db.select_SP()
                         //where String.Compare(u.tenLoai, txtData.Text, true)==0
                         where u.tenLoai.ToUpper().Contains(txtData.Text.ToUpper())
                         select u;
                foreach (var item in sp)
                {
                    MemoryStream stream = new MemoryStream(item.anh.ToArray());

                    Uc_ProductShow uc_Product = new Uc_ProductShow(item.maSP, item.tenSP, Image.FromStream(stream), Convert.ToInt32(item.soLuong));

                    fpnlProduct.Controls.Add(uc_Product);

                }
            }
        }
    }
}
