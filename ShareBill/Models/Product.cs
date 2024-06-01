namespace ShareBill.Models
{
    public class Product
    {        
        public string Name { get; set; } = string.Empty;
        // The amount bought quantified in the unit of UnitName
        private bool _useUnit = false;
        public bool UseUnit { 
            get {
                return _useUnit;
            }
            set {
                _useUnit = value;
                if (!value)
                {
                    _unitName = "";
                    _quantity = (int)_quantity;
                    ItemCount = (int)_quantity;
                }
            }
        }
        public bool IsUsingUnit {
            get {
                return UseUnit && !string.IsNullOrEmpty(_unitName);
            }
        }
        private string _unitName = "";
        public string UnitName {
            get {
                return IsUsingUnit ? _unitName : "";
            }
            set {
                _unitName = UseUnit ? value : "";
            }
        }
        private decimal _quantity = 1;
        public decimal Quantity { 
            get {
                return _quantity;
            } 
            set {
                _quantity = value;
                if (!IsUsingUnit)
                {
                    _quantity = (int)value;
                    ItemCount = (int)value;
                }
            }
        }
        public decimal PricePerUnit { get; set; } = 1;
        public decimal TotalPrice {
            get {
                return _quantity * PricePerUnit;
            }
            set {
                PricePerUnit = value / _quantity;
            }
        }
        // Count of individual units. Differs from Quantity. E.g. 3 apples for 2 kg, 3 is ItemCount, 2 is Quantity, kg is UnitName
        public int ItemCount { get; set; } = 1;
        public static Dictionary<int, string> SplitSchemeMap { get; } = new()
        {
            { 0, "By unit amount" },
            { 1, "By item count" },
            { 2, "By percentage" },
        };
        public int SplitScheme { get; set; } = 0;
        public string PayerId { get; set; } = "0";
    }
} 