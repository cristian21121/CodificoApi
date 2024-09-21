namespace Models
{
    public class Product
    {
        public int Id { get; set; }

        public string ProductName { get; set; } = string.Empty;

        public int SupplierId { get; set; }

        public int CategoryId { get; set; }

        public decimal UnitPrice { get; set; }

        public bool Discontinued { get; set; }
    }
}
