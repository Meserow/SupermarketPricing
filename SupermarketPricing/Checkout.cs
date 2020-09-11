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
            return -1;
        }
    }
}