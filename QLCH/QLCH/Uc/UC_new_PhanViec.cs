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
    public partial class UC_new_PhanViec : UserControl
    {
        public UC_new_PhanViec()
        {
            InitializeComponent();
        }
        DataClasses1DataContext db = new DataClasses1DataContext();
        private void btnSet_Click(object sender, EventArgs e)
        {
            db.PV_Ins_Up(txtID.Text, cbbJob.SelectedValue.ToString());
            UC_new_PhanViec_Load(sender, e);
        }

        private void UC_new_PhanViec_Load(object sender, EventArgs e)
        {
            cbbJob.Text = "";
            dgvPhanViec.AutoGenerateColumns = false;
            dgvPhanViec.DataSource = db.PV_Sel();
            cbbJob.ValueMember = "maCV";
            cbbJob.DisplayMember = "tenCV";
            cbbJob.DataSource = db.congViecs;
        }

        private void dgvPhanViec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = dgvPhanViec.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (dgvPhanViec.Rows[e.RowIndex].Cells[2].Value != null)
                    cbbJob.Text = dgvPhanViec.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
    }
}
