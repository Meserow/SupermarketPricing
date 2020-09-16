using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketPricing
{
    public class ProductCalculator : IProductCalculator
    {
        public void CalculatePromotions(List<Product> products, List<ProductPromotion> promotions)
        {

            foreach (var product in products)
            {
                var promotion = promotions.FirstOrDefault(pr => pr.Product.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase));

                if (promotion == null) continue;

                var discount = (int)(product.Quantity / promotion.MaxQuantity);

                product.PromotionDiscount = discount * promotion.PromotionPrice;

            }


        }
    }
}
