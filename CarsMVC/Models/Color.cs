namespace CarsMVC.Models
{
    public class Color : BaseEntity
    {
        public string Name { get; set; }
        public int HexCode { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public List<Image> Images { get; set; }
    }
}
