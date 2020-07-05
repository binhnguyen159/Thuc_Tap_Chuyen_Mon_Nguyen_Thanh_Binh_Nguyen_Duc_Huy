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
    public partial class Uc_Products : UserControl
    {
        public Uc_Products()
        {
            InitializeComponent();
        }

        

        DataClasses1DataContext db = new DataClasses1DataContext();
        Bitmap bitmap;
        int ma;
        int dem = 0;
        int choose;
        string id = "";
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            choose = 1;
            txtTenSP.Enabled = true;
            txtGia.Enabled = true;
            panelSave_Delete.Visible = true;
            gunaGroupBox1.Visible = false;
            sanPham sp = new sanPham();
            if (sp == null)
            {
                ma = 1;
            }
            else
            {
                foreach (var a in db.sanPhams)
                {
                    dem++;
                }
                ma = dem + 1;
                //label1.Text = ma.ToString();
                id = ma.ToString();
                dem = 0;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            choose = 2;
            gunaGroupBox1.Visible = false;
            panelSave_Delete.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to delete that Product ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                db.deleteSP(id);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
            var nsp = from u in db.nhomSPs select u;
            var hsp = from u in db.HangSPs select u;
            if (choose == 1)
            {
                if (txtTenSP.Text == "" || txtGia.Text == "")
                {
                    MessageBox.Show("Please fill all the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenSP.Focus();
                }
                else
                {
                    nhomSP sp = db.nhomSPs.OrderByDescending(s=>s.maLoai).FirstOrDefault();
                    if (nsp.Count() == 0)
                    {
                        nhomSP nsp_Add = new nhomSP();
                        nsp_Add.maLoai = "Nhom1";
                        nsp_Add.tenLoai = cbbType.Text;
                        db.nhomSPs.InsertOnSubmit(nsp_Add);
                        db.SubmitChanges();
                    }
                    else if(nsp.Count() >= 1)
                    {
                        string str = sp.maLoai.ToString().Trim().Substring(4);
                        db.addSP("SP" + id, txtTenSP.Text, Convert.ToDouble(txtGia.Text), stream.ToArray(), 0, null, cbbType.SelectedValue.ToString(), cbbBrand.SelectedValue.ToString());
                        Uc_Products_Load(sender, e);
                    }
                    
                    
                }
            }
            if (choose == 2)
            {
                if (txtTenSP.Text == "" || txtGia.Text == "")
                {
                    MessageBox.Show("Please fill all the information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenSP.Focus();
                }
                else
                {
                    //db.updateSP(id, txtTenSP.Text, Convert.ToDouble(txtGia.Text), stream.ToArray(), cbbType.SelectedValue.ToString(), cbbBrand.SelectedValue.ToString());
                    Uc_Products_Load(sender, e);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelSave_Delete.Visible = false;
            gunaGroupBox1.Visible = true;
            Uc_Products_Load(sender, e);
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
            Uc_Products_Load(sender, e);
        }

        private void Uc_Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loaiSP.nhomSP' table. You can move, or remove it, as needed.
            //this.nhomSPTableAdapter.Fill(this.loaiSP.nhomSP);
            //// TODO: This line of code loads data into the 'loaiSP.nhomSP' table. You can move, or remove it, as needed.
            //this.nhomSPTableAdapter.Fill(this.loaiSP.nhomSP);

            var nsp = from u in db.nhomSPs select u;

            var hsp = from u in db.HangSPs select u;
                        
            cbbType.Text = "";
            txtTenSP.Text = "";
            txtGia.Text = "";
            txtTenSP.Enabled = false;
            txtGia.Enabled = false;
            //nhomSP nsp = db.nhomSPs();
            
            cbbType.DisplayMember = "tenLoai";
            cbbType.ValueMember = "maLoai";
            cbbType.DataSource = nsp;

            cbbBrand.DisplayMember = "tenHang";
            cbbBrand.ValueMember = "maHang";
            cbbBrand.DataSource = hsp;

            dgvProduct.AutoGenerateColumns = false;
            dgvProduct.DataSource = db.select_SP();
            //btnUpdate.Visible = false;
            //btnDelete.Visible = false;
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int i = 0;
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            txtTenSP.Text = dgvProduct.Rows[i].Cells[1].Value.ToString();
            txtGia.Text = dgvProduct.Rows[i].Cells[2].Value.ToString();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
        }
    }
}
