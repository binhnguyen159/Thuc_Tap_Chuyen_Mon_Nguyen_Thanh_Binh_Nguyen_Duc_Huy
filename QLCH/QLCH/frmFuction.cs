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
    public partial class frmFuction : Form
    {
        public frmFuction()
        {
            InitializeComponent();
        }

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

        Boolean bill = false;
        private void btnBill_Click(object sender, EventArgs e)
        {
            bill = !bill;
            if (bill == true)
            {
                btnBuy.Location = new Point(22, btnBill.Location.Y + btnBill.Height + 4);
                btnSell.Location = new Point(22, btnBuy.Location.Y + btnBuy.Height + 4);
                btnReport.Location = new Point(5, btnSell.Location.Y + btnSell.Height + 4);
                btnBuy.Visible = true;
                btnSell.Visible = true;
            }
            else
            {
                btnBuy.Visible = false;
                btnSell.Visible = false;
                btnReport.Location = new Point(5, btnBill.Location.Y + btnBill.Height + 4);
            }
        }

        private void btnEngineer_Click(object sender, EventArgs e)
        {
            Uc_Employees employees = new Uc_Employees();
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(employees);
            employees.Show();
        }

<<<<<<< HEAD
        private void btnProvider_Click(object sender, EventArgs e)
        {
            UCProvider uCProvider = new UCProvider();
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(uCProvider);
            uCProvider.Show();
=======
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            Uc_Customer customer = new Uc_Customer();
            pnlContent.Controls.Add(customer);
            customer.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Uc_Products products = new Uc_Products();
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(products);
            products.Show();
>>>>>>> 46112605d9a90d3477e9a1c02785010c56ae5ceb
        }
    }
}
