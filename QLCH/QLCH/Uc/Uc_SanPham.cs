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
using System.Drawing.Imaging;

namespace QLCH.Uc
{
    public partial class Uc_SanPham : UserControl
    {
        public Uc_SanPham()
        {
            InitializeComponent();

        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        Bitmap bitmap;
        int choose;
        int stt = 0;
        string id = "";

        private void Uc_SanPham_Load(object sender, EventArgs e)
        {
            var nsp = from u in db.nhomSPs select u;

            var hsp = from u in db.HangSPs select u;

            cbbType.Text = "";
            txtTenSP.Text = "";
            txtGia.Text = "";
            

            cbbType.DisplayMember = "tenLoai";
            cbbType.ValueMember = "maLoai";
            cbbType.DataSource = nsp;

            cbbBrand.DisplayMember = "tenHang";
            cbbBrand.ValueMember = "maHang";
            cbbBrand.DataSource = hsp;

            dgvProduct.AutoGenerateColumns = false;
            dgvProduct.DataSource = db.select_SP();


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            choose = 1;
            txtTenSP.Enabled = true;
            txtGia.Enabled = true;
            panelSave_Delete.Visible = true;
            gunaGroupBox1.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            choose = 2;
            txtTenSP.Enabled = true;
            txtGia.Enabled = true;
            gunaGroupBox1.Visible = false;
            panelSave_Delete.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            choose = 3;
            gunaGroupBox1.Visible = false;
            panelSave_Delete.Visible = true;
            //DialogResult dialogResult = MessageBox.Show("Are you sure want to delete that Product ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (dialogResult == DialogResult.Yes)
            //{

            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
            var sp = from u in db.sanPhams select u;
            var nsp = from u in db.nhomSPs select u;
            var hsp = from u in db.HangSPs select u;
            if (txtTenSP.Text == "" || txtGia.Text == "")
            {
                MessageBox.Show("Please fill all the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenSP.Focus();
            }
            else
            {
                switch (choose)
                {
                    case 1:
                        {
                            if (sp.Count() == 0)
                            {
                                db.addSP("SP1", txtTenSP.Text, Convert.ToDouble(txtGia.Text), stream.ToArray(), 0, null, cbbType.SelectedValue.ToString(), cbbBrand.SelectedValue.ToString());
                            }
                            else
                            {
                                sanPham ssp = db.sanPhams.OrderByDescending(s => s.maSP).FirstOrDefault();

                                stt = Convert.ToInt32(ssp.maSP.ToString().Trim().Substring(2)) + 1;
                                id = "SP" + stt;
                                db.addSP(id, txtTenSP.Text, Convert.ToDouble(txtGia.Text), stream.ToArray(), 0, null, cbbType.SelectedValue.ToString(), cbbBrand.SelectedValue.ToString());
                            }
                            Uc_SanPham_Load(sender, e);

                            break;
                        }
                    case 2:
                        {

                            db.updateSP(txtMaSP.Text, txtTenSP.Text, Convert.ToDouble(txtGia.Text), stream.ToArray(), cbbType.SelectedValue.ToString(), cbbBrand.SelectedValue.ToString());
                            Uc_SanPham_Load(sender, e);

                            break;
                        }

                    case 3:
                        {
                            db.deleteSP(txtMaSP.Text);
                            Uc_SanPham_Load(sender, e);
                            break;
                        }
                }
            }
            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtTenSP.Enabled = false;
            txtGia.Enabled = false;
            panelSave_Delete.Visible = false;
            gunaGroupBox1.Visible = true;
            Uc_SanPham_Load(sender, e);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (open.ShowDialog() == DialogResult.OK)
            {
                bitmap = new Bitmap(open.FileName);
                pictureBox1.Image = bitmap;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Uc_SanPham_Load(sender, e);
        }
        int i = 0;
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            if (i >= 0)
            {
                txtMaSP.Text = dgvProduct.Rows[i].Cells[0].Value.ToString();
                txtTenSP.Text = dgvProduct.Rows[i].Cells[1].Value.ToString();
                txtGia.Text = dgvProduct.Rows[i].Cells[2].Value.ToString();
                cbbType.Text = dgvProduct.Rows[i].Cells[4].Value.ToString();
                cbbBrand.Text = dgvProduct.Rows[i].Cells[5].Value.ToString();

                var sp = db.select_SP().Where(s => s.maSP == txtMaSP.Text).FirstOrDefault();

                MemoryStream stream = new MemoryStream(sp.anh.ToArray());
                if (stream == null)
                    return;
                else
                {
                    pictureBox1.Image = Image.FromStream(stream);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }

        }

    }
}
