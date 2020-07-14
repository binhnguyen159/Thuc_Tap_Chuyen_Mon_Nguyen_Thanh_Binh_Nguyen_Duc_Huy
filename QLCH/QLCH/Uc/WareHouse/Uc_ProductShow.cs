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
    public partial class Uc_ProductShow : UserControl
    {
        
        public Uc_ProductShow(string id, string name, Image image, int amount)
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
            if (amount < 5)
                pnlNoti.BaseColor = Color.Red;
            else
            {
                pnlNoti.BaseColor = Color.White;
            }
        }


        private void Uc_ProductShow_Load(object sender, EventArgs e)
        {

        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        private void btnRemove_Click(object sender, EventArgs e)
        {
            db.deleteSP(lbID.Text);
            lbID.Text = "!!!";
            lbName.Text = "!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!";
            lbSL.Text = "!!!";
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

        }

        private void Uc_ProductShow_Load_1(object sender, EventArgs e)
        {

        }

        //public Uc_ProductShow(string id, string name, Image image, string hang)
        //{
        //    InitializeComponent();
        //    lbID.Text = id;
        //    lbName.Text = name;
        //    ptbAnh.Image = image;
        //}

        //public Uc_ProductShow(string id, string name, string nhom, Image image)
        //{
        //    InitializeComponent();
        //    lbID.Text = id;
        //    lbName.Text = name;
        //    ptbAnh.Image = image;
        //}

    }
}
