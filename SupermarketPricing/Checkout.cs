using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace SupermarketPricing
{
    public class Checkout
    {
        public List<Product> Products { get; }
        private readonly IProductPromotions _productPromotions;
        private readonly IProductCalculator _productCalculator;

        public Checkout()
        {
            this.Products = new List<Product>();
            _productPromotions = new ProductPromotions();
            _productCalculator = new ProductCalculator();
        }

        public decimal CalculateNetTotal()
        {
            var promotions = _productPromotions.GetAllProductPromotions();
            _productCalculator.CalculatePromotions(Products, promotions);
            return Products.Sum(p =>p.Subtotal);
        }


        public bool AddProduct(Product product)
        {
            if (product == null || product.Quantity <= 0) return false;
            var existingProduct = Products.FirstOrDefault(p => p.Name.Equals(product.Name, System.StringComparison.OrdinalIgnoreCase));
            if (existingProduct != null)
            {
                existingProduct.Quantity += product.Quantity;
            }
            else
            {
                Products.Add(product);
            }

            return true;


        }

    }
}