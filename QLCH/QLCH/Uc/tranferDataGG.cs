using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace QLCH.Uc
{
    public class tranferDataGG
    {
        private String productId;
        private String productName;

        private double productDefaultPrice;
        private int productQuantity;
        private Image productImg;
        private int IDCartDetail;

        public tranferDataGG(string productId, string productName, double productDefaultPrice, int productQuantity, Image productImg, int iDCartDetail)
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.ProductDefaultPrice = productDefaultPrice;
            this.ProductQuantity = productQuantity;
            this.ProductImg = productImg;
            this.IDCartDetail1 = iDCartDetail;
        }

        public string ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public double ProductDefaultPrice { get => productDefaultPrice; set => productDefaultPrice = value; }
        public int ProductQuantity { get => productQuantity; set => productQuantity = value; }
        public Image ProductImg { get => productImg; set => productImg = value; }
        public int IDCartDetail1 { get => IDCartDetail; set => IDCartDetail = value; }
    }
}