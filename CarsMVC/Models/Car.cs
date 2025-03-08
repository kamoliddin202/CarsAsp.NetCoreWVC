using System.Security.Principal;

namespace CarsMVC.Models
{
    public class Car : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public List<Model> Models { get; set; }
        public List<Color> Colors { get; set; }
        public List<Order> Orders { get; set; }
    }
}
