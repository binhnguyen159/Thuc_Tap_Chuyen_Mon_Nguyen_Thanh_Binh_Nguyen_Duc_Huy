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

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtBillID.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCusName.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            cbSP.DataSource = db.search_sp_by_bill(txtBillID.Text);
           
            dataGridView2.Visible = false;
        }
        int choose;
        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            choose = 1;
            txtBillID.Text = "";
            txtCusName.Text = "";
            rTxTInfo.Text = "";
        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
