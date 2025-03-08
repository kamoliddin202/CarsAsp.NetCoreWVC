using CarsMVC.Data.Interfaces;
using CarsMVC.Models;

namespace CarsMVC.Data.Repasitories
{
    public class OrderRepasitory : Repasitory<Order>, IOrderInterface
    {
        public OrderRepasitory(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
