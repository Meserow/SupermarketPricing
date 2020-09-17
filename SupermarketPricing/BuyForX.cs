using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketPricing
{
    public class BuyForX : ISale
    {
        public decimal Price { get; set; }
        public decimal SaleQuantity { get; set; }

        public decimal GetSalePrice(Product product)
        {
            int qualifyingGroups = (int)(product.Quantity / SaleQuantity);

            decimal salesPrice = qualifyingGroups * Price;
            decimal regularItems = product.Quantity % SaleQuantity;
            decimal totalPrice = salesPrice + (regularItems * product.Price);
            return totalPrice;
        }
    }
}
