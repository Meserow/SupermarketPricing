using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketPricing
{
    interface IProductCalculator
    {
        void CalculatePromotions(List<Product> products, List<ProductPromotion> promotions);
    }
}
