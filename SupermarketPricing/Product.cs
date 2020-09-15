namespace SupermarketPricing
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public SaleType Sale { get; set; }
    }

    public enum SaleType
    {
        NoSale = 0,
        Bogo = 1,
        Btgo = 2
    }
}