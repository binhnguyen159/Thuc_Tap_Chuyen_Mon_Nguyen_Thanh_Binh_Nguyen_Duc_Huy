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
using DevExpress.XtraEditors.Filtering.Templates;

namespace QLCH.Uc
{
    public partial class Uc_WareHouse : UserControl
    {
        public Uc_WareHouse()
        {
            InitializeComponent();
        }

        public class GetIdBill
        {
            public static string id = "";
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        private void Uc_WareHouse_Load(object sender, EventArgs e)
        {
            GetIdBill.id = "";
            fpnlProduct.Controls.Clear();
            foreach (sanPham item in db.sanPhams)
            {
                if (item.anh == null)
                {
                    Uc_ProductShow uc_Product = new Uc_ProductShow(item.maSP, item.tenSP, null, Convert.ToInt32(item.soLuong));
                    fpnlProduct.Controls.Add(uc_Product);
                }
                else if(item.anh != null)
                {
                    MemoryStream stream = new MemoryStream(item.anh.ToArray());
                    Uc_ProductShow uc_Product = new Uc_ProductShow(item.maSP, item.tenSP, Image.FromStream(stream), Convert.ToInt32(item.soLuong));
                    fpnlProduct.Controls.Add(uc_Product);
                }

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
                    if (item.anh == null)
                    {
                        Uc_ProductShow uc_Product = new Uc_ProductShow(item.maSP, item.tenSP, null, Convert.ToInt32(item.soLuong));
                        fpnlProduct.Controls.Add(uc_Product);
                    }
                    else if(item.anh!=null)
                    {
                        MemoryStream stream = new MemoryStream(item.anh.ToArray());
                        Uc_ProductShow uc_Product = new Uc_ProductShow(item.maSP, item.tenSP, Image.FromStream(stream), Convert.ToInt32(item.soLuong));
                        fpnlProduct.Controls.Add(uc_Product);
                    }
                    //MemoryStream stream = new MemoryStream(item.anh.ToArray());

                    //Uc_ProductShow uc_Product = new Uc_ProductShow(item.maSP, item.tenSP, Image.FromStream(stream), Convert.ToInt32(item.soLuong));

                    //fpnlProduct.Controls.Add(uc_Product);

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
                    if (item.anh == null)
                    {
                        Uc_ProductShow uc_Product = new Uc_ProductShow(item.maSP, item.tenSP, null, Convert.ToInt32(item.soLuong));
                        fpnlProduct.Controls.Add(uc_Product);
                    }
                    else
                    {
                        MemoryStream stream = new MemoryStream(item.anh.ToArray());
                        Uc_ProductShow uc_Product = new Uc_ProductShow(item.maSP, item.tenSP, Image.FromStream(stream), Convert.ToInt32(item.soLuong));
                        fpnlProduct.Controls.Add(uc_Product);
                    }
                    //MemoryStream stream = new MemoryStream(item.anh.ToArray());

                    //Uc_ProductShow uc_Product = new Uc_ProductShow(item.maSP, item.tenSP, Image.FromStream(stream), Convert.ToInt32(item.soLuong));

                    //fpnlProduct.Controls.Add(uc_Product);

                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            btnImport.Visible = false;
            btnCancle.Visible = true;
            DateTime d = DateTime.Now;
            var phieuNhap = db.PhieuNhaps;
            if (phieuNhap.Count() == 0)
            {
                GetIdBill.id = "PN000001";
                db.PN_Ins("PN000001", "nv2", d);
            }
            else if (phieuNhap.Count() > 0)
            {
                var pn = db.PhieuNhaps.OrderByDescending(s => s.maphieu).FirstOrDefault();
                int stt = Convert.ToInt32(pn.maphieu.Substring(2))+1;
                GetIdBill.id = "";
                if (stt / 10 >= 100000)
                    GetIdBill.id = "PN" + stt;
                else if (stt / 10 >= 1000 && stt / 10 < 10000)
                    GetIdBill.id = "PN0" + stt;
                else if (stt / 10 >= 100 && stt / 10 < 1000)
                    GetIdBill.id = "PN00" + stt;
                else if (stt / 10 >= 10 && stt / 10 < 100)
                    GetIdBill.id = "PN000" + stt;
                else if (stt / 10 >= 1 && stt / 10 < 10)
                    GetIdBill.id = "PN0000" + stt;
                else if (stt / 10 < 1)
                    GetIdBill.id = "PN00000" + stt;
                db.PN_Ins(GetIdBill.id, "nv2", d);
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            btnImport.Visible = true;
            btnCancle.Visible = false;
            MessageBox.Show(GetIdBill.id);
            db.PN_Del(GetIdBill.id);
        }
    }
}
