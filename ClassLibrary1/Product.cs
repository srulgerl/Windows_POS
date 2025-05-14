using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posLibrary
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int Productquantity { get; set; }
        public Category ProductCategory { get; set; }
        public int ProductDiscount { get; set; }
        public int Barcode { get; set; }
        public Product(int id, string name, decimal price,int quantity, int discount, Category category, int barcode)
        {
            ProductId = id;
            ProductName = name;
            ProductPrice = price;
            Productquantity = quantity;
            ProductCategory = category;
            ProductDiscount = discount;
            Barcode = barcode;
        }


    }
}
