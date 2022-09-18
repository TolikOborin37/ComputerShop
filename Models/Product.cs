namespace ComputerShop.Models
{
    public class Product
    {
        public Guid Id { get; set; } = new Guid();
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
