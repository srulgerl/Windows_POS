using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using posLibrary;

namespace pos
{
    public class Cart
    {
        public List<CartItem> Items { get; private set; } = new List<CartItem>();

        public void AddCartItem(CartItem item)
        {
            var existing = Items.FirstOrDefault(i => i.Product.ProductId == item.Product.ProductId);
            
            var totalQuantity = item.Quantity + (existing?.Quantity ?? 0);

            if (totalQuantity > item.Product.Productquantity)
            {
                throw new InvalidOperationException($"'{item.Product.ProductName}' барааны үлдэгдэл хүрэлцэхгүй байна. Үлдэгдэл: {item.Product.Productquantity}");
            }

            if (existing != null)
            {
                existing.IncreaseQuantity();
                return;
            }
            Items.Add(item);
        }

        public void RemoveCartItem(int productId)
        {
            Items.RemoveAll(i => i.Product.ProductId == productId);
           
        }


        public decimal CalculateTotal()
        {
            return Items.Sum(i => i.TotalPrice);
        }

    }
}