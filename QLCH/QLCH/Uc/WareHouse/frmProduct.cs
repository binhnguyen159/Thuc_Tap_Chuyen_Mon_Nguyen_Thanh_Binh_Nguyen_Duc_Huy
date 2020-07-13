using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH.Uc.WareHouse
{
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void ptbExit_Click(object sender, EventArgs e)
        {
            Uc_WareHouse.GetChoose.choose = 0;
            Uc_WareHouse wareHouse = new Uc_WareHouse();
            wareHouse.Uc_WareHouse_Load(sender, e);
            this.Close();
            
        }
        int stt = 0;
        string id = "";
        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = ("(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif");
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(openFile.FileName);
                ptbAvatar.Image = bitmap;
            }
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            stt = 0;
            id = "";
            var nsp = from u in db.nhomSPs select u;
            cbbType.DisplayMember = "tenLoai";
            cbbType.ValueMember = "maLoai";
            cbbType.DataSource = nsp;

            var hsp = from u in db.HangSPs select u;
            cbbBrand.DisplayMember = "tenHang";
            cbbBrand.ValueMember = "maHang";
            cbbBrand.DataSource = hsp;
            switch (Uc_WareHouse.GetChoose.choose)
            {
                case 1:
                    lbTitle.Text = "Add new product";
                    break;
                case 2:
                    txtMaSP.Enabled = true;
                    txtTenSP.Enabled = false;
                    sanPham sp = db.sanPhams.Where(s => s.maSP.Equals(Uc_WareHouse.GetChoose.id)).FirstOrDefault();
                    txtMaSP.Text = sp.maSP;
                    txtTenSP.Text = sp.tenSP;
                    txtGia.Text = sp.gia.ToString();
                    rtxtParameter.Text = sp.thongSo;
                    MemoryStream stream = new MemoryStream(sp.anh.ToArray());
                    ptbAvatar.Image = Image.FromStream(stream);
                    lbTitle.Text = "Detail of product";
                    break;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (Uc_WareHouse.GetChoose.choose)
            {
                case 1:
                    {
                        if (txtTenSP.Text == "" || txtGia.Text == "")
                            MessageBox.Show("Please fill all information");
                        else
                        {
                            var sp = from u in db.sanPhams select u;
                            MemoryStream stream = new MemoryStream();
                            ptbAvatar.Image.Save(stream, ImageFormat.Jpeg);
                            if (sp.Count() == 0)
                            {
                                db.addSP("SP000001", txtTenSP.Text, Convert.ToDouble(txtGia.Text), stream.ToArray(), 0, null, cbbType.SelectedValue.ToString(), cbbBrand.SelectedValue.ToString());
                            }
                            else
                            {
                                sanPham sssp = db.sanPhams.Where(s => s.tenSP.Equals(txtTenSP.Text)).FirstOrDefault();
                                if (sssp != null)
                                    MessageBox.Show("Already have this name");
                                else
                                {
                                    
                                    sanPham ssp = db.sanPhams.OrderByDescending(s => s.maSP).FirstOrDefault();
                                    stt = Convert.ToInt32(ssp.maSP.ToString().Trim().Substring(2)) + 1;
                                    if (stt / 10 >= 100000)
                                        id = "SP" + stt;
                                    else if (stt / 10 >= 1000 && stt / 10 < 10000)
                                        id = "SP0" + stt;
                                    else if (stt / 10 >= 100 && stt / 10 < 1000)
                                        id = "SP00" + stt;
                                    else if (stt / 10 >= 10 && stt / 10 < 100)
                                        id = "SP000" + stt;
                                    else if (stt / 10 >= 1 && stt / 10 < 10)
                                        id = "SP0000" + stt;
                                    else if (stt / 10 < 1)
                                        id = "SP00000" + stt;
                                    db.addSP(id, txtTenSP.Text, Convert.ToDouble(txtGia.Text), stream.ToArray(), 0, rtxtParameter.Text, cbbType.SelectedValue.ToString(), cbbBrand.SelectedValue.ToString());
                                    Uc_WareHouse wareHouse = new Uc_WareHouse();
                                    wareHouse.Uc_WareHouse_Load(sender, e);
                                    MessageBox.Show("Add successfull");
                                }
                                
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        if (txtMaSP.Text == "" || txtTenSP.Text == "" || txtGia.Text == "" || rtxtParameter.Text == "")
                            MessageBox.Show("Please fill all information");
                        else
                        {

                            MemoryStream stream = new MemoryStream();
                            ptbAvatar.Image.Save(stream, ImageFormat.Jpeg);
                            db.updateSP(txtMaSP.Text, txtTenSP.Text, Convert.ToDouble(txtGia.Text), stream.ToArray(),
                                    rtxtParameter.Text, cbbType.SelectedValue.ToString(), cbbBrand.SelectedValue.ToString());

                        }
                        break;
                    }
            }
        }
    }
}
