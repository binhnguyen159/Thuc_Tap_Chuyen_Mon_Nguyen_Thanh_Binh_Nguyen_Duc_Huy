using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH.Uc
{
    public partial class Uc_DanhMuc : UserControl
    {
        public Uc_DanhMuc()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void tctDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            nhanVien nv = db.nhanViens.Where(s => s.maNV == frmLogin.GetID.id).FirstOrDefault();
            if (nv.maCV == "cv2")
            {
                pnlNhanVien.Visible = false;
                pnlKhachhang.Visible = false;
                pnlTaiKhoan.Visible = false;
                pnlNCC.Visible = true;
            }
            else if (nv.maCV == "cv3")
            {
                pnlNhanVien.Visible = false;
                pnlKhachhang.Visible = true;
                pnlTaiKhoan.Visible = false;
                pnlNCC.Visible = false;
            }
           
            switch (tctDanhMuc.SelectedIndex)
            {
                case 0:
                    {
                        pnlNhanVien.Controls.Clear();
                        Uc_Employees employees = new Uc_Employees();
                        pnlNhanVien.Controls.Add(employees);
                        break;
                    }
                case 1:
                    {
                        pnlKhachhang.Controls.Clear();
                        Uc_Customer customer = new Uc_Customer();
                        pnlKhachhang.Controls.Add(customer);
                        break;
                    }
                case 2:
                    {
                        pnlTaiKhoan.Controls.Clear();
                        Uc_TaiKhoan taiKhoan = new Uc_TaiKhoan();
                        pnlTaiKhoan.Controls.Add(taiKhoan);
                        break;;
                    }
                case 3:
                    {
                        pnlNCC.Controls.Clear();
                        Uc_NCC provider = new Uc_NCC();
                        pnlNCC.Controls.Add(provider);
                        break;
                    }
            }
            
        }
    }
}
