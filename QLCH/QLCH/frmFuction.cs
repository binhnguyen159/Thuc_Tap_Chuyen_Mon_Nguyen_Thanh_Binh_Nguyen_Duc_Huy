using QLCH.Uc;
using QLCH.Uc.WareHouse;
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
    public partial class frmFuction : Form
    {
        public frmFuction()
        {
            InitializeComponent();
            customPanelBill();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void ptbBack_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.ShowDialog();
        }

        private void ptbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void customPanelBill()
        {
            panelSubMenu.Visible = false;
        }
        private void hideSubPanel()
        {
            if (panelSubMenu.Visible == true)
            {
                panelSubMenu.Visible = false;
            }
        }
        private void showSubPanel(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubPanel();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }



        //Boolean bill = false;
        private void btnBill_Click(object sender, EventArgs e)
        {
            //bill = !bill;
            //if (bill == true)
            //{
            //    btnBuy.Location = new Point(22, btnBill.Location.Y + btnBill.Height + 4);
            //    btnSell.Location = new Point(22, btnBuy.Location.Y + btnBuy.Height + 4);
            //    btnStatistical.Location = new Point(5, btnSell.Location.Y + btnSell.Height + 4);
            //    btnBuy.Visible = true;
            //    btnSell.Visible = true;
            //}
            //else
            //{
            //    btnBuy.Visible = false;
            //    btnSell.Visible = false;
            //    btnStatistical.Location = new Point(5, btnBill.Location.Y + btnBill.Height + 4);
            //}
            showSubPanel(panelSubMenu);
        }

        private void btnEngineer_Click(object sender, EventArgs e)
        {
            Uc_Employees employees = new Uc_Employees();
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(employees);
            employees.Show();
        }

        private void btnProvider_Click(object sender, EventArgs e)
        {
            Uc_QLSP uCProvider = new Uc_QLSP();
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(uCProvider);
            //uCProvider.Show();
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            Uc_DanhMuc danhmuc = new Uc_DanhMuc();
            pnlContent.Controls.Add(danhmuc);
            danhmuc.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            //Uc_WareHouse products = new Uc_WareHouse();
            //pnlContent.Controls.Clear();
            //pnlContent.Controls.Add(products);
        }

        private void frmFuction_Load(object sender, EventArgs e)
        {
            nhanVien nv = db.nhanViens.Where(s => s.maNV == frmLogin.GetID.id).FirstOrDefault();
            lbName.Text = nv.tenNV.ToString();
            if (nv.maCV == "cv3")
            {
                btnSaleProduct.Visible = false;
            }
            else if (nv.maCV == "cv2")
            {
                btnProduct.Visible = false;
               
            }
            else
            {
                btnSaleProduct.Visible = true;
                btnProduct.Visible = true;
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            Uc_Bill_Buy bill_Buy = new Uc_Bill_Buy();
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(bill_Buy);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FormThongKe thongKe = new FormThongKe();
            pnlContent.Controls.Clear();
            thongKe.TopLevel = false;
            thongKe.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(thongKe);
            thongKe.Show();
        }

        private void btnSaleProduct_Click(object sender, EventArgs e)
        {
            UCShowProduct product = new UCShowProduct();
            pnlContent.Controls.Clear();
            product.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(product);
            product.Show();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            UcBill_Sell sell = new UcBill_Sell();
            pnlContent.Controls.Clear();
            sell.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(sell);
            sell.Show();
        }

        private void btnGuarantee_Click(object sender, EventArgs e)
        {
            UC_Guarantee guarantee = new UC_Guarantee();
            pnlContent.Controls.Clear();
            guarantee.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(guarantee);
            guarantee.Show();
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
