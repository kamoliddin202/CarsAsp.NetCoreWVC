namespace CarsMVC.Models
{
    public class User : BaseEntity
    {
        public string Fish { get; set; }
        public string PhonrNumber { get; set; }
        public string Parol { get; set; }
        public int Manzin { get; set; }
        public List<Order> Orders { get; set; }
    }
}
