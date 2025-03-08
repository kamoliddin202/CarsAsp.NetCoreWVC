namespace CarsMVC.Models
{
    public class Order : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }
        public string ColorName { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public string ModelName { get; set; }
        public int Price { get; set; }
    }
}
