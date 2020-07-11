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

namespace QLCH.Uc
{
    public partial class UCShowProduct : UserControl
    {
       
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
            dataGridView1.DataSource = db.select_SP();
            lbMa.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            lbTenSP.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            sanPham sp = db.sanPhams.Where(s => s.maSP == lbMa.Text).FirstOrDefault();
            txtThongSo.Text = sp.thongSo.ToString();
            lbQuantity.Text = sp.soLuong.ToString();
            if (Convert.ToInt32(lbQuantity.Text) == 0)
            {
                gunaGradientButton1.Enabled = false;
            }
            else
            {
                gunaGradientButton1.Enabled = true;
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
            //cbloaisp.
            sanPham sp = db.sanPhams.Where(s => s.maSP == lbMa.Text.Trim()).FirstOrDefault();
            txtThongSo.Text = sp.thongSo.ToString();
            lbQuantity.Text = sp.soLuong.ToString();

            if (Convert.ToInt32(lbQuantity.Text) == 0)
            {
                gunaGradientButton1.Enabled = false;
            }
            else
            {
                gunaGradientButton1.Enabled = true;
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
        String CusId;

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            // làm cái mã giùm t với ,dđm, cái mã bên giỏ hàng ,t ự tăng, có code r mà, nhìn mà làm 3, ko hiểu gì hết, what the fuck, ,:siỉ nhục code sạch vcl< CHƯA PULL VỀ
            //pull về di ba
            var id
            //db.insert_cart(,CusId, lbMa.Text, Convert.ToInt32(numericSoLuong.Value), Convert.ToDouble(lbGia.Text), Convert.ToDouble(Convert.ToInt32(numericSoLuong.Value) * Convert.ToDouble(lbGia.Text)));
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
            int i = dataGridView2.CurrentRow.Index;
            txtCusName.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
            CusId = dataGridView2.Rows[i].Cells[0].Value.ToString();
            panelKH.Visible = false;
        }
    }
}
