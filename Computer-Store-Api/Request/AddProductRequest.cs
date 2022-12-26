namespace Computer_Store_Api.Request
{
    public class AddProductRequest
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string Drive { get; set; }
        public string VGA { get; set; }
        public string Monitor { get; set; }
    }
}
