using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketPricing
{
    public interface ICheckout
    {

        decimal CalculateNetTotal();
        bool AddProduct(Product product);

    }
}
