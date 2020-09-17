using System.Collections.Generic;

namespace SupermarketPricing
{
    public class Checkout
    {
        public List<Product> Products { get; }

        public Checkout()
        {
            this.Products = new List<Product>();
        }

        public decimal CalculateNetTotal()
        {
            decimal total = 0;
            foreach(Product product in Products)
            {
                if (product != null)
                {
                    if (product.Quantity > 0)
                    {
                        total += product.CalculatedPrice();
                    }
                }
            }
            return total;
        }
    }
}