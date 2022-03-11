namespace NMSSpecification.Sample.InMemory.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public ProductColor Color { get; set; }
    }

    public enum ProductColor{
        Red =1,
        Blue,
        Green,
        Yellow,
        Gold,
        Silver
    }
}