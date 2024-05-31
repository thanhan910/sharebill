namespace ShareBill.Models
{
    public class ProductPortion
    {
        public required Product Product;
        public Person? Owner;
        public decimal PortionValue { get; set; } = 1;
        public decimal Price {
            get {
                return Product.SplitScheme switch
                {
                    SplitScheme.ByUnitAmount => Product.PricePerUnit * PortionValue,
                    SplitScheme.ByItemCount => Product.TotalPrice / Product.ItemCount * PortionValue,
                    SplitScheme.ByProportion => Product.TotalPrice * PortionValue,
                    _ => 0,
                };
            }
        }
    }
}

// public List<double> Portions { get => _portions; }
        // public Product Product { get => _product; }
        // public double TotalPrice { get => _product.TotalPrice; }
        // public int DefaultSplitPosition { get; set; } = 0;
        // public void Split(int position = -1) {
        //     if (position < 0 || position >= Portions.Count) {
        //         position = DefaultSplitPosition;
        //     }
        //     double portion = Portions[position];
        //     double value_received = 0;
        //     double value_remained = 0;
        //     if (_product.SplitScheme == SplitScheme.ByItemCount) {
        //         if (portion < 1) {
        //             return;
        //         }
        //         value_received = 1;
        //         value_remained = portion - value_received;
        //     } else if (_product.SplitScheme == SplitScheme.ByUnitAmount) {
        //         value_received = portion / 2;
        //         value_remained = portion - value_received;
        //     } else if (_product.SplitScheme == SplitScheme.ByProportion) {
        //         // Split the portion into two equal parts
        //         value_received = portion / 2;
        //         value_remained = portion - value_received;
        //     }
        //     Portions[position] = value_remained;
        //     Portions.Add(value_received);
        // }
        // public void Remove(int position) {
        //     if (position < 0 || position >= Portions.Count) {
        //         return;
        //     }
        //     double portion = Portions[position];
        //     Portions.RemoveAt(position);
        //     if (Portions.Count == 0) {
        //         Portions.Add(1);
        //     } else {
        //         Portions[0] += portion;
        //     }
        // }