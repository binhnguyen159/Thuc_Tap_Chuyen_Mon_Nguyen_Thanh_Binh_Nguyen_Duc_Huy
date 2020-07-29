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


        public void load()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = db.Product_select();
            numericSoLuong.Value = 0;
        }
        private void UCShowProduct_Load(object sender, EventArgs e)
        {
            btnSeeCart.Visible = false;
            btnAddToCart.Visible = false;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = db.Product_select();
            var ssp = from u in db.sanPhams select u;
            if (ssp.Count() == 0)
            {
                return;
            }
            else
            {
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
                var spp = db.Product_select().Where(s => s.maSP == lbMa.Text).FirstOrDefault();
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



        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            lbMa.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();


            lbTenSP.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            lbGia.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();

            lbTLSP.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            //MessageBox.Show(lbMa.Text + "\n" + lbTenSP.Text + "\n" + lbGia.Text + "\n" + lbTLSP.Text);
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
            numericSoLuong.Value = 0;
        }


        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lbMa.Text + "\n" + lbTenSP.Text + "\n" + lbGia.Text + "\n" + numericSoLuong.Value.ToString());
            db.insert_cart(Convert.ToInt32(lbMaGio.Text), lbMa.Text, Convert.ToInt32(numericSoLuong.Value), Convert.ToDouble(lbGia.Text), Convert.ToDouble(Convert.ToInt32(numericSoLuong.Value) * Convert.ToDouble(lbGia.Text)));
            //db.update_soluong(lbMa.Text, Convert.ToInt32(lbQuantity.Text));
            //UCShowProduct_Load(sender, e);
        }


        private void numericSoLuong_Click(object sender, EventArgs e)
        {
            sanPham sp = db.sanPhams.Where(s => s.maSP == lbMa.Text.Trim()).FirstOrDefault();

            if (Convert.ToInt32(lbQuantity.Text) > 0)
            {
                lbQuantity.Text = (sp.soLuong - Convert.ToInt32(numericSoLuong.Value)).ToString();
                //db.update_soluong(lbMa.Text, Convert.ToInt32(lbQuantity.Text));
            }
            else
            {
                numericSoLuong.Value = (int)sp.soLuong;
            }

        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            FrmCart frmCart = new FrmCart();
            frmCart.ShowDialog();
            if (FrmCart.signal.sign == 1)
            {
                load();
                UCShowProduct_Load(sender, e);
            }
                
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            panelKH.Visible = true;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = db.khachHang_search(txtCusName.Text);

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                btnCreateCart.Visible = true;
                tranferIDBill.CusId = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCusName.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                btnCreateCart.Visible = true;
                panelKH.Visible = false;
            }
            // đợi xíuok :))
        }

        int dem;
        private void btnCreateCart_Click(object sender, EventArgs e)
        {
            btnAddToCart.Visible = true;
            btnSeeCart.Visible = true;// nó ẩn sẵn rồi mà, lúc m tạo giỏ cho nó hiện ra để xem chứ
            // ngta thanh toán thì ẩn nó đi tiếp cho lần tạo giỏ tiếp theo mới hiện ra
            // để t chạy thử đã

            db.insert_gioHang(tranferIDBill.CusId);

            foreach (var a in db.GioHangs)
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
            //this.Hide()
            FrmAddCus addCus = new FrmAddCus(load_data_after_add_customer);
            addCus.Show();
        }
    }
}
