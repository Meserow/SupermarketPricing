using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketPricing
{
    public class ProductPromotions : IProductPromotions
    {
        public List<ProductPromotion> GetAllProductPromotions()
        {
            var promotions = new List<ProductPromotion>();
            var beans = new Product
            {
                Name = "Beans",
                Price = 1,
                Quantity = 1
            };

            var promotion = new ProductPromotion
            {
                Product = beans,
                ApplicableQuantity = 1,
                MaxQuantity = 3,
                PromotionPrice = 0

            };
            promotions.Add(promotion);

            return promotions;
        }

        public ProductPromotion GetProductPromotion(string productName)
        {
            throw new NotImplementedException();
        }
    }
}
