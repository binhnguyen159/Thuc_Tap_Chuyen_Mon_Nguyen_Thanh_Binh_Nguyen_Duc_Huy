using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DevExpress.XtraEditors.Filtering.Templates;

namespace QLCH.Uc
{
    public partial class UCShowProduct : UserControl
    {
        public class tranferIDBill
        {
            static public int cartID;
            static public String CusId;
        }
        public UCShowProduct()
        {
            InitializeComponent();
        }

        int i = 0;
        //int dem = 0;
        DataClasses1DataContext db = new DataClasses1DataContext();



        private void UCShowProduct_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = db.Product_select();

            lbMa.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            lbTenSP.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            sanPham sp = db.sanPhams.Where(s => s.maSP == lbMa.Text).FirstOrDefault();
            if (sp.thongSo == null)
            {
                txtThongSo.Text = "No infomations";
            }
            else
            {
                txtThongSo.Text = sp.thongSo.ToString();
            }
            lbQuantity.Text = sp.soLuong.ToString();
            if (Convert.ToInt32(lbQuantity.Text) == 0)
            {
                btnAddToCart.Enabled = false;
            }
            else
            {
                btnAddToCart.Enabled = true;
            }

            if (sp == null || sp.anh == null)
            { }
            else
            {
                MemoryStream img = new MemoryStream(sp.anh.ToArray());
                Image image = Image.FromStream(img);
                if (image == null) { return; }
                else
                {
                    pictureBox1.Image = image;
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }


            nhomSP loaiSP = db.nhomSPs.Where(s => s.maLoai == sp.maLoai).FirstOrDefault();
            lbTLSP.Text = loaiSP.tenLoai;
            lbGia.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            panelKH.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            lbMa.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();

            lbTenSP.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            lbGia.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();

            lbTLSP.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();

            sanPham sp = db.sanPhams.Where(s => s.maSP == lbMa.Text.Trim()).FirstOrDefault();
            if (sp.thongSo == null)
            {
                txtThongSo.Text = "No infomations";
            }
            else
            {
                txtThongSo.Text = sp.thongSo.ToString();

            }
            lbQuantity.Text = sp.soLuong.ToString();

            if (Convert.ToInt32(lbQuantity.Text) == 0)
            {
                btnAddToCart.Enabled = false;
            }
            else
            {
                btnAddToCart.Enabled = true;
            }
            if (sp == null || sp.anh == null)
            { }
            else
            {
                MemoryStream img = new MemoryStream(sp.anh.ToArray());
                Image image = Image.FromStream(img);
                if (image == null) { return; }
                else
                {
                    pictureBox1.Image = image;
                }
            }
        }
  

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {

<<<<<<< HEAD
           db.insert_cart(Convert.ToInt32(lbMaGio.Text), lbMa.Text, Convert.ToInt32(numericSoLuong.Value), Convert.ToDouble(lbGia.Text), Convert.ToDouble(Convert.ToInt32(numericSoLuong.Value) * Convert.ToDouble(lbGia.Text)));
=======
            //var id
            //db.insert_cart(,CusId, lbMa.Text, Convert.ToInt32(numericSoLuong.Value), Convert.ToDouble(lbGia.Text), Convert.ToDouble(Convert.ToInt32(numericSoLuong.Value) * Convert.ToDouble(lbGia.Text)));

            
            db.insert_cart(Convert.ToInt32(lbMaGio.Text), lbMa.Text, Convert.ToInt32(numericSoLuong.Value), Convert.ToDouble(lbGia.Text), Convert.ToDouble(Convert.ToInt32(numericSoLuong.Value) * Convert.ToDouble(lbGia.Text)));

>>>>>>> 7c6cf4bbd41294897e3ff613daa4ac03073772af
        }


        private void numericSoLuong_Click(object sender, EventArgs e)
        {
            //chưa xong
            sanPham sp = db.sanPhams.Where(s => s.maSP == lbMa.Text.Trim()).FirstOrDefault();


            lbQuantity.Text = (sp.soLuong - Convert.ToInt32(numericSoLuong.Value)).ToString();


        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {

            FrmCart frmCart = new FrmCart();
            frmCart.Show();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            panelKH.Visible = true;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = db.khachHang_search(txtCusName.Text);
        }
       
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtCusName.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            tranferIDBill.CusId = dataGridView2.Rows[i].Cells[0].Value.ToString();
            panelKH.Visible = false;
        }
   
        int dem;
        private void btnCreateCart_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            btnAddToCart.Visible = true;

             db.insert_gioHang(tranferIDBill.CusId);

            foreach (var a in db.GioHangs)
=======
            btnAddToCart.Enabled = true;
            hoadDonXuat ssp = db.hoadDonXuats.OrderByDescending(s => s.maHDX).FirstOrDefault();
            stt = Convert.ToInt32(ssp.maHDX.ToString().Trim().Substring(2)) + 1;
            if (stt / 10 >= 100000)
                id = "HDX" + stt;
            else if (stt / 10 >= 1000 && stt / 10 < 10000)
                id = "HDX0" + stt;
            else if (stt / 10 >= 100 && stt / 10 < 1000)
                id = "HDX00" + stt;
            else if (stt / 10 >= 10 && stt / 10 < 100)
                id = "HDX000" + stt;
            else if (stt / 10 >= 1 && stt / 10 < 10)
                id = "HDX0000" + stt;
            else if (stt / 10 < 1)
                id = "HDX00000" + stt;
            //chua xong
            //db.hdx_insert(id, "ma nv", CusId, 0, "Not Paid", DateTime.Now);

            //db.insert_gioHang(CusId);
            
            foreach(var a in db.GioHangs)
>>>>>>> 7c6cf4bbd41294897e3ff613daa4ac03073772af
            {
                dem = a.magio;
            }
            lbMaGio.Text = dem.ToString();
            tranferIDBill.cartID = Convert.ToInt32(lbMaGio.Text);
        }
        private void load_data_after_add_customer()
        {
            this.Visible = true;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAddCus addCus = new FrmAddCus(load_data_after_add_customer);
            addCus.Show();
        }
    }
}
