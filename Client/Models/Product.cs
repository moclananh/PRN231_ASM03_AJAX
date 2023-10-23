namespace Client.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public int? CategoryId { get; set; }
        public string ProductName { get; set; }
        public int Weight { get; set; }
        public int UnitPrice { get; set; }
        public int UnitInStock { get; set; }
    }
}
