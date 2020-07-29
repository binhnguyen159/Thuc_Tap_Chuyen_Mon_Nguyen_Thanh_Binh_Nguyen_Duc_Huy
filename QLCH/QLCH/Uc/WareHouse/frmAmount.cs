using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH.Uc.WareHouse
{
    public partial class frmAmount : Form
    {
        public frmAmount()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        public class GetData
        {
            public static int sL = 0;
            public static double gia = 0;
        }
        private void frmAmount_Load(object sender, EventArgs e)
        {
            gunaLabel1.Text = "Enter the infor to import product";
            //if (Uc_WareHouse.GetData.choose == 3)
            //{
            //    this.Height = 122;
            //    nmrAmount.Visible = true;
            //    label1.Visible = false;
            //    label2.Visible = false;
            //    txtSeri.Visible = false;
            //    txtColor.Visible = false;
            //    dgvCTSP.Visible = false;
            //    gunaLabel1.Text = "Enter the amount of product";
            //}
            //else
            //{
            //    this.Height = 360;
            //    label1.Visible = true;
            //    label2.Visible = true;
            //    nmrAmount.Visible = false;
            //    txtSeri.Visible = true;
            //    txtColor.Visible = true;
            //    dgvCTSP.Visible = true;
            //    gunaLabel1.Text = "Add new in product";
            //}
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (nmrAmount.Value == 0 || txtGia.Text == "")
                MessageBox.Show("Please fill all information");
            else
            {
                GetData.sL = Convert.ToInt32(nmrAmount.Value);
                GetData.gia = Convert.ToDouble(txtGia.Text);
                this.Close();
            }
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            
            GetData.sL = 0;
            this.Close();

        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
