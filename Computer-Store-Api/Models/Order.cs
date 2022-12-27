namespace Computer_Store_Api.Models
{
    public class Order : BaseEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Quantity { get; set; }

    }
}
