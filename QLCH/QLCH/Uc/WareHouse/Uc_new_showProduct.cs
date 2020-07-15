using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace QLCH.Uc.WareHouse
{
    public partial class Uc_new_showProduct : UserControl
    {
        public Uc_new_showProduct(string id, string name, Image image, int amount)
        {
            InitializeComponent();
            lbID.Text = id;
            lbName.Text = name;
            if (image == null)
            {
                MemoryStream stream = new MemoryStream();
                ptbAnh.Image.Save(stream, ImageFormat.Jpeg);

            }
            else
            {
                ptbAnh.Image = image;
            }

            lbSL.Text = amount.ToString();
        }

        private void Uc_new_showProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }
    }
}
