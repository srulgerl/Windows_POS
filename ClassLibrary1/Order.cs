using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace posLibrary
{
    public class Order
    {
        public int ProductId { get; }
        public string ProductName { get; }
        public decimal UnitPrice { get; }
        public int Quantity { get; }
        public decimal TotalPrice => UnitPrice * Quantity;

        public Order(int productId, string productName, decimal unitPrice, int quantity)
        {
            ProductId = productId;
            ProductName = productName;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }
    }
}
