using pos;

namespace posLibrary
{
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; } = 0;
        public decimal TotalPrice => Quantity * Product.ProductPrice;

        public CartItem(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }

        public void IncreaseQuantity()
        {
            Quantity++;
        }

        public void DecreaseQuantity()
        {
            if (Quantity > 0)
            {
                Quantity--;
            }
          
          
        }
      
    }
}