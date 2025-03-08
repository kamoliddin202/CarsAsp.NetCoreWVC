namespace CarsMVC.Models
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public List<Car> Cars { get; set; }
    }
}
