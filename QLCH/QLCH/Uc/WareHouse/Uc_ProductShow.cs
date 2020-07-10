using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH.Uc.WareHouse
{
    public partial class Uc_ProductShow : UserControl
    {
        public Uc_ProductShow(string id, string name, Image image,int amount)
        {
            InitializeComponent();
            lbID.Text = id;
            lbName.Text = name;
            ptbAnh.Image = image;
            lbSL.Text = amount.ToString();
            if (amount < 5)
                pnlNoti.BaseColor = Color.Red;

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
