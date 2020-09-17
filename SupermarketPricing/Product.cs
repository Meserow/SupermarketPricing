namespace SupermarketPricing
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public ISale sale { get; set; }

        public decimal CalculatedPrice()
        {
            decimal calculatedPrice = 0;
            if( sale == null)
            {
                calculatedPrice = Price * Quantity;
            }
            else 
            {
                calculatedPrice = sale.GetSalePrice(this);   
            }

            return calculatedPrice;
        }
    }

    public enum saleTypes
    {
        none = 0,
        twoForOne = 1,
    }

    
}