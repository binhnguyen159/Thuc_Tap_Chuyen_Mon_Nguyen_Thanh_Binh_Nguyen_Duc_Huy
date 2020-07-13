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
using Guna.UI.WinForms;
using System.Runtime.Remoting.Messaging;
using DevExpress.DirectX.Common.DirectWrite;

namespace QLCH.Uc
{
    public partial class Uc_WareHouse : UserControl
    {
        public Uc_WareHouse()
        {
            InitializeComponent();
        }

        public class GetChoose
        {
            public static string id = "";
            public static int choose = 0;
        }

        string ma = "", ten = "", nhomsp = "", hangsp = "";
        int sLuong = 0;
        int i = 0;
        //, choose = 0;
        DataClasses1DataContext db = new DataClasses1DataContext();
        public void Uc_WareHouse_Load(object sender, EventArgs e)
        {
            cbbBrand.Enabled = false;
            hangsp = "";
            //var sssp = db.select_SP();
            //dgvSP.DataSource = sssp;
            GetChoose.id = "";
            fpnlGroupSP.Controls.Clear();
            foreach(var item in db.nhomSPs)
            {
                Button btn = new Button();
                btn.Height = 50;
                btn.Width = 120;
                btn.Text = item.tenLoai;
                btn.BackColor = Color.FromArgb(35, 200, 178);
                fpnlGroupSP.Controls.Add(btn);
                btn.Click += btn_Click;

            }
            
            cbbBrand.ValueMember = "maHang";
            cbbBrand.DisplayMember = "tenHang";
            cbbBrand.DataSource = db.HangSPs;
            cbbBrand.Text = "";
            int d = db.select_SP().Count() / 50;
            fpnl2.Controls.Clear();
            for (i=0; i <= d; i++)
            {
                GunaLinkLabel llb = new GunaLinkLabel();
                llb.AutoSize = true;
                llb.Text = i.ToString();
                llb.Click += llb_Click;
                fpnl2.Controls.Add(llb);
                
            }
            int dem = 0;
            fpnlProduct.Controls.Clear();
            var sp = db.select_SP();
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
                dem++;
                if (dem == 49)
                    break;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            nhomsp = btn.Text;
            hangsp = "";
            dgvSP.DataSource = db.SP_Filter_Group(nhomsp);
            fpnlProduct.Controls.Clear();

            cbbBrand.Enabled = true;
            
            var sp = from u in db.select_SP()
                         //where String.Compare(u.tenLoai, txtData.Text, true)==0
                     where u.tenLoai.ToUpper().Contains(nhomsp.ToUpper())
                     select u;
            
            int d = db.select_SP().Where(s => s.tenLoai.Equals(nhomsp)).Count() / 50;
            fpnl2.Controls.Clear();
            for (i = 0; i <= d; i++)
            {
                GunaLinkLabel llb = new GunaLinkLabel();
                llb.AutoSize = true;
                llb.Text = i.ToString();
                llb.Click += llb_Click;
                fpnl2.Controls.Add(llb);

            }
            int dem = 0;
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
                dem++;
                if (dem == 49)
                    break;
            }
        }

        private void llb_Click(object sender, EventArgs e)
        {
           
            GunaLinkLabel llb = sender as GunaLinkLabel;
            int dem = Convert.ToInt32(llb.Text);
            i = dem * 50;
            int max = i + 50;
            fpnlProduct.Controls.Clear();
            if (nhomsp == "")
            {
                for (int l = i; l < max; l++)
                {
                    if (l == db.select_SP().Count())
                    {
                        break;
                    }
                    else
                    {
                        ma = dgvSP.Rows[l].Cells[0].Value.ToString();
                        sanPham sp = db.sanPhams.Where(s => s.maSP.Equals(ma)).FirstOrDefault();
                        ten = dgvSP.Rows[l].Cells[1].Value.ToString();
                        sLuong = Convert.ToInt32(dgvSP.Rows[l].Cells[4].Value.ToString());
                        if (sp.anh == null)
                        {

                            // sLuong = Convert.ToInt32(gunaDataGridView1.Rows[i].Cells[4].Value.ToString());
                            Uc_ProductShow uc_Product = new Uc_ProductShow(ma, ten, null, sLuong);
                            fpnlProduct.Controls.Add(uc_Product);
                        }
                        else if (sp.anh != null)
                        {

                            MemoryStream stream = new MemoryStream(sp.anh.ToArray());
                            Uc_ProductShow uc_Product = new Uc_ProductShow(ma, ten, Image.FromStream(stream), sLuong);
                            fpnlProduct.Controls.Add(uc_Product);
                        }
                    }
                }
            }
            
            else if (hangsp != "" && nhomsp != "")
            {
                for (int l = i; l < max; l++)
                {
                    if (l == db.SP_Filter_Gr_Br(nhomsp, hangsp).Count())
                    {
                        break;
                    }

                    else
                    {
                        ma = dgvSP.Rows[l].Cells[0].Value.ToString();
                        sanPham sp = db.sanPhams.Where(s => s.maSP.Equals(ma)).FirstOrDefault();
                        ten = dgvSP.Rows[l].Cells[1].Value.ToString();
                        sLuong = Convert.ToInt32(dgvSP.Rows[l].Cells[4].Value.ToString());
                        if (sp.anh == null)
                        {

                            // sLuong = Convert.ToInt32(gunaDataGridView1.Rows[i].Cells[4].Value.ToString());
                            Uc_ProductShow uc_Product = new Uc_ProductShow(ma, ten, null, sLuong);
                            fpnlProduct.Controls.Add(uc_Product);
                        }
                        else if (sp.anh != null)
                        {

                            MemoryStream stream = new MemoryStream(sp.anh.ToArray());
                            Uc_ProductShow uc_Product = new Uc_ProductShow(ma, ten, Image.FromStream(stream), sLuong);
                            fpnlProduct.Controls.Add(uc_Product);
                        }
                    }
                }
            }
            else if (hangsp != "")
            {
                for (int l = i; l < max; l++)
                {
                    if (l == db.SP_Filter_Brand(hangsp).Count())
                    {
                        break;
                    }
                    else
                    {
                        ma = dgvSP.Rows[l].Cells[0].Value.ToString();
                        sanPham sp = db.sanPhams.Where(s => s.maSP.Equals(ma)).FirstOrDefault();
                        ten = dgvSP.Rows[l].Cells[1].Value.ToString();
                        sLuong = Convert.ToInt32(dgvSP.Rows[l].Cells[4].Value.ToString());
                        if (sp.anh == null)
                        {

                            // sLuong = Convert.ToInt32(gunaDataGridView1.Rows[i].Cells[4].Value.ToString());
                            Uc_ProductShow uc_Product = new Uc_ProductShow(ma, ten, null, sLuong);
                            fpnlProduct.Controls.Add(uc_Product);
                        }
                        else if (sp.anh != null)
                        {

                            MemoryStream stream = new MemoryStream(sp.anh.ToArray());
                            Uc_ProductShow uc_Product = new Uc_ProductShow(ma, ten, Image.FromStream(stream), sLuong);
                            fpnlProduct.Controls.Add(uc_Product);
                        }
                    }
                }
            }
            else if (nhomsp != "")
            {
                for (int l = i; l < max; l++)
                {
                    if (l == db.SP_Filter_Group(nhomsp).Count())
                    {
                        break;
                    }
                    else
                    {
                        ma = dgvSP.Rows[l].Cells[0].Value.ToString();
                        sanPham sp = db.sanPhams.Where(s => s.maSP.Equals(ma)).FirstOrDefault();
                        ten = dgvSP.Rows[l].Cells[1].Value.ToString();
                        sLuong = Convert.ToInt32(dgvSP.Rows[l].Cells[4].Value.ToString());
                        if (sp.anh == null)
                        {

                            // sLuong = Convert.ToInt32(gunaDataGridView1.Rows[i].Cells[4].Value.ToString());
                            Uc_ProductShow uc_Product = new Uc_ProductShow(ma, ten, null, sLuong);
                            fpnlProduct.Controls.Add(uc_Product);
                        }
                        else if (sp.anh != null)
                        {

                            MemoryStream stream = new MemoryStream(sp.anh.ToArray());
                            Uc_ProductShow uc_Product = new Uc_ProductShow(ma, ten, Image.FromStream(stream), sLuong);
                            fpnlProduct.Controls.Add(uc_Product);
                        }
                    }
                }
            }
        }

        private void cbbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            hangsp = cbbBrand.Text;
            if (nhomsp == "")
                dgvSP.DataSource = db.select_SP();
            else if (nhomsp != "" && hangsp != "")
                dgvSP.DataSource = db.SP_Filter_Gr_Br(nhomsp, hangsp);
            if (hangsp != "")
                dgvSP.DataSource = db.SP_Filter_Brand(hangsp);


            var sp = from u in db.select_SP()
                     where u.tenLoai.ToUpper().Contains(nhomsp.ToUpper())
                     where u.tenHang.ToUpper().Contains(hangsp.ToUpper())
                     select u;
            
            int d = db.SP_Filter_Gr_Br(nhomsp, hangsp).Count() / 50;
            fpnl2.Controls.Clear();
            for (i = 0; i <= d; i++)
            {
                GunaLinkLabel llb = new GunaLinkLabel();
                llb.AutoSize = true;
                llb.Text = i.ToString();
                llb.Click += llb_Click;
                fpnl2.Controls.Add(llb);

            }
            int dem = 0;
            fpnlProduct.Controls.Clear();
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
                dem++;
                if (dem == 49)
                    break;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            fpnlProduct.Controls.Clear();
            fpnl2.Controls.Clear();
            Uc_WareHouse_Load(sender, e);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            hangsp = cbbBrand.Text;
            if (txtID.Text == "")
                MessageBox.Show("Not enter the id yet");
            else
            {
                int dem = 0;
                if (nhomsp=="" && hangsp == "")
                {
                    var sp = db.SP_Find_id(txtID.Text);
                    fpnlProduct.Controls.Clear();
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
                        dem++;
                        if (dem == 49)
                            break;
                    }
                }
                else if (nhomsp != "" && hangsp == "")
                {
                    var sp = db.SP_Find_id(txtID.Text).Where(s=>s.tenLoai.Equals(nhomsp));
                    fpnlProduct.Controls.Clear();
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
                        dem++;
                        if (dem == 49)
                            break;
                    }
                }
                else if (nhomsp != "" && hangsp != "")
                {
                    var sp = db.SP_Find_id(txtID.Text).Where(s => s.tenHang.Equals(hangsp));
                    fpnlProduct.Controls.Clear();
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
                        dem++;
                        if (dem == 49)
                            break;
                    }
                }


                fpnl2.Controls.Clear();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmProduct product = new frmProduct();
            GetChoose.choose = 1;
            product.ShowDialog();
            
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            btnImport.Visible = false;
            btnCancle.Visible = true;
            DateTime d = DateTime.Now;
            var phieuNhap = db.PhieuNhaps;
            if (phieuNhap.Count() == 0)
            {
                GetChoose.id = "PN000001";
                db.PN_Ins("PN000001", "nv2", d);
            }
            else if (phieuNhap.Count() > 0)
            {
                var pn = db.PhieuNhaps.OrderByDescending(s => s.maphieu).FirstOrDefault();
                int stt = Convert.ToInt32(pn.maphieu.Substring(2))+1;
                GetChoose.id = "";
                if (stt / 10 >= 100000)
                    GetChoose.id = "PN" + stt;
                else if (stt / 10 >= 1000 && stt / 10 < 10000)
                    GetChoose.id = "PN0" + stt;
                else if (stt / 10 >= 100 && stt / 10 < 1000)
                    GetChoose.id = "PN00" + stt;
                else if (stt / 10 >= 10 && stt / 10 < 100)
                    GetChoose.id = "PN000" + stt;
                else if (stt / 10 >= 1 && stt / 10 < 10)
                    GetChoose.id = "PN0000" + stt;
                else if (stt / 10 < 1)
                    GetChoose.id = "PN00000" + stt;
                db.PN_Ins(GetChoose.id, "nv2", d);
            }
        }

        

        private void btnCancle_Click(object sender, EventArgs e)
        {
            btnImport.Visible = true;
            btnCancle.Visible = false;
            MessageBox.Show(GetChoose.id);
            db.PN_Del(GetChoose.id);
        }
    }
}
