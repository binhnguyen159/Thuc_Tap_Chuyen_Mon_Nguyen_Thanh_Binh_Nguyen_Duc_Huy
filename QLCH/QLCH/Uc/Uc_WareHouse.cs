using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCH.Uc.WareHouse;

namespace QLCH.Uc
{
    public partial class Uc_WareHouse : UserControl
    {
        public Uc_WareHouse()
        {
            InitializeComponent();
        }

        DataClasses1DataContext db = new DataClasses1DataContext();

        private void Uc_WareHouse_Load(object sender, EventArgs e)
        {
            fpnlProduct.Controls.Clear();
            var sp = db.sanPhams;
            foreach(sanPham item in db.sanPhams)
            {
                Uc_ProductShow uc_Product = new Uc_ProductShow();
                
            }
        }
    }
}
