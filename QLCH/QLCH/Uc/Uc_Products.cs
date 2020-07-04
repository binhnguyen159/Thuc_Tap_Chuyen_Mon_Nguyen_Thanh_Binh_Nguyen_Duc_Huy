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
                label1.Text = ma.ToString();
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
                db.deleteSP(label1.Text);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            pictureBox1.Image.Save(stream, ImageFormat.Jpeg);
            if (choose == 1)
            {

                if (txtTenSP.Text == "" || txtGia.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên sản phẩm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenSP.Focus();
                }
                else
                {
                    db.addSP("sp" + label1.Text, txtTenSP.Text, Convert.ToDouble(txtGia.Text), stream.ToArray(), 0, null, cbbType.SelectedValue.ToString());
                    Uc_Products_Load(sender, e);
                }
            }
            if (choose == 2)
            {
                if (txtTenSP.Text == "" || txtGia.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập tên sản phẩm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenSP.Focus();
                }
                else
                {
                    db.updateSP(label1.Text, txtTenSP.Text, Convert.ToDouble(txtGia.Text), stream.ToArray(), cbbType.SelectedValue.ToString());
                    Uc_Products_Load(sender, e);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            panelSave_Delete.Visible = false;
            gunaGroupBox1.Visible = true;
            //Form1_Load(sender, e);
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

        private void Uc_Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loaiSP.nhomSP' table. You can move, or remove it, as needed.
            //this.nhomSPTableAdapter.Fill(this.loaiSP.nhomSP);
            //// TODO: This line of code loads data into the 'loaiSP.nhomSP' table. You can move, or remove it, as needed.
            //this.nhomSPTableAdapter.Fill(this.loaiSP.nhomSP);

            //comboBox1.Text = "";
            //txtTenSP.Text = "";
            //txtGia.Text = "";
            //txtTenSP.Enabled = false;
            //txtGia.Enabled = false;
            //comboBox1.DisplayMember = "tenLoai";
            //comboBox1.ValueMember = "maLoai";
            //comboBox1.DataSource = db.nhomSPs;
            //dataGridView1.AutoGenerateColumns = false;
            //dataGridView1.DataSource = db.select_SP();
            //btnUpdate.Visible = false;
            //btnDelete.Visible = false;
        }

    
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            label1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTenSP.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtGia.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            cbbType.SelectedValue = dataGridView1.Rows[i].Cells[4].Value.ToString();

            sanPham sp = db.sanPhams.Where(s => s.maSP == label1.Text).FirstOrDefault();
            if (sp == null || sp.anh == null)
            {

            }
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
            btnAdd.Enabled = false;
        }
    }
}
