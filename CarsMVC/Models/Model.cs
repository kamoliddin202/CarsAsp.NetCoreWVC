namespace CarsMVC.Models
{
    public class Model : BaseEntity
    {
        public string Name { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int Price { get; set; }
    }
}
