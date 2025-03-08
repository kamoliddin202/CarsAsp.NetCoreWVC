namespace CarsMVC.Models
{
    public class Image : BaseEntity
    {
        public string ImageUrl { get; set; }
        public int ColorId { get; set; }
        public Color Color { get; set; }
    }
}
