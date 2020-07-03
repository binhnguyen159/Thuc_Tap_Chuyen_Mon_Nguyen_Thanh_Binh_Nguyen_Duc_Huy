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
    public partial class Uc_Employees : UserControl
    {
        public Uc_Employees()
        {
            InitializeComponent();
        }

        private void btnGetPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            
            if (open.ShowDialog() == DialogResult.OK)
                open.Filter = "Pictures files (*.jpg,*jpeg,*.jpe,*.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            ptbAvatar.Image = new Bitmap(open.FileName);
            ptbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
