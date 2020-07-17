using Guna.UI.WinForms;
using QLCH.Uc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH
{
    public partial class FrmSale : Form
    {
        public FrmSale()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        //GunaButton button;
        private void btnProduct_Click(object sender, EventArgs e)
        {
            //foreach (var a in db.nhomSPs)
            //{
            //    button = new GunaButton();
            //    button.Height = 35;
            //    button.Text = a.tenLoai.ToString();
            //    flowLayoutPanel1.Controls.Add(button);
            //}
            panelShowSP.Controls.Clear();
            UCShowProduct uCShowProduct = new UCShowProduct();
            panelShowSP.Controls.Add(uCShowProduct);
            uCShowProduct.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            FrmCart frmCart = new FrmCart();
            panelShowSP.Controls.Clear();
            frmCart.TopLevel = false;
            panelShowSP.Controls.Add(frmCart);
            frmCart.Show();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            UcBill_Sell ucBill_Sell = new UcBill_Sell();
            panelShowSP.Controls.Clear();
            ucBill_Sell.Dock = DockStyle.Fill;
            panelShowSP.Controls.Add(ucBill_Sell);
            ucBill_Sell.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Uc_new_ProductShow uc_New_Product = new Uc_new_ProductShow();
            panelShowSP.Controls.Clear();
            uc_New_Product.Dock = DockStyle.Fill;
            panelShowSP.Controls.Add(uc_New_Product);
            uc_New_Product.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            FormThongKe thongKe = new FormThongKe();
            panelShowSP.Controls.Clear();
            thongKe.TopLevel = false;
            thongKe.Dock = DockStyle.Fill;
            panelShowSP.Controls.Add(thongKe);
            thongKe.Show();
        }
    }
}
