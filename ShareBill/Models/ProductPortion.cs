namespace ShareBill.Models
{
    public class ProductPortion
    {
        public required string ProductId;
        public string OwnerId { get; set; } = string.Empty;
        public string PreviousOwnerId { get; set; } = "0";
        public decimal PortionValue { get; set; } = 1;
        // public decimal Price {
        //     get {
        //         return Product.SplitScheme switch
        //         {
        //             0 => Product.PricePerUnit * PortionValue,
        //             1 => Product.TotalPrice / Product.ItemCount * PortionValue,
        //             2 => Product.TotalPrice * PortionValue,
        //             _ => 0,
        //         };
        //     }
        // }
    }
}
