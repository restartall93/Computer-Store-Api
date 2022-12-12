using Computer_Store_Api.Models;

namespace Computer_Store_Api.Dto
{
    public class CartDetailDto
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
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
