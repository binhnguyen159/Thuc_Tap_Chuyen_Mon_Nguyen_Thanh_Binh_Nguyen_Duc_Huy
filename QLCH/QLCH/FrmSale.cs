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
        GunaButton button;
        private void btnProduct_Click(object sender, EventArgs e)
        {
            //foreach (var a in db.nhomSPs)
            //{
            //    button = new GunaButton();
            //    button.Height = 35;
            //    button.Text = a.tenLoai.ToString();
            //    flowLayoutPanel1.Controls.Add(button);
            //}
            UCShowProduct uCShowProduct = new UCShowProduct();
            panelShowSP.Controls.Add(uCShowProduct);
            uCShowProduct.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            UCCart uCCart = new UCCart();
            panelShowSP.Controls.Clear();
            panelShowSP.Controls.Add(uCCart);
            uCCart.Show();
        }
    }
}
