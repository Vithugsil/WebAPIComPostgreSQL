namespace ConectPg.Models
{
    public class ProductModel
    {
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
        public string brand { get; set; } = string.Empty;
        public int size { get; set; }
        public int price { get; set; }
    }
}
