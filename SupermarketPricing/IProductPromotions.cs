using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketPricing
{
    interface IProductPromotions
    {
        List<ProductPromotion> GetAllProductPromotions();
        ProductPromotion GetProductPromotion(string productName);
    }
}
