using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketPricing
{
    public interface ISale
    {
        decimal GetSalePrice (Product product);
    }
}
