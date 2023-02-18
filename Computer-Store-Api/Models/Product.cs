namespace Computer_Store_Api.Models
{
    public class Product : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }
        public string ProductType { get; set; }
        public string Description { get; set; }
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string Drive { get; set; }
        public string VGA { get; set; }
        public string Monitor { get; set; }
        public string Details { get; set; }


    }
}
