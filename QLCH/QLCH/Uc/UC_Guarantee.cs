using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.XtraLayout.Filtering.Templates;
using DevExpress.DataProcessing.InMemoryDataProcessor.GraphGenerator;

namespace QLCH.Uc
{
    public partial class UC_Guarantee : UserControl
    {
        public UC_Guarantee()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            dataGridView2.Visible = true;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = db.bill_search(txtSearch.Text);
        }

        private void UC_Guarantee_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = db.Guarantee_info();
            cbSP.DisplayMember = "tenSP";
            cbSP.ValueMember = "maSP";

        }
        String maHd;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtBillID.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCusName.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            maHd = txtBillID.Text;
            cbSP.DataSource = db.search_sp_by_bill(txtBillID.Text);
            dataGridView2.Visible = false;
        }
        int choose;
        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            choose = 1;
            cbSP.Enabled = true;
            rTxTInfo.Enabled = true;
            gunaGradientButton1.Enabled = false;
            gunaGradientButton2.Enabled = false;
        }
        int stt;
        String id;
        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            if (choose == 1)
            {
                var p = from u in db.phieuBaoHanhs select u;
                if (p.Count() == 0)
                {
                    if (dateTimePic.Value < DateTime.Now)
                    {
                        MessageBox.Show("Please select Expired day again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (cbSP.SelectedValue == null)
                        {
                            MessageBox.Show("Please select product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            db.phieuBaoHanh_insert("pBH000001", cbSP.SelectedValue.ToString(), DateTime.Now, dateTimePic.Value, "Pending", rTxTInfo.Text);

                        }

                    }
                }
                else
                {
                    phieuBaoHanh pBH = db.phieuBaoHanhs.OrderByDescending(s => s.maPhieu).FirstOrDefault();
                    stt = Convert.ToInt32(pBH.maPhieu.ToString().Trim().Substring(3)) + 1;
                    if (stt / 10 >= 100000)
                        id = "pBH" + stt;
                    else if (stt / 10 >= 1000 && stt / 10 < 10000)
                        id = "pBH0" + stt;
                    else if (stt / 10 >= 100 && stt / 10 < 1000)
                        id = "pBH00" + stt;
                    else if (stt / 10 >= 10 && stt / 10 < 100)
                        id = "pBH000" + stt;
                    else if (stt / 10 >= 1 && stt / 10 < 10)
                        id = "pBH0000" + stt;
                    else if (stt / 10 < 1)
                        id = "pBH00000" + stt;

                    if (dateTimePic.Value < DateTime.Now)
                    {
                        MessageBox.Show("Please select Expired day again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        db.phieuBaoHanh_insert(id, cbSP.SelectedValue.ToString(), DateTime.Now, dateTimePic.Value, "Pending", rTxTInfo.Text);
                    }
                }
            }
            if (choose == 2)
            {
                if (dateTimePic.Value < DateTime.Now)
                {
                    MessageBox.Show("Please select Expired day again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    db.phieuBaoHanh_insert(id, cbSP.SelectedValue.ToString(), DateTime.Now, dateTimePic.Value, "Pending", rTxTInfo.Text);

                }
            }
        }
        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            choose = 2;
            gunaGradientButton1.Enabled = false;
            gunaGradientButton2.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lbmaP.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtBillID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCusName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            cbSP.DataSource = db.search_sp_by_bill(txtBillID.Text);
        }

        private void gunaGradientButton4_Click(object sender, EventArgs e)
        {
            gunaGradientButton1.Enabled = true;
            gunaGradientButton2.Enabled = true;
            UC_Guarantee_Load(sender, e);
            dataGridView2.Visible = false;
        }

        private void dataGridView2_MouseLeave(object sender, EventArgs e)
        {
            dataGridView2.Visible = false;
        }
    }
}
