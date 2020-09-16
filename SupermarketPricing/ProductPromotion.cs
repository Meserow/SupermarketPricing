using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketPricing
{
    public class ProductPromotion
    {
        public Product Product { get; set; }
        public int PromotionPrice { get; set; }
        public int MaxQuantity { get; set; }
        public int ApplicableQuantity { get; set; }


    }
}
