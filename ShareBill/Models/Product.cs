namespace ShareBill.Models
{
    public enum SplitScheme
    {
        ByUnitAmount = 0,
        ByItemCount = 1,
        ByProportion = 2,
    }

    public class Product
    {        
        public string Name { get; set; }
        // The amount bought quantified in the unit of UnitName
        public decimal Quantity { get; set; } = 1;
        public string UnitName { get; set; } = "item";
        public decimal PricePerUnit {
            get {
                return TotalPrice / Quantity;
            }
            set {
                TotalPrice = value * Quantity;
            }
        }
        public decimal TotalPrice {
            get {
                return PricePerUnit * Quantity;
            }
            set {
                Quantity = value / PricePerUnit;
            }
        }
        // Count of individual units. Differs from Quantity. E.g. 3 apples for 2 kg, 3 is ItemCount, 2 is Quantity, kg is UnitName
        public int ItemCount { get; set; } = 1;
        public SplitScheme SplitScheme { get; set; } = SplitScheme.ByUnitAmount;

        // public Product(string name, decimal quantity, string unitName, decimal pricePerUnit, int itemCount = 1)
        // {
        //     Name = name;
        //     Quantity = quantity;
        //     UnitName = unitName;
        //     PricePerUnit = pricePerUnit;
        //     ItemCount = itemCount;
        // }

        // public List<decimal> Portions { get; set; } = [1];
        // private SplitScheme _splitScheme = SplitScheme.ByItemCount;
        // public SplitScheme SplitScheme {
        //     get {
        //         return _splitScheme;
        //     }
        //     set {
        //         _splitScheme = value;
        //         Portions = _splitScheme switch
        //         {
        //             SplitScheme.ByItemCount => [ItemCount],
        //             SplitScheme.ByUnitAmount => [Quantity],
        //             SplitScheme.ByProportion => [1],
        //             _ => throw new ArgumentException("Invalid SplitScheme"),
        //         };
        //     }
        // }
    }
} 