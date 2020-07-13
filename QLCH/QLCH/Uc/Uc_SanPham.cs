﻿using System;
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
using QLCH.Uc.WareHouse;

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

            txtMaSP.Enabled = false;
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            choose = 1;
            
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            cbbTimKiem.Enabled = true;
            btnTimKiem.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            //gunaGroupBox1.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            choose = 2;
            txtMaSP.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            cbbTimKiem.Enabled = true;
            btnTimKiem.Enabled = true;
            btnDelete.Enabled = false;
            btnAdd.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            choose = 3;
            txtMaSP.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            cbbTimKiem.Enabled = true;
            btnTimKiem.Enabled = true;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var sp = from u in db.sanPhams select u;
            switch (choose)
            {
                case 1:
                    {
                        if (txtTenSP.Text == "" || txtGia.Text == "")
                            MessageBox.Show("Please fill all information");
                        else
                        {
                            MemoryStream stream = new MemoryStream();
                            pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
                            if (sp.Count() == 0)
                            {
                                db.addSP("SP000001", txtTenSP.Text, Convert.ToDouble(txtGia.Text), stream.ToArray(), 0, null,cbbType.SelectedValue.ToString(), cbbBrand.SelectedValue.ToString());
                            }
                            else
                            {
                                sanPham sssp = db.sanPhams.Where(s=>s.tenSP.Equals(txtTenSP.Text)).FirstOrDefault();
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
                                }
                                
                            }
                            Uc_SanPham_Load(sender, e);
                        }
                        break;
                    }
                case 2:
                    {
                        if (txtMaSP.Text == "" || txtTenSP.Text == "" || txtGia.Text == "" || rtxtParameter.Text == "")
                            MessageBox.Show("Please fill all information");
                        else
                        {
                            sanPham sssp = db.sanPhams.Where(s => s.tenSP.Equals(txtTenSP.Text)).FirstOrDefault();
                            if (sssp != null)
                                MessageBox.Show("Already have this name");
                            else
                            {
                                MemoryStream stream = new MemoryStream();
                                pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
                                db.updateSP(txtMaSP.Text, txtTenSP.Text, Convert.ToDouble(txtGia.Text), stream.ToArray(),
                                        rtxtParameter.Text, cbbType.SelectedValue.ToString(), cbbBrand.SelectedValue.ToString());

                                Uc_SanPham_Load(sender, e);
                            }
                        }
                        break;
                    }
                case 3:
                    {
                        if (txtMaSP.Text == "")
                            MessageBox.Show("Enter the id to delete product that you want");
                        else
                        {
                            db.deleteSP(txtMaSP.Text);
                            Uc_SanPham_Load(sender, e);
                        }
                        break;
                    }
            }
            //if (choose == 3)
            //{
            //    db.deleteSP(txtMaSP.Text);
            //    Uc_SanPham_Load(sender, e);
            //}
            //else
            //{
            //    if (txtTenSP.Text == "" || txtGia.Text == "")
            //    {
            //        MessageBox.Show("Please fill all the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        txtTenSP.Focus();
            //    }
            //    else
            //    {

            //        switch (choose)
            //        {
            //            case 1:
            //                {
            //                    MemoryStream stream = new MemoryStream();
            //                    pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
            //                    if (sp.Count() == 0)
            //                    {
            //                        //db.addSP("SP000001", txtTenSP.Text, Convert.ToDouble(txtGia.Text), stream.ToArray(), 0, null, cbbType.SelectedValue.ToString(), cbbBrand.SelectedValue.ToString());
            //                        db.addSP("SP000001", txtTenSP.Text, Convert.ToDouble(txtGia.Text), stream.ToArray(), 0, null, null, null);
            //                    }
            //                    else
            //                    {


            //                        //for (int i = 0; i < 1001; i++)
            //                        //{
            //                        //    sanPham ssp = db.sanPhams.OrderByDescending(s => s.maSP).FirstOrDefault();
            //                        //    stt = Convert.ToInt32(ssp.maSP.ToString().Trim().Substring(2)) + 1;
            //                        //    if (stt / 10 >= 100000)
            //                        //        id = "SP" + stt;
            //                        //    else if (stt / 10 >= 1000 && stt / 10 < 10000)
            //                        //        id = "SP0" + stt;
            //                        //    else if (stt / 10 >= 100 && stt / 10 < 1000)
            //                        //        id = "SP00" + stt;
            //                        //    else if (stt / 10 >= 10 && stt / 10 < 100)
            //                        //        id = "SP000" + stt;
            //                        //    else if (stt / 10 >= 1 && stt / 10 < 10)
            //                        //        id = "SP0000" + stt;
            //                        //    else if (stt / 10 < 1)
            //                        //        id = "SP00000" + stt;
            //                        //    db.addSP(id, txtTenSP.Text, Convert.ToDouble(txtGia.Text), null, 0, null, cbbType.SelectedValue.ToString(), cbbBrand.SelectedValue.ToString());

            //                        //}
            //                        sanPham ssp = db.sanPhams.OrderByDescending(s => s.maSP).FirstOrDefault();
            //                        stt = Convert.ToInt32(ssp.maSP.ToString().Trim().Substring(2)) + 1;
            //                        if (stt / 10 >= 100000)
            //                            id = "SP" + stt;
            //                        else if (stt / 10 >= 1000 && stt / 10 < 10000)
            //                            id = "SP0" + stt;
            //                        else if (stt / 10 >= 100 && stt / 10 < 1000)
            //                            id = "SP00" + stt;
            //                        else if (stt / 10 >= 10 && stt / 10 < 100)
            //                            id = "SP000" + stt;
            //                        else if (stt / 10 >= 1 && stt / 10 < 10)
            //                            id = "SP0000" + stt;
            //                        else if (stt / 10 < 1)
            //                            id = "SP00000" + stt;
            //                        //db.addSP(id, txtTenSP.Text, Convert.ToDouble(txtGia.Text), stream.ToArray(), 0, null, cbbType.SelectedValue.ToString(), cbbBrand.SelectedValue.ToString());

            //                    }
            //                    Uc_SanPham_Load(sender, e);
            //                    break;
            //                }
            //            case 2:
            //                {

            //                    if (pictureBox1.Image == null)
            //                    {
            //                        db.updateSP(txtMaSP.Text, txtTenSP.Text, Convert.ToDouble(txtGia.Text), null, cbbType.SelectedValue.ToString(), cbbBrand.SelectedValue.ToString());

            //                    }
            //                    else
            //                    {
            //                        MemoryStream stream = new MemoryStream();
            //                        pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
            //                        db.updateSP(txtMaSP.Text, txtTenSP.Text, Convert.ToDouble(txtGia.Text), stream.ToArray(), cbbType.SelectedValue.ToString(), cbbBrand.SelectedValue.ToString());
                                 

            //                    }
            //                    Uc_SanPham_Load(sender, e);

            //                    break;
            //                }
            //        }

            //    }
            //}


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
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

                var sp = db.sanPhams.Where(s => s.maSP == txtMaSP.Text).FirstOrDefault();
                if (sp.anh == null)

                    pictureBox1.Image = null;

                else
                {
                    MemoryStream stream = new MemoryStream(sp.anh.ToArray());
                    if (stream == null)
                        return;
                    else
                    {
                        pictureBox1.Image = Image.FromStream(stream);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                rtxtParameter.Text = sp.thongSo;
            }

        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
