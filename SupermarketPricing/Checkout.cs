using System.Collections.Generic;

namespace SupermarketPricing
{
    public class Checkout
    {
        public List<Product> Products { get; }

        public Checkout()
        {
            this.Products = new List<Product>();
        }

        public decimal CalculateNetTotal()
        {
            //First get products
            //Create Total
            //Loop through
                //Add price
                        
            var total = 0;
            

            for( var i =0; i < Products.Count; i++)
            {
                //quanitity o fproducts
                var quantityOfProducts = 0;

                //Check for buy two get one 
                if (Products[i].Sale == SaleType.Btgo)
                {
                    int groupOfThree = Products[i].Quantity / 3;
                    quantityOfProducts = Products[i].Quantity - groupOfThree;
                }
                //Check for buy one get one
                else if (Products[i].Sale == SaleType.Bogo)
                {
                    int grouOfTwo = Products[i].Quantity / 2;
                    quantityOfProducts = Products[i].Quantity - grouOfTwo;
                }
                //Check for No Sale
                else
                {
                    quantityOfProducts = Products[i].Quantity;
                }
              
                
                total = total + (quantityOfProducts * Products[i].Price);

            }
            
            return total;
        }
    }
}