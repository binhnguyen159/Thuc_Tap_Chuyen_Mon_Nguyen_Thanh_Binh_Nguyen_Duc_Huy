using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using DevExpress.Utils.Extensions;

namespace QLCH.Uc
{
    public partial class UCCart : UserControl
    {
        Panel pnlContain, pnlInfo, pnlContainNumber;
        PictureBox picProduct;
        Label lbDefaultPrice, lbPrice, lbNumber, lbProductName;
        GunaButton btnUp, btnDown;
        GunaImageButton btnDelete;
        public UCCart()
        {
            InitializeComponent();
        }

        private void UCCart_Load(object sender, EventArgs e)
        {


            // chưa sắp xếp thứ tự 
            for (int i = 0; i <= 10; i++)
            {
                //UCCartProduct uCCartProduct = new UCCartProduct();
                //uCCartProduct.Dock = DockStyle.Top;
                //panelProductList.Controls.Add(uCCartProduct);
                //uCCartProduct.Show();


                pnlContain = new Panel();
                pnlContain.Dock = DockStyle.Top;

                picProduct = new PictureBox();
                picProduct.Dock = DockStyle.Left;
                picProduct.Width = 126;
                pnlContain.Controls.Add(picProduct);

                pnlInfo = new Panel();
                pnlInfo.Dock = DockStyle.Fill;
                

                lbDefaultPrice = new Label();
                lbPrice = new Label();
                lbProductName = new Label();
                lbNumber = new Label();

                lbProductName.Text = "test";

                //Point point = new Point();
                //point.X = 6;
                //point.Y = 45;
                lbProductName.Location = new Point(6, 45);
                lbPrice.Text = "100";
                lbDefaultPrice.Text = "110";
                lbPrice.Text = lbDefaultPrice.Text;

                lbPrice.Location = new Point(302, 45);
                lbNumber.BorderStyle = BorderStyle.Fixed3D;
                lbNumber.Text = "1";// <-- ko dc thay doi

                pnlInfo.Controls.Add(lbProductName);
                pnlInfo.Controls.Add(lbPrice);
                pnlInfo.Controls.Add(lbDefaultPrice);


                btnUp = new GunaButton();
                btnDown = new GunaButton();
                btnDown.Text = "";
                btnUp.Text = "";
                btnUp.Image = Image.FromFile("D:/Thuc_Tap_Chuyen_Mon_Nguyen_Thanh_Binh_Nguyen_Duc_Huy/image/icons8-plus-math-60.png");
                btnDown.Image = Image.FromFile("D:/Thuc_Tap_Chuyen_Mon_Nguyen_Thanh_Binh_Nguyen_Duc_Huy/image/icons8-subtract-60.png");
                btnDown.Width = 35;
                btnDown.Height = 32;
                btnUp.Width = 35;
                btnUp.Height = 32;

                pnlContainNumber = new Panel();

                btnDown.Dock = DockStyle.Left;
                lbNumber.Dock = DockStyle.Left;
                btnDown.Dock = DockStyle.Left;
                pnlContainNumber.Controls.Add(btnDown);
                pnlContainNumber.Controls.Add(lbNumber);
                pnlContainNumber.Controls.Add(btnUp);

                pnlContainNumber.Location = new Point(142, 37);
                pnlInfo.Controls.Add(pnlContainNumber);

                btnDelete = new GunaImageButton();
                btnDelete.Image = Image.FromFile("D:/Thuc_Tap_Chuyen_Mon_Nguyen_Thanh_Binh_Nguyen_Duc_Huy/image/icons8-delete-60.png");
                btnDelete.Location = new Point(374, 37);

                pnlInfo.Controls.Add(btnDelete);

                pnlContain.Controls.Add(picProduct);
                pnlContain.Controls.Add(pnlInfo);

               
                panelProductList.Controls.Add(pnlContain);
                pnlContain.Show();



                //load anh len
                //if (i == null || i.HinhAnh == null)
                //{
                //    ptb.Image = null;
                //}
                //else
                //{
                //    MemoryStream img = new MemoryStream(i.HinhAnh.ToArray());
                //    Image image = Image.FromStream(img);
                //    if (i == null)
                //    {
                //        ptb.Image = null;
                //    }
                //    else
                //    {
                //        ptb.Image = image;
                //        lbMa.Text = i.MaSP.ToString();
                //        sp = net.SanPhams.Where(s => s.MaSP == Convert.ToInt32(lbMa.Text)).FirstOrDefault();
                //        TenSP = sp.TenSP;

                //    }
                //}
                //Load database cart
            }
        }
    }
}
