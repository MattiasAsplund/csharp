namespace Demo_01
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public override string ToString()
        {
            return $"{Name} costs {Price}, it's really true! ({PriceInSEK} kr)";
            
        }

        public int PriceInSEK
        {
            get { return 8 * Price; }
        }

    }
}