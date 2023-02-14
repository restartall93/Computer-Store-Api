namespace Computer_Store_Api.Dto
{
    public class OrderDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
    }
}
