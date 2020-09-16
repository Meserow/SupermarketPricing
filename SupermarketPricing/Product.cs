namespace SupermarketPricing
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public decimal PromotionDiscount { get; set; }

        public decimal Subtotal => (Price * Quantity) - PromotionDiscount;

    }
}