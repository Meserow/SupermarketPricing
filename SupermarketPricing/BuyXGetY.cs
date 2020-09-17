using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketPricing
{
    public class BuyXGetY : ISale
    {
        public int ForFree { get; set; }
        public int QualifyingAmount { get; set; } 
        public decimal GetSalePrice(Product product)
        {
            decimal adjustedQuantity = product.Quantity;
            int discount = (int)product.Quantity / (ForFree + QualifyingAmount);
            adjustedQuantity = product.Quantity - discount;
            return adjustedQuantity * product.Price;
        }
    }
}
