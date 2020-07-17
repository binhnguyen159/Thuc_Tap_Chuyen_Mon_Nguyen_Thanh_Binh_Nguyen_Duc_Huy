using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH.Uc
{
    public partial class FrmAddCus : Form
    {
        private Exit exit;
        public FrmAddCus()
        {
            InitializeComponent();
        }
        public FrmAddCus(Exit ex)
        {
            InitializeComponent();
            exit = ex;
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void FrmAddCus_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string gt = "";
            if (rdbMale.Checked)
                gt = "Nam";
            else
                gt = "Nữ";

            if (txtAddress.Text == "" || txtEmail.Text == "" || txtName.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Please fill all information");
            }
            else
            {
                int ma = 1;
                string id = "";
                var kh = from u in db.khachHangs select u;
                if (kh.Count() == 0)
                {
                    id = "KH" + ma;
                    db.KH_Ins(id, txtName.Text, gt, dtpBirthday.Value, txtEmail.Text, txtAddress.Text, txtPhone.Text); 
                    this.Close();
                    exit();
                }
                else if (kh.Count() > 0)
                {

                    kh.OrderByDescending(s => s.maKH).FirstOrDefault();
                    var kh2 = db.khachHangs.OrderByDescending(s => s.maKH).FirstOrDefault();
                    ma = Convert.ToInt32(kh2.maKH.ToString().Substring(2)) + 1;
                    id = "KH" + ma;
                    db.KH_Ins(id, txtName.Text, gt, dtpBirthday.Value, txtEmail.Text, txtAddress.Text, txtPhone.Text);
                    this.Close();
                    exit();
                }
            }
            
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            exit();
        }

        private void txtPhone_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}