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
    public partial class frmAssign : Form
    {
        public frmAssign()
        {
            InitializeComponent();
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {

        }

        private void btnAssign_Click(object sender, EventArgs e)
        {

        }

        private void frmAssign_Load(object sender, EventArgs e)
        {
            lbID.Text = Uc_Employees.GetMaNV.manv;
        }
    }
}
